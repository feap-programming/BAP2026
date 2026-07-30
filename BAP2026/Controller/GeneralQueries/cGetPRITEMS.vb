Imports MySql.Data.MySqlClient

Public Class cGetPRITEMS

    Dim dbMain As New cMainDb



    Public Function GetPrItems(Transcode As String)

        Dim dt As New DataTable


        GlobalVariables.myParam.Clear()

        GlobalVariables.myParam.Add(New MySqlParameter("p_TransCode", Transcode))

        dt = dbMain.dbSelect("SP_GetPRItems")

        Return dt


    End Function



End Class
