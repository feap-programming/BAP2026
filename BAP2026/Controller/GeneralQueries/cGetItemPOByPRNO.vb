Imports MySql.Data.MySqlClient

Public Class cGetItemPOByPRNO

    Dim dbMain As New cMainDb

    Public Function getItemPObyPRNO(PRNo As String) As DataTable

        Dim dt As DataTable

        GlobalVariables.myParam.Clear()

        GlobalVariables.myParam.Add(New MySqlParameter("PRNo", PRNo))


        dt = dbMain.dbSelect("SP_CPO_GetItemToPOByPRNo")

        Return dt

    End Function

End Class
