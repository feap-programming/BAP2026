Imports MySql.Data.MySqlClient

Public Class cCancelPOI


    Dim dbMain As New cMainDb

    Public Function CancelPOI(pPOIID As Integer, pIndex As Integer)

        Dim dt As DataTable

        GlobalVariables.myParam.Clear()

        GlobalVariables.myParam.Add(New MySqlParameter("pPOIID", pPOIID))
        GlobalVariables.myParam.Add(New MySqlParameter("pIndex", pIndex))



        dt = dbMain.dbSelect("SP_CancelPOI")

        Return dt

    End Function

End Class
