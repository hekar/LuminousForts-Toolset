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
        Dim ListViewItem3 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("")
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OptionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SettingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButtonLoadFGD = New System.Windows.Forms.ToolStripButton()
        Me.entitylist = New System.Windows.Forms.ListBox()
        Me.entitytextbox = New System.Windows.Forms.TextBox()
        Me.search = New System.Windows.Forms.Button()
        Me.entityinfotable = New System.Windows.Forms.ListView()
        Me.propname = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.proptype = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.propvalue = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.entityinfobrowser = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(655, 28)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(44, 24)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(152, 24)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'OptionsToolStripMenuItem
        '
        Me.OptionsToolStripMenuItem.Name = "OptionsToolStripMenuItem"
        Me.OptionsToolStripMenuItem.Size = New System.Drawing.Size(73, 24)
        Me.OptionsToolStripMenuItem.Text = "Options"
        '
        'SettingsToolStripMenuItem
        '
        Me.SettingsToolStripMenuItem.Name = "SettingsToolStripMenuItem"
        Me.SettingsToolStripMenuItem.Size = New System.Drawing.Size(152, 24)
        Me.SettingsToolStripMenuItem.Text = "Settings"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(53, 24)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(152, 24)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 28)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(655, 27)
        Me.ToolStrip1.TabIndex = 1
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripButtonLoadFGD
        '
        Me.ToolStripButtonLoadFGD.Image = Global.P_EntityBrowser.My.Resources.Resources.folder_open
        Me.ToolStripButtonLoadFGD.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButtonLoadFGD.Name = "ToolStripButtonLoadFGD"
        Me.ToolStripButtonLoadFGD.Size = New System.Drawing.Size(94, 24)
        Me.ToolStripButtonLoadFGD.Text = "Load FGD"
        '
        'entitylist
        '
        Me.entitylist.FormattingEnabled = True
        Me.entitylist.ItemHeight = 16
        Me.entitylist.Location = New System.Drawing.Point(13, 88)
        Me.entitylist.Name = "entitylist"
        Me.entitylist.Size = New System.Drawing.Size(199, 404)
        Me.entitylist.TabIndex = 2
        '
        'entitytextbox
        '
        Me.entitytextbox.Location = New System.Drawing.Point(12, 60)
        Me.entitytextbox.Name = "entitytextbox"
        Me.entitytextbox.Size = New System.Drawing.Size(167, 22)
        Me.entitytextbox.TabIndex = 3
        '
        'search
        '
        Me.search.Image = Global.P_EntityBrowser.My.Resources.Resources.edit_find
        Me.search.Location = New System.Drawing.Point(185, 58)
        Me.search.Name = "search"
        Me.search.Size = New System.Drawing.Size(27, 27)
        Me.search.TabIndex = 4
        Me.search.UseVisualStyleBackColor = True
        '
        'entityinfotable
        '
        Me.entityinfotable.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.propname, Me.proptype, Me.propvalue})
        Me.entityinfotable.Items.AddRange(New System.Windows.Forms.ListViewItem() {ListViewItem3})
        Me.entityinfotable.Location = New System.Drawing.Point(218, 88)
        Me.entityinfotable.Name = "entityinfotable"
        Me.entityinfotable.Size = New System.Drawing.Size(418, 404)
        Me.entityinfotable.TabIndex = 5
        Me.entityinfotable.UseCompatibleStateImageBehavior = False
        Me.entityinfotable.View = System.Windows.Forms.View.Details
        '
        'propname
        '
        Me.propname.Text = "Name"
        Me.propname.Width = 147
        '
        'proptype
        '
        Me.proptype.Text = "Type"
        '
        'propvalue
        '
        Me.propvalue.Text = "Value"
        Me.propvalue.Width = 192
        '
        'entityinfobrowser
        '
        Me.entityinfobrowser.AutoSize = True
        Me.entityinfobrowser.Location = New System.Drawing.Point(218, 63)
        Me.entityinfobrowser.Name = "entityinfobrowser"
        Me.entityinfobrowser.Size = New System.Drawing.Size(172, 17)
        Me.entityinfobrowser.TabIndex = 6
        Me.entityinfobrowser.Text = "Entity Information Browser"
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(655, 515)
        Me.Controls.Add(Me.entityinfobrowser)
        Me.Controls.Add(Me.entityinfotable)
        Me.Controls.Add(Me.search)
        Me.Controls.Add(Me.entitytextbox)
        Me.Controls.Add(Me.entitylist)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "MainForm"
        Me.Text = "Luminousforts: Hammer, Entity Lister"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OptionsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SettingsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripButtonLoadFGD As System.Windows.Forms.ToolStripButton
    Friend WithEvents entitylist As System.Windows.Forms.ListBox
    Friend WithEvents entitytextbox As System.Windows.Forms.TextBox
    Friend WithEvents search As System.Windows.Forms.Button
    Friend WithEvents entityinfotable As System.Windows.Forms.ListView
    Friend WithEvents propname As System.Windows.Forms.ColumnHeader
    Friend WithEvents proptype As System.Windows.Forms.ColumnHeader
    Friend WithEvents propvalue As System.Windows.Forms.ColumnHeader
    Friend WithEvents entityinfobrowser As System.Windows.Forms.Label

End Class
