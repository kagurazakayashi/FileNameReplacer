Imports System.IO
Imports System.Runtime.InteropServices.ComTypes
Imports System.Windows.Forms

Module DirTool
    ''' <summary>
    ''' 預覽並構建一個以日期為結構的 TreeView 目錄樹。
    ''' </summary>
    ''' <param name="TreeView1">目標 TreeView 控制元件</param>
    ''' <param name="Path">根目錄名稱</param>
    ''' <param name="startDate">起始日期</param>
    ''' <param name="endDate">結束日期</param>
    Public Sub Preview(TreeView1 As TreeView, Path As String, startDate As DateTime, endDate As DateTime)
        ' 清空 TreeView，確保資料不會累加
        TreeView1.Nodes.Clear()

        ' 建立根目錄節點
        Dim rootNode As New TreeNode(Path, 0, 0) ' 0: 代表資料夾圖示索引
        TreeView1.Nodes.Add(rootNode) ' 將根節點新增到 TreeView 控制元件中

        ' 初始化當前日期，從起始日期開始遍歷
        Dim currentDate As DateTime = startDate

        ' 遍歷給定日期範圍
        While currentDate <= endDate
            ' 按照年、月、日格式構建資料夾和檔名稱
            Dim yearFolder As String = currentDate.ToString("yyyy") ' 年資料夾（如 "2025"）
            Dim monthFolder As String = currentDate.ToString("yyyy-MM") ' 月資料夾（如 "2025-03"）
            Dim dayFile As String = currentDate.ToString("yyyy-MM-dd") & ".txt" ' 日檔案（如 "2025-03-11.txt"）

            ' 獲取或建立年級別的資料夾節點
            Dim yearNode As TreeNode = GetOrCreateNode(rootNode, yearFolder, 0) ' 0: 代表資料夾圖示
            ' 獲取或建立月級別的資料夾節點
            Dim monthNode As TreeNode = GetOrCreateNode(yearNode, monthFolder, 0) ' 0: 代表資料夾圖示

            ' 建立並新增日級別的檔案節點
            Dim fileNode As New TreeNode(dayFile, 1, 1) ' 1: 代表檔案圖示索引
            monthNode.Nodes.Add(fileNode) ' 將日檔案節點新增到月份節點下

            ' 日期遞增一天，繼續下一次迴圈
            currentDate = currentDate.AddDays(1)
        End While

        ' 展開所有節點，確保介面上能立即看到完整的結構
        TreeView1.ExpandAll()
    End Sub

    ''' <summary>
    ''' 獲取或建立指定父節點下的子節點。
    ''' </summary>
    ''' <param name="parentNode">父節點</param>
    ''' <param name="nodeName">子節點名稱</param>
    ''' <param name="imageIndex">節點圖示索引</param>
    ''' <returns>返回找到或建立的節點</returns>
    Private Function GetOrCreateNode(parentNode As TreeNode, nodeName As String, imageIndex As Integer) As TreeNode
        ' 遍歷父節點下的所有子節點，檢查是否已存在目標節點
        For Each childNode As TreeNode In parentNode.Nodes
            If childNode.Text = nodeName Then
                Return childNode ' 如果找到匹配的節點，則直接返回
            End If
        Next

        ' 如果目標節點不存在，則建立新節點並新增到父節點下
        Dim newNode As New TreeNode(nodeName, imageIndex, imageIndex)
        parentNode.Nodes.Add(newNode) ' 新增子節點
        Return newNode ' 返回新建立的節點
    End Function

    ''' <summary>
    ''' 根據提供的根目錄路徑和樹形結構節點，建立對應的年份、月份、日期資料夾，並生成對應的文字檔案。
    ''' </summary>
    ''' <param name="rootPath">存放資料夾的根路徑</param>
    ''' <param name="nodes">包含年份、月份和日期的樹形結構節點</param>
    ''' <returns>返回包含建立失敗錯誤資訊的列表，如果全部建立成功，則返回空列表。</returns>
    Public Function MakeDir(rootPath As String, nodes As TreeNode) As List(Of String)
        ' 用於儲存錯誤訊息的列表
        Dim errorMessages As New List(Of String)

        Try
            ' 遍歷樹形結構的年份節點
            For Each yearNode As TreeNode In nodes.Nodes
                ' 組合出年份資料夾的完整路徑
                Dim yearPath As String = Path.Combine(rootPath, yearNode.Text)

                ' 嘗試建立年份資料夾
                Try
                    Directory.CreateDirectory(yearPath)
                Catch ex As Exception
                    ' 如果建立失敗，記錄錯誤資訊並繼續處理下一個年份
                    errorMessages.Add("创建年份文件夹失败: " & yearPath & " - " & ex.Message)
                    Continue For
                End Try

                ' 遍歷月份節點
                For Each monthNode As TreeNode In yearNode.Nodes
                    ' 組合出月份資料夾的完整路徑
                    Dim monthPath As String = Path.Combine(yearPath, monthNode.Text)

                    ' 嘗試建立月份資料夾
                    Try
                        Directory.CreateDirectory(monthPath)
                    Catch ex As Exception
                        ' 如果建立失敗，記錄錯誤資訊並繼續處理下一個月份
                        errorMessages.Add("创建月份文件夹失败: " & monthPath & " - " & ex.Message)
                        Continue For
                    End Try

                    ' 遍歷日期節點
                    For Each dayNode As TreeNode In monthNode.Nodes
                        ' 組合出文件的完整路徑
                        Dim filePath As String = Path.Combine(monthPath, dayNode.Text)

                        ' 構造檔案內容，第一行記錄相對路徑，第二行記錄日期
                        Dim fileContent As String = $".\{yearNode.Text}\{monthNode.Text}\{dayNode.Text}" & vbCrLf &
                                $"{dayNode.Text.Replace(".txt", "")}"

                        ' 嘗試建立檔案並寫入內容
                        Try
                            File.WriteAllText(filePath, fileContent)
                        Catch ex As Exception
                            ' 如果建立失敗，記錄錯誤資訊
                            errorMessages.Add("创建文件失败: " & filePath & " - " & ex.Message)
                        End Try
                    Next
                Next
            Next

            ' 檢查是否有錯誤發生
            If errorMessages.Count > 0 Then
                ' 如果有錯誤資訊，則彈出警告訊息框
                MessageBox.Show("文件创建失败！错误已在右侧栏列出。", "失败", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                ' 如果全部建立成功，則彈出成功訊息框
                MessageBox.Show("文件创建完成！双击右侧栏中的文件/文件夹可以打开它们。", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

        Catch ex As Exception
            ' 捕獲整個過程中可能出現的嚴重錯誤
            MessageBox.Show("发生严重错误: " & ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        ' 返回錯誤資訊列表
        Return errorMessages
    End Function

End Module
