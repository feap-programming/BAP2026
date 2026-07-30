Imports MySql.Data.MySqlClient

Public Class cVPRRemove

    Dim dbMain As New cMainDb

    Public Function removeVPR(pOrderID As Integer, pTranscode As String, pPRNO As String)

        Dim dt As DataTable

        GlobalVariables.myParam.Clear()

        GlobalVariables.myParam.Add(New MySqlParameter("p_OrderID", pOrderID))
        GlobalVariables.myParam.Add(New MySqlParameter("p_TransCode", pTranscode))
        GlobalVariables.myParam.Add(New MySqlParameter("p_PRNo", pPRNO))


        dt = dbMain.dbSelect("SP_VPRRemove")

        Return dt


    End Function

End Class
