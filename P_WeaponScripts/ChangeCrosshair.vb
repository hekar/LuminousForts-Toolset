'ChangeCrosshair.vb
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
Imports System.Text.RegularExpressions
Imports System.Windows.Forms

Public Class ChangeCrosshair

    Private Sub ReplaceCrosshair(ByRef filename As String, ByRef oldcrosshair As String, ByRef newcrosshair As String)
        Dim reader As New StreamReader(filename)
        Dim contents = reader.ReadToEnd()
        reader.Close()

        Dim pattern = """crosshair""\s*{\s*""font""\s*""Crosshairs""\s*""character""\s*""" & oldcrosshair & """\s*}"
        Dim re As New Regex(pattern)
        contents = re.Replace(contents, """crosshair""" & vbCrLf &
                              vbTab & vbTab & "{" & vbCrLf &
                              vbTab & vbTab & vbTab & vbTab & """font""     ""Crosshairs""" & vbCrLf &
                              vbTab & vbTab & vbTab & vbTab & """character""        """ & newcrosshair & """" & vbCrLf &
                              vbTab & vbTab & "}")

        Dim writer As New StreamWriter(filename, False)
        writer.Write(contents)
        writer.Close()
    End Sub

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click

        For Each file As String In MainForm.clstWeaponScripts.CheckedItems
            ReplaceCrosshair(file, txtOldCrosshair.Text, txtNewCrosshair.Text)
        Next

        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

End Class
