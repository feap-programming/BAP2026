Imports MySql.Data.MySqlClient

Public Class cCloseOpenPO

    Dim dbMain As New cMainDb

    Public Function CloseOpenPO(OBLINE As String, pIndex As String, pRemarks As String, pCancelSIgn As String)

        Dim dt As DataTable

        GlobalVariables.myParam.Clear()

        GlobalVariables.myParam.Add(New MySqlParameter("pOBLINE", OBLINE))
        GlobalVariables.myParam.Add(New MySqlParameter("pINDEXPO", pIndex))
        GlobalVariables.myParam.Add(New MySqlParameter("pRemarks", pRemarks))
        GlobalVariables.myParam.Add(New MySqlParameter("pCancelSign", pCancelSIgn))


        dt = dbMain.dbSelect("SP_CloseOpenPO")

        Return dt

    End Function


End Class
