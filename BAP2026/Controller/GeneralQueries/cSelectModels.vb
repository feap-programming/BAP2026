Imports MySql.Data.MySqlClient

Public Class cSelectModels


    Dim dbMain As New cMainDb

    Public Function selectFAC()

        Dim dt As DataTable

        GlobalVariables.myParam.Clear()

        dt = dbMain.dbSelect("SP_SelectAllModel")

        Return dt

    End Function




End Class
