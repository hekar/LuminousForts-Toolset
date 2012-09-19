'OpenDialog.vb
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

Public Class OpenDialog

    Private Sub OpenDialog_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CenterToScreen()
    End Sub

    Private Sub OpenGameConfigButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpenGameConfigButton.Click
        Try
            MainForm.OpenGameConfigFile()
        Catch ex As Exception
        Finally
            Me.Close()
        End Try
    End Sub

    Private Sub OpenAsButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpenAsButton.Click
        Try
            MainForm.OpenAsGameConfigFile()
        Catch ex As Exception
        Finally
            Me.Close()
        End Try
    End Sub

    Private Sub CancelButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CancelDialogButton.Click
        Me.Close()
    End Sub

End Class