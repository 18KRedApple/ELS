Public Class ThisAddIn
    Public isDialogOpen As Boolean = False
    Private Sub ThisAddIn_Startup() Handles Me.Startup
    End Sub

    Private Sub ThisAddIn_Shutdown() Handles Me.Shutdown

    End Sub
    Public Sub WriteStringToCell(ByVal formData As String)
        Me.Application.ActiveCell.Value2 = formData
    End Sub
End Class
