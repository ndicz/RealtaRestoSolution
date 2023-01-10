Imports RealtaVbNetApi.Model

Namespace Repository
    Public Interface IRestoMenusRepository
        Function CreateRestoMenus(ByVal restomenus As RestoMenus) As RestoMenus

        Function DeleteRestoMenus(ByVal id As Int32) As Int32

        Function FindAllRestoMenus() As List(Of RestoMenus)

        Function FindAllRestoMenuslAsync() As Task(Of List(Of RestoMenus))

        Function FindRestoMenusById(ByVal id As Int32) As RestoMenus

        Function UpdateRestoMenuslById(id As Integer, value As String, Optional showCommand As Boolean = False) As Boolean

        Function UpdateRestoMenusBySp(id As Integer, value As String, Optional showCommand As Boolean = False) As Boolean
    End Interface
End Namespace