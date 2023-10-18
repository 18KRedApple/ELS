Public Class ThisAddIn
    Public isDialogOpen As Boolean = False
    Private myUserControl As MyUserControl
    Private myCustomTaskPane As Microsoft.Office.Tools.CustomTaskPane
    Private Sub ThisAddIn_Startup() Handles Me.Startup
        myUserControl = New MyUserControl
        myCustomTaskPane = Me.CustomTaskPanes.Add(myUserControl, "Els Task Pane")
        myCustomTaskPane.Visible = True
    End Sub

    Private Sub ThisAddIn_Shutdown() Handles Me.Shutdown

    End Sub
    Public Sub WriteStringToCell(ByVal formData As String)
        Me.Application.ActiveCell.Value2 = formData
    End Sub
End Class
