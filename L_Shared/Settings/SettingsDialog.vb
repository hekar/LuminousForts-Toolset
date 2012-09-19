'SettingsDialog.vb
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
Imports System.Windows.Forms

Public Class SettingsDialog
    Private _settingpages As New List(Of SettingsPage)

    Public Sub New(ByRef settings As Settings)
        ' This call is required by the designer.
        InitializeComponent()

        AddSettingsPage(New SteamSetting())
    End Sub

    Private Sub SettingsDialog_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CenterToParent()
    End Sub

    Private Sub SettingsDialog_Shown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Shown
        For Each page In _settingpages
            page.OnShown()
        Next
    End Sub

    Public Sub AddSettingsPage(ByRef page As SettingsPage)
        _settingpages.Add(page)
        page.OnLoaded()
    End Sub

    Public Sub RemoveSettingsPage(ByRef page As SettingsPage)
        _settingpages.Remove(page)
    End Sub

    Protected Overridable Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click

        For Each page In _settingpages
            page.OnApply()
        Next

        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        For Each page In _settingpages
            page.OnCancel()
        Next

        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

End Class
