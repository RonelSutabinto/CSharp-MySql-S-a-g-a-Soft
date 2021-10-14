Namespace Models
    Public Class MCTransaction
        Private _id As Integer
        Private _transaction
        Private _description

        Public Property ID As Integer
            Get
                Return _id
            End Get
            Set(ByVal value As Integer)
                _id = value
            End Set
        End Property

        Public Property Transaction As String
            Get
                Return _transaction
            End Get
            Set(ByVal value As String)
                _transaction = value
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