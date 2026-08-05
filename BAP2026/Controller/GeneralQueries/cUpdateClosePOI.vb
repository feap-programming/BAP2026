Imports MySql.Data.MySqlClient

Public Class cUpdateClosePOI


    Dim dbMain As New cMainDb


    Public Function CloseDropPOI(POIID As Integer, Index As Integer)

        Dim dt As DataTable

        GlobalVariables.myParam.Clear()

        GlobalVariables.myParam.Add(New MySqlParameter("pPOIID", POIID))
        GlobalVariables.myParam.Add(New MySqlParameter("pIndex", Index))

        dt = dbMain.dbSelect("SP_CloseOpenPOI")

        Return dt



    End Function

End Class
