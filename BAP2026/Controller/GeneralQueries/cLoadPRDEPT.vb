Imports MySql.Data.MySqlClient

Public Class cLoadPRDEPT

    Dim dbMain As New cMainDb

    Public Function loadPRDEPT(FMONTH As Date, fyear As Date, dept As String)

        Dim dt As DataTable

        GlobalVariables.myParam.Clear()
        GlobalVariables.myParam.Add(New MySqlParameter("FMONTH", FMONTH))
        GlobalVariables.myParam.Add(New MySqlParameter("FYEAR", fyear))
        GlobalVariables.myParam.Add(New MySqlParameter("DEPT", dept))
        'GlobalVariables.myParam.Add(New MySqlParameter("PRNO", prno))

        dt = dbMain.dbSelect("PR_GetPRNonAdmin")

        Return dt


    End Function


End Class
