Imports RealtaVbNetApi.Model

Namespace Repository
    Public Interface IRestoOrderMenuRepository
        Function CreateRestoOrderMenus(ByVal ordermenu As RestoOrderMenu) As RestoOrderMenu

        Function DeleteRestoOrderMenus(ByVal id As Int32) As Int32

        Function FindAllRestoOrderMenus() As List(Of RestoOrderMenu)

        Function FindAllRestoOrderMenuslAsync() As Task(Of List(Of RestoOrderMenu))

        Function FindRestoOrderMenusById(ByVal id As Int32) As RestoOrderMenu

        Function UpdateRestoOrderMenuslById(ormeID As Integer, ormeOrNum As String, ormeOrDate As Date, ormeTotItem As Integer, ormeTotDIsc As Decimal, ormeTotAmo As Decimal, ormePayType As String, ormeCard As String, ormeIsPaid As Char, ormeModDate As Date, ormeUserId As Integer, Optional showCommand As Boolean = False) As Boolean

        Function UpdateRestoOrderMenusBySp(ormeID As Integer, ormeOrNum As String, ormeOrDate As Date, ormeTotItem As Integer, ormeTotDIsc As Decimal, ormeTotAmo As Decimal, ormePayType As String, ormeCard As String, ormeIsPaid As Char, ormeModDate As Date, ormeUserId As Integer, Optional showCommand As Boolean = False) As Boolean
    End Interface
End Namespace