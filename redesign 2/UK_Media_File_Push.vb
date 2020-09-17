Imports System.IO


Public Class UK_Media_File_Push

    Private Sub UK_Media_File_Push_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim mystream As New StreamReader("C:\Users\kevinmorales\Documents\UK Media PC's.txt")
        Dim TempStr As String

        Do While mystream.Peek <> -1

            TempStr = mystream.ReadLine
            LB_Stations.Items.Add(TempStr)

        Loop
    End Sub

    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        OFD_Browse.Title = "Please Select Flash File"
        OFD_Browse.InitialDirectory = System.Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
        OFD_Browse.ShowDialog()

    End Sub
    Public Sub OpenFile()
        Dim myStream As Stream = Nothing
        Dim oReader As StreamReader

        
        OFD_Browse.Filter = "swf files (*.swf)|*.swf"
        OFD_Browse.FilterIndex = 2
        OFD_Browse.RestoreDirectory = True

        If OFD_Browse.ShowDialog = System.Windows.Forms.DialogResult.OK Then
            oReader = New StreamReader(OFD_Browse.FileName, True)
            txtFileSelect.Text = oReader.ReadToEnd
        End If
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()

    End Sub
    Public Sub copyFiles()

        For i As Integer = 0 To Me.LB_PCs.Items.Count - 1

            'Dim Source As String = "\\" & lvPCs.Items(i).ToString & "\c$\temp\file\"
            Try
                My.Computer.FileSystem.CopyFile(txtFileSelect.Text, "\\" & LB_PCs.Items(i).ToString & "\c$\temp\" & System.IO.Path.GetFileName(OFD_Browse.FileName), Microsoft.VisualBasic.FileIO.UIOption.AllDialogs, Microsoft.VisualBasic.FileIO.UICancelOption.DoNothing)
            Catch ex As Exception

            End Try
        Next
        MsgBox("New Media File is copied over!")
    End Sub
    Private Sub btnCopyDef_Click(sender As Object, e As EventArgs) Handles btnCopyDef.Click
        copyFiles()
        txtFileSelect.Text = ""
        LB_PCs.Items.Clear()


    End Sub

    Private Sub lvHosts_DragDrop(sender As Object, e As DragEventArgs)
        'Dim myItem As ListViewItem
        'Dim myItems() As ListViewItem = e.Data.GetData("System.Windows.Forms.ListViewItem()")
        'Dim i As Integer = 0

        'For Each myItem In myItems
        '    ' Add the item to the target list.
        '    sender.Items.Add(myItems(i).Text)
        '    ' Remove the item from the source list.
        '    If sender Is lvHosts Then
        '        lvPCs.Items.Remove(lvPCs.SelectedItems.Item(0))
        '    Else
        '        lvHosts.Items.Remove(lvHosts.SelectedItems.Item(0))
        '    End If
        '    i = i + 1
        'Next
    End Sub

    Private Sub lvHosts_DragEnter(sender As Object, e As DragEventArgs)
        ' Check for the custom DataFormat ListViewItem array.
        If e.Data.GetDataPresent("System.Windows.Forms.ListViewItem()") Then
            e.Effect = DragDropEffects.Move

        Else
            e.Effect = DragDropEffects.None
        End If
    End Sub

    Private Sub lvHosts_ItemDrag(sender As Object, e As ItemDragEventArgs)

        Dim myItem As ListViewItem
        Dim myItems(sender.SelectedItems.Count - 1) As ListViewItem
        Dim i As Integer = 0

        ' Loop though the SelectedItems collection for the source.
        For Each myItem In sender.SelectedItems
            ' Add the ListViewItem to the array of ListViewItems.
            myItems(i) = myItem
            i = i + 1
        Next
        ' Create a DataObject containg the array of ListViewItems.
        sender.DoDragDrop(New  _
        DataObject("System.Windows.Forms.ListViewItem()", myItems), _
        DragDropEffects.Move)
    End Sub

    Private Sub lvHosts_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub OFD_Browse_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles OFD_Browse.FileOk
        Dim strm As System.IO.Stream

        strm = OFD_Browse.OpenFile()

        txtFileSelect.Text = OFD_Browse.FileName.ToString()

        If Not (strm Is Nothing) Then
            'insert code to read the file data

            strm.Close()

        End If

    End Sub

    Private Sub btnMove_Click(sender As Object, e As EventArgs) Handles btnMove.Click
        Dim selecteditems = (From i In LB_Stations.SelectedItems).ToArray()

        For Each selectedItem In selecteditems
            LB_PCs.Items.Add(selectedItem)
            LB_Stations.Items.Remove(selectedItem)
        Next
    End Sub
End Class