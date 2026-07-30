Imports System.Security.Cryptography.X509Certificates
Imports MySql.Data.MySqlClient

Public Class cSelectPRSEARCH

    Dim dbMain As New cMainDb


    Public Function getPRSirts(prno As String)

        Dim dt As DataTable


        GlobalVariables.myParam.Clear()
        GlobalVariables.myParam.Add(New MySqlParameter("pPRNo", prno))

        dt = dbMain.dbSelect("SP_SelectPRNoForViewPR")

        Return dt

    End Function

End Class
