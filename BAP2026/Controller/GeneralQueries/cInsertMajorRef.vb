Public Class cInsertMajorRef


    Dim dbMain As New cMainDb

    Public Function InsertMajorRef(ByVal year As String,
                                   ByVal classCode As String,
                                   ByVal dept As String,
                                   ByVal addedBy As String) As Boolean
        Dim bStatus As Boolean

        GlobalVariables.myParam.Clear()
        dbMain.addParameters("p_Year", year)
        dbMain.addParameters("p_ClassCode", classCode)
        dbMain.addParameters("p_Dept", dept)
        dbMain.addParameters("p_AddedBy", addedBy)

        bStatus = dbMain.dbAED("SP_InsertMajorRef")
        Return bStatus


    End Function
End Class
