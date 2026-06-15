Imports MySql.Data.MySqlClient
Imports Telerik.WinControls

Public Class cMainDb

    Public MySQLCon As New MySql.Data.MySqlClient.MySqlConnection(GlobalVariables.BAPconnString)
    Public MySQLCmd As MySqlCommand
    Public MySQLDA As MySqlDataAdapter
    Public MySQLDataTable As DataTable
    Public MySQLDataSet As DataSet

    Dim strSelect, strInsert, strUpdate As String

    Public Sub RunQuery(ByVal Query As String)
        Try
            MySQLCon.Open()

            MySQLCmd = New MySqlCommand(Query, MySQLCon)
            MySQLDA = New MySqlDataAdapter(MySQLCmd)
            MySQLDataTable = New DataTable
            MySQLDA.Fill(MySQLDataTable)

            MySQLCon.Close()
        Catch ex As Exception
            If MySQLCon.State = ConnectionState.Open Then
                MySQLCon.Close()
            End If

            MsgBox(ex.Message)
        End Try
    End Sub

    Shared Function isOpenForm(ByVal frm As Form) As Boolean

        If Application.OpenForms.OfType(Of Form).Contains(frm) Then
            Return True
        Else
            Return False
        End If
    End Function

    Shared Function fetchDBTable(ByVal mySQLCommand As String) As DataTable
        Dim myCmd As New MySqlCommand
        Dim myData As New DataTable
        Dim myAdapter As New MySql.Data.MySqlClient.MySqlDataAdapter

        Dim conn As New MySql.Data.MySqlClient.MySqlConnection(GlobalVariables.BAPconnString)

        Try
            conn.Open()
            myCmd.CommandText = mySQLCommand
            myCmd.Connection = conn
            myCmd.CommandTimeout = 500
            myAdapter.SelectCommand = myCmd
            myAdapter.Fill(myData)

            conn.Close()
        Catch ex As SqlClient.SqlException
            conn.Close()
            RadMessageBox.Show(ex.Message)
        End Try

        conn = Nothing

        Return myData
    End Function

    Shared Function fetchMySqlRow(ByVal SQLcommand As String) As DataRow
        Dim myCmd As New MySqlCommand
        Dim myData As New DataTable
        Dim myAdapter As New MySql.Data.MySqlClient.MySqlDataAdapter

        Dim conn As New MySql.Data.MySqlClient.MySqlConnection(GlobalVariables.BAPconnString)

        conn.Open()
        myCmd.CommandText = SQLcommand
        myCmd.Connection = conn

        myAdapter.SelectCommand = myCmd
        myAdapter.Fill(myData)

        If myData.Rows.Count > 0 Then
            fetchMySqlRow = myData.Rows(0)
        Else
            fetchMySqlRow = Nothing
        End If

        conn.Close()
        conn = Nothing

    End Function

    Shared Function checkIfRecordExist(ByVal SQLcommand As String) As Boolean
        Dim myCmd As New MySqlCommand
        Dim myData As New DataTable
        Dim myAdapter As New MySql.Data.MySqlClient.MySqlDataAdapter

        Dim conn As New MySql.Data.MySqlClient.MySqlConnection(GlobalVariables.BAPconnString)

        conn.Open()
        myCmd.CommandText = SQLcommand
        myCmd.Connection = conn

        myAdapter.SelectCommand = myCmd
        myAdapter.Fill(myData)

        If myData.Rows.Count > 0 Then
            checkIfRecordExist = True
        Else
            checkIfRecordExist = False
        End If

        conn.Close()
        conn = Nothing

        Return checkIfRecordExist

    End Function

    Public Function addParameters(ByVal name As String, ByVal value As Object) As Boolean
        Dim newParameter As New MySqlParameter(name, value)
        GlobalVariables.myParam.Add(newParameter)

        Return True
    End Function

    Public Function dbSelect(ByVal query As String) As DataTable
        Dim myData As DataTable = Nothing

        Try
            MySQLCon.Open()

            MySQLCmd = New MySqlCommand(query, MySQLCon)
            MySQLCmd.CommandType = CommandType.StoredProcedure
            GlobalVariables.myParam.ForEach(Function(p) MySQLCmd.Parameters.Add(p))

            myData = New DataTable
            MySQLDA = New MySqlDataAdapter(MySQLCmd)
            MySQLDA.Fill(myData)

            MySQLCon.Close()

        Catch ex As Exception
            MySQLCon.Close()
            GlobalVariables.myParam.Clear()
            If MySQLCon.State = ConnectionState.Open Then
                MySQLCon.Close()
            End If
            RadMessageBox.Show(ex.Message, "WARNING", MessageBoxButtons.OK, RadMessageIcon.Exclamation)
            Return myData
        End Try

        Return myData

    End Function

    Public Function dbAED(ByVal query As String) As Boolean
        Try
            MySQLCon.Open()

            MySQLCmd = New MySqlCommand(query, MySQLCon)
            MySQLCmd.CommandType = CommandType.StoredProcedure
            GlobalVariables.myParam.ForEach(Function(p) MySQLCmd.Parameters.Add(p))

            MySQLCmd.ExecuteNonQuery()
            GlobalVariables.myParam.Clear()

            MySQLCon.Close()

        Catch ex As Exception
            MySQLCon.Close()
            GlobalVariables.myParam.Clear()
            If MySQLCon.State = ConnectionState.Open Then
                MySQLCon.Close()
            End If
            RadMessageBox.Show(ex.Message, "WARNING", MessageBoxButtons.OK, RadMessageIcon.Exclamation)
            Return False
        End Try

        Return True
    End Function




End Class
