Imports System.Threading.Tasks
Imports Telerik.WinControls
Imports Telerik.WinControls.UI

Public Class FrmRegister

    Dim selectGen As New cSelect
    Dim iUser As New cInsertUsers

    Dim rGvEmployee As New cGvAllEmployees

    Dim dbHrms As New cHrmsDb
    Dim selectUsers As New cselectUsers
    Dim dtuser As DataTable

    Dim dUser As New cDeleteUser

    Dim uUser As New cUpdateUser

    Public Event DataLoaded()

    Private _dtEmployees As DataTable
    Private _dtUsers As DataTable


    Dim UID As Integer
    Dim status As String = "INSERT"

    Private Sub selectDepartments()

        dtuser = selectGen.SelectAllDepartments()

    End Sub


    Private Sub selectAllUsers()
        dtuser = selectUsers.SelectAllUsers
        If dtuser.Rows.Count > 0 Then
            gvUsers.DataSource = dtuser
        Else
            gvUsers.DataSource = Nothing
        End If
    End Sub

    Private Sub clearFields()
        txtEmpNo.Text = ""
        txtFirstname.Text = ""
        txtLastname.Text = ""
        txtMiddlename.Text = ""
        txtSection.Text = ""
        txtDept.Text = ""
        tsAll.Value = False
        tsHRGA.Value = False
        tsPresident.Value = False
        tsACCTG.Value = False
        tsPC.Value = False
        tsQA.Value = False
        tsWH.Value = False
        tsLOG.Value = False
        tsFAB.Value = False
        tsFACILITY.Value = False
        tsFFC.Value = False
        tsENGG.Value = False
        tsPROJECT.Value = False
        tsCommon.Value = False
        tsMIS.Value = False
        tsBSS.Value = False
        tsQC.Value = False
        tsIVG.Value = False
        tsFGM.Value = False
        tsKAIZEN.Value = False
        tsTRAINING.Value = False
        tsINJ.Value = False
        tsPROD.Value = False
        tsSAFETY.Value = False
        tsSRC.Value = False
        tsEVAL.Value = False
    End Sub


    Public Sub PreloadData()

        ' Run both DB calls at the same time instead of sequentially
        Dim t1 = Task.Run(Sub()
                              _dtEmployees = dbHrms.dbSelect("SP_TaskOrganizer_GetAllEmployee")
                          End Sub)

        Dim t2 = Task.Run(Sub()
                              _dtUsers = selectUsers.SelectAllUsers
                          End Sub)

        ' Wait for both to finish before continuing
        Task.WaitAll(t1, t2)

    End Sub
    Private Sub FrmRegister_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        rGvEmployee.readyMcbEmployee(txtsearch)
        rGvEmployee.readyGvAllUsers(gvUsers)

        RemoveHandler txtsearch.SelectedIndexChanged, AddressOf txtsearch_SelectedIndexChanged
    End Sub

    Private Sub RadButton1_Click(sender As Object, e As EventArgs) Handles btnSave.Click




        Dim deptAll As String
        Dim deptPresident As String
        Dim deptWH As String
        Dim deptFFC As String
        Dim deptproject As String
        Dim deptBSS As String
        Dim deptqc As String
        Dim deptkaizen As String
        Dim depttraining As String
        Dim deptinj As String
        Dim deptprod As String
        Dim depthrga As String
        Dim deptacctg As String
        Dim deptlog As String
        Dim depttqa As String
        Dim deptfacility As String
        Dim deptmis As String
        Dim deptivg As String
        Dim deptfgm As String
        Dim depteval As String
        Dim deptsafety As String
        Dim deptsrc As String
        Dim deptengg As String
        Dim deptpc As String
        Dim deptqa As String
        Dim deptfab As String
        Dim deptcommon As String


        Dim user As Boolean
        Dim dtUsers As DataTable


        deptAll = If(tsAll.Value = True, 1, 0)
        deptPresident = If(tsPresident.Value = True, 1, 0)
        deptWH = If(tsWH.Value = True, 1, 0)
        deptFFC = If(tsFFC.Value = True, 1, 0)
        deptproject = If(tsPROJECT.Value = True, 1, 0)
        deptBSS = If(tsBSS.Value = True, 1, 0)
        deptqc = If(tsQC.Value = True, 1, 0)
        deptkaizen = If(tsKAIZEN.Value = True, 1, 0)
        depttraining = If(tsTRAINING.Value = True, 1, 0)
        deptinj = If(tsINJ.Value = True, 1, 0)
        deptprod = If(tsPROD.Value = True, 1, 0)
        depthrga = If(tsHRGA.Value = True, 1, 0)
        deptacctg = If(tsACCTG.Value = True, 1, 0)
        deptlog = If(tsLOG.Value = True, 1, 0)
        depttqa = If(tsQA.Value = True, 1, 0)
        depteval = If(tsEVAL.Value = True, 1, 0)
        deptfacility = If(tsFACILITY.Value = True, 1, 0)
        deptmis = If(tsMIS.Value = True, 1, 0)
        deptivg = If(tsIVG.Value = True, 1, 0)
        deptfgm = If(tsFGM.Value = True, 1, 0)
        deptsafety = If(tsSAFETY.Value = True, 1, 0)
        deptsrc = If(tsSRC.Value = True, 1, 0)
        deptengg = If(tsSRC.Value = True, 1, 0)
        deptpc = If(tsPC.Value = True, 1, 0)
        deptqa = If(tsQA.Value = True, 1, 0)
        deptfab = If(tsFAB.Value = True, 1, 0)
        deptcommon = If(tsCommon.Value = True, 1, 0)



        If status = "INSERT" Or status = "UPDATE" Then

            If String.IsNullOrWhiteSpace(txtEmpNo.Text) Then
                RadMessageBox.SetThemeName("VisualStudio2022Light")
                RadMessageBox.Show("Select Emp No.", " Error")
                Exit Sub
            End If

            If String.IsNullOrWhiteSpace(txtFirstname.Text) Then
                RadMessageBox.SetThemeName("VisualStudio2022Light")
                RadMessageBox.Show("Input First Name")
                Exit Sub
            End If

            'If String.IsNullOrWhiteSpace(txtMiddlename.Text) Then
            '    RadMessageBox.SetThemeName("VisualStudio2022Light")
            '    RadMessageBox.Show("Input Middlename")
            '    Exit Sub

            'End If

            If String.IsNullOrWhiteSpace(txtLastname.Text) Then
                RadMessageBox.SetThemeName("VisualStudio2022Light")
                RadMessageBox.Show("Input Lastname")
                Exit Sub
            End If

            If ddUserLevel.SelectedItem Is Nothing Then
                RadMessageBox.SetThemeName("VisualStudio2022Light")
                RadMessageBox.Show("Select User Level")
                Exit Sub
            End If


            'If String.IsNullOrWhiteSpace(txtSection.Text) Then
            'RadMessageBox.SetThemeName("VisualStudio2022Light")
            'RadMessageBox.Show("")


            ' End If
        End If

        If status = "INSERT" Then



                user = iUser.InsertUser(
                txtEmpNo.Text,
                txtFirstname.Text,
                txtLastname.Text,
                txtMiddlename.Text,
                txtDept.Text,
                txtSection.Text,
                ddUserLevel.Text,
                deptAll,
                deptPresident,
                depthrga,
                deptacctg,
                deptlog,
                depteval,
                deptfacility,
                deptengg,
                deptprod,
                deptpc,
                deptqa,
                deptWH,
                deptfab,
                deptFFC,
                deptproject,
                deptcommon,
                deptmis,
                deptBSS,
                deptqc,
                deptivg,
                deptkaizen,
                deptfgm,
                depttraining,
                deptsafety,
                deptinj,
                deptsrc
            )

                If user Then
                    RadMessageBox.SetThemeName("VisualStudio2022LightTheme")
                    RadMessageBox.Show("User successfully added!", "SUCCESS", MessageBoxButtons.OK, RadMessageIcon.Info)
                End If

            ElseIf status = "UPDATE" Then

                UID = gvUsers.CurrentRow.Cells("fldUID").Value()
            user = uUser.UpdateUser(UID,
                                    txtEmpNo.Text,
                                    txtFirstname.Text,
                                    txtLastname.Text,
                                    txtMiddlename.Text,
                                    txtDept.Text,
                                    txtSection.Text,
                                    ddUserLevel.Text,
                                    deptAll,
                                    deptPresident,
                                    depthrga,
                                    deptacctg,
                                    deptlog,
                                    depteval,
                                    deptfacility,
                                    deptengg,
                                    deptprod,
                                    deptpc,
                                    deptqa,
                                    deptWH,
                                    deptfab,
                                    deptFFC,
                                    deptproject,
                                    deptcommon,
                                    deptmis,
                                    deptBSS,
                                    deptqc,
                                    deptivg,
                                    deptkaizen,
                                    deptfgm,
                                    depttraining,
                                    deptsafety,
                                    deptinj,
                                    deptsrc
                                    )

            If user Then
                RadMessageBox.SetThemeName("VisualStudio2022Light")
                RadMessageBox.Show("User successfully updated!", "SUCCESS", MessageBoxButtons.OK, RadMessageIcon.Info)
            End If


        End If

        selectAllUsers()
        clearFields()

    End Sub

    Private Sub txtsearch_SelectedIndexChanged(sender As Object, e As EventArgs) Handles txtsearch.SelectedIndexChanged


        Dim selectedRow As GridViewDataRowInfo = CType(txtsearch.SelectedItem, GridViewDataRowInfo)

        txtEmpNo.Text = selectedRow.Cells("fldEmpNo").Value.ToString()

        txtFirstname.Text = selectedRow.Cells("fldEmpFirstName").Value.ToString()

        txtLastname.Text = selectedRow.Cells("fldEmpLastName").Value.ToString()

        txtMiddlename.Text = selectedRow.Cells("fldEmpMiddleName").Value.ToString()

        txtSection.Text = selectedRow.Cells("fldEmpSection").Value.ToString()

        txtDept.Text = selectedRow.Cells("fldEmpDepartment").Value.ToString()

    End Sub

    Private Sub FrmRegister_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        Task.Run(Sub()
                     PreloadData()

                     Me.Invoke(Sub()
                                   txtsearch.DataSource = _dtEmployees

                                   If _dtUsers IsNot Nothing AndAlso _dtUsers.Rows.Count > 0 Then
                                       gvUsers.DataSource = _dtUsers
                                   Else
                                       gvUsers.DataSource = Nothing
                                   End If

                                   AddHandler txtsearch.SelectedIndexChanged, AddressOf txtsearch_SelectedIndexChanged

                                   ' Fire event to tell dashboard data is ready
                                   RaiseEvent DataLoaded()
                               End Sub)
                 End Sub)
    End Sub


    Private Sub gvUsers_CellDoubleClick(sender As Object, e As GridViewCellEventArgs) Handles gvUsers.CellDoubleClick

    End Sub

    Private Sub gvUsers_DoubleClick(sender As Object, e As EventArgs) Handles gvUsers.DoubleClick
        If gvUsers.Rows.Count > 0 Then

            status = "UPDATE"
            txtsearch.Enabled = False

            txtFirstname.Text = gvUsers.CurrentRow.Cells("fldEmpFirstName").Value.ToString()
            txtEmpNo.Text = gvUsers.CurrentRow.Cells("fldEmpNo").Value.ToString()
            txtLastname.Text = gvUsers.CurrentRow.Cells("fldEmpLastName").Value.ToString()
            txtMiddlename.Text = gvUsers.CurrentRow.Cells("fldEmpMiddleName").Value.ToString()
            txtSection.Text = gvUsers.CurrentRow.Cells("fldSection").Value.ToString()
            txtDept.Text = gvUsers.CurrentRow.Cells("fldDepartment").Value.ToString()

            tsAll.Value = gvUsers.CurrentRow.Cells("fldDeptAll").Value()
            tsHRGA.Value = gvUsers.CurrentRow.Cells("fldDeptHRGA").Value()
            tsPresident.Value = gvUsers.CurrentRow.Cells("fldDeptPresident").Value()
            tsACCTG.Value = gvUsers.CurrentRow.Cells("fldDeptAcctg").Value()
            tsPC.Value = gvUsers.CurrentRow.Cells("fldDeptPC").Value()
            tsQA.Value = gvUsers.CurrentRow.Cells("fldDeptQA").Value()
            tsWH.Value = gvUsers.CurrentRow.Cells("fldDeptWH").Value()
            tsLOG.Value = gvUsers.CurrentRow.Cells("fldDeptLog").Value()
            tsFAB.Value = gvUsers.CurrentRow.Cells("fldDeptFab").Value()
            tsFACILITY.Value = gvUsers.CurrentRow.Cells("fldDeptFac").Value() /
            tsFFC.Value = gvUsers.CurrentRow.Cells("fldDeptFFC").Value()
            tsENGG.Value = gvUsers.CurrentRow.Cells("fldDeptEngg").Value()
            tsPROJECT.Value = gvUsers.CurrentRow.Cells("fldDeptProject").Value()
            tsCommon.Value = gvUsers.CurrentRow.Cells("fldDeptCommon").Value()
            tsMIS.Value = gvUsers.CurrentRow.Cells("fldDeptMIS").Value()
            tsBSS.Value = gvUsers.CurrentRow.Cells("fldDeptBSS").Value()
            tsQC.Value = gvUsers.CurrentRow.Cells("fldDeptQC").Value()
            tsIVG.Value = gvUsers.CurrentRow.Cells("fldDeptIVG").Value()
            tsFGM.Value = gvUsers.CurrentRow.Cells("fldDeptFGM").Value()
            tsKAIZEN.Value = gvUsers.CurrentRow.Cells("fldDeptKaizen").Value()
            tsTRAINING.Value = gvUsers.CurrentRow.Cells("fldDeptTraining").Value()
            tsINJ.Value = gvUsers.CurrentRow.Cells("fldDeptEnggInj").Value()
            tsPROD.Value = gvUsers.CurrentRow.Cells("fldDeptProd").Value()
            tsSAFETY.Value = gvUsers.CurrentRow.Cells("fldDeptSafety").Value()
            tsSRC.Value = gvUsers.CurrentRow.Cells("fldDeptEnggSRC").Value()
            tsEVAL.Value = gvUsers.CurrentRow.Cells("fldDeptEval").Value()

            btnCancel.Enabled = True
        End If
    End Sub

    Private Sub gvUsers_CommandCellClick(sender As Object, e As GridViewCellEventArgs) Handles gvUsers.CommandCellClick
        If e.Column.HeaderText = "DELETE" Then
            RadMessageBox.SetThemeName("VisualStudio2022Light")
            Dim result As DialogResult = RadMessageBox.Show("Are you sure you want to delete this user?", "CONFIRMATION", MessageBoxButtons.YesNo, RadMessageIcon.Question)
            If result = DialogResult.Yes Then

                Dim userId As Integer = gvUsers.CurrentRow.Cells("fldUID").Value()
                If dUser.DeleteUser(userId) Then
                    RadMessageBox.Show("User successfully deleted!", "SUCCESS", MessageBoxButtons.OK, RadMessageIcon.Info)
                    selectAllUsers()
                End If
            End If
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        btnCancel.Enabled = False
        txtsearch.Enabled = True
        clearFields()
        status = "INSERT"
    End Sub

    Private Sub txtFirstname_TextChanged(sender As Object, e As EventArgs) Handles txtFirstname.TextChanged

    End Sub
End Class
