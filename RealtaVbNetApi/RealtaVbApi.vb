
Imports RealtaVbNetApi.Base
Imports RealtaVbNetApi.Context

Public Class RealtaVbApi
    Implements IRealtaVbApi

    Private Property _repoManager As IRepositoryManager


    Private ReadOnly _repositoryContext As IRepositoryContext

    Public Sub New(ByVal connstring As String)
        'Console.WriteLine($"CS : {connstring}")

        If _repositoryContext Is Nothing Then
            _repositoryContext = New RepositoryContext(connstring)
        End If
    End Sub

    Public ReadOnly Property RepositoryManager As IRepositoryManager Implements IRealtaVbApi.RepositoryManager
        Get

            If _repoManager Is Nothing Then
                _repoManager = New RepositoryManager(_repositoryContext)
            End If

            Return _repoManager

        End Get
    End Property

    Public Sub SayHello() Implements IRealtaVbApi.SayHello
        Console.WriteLine("HALO")
    End Sub


End Class



