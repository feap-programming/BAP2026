Public Class cUpdateUser

    Dim dbMain As New cMainDb


    Public Function UpdateUser(ByVal parUID As Integer, ByVal parEmpNo As String, ByVal parEmpFirstname As String, parEmpLastName As String, parEmpMiddleName As String, parDepartment As String, parSection As String, parUserType As String, parDeptAll As String, parDeptPresident As String, parDeptHRGA As String, parDeptAcctg As String, parDeptLog As String, parDeptEval As String, parDeptFac As String, parDeptEngg As String, parDeptProd As String, parDeptPC As String,
                              parDeptQA As String, parDeptWH As String, parDeptFab As String, parDeptFFC As String, parDeptProject As String, parDeptCommon As String, parDeptMIS As String, parDeptBSS As String, parDeptQC As String, parDeptIVG As String, parDeptKaizen As String, parDeptFGM As String, parDeptTraining As String, parDeptSafety As String, parDeptEnggInj As String, parDeptEnggSRC As String)


        Dim bStatus As Boolean
        GlobalVariables.myParam.Clear()
        dbMain.addParameters("parUID", parUID)
        dbMain.addParameters("parEmpNo", parEmpNo)
        dbMain.addParameters("parEmpFirstName", parEmpFirstname)
        dbMain.addParameters("parEmpLastName", parEmpLastName)
        dbMain.addParameters("parEmpMiddleName", parEmpMiddleName)
        dbMain.addParameters("parDepartment", parDepartment)
        dbMain.addParameters("parSection", parSection)
        dbMain.addParameters("parUserType", parUserType)
        dbMain.addParameters("parDeptAll", parDeptAll)
        dbMain.addParameters("parDeptPresident", parDeptPresident)
        dbMain.addParameters("parDeptHRGA", parDeptHRGA)
        dbMain.addParameters("parDeptAcctg", parDeptAcctg)
        dbMain.addParameters("parDeptLog", parDeptLog)
        dbMain.addParameters("parDeptEval", parDeptEval)
        dbMain.addParameters("parDeptFac", parDeptFac)
        dbMain.addParameters("parDeptEngg", parDeptEngg)
        dbMain.addParameters("parDeptProd", parDeptProd)
        dbMain.addParameters("parDeptPC", parDeptPC)
        dbMain.addParameters("parDeptQA", parDeptQA)
        dbMain.addParameters("parDeptWH", parDeptWH)
        dbMain.addParameters("parDeptFab", parDeptFab)
        dbMain.addParameters("parDeptFFC", parDeptFFC)
        dbMain.addParameters("parDeptProject", parDeptProject)
        dbMain.addParameters("parDeptCommon", parDeptCommon)
        dbMain.addParameters("parDeptMIS", parDeptMIS)
        dbMain.addParameters("parDeptBSS", parDeptBSS)
        dbMain.addParameters("parDeptQC", parDeptQC)
        dbMain.addParameters("parDeptIVG", parDeptIVG)
        dbMain.addParameters("parDeptKaizen", parDeptKaizen)
        dbMain.addParameters("parDeptFGM", parDeptFGM)
        dbMain.addParameters("parDeptTraining", parDeptTraining)
        dbMain.addParameters("parDeptSafety", parDeptSafety)
        dbMain.addParameters("parDeptEnggInj", parDeptEnggInj)
        dbMain.addParameters("parDeptEnggSRC", parDeptEnggSRC)



        bStatus = dbMain.dbAED("SP_UpdateUser")

        Return bStatus
    End Function
End Class
