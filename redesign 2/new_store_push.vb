Imports System.IO


Public Class new_store_push

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub TreeView1_AfterSelect(sender As Object, e As TreeViewEventArgs)

    End Sub

    Private Sub TreeView1_DragDrop(sender As Object, e As DragEventArgs)

    End Sub

    Private Sub new_store_push_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim mystream As New StreamReader("C:\Users\kevinmorales\Documents\StorePcs.txt")
            Dim TempStr As String



            Do While mystream.Peek <> -1
                Dim LBItem As New ListBox
                TempStr = mystream.ReadLine
                ListBox1.Items.Add(TempStr)

            Loop
        Catch ex As Exception

        End Try

    End Sub

    Private Sub ListBox1_MouseDown(sender As Object, e As MouseEventArgs) Handles ListBox1.MouseDown
        If (ListBox1.Items.Count = 0) Then
            Return
        End If
        Dim index As Integer = ListBox1.IndexFromPoint(e.X, e.Y)
        Dim sourceStr As String = ListBox1.Items(index).ToString()
        Dim objDragDropEff As DragDropEffects = DoDragDrop(sourceStr, DragDropEffects.Copy)
        If objDragDropEff = DragDropEffects.Copy Then
            ListBox1.Items.RemoveAt(ListBox1.IndexFromPoint(e.X, e.Y))
        End If
    End Sub

    Private Sub ListBox2_DragDrop(sender As Object, e As DragEventArgs) Handles ListBox2.DragDrop

        If e.Data.GetDataPresent(DataFormats.StringFormat) Then
            Dim str As String = CStr(e.Data.GetData(DataFormats.StringFormat))
            ListBox2.Items.Add(str)
            e.Effect = DragDropEffects.Copy
        End If


        'Dim str As String = CStr(e.Data.GetData(DataFormats.StringFormat))
        'ListBox2.Items.Add(str)
    End Sub

    Private Sub ListBox2_DragEnter(sender As Object, e As DragEventArgs) Handles ListBox2.DragEnter
        e.Effect = DragDropEffects.All

    End Sub

End Class