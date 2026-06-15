Public Class cGenerateConversion




    Dim dbMain As New cMainDb

        Public Function GetLatestRate(currency As String) As Decimal

            GlobalVariables.myParam.Clear()
            dbMain.addParameters("p_Currency", currency)

            Dim dt As DataTable = dbMain.dbSelect("SP_SelectLatestConversion")

            If dt IsNot Nothing AndAlso dt.Rows.Count > 0 Then
                Return Convert.ToDecimal(dt.Rows(0)("fldAmount"))
            Else
                Return 0D ' or default
            End If

        End Function

    End Class



