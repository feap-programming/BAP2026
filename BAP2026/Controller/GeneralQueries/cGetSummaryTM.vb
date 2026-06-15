Imports MySql.Data.MySqlClient

Public Class cGetSummaryTM

    Dim dbMain As New cMainDb

    Public Function GetSummaryTotalMajor(fldMajorRefNo As String)

        Dim dt As DataTable
        GlobalVariables.myParam.Clear()
        GlobalVariables.myParam.Add(New MySqlParameter("MajorRefNum", fldMajorRefNo))
        dt = dbMain.dbSelect("SP_GetSummaryTotalbyMajor")

        Return dt

    End Function

End Class

