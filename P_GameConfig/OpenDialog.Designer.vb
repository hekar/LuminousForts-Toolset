<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OpenDialog
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
        Me.OpenGameConfigButton = New System.Windows.Forms.Button()
        Me.OpenAsButton = New System.Windows.Forms.Button()
        Me.CancelDialogButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'OpenGameConfigButton
        '
        Me.OpenGameConfigButton.Location = New System.Drawing.Point(13, 13)
        Me.OpenGameConfigButton.Name = "OpenGameConfigButton"
        Me.OpenGameConfigButton.Size = New System.Drawing.Size(294, 83)
        Me.OpenGameConfigButton.TabIndex = 0
        Me.OpenGameConfigButton.Text = "&Open GameConfig"
        Me.OpenGameConfigButton.UseVisualStyleBackColor = True
        '
        'OpenAsButton
        '
        Me.OpenAsButton.Location = New System.Drawing.Point(13, 103)
        Me.OpenAsButton.Name = "OpenAsButton"
        Me.OpenAsButton.Size = New System.Drawing.Size(294, 94)
        Me.OpenAsButton.TabIndex = 1
        Me.OpenAsButton.Text = "Open &As..."
        Me.OpenAsButton.UseVisualStyleBackColor = True
        '
        'CancelDialogButton
        '
        Me.CancelDialogButton.Location = New System.Drawing.Point(225, 220)
        Me.CancelDialogButton.Name = "CancelDialogButton"
        Me.CancelDialogButton.Size = New System.Drawing.Size(82, 26)
        Me.CancelDialogButton.TabIndex = 2
        Me.CancelDialogButton.Text = "&Cancel"
        Me.CancelDialogButton.UseVisualStyleBackColor = True
        '
        'OpenDialog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(319, 258)
        Me.Controls.Add(Me.CancelDialogButton)
        Me.Controls.Add(Me.OpenAsButton)
        Me.Controls.Add(Me.OpenGameConfigButton)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "OpenDialog"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "OpenDialog"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents OpenGameConfigButton As System.Windows.Forms.Button
    Friend WithEvents OpenAsButton As System.Windows.Forms.Button
    Friend WithEvents CancelDialogButton As System.Windows.Forms.Button
End Class
