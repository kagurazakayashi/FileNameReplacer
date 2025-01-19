Imports System.IO
Imports System.Runtime.InteropServices.ComTypes
Imports System.Windows.Forms

Module DirTool
    Public Sub Preview(TreeView1 As TreeView, Path As String, startDate As DateTime, endDate As DateTime)
        ' 清空 TreeView
        TreeView1.Nodes.Clear()
        ' 根目錄節點
        Dim rootNode As New TreeNode(Path, 0, 0) ' 0: 資料夾圖示
        TreeView1.Nodes.Add(rootNode)

        ' 遍历日期范围
        Dim currentDate As DateTime = startDate
        While currentDate <= endDate
            Dim yearFolder As String = currentDate.ToString("yyyy")
            Dim monthFolder As String = currentDate.ToString("yyyy-MM")
            Dim dayFile As String = currentDate.ToString("yyyy-MM-dd") & ".txt"

            ' 获取或创建年节点
            Dim yearNode As TreeNode = GetOrCreateNode(rootNode, yearFolder, 0) ' 0: 文件夹图标
            ' 获取或创建月节点
            Dim monthNode As TreeNode = GetOrCreateNode(yearNode, monthFolder, 0) ' 0: 文件夹图标
            ' 添加日文件节点
            Dim fileNode As New TreeNode(dayFile, 1, 1) ' 1: 文件图标
            monthNode.Nodes.Add(fileNode)

            ' 递增日期
            currentDate = currentDate.AddDays(1)
        End While

        ' 展开所有节点
        TreeView1.ExpandAll()
    End Sub

    ' 获取或创建 TreeView 节点，并设置对应的图标
    Private Function GetOrCreateNode(parentNode As TreeNode, nodeName As String, imageIndex As Integer) As TreeNode
        For Each node As TreeNode In parentNode.Nodes
            If node.Text = nodeName Then
                Return node
            End If
        Next
        Dim newNode As New TreeNode(nodeName, imageIndex, imageIndex) ' 设置图标
        parentNode.Nodes.Add(newNode)
        Return newNode
    End Function

End Module
