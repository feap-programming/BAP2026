Public Class cGetAllDeptCode

    Dim dbMain As New cMainDb




    Public Function cgetAllDeptCode()


        Dim dt As DataTable
        GlobalVariables.myParam.Clear()
        dt = dbMain.dbSelect("SP_GetAllDeptCode")

        Return dt

    End Function


End Class
