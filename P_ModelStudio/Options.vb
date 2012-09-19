'Options.vb
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

Module Options

    Structure Argument
        Public Switch As String
        Public Name As String
        Public ToolTip As String
        Public Checked As Boolean

        Public Sub New(ByRef switch As String, ByRef name As String,
                       ByRef tooltip As String, Optional ByVal check As Boolean = False)
            Me.Switch = switch
            Me.Name = name
            Me.ToolTip = tooltip
            Me.Checked = False
        End Sub
    End Structure

    Public Arguments() As Argument =
    {
        New Argument("-a", "Blend Normal Angles", "<normal_blend_angle>"),
        New Argument("-checklengths", "Check Lengths", ""),
        New Argument("-d", "Dump GLView Files", "Dump GLView Files"),
        New Argument("-definebones", "Define Bones", ""),
        New Argument("-dumpmaterials", "Dump Materials", "dump out material names"),
        New Argument("-f", "Flip All Triangles", "Flip All Triangles"),
        New Argument("-fullcollide", "Full Collision", "don't truncate really big collisionmodels"),
        New Argument("-h", "Dump Hitboxes", "dump hboxes"),
        New Argument("-i", "Ignore Warnings", "ignore warnings"),
        New Argument("-mdlreport", "Report Performance Info", "report perf info")
    }


End Module