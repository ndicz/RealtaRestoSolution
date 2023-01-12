Imports RealtaVbNetApi.Context

Namespace Repository
    Public Class RestoMenuPhotosRepository


        Implements IRestoMenuPhotosRepository

        Private ReadOnly _context As IRepositoryContext

        Public Sub New(context As IRepositoryContext)
            _context = context
        End Sub

        Public Function CreateRestoMenusPhotos(restomenuphotos As RestoMenuPhotos) As RestoMenuPhotos Implements IRestoMenuPhotosRepository.CreateRestoMenusPhotos
            Throw New NotImplementedException()
        End Function

        Public Function DeleteRestoMenusPhotos(id As Integer) As Integer Implements IRestoMenuPhotosRepository.DeleteRestoMenusPhotos
            Throw New NotImplementedException()
        End Function

        Public Function FindAllRestoMenusPhotos() As List(Of RestoMenuPhotos) Implements IRestoMenuPhotosRepository.FindAllRestoMenusPhotos
            Throw New NotImplementedException()
        End Function

        Public Function FindAllRestoMenusPlAsync() As Task(Of List(Of RestoMenuPhotos)) Implements IRestoMenuPhotosRepository.FindAllRestoMenusPlAsync
            Throw New NotImplementedException()
        End Function

        Public Function FindRestoMenusPById(id As Integer) As RestoMenuPhotos Implements IRestoMenuPhotosRepository.FindRestoMenusPById
            Throw New NotImplementedException()
        End Function

        Public Function UpdateRestoMenusPById(rempId As Integer, rempThumb As String, rempPrimary As Boolean, rempUrl As String, rempReme As Integer, Optional showCommand As Boolean = False) As Boolean Implements IRestoMenuPhotosRepository.UpdateRestoMenusPById
            Throw New NotImplementedException()
        End Function

        Public Function UpdateRestoMenusPBySp(id As Integer, value As String, Optional showCommand As Boolean = False) As Boolean Implements IRestoMenuPhotosRepository.UpdateRestoMenusPBySp
            Throw New NotImplementedException()
        End Function
    End Class
End Namespace

