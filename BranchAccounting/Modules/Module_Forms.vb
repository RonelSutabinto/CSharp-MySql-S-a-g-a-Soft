Namespace Modules
    Module Module_Forms

        Friend Sub Show_Journal_Entries(ByVal sReference As String)
            Dim frm As New Forms.frm_Journal_Entries_Branch With {.Text = $"{ .Text} Reference:{sReference}"}
            With frm
                .eMode = Forms.frm_Journal_Entries_Branch.LoadMode.mReference
                .sReference = sReference
                .Bar_Parameters.Visible = True

                .Show()

                .Form_Load_Data(sReference)
            End With
        End Sub

    End Module
End Namespace