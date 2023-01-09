Namespace Model
    Public Class RestoOrderMenuDetail

        Private _omdeId As Integer
        Private _ormePrice As Decimal
        Private _ormeQyt As Integer
        Private _ormeSubtotal As Integer
        Private _ormeDiscount As Decimal
        Private _omdeOrmeId As Integer
        Private _omdeRemeId As Integer


        Public Sub New(omdeId As Integer, ormePrice As Decimal, ormeQyt As Integer, ormeSubtotal As Integer, ormeDiscount As Decimal, omdeOrmeId As Integer, omdeRemeId As Integer)
            Me.OmdeId = omdeId
            Me.OrmePrice = ormePrice
            Me.OrmeQyt = ormeQyt
            Me.OrmeSubtotal = ormeSubtotal
            Me.OrmeDiscount = ormeDiscount
            Me.OmdeOrmeId = omdeOrmeId
            Me.OmdeRemeId = omdeRemeId
        End Sub

        Public Sub New()
        End Sub

        Public Overrides Function ToString() As String
            Return $"
            OmdeId       : {OmdeId} 
            OrmePrice    : {OrmePrice} 
            OrmeQty      : {OrmeQyt} 
            OrmeSubTotal : {OrmeSubtotal}  
            OrmeDiscount : {OrmeDiscount}  
            OmdeOrmeID   : {OmdeOrmeId} 
            OmdeRemeID   : {OmdeRemeId}"
        End Function

        Public Property OmdeId As Integer
            Get
                Return _omdeId
            End Get
            Set(value As Integer)
                _omdeId = value
            End Set
        End Property

        Public Property OrmePrice As Decimal
            Get
                Return _ormePrice
            End Get
            Set(value As Decimal)
                _ormePrice = value
            End Set
        End Property

        Public Property OrmeQyt As Integer
            Get
                Return _ormeQyt
            End Get
            Set(value As Integer)
                _ormeQyt = value
            End Set
        End Property

        Public Property OrmeSubtotal As Integer
            Get
                Return _ormeSubtotal
            End Get
            Set(value As Integer)
                _ormeSubtotal = value
            End Set
        End Property

        Public Property OrmeDiscount As Decimal
            Get
                Return _ormeDiscount
            End Get
            Set(value As Decimal)
                _ormeDiscount = value
            End Set
        End Property

        Public Property OmdeOrmeId As Integer
            Get
                Return _omdeOrmeId
            End Get
            Set(value As Integer)
                _omdeOrmeId = value
            End Set
        End Property

        Public Property OmdeRemeId As Integer
            Get
                Return _omdeRemeId
            End Get
            Set(value As Integer)
                _omdeRemeId = value
            End Set
        End Property
    End Class

End Namespace