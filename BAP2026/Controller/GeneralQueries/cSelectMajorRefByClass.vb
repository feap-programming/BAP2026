Imports MySql.Data.MySqlClient

Public Class cSelectMajorRefByClass


    Dim dbMain As New cMainDb

    Public Function cSelectMajorRef(p_ClassCode As String, p_Dept As String) As DataTable

        Dim dt As DataTable
        GlobalVariables.myParam.Clear()
        GlobalVariables.myParam.Add(New MySqlParameter("p_ClassCode", p_ClassCode))
        GlobalVariables.myParam.Add(New MySqlParameter("p_Dept", p_Dept))
        dt = dbMain.dbSelect("SP_SelectMajorRefByClass")
        Return dt

    End Function


End Class
