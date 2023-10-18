<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MyUserControl
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.ModelListBox = New System.Windows.Forms.ListBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GetModelRefreshBtn = New System.Windows.Forms.Button()
        Me.ModelTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.QueryListBox = New System.Windows.Forms.ListBox()
        Me.QueryTextBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.RunBtn = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'ModelListBox
        '
        Me.ModelListBox.FormattingEnabled = True
        Me.ModelListBox.Location = New System.Drawing.Point(10, 19)
        Me.ModelListBox.Name = "ModelListBox"
        Me.ModelListBox.Size = New System.Drawing.Size(168, 95)
        Me.ModelListBox.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GetModelRefreshBtn)
        Me.GroupBox1.Controls.Add(Me.ModelListBox)
        Me.GroupBox1.Location = New System.Drawing.Point(14, 16)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(191, 162)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Model List"
        '
        'GetModelRefreshBtn
        '
        Me.GetModelRefreshBtn.Location = New System.Drawing.Point(103, 127)
        Me.GetModelRefreshBtn.Name = "GetModelRefreshBtn"
        Me.GetModelRefreshBtn.Size = New System.Drawing.Size(75, 23)
        Me.GetModelRefreshBtn.TabIndex = 4
        Me.GetModelRefreshBtn.Text = "Refresh"
        Me.GetModelRefreshBtn.UseVisualStyleBackColor = True
        '
        'ModelTextBox
        '
        Me.ModelTextBox.Location = New System.Drawing.Point(105, 202)
        Me.ModelTextBox.Name = "ModelTextBox"
        Me.ModelTextBox.Size = New System.Drawing.Size(100, 20)
        Me.ModelTextBox.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(21, 205)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Selected Model"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.QueryListBox)
        Me.GroupBox2.Controls.Add(Me.QueryTextBox)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Location = New System.Drawing.Point(14, 228)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(191, 198)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Query List"
        '
        'QueryListBox
        '
        Me.QueryListBox.FormattingEnabled = True
        Me.QueryListBox.Location = New System.Drawing.Point(10, 19)
        Me.QueryListBox.Name = "QueryListBox"
        Me.QueryListBox.Size = New System.Drawing.Size(168, 95)
        Me.QueryListBox.TabIndex = 0
        '
        'QueryTextBox
        '
        Me.QueryTextBox.Location = New System.Drawing.Point(11, 158)
        Me.QueryTextBox.Name = "QueryTextBox"
        Me.QueryTextBox.Size = New System.Drawing.Size(167, 20)
        Me.QueryTextBox.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 133)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Selected Query"
        '
        'RunBtn
        '
        Me.RunBtn.Location = New System.Drawing.Point(117, 442)
        Me.RunBtn.Name = "RunBtn"
        Me.RunBtn.Size = New System.Drawing.Size(75, 23)
        Me.RunBtn.TabIndex = 4
        Me.RunBtn.Text = "Run"
        Me.RunBtn.UseVisualStyleBackColor = True
        '
        'MyUserControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.RunBtn)
        Me.Controls.Add(Me.ModelTextBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "MyUserControl"
        Me.Size = New System.Drawing.Size(221, 480)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ModelListBox As Windows.Forms.ListBox
    Friend WithEvents GroupBox1 As Windows.Forms.GroupBox
    Friend WithEvents ModelTextBox As Windows.Forms.TextBox
    Friend WithEvents Label1 As Windows.Forms.Label
    Friend WithEvents GroupBox2 As Windows.Forms.GroupBox
    Friend WithEvents QueryListBox As Windows.Forms.ListBox
    Friend WithEvents Label2 As Windows.Forms.Label
    Friend WithEvents QueryTextBox As Windows.Forms.TextBox
    Friend WithEvents RunBtn As Windows.Forms.Button
    Friend WithEvents GetModelRefreshBtn As Windows.Forms.Button
End Class
