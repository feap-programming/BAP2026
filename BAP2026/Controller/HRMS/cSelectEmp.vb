Imports MySql.Data.MySqlClient
Public Class cSelectEmp

    Dim dbHRMS As New cHrmsDb

    Public Function SelectRFQUsers() As DataTable
        Dim dt As DataTable
        GlobalVariables.myParam.Clear()
        dt = dbHRMS.dbSelect("SP_BAP_GetAllEmployee")
        Return dt
    End Function

End Class
