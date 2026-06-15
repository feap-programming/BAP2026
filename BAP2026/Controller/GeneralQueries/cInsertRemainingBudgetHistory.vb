Imports MySql.Data.MySqlClient

Public Class CInsertRemainingBudgetHistory

    Dim dbMain As New cMainDb

    Public Function InsertRBHistory(TransCode As String, RemBud As Decimal, UPO As Decimal, PO As Decimal, PRNotPO As Decimal, Budget As Decimal)

        Dim dt As DataTable

        GlobalVariables.myParam.Clear()

        GlobalVariables.myParam.Add(New MySqlParameter("@Transcode", TransCode))
        GlobalVariables.myParam.Add(New MySqlParameter("@RemBud", RemBud))
        GlobalVariables.myParam.Add(New MySqlParameter("@UPO", UPO))
        GlobalVariables.myParam.Add(New MySqlParameter("@PO", PO))
        GlobalVariables.myParam.Add(New MySqlParameter("@PRNotPO", PRNotPO))
        GlobalVariables.myParam.Add(New MySqlParameter("@Budget", Budget))

        dt = dbMain.dbSelect("SP_InsertRemBudHistory")

        Return dt

    End Function


End Class
