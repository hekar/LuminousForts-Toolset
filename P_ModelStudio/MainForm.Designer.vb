<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Me.MainSplit = New System.Windows.Forms.SplitContainer()
        Me.TextBox = New System.Windows.Forms.TextBox()
        Me.ArgSwitchList = New System.Windows.Forms.CheckedListBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CustomArguments = New System.Windows.Forms.TextBox()
        Me.TextureOverride = New System.Windows.Forms.TextBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OptionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStrip = New System.Windows.Forms.ToolStrip()
        Me.CompileToolButton = New System.Windows.Forms.ToolStripButton()
        CType(Me.MainSplit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MainSplit.Panel1.SuspendLayout()
        Me.MainSplit.Panel2.SuspendLayout()
        Me.MainSplit.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.ToolStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'MainSplit
        '
        Me.MainSplit.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MainSplit.FixedPanel = System.Windows.Forms.FixedPanel.Panel2
        Me.MainSplit.Location = New System.Drawing.Point(0, 24)
        Me.MainSplit.Margin = New System.Windows.Forms.Padding(2)
        Me.MainSplit.Name = "MainSplit"
        '
        'MainSplit.Panel1
        '
        Me.MainSplit.Panel1.Controls.Add(Me.TextBox)
        '
        'MainSplit.Panel2
        '
        Me.MainSplit.Panel2.Controls.Add(Me.ArgSwitchList)
        Me.MainSplit.Panel2.Controls.Add(Me.Label3)
        Me.MainSplit.Panel2.Controls.Add(Me.Label2)
        Me.MainSplit.Panel2.Controls.Add(Me.Label1)
        Me.MainSplit.Panel2.Controls.Add(Me.CustomArguments)
        Me.MainSplit.Panel2.Controls.Add(Me.TextureOverride)
        Me.MainSplit.Size = New System.Drawing.Size(733, 478)
        Me.MainSplit.SplitterDistance = 402
        Me.MainSplit.SplitterWidth = 3
        Me.MainSplit.TabIndex = 1
        '
        'TextBox
        '
        Me.TextBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBox.Location = New System.Drawing.Point(0, 0)
        Me.TextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBox.Multiline = True
        Me.TextBox.Name = "TextBox"
        Me.TextBox.Size = New System.Drawing.Size(402, 478)
        Me.TextBox.TabIndex = 0
        '
        'ArgSwitchList
        '
        Me.ArgSwitchList.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ArgSwitchList.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ArgSwitchList.FormattingEnabled = True
        Me.ArgSwitchList.Location = New System.Drawing.Point(6, 33)
        Me.ArgSwitchList.Margin = New System.Windows.Forms.Padding(2)
        Me.ArgSwitchList.Name = "ArgSwitchList"
        Me.ArgSwitchList.Size = New System.Drawing.Size(235, 184)
        Me.ArgSwitchList.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 17)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(43, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Options"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 329)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(95, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Custom Arguments"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 268)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Override Texture"
        '
        'CustomArguments
        '
        Me.CustomArguments.Location = New System.Drawing.Point(6, 348)
        Me.CustomArguments.Margin = New System.Windows.Forms.Padding(2)
        Me.CustomArguments.Name = "CustomArguments"
        Me.CustomArguments.Size = New System.Drawing.Size(235, 20)
        Me.CustomArguments.TabIndex = 2
        Me.CustomArguments.Tag = ""
        '
        'TextureOverride
        '
        Me.TextureOverride.Location = New System.Drawing.Point(6, 287)
        Me.TextureOverride.Margin = New System.Windows.Forms.Padding(2)
        Me.TextureOverride.Name = "TextureOverride"
        Me.TextureOverride.Size = New System.Drawing.Size(235, 20)
        Me.TextureOverride.TabIndex = 1
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.OptionsToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(4, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(733, 24)
        Me.MenuStrip1.TabIndex = 2
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(92, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'OptionsToolStripMenuItem
        '
        Me.OptionsToolStripMenuItem.Name = "OptionsToolStripMenuItem"
        Me.OptionsToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.OptionsToolStripMenuItem.Text = "Options"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'ToolStrip
        '
        Me.ToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CompileToolButton})
        Me.ToolStrip.Location = New System.Drawing.Point(0, 24)
        Me.ToolStrip.Name = "ToolStrip"
        Me.ToolStrip.Size = New System.Drawing.Size(733, 25)
        Me.ToolStrip.TabIndex = 3
        Me.ToolStrip.Text = "ToolStrip1"
        '
        'CompileToolButton
        '
        Me.CompileToolButton.Image = Global.P_ModelStudio.My.Resources.Resources.gear
        Me.CompileToolButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.CompileToolButton.Name = "CompileToolButton"
        Me.CompileToolButton.Size = New System.Drawing.Size(72, 22)
        Me.CompileToolButton.Text = "Compile"
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(733, 502)
        Me.Controls.Add(Me.ToolStrip)
        Me.Controls.Add(Me.MainSplit)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MinimumSize = New System.Drawing.Size(574, 445)
        Me.Name = "MainForm"
        Me.Text = "Model Studio"
        Me.MainSplit.Panel1.ResumeLayout(False)
        Me.MainSplit.Panel1.PerformLayout()
        Me.MainSplit.Panel2.ResumeLayout(False)
        Me.MainSplit.Panel2.PerformLayout()
        CType(Me.MainSplit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MainSplit.ResumeLayout(False)
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ToolStrip.ResumeLayout(False)
        Me.ToolStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MainSplit As System.Windows.Forms.SplitContainer
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CustomArguments As System.Windows.Forms.TextBox
    Friend WithEvents TextureOverride As System.Windows.Forms.TextBox
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ArgSwitchList As System.Windows.Forms.CheckedListBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TextBox As System.Windows.Forms.TextBox
    Friend WithEvents ToolStrip As System.Windows.Forms.ToolStrip
    Friend WithEvents CompileToolButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents OptionsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
