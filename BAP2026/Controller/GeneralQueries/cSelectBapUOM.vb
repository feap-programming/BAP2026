Public Class cSelectBapUOM

    Dim dbMain As New cMainDb

    Public Function selectUOM()

        Dim dt As DataTable

        GlobalVariables.myParam.Clear()

        dt = dbMain.dbSelect("SP_SelectAllUOM")

        Return dt

    End Function

End Class
