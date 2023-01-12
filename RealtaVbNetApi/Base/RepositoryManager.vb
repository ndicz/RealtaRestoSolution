Imports RealtaVbNetApi.Context
Imports RealtaVbNetApi.Repository

Namespace Base

    Public Class RepositoryManager

        Implements IRepositoryManager


        Private _restoOrderMenuDetailRepository As IRestoOrderMenuDetailRepository

        Private _restomenus As IRestoMenuRepository

        Private _restoOrderMenu As IRestoOrderMenuRepository

        Private _restoMenuP As IRestoMenuPhotosRepository

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

        Public ReadOnly Property RestoMenus As IRestoMenuRepository Implements IRepositoryManager.RestoMenus
            Get
                If _restomenus Is Nothing Then
                    _restomenus = New RestoMenusRepository(_repositoryContext)
                End If

                Return _restomenus
            End Get
        End Property

        Public ReadOnly Property RestoOrderMenu As IRestoOrderMenuRepository Implements IRepositoryManager.RestoOrderMenu
            Get
                If _restoOrderMenu Is Nothing Then
                    _restoOrderMenu = New RestoOrderMenuRepository(_repositoryContext)
                End If

                Return _restoOrderMenu
            End Get
        End Property

        Public ReadOnly Property RestoMenuPhotos As IRestoMenuPhotosRepository Implements IRepositoryManager.RestoMenuPhotos

            Get
                If _restoMenuP Is Nothing Then
                    _restoMenuP = New RestoOrderMenuRepository(_repositoryContext)
                End If

                Return _restoMenuP

            End Get
        End Property
    End Class
End Namespace


