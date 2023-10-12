Imports Microsoft.Office.Tools.Ribbon

Public Class Ribbon1
    Private isDialogOpen As Boolean = False
    Private Sub Ribbon1_Load(ByVal sender As System.Object, ByVal e As RibbonUIEventArgs) Handles MyBase.Load

    End Sub

    Private Sub RunTooboxBtn_Click(sender As Object, e As RibbonControlEventArgs) Handles RunTooboxBtn.Click
        Dim dialog As New Form1()
        dialog.Show()
    End Sub
End Class
