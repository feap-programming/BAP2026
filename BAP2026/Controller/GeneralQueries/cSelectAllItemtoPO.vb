Public Class cSelectAllItemtoPO

    Dim dbMain As New cMainDb



    Public Function cSelectAllItemPO()


        Dim dt As DataTable

        GlobalVariables.myParam.Clear()

        dt = dbMain.dbSelect("SP_CPO_SELECTALLItemToPO")

        Return dt

    End Function

End Class
