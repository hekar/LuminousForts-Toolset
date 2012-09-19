<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FileSearchForm
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
        Me.CancelBut = New System.Windows.Forms.Button()
        Me.filename = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'CancelButton
        '
        Me.CancelBut.Location = New System.Drawing.Point(305, 22)
        Me.CancelBut.Name = "CancelButton"
        Me.CancelBut.Size = New System.Drawing.Size(75, 26)
        Me.CancelBut.TabIndex = 1
        Me.CancelBut.Text = "Cancel"
        Me.CancelBut.UseVisualStyleBackColor = True
        '
        'filename
        '
        Me.filename.AutoSize = True
        Me.filename.Location = New System.Drawing.Point(12, 27)
        Me.filename.Name = "filename"
        Me.filename.Size = New System.Drawing.Size(71, 17)
        Me.filename.TabIndex = 2
        Me.filename.Text = "{filename}"
        '
        'FileSearchForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(402, 77)
        Me.Controls.Add(Me.filename)
        Me.Controls.Add(Me.CancelBut)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "FileSearchForm"
        Me.Text = "Searching..."
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CancelBut As System.Windows.Forms.Button
    Friend WithEvents filename As System.Windows.Forms.Label
End Class
