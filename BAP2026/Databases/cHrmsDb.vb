Imports MySql.Data.MySqlClient
Imports Telerik.WinControls

Public Class cHrmsDb

    Public MySQLCon As New MySqlConnection With {.ConnectionString = GlobalVariables.HRMSconnString}
    Public MySQLCmd As MySqlCommand
    Public MySQLDA As MySqlDataAdapter
    Public MySQLDataTable As DataTable

    Dim strInsert, strSelect, strUpdate As String

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

    Public Sub SelectEmployeeByID(ByVal ID As String)
        Try
            MySQLCon.Open()

            strSelect = "CALL SP_GetEmpByID('" & ID & "')"

            MySQLCmd = New MySqlCommand(strSelect, MySQLCon)
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

    Public Sub SelectAllEmployee()
        Try
            MySQLCon.Open()

            strSelect = "CALL SP_GetAllEmployee"

            MySQLCmd = New MySqlCommand(strSelect, MySQLCon)
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

    Public Sub Login(ByVal empNo As String, ByVal empPin As String)

        Try
            MySQLCon.Open()

            strSelect = "CALL SP_Login('" & empNo & "','" & empPin & "')"

            MySQLCmd = New MySqlCommand(strSelect, MySQLCon)
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

    Public Sub SelectEmpEmailByID(ByVal ID As String)
        Try
            MySQLCon.Open()

            strSelect = "SELECT fldEmpCompanyEmail FROM dbHRMSlive.tblEmployee where fldEmpNo = " & ID & ";"

            MySQLCmd = New MySqlCommand(strSelect, MySQLCon)
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



End Class
