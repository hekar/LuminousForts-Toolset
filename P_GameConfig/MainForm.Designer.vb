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
        Me.menubar = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveAsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SettingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddLuminousfortsEntryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OptionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FullAboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolbar = New System.Windows.Forms.ToolStrip()
        Me.OpenStripButton = New System.Windows.Forms.ToolStripButton()
        Me.SaveStripButton = New System.Windows.Forms.ToolStripButton()
        Me.SaveAsStripButton = New System.Windows.Forms.ToolStripButton()
        Me.AboutStripButton = New System.Windows.Forms.ToolStripButton()
        Me.openfiledialog = New System.Windows.Forms.OpenFileDialog()
        Me.savefiledialog = New System.Windows.Forms.SaveFileDialog()
        Me.TextBox = New ScintillaNet.Scintilla()
        Me.menubar.SuspendLayout()
        Me.toolbar.SuspendLayout()
        CType(Me.TextBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'menubar
        '
        Me.menubar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.SettingsToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.menubar.Location = New System.Drawing.Point(0, 0)
        Me.menubar.Name = "menubar"
        Me.menubar.Size = New System.Drawing.Size(589, 28)
        Me.menubar.TabIndex = 0
        Me.menubar.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpenToolStripMenuItem, Me.SaveToolStripMenuItem, Me.SaveAsToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(44, 24)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'OpenToolStripMenuItem
        '
        Me.OpenToolStripMenuItem.Image = Global.P_GameConfig.My.Resources.Resources.fileopen
        Me.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem"
        Me.OpenToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
        Me.OpenToolStripMenuItem.Size = New System.Drawing.Size(219, 24)
        Me.OpenToolStripMenuItem.Text = "&Open..."
        '
        'SaveToolStripMenuItem
        '
        Me.SaveToolStripMenuItem.Image = Global.P_GameConfig.My.Resources.Resources.filesave
        Me.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
        Me.SaveToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.SaveToolStripMenuItem.Size = New System.Drawing.Size(219, 24)
        Me.SaveToolStripMenuItem.Text = "&Save"
        '
        'SaveAsToolStripMenuItem
        '
        Me.SaveAsToolStripMenuItem.Image = Global.P_GameConfig.My.Resources.Resources.filesaveas
        Me.SaveAsToolStripMenuItem.Name = "SaveAsToolStripMenuItem"
        Me.SaveAsToolStripMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
                    Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.SaveAsToolStripMenuItem.Size = New System.Drawing.Size(219, 24)
        Me.SaveAsToolStripMenuItem.Text = "S&ave As"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Image = Global.P_GameConfig.My.Resources.Resources._exit
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Q), System.Windows.Forms.Keys)
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(219, 24)
        Me.ExitToolStripMenuItem.Text = "E&xit"
        '
        'SettingsToolStripMenuItem
        '
        Me.SettingsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddLuminousfortsEntryToolStripMenuItem, Me.OptionsToolStripMenuItem})
        Me.SettingsToolStripMenuItem.Name = "SettingsToolStripMenuItem"
        Me.SettingsToolStripMenuItem.Size = New System.Drawing.Size(74, 24)
        Me.SettingsToolStripMenuItem.Text = "&Settings"
        '
        'AddLuminousfortsEntryToolStripMenuItem
        '
        Me.AddLuminousfortsEntryToolStripMenuItem.Image = Global.P_GameConfig.My.Resources.Resources.add
        Me.AddLuminousfortsEntryToolStripMenuItem.Name = "AddLuminousfortsEntryToolStripMenuItem"
        Me.AddLuminousfortsEntryToolStripMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Alt) _
                    Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
        Me.AddLuminousfortsEntryToolStripMenuItem.Size = New System.Drawing.Size(259, 24)
        Me.AddLuminousfortsEntryToolStripMenuItem.Text = "&Add Mod Entry"
        '
        'OptionsToolStripMenuItem
        '
        Me.OptionsToolStripMenuItem.Image = Global.P_GameConfig.My.Resources.Resources.tool
        Me.OptionsToolStripMenuItem.Name = "OptionsToolStripMenuItem"
        Me.OptionsToolStripMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Alt) _
                    Or System.Windows.Forms.Keys.P), System.Windows.Forms.Keys)
        Me.OptionsToolStripMenuItem.Size = New System.Drawing.Size(259, 24)
        Me.OptionsToolStripMenuItem.Text = "&Options"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem, Me.FullAboutToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(53, 24)
        Me.HelpToolStripMenuItem.Text = "&Help"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Image = Global.P_GameConfig.My.Resources.Resources.help_contents
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(251, 24)
        Me.AboutToolStripMenuItem.Text = "&About"
        '
        'FullAboutToolStripMenuItem
        '
        Me.FullAboutToolStripMenuItem.Image = Global.P_GameConfig.My.Resources.Resources.help_hint
        Me.FullAboutToolStripMenuItem.Name = "FullAboutToolStripMenuItem"
        Me.FullAboutToolStripMenuItem.Size = New System.Drawing.Size(251, 24)
        Me.FullAboutToolStripMenuItem.Text = "A&bout {modname} Toolkit"
        '
        'toolbar
        '
        Me.toolbar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpenStripButton, Me.SaveStripButton, Me.SaveAsStripButton, Me.AboutStripButton})
        Me.toolbar.Location = New System.Drawing.Point(0, 28)
        Me.toolbar.Name = "toolbar"
        Me.toolbar.Size = New System.Drawing.Size(589, 27)
        Me.toolbar.TabIndex = 2
        Me.toolbar.Text = "ToolStrip1"
        '
        'OpenStripButton
        '
        Me.OpenStripButton.Image = Global.P_GameConfig.My.Resources.Resources.fileopen
        Me.OpenStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.OpenStripButton.Name = "OpenStripButton"
        Me.OpenStripButton.Size = New System.Drawing.Size(74, 24)
        Me.OpenStripButton.Text = "&Open..."
        '
        'SaveStripButton
        '
        Me.SaveStripButton.Image = Global.P_GameConfig.My.Resources.Resources.filesave
        Me.SaveStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.SaveStripButton.Name = "SaveStripButton"
        Me.SaveStripButton.Size = New System.Drawing.Size(60, 24)
        Me.SaveStripButton.Text = "S&ave"
        '
        'SaveAsStripButton
        '
        Me.SaveAsStripButton.Image = Global.P_GameConfig.My.Resources.Resources.filesaveas
        Me.SaveAsStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.SaveAsStripButton.Name = "SaveAsStripButton"
        Me.SaveAsStripButton.Size = New System.Drawing.Size(80, 24)
        Me.SaveAsStripButton.Text = "Sa&ve As"
        '
        'AboutStripButton
        '
        Me.AboutStripButton.Image = Global.P_GameConfig.My.Resources.Resources.help_contents
        Me.AboutStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.AboutStripButton.Name = "AboutStripButton"
        Me.AboutStripButton.Size = New System.Drawing.Size(70, 24)
        Me.AboutStripButton.Text = "&About"
        '
        'openfiledialog
        '
        Me.openfiledialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*"""
        '
        'TextBox
        '
        Me.TextBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBox.Location = New System.Drawing.Point(0, 55)
        Me.TextBox.Name = "TextBox"
        Me.TextBox.Size = New System.Drawing.Size(589, 448)
        Me.TextBox.Styles.BraceBad.FontName = "Verdana"
        Me.TextBox.Styles.BraceLight.FontName = "Verdana"
        Me.TextBox.Styles.ControlChar.FontName = "Verdana"
        Me.TextBox.Styles.Default.FontName = "Verdana"
        Me.TextBox.Styles.IndentGuide.FontName = "Verdana"
        Me.TextBox.Styles.LastPredefined.FontName = "Verdana"
        Me.TextBox.Styles.LineNumber.FontName = "Verdana"
        Me.TextBox.Styles.Max.FontName = "Verdana"
        Me.TextBox.TabIndex = 3
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(589, 503)
        Me.Controls.Add(Me.TextBox)
        Me.Controls.Add(Me.toolbar)
        Me.Controls.Add(Me.menubar)
        Me.MainMenuStrip = Me.menubar
        Me.Name = "MainForm"
        Me.Text = "{modname}: Hammer GameConfig"
        Me.menubar.ResumeLayout(False)
        Me.menubar.PerformLayout()
        Me.toolbar.ResumeLayout(False)
        Me.toolbar.PerformLayout()
        CType(Me.TextBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents menubar As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OpenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SaveToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SaveAsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SettingsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OptionsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents toolbar As System.Windows.Forms.ToolStrip
    Friend WithEvents OpenStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents SaveStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents SaveAsStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents AboutStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents openfiledialog As System.Windows.Forms.OpenFileDialog
    Friend WithEvents savefiledialog As System.Windows.Forms.SaveFileDialog
    Friend WithEvents AddLuminousfortsEntryToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FullAboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TextBox As ScintillaNet.Scintilla

End Class
