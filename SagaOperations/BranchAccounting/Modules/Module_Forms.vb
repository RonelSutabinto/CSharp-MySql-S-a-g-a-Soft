Namespace Modules
    Module Module_Forms

        Friend Sub Show_Journal_Entries(ByVal sReference As String)
            Dim frm As New Forms.XtraForm_Journal_Entries With {.Text = $"{ .Text} Reference:{sReference}"}
            With frm
                .eMode = Forms.XtraForm_Journal_Entries.LoadMode.mReference
                .sReference = sReference
                .Bar_Parameters.Visible = True

                .Show()

                .Form_Data_Load(sReference)
            End With
        End Sub

    End Module
End Namespace