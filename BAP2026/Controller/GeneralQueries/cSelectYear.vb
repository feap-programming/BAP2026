Public Class cSelectYear
    Dim dbMain As New cMainDb

    Public Function SelectOpenYear() As String
        Dim dt As DataTable
        GlobalVariables.myParam.Clear()
        dt = dbMain.dbSelect("SP_SelectOpenYear")

        If dt IsNot Nothing AndAlso dt.Rows.Count > 0 Then
            Return dt.Rows(0)("fldYear").ToString()
        End If

        Return String.Empty
    End Function
End Class