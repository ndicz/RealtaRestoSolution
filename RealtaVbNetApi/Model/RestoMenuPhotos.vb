Namespace Model
    Public Class RestoMenuPhotos

        Private _rempId As Integer
        Private _rempThumb As String
        Private _rempPrimary As Boolean
        Private _rempUrl As String
        Private _rempReme As Integer

        Public Sub New(rempId As Integer, rempThumb As String, rempPrimary As Boolean, rempUrl As String, rempReme As Integer)
            Me.RempId = rempId
            Me.RempThumb = rempThumb
            Me.RempPrimary = rempPrimary
            Me.RempUrl = rempUrl
            Me.RempReme = rempReme
        End Sub
        Public Sub New()
        End Sub

        Public Overrides Function ToString() As String
            Return $"
            RempId      : {RempId}
            RempThumb   : {RempThumb}
            RempPrimary : {RempPrimary}
            RempUrl     : {RempUrl}
            RempReme    : {RempReme}



                    "
        End Function

        Public Property RempId As Integer
            Get
                Return _rempId
            End Get
            Set(value As Integer)
                _rempId = value
            End Set
        End Property

        Public Property RempThumb As String
            Get
                Return _rempThumb
            End Get
            Set(value As String)
                _rempThumb = value
            End Set
        End Property

        Public Property RempPrimary As Boolean
            Get
                Return _rempPrimary
            End Get
            Set(value As Boolean)
                _rempPrimary = value
            End Set
        End Property

        Public Property RempUrl As String
            Get
                Return _rempUrl
            End Get
            Set(value As String)
                _rempUrl = value
            End Set
        End Property

        Public Property RempReme As Integer
            Get
                Return _rempReme
            End Get
            Set(value As Integer)
                _rempReme = value
            End Set
        End Property
    End Class
End Namespace
Public Class RestoMenuPhotos

End Class
