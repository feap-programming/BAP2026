Imports MySql.Data.MySqlClient
Imports Org.BouncyCastle.Asn1


Public Class cSelectFAC


    Dim dbMain As New cMainDb

    Public Function selectFAC()

        Dim dt As DataTable

        GlobalVariables.myParam.Clear()

        dt = dbMain.dbSelect("SP_SelectControlNoSetting")

        Return dt

    End Function

    Public Function selectFACByFAC(FAC As String)

        Dim dt As DataTable

        GlobalVariables.myParam.Clear()

        GlobalVariables.myParam.Add(
                 New MySqlParameter("@parCategory", FAC & "%"))


        dt = dbMain.dbSelect("SP_SelectControlNoLogs")

        Return dt


    End Function




End Class

