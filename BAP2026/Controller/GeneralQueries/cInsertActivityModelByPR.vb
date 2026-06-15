Imports MySql.Data.MySqlClient



Public Class CInsertActivityModelByPR

    Dim dbMain As New cMainDb


    Public Function InsertAMPR(Activity As String, Model As String, TransCode As String)

        Dim dt As DataTable


        GlobalVariables.myParam.Clear()

        GlobalVariables.myParam.Add(New MySqlParameter("@Activity", Activity))
        GlobalVariables.myParam.Add(New MySqlParameter("@Model", Model))
        GlobalVariables.myParam.Add(New MySqlParameter("@TransCode", TransCode))

        dt = dbMain.dbSelect("SP_InsertActivityModelbyPR")

        Return dt

    End Function

End Class
