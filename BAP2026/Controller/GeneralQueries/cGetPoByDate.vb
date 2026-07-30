Imports MySql.Data.MySqlClient

Public Class cGetPoByDate

    Dim dbMain As New cMainDb

    Public Function getPObyDate(FMONTH As Decimal, FYEAR As Integer, DEPT As String) As DataTable

        Dim dt As DataTable


        GlobalVariables.myParam.Clear()
        GlobalVariables.myParam.Add(New MySqlParameter("FMONTH", FMONTH))
        GlobalVariables.myParam.Add(New MySqlParameter("FYEAR", FYEAR))
        GlobalVariables.myParam.Add(New MySqlParameter("DEPT", DEPT))

        dt = dbMain.dbSelect("SP_GetPOByDeptDate")
        Return dt


    End Function


End Class
