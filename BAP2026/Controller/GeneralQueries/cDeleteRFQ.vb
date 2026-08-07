Public Class cDeleteRFQ

    Dim dbMain As New cMainDb

    Public Function DeleteRFQ(ByVal parRFQNo As Integer) As Boolean

        Dim bstatus As Boolean

        GlobalVariables.myParam.Clear()
        dbMain.addParameters("parRFQNo", parRFQNo)
        bstatus = dbMain.dbAED("SP_DeleteRFQ")

        Return bstatus
    End Function

    Public Function DeleteRFQChild(ByVal parRFQNo As Integer) As Boolean

        Dim bstatus As Boolean

        GlobalVariables.myParam.Clear()
        dbMain.addParameters("parRFQNo", parRFQNo)
        bstatus = dbMain.dbAED("SP_DeleteRFQChild")

        Return bstatus
    End Function

End Class
