Imports System
Imports System.Diagnostics
Imports System.Threading
Imports System.IO
Imports System.Windows.Forms
Public Class MyUserControl
    Private elapsedTime As Integer
    Private eventHandled As Boolean
    Public Event Exited As EventHandler
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click, Label2.Click

    End Sub

    Private Sub MyUserControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        QueryListBox.Items.Add("average sale price")
        QueryListBox.Items.Add("top 10 sales")
        QueryListBox.Items.Add("total sales")
        QueryListBox.Items.Add("list the column names")
        QueryListBox.Items.Add("list the total rows")
    End Sub

    Private Sub ModelListBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ModelListBox.SelectedIndexChanged
        ModelTextBox.Text = ModelListBox.SelectedItem.ToString()
    End Sub

    Private Sub QueryListBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles QueryListBox.SelectedIndexChanged
        QueryTextBox.Text = QueryListBox.SelectedItem.ToString()
    End Sub

    Private Sub GetModelRefreshBtn_Click(sender As Object, e As EventArgs) Handles GetModelRefreshBtn.Click
        GetModelRefreshBtn.Enabled = False
        elapsedTime = 0
        eventHandled = False
        Dim sOutput As String
        Dim separator As Char = ":"
        Dim pythonProcess As New Process()
        Dim pythonPath As String = Path.Combine(Path.GetTempPath(), "python.exe")
        Dim scriptPath As String = Path.Combine(Path.GetTempPath(), "test.py")
        Dim pythonStartInfo As New ProcessStartInfo("c:\Program Files\python39\python.exe", "d:\work\VB\addin\ELS\ELS\bin\Debug\test.py")
        pythonStartInfo.UseShellExecute = False
        pythonStartInfo.RedirectStandardOutput = True
        pythonProcess.StartInfo = pythonStartInfo
        pythonStartInfo.CreateNoWindow = True
        pythonProcess.Start()
        System.Threading.Thread.Sleep(3000)
        Using pythonStreamReader As System.IO.StreamReader = pythonProcess.StandardOutput
            sOutput = pythonStreamReader.ReadLine()
        End Using
        ModelListBox.Items.Clear()
        Dim substrings() As String = sOutput.Split(separator)
        Dim subModelStingList As New List(Of String)(substrings)
        For Each substring As String In subModelStingList
            If String.IsNullOrEmpty(substring) Then
                Continue For
            Else
                ModelListBox.Items.Add(substring)
            End If
        Next
        GetModelRefreshBtn.Enabled = True
    End Sub
End Class
