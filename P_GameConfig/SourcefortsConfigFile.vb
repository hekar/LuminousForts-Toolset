'SourcefortsConfigFile.vb
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

' Modifies the GameConfig.txt, adding a Sourceforts entry
Public Class GameConfigFile

    Private _configfile As String
    Private _username As String

    ' TODO: Make Generic and have it work for any mod
    Public Sub New(ByRef gameconfigpath As String, ByRef username As String)
        _configfile = gameconfigpath
        _username = username
    End Sub

    ' Basically check if we already fine sourceforts in the configuration
    Private Function AlreadyAdded(ByRef filedata() As String) As Boolean
        For Each line As String In filedata
            If line.IndexOf(ModShared.kModName) >= 0 Then
                Return True
            End If
        Next
        Return False
    End Function

    Public Function AddMod(ByRef templatefile As String, ByRef filedata() As String) As String
        Dim output As New StringWriter

        If AlreadyAdded(filedata) Then
            For Each line As String In filedata
                output.WriteLine(line)
            Next

            MessageBox.Show("Already Added", ModShared.kModName + " already added")

            Return output.ToString()
        End If

        For i As Integer = 0 To filedata.Count - 2
            If i + 1 < filedata.Count Then
                If filedata(i + 1).IndexOf("SDKVersion") >= 0 Then
                    Exit For
                End If
            End If
            output.WriteLine(filedata(i))
        Next i

        ' Sourceforts stuff
        Dim reader As New StreamReader(templatefile)
        Dim template_lines As String = reader.ReadToEnd()
        reader.Close()
        output.Write(template_lines.Replace("%USERNAME%", _username))

        output.WriteLine("")
        output.WriteLine(vbTab + "}")
        output.WriteLine(vbTab + """SDKVersion"" ""3""")
        output.WriteLine("}")


        Return output.ToString()

    End Function

    Private Sub RemoveMod(ByRef templatefile As String, ByRef filedata() As String)

    End Sub

End Class
