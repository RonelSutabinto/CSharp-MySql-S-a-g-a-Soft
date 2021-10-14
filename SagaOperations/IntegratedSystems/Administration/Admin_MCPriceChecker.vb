Imports MyClassLibrary.Classes
Imports System.Data.SqlClient

Public Class Admin_MCPriceChecker

    Sub ShowModelPrice()
        Dim Parameters As SqlParameter() = {
            New SqlParameter("@ParamModelCode", txt_modelcode.Text),
            New SqlParameter("@ParamTotalDP", txt_DP.Text)
        }

        Using myDataReader As SqlDataReader = class_Database.Procedure_Retrieve(class_Database.ICSConnection, Parameters, "mg_ShowModelPriceChecker")
            If myDataReader IsNot Nothing AndAlso myDataReader.HasRows Then
                myDataReader.Read()
                txt_LCP.Text = Format(Val(myDataReader("lcp").ToString()), "##0.00")
                txt_FinancedAmt.Text = Format(Val(myDataReader("FinancedAmt").ToString()), "##0.00")
                txt_rebates.Text = Format(Val(myDataReader("Rebates").ToString()), "##0.00")
                txt_aoc.Text = Format(Val(myDataReader("aoc").ToString()), "##0.00")
            End If
        End Using
    End Sub

    Sub showModel()
        txt_model.Items.Clear()
        Dim Parameters As SqlParameter() = {}

        Using myDataReader As SqlDataReader = class_Database.Procedure_Retrieve(class_Database.ICSConnection, Parameters, "mg_ShowModel")
            If myDataReader IsNot Nothing AndAlso myDataReader.HasRows Then
                Do While myDataReader.Read()
                    txt_model.Items.Add(myDataReader.Item("modeldesc").ToString)
                Loop
            End If
        End Using
    End Sub

    Sub showModelCode()
        Dim Parameters As SqlParameter() = {New SqlParameter("@ParamModel", txt_model.Text)}

        Using myDataReader As SqlDataReader = class_Database.Procedure_Retrieve(class_Database.ICSConnection, Parameters, "mg_ShowModelcode")
            If myDataReader IsNot Nothing AndAlso myDataReader.HasRows Then
                myDataReader.Read()
                txt_modelcode.Text = myDataReader("ModelCode").ToString()
            End If
        End Using
    End Sub

    Private Sub Admin_MCPriceChecker_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        showModel()
    End Sub

    Sub ComputePMT()
        If txt_terms.Text = String.Empty Then
            'MsgBox("Please supply Terms", vbCritical, Application.CompanyName)
            Return
        End If
        If txt_intrate.Text = String.Empty Then
            'MsgBox("Please supply InterestRate", vbCritical, Application.CompanyName)
            Return
        End If
        txt_effintrate.Text = txt_intrate.Text - 100
        txt_ratePA.Text = Format(Val(txt_effintrate.Text / (txt_terms.Text / 12)), "#.00")

        Dim a As Double
        a = (txt_FinancedAmt.Text * txt_intrate.Text) / 100
        ' MsgBox(a)
        txt_pmt.Text = Format(Math.Round(a / txt_terms.Text), "#,##0.00")
        'MsgBox(txt_pmt.Text)
    End Sub

    Private Sub txt_model_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_model.TextChanged
        showModelCode()
    End Sub

    Private Sub txt_modelcode_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_modelcode.TextChanged
        ShowModelPrice()
    End Sub

    Private Sub txt_DP_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_DP.TextChanged
        If txt_DP.Text = "0.00" Then
            MsgBox("Please Supply D/P", vbInformation, Application.CompanyName)
            Return
        Else
            txt_model.Enabled = True
        End If
    End Sub

    Private Sub txt_terms_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_terms.TextChanged
        ComputePMT()
    End Sub

    Private Sub txt_intrate_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_intrate.TextChanged
        ComputePMT()
    End Sub

    Private Sub txt_pmt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_pmt.TextChanged
        txt_prinpmt.Text = Decimal.Round(txt_FinancedAmt.Text / txt_terms.Text, 2, MidpointRounding.AwayFromZero)
        txt_intpmt.Text = txt_pmt.Text - txt_prinpmt.Text
    End Sub

    Sub ComputeFinancedAmt()
        Dim testDiff As Decimal = 0

        If Val(txt_aoc.Text) > Val(txt_DP.Text) Then
            testDiff = "0.00"
        Else
            testDiff = Val(txt_DP.Text) - Val(txt_aoc.Text)
        End If
        'testLCP = txt_DP.Text - txt_aoc.Text
        txt_FinancedAmt.Text = Val(txt_LCP.Text) - Val(testDiff)
    End Sub

    Private Sub txt_LCP_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_LCP.TextChanged
        ComputeFinancedAmt()
        ComputePMT()
    End Sub

    Private Sub txt_aoc_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_aoc.TextChanged
        ComputeFinancedAmt()
        ComputePMT()
    End Sub

    Private Sub txt_FinancedAmt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_FinancedAmt.TextChanged
        ComputeFinancedAmt()
        ComputePMT()
    End Sub
End Class