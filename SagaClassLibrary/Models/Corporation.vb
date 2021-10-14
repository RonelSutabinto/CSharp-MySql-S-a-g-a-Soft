Namespace Models
    Public Class Corporation
        Private _id As Integer
        Private _code As String
        Private _name As String
        Private _fullname As String
        Private _address As String

        Public Property ID As Integer
            Get
                Return _id
            End Get
            Set(ByVal value As Integer)
                _id = value
            End Set
        End Property

        Public Property Code As String
            Get
                Return _code
            End Get
            Set(ByVal value As String)
                _code = value
            End Set
        End Property

        Public Property Name As String
            Get
                Return _name
            End Get
            Set(ByVal value As String)
                _name = value
            End Set
        End Property

        Public Property FullName As String
            Get
                Return _fullname
            End Get
            Set(ByVal value As String)
                _fullname = value
            End Set
        End Property

        Public Property Address As String
            Get
                Return _address
            End Get
            Set(ByVal value As String)
                _address = value
            End Set
        End Property
    End Class
End Namespace