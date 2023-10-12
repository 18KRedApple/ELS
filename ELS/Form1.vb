Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Form1_Cancel(sender As Object, e As EventArgs) Handles MyBase.Closed
        Globals.ThisAddIn.isDialogOpen = False
    End Sub

    Private Sub RunBtn_Click(sender As Object, e As EventArgs) Handles RunBtn.Click
        Globals.ThisAddIn.WriteStringToCell(Me.TextBox1.Text)
    End Sub
End Class