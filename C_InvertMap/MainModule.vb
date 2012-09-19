'MainModule.vb
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
Imports System.Text
Imports System.Text.RegularExpressions
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq

Module MainModule

    Public Sub ConvertBasicKeyValToJson(ByRef fullname As String, ByRef outname As String)
        Dim reader As New StreamReader(fullname)
        Dim kvContents = reader.ReadToEnd
        reader.Close()

        ' Insert the colons (':') that the Keyvalues format is missing

        Dim buffer = New StringBuilder
        buffer.AppendLine("{")
        For Each line In kvContents.Split(vbCr.ToCharArray)
            Dim replaced = Regex.Replace(line, """\s*""", """:""")
            replaced = Regex.Replace(replaced, """\s*$", """,")

            ' Nothing was changed
            If replaced.Equals(line) Then
                ' If the line has no quotes
                If line.IndexOf("""") < 0 And line.IndexOf("{") < 0 And
                    line.IndexOf("}") < 0 Then
                    replaced = vbNewLine & """" & line.Trim((vbTab & vbCrLf).ToCharArray()) & """"
                End If
            End If

            If line.IndexOf("{") >= 0 Then
                buffer.Append(" : ")
            End If

            buffer.Append(replaced)
        Next

        buffer.AppendLine("}")

        Dim finalcontents = buffer.ToString
        finalcontents = Regex.Replace(finalcontents, """,\s*}", """" & vbNewLine & "}")
        finalcontents = Regex.Replace(finalcontents, "}\s*""", "}" & vbNewLine & ",""")

        ' Dirty hack
        finalcontents = finalcontents.Replace("""""}", "}")

        Dim writer As New StreamWriter(outname)
        writer.Write(finalcontents)
        writer.Close()
    End Sub

    Public Sub ConvertBasicJsonToKeyVal(ByRef fullname As String, ByRef outname As String)
        Dim reader As New StreamReader(fullname)
        Dim contents = reader.ReadToEnd
        reader.Close()

        ' Reverse all the old changes
        contents = contents.Substring(1, contents.Length - 2).Replace(":", vbTab)
        contents = Regex.Replace(contents, """\s*,\s*$", """")
        contents = Regex.Replace(contents, "}\s*,""", "}" & vbNewLine & """")
        contents = contents.Replace(",}", "")
        contents = contents.Replace(""",", """")
        contents = contents.Replace("},", "}")


        Dim writer As New StreamWriter(outname)
        writer.Write(contents)
        writer.Close()
    End Sub

    Public Sub PerformAxisInversion(ByRef fullname As String,
                                     ByRef outname As String,
                                     Optional ByVal yaxis As Boolean = False)

        Dim reader As New StreamReader(fullname)
        Dim contents = reader.ReadToEnd()
        reader.Close()

        Dim invertNext = False
        Dim buffer = New StringBuilder
        Dim wasPlane = False
        For Each line In contents.Split(vbCr.ToCharArray)
            If line.IndexOf("plane") >= 0 Then
                buffer.Append(vbNewLine)
                buffer.Append(vbTab & vbTab)
                Dim result As Double = 0
                For Each token In line.Split((" " & vbTab).ToCharArray)
                    If invertNext Then
                        Dim lasttoken = token
                        token = (-Double.Parse(lasttoken)).ToString()
                        invertNext = False
                    End If

                    Dim trimmedquote = False
                    If token.IndexOf("""") = 0 Then
                        token = token.TrimStart("""".ToCharArray)
                        trimmedquote = True
                    End If

                    If token.IndexOf("(") >= 0 Then
                        Dim trimmedtoken = token.Replace("(".ToCharArray(), "")
                        If Double.TryParse(trimmedtoken, result) Then
                            ' Invert the sign of the X Axis
                            token = "(" & (-Double.Parse(trimmedtoken)).ToString()
                            invertNext = True
                    End If
                    End If

                    If trimmedquote Then
                        buffer.Append("""")
                    End If

                    buffer.Append(token)
                    buffer.Append(" ")
                    wasPlane = True
                Next
            End If

            If Not wasPlane Then
                buffer.Append(line)
            Else
                buffer.Append(vbNewLine)
            End If

            wasPlane = False
        Next

        Dim writer As New StreamWriter(outname)
        writer.Write(buffer.ToString())
        writer.Close()

    End Sub

    Public Class curSide
        Public Id As String = ""
        Public Plane As String = ""
        Public Material As String = ""
        Public UAxis As String = ""
        Public VAxis As String = ""
        Public Rotation As String = ""
        Public LightmapScale As String = ""
        Public SmoothingGroups As String = ""
    End Class

    Sub Main()
        Dim infile = "C:\Users\hekar\Desktop\lf_hall.vmf"
        Dim outjson = "C:\Users\hekar\Desktop\lf_hall.json"
        Dim outjsonkv = "C:\Users\hekar\Desktop\lf_hall_json.txt"
        Dim outmirrored = "C:\Users\hekar\Desktop\lf_hall_mirrored.vmf"
        Dim outfinal = "C:\Users\hekar\Desktop\lf_hall_final.vmf"
        ConvertBasicKeyValToJson(infile, outjson)
        ConvertBasicJsonToKeyVal(outjson, outjsonkv)
        PerformAxisInversion(outjsonkv,
                  "C:\Users\hekar\Desktop\lf_hall_converted.vmf", True)

        Dim lastPropertyName = ""
        Dim ownerName = ""

        Dim curSide As New curSide

        Dim lastSolidDepth = 0
        Dim lastSideDepth = 0
        Dim itemsRead = 0
        Dim inSolid As Boolean = False
        Dim inSide As Boolean = False
        Dim previousSides As New List(Of curSide)

        Dim reader As New StreamReader(outjson)
        Dim json As New JsonTextReader(reader)

        Dim writer As New StreamWriter(outmirrored)
        Dim jsonwriter As New JsonTextWriter(writer)

        jsonwriter.Formatting = Formatting.Indented

        jsonwriter.WriteStartObject()
        While json.Read
            If json.TokenType = JsonToken.PropertyName Then
                lastPropertyName = json.Value.ToString
            ElseIf json.TokenType = JsonToken.StartObject Then
                ownerName = lastPropertyName
                If ownerName = "solid" Then
                    inSolid = True
                    lastSolidDepth = json.Depth
                    jsonwriter.WritePropertyName(ownerName)
                    jsonwriter.WriteStartObject()
                ElseIf ownerName = "side" Then
                    inSide = True
                    lastSideDepth = json.Depth
                Else
                    jsonwriter.WritePropertyName(ownerName)
                    jsonwriter.WriteStartObject()
                End If
            ElseIf json.TokenType = JsonToken.String Then
                If inSolid And inSide Then
                    If itemsRead = 0 Then
                        curSide.Id = json.Value.ToString
                    ElseIf itemsRead = 1 Then
                        curSide.Plane = json.Value.ToString
                    ElseIf itemsRead = 2 Then
                        curSide.Material = json.Value.ToString
                    ElseIf itemsRead = 3 Then
                        curSide.UAxis = json.Value.ToString
                    ElseIf itemsRead = 4 Then
                        curSide.VAxis = json.Value.ToString
                    ElseIf itemsRead = 5 Then
                        curSide.Rotation = json.Value.ToString
                    ElseIf itemsRead = 6 Then
                        curSide.LightmapScale = json.Value.ToString
                    ElseIf itemsRead = 7 Then
                        curSide.SmoothingGroups = json.Value.ToString
                    End If
                    itemsRead += 1
                Else
                    jsonwriter.WritePropertyName(lastPropertyName)
                    jsonwriter.WriteValue(json.Value.ToString())
                End If
            ElseIf json.TokenType = JsonToken.EndObject Then
                If inSolid And json.Depth <= lastSolidDepth Then
                    inSolid = False
                    lastSolidDepth = 0

                    previousSides.Reverse()
                    For Each side In previousSides
                        jsonwriter.WritePropertyName("side")
                        jsonwriter.WriteStartObject()
                        jsonwriter.WritePropertyName("id")
                        jsonwriter.WriteValue(side.Id)
                        jsonwriter.WritePropertyName("plane")
                        jsonwriter.WriteValue(side.Plane)
                        jsonwriter.WritePropertyName("material")
                        jsonwriter.WriteValue(side.Material)
                        jsonwriter.WritePropertyName("uaxis")
                        jsonwriter.WriteValue(side.UAxis)
                        jsonwriter.WritePropertyName("vaxis")
                        jsonwriter.WriteValue(side.VAxis)
                        jsonwriter.WritePropertyName("rotation")
                        jsonwriter.WriteValue(side.Rotation)
                        jsonwriter.WritePropertyName("lightmapscale")
                        jsonwriter.WriteValue(side.LightmapScale)
                        jsonwriter.WritePropertyName("smoothing_groups")
                        jsonwriter.WriteValue(side.SmoothingGroups)
                        jsonwriter.WriteEndObject()
                    Next

                    previousSides.Clear()

                    jsonwriter.WriteEndObject()
                ElseIf inSide And json.Depth <= lastSideDepth Then
                    inSide = False
                    previousSides.Add(curSide)
                    lastSideDepth = 0
                Else
                    jsonwriter.WriteEndObject()
                End If

                itemsRead = 0
            End If
        End While

        jsonwriter.WriteEndObject()

        jsonwriter.Close()
        writer.Close()

        json.Close()
        reader.Close()

        ConvertBasicJsonToKeyVal(outmirrored, outfinal)
        Console.ReadKey()
    End Sub

End Module