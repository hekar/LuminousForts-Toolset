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

Imports L_Shared

Public Class MainForm

    Private _settings As Settings
    Private _settingsdialog As SettingsDialog

    Private Sub ExecuteApplication(ByRef filename As String, ByRef workingdir As String)
        Dim app As New ApplicationLauncher(filename, workingdir)
        app.Start()

        Me.Hide()
        app.WaitForExit()
        Me.Show()
    End Sub

    Private Sub MainForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Text = ModShared.kModName & " - Toolset"

        _settings = New Settings("xml/settings.xml")
        _settingsdialog = New SettingsDialog(_settings)

        CenterToScreen()

    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        ' Quit the application
        Application.Exit()
    End Sub

    Private Sub OptionToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OptionToolStripMenuItem.Click
        ' Open up a settings dialog
        _settingsdialog.Show()
    End Sub

    Private Sub GameConfig_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GameConfig.Click
        ExecuteApplication("Luminousforts_Hammer.exe", "C:\Users\hekar\Desktop\code\Luminousforts-toolset\Luminousforts_Hammer\Luminousforts_Hammer\bin\Debug")
    End Sub

    Private Sub EntityBrowser_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EntityBrowser.Click
        ExecuteApplication("Luminousforts_Hammer.exe", "C:\Users\hekar\Desktop\code\Luminousforts-toolset\Luminousforts_Hammer\Luminousforts_Hammer\bin\Debug")
    End Sub

    Private Sub MapPack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MapPack.Click
        ExecuteApplication("Luminousforts_Hammer.exe", "C:\Users\hekar\Desktop\code\Luminousforts-toolset\Luminousforts_Hammer\Luminousforts_Hammer\bin\Debug")
    End Sub

    Private Sub AboutToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem1.Click
        Dim aboutpage As New AboutModSharedDialog
        aboutpage.Show()
    End Sub
End Class
