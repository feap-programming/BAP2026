Public Class cSelectAllProcess

    Dim dbMain As New cMainDb


    Public Function cSElectProcess() As DataTable


        Dim dt As DataTable
        GlobalVariables.myParam.Clear()
        dt = dbMain.dbSelect("SP_SelectAllProcess")

        Return dt





    End Function

End Class
