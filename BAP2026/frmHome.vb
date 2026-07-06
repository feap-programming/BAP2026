Imports System.Windows.Controls

Public Class FrmHome

    Dim dbHrms As New cHrmsDb
    Dim dbMain As New cMainDb
    Dim cUsers As New cselectUsers
    Dim cUpdate As New cUpdateUser



    Dim frmaddrec As New FrmAddMajorRec

    Dim frmpurchaserec As New FrmAddPurchaseReq


    Public ReadOnly Property SelectedDept As String

        Get
            Return RadDropDownList1.Text
            'cbDept.Text

        End Get
    End Property

    Private Sub loadDefaultDept()
        Dim dt As DataTable
        dt = cUsers.SelectDefaultDeptByEmpNo(GlobalVariables.empNo)

        If dt.Rows.Count > 0 Then
            If dt.Rows(0).Item("fldDefaultDept").ToString <> String.Empty Then
                listDept.SelectedValue = dt.Rows(0)("fldDefaultDept").ToString()
                lblDefaultDept.Text = dt.Rows(0).Item("fldDefaultDept").ToString
            Else
                lblDefaultDept.Text = "N/A"
            End If
        Else
            lblDefaultDept.Text = "N/A"
        End If
    End Sub

    Private Sub FrmHome_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'If RadDropDownList1.Text <> "" Then


        '    GlobalVariables.SelectedDept = RadDropDownList1.Text


        'End If
        loadDept()
        loadDefaultDept()

        If listDept.SelectedValue IsNot Nothing Then
            GlobalVariables.SelectedDept = listDept.SelectedValue.ToString()
        End If

        RemoveHandler listDept.SelectedIndexChanged, AddressOf listDept_SelectedIndexChanged


        txtdate.Text = Date.Now.ToString("MMMM dd, yyyy")

        'Call fullname from Global variables'

        txtSection.Text = GlobalVariables.empSection
        txtName.Text = GlobalVariables.empFirstName & " " & GlobalVariables.empMiddleName & " " & GlobalVariables.empLastName
        txtempNo.Text = GlobalVariables.empNo
        txtDept.Text = GlobalVariables.empDept
        txtgroup.Text = GlobalVariables.empUserType


        'LoadDepartment()

        frmaddrec.SelectedDept = listDept.SelectedValue.ToString
        frmpurchaserec.SelectedDept = listDept.SelectedValue.ToString


        Dim frm1 As New FrmAddMajorRef()
        frm1.SelectedDept = listDept.SelectedValue.ToString

        Dim frm2 As New FrmAddPurchaseReq()
        frm2.SelectedDept = listDept.SelectedValue.ToString


        'Dim frm3 As New frmCreateBudget()
        'frm2.SelectedDept = RadMultiColumnComboBox1.Text


        'cbDept.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList

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

            With listDept

                .DataSource = Nothing
                .DisplayMember = "DeptCode"
                .ValueMember = "DeptCode"
                .DataSource = dtemp


            End With

        End If


    End Sub



    Private Sub RadDropDownList1_SelectedIndexChanged(sender As Object, e As Telerik.WinControls.UI.Data.PositionChangedEventArgs) Handles RadDropDownList1.SelectedIndexChanged

        'GlobalVariables.SelectedDept = RadDropDownList1.Text
    End Sub

    Private Sub listDept_SelectedIndexChanged(sender As Object, e As Telerik.WinControls.UI.Data.PositionChangedEventArgs) Handles listDept.SelectedIndexChanged
        GlobalVariables.SelectedDept = listDept.SelectedItem.Text
        lblDeptSelected.Text = listDept.SelectedItem.Text
    End Sub

    Private Sub btnDefault_Click(sender As Object, e As EventArgs) Handles btnDefault.Click
        Dim bUpdate As Boolean
        If listDept.SelectedIndex <> -1 Then
            bUpdate = cUpdate.UpdateDefaultDept(txtempNo.Text, listDept.SelectedValue.ToString)
            loadDefaultDept()
        End If
    End Sub

    Private Sub FrmHome_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        AddHandler listDept.SelectedIndexChanged, AddressOf listDept_SelectedIndexChanged
    End Sub
End Class
