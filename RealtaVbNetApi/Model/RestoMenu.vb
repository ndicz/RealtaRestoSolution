Namespace Model

    Public Class RestoMenu

        Private _remeFaciId As Integer
        Private _remeId As Integer
        Private _remeName As String
        Private _remeDesc As String
        Private _remePrice As Decimal
        Private _remeStatus As String
        Private _remeModDate As Date

        Public Sub New(remeFaciId As Integer, remeId As Integer, remeName As String, remeDesc As String, remePrice As Decimal, remeStatus As String, remeModDate As Date)
            Me.RemeFaciId = remeFaciId
            Me.RemeId = remeId
            Me.RemeName = remeName
            Me.RemeDesc = remeDesc
            Me.RemePrice = remePrice
            Me.RemeStatus = remeStatus
            Me.RemeModDate = remeModDate
        End Sub

        Public Sub New()
        End Sub

        Public Overrides Function ToString() As String

            Return $"
                  
            RemeFaciId  : {RemeFaciId}
            RemeId      : {RemeId}
            RemeName    : {RemeName}
            RemeDesc    : {RemeDesc}
            RemePrice   : {RemePrice}
            RemeStatus  : {RemeStatus}
            RemeModDate : {RemeModDate}
                    
                    "

        End Function
        Public Property RemeFaciId As Integer
            Get
                Return _remeFaciId
            End Get
            Set(value As Integer)
                _remeFaciId = value
            End Set
        End Property

        Public Property RemeId As Integer
            Get
                Return _remeId
            End Get
            Set(value As Integer)
                _remeId = value
            End Set
        End Property

        Public Property RemeName As String
            Get
                Return _remeName
            End Get
            Set(value As String)
                _remeName = value
            End Set
        End Property

        Public Property RemeDesc As String
            Get
                Return _remeDesc
            End Get
            Set(value As String)
                _remeDesc = value
            End Set
        End Property

        Public Property RemePrice As Decimal
            Get
                Return _remePrice
            End Get
            Set(value As Decimal)
                _remePrice = value
            End Set
        End Property

        Public Property RemeStatus As String
            Get
                Return _remeStatus
            End Get
            Set(value As String)
                _remeStatus = value
            End Set
        End Property

        Public Property RemeModDate As Date
            Get
                Return _remeModDate
            End Get
            Set(value As Date)
                _remeModDate = value
            End Set
        End Property



    End Class


End Namespace
