Public Class cSelectUOM

    Dim dbMain As New cSapDb


    Public Function SelectUOM() As DataTable

        Dim dt As DataTable
        GlobalVariables.myParam.Clear()

        dt = dbMain.dbSelect("select distinct T0.BuyUnitMsr from OITM T0 where T0.BuyUnitMsr is not null ORDER BY BuyUnitMsr")


        Return dt

    End Function

End Class
