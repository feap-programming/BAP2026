Public Class cAddConversion

    Dim dbMain As New cMainDb

    Public Function insertConversion(p_Currency As String, p_Conversion As Decimal) As Boolean


        GlobalVariables.myParam.Clear()

        Dim bStatus As Boolean


        GlobalVariables.myParam.Add(New MySql.Data.MySqlClient.MySqlParameter("p_Currency", p_Currency))
        GlobalVariables.myParam.Add(New MySql.Data.MySqlClient.MySqlParameter("p_Conversion", p_Conversion))

        bStatus = dbMain.dbAED("SP_InsertConversion")
        Return bStatus
    End Function

End Class