<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Me.RunBtn = New System.Windows.Forms.Button()
        Me.ClearBtn = New System.Windows.Forms.Button()
        Me.PreviousBtn = New System.Windows.Forms.Button()
        Me.SaveBtn = New System.Windows.Forms.Button()
        Me.CommitBtn = New System.Windows.Forms.Button()
        Me.RefreshBtn = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'RunBtn
        '
        Me.RunBtn.ForeColor = System.Drawing.SystemColors.ControlText
        Me.RunBtn.Location = New System.Drawing.Point(118, 12)
        Me.RunBtn.Name = "RunBtn"
        Me.RunBtn.Size = New System.Drawing.Size(75, 23)
        Me.RunBtn.TabIndex = 0
        Me.RunBtn.Text = "Run"
        Me.RunBtn.UseVisualStyleBackColor = True
        '
        'ClearBtn
        '
        Me.ClearBtn.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ClearBtn.Location = New System.Drawing.Point(199, 12)
        Me.ClearBtn.Name = "ClearBtn"
        Me.ClearBtn.Size = New System.Drawing.Size(75, 23)
        Me.ClearBtn.TabIndex = 0
        Me.ClearBtn.Text = "Clear"
        Me.ClearBtn.UseVisualStyleBackColor = True
        '
        'PreviousBtn
        '
        Me.PreviousBtn.ForeColor = System.Drawing.SystemColors.ControlText
        Me.PreviousBtn.Location = New System.Drawing.Point(280, 12)
        Me.PreviousBtn.Name = "PreviousBtn"
        Me.PreviousBtn.Size = New System.Drawing.Size(75, 23)
        Me.PreviousBtn.TabIndex = 0
        Me.PreviousBtn.Text = "Previous"
        Me.PreviousBtn.UseVisualStyleBackColor = True
        '
        'SaveBtn
        '
        Me.SaveBtn.ForeColor = System.Drawing.SystemColors.ControlText
        Me.SaveBtn.Location = New System.Drawing.Point(361, 12)
        Me.SaveBtn.Name = "SaveBtn"
        Me.SaveBtn.Size = New System.Drawing.Size(75, 23)
        Me.SaveBtn.TabIndex = 0
        Me.SaveBtn.Text = "Save"
        Me.SaveBtn.UseVisualStyleBackColor = True
        '
        'CommitBtn
        '
        Me.CommitBtn.ForeColor = System.Drawing.SystemColors.ControlText
        Me.CommitBtn.Location = New System.Drawing.Point(442, 12)
        Me.CommitBtn.Name = "CommitBtn"
        Me.CommitBtn.Size = New System.Drawing.Size(75, 23)
        Me.CommitBtn.TabIndex = 0
        Me.CommitBtn.Text = "Commit"
        Me.CommitBtn.UseVisualStyleBackColor = True
        '
        'RefreshBtn
        '
        Me.RefreshBtn.ForeColor = System.Drawing.SystemColors.ControlText
        Me.RefreshBtn.Location = New System.Drawing.Point(523, 12)
        Me.RefreshBtn.Name = "RefreshBtn"
        Me.RefreshBtn.Size = New System.Drawing.Size(75, 23)
        Me.RefreshBtn.TabIndex = 0
        Me.RefreshBtn.Text = "Refresh"
        Me.RefreshBtn.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(12, 13)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 1
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(608, 46)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.RefreshBtn)
        Me.Controls.Add(Me.CommitBtn)
        Me.Controls.Add(Me.SaveBtn)
        Me.Controls.Add(Me.PreviousBtn)
        Me.Controls.Add(Me.ClearBtn)
        Me.Controls.Add(Me.RunBtn)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(624, 85)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(624, 85)
        Me.Name = "Form1"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "ELS"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents RunBtn As Windows.Forms.Button
    Friend WithEvents ClearBtn As Windows.Forms.Button
    Friend WithEvents PreviousBtn As Windows.Forms.Button
    Friend WithEvents SaveBtn As Windows.Forms.Button
    Friend WithEvents CommitBtn As Windows.Forms.Button
    Friend WithEvents RefreshBtn As Windows.Forms.Button
    Friend WithEvents TextBox1 As Windows.Forms.TextBox
End Class
