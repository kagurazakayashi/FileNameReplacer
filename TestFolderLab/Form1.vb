Imports System.IO

Public Class Form1
    ''' <summary>
    ''' 窗體載入事件，在窗體初始化時執行。
    ''' 設定日期選擇器的預設值，並填充磁碟驅動器資訊到下拉框。
    ''' </summary>
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' 設定 DateTimePicker1 的值為去年的第一天
        DateTimePicker1.Value = New DateTime(DateTime.Now.Year - 1, 1, 1)
        ' 設定 DateTimePicker2 的值為今年的最後一天
        DateTimePicker2.Value = New DateTime(DateTime.Now.Year, 12, 31)

        ' 獲取所有磁碟驅動器的名稱，並轉換為字串陣列
        Dim driveLetters As String() = DriveInfo.GetDrives().Select(Function(d) d.Name).ToArray()

        ' 獲取當前日期時間，並格式化為字串（格式：yyyyMMddHHmmss）
        Dim currentDateTime As String = DateTime.Now.ToString("yyyyMMddHHmmss")

        ' 遍歷磁碟驅動器，將其名稱和測試資料夾路徑新增到 ComboBox1
        For Each drive In driveLetters
            ComboBox1.Items.Add(drive + "TestFolder" + currentDateTime)
        Next

        ' 如果下拉框中至少有一個選項，則選中第一個選項
        If ComboBox1.Items.Count > 1 Then
            ComboBox1.SelectedIndex = 0
        End If

        ' 呼叫 Preview 方法進行預覽
        Preview()
    End Sub

    ''' <summary>
    ''' 處理按鈕 Button2 的點選事件。
    ''' 在預覽成功後，建立目錄並顯示錯誤資訊（如果有）。
    ''' </summary>
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ' 先進行預覽，如果失敗則返回
        If Not Preview() Then
            Return
        End If

        ' 呼叫 DirTool.MakeDir 建立目錄，並接收可能的錯誤資訊
        Dim errorMessages As List(Of String) = DirTool.MakeDir(ComboBox1.Text, TreeView1.Nodes(0))

        ' 如果存在錯誤資訊，則顯示在 ListBox1 中
        If errorMessages.Count > 0 Then
            ListBox1.Items.Clear()
            ListBox1.Visible = True
            For Each msg As String In errorMessages
                ListBox1.Items.Add(msg)
            Next
        End If
    End Sub

    ''' <summary>
    ''' 預覽功能，檢查目錄輸入和日期輸入是否合法，並在 TreeView 中顯示預覽結果。
    ''' </summary>
    ''' <returns>如果預覽成功返回 True，否則返回 False。</returns>
    Private Function Preview()
        ' 檢查路徑是否合法
        If Not UIAction.ChkDirInput(ComboBox1.Text) Then
            Return False
        End If

        ' 檢查使用者輸入的日期是否合法
        If Not UIAction.ChkDateInput(DateTimePicker1.Value, DateTimePicker2.Value) Then
            Return False
        End If

        ' 呼叫 DirTool.Preview 生成預覽
        DirTool.Preview(TreeView1, ComboBox1.Text, DateTimePicker1.Value, DateTimePicker2.Value)

        ' 如果 TreeView 有節點，則選中第一個根節點並滾動到頂部
        If TreeView1.Nodes.Count > 0 Then
            TreeView1.SelectedNode = TreeView1.Nodes(0) ' 選中第一根節點
            TreeView1.TopNode = TreeView1.Nodes(0) ' 滾動到頂部
        End If

        Return True
    End Function

    ''' <summary>
    ''' 處理按鈕 Button1 的點選事件。
    ''' 開啟資料夾選擇對話方塊，並將選擇的資料夾路徑設定到 ComboBox1。
    ''' </summary>
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If FolderBrowserDialog1.ShowDialog() = DialogResult.OK Then
            ' 獲取使用者選擇的資料夾路徑，並更新 ComboBox1
            ComboBox1.Text = FolderBrowserDialog1.SelectedPath
        End If
    End Sub

    ''' <summary>
    ''' 處理按鈕 Button3 的點選事件。
    ''' 觸發預覽操作。
    ''' </summary>
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Preview()
    End Sub

    ''' <summary>
    ''' 處理 ListBox1 專案選中事件。
    ''' 清除所有專案，並隱藏 ListBox1。
    ''' </summary>
    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        ListBox1.Items.Clear()
        ListBox1.Visible = False
    End Sub

    ''' <summary>
    ''' 處理 ListBox1 點選事件。
    ''' 清除所有專案，並隱藏 ListBox1。
    ''' </summary>
    Private Sub ListBox1_Click(sender As Object, e As EventArgs) Handles ListBox1.Click
        ListBox1.Items.Clear()
        ListBox1.Visible = False
    End Sub

    Private Sub TreeView1_NodeMouseDoubleClick(sender As Object, e As TreeNodeMouseClickEventArgs) Handles TreeView1.NodeMouseDoubleClick
        Dim rootPath As String = ComboBox1.Text
        If String.IsNullOrWhiteSpace(rootPath) Then
            'MessageBox.Show("请选择根目录！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' 获取选中的节点
        Dim selectedNode As TreeNode = e.Node
        If selectedNode Is Nothing Then Exit Sub

        ' 计算完整路径
        Dim fullPath As String = Path.Combine(rootPath, selectedNode.FullPath)

        ' 判断是文件还是文件夹，并执行相应操作
        If Directory.Exists(fullPath) Then
            ' 如果是文件夹，打开文件夹
            Try
                Process.Start("explorer.exe", fullPath)
            Catch ex As Exception
                'MessageBox.Show("无法打开文件夹: " & fullPath & vbCrLf & "错误: " & ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        ElseIf File.Exists(fullPath) Then
            ' 如果是文件，打开文件
            Try
                Process.Start(fullPath)
            Catch ex As Exception
                'MessageBox.Show("无法打开文件: " & fullPath & vbCrLf & "错误: " & ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        Else
            'MessageBox.Show("文件或文件夹不存在: " & fullPath, "错误", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub
End Class
