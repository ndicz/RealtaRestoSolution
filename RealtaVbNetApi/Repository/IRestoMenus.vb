Imports RealtaVbNetApi.Model

Namespace Repository
    Public Interface IRestoMenus
        Function CreateRestoMenus(ByVal region As RestoOrderMenuDetail) As RestoOrderMenuDetail

        Function DeleteRestoMenus(ByVal id As Int32) As Int32

        Function FindAllRestoMenus() As List(Of RestoOrderMenuDetail)

        Function FindAllRestoMenuslAsync() As Task(Of List(Of RestoOrderMenuDetail))

        Function FindRestoMenusById(ByVal id As Int32) As RestoOrderMenuDetail

        Function UpdateRestoMenuslById(id As Integer, value As String, Optional showCommand As Boolean = False) As Boolean

        Function UpdateRestoMenusBySp(id As Integer, value As String, Optional showCommand As Boolean = False) As Boolean
    End Interface
End Namespace