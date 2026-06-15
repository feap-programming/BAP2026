Imports MySql.Data.MySqlClient

Public Class cGetTJPY

    Dim dbMain As New cMainDb

    Public Function TJPYLinq(BudRefNum As String)

        Dim dt As DataTable

        GlobalVariables.myParam.Clear()
        GlobalVariables.myParam.Add(New MySqlParameter("BudRefNum", BudRefNum))  ' <-- pass parameter   

        dt = dbMain.dbSelect("SP_GetTJPY")

        Return dt

    End Function

End Class
