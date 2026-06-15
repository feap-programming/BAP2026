Public Class cSelectAllActivityPR

    Dim dbMain As New cMainDb


    Public Function selectAllACtivity()


        Dim dt As DataTable

        GlobalVariables.myParam.Clear()
        dt = dbMain.dbSelect("SP_SelectAllActivity")



        Return dt


    End Function

End Class
