Public Class cSelectRFQ

    Dim dbMain As New cMainDb

    Public Function selectTypeOfExpense()

        Dim dt As DataTable

        GlobalVariables.myParam.Clear()

        dt = dbMain.dbSelect("SP_SelectAllTypeOfExpense")

        Return dt

    End Function

    Public Function selectLastCreatedRFQByDept(ByVal parDept As String, ByVal parSection As String)

        Dim dt As DataTable

        GlobalVariables.myParam.Clear()


        dbMain.addParameters("parDept", parDept)
        dbMain.addParameters("parSection", parSection)
        dt = dbMain.dbSelect("SP_SelectLastCreatedRFQbyDept")

        Return dt

    End Function

    Public Function selectRFQBySelectedDept(ByVal parSelectedDept As String)

        Dim dt As DataTable

        GlobalVariables.myParam.Clear()

        dbMain.addParameters("parSelectedDept", parSelectedDept)
        dt = dbMain.dbSelect("SP_SelectRFQBySelectedDept")

        Return dt

    End Function

End Class
