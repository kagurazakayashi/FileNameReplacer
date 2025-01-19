Imports System.IO

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' 設定 DateTimePicker1 的值為去年的第一天
        DateTimePicker1.Value = New DateTime(DateTime.Now.Year - 1, 1, 1)
        ' 設定 DateTimePicker2 的值為今年的最後一天
        DateTimePicker2.Value = New DateTime(DateTime.Now.Year, 12, 31)
        ' 獲取所有磁碟機代號並轉換為字串陣列
        Dim driveLetters As String() = DriveInfo.GetDrives().Select(Function(d) d.Name).ToArray()
        ' 获取当前日期时间并格式化
        Dim currentDateTime As String = DateTime.Now.ToString("yyyyMMddHHmmss")
        ' 輸出磁碟機代號
        For Each drive In driveLetters
            ComboBox1.Items.Add(drive + "TestFolder" + currentDateTime)
        Next
        If ComboBox1.Items.Count > 1 Then
            ComboBox1.SelectedIndex = 0
        End If
        Preview()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If Not Preview() Then
            Return
        End If
    End Sub

    Private Function Preview()
        ' 檢查路徑是否合法
        If Not UIAction.ChkDirInput(ComboBox1.Text) Then
            Return False
        End If
        ' 檢查使用者輸入的日期是否正確
        If Not UIAction.ChkDateInput(DateTimePicker1.Value, DateTimePicker2.Value) Then
            Return False
        End If
        DirTool.Preview(TreeView1, ComboBox1.Text, DateTimePicker1.Value, DateTimePicker2.Value)
        Return True
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If FolderBrowserDialog1.ShowDialog() = DialogResult.OK Then
            ' 獲取使用者選擇的資料夾路徑
            ComboBox1.Text = FolderBrowserDialog1.SelectedPath
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Preview()
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        ListBox1.Items.Clear()
        ListBox1.Visible = False
    End Sub

    Private Sub ListBox1_Click(sender As Object, e As EventArgs) Handles ListBox1.Click
        ListBox1.Items.Clear()
        ListBox1.Visible = False
    End Sub
End Class
