Imports RealtaVbNetApi.Model

Namespace Repository
    Public Interface IRestoOrderMenuDetailRepository

        Function CreateRestoOrderDetail(ByVal restoOrderMenu As RestoOrderMenuDetail) As RestoOrderMenuDetail

        Function DeleteRestoOrderDetail(ByVal id As Int32) As Int32

        Function FindAllRestoOrderDetail() As List(Of RestoOrderMenuDetail)

        Function FindAllRestoOrderDetailAsync() As Task(Of List(Of RestoOrderMenuDetail))

        Function FindRestoOrderDetailById(ByVal id As Int32) As RestoOrderMenuDetail

        Function UpdateRestoOrderDetailById(omdeId As Integer, ormePrice As Decimal, ormeQyt As Integer, ormeSubtotal As Integer, ormeDiscount As Decimal, omdeOrmeId As Integer, omdeRemeId As Integer, Optional showCommand As Boolean = False) As Boolean

        Function UpdateRestoOrderDetailBySp(id As Integer, value As String, Optional showCommand As Boolean = False) As Boolean
    End Interface
End Namespace

