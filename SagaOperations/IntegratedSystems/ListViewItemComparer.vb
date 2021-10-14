Class ListViewItemComparer

    Private _sortOrder As SqlClient.SortOrder
    Private _p1 As Integer

    Sub New(ByVal p1 As Integer, ByVal sortOrder As SqlClient.SortOrder)
        ' TODO: Complete member initialization
        _p1 = p1
        _sortOrder = sortOrder
    End Sub

End Class