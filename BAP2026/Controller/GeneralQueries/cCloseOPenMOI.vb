Imports MySql.Data.MySqlClient

Public Class cCloseOPenMOI

    Dim dbMain As New cMainDb


    Public Function closeOpenMoi(pMoiid As Integer, pSOUT As Decimal)

        Dim dt As DataTable

        GlobalVariables.myParam.Clear()

        GlobalVariables.myParam.Add(New MySqlParameter("pMOIID", pMoiid))
        GlobalVariables.myParam.Add(New MySqlParameter("pSOUT", pSOUT))

        dt = dbMain.dbSelect("SP_CloseOpenMOI")

        Return dt

    End Function


End Class

