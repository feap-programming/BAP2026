Public Class cInsertRFQ

    Dim dbMain As New cMainDb

    Public Function InsertRFQ(ByVal parRFQNo As Integer, ByVal parDateRequest As String, ByVal parEmpName As String, ByVal parDept As String,
                                ByVal parSection As String, ByVal parCheckedBy As String, ByVal parApprovedBy As String,
                                ByVal parCPosition As String, ByVal parAPosition As String) As Boolean
        Dim bStatus As Boolean
        GlobalVariables.myParam.Clear()
        dbMain.addParameters("parRFQNo", parRFQNo)
        dbMain.addParameters("parDateRequest", parDateRequest)
        dbMain.addParameters("parEmpNo", GlobalVariables.empNo)
        dbMain.addParameters("parEmpName", parEmpName)
        dbMain.addParameters("parDept", parDept)
        dbMain.addParameters("parSection", parSection)
        dbMain.addParameters("parCheckedBy", parCheckedBy)
        dbMain.addParameters("parApprovedBy", parApprovedBy)
        dbMain.addParameters("parCPosition", parCPosition)
        dbMain.addParameters("parAPosition", parAPosition)
        dbMain.addParameters("parSelectedDept", GlobalVariables.SelectedDept)
        bStatus = dbMain.dbAED("SP_InsertRFQ")
        Return bStatus
    End Function

    Public Function InsertRFQChild(ByVal parRFQNo As Integer, ByVal parTypeExpense As String, ByVal parDesc As String, ByVal parQty As String,
                                ByVal parUOM As String, ByVal parDateNeeded As String, ByVal parRemarks As String, ByVal parChemical As String,
                                ByVal parNo As String, ByVal parPPE As String) As Boolean
        Dim bStatus As Boolean
        GlobalVariables.myParam.Clear()
        dbMain.addParameters("parRFQNo", parRFQNo)
        dbMain.addParameters("parTypeExpense", parTypeExpense)
        dbMain.addParameters("parDesc", parDesc)
        dbMain.addParameters("parQty", parQty)
        dbMain.addParameters("parUOM", parUOM)
        dbMain.addParameters("parDateNeeded", parDateNeeded)
        dbMain.addParameters("parRemarks", parRemarks)
        dbMain.addParameters("parChemical", parChemical)
        dbMain.addParameters("parNo", parNo)
        dbMain.addParameters("parPPE", parPPE)
        bStatus = dbMain.dbAED("SP_InsertRFQChild")
        Return bStatus
    End Function
End Class
