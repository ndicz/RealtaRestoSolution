Namespace Model
    Public Class RestoOrderMenu

        Private _OrmeID As Integer
        Private _OrmeOrNum As String
        Private _OrmeOrDate As DateTime
        Private _OrmeTotItem As Integer
        Private _OrmeTotDIsc As Decimal
        Private _OrmeTotAmo As Decimal
        Private _OrmePayType As String
        Private _OrmeCard As String
        Private _OrmeIsPaid As String
        Private _OrmeModDate As DateTime
        Private _OrmeUserId As Integer



        Public Sub New(ormeID As Integer, ormeOrNum As String, ormeOrDate As Date, ormeTotItem As Integer, ormeTotDIsc As Decimal, ormeTotAmo As Decimal, ormePayType As String, ormeCard As String, ormeIsPaid As String, ormeModDate As Date, ormeUserId As Integer)
            Me.OrmeID = ormeID
            Me.OrmeOrNum = ormeOrNum
            Me.OrmeOrDate = ormeOrDate
            Me.OrmeTotItem = ormeTotItem
            Me.OrmeTotDIsc = ormeTotDIsc
            Me.OrmeTotAmo = ormeTotAmo
            Me.OrmePayType = ormePayType
            Me.OrmeCard = ormeCard
            Me.OrmeIsPaid = ormeIsPaid
            Me.OrmeModDate = ormeModDate
            Me.OrmeUserId = ormeUserId
        End Sub


        Public Overrides Function ToString() As String
            Return $"
            OrmeID      : {OrmeID}
            OrmeOrNum   : {OrmeOrNum}
            OrmeOrDate  : {OrmeOrDate}
            OrmeTotItem : {OrmeTotItem}
            OrmeTotDIsc : {OrmeTotDIsc}
            OrmeTotAmo  : {OrmeTotAmo}
            OrmePayType : {OrmePayType}
            OrmeCard    : {OrmeCard}
            OrmeIsPaid  : {OrmeIsPaid}
            OrmeModDate : {OrmeModDate}
            OrmeUserId  : {OrmeUserId}
                    "
        End Function

        Public Sub New()
        End Sub


        Public Property OrmeID As Integer
            Get
                Return _OrmeID
            End Get
            Set(value As Integer)
                _OrmeID = value
            End Set
        End Property

        Public Property OrmeOrNum As String
            Get
                Return _OrmeOrNum
            End Get
            Set(value As String)
                _OrmeOrNum = value
            End Set
        End Property

        Public Property OrmeOrDate As Date
            Get
                Return _OrmeOrDate
            End Get
            Set(value As Date)
                _OrmeOrDate = value
            End Set
        End Property

        Public Property OrmeTotItem As Integer
            Get
                Return _OrmeTotItem
            End Get
            Set(value As Integer)
                _OrmeTotItem = value
            End Set
        End Property

        Public Property OrmeTotDIsc As Decimal
            Get
                Return _OrmeTotDIsc
            End Get
            Set(value As Decimal)
                _OrmeTotDIsc = value
            End Set
        End Property

        Public Property OrmeTotAmo As Decimal
            Get
                Return _OrmeTotAmo
            End Get
            Set(value As Decimal)
                _OrmeTotAmo = value
            End Set
        End Property

        Public Property OrmePayType As String
            Get
                Return _OrmePayType
            End Get
            Set(value As String)
                _OrmePayType = value
            End Set
        End Property

        Public Property OrmeCard As String
            Get
                Return _OrmeCard
            End Get
            Set(value As String)
                _OrmeCard = value
            End Set
        End Property

        Public Property OrmeIsPaid As String
            Get
                Return _OrmeIsPaid
            End Get
            Set(value As String)
                _OrmeIsPaid = value
            End Set
        End Property

        Public Property OrmeModDate As Date
            Get
                Return _OrmeModDate
            End Get
            Set(value As Date)
                _OrmeModDate = value
            End Set
        End Property

        Public Property OrmeUserId As Integer
            Get
                Return _OrmeUserId
            End Get
            Set(value As Integer)
                _OrmeUserId = value
            End Set
        End Property
    End Class
End Namespace

