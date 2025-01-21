Imports System.IO

Module UIAction
    ''' <summary>
    ''' 檢查使用者輸入的資料夾路徑是否正確
    ''' </summary>
    ''' <param name="folderPath">資料夾路徑</param>
    ''' <returns>是否正確</returns>
    Public Function ChkDirInput(folderPath As String) As Boolean
        ' 檢查路徑是否合法
        If String.IsNullOrWhiteSpace(folderPath) Then
            MessageBox.Show("无效的路径输入！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If
        Try
            ' 檢查資料夾是否存在
            If Directory.Exists(folderPath) Then
                'MessageBox.Show("文件夹已存在: " & folderPath, "文件夹", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                ' 嘗試建立資料夾
                Directory.CreateDirectory(folderPath)
                'MessageBox.Show("文件夹已成功创建: " & folderPath, "文件夹", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            Return True
        Catch ex As Exception
            MessageBox.Show("创建文件夹时出错: " & ex.Message, "文件夹错误", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    ''' <summary>
    ''' 檢查使用者輸入的日期是否正確
    ''' </summary>
    ''' <param name="startDate">起始日期</param>
    ''' <param name="endDate">結束日期</param>
    ''' <returns>是否正確</returns>
    Public Function ChkDateInput(startDate As DateTime, endDate As DateTime) As Boolean
        If startDate > endDate Then
            MessageBox.Show("起始日期不能大于结束日期！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If
        Return True
    End Function

    ''' <summary>
    ''' 計算 TreeView 控制元件中所有節點（包括子節點）的總數。
    ''' </summary>
    ''' <param name="treeView">要計算的 TreeView 控制元件。</param>
    ''' <returns>返回該 TreeView 中所有節點（包括子節點）的總數量。</returns>
    Public Function GetTreeViewItemCount(treeView As TreeView) As Integer
        ' 初始化節點計數器
        Dim count As Integer = 0

        ' 遍歷 TreeView 控制元件的所有頂級節點（一級節點）
        For Each node As TreeNode In treeView.Nodes
            ' 呼叫遞迴方法，計算該節點及其子節點的總數量
            count += GetNodeCount(node)
        Next

        ' 返回計算出的總節點數
        Return count
    End Function

    ''' <summary>
    ''' 遞迴計算指定節點及其所有子節點的數量。
    ''' </summary>
    ''' <param name="node">要計算的起始 TreeNode 節點。</param>
    ''' <returns>返回該節點及其所有子節點的總數量。</returns>
    Private Function GetNodeCount(node As TreeNode) As Integer
        ' 計入當前節點自身
        Dim count As Integer = 1

        ' 遍歷當前節點的所有子節點
        For Each child As TreeNode In node.Nodes
            ' 遞迴計算子節點的數量，並累加
            count += GetNodeCount(child)
        Next

        ' 返回該節點及其所有子節點的總數量
        Return count
    End Function

End Module
