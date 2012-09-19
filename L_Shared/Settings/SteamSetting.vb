Imports System.Windows.Forms

Public Class SteamSetting
    Inherits SettingsPage
    Friend WithEvents steamfolder As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents username As System.Windows.Forms.TextBox
    Friend WithEvents browsebutton As System.Windows.Forms.Button
    Friend WithEvents sourcesdkbin As System.Windows.Forms.TextBox
    Friend WithEvents sourcesdkbinlabel As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents gamedir As System.Windows.Forms.TextBox
    Friend WithEvents gamedirlabel As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button

    ' Default filename for settings
    Private Const kSettingsFilename = GlobalShared.kSettingsSteam
    Friend WithEvents openfolderdialog As System.Windows.Forms.FolderBrowserDialog

    ' Keyvalues of mod settings
    Private _settings As Settings

    Public Sub New()
        ' Initialize the settings before the components are initialized
        _settings = New Settings(kSettingsFilename)

        InitializeComponent()
    End Sub

    Public Overrides Sub OnLoaded()
        steamfolder.Text = _settings.GetSetting("steam_folder")
        username.Text = _settings.GetSetting("steam_username")
        sourcesdkbin.Text = _settings.GetSetting("steam_sourcesdkbin")
        gamedir.Text = _settings.GetSetting("steam_gamedir")
    End Sub

    Public Overrides Sub OnShown()
        ' Reload the settings each time this dialog is opened
        _settings.ReadSettings()
        steamfolder.Text = _settings.GetSetting("steam_folder")
        username.Text = _settings.GetSetting("steam_username")
        username.Text = _settings.GetSetting("steam_sourcesdkbin")
        sourcesdkbin.Text = _settings.GetSetting("steam_gamedir")
    End Sub

    Public Overrides Sub OnApply()
        ' Save our settings!!
        _settings.WriteSettings()

        _settings.SetSetting("steam_folder", steamfolder.Text)
        _settings.SetSetting("steam_username", username.Text)
        _settings.SetSetting("steam_sourcesdkbin", sourcesdkbin.Text)
        _settings.SetSetting("steam_gamedir", gamedir.Text)
    End Sub

    Public Overrides Sub OnCancel()
    End Sub

    ' Default Page shown in all instances of the setting dialog
    Private Sub browsebutton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim result As DialogResult = openfolderdialog.ShowDialog()
        If result = DialogResult.OK Then
            steamfolder.Text = openfolderdialog.SelectedPath
        End If
    End Sub

    Private Sub InitializeComponent()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.gamedirlabel = New System.Windows.Forms.Label()
        Me.gamedir = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.sourcesdkbinlabel = New System.Windows.Forms.Label()
        Me.sourcesdkbin = New System.Windows.Forms.TextBox()
        Me.browsebutton = New System.Windows.Forms.Button()
        Me.username = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.steamfolder = New System.Windows.Forms.TextBox()
        Me.openfolderdialog = New System.Windows.Forms.FolderBrowserDialog()
        Me.SuspendLayout()
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(302, 75)
        Me.Button2.Margin = New System.Windows.Forms.Padding(2)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(65, 23)
        Me.Button2.TabIndex = 16
        Me.Button2.Text = "&Browse..."
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button2.UseVisualStyleBackColor = True
        '
        'gamedirlabel
        '
        Me.gamedirlabel.AutoSize = True
        Me.gamedirlabel.Location = New System.Drawing.Point(3, 81)
        Me.gamedirlabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.gamedirlabel.Name = "gamedirlabel"
        Me.gamedirlabel.Size = New System.Drawing.Size(80, 13)
        Me.gamedirlabel.TabIndex = 15
        Me.gamedirlabel.Text = "&Game Directory"
        '
        'gamedir
        '
        Me.gamedir.Location = New System.Drawing.Point(87, 78)
        Me.gamedir.Margin = New System.Windows.Forms.Padding(2)
        Me.gamedir.Name = "gamedir"
        Me.gamedir.Size = New System.Drawing.Size(211, 20)
        Me.gamedir.TabIndex = 14
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(302, 45)
        Me.Button1.Margin = New System.Windows.Forms.Padding(2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(65, 23)
        Me.Button1.TabIndex = 13
        Me.Button1.Text = "&Browse..."
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button1.UseVisualStyleBackColor = True
        '
        'sourcesdkbinlabel
        '
        Me.sourcesdkbinlabel.AutoSize = True
        Me.sourcesdkbinlabel.Location = New System.Drawing.Point(3, 49)
        Me.sourcesdkbinlabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.sourcesdkbinlabel.Name = "sourcesdkbinlabel"
        Me.sourcesdkbinlabel.Size = New System.Drawing.Size(79, 13)
        Me.sourcesdkbinlabel.TabIndex = 12
        Me.sourcesdkbinlabel.Text = "&SDK Bin Folder"
        '
        'sourcesdkbin
        '
        Me.sourcesdkbin.Location = New System.Drawing.Point(87, 45)
        Me.sourcesdkbin.Margin = New System.Windows.Forms.Padding(2)
        Me.sourcesdkbin.Name = "sourcesdkbin"
        Me.sourcesdkbin.Size = New System.Drawing.Size(211, 20)
        Me.sourcesdkbin.TabIndex = 11
        '
        'browsebutton
        '
        Me.browsebutton.Location = New System.Drawing.Point(303, 14)
        Me.browsebutton.Margin = New System.Windows.Forms.Padding(2)
        Me.browsebutton.Name = "browsebutton"
        Me.browsebutton.Size = New System.Drawing.Size(65, 23)
        Me.browsebutton.TabIndex = 10
        Me.browsebutton.Text = "&Browse..."
        Me.browsebutton.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.browsebutton.UseVisualStyleBackColor = True
        '
        'username
        '
        Me.username.Location = New System.Drawing.Point(87, 112)
        Me.username.Margin = New System.Windows.Forms.Padding(2)
        Me.username.Name = "username"
        Me.username.Size = New System.Drawing.Size(211, 20)
        Me.username.TabIndex = 9
        Me.username.Text = "your_steam_username"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(3, 115)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "&Username"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(4, 18)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "&Steam Folder"
        '
        'steamfolder
        '
        Me.steamfolder.Location = New System.Drawing.Point(88, 15)
        Me.steamfolder.Margin = New System.Windows.Forms.Padding(2)
        Me.steamfolder.Name = "steamfolder"
        Me.steamfolder.Size = New System.Drawing.Size(211, 20)
        Me.steamfolder.TabIndex = 6
        Me.ResumeLayout(False)

    End Sub
End Class
