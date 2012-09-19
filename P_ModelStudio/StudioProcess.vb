Imports System.ComponentModel
Imports System.Text

Public Class StudioProcess
    Inherits BackgroundWorker

    Private Const kProcessName As String = ""
    Private _studiomdl As Process

    Public ReadOnly Property ProcessName As String
        Get
            Return kProcessName
        End Get
    End Property

    Public Property Arguments As String

    Public Event FinishedExecution As Action(Of String)

    Public Sub New()
        AddHandler MyBase.DoWork, AddressOf DoWork
        AddHandler MyBase.RunWorkerCompleted, AddressOf WorkCompleted
    End Sub

    Private Shadows Sub DoWork(ByVal sender As Object, ByVal e As EventArgs)
        Dim startinfo As New ProcessStartInfo
        startinfo.FileName = kProcessName
        startinfo.Arguments = Arguments
        startinfo.UseShellExecute = False
        startinfo.RedirectStandardOutput = True

        _studiomdl = Process.Start(startinfo)

        _studiomdl.WaitForExit()
    End Sub

    Private Shadows Sub WorkCompleted(ByVal sender As Object, ByVal e As EventArgs)
        RaiseEvent FinishedExecution(_studiomdl.StandardOutput.ReadToEnd())
    End Sub

    Public Sub Start()
        If IsBusy Then
            ' Cancel the current work
            CancelAsync()
        End If

        RunWorkerAsync()
    End Sub

End Class
