Imports System.Data.SqlClient
Imports Telerik.WinControls

Public Class cSapDb


    Public SQLCon As New SqlConnection With {.ConnectionString = GlobalVariables.connString}
    Public SQLCmd As SqlCommand
    Public SQLDA As SqlDataAdapter
    Public SQLDataTable As DataTable

    Dim strInsert, strSelect, strUpdate As String

    Public Function addParameters(ByVal name As String, ByVal value As Object) As Boolean
        Dim newParameter As New SqlParameter(name, value)
        GlobalVariables.myParamSAP.Add(newParameter)

        Return True
    End Function

    Public Function dbSelect(ByVal query As String) As DataTable
        Dim myData As DataTable = Nothing
        Try
            SQLCon.Open()

            SQLCmd = New SqlCommand(query, SQLCon)
            SQLCmd.CommandType = CommandType.Text
            GlobalVariables.myParam.ForEach(Function(p) SQLCmd.Parameters.Add(p))
            myData = New DataTable
            SQLDA = New SqlDataAdapter(SQLCmd)
            SQLDA.Fill(myData)

            SQLCon.Close()

        Catch ex As Exception
            SQLCon.Close()
            GlobalVariables.myParam.Clear()
            If SQLCon.State = ConnectionState.Open Then
                SQLCon.Close()
            End If
            RadMessageBox.Show(ex.Message, "WARNING", MessageBoxButtons.OK, RadMessageIcon.Exclamation)
            Return myData
        End Try

        Return myData

    End Function

End Class
