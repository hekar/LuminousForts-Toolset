'FileFinder.vb
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

Imports System.DirectoryServices
Imports System.Threading

Public Class FileFinder

    Private _files As SearchResultCollection
    Private _dirsearcher As DirectorySearcher

    ' Only show search items when search is complete
    Private _lock As New Mutex

    ' Directory to start from and substring to search for in filename
    Public Sub New(ByRef startdir As String, ByRef filter As String)
        _dirsearcher = New DirectorySearcher(New DirectoryEntry(startdir), filter)
        _dirsearcher.Asynchronous = True
        PerformSearch()
    End Sub

    Public Sub PerformSearch()
        _lock.WaitOne()
        If _dirsearcher Is Nothing Then
            ' pass through
        Else
            _files = _dirsearcher.FindAll()
        End If
        _lock.ReleaseMutex()
    End Sub

    Public Sub CancelSearch()
        _dirsearcher.Dispose()
    End Sub

    Public ReadOnly Property Items As SearchResultCollection
        Get
            _lock.WaitOne()
            Return _files
            _lock.ReleaseMutex()
        End Get
    End Property

End Class
