Imports RealtaVbNetApi.Model

Namespace Repository
    Public Interface IRestoMenuPhotosRepository
        Function CreateRestoMenusPhotos(ByVal restomenuphotos As RestoMenuPhotos) As RestoMenuPhotos

        Function DeleteRestoMenusPhotos(ByVal id As Int32) As Int32

        Function FindAllRestoMenusPhotos() As List(Of RestoMenuPhotos)

        Function FindAllRestoMenusPlAsync() As Task(Of List(Of RestoMenuPhotos))

        Function FindRestoMenusPById(ByVal id As Int32) As RestoMenuPhotos

        Function UpdateRestoMenusPById(rempId As Integer, rempThumb As String, rempPrimary As Boolean, rempUrl As String, rempReme As Integer, Optional showCommand As Boolean = False) As Boolean

        Function UpdateRestoMenusPBySp(id As Integer, value As String, Optional showCommand As Boolean = False) As Boolean
    End Interface
End Namespace