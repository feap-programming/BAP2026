Imports System.Windows
Imports Telerik.WinControls

Public Class FrmLogin


    Dim dbHrms As New cHrmsDb
    Dim dbMain As New cMainDb

    Dim frmMain As New FrmDashboard_vb1



    Private Sub IconButton3_Click(sender As Object, e As EventArgs) Handles IconButton3.Click

        GlobalVariables.myParam.Clear()

        Dim dtemp As DataTable


        If txtUsername.Text = "" Then
            RadMessageBox.SetThemeName("VisualStudio2022Light")
            RadMessageBox.Show("Please Enter Username", "Error", MessageBoxButtons.OK, RadMessageIcon.Error)

        Else

            If txtPassword.Text = "" Then
                RadMessageBox.SetThemeName("VisualStudio2022Light")
                RadMessageBox.Show("Please Enter Password", "Error", MessageBoxButtons.OK, RadMessageIcon.Error)

            Else

                dbHrms.Login(txtUsername.Text, txtPassword.Text)

                If dbHrms.MySQLDataTable.Rows.Count > 0 Then
                    If dbHrms.MySQLDataTable.Rows(0).Item("countme").ToString = "1" Then

                        dbMain.addParameters("parEmpNo", txtUsername.Text)
                        dtemp = dbMain.dbSelect("SP_SelectUserByEmpNo")

                        If dtemp.Rows.Count > 0 Then

                            GlobalVariables.empNo = dtemp.Rows(0).Item("fldEmpNo")
                            GlobalVariables.empFirstName = dtemp.Rows(0).Item("fldEmpFirstName")
                            GlobalVariables.empMiddleName = dtemp.Rows(0).Item("fldEmpMiddleName")
                            GlobalVariables.empLastName = dtemp.Rows(0).Item("fldEmpLastName")
                            GlobalVariables.empDept = dtemp.Rows(0).Item("fldDepartment")
                            GlobalVariables.empSection = dtemp.Rows(0).Item("fldSection")
                            GlobalVariables.empUserType = dtemp.Rows(0).Item("fldUserType")

                            frmMain.Show()
                            Me.Hide()
                        End If

                    Else

                        RadMessageBox.SetThemeName("VisualStudio2022Light")
                        RadMessageBox.Show("Invalid Username or Password", "Error", MessageBoxButtons.OK, RadMessageIcon.Error)

                    End If

                End If

            End If

        End If



        'Try


        'Catch ex As Exception

        'End Try
    End Sub


End Class
