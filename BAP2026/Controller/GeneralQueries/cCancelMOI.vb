Imports MySql.Data.MySqlClient

Public Class cCancelMOI


    Dim dbMain As New cMainDb


    Public Function CancelMOI(pmmoid As Integer, pSOUT As Decimal)



        Dim dt As DataTable


        GlobalVariables.myParam.Clear()

        GlobalVariables.myParam.Add(New MySqlParameter("pMOIID", pmmoid))
        GlobalVariables.myParam.Add(New MySqlParameter("pSOUT", pSOUT))

        dt = dbMain.dbSelect("SP_CancelMOI")

        Return dt


    End Function

End Class
