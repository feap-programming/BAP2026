Imports MySql.Data.MySqlClient

Public Class cCancelPO

    Dim dbMain As New cMainDb

    Public Function CancelPO(pobline As String, pindex As String, pRemarks As String, pCancelSign As String)

        Dim dt As DataTable


        GlobalVariables.myParam.Clear()


        GlobalVariables.myParam.Add(New MySqlParameter("pOBLINE", pobline))
        GlobalVariables.myParam.Add(New MySqlParameter("pINDEXPO", pindex))
        GlobalVariables.myParam.Add(New MySqlParameter("pRemarks", pRemarks))
        GlobalVariables.myParam.Add(New MySqlParameter("pCloseSign", pCancelSign))

        dt = dbMain.dbSelect("SP_CancelPO")


        Return dt

    End Function


End Class
