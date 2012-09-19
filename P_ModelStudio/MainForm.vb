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

Imports System.Text
Imports L_Shared


Public Class MainForm

    Private WithEvents _studioprocess As New StudioProcess
    Private _arguments As New StringBuilder

    Private Sub MainForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ArgSwitchList.Sorted = False
        For Each arg In Arguments
            ArgSwitchList.Items.Add(arg.Name + " (" + arg.Switch + ")", arg.Checked)
        Next
    End Sub

    Private Sub CompileToolButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CompileToolButton.Click
        For Each item In ArgSwitchList.SelectedItems
            Dim label As String = item.ToString()
            Dim switch As String = label.Substring(label.IndexOf("("), label.IndexOf(")") - label.IndexOf(")"))
            MessageBox.Show(switch)
            _arguments.Append(switch)
            _arguments.Append(" ")
        Next

        If TextureOverride.Text <> "" Then
            _arguments.Append("-t " & TextureOverride.Text)
        End If

        _arguments.Append(" ")
        _arguments.Append(CustomArguments.Text)

        ' Check if they changed the game directory
        If CustomArguments.Text.IndexOf("-gamedir") > 0 Then
            ' Do nothing ...
        Else
            ' Add the default game directory from steam settings
            Dim steamsettings As New Settings(GlobalShared.kSettingsSteam)
        End If

        _studioprocess.Arguments = _arguments.ToString()
        _studioprocess.Start()
    End Sub

    Private Sub StudioProcess_Finished(ByVal output As String) Handles _studioprocess.FinishedExecution
        TextBox.Text = output
    End Sub

End Class
