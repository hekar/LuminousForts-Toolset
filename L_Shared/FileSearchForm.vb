'FileSearchForm.vb
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

Public Class FileSearchForm

    Private _filefinder As FileFinder

    Public Sub PerformSearch(ByRef startdir As String, ByRef filter As String)
        _filefinder = New FileFinder(startdir, filter)
    End Sub

    Private Sub CancelSearch()
        If _filefinder Is Nothing Then
            ' Pass through
        Else
            _filefinder.CancelSearch()
        End If
    End Sub

    Private Sub FileSearchForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub FileSearchForm_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        CancelSearch()
    End Sub

    Private Sub CancelButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CancelBut.Click
        CancelSearch()
    End Sub

End Class