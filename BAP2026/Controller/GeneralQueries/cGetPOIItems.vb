Imports MySql.Data.MySqlClient

Public Class cGetPOIItems

    Dim dbMain As New cMainDb

    Public Function getPOITEMS(OBLINE As String)

        Dim dt As DataTable

        GlobalVariables.myParam.Clear()
        GlobalVariables.myParam.Add(New MySqlParameter("OB_Line", OBLINE))

        dt = dbMain.dbSelect("PO_GetPOItemsv2")
        Return dt


    End Function

End Class
