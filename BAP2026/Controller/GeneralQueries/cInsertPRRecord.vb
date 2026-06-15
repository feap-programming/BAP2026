Imports MySql.Data.MySqlClient

Public Class cInsertPRRecord

    Dim dbMain As New cMainDb

    Public Function InsertPRRecord(pryear As Integer, TC As String, dept As String)

        Dim dt As DataTable

        GlobalVariables.myParam.Clear()

        GlobalVariables.myParam.Add(New MySqlParameter("@pryear", pryear))
        GlobalVariables.myParam.Add(New MySqlParameter("@TC", TC))
        GlobalVariables.myParam.Add(New MySqlParameter("@dept", dept))

        dt = dbMain.dbSelect("PR_Insert")

        Return dt

    End Function
End Class
