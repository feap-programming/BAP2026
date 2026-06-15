Public Class cDeleteUser

    Dim dbMain As New cMainDb
    Public Function DeleteUser(ByVal parUID As Integer) As Boolean


        Dim bStatus As Boolean
        GlobalVariables.myParam.Clear()
        dbMain.addParameters("parUID", parUID)
        bStatus = dbMain.dbAED("SP_DeleteUser")
        Return bStatus

    End Function
End Class
