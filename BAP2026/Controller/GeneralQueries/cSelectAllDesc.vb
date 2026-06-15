Imports MySql.Data.MySqlClient

Public Class cSelectAllDesc

    Dim dbMain As New cMainDb

    Public Function SelectAllDesc() As DataTable
        Dim dt As DataTable
        GlobalVariables.myParam.Clear()
        dt = dbMain.dbSelect("SP_SelectMajorDescription")
        Return dt
    End Function

    Public Function cSelectMajorPR() As DataTable

        Dim dt As DataTable
        GlobalVariables.myParam.Clear()
        dt = dbMain.dbSelect("SP_SelectMajorDescription")
        Return dt


    End Function

    Public Function SelectAllClassDesc() As DataTable

        Dim dt As DataTable
        GlobalVariables.myParam.Clear()
        dt = dbMain.dbSelect("SP_SelectAllClass")

        Return dt

    End Function

    Public Function SelectMajorByDept(dept As String) As DataTable

        Dim dt As DataTable
        GlobalVariables.myParam.Clear()
        GlobalVariables.myParam.Add(New MySqlParameter("p_Dept", dept))
        dt = dbMain.dbSelect("SP_SelectMajorbyDeptPR")

        Return dt

    End Function


    Public Function SelectSubMajorByDeptnRef(dept As String, subrefno As String) As DataTable

        Dim dt As DataTable
        GlobalVariables.myParam.Clear()
        GlobalVariables.myParam.Add(New MySqlParameter("p_Dept", dept))
        GlobalVariables.myParam.Add(New MySqlParameter("p_MajorRefNo", subrefno))
        dt = dbMain.dbSelect("SP_SelectSubMajorbyDeptPR")
        Return dt


    End Function


End Class
