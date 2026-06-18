Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient


Module GlobalVariables

    Dim objUID As New cGetUID()
    Dim dt As DataTable


    Public BAPconnString As String = "server=" + My.Settings.setServerAddress + ";" + "uid=" + My.Settings.setUsername + ";" + "pwd=" + My.Settings.setPassword + ";" + "Convert Zero Datetime=True;database=" + My.Settings.setServerDBName

    Public ReportconnString As String = "server=" + My.Settings.setReportAddress + ";" + "uid=" + My.Settings.setReportUser + ";" + "pwd=" + My.Settings.setReportPassword + ";" + "Convert Zero Datetime=True;database=" + My.Settings.setReportDBName

    Public HRMSconnString As String = "server=" + My.Settings.setHRMSServerAddress + ";" + "uid=" + My.Settings.setHRMSUsername + ";" + "pwd=" + My.Settings.setHRMSPassword + ";" + "Convert Zero Datetime=True;database=" + My.Settings.setHRMSDBName

    Public myParam As New List(Of MySqlParameter)

    Public dtEmployees As DataTable

    Public empID, empNo, empName, empShortName, empFirstName, empMiddleName, empLastName, empDept, empSection, empUserType, empGender, empTheme As String

    Public UIDemp As String = ""

    Public groupsView As String

    Public ModelSearchValue As String

    Public currentForm As String

    Public rptGroupId As Integer

    Public rptName, rptGroupName, rptStatus As String

    Public rptDateFrom, rptDateTo As DateTime

    Public SelectedDept As String = ""

    Public connString As String = "Data Source=" & My.Settings.setSAPServerAddress & ";Initial Catalog=" & My.Settings.setSAPServerName & ";User ID=" & My.Settings.setSAPUsername & ";Password=" & My.Settings.setSAPPassword & "; Connection Timeout=500;"

    Public myParamSAP As New List(Of SqlParameter)

End Module
