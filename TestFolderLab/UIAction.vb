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
End Module
