Imports System.Windows.Controls

Public Class FrmHome

    Dim dbHrms As New cHrmsDb
    Dim dbMain As New cMainDb
    Dim cUsers As New cselectUsers



    Dim frmaddrec As New FrmAddMajorRec

    Dim frmpurchaserec As New FrmAddPurchaseReq


    Public ReadOnly Property SelectedDept As String

        Get
            Return RadDropDownList1.Text
            'cbDept.Text

        End Get
    End Property



    Private Sub FrmHome_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If RadDropDownList1.Text <> "" Then


            GlobalVariables.SelectedDept = RadDropDownList1.Text


        End If


        txtdate.Text = Date.Now.ToString("MMMM dd, yyyy")

        'Call fullname from Global variables'

        txtSection.Text = GlobalVariables.empSection
        txtName.Text = GlobalVariables.empFirstName & " " & GlobalVariables.empMiddleName & " " & GlobalVariables.empLastName
        txtempNo.Text = GlobalVariables.empNo
        txtDept.Text = GlobalVariables.empDept
        txtgroup.Text = GlobalVariables.empUserType


        'LoadDepartment()

        frmaddrec.SelectedDept = RadDropDownList1.Text
        frmpurchaserec.SelectedDept = RadDropDownList1.Text


        Dim frm1 As New FrmAddMajorRef()
        frm1.SelectedDept = RadDropDownList1.Text

        Dim frm2 As New FrmAddPurchaseReq()
        frm2.SelectedDept = RadDropDownList1.Text




        'Dim frm3 As New frmCreateBudget()
        'frm2.SelectedDept = RadMultiColumnComboBox1.Text


        'cbDept.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList


        loadDept()
        clearfield()

    End Sub


    Private Sub clearfield()


        RadDropDownList1.SelectedIndex = -1
        RadDropDownList1.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList


    End Sub


    'Private Sub LoadDepartment()
    '    Dim dtemp As DataTable
    '    dtemp = cUsers.SelectedDepartmentByUser(GlobalVariables.empNo)




    '    If dtemp IsNot Nothing AndAlso dtemp.Rows.Count > 0 Then
    '        With cbDept
    '            .DataSource = Nothing
    '            .DataSource = dtemp
    '            .DisplayMember = "DeptCode"  ' alias in the SQL
    '            .ValueMember = "DeptCode"
    '        End With
    '    Else
    '        MessageBox.Show("No departments found for user: " & GlobalVariables.empNo)
    '    End If
    'End Sub



    Private Sub loadDept()

        Dim dtemp As DataTable
        dtemp = cUsers.SelectedDepartmentByUser(GlobalVariables.empNo)


        RadDropDownList1.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList


        If dtemp IsNot Nothing AndAlso dtemp.Rows.Count > 0 Then

            With RadDropDownList1

                .DataSource = Nothing
                .DataSource = dtemp
                .DisplayMember = "DeptCode"
                .ValueMember = "DeptCode"


            End With

            'Else

            '    MessageBox.Show("No departmen found")


        End If


    End Sub



    Private Sub RadDropDownList1_SelectedIndexChanged(sender As Object, e As Telerik.WinControls.UI.Data.PositionChangedEventArgs) Handles RadDropDownList1.SelectedIndexChanged

        GlobalVariables.SelectedDept = RadDropDownList1.Text
    End Sub
End Class
