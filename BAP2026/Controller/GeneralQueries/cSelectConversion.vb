Public Class cSelectConversion



    Dim dbMain As New cMainDb
    Public Function SelectConversion(p_Amount As Decimal) As String
        GlobalVariables.myParam.Clear()
        GlobalVariables.myParam.Add(New MySql.Data.MySqlClient.MySqlParameter("p_Amount", p_Amount))
        Dim dt As DataTable = dbMain.dbSelect("SP_SelectConversion")
        If dt IsNot Nothing AndAlso dt.Rows.Count > 0 Then
            Return dt.Rows(0)("AmountInWords").ToString()
        Else
            Return String.Empty
        End If
    End Function

End Class
