Imports MySql.Data.MySqlClient

Public Class cGetUID

    Dim dbMain As New cMainDb

    Public Function GetUID(p_UID As String) As DataTable

        Dim dt As DataTable

        GlobalVariables.myParam.Clear()

        GlobalVariables.myParam.Add(New MySqlParameter("parEmpNo", p_UID))

        dt = dbMain.dbSelect("SP_SelectfldUID")

        Return dt


    End Function


End Class
