Public Class FrmViewPO


    Dim cusers As New cselectUsers

    Dim cGetPOBYDATE As New cGetPoByDate

    Dim dtPOBYDATE As New DataTable

    Dim cVPOUI As New cVPOUI

    Dim cVPOIUI As New cVPOUI

    Private _selectedDept As String
    Public Property SelectedDept As String
        Get
            Return _selectedDept
        End Get
        Set(value As String)
            _selectedDept = value
        End Set
    End Property

    Private Sub FrmViewPO_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        LoadFields()

    End Sub


    Public Sub LoadFields()

        For i As Integer = 1 To 12
            ddMonth.Items.Add(i)
        Next

        For year As Integer = 2015 To Today.Year
            ddYear.Items.Add(year)
        Next


        ddMonth.SelectedIndex = Today.Month - 1
        ddYear.Text = Today.Year.ToString()

        dtMO.Value = Today
        dtDD.Value = Today

        LoadDept()

        cVPOUI.rgvPOLIST(gvPOLIST)
        cVPOIUI.POIGRID(gvPOILIST)


    End Sub

    Public Sub LoadDept()

        Dim dt As DataTable

        dt = cusers.SelectedDepartmentByUser(GlobalVariables.empNo)

        If dt IsNot Nothing AndAlso dt.Rows.Count > 0 Then

            With ddlDept
                .DataSource = dt
                .DisplayMember = "DeptCode"
                .ValueMember = "DeptCode"
            End With

        Else
            MessageBox.Show("No Departments found for user:" & GlobalVariables.empNo)

        End If

    End Sub

    Public Sub GetPOByDate(FMONTH As Decimal, FYEAR As Decimal, DEPT As String)

        Dim dt As DataTable = cGetPOBYDATE.getPObyDate(FMONTH:=ddMonth.Text, FYEAR:=ddYear.Text, DEPT:=ddlDept.Text)

        If dt IsNot Nothing AndAlso dt.Rows.Count > 0 Then

            With gvPOLIST

                .DataSource = dt

            End With

        End If


    End Sub

    Private Sub RadButton1_Click(sender As Object, e As EventArgs) Handles RadButton1.Click


        GetPOByDate(FMONTH:=ddMonth.Text, FYEAR:=ddYear.Text, DEPT:=ddlDept.Text)


    End Sub
End Class
