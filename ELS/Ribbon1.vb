Imports Microsoft.Office.Tools.Ribbon
Imports Excel = Microsoft.Office.Interop.Excel
Imports Microsoft.Office.Tools.Excel

Public Class Ribbon1

    Private Sub Ribbon1_Load(ByVal sender As System.Object, ByVal e As RibbonUIEventArgs) Handles MyBase.Load

    End Sub

    Private Sub RunTooboxBtn_Click(sender As Object, e As RibbonControlEventArgs) Handles RunTooboxBtn.Click
        If Not Globals.ThisAddIn.isDialogOpen Then
            Dim dialog As New Form1()
            dialog.Show()
            Globals.ThisAddIn.isDialogOpen = True
        End If
    End Sub
End Class
