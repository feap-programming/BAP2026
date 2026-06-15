Imports MySql.Data

Public Class cSelectAllMajorBudget

    Dim dbMain As New cMainDb


    Public Function cSelectAllMajorBudget(dept As String) As DataTable

        Dim dt As DataTable

        GlobalVariables.myParam.Clear()

        GlobalVariables.myParam.Add(New MySqlClient.MySqlParameter("p_Dept", dept))
        dt = dbMain.dbSelect("SP_SelectAllMajorByDept")

        Return dt


    End Function


End Class
