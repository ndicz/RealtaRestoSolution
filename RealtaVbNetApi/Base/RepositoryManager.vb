Imports RealtaVbNetApi.Context
Imports RealtaVbNetApi.Repository

Namespace Base

    Public Class RepositoryManager

        Implements IRepositoryManager


        Private _restoOrderMenuDetailRepository As IRestoOrderMenuDetailRepository

        Private _restomenus As IRestoMenusRepository

        Private _repositoryContext As IRepositoryContext


        Public Sub New(repositoryContext As IRepositoryContext)
            _repositoryContext = repositoryContext
        End Sub

        Public ReadOnly Property RestoOrderMenuDetail As IRestoOrderMenuDetailRepository Implements IRepositoryManager.RestoOrderMenuDetail
            Get
                If _restoOrderMenuDetailRepository Is Nothing Then
                    _restoOrderMenuDetailRepository = New RestoOrderMenuDetailRepository(_repositoryContext)
                End If
                Return _restoOrderMenuDetailRepository

            End Get
        End Property

        Public ReadOnly Property RestoMenus As IRestoMenusRepository Implements IRepositoryManager.RestoMenus
            Get
                If _restomenus Is Nothing Then
                    _restomenus = New RestoMenusRepository(_repositoryContext)
                End If

                Return _restomenus
            End Get
        End Property

        'Public ReadOnly Property RestoOrderMenus As IRestoOrderMenusRepository Implements IRepositoryManager.RestoOrderMenus
        '    Get
        '        Throw New NotImplementedException()
        '    End Get
        'End Property
    End Class
End Namespace


