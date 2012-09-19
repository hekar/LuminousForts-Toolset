'ObjToSmd.vb
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

' Convert a .obj model to a .smd model
Public Class ObjToSmd

    ' Full filepaths
    Private _objpath As String
    Private _smdpath As String

    ' File Content Buffers
    Private _objcontents As String
    Private _smdcontents As New StringWriter

    Public Sub New(ByRef obj_path As String, ByRef out_path As String)
        _objpath = obj_path
        _smdpath = out_path

        Try
            LoadObjFile(_objpath)
        Catch ex As IOException
            Throw ex
        End Try

        ConvertObjToSmd(_objpath, _smdpath)

    End Sub

    Private Sub LoadObjFile(ByRef objpath As String)
        Dim reader As New StreamReader(objpath)
        _objcontents = reader.ReadToEnd()
        reader.Close()
    End Sub

    Private Sub WriteSmdHeader(ByRef objmodelname As String)
        ' Do initial file contents
        _smdcontents.WriteLine("version 1")

        _smdcontents.WriteLine("nodes")
        _smdcontents.WriteLine("0 {0} -1", objmodelname)
        _smdcontents.WriteLine("end")

        _smdcontents.WriteLine("skeleton")
        _smdcontents.WriteLine("time 0")
        _smdcontents.WriteLine("0 0.000000 0.000000 0.000000 0.000000 0.000000 0.000000")
        _smdcontents.WriteLine("end")

    End Sub

    Private Structure Vertex
        Public x As Double
        Public y As Double
        Public z As Double

        Public Sub SetValue(ByVal index As Integer, ByVal val As Double)
            If index = 0 Then
                x = val
            ElseIf index = 1 Then
                y = val
            ElseIf index = 2 Then
                z = val
            End If
        End Sub

    End Structure

    Private Structure TextureCoordinate
        Public u As Double
        Public v As Double

        Public Sub SetValue(ByVal index As Integer, ByVal val As Double)
            If index = 0 Then
                u = val
            ElseIf index = 1 Then
                v = val
            End If
        End Sub
    End Structure

    Private _vertexlist As New List(Of Vertex)
    Private _normallist As New List(Of Vertex)
    Private _texclist As New List(Of TextureCoordinate)

    Private _facelist As New List(Of Face)
    Private Class Face
        ' Datatypes that do not exist should be 'Nothing'
        ' Everything assumes that 'Vertex' exists
        Public VertexIndex(3) As Integer
        Public NormalIndex(3) As Integer
        Public TexcIndex(3) As Integer
    End Class

    Private Sub CalculateVertices(ByRef objmodelname As String)

        ' Iterate through each line in the .obj file
        For Each line In _objcontents.Split(vbCrLf.ToCharArray())

            ' Ignore file comments
            If line.StartsWith("#") Then
                Continue For
            End If

            If line.StartsWith("v ") Then
                ' Vertices
                Dim vertices_string = line.Replace("v ", "").Split()
                Dim vertex As New Vertex()

                vertex.x = CType(vertices_string(0), Integer)
                vertex.y = CType(vertices_string(1), Integer)
                vertex.z = CType(vertices_string(2), Integer)

                _vertexlist.Add(vertex)
            ElseIf line.StartsWith("vt ") Then
                ' Texture Coordinates
                Dim texc_string = line.Replace("vt ", "").Split()
                Dim texc As New TextureCoordinate()

                texc.u = CType(texc_string(0), Integer)
                texc.v = CType(texc_string(1), Integer)

                _texclist.Add(texc)
            ElseIf line.StartsWith("vn ") Then
                ' Normal Coordinates
            ElseIf line.StartsWith("f") Then
                ' Face Definition
                Dim face As New Face
                Dim faces_string() = line.Replace("f ", "").Split()

                Dim segs(3)() As String
                For i As Integer = 0 To 2
                    segs(i) = faces_string(i).Split("/".ToCharArray())
                Next

                For i As Integer = 0 To 2
                    Dim dim_count As Integer = segs(i).Count

                    If dim_count = 1 Then
                        ' Face has vertices only
                        face.VertexIndex(i) = CType(segs(i)(0), Integer)
                    ElseIf dim_count = 2 Then
                        ' Face has vertices and texture coordinates
                        face.VertexIndex(i) = CType(segs(i)(0), Integer)
                        face.TexcIndex(i) = CType(segs(i)(1), Integer)

                    ElseIf dim_count = 3 Then
                        ' Face has vertices, texture coordinates and normals
                        face.VertexIndex(i) = CType(segs(i)(0), Integer)
                        face.TexcIndex(i) = CType(segs(i)(1), Integer)
                        face.NormalIndex(i) = CType(segs(i)(2), Integer)
                    End If
                Next

                ' Add the face
                _facelist.Add(face)
            End If

        Next
    End Sub

    Private Sub WriteSmdContents(ByRef objmodelname As String)
        ' Name for the respective texture file of the model
        Dim texturename As String = objmodelname + ".tga"

        ' This Obj to Smd writer only does triangles
        _smdcontents.WriteLine("triangles")

        For Each face In _facelist
            ' Write name of texture
            _smdcontents.WriteLine("{0}", texturename)
            For i As Integer = 0 To 2
                Dim vertices As Vertex = _vertexlist(face.VertexIndex(i) - 1)
                _smdcontents.Write("{0} {1} {2} ", vertices.x.ToString("N6"), vertices.y.ToString("N6"), vertices.z.ToString("N6"))

                If _normallist.Count > 0 Then
                    Dim normals As Vertex = _normallist(face.NormalIndex(i) - 1)
                    _smdcontents.Write("{0} {1} {2} ", normals.x.ToString("N6"), normals.y.ToString("N6"), normals.z.ToString("N6"))
                End If

                If _texclist.Count > 0 Then
                    Dim texc As TextureCoordinate = _texclist(face.TexcIndex(i) - 1)
                    _smdcontents.WriteLine("{0} {1}", texc.u.ToString("N6"), texc.v.ToString("N6"))
                End If
            Next

        Next

        _smdcontents.WriteLine("end")

    End Sub

    Private Sub SaveSmdContents(ByRef smdpath As String)
        Dim writer As New StreamWriter(smdpath)
        writer.Write(_smdcontents.ToString())
        writer.Close()
    End Sub

    Private Sub ConvertObjToSmd(ByRef objpath As String, ByRef smdpath As String)

        Dim objfileinfo As New FileInfo(objpath)

        ' Just grab the "leaf" (filename without directory or fullpath)
        Dim objfilename As String = objfileinfo.Name

        Dim objmodelname As String = objfilename.Substring(0, objfilename.LastIndexOf("."))

        ' Write the header
        WriteSmdHeader(objmodelname)

        ' Write the actual vertices
        CalculateVertices(objmodelname)

        ' Write the Smd's actual contents (vertices, texture coordinates, etc)
        WriteSmdContents(objmodelname)

        SaveSmdContents(smdpath)
    End Sub

    Public Shadows Function ToString() As String
        Return _smdcontents.ToString()
    End Function

End Class
