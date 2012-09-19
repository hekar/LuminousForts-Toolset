'MainForm.vb
'
'LuminousForts Toolset -- A modders toolkit, written in VB.Net
'Copyright (C) 2010 Hekar Khani

'This program is free software: you can redistribute it and/or modify
'it under the terms of the GNU General Public License as published by
'the Free Software Foundation, either version 3 of the License, or
'(at your option) any later version.

'This program is distributed in the hope that it will be useful,
'but WITHOUT ANY WARRANTY; without even the implied warranty of
'MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
'GNU General Public License for more details.

'You should have received a copy of the GNU General Public License
'along with this program.  If not, see <http://www.gnu.org/licenses/>.

Imports System.IO
Imports L_Shared
Imports L_Shared.ModShared

Public Class MainForm

    ' File operations
    Private _fileopen As Boolean = False
    Private _filesaved As Boolean = True
    Private _filecurname As String = ""

    ' Misc constants
    Private Const kSteamAppsFolder = "\steamapps\"
    Private Const kSourceSDKFolder = "\sourcesdk\"
    ' Luminous Forts is for Source Engine 2007
    Private Const kOrangeSDKFolder = "bin\source2007\bin\"
    Private Const kGameConfigTxt = "GameConfig.txt"

    ' Settings stuff
    Private _steamfolder As String = ""
    Private _steamusername As String = ""
    Private _gameconfigpath As String = ""

    ' Setting Keyvalues
    Private _settings As Settings

    ' Settings dialog UI
    Private _settingsdialog As SettingsDialog

    ' Shared Mod About Box 
    Private _aboutmodshareddialog As New AboutModSharedDialog

    Public Property SteamFolder As String
        Get
            Return _steamfolder
        End Get
        Set(ByVal value As String)
            _steamfolder = value
        End Set
    End Property

    Public Property SteamUsername As String
        Get
            Return _steamusername
        End Get
        Set(ByVal value As String)
            _steamusername = value
        End Set
    End Property

    ' Logic stuff ----------------------
    Public Sub LoadSettings()
        Try
            _settings.ReadSettings()

            _steamfolder = _settings.GetSetting("steam_folder")
            _steamusername = _settings.GetSetting("steam_username")

            ' Create the gameconfiguration path from both the variables above
            _gameconfigpath = GetGameConfigFilePath(_steamfolder, _steamusername)
        Catch ex As FileNotFoundException
            MessageBox.Show("Failed to open file: " & kSettingsFilename)
        Catch ex As IOException
            MessageBox.Show("Error reading from file: " & kSettingsFilename)
        End Try
    End Sub

    Public Sub SaveSettings()
        Try
            _settings.WriteSettings()
        Catch ex As FileNotFoundException
            MessageBox.Show("Failed to open file: " & kSettingsFilename)
        Catch ex As IOException
            MessageBox.Show("Error writing to file: " & kSettingsFilename)
        End Try
    End Sub

    Public Function GetGameConfigFilePath(ByRef steamfolder As String, ByRef steamusername As String) As String
        Dim gameconfigpath As String = ""

        gameconfigpath = steamfolder & kSteamAppsFolder & steamusername _
            & kSourceSDKFolder & kOrangeSDKFolder & kGameConfigTxt

        If File.Exists(gameconfigpath) Then
            Return gameconfigpath
        Else
            Throw New FileNotFoundException("Failed to Find Folder for GameConfig.txt: " & gameconfigpath)
            Return _filecurname
        End If
    End Function

    Private Sub LoadConfigFile(ByRef filepath As String)

        If _fileopen Then
            ' Are you sure you want to overwrite etc
        End If

        Try
            Dim reader As New StreamReader(filepath)
            TextBox.Text = reader.ReadToEnd()
            reader.Close()

            _filecurname = filepath
            _fileopen = True
        Catch ex As FileNotFoundException
            _filecurname = ""
            _fileopen = False

            ' Throw the exception to a higher level
            Throw ex
        End Try

    End Sub

    Private Sub SaveConfigFile(ByRef filepath As String)
        Dim writer As New StreamWriter(filepath)
        For Each line As String In TextBox.Text.Split(vbLf)
            writer.Write(line)
        Next
        writer.Close()

        _filesaved = True
    End Sub

    Public Sub OpenGameConfigFile()
        Dim saveresult As DialogResult = CheckSave("Save before opening new buffer", "Do you want to save before opening a new file?")
        If saveresult = DialogResult.OK Then
            SaveGameConfig()
        ElseIf saveresult = DialogResult.No Then
            ' Do nothing..
        ElseIf saveresult = DialogResult.Cancel Then
            Exit Sub
        End If

        If Not File.Exists(_gameconfigpath) Then
            MessageBox.Show("Game Config File isn't found, Check your steam folder and username settings")
            Dim result As DialogResult = _settingsdialog.ShowDialog()
            If result = DialogResult.OK Then
                SaveSettings()
                If File.Exists(_gameconfigpath) Then
                    LoadConfigFile(_gameconfigpath)
                Else
                    MessageBox.Show("Could not find your GameConfig.txt file: " & _gameconfigpath)
                End If
            End If
        Else
            ' Don't show the settings dialog
            LoadConfigFile(_gameconfigpath)
        End If
    End Sub

    Public Sub OpenAsGameConfigFile()
        Dim saveresult As DialogResult = CheckSave("Save before opening new buffer", "Do you want to save before opening a new file?")
        If saveresult = DialogResult.OK Then
            SaveGameConfig()
        ElseIf saveresult = DialogResult.No Then
            ' Do nothing..
        ElseIf saveresult = DialogResult.Cancel Then
            Exit Sub
        End If

        openfiledialog.InitialDirectory = _gameconfigpath.Substring(0, _gameconfigpath.LastIndexOf("\"))
        Dim result As DialogResult = openfiledialog.ShowDialog()
        If result = DialogResult.OK Then
            LoadConfigFile(openfiledialog.FileName)
        End If
    End Sub

    Private Sub SaveGameConfig()
        If Not _fileopen Then
            MessageBox.Show("Please Select a File to Save As", "No Filename Specified")
            SaveAsGameConfig()
        Else
            SaveConfigFile(_gameconfigpath)
        End If
    End Sub

    Private Sub SaveAsGameConfig()
        Dim result As DialogResult = savefiledialog.ShowDialog()
        If result = DialogResult.OK Then
            SaveConfigFile(savefiledialog.FileName)
        End If
    End Sub

    Private Sub ExitApplication()
        ' Are you sure you want to exit, etc, etc
        Dim result As DialogResult = CheckSave("Save before Exiting", "Do you want to save before exiting?")
        If result = DialogResult.OK Then
            SaveGameConfig()
            Application.Exit()
        ElseIf result = DialogResult.No Then
            Application.Exit()
        ElseIf result = DialogResult.Cancel Then
            ' Do nothing..
        ElseIf result = DialogResult.None Then
            Application.Exit()
        End If
    End Sub

    Private Function CheckSave(ByRef title As String, ByRef message As String) As DialogResult
        Dim result As DialogResult = DialogResult.None
        If Not _filesaved Then
            result = MessageBox.Show(title, message, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation)
        End If
        Return result
    End Function

    ' Ui stuff ----------------------
    Private Sub MainForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Text = ModShared.kModName & " - Hammer GameConfig"
        AddLuminousfortsEntryToolStripMenuItem.Text = "Add Mod Entry"
        FullAboutToolStripMenuItem.Text = "About " & ModShared.kModName & " Toolkit"

        _settings = New Settings(kSettingsFilename, "settings", False)
        _settingsdialog = New SettingsDialog(_settings)

        CenterToScreen()

        Try
            LoadSettings()
            If File.Exists(_steamfolder) Then
                ' Change the initial directories for the save file dialog
                savefiledialog.InitialDirectory = _steamfolder
            End If

        Catch ex As FileNotFoundException
            ' Create default settings
            SaveSettings()
        End Try
    End Sub

    Private Sub MainForm_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        ' Are you sure you want to exit, etc, etc
        Dim result As DialogResult = CheckSave("Save before Exiting", "Do you want to save before exiting?")
        If result = DialogResult.OK Then
            SaveGameConfig()
        ElseIf result = DialogResult.No Then
        ElseIf result = DialogResult.Cancel Then
            ' Do nothing..
            e.Cancel = True
        End If
    End Sub

    Private Sub TextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox.TextChanged
        _filesaved = False
    End Sub

    Private Sub OpenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpenToolStripMenuItem.Click
        OpenDialog.Show()
    End Sub

    Private Sub SaveToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveToolStripMenuItem.Click
        SaveGameConfig()
    End Sub

    Private Sub SaveAsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveAsToolStripMenuItem.Click
        SaveAsGameConfig()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        ExitApplication()
    End Sub

    Private Sub AddLuminousfortsEntryToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddLuminousfortsEntryToolStripMenuItem.Click
        Dim result As DialogResult = AddGameEntry.ShowDialog()
        If result = DialogResult.OK Then
            Dim sfconfig As New GameConfigFile(_gameconfigpath, _steamusername)
            Dim modfile As String = AddGameEntry.SelectedTemplate.Filepath
            Dim lines = sfconfig.AddMod(modfile, TextBox.Text.Split(vbCrLf))
            TextBox.Text = lines
        Else
            ' Do nothing
        End If
    End Sub

    Private Sub OptionsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OptionsToolStripMenuItem.Click
        If _settingsdialog.ShowDialog() = DialogResult.OK Then
            SaveSettings()
        End If
    End Sub

    Private Sub AboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        AboutBox.Show()
    End Sub

    Private Sub OpenStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpenStripButton.Click
        OpenDialog.Show()
    End Sub

    Private Sub SaveStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveStripButton.Click
        SaveGameConfig()
    End Sub

    Private Sub SaveAsStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveAsStripButton.Click
        SaveAsGameConfig()
    End Sub

    Private Sub HelpToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ' Open URL in Browser
        Dim process As Process = process.Start("iexplore", ModShared.kModToolkitHelpUrl)
    End Sub

    Private Sub AboutStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutStripButton.Click
        AboutBox.ShowDialog()
    End Sub

    Private Sub AboutmodnameToolkitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FullAboutToolStripMenuItem.Click
        _aboutmodshareddialog.Show()
    End Sub

End Class
