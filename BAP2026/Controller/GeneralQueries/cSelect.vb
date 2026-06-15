Public Class cSelect

    Dim dbMain As New cMainDb

    Public Function SelectAllDepartments() As DataTable
        Dim dt As DataTable
        GlobalVariables.myParam.Clear()
        dt = dbMain.dbSelect("SP_SelectAllDepartment")
        Return dt
    End Function



End Class
