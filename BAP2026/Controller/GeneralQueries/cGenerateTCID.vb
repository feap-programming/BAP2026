Imports MySql.Data.MySqlClient

Public Class cGenerateTCID

    Dim dbMain As New cMainDb


    Public Function GenerateTCID()

        Dim dt As DataTable
        GlobalVariables.myParam.Clear()


        dt = dbMain.dbSelect("SP_SelectTCID")

        Return dt


    End Function


End Class
