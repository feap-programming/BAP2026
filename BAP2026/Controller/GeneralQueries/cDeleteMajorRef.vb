Public Class cDeleteMajorRef

    Dim dbMain As New cMainDb

    Public Function DeleteMajorRef(ByVal parMID As Integer) As Boolean

        Dim bstatus As Boolean

        GlobalVariables.myParam.Clear()
        dbMain.addParameters("parMID", parMID)
        bstatus = dbMain.dbAED("SP_DeleteMajorRef")

        Return bstatus
    End Function

End Class


