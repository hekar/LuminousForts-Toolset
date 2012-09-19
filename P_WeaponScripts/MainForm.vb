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

    Private Sub Main_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Text = ModShared.kModName + "- Weapon Scripts"
    End Sub

    Private Sub OpenFolderToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpenFolderToolStripMenuItem.Click

        Try
            Dim settings = New Settings(kSettingsFilename)
            Dim steamfolder = settings.GetSetting("steamfolder") &
                Path.DirectorySeparatorChar & "steamapps" &
                Path.DirectorySeparatorChar & "sourcemods"

            FolderBrowserDialog.SelectedPath = steamfolder
        Catch ex As Xml.XmlException
        Catch ex As FileNotFoundException
        Catch ex As DirectoryNotFoundException
            ' ignore all
        End Try

        Dim result = FolderBrowserDialog.ShowDialog()
        If result = Windows.Forms.DialogResult.OK Then
            Dim files = Directory.GetFiles(FolderBrowserDialog.SelectedPath)
            For Each file As String In files
                If file.IndexOf("weapon_") >= 0 And file.EndsWith(".txt") Then
                    clstWeaponScripts.Items.Add(file, True)
                End If
            Next
        End If
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub ChangeCrosshairsToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChangeCrosshairsToolStripButton.Click
        ChangeCrosshair.ShowDialog()
    End Sub
End Class
