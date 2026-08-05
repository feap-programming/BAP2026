Imports MySql.Data.MySqlClient

Public Class cselectUsers

    Dim dbMain As New cMainDb

    Public Function SelectAllUsers() As DataTable
        Dim dt As DataTable
        GlobalVariables.myParam.Clear()
        dt = dbMain.dbSelect("SP_SelectAllUsers")
        Return dt
    End Function

    Public Function SelectUserByEmpNo(ByVal EmpNo As String) As DataTable
        Dim dt As DataTable
        GlobalVariables.myParam.Clear()
        dbMain.addParameters("EmpNo", EmpNo)
        dt = dbMain.dbSelect("SP_SelectUserByEmpNo")
        Return dt
    End Function

    Public Function SelectedDepartmentByUser(ByVal empNo As String) As DataTable
        Dim dt As DataTable
        GlobalVariables.myParam.Clear()
        dbMain.addParameters("parEmpNo", empNo)
        dt = dbMain.dbSelect("SP_SelectDeptByUser")
        Return dt
    End Function

    Public Function SelectDefaultDeptByEmpNo(ByVal empNo As String) As DataTable
        Dim dt As DataTable
        GlobalVariables.myParam.Clear()
        dbMain.addParameters("parEmpNo", empNo)
        dt = dbMain.dbSelect("SP_SelectDefaultDeptByEmpNo")
        Return dt
    End Function

    Public Function GetClassDesc() As DataTable
        Dim dt As New DataTable


        Using cmd As New MySqlCommand("SP_SelectAllClassDesc")
            cmd.CommandType = CommandType.StoredProcedure

            Dim da As New MySqlDataAdapter(cmd)
            da.Fill(dt)
        End Using


        Return dt
    End Function

    Public Function SelectRFQUsers() As DataTable
        Dim dt As DataTable
        GlobalVariables.myParam.Clear()
        dt = dbMain.dbSelect("SP_BAP_GetAllEmployee")
        Return dt
    End Function



End Class