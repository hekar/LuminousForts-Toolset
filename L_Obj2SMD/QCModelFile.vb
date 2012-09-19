'QCModelFile.vb
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

Public Class QCModelFile

    Private _qcfilepath As String

    Private _qcfilecontents As New stringwriter

    Public Sub New(ByRef qcfilepath As String)
        _qcfilepath = qcfilepath

    End Sub

    Property ModelName As String = ""
    Property BodyName As String = ""
    Property SurfaceProp As String = ""
    Property CdMaterials As String = ""
    Property IdleSequenceFile As String = ""
    Property CollisionModel As String = ""

    Private Sub WriteQCFileHeader()

    End Sub

    Private Sub WriteQCFileContents()
        _qcfilecontents.WriteLine("$modelname """ & ModelName & """")
        _qcfilecontents.WriteLine("$body mybody """ & BodyName & """")
        _qcfilecontents.WriteLine("$staticprop")
        _qcfilecontents.WriteLine("$surfaceprop " & SurfaceProp)
        _qcfilecontents.WriteLine("$cdmaterials """ & CdMaterials & """")
        _qcfilecontents.WriteLine("$sequence idle """ & IdleSequenceFile & """ loop fps 15")
        _qcfilecontents.WriteLine("$collisionmodel """ & CollisionModel & """ { $concave }")
    End Sub

    Public Sub Write()

        WriteQCFileHeader()
        WriteQCFileContents()

        Dim writer As New StreamWriter(_qcfilepath)
        writer.Write(_qcfilecontents.ToString())
        writer.Close()
    End Sub
End Class
