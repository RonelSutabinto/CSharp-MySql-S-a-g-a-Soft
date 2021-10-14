Namespace Models
    Public Class Warehouse
        Private _id As Integer
        Private _code As String
        Private _category As String
        Private _description As String

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

        Public Property Category As String
            Get
                Return _category
            End Get
            Set(ByVal value As String)
                _category = value
            End Set
        End Property

        Public Property Description As String
            Get
                Return _description
            End Get
            Set(ByVal value As String)
                _description = value
            End Set
        End Property
    End Class
End Namespace