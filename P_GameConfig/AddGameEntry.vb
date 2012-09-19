'AddGameEntry.vb
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
Imports System.Windows.Forms.ListView
Imports L_Shared

Public Structure GameEntryTemplate
    Public Name As String
    Public Filepath As String
End Structure

Public Class AddGameEntry

    Private kEntryTemplateDir As String = GameConfigShared.kGameConfigDir & "templates/"

    Private _selectedindex As Integer = 0
    Private _templates As New List(Of GameEntryTemplate)
    Private _dir As New DirectoryInfo(kEntryTemplateDir)

    Public ReadOnly Property Templates As List(Of GameEntryTemplate)
        Get
            Return _templates
        End Get
    End Property

    Public ReadOnly Property SelectedTemplate As GameEntryTemplate
        Get
            Return _templates(_selectedindex)
        End Get
    End Property

    Public Property SelectedIndex As Integer
        Get
            Return _selectedindex
        End Get
        Set(ByVal value As Integer)
            _selectedindex = value
        End Set
    End Property

    Private Sub AddGameEntry_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' Remove all items from the GameEntryList if they're there
        GameEntryList.Items.Clear()

        ' Allocate items onto the list from their specified folder
        For Each file As FileInfo In _dir.EnumerateFiles()
            Dim entry As New GameEntryTemplate()
            entry.Name = file.Name.Replace(".txt", "")
            entry.Filepath = kEntryTemplateDir & file.Name
            _templates.Add(entry)
            GameEntryList.Items.Add(entry.Name)
        Next

        If _templates.Count = 0 Then
            Throw New FileNotFoundException("Could not find Template files in " & kEntryTemplateDir)
        End If

    End Sub

    Private Sub GameEntryList_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GameEntryList.SelectedIndexChanged
        _selectedindex = GameEntryList.SelectedIndex()
    End Sub

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

End Class
