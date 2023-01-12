Imports RealtaVbNetApi.Model

Namespace Repository
    Public Interface IRestoMenuRepository
        Function CreateRestoMenus(ByVal restomenus As RestoMenu) As RestoMenu

        Function DeleteRestoMenus(ByVal id As Int32) As Int32

        Function FindAllRestoMenus() As List(Of RestoMenu)

        Function FindAllRestoMenuslAsync() As Task(Of List(Of RestoMenu))

        Function FindRestoMenusById(ByVal id As Int32) As RestoMenu

        Function UpdateRestoMenuslById(remeId As Integer, remeName As String, remeDesc As String, remePrice As Decimal, remeStatus As String, remeModDate As Date, Optional showCommand As Boolean = False) As Boolean

        Function UpdateRestoMenusBySp(id As Integer, value As String, Optional showCommand As Boolean = False) As Boolean
    End Interface
End Namespace