<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AboutModSharedDialog
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
        Me.OKButton = New System.Windows.Forms.Button()
        Me.modname = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.modauthor = New System.Windows.Forms.Label()
        Me.modurl = New System.Windows.Forms.LinkLabel()
        Me.modauthorurl = New System.Windows.Forms.LinkLabel()
        Me.SuspendLayout()
        '
        'OKButton
        '
        Me.OKButton.Location = New System.Drawing.Point(444, 280)
        Me.OKButton.Name = "OKButton"
        Me.OKButton.Size = New System.Drawing.Size(84, 36)
        Me.OKButton.TabIndex = 1
        Me.OKButton.Text = "Close"
        Me.OKButton.UseVisualStyleBackColor = True
        '
        'modname
        '
        Me.modname.AutoSize = True
        Me.modname.Location = New System.Drawing.Point(26, 42)
        Me.modname.Name = "modname"
        Me.modname.Size = New System.Drawing.Size(80, 17)
        Me.modname.TabIndex = 2
        Me.modname.Text = "{modname}"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(26, 225)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(156, 17)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Luminous Forts Toolset"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(26, 253)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(186, 17)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Copyright Hekar Khani 2010"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(26, 280)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(164, 17)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Licensed Under the GPL"
        '
        'modauthor
        '
        Me.modauthor.AutoSize = True
        Me.modauthor.Location = New System.Drawing.Point(26, 71)
        Me.modauthor.Name = "modauthor"
        Me.modauthor.Size = New System.Drawing.Size(86, 17)
        Me.modauthor.TabIndex = 6
        Me.modauthor.Text = "{modauthor}"
        '
        'modurl
        '
        Me.modurl.AutoSize = True
        Me.modurl.Cursor = System.Windows.Forms.Cursors.Hand
        Me.modurl.Location = New System.Drawing.Point(26, 98)
        Me.modurl.Name = "modurl"
        Me.modurl.Size = New System.Drawing.Size(61, 17)
        Me.modurl.TabIndex = 7
        Me.modurl.TabStop = True
        Me.modurl.Tag = "www.google.ca"
        Me.modurl.Text = "{modurl}"
        '
        'modauthorurl
        '
        Me.modauthorurl.AutoSize = True
        Me.modauthorurl.Cursor = System.Windows.Forms.Cursors.Hand
        Me.modauthorurl.Location = New System.Drawing.Point(26, 125)
        Me.modauthorurl.Name = "modauthorurl"
        Me.modauthorurl.Size = New System.Drawing.Size(93, 17)
        Me.modauthorurl.TabIndex = 8
        Me.modauthorurl.TabStop = True
        Me.modauthorurl.Tag = "www.google.ca"
        Me.modauthorurl.Text = "{modauthors}"
        '
        'AboutModSharedDialog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(540, 328)
        Me.Controls.Add(Me.modauthorurl)
        Me.Controls.Add(Me.modurl)
        Me.Controls.Add(Me.modauthor)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.modname)
        Me.Controls.Add(Me.OKButton)
        Me.Name = "AboutModSharedDialog"
        Me.Text = "{modname}"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents OKButton As System.Windows.Forms.Button
    Friend WithEvents modname As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents modauthor As System.Windows.Forms.Label
    Friend WithEvents modurl As System.Windows.Forms.LinkLabel
    Friend WithEvents modauthorurl As System.Windows.Forms.LinkLabel
End Class
