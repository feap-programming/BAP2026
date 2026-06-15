Imports MySql.Data.MySqlClient

Public Class cGenerateSubRefNo


    Dim dbMain As New cMainDb

    Public Function GenerateSubRefNo(p_MajorRefNo As String) As String

        GlobalVariables.myParam.Clear()
        GlobalVariables.myParam.Add(New MySqlParameter("p_MajorRefNo", p_MajorRefNo))
        Dim dt As DataTable = dbMain.dbSelect("SP_GenerateSubRefNo")

        If dt IsNot Nothing AndAlso dt.Rows.Count > 0 Then
            Return dt.Rows(0)("NewSubRefNo").ToString()
        Else
            Return String.Empty
        End If
    End Function
End Class
