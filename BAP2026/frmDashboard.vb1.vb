Imports System.Threading.Tasks
Imports Org.BouncyCastle.Asn1.Cmp
Imports Telerik.WinControls
Imports Telerik.WinControls.UI

Public Class FrmDashboard_vb1


    Dim openchildform As New cOpenChildForm


    Dim frmhome As New FrmHome

    Dim frmbcdudget As New frmCreateBudget




    Private Sub ShowLoading()

        RadPanel2.BringToFront()
        RadPanel2.Visible = True
        RadWaitingBar1.StartWaiting()
        Me.Refresh()
        Application.DoEvents()

    End Sub

    Private Sub HideLoading()
        RadWaitingBar1.StopWaiting()
        RadPanel2.Visible = False
    End Sub

    Private Function checkDept() As Boolean
        Dim dept As Boolean

        dept = If(GlobalVariables.SelectedDept <> String.Empty, True, False)
        Return dept
    End Function

    Private Sub FrmDashboard_vb1_Load(sender As Object, e As EventArgs) Handles MyBase.Load



        RadPanel2.Dock = DockStyle.Fill
        RadPanel2.Visible = False




        Dim dbMain As New cMainDb

        'Me.WindowState = FormWindowState.Maximized'

        'Linear theme'



        'Budget node image  alignment'

        'budget parent node'

        Dim budgetparentNode As Telerik.WinControls.UI.RadTreeNode = treeModules.Nodes("nodeBudget")
        budgetparentNode.Image = New Bitmap(My.Resources.budget, 25, 25)

        'budget child node'
        Dim nodeCreateBudget As Telerik.WinControls.UI.RadTreeNode = budgetparentNode.Nodes("nodeCreateBudget")
        nodeCreateBudget.Image = New Bitmap(My.Resources.add, 15, 15)

        Dim nodeConsolidatedBudget As Telerik.WinControls.UI.RadTreeNode = budgetparentNode.Nodes("nodeConsolidatedBudget")
        nodeConsolidatedBudget.Image = New Bitmap(My.Resources.fund, 15, 15)

        Dim nodeCreateReport As Telerik.WinControls.UI.RadTreeNode = budgetparentNode.Nodes("nodeCreateReport")
        nodeCreateReport.Image = New Bitmap(My.Resources.old_add, 15, 15)

        Dim nodeInvestment As Telerik.WinControls.UI.RadTreeNode = budgetparentNode.Nodes("nodeInvestment")
        nodeInvestment.Image = New Bitmap(My.Resources.arrows, 15, 15)

        Dim nodeUploadBudget As Telerik.WinControls.UI.RadTreeNode = budgetparentNode.Nodes("nodeUploadBudget")
        nodeUploadBudget.Image = New Bitmap(My.Resources.yen, 15, 15)



        'Requisition Node Parent'
        Dim Requisitionparentnode As Telerik.WinControls.UI.RadTreeNode = treeModules.Nodes("nodeRequisition")
        Requisitionparentnode.Image = New Bitmap(My.Resources.purchase, 25, 25)


        'Child node'
        Dim nodeNewRequisition As Telerik.WinControls.UI.RadTreeNode = Requisitionparentnode.Nodes("nodeNewRequisition")
        nodeNewRequisition.Image = New Bitmap(My.Resources.purchase__1_, 15, 15)


        Dim nodeViewRequisition As Telerik.WinControls.UI.RadTreeNode = Requisitionparentnode.Nodes("nodeViewRequisition")
        nodeViewRequisition.Image = New Bitmap(My.Resources.find, 15, 15)

        Dim nodeBudgetSummary As Telerik.WinControls.UI.RadTreeNode = Requisitionparentnode.Nodes("nodeBudgetSummary")
        nodeBudgetSummary.Image = New Bitmap(My.Resources.summary, 15, 15)

        Dim nodePurchaseRequisition As Telerik.WinControls.UI.RadTreeNode = Requisitionparentnode.Nodes("nodePurchaseRequisition")
        nodePurchaseRequisition.Image = New Bitmap(My.Resources.oldcart, 15, 15)



        'purchase node parent'

        Dim purchaseorderparentnode As Telerik.WinControls.UI.RadTreeNode = treeModules.Nodes("nodePurchaseOrder")
        purchaseorderparentnode.Image = New Bitmap(My.Resources.compliant, 25, 25)

        ' node child'
        Dim nodeViewOrder As Telerik.WinControls.UI.RadTreeNode = purchaseorderparentnode.Nodes("nodeViewOrder")
        nodeViewOrder.Image = New Bitmap(My.Resources.search, 15, 15)

        Dim nodeCreateOrder As Telerik.WinControls.UI.RadTreeNode = purchaseorderparentnode.Nodes("nodeCreateOrder")
        nodeCreateOrder.Image = New Bitmap(My.Resources.add_cart, 15, 15)

        Dim nodeInactiveStatus As Telerik.WinControls.UI.RadTreeNode = purchaseorderparentnode.Nodes("nodeInactiveStatus")
        nodeInactiveStatus.Image = New Bitmap(My.Resources.inactive, 15, 15)


        Dim nodePurchaseOrderChange As Telerik.WinControls.UI.RadTreeNode = purchaseorderparentnode.Nodes("nodePurchaseOrderChange")
        nodePurchaseOrderChange.Image = New Bitmap(My.Resources.order_change_cart, 15, 15)

        Dim nodeForcePurchaseOrder As Telerik.WinControls.UI.RadTreeNode = purchaseorderparentnode.Nodes("nodeForcePurchaseOrder")
        nodeForcePurchaseOrder.Image = New Bitmap(My.Resources.force, 15, 15)



        'Acquisition'

        Dim nodeActualAcquisition As Telerik.WinControls.UI.RadTreeNode = treeModules.Nodes("nodeActualAcquisition")
        nodeActualAcquisition.Image = New Bitmap(My.Resources.acquisition, 25, 25)



        'report node parent'

        Dim nodeparentnodeReport As Telerik.WinControls.UI.RadTreeNode = treeModules.Nodes("nodeReport")
        nodeparentnodeReport.Image = New Bitmap(My.Resources.report, 25, 25)


        'child node'

        Dim nodeInvestmentReport As Telerik.WinControls.UI.RadTreeNode = nodeparentnodeReport.Nodes("nodeInvestmentReport")
        nodeInvestmentReport.Image = New Bitmap(My.Resources.investment_report, 15, 15)



        'rfq parent node'
        Dim nodeparentRequestQuotation As Telerik.WinControls.UI.RadTreeNode = treeModules.Nodes("nodeRequestQuotation")
        nodeparentRequestQuotation.Image = New Bitmap(My.Resources.rfq, 25, 25)

        'rfq child node'
        Dim nodeRFQSuppliers As Telerik.WinControls.UI.RadTreeNode = nodeparentRequestQuotation.Nodes("nodeRFQSuppliers")
        nodeRFQSuppliers.Image = New Bitmap(My.Resources.supplier, 15, 15)

        Dim nodeSignatory As Telerik.WinControls.UI.RadTreeNode = nodeparentRequestQuotation.Nodes("nodeSignatory")
        nodeSignatory.Image = New Bitmap(My.Resources.signature, 15, 15)





        'sub-budget parent node'


        Dim nodeparentSubBudget As Telerik.WinControls.UI.RadTreeNode = treeModules.Nodes("nodeSubBudget")
        nodeparentSubBudget.Image = New Bitmap(My.Resources.currency, 25, 25)

        'budget child node'
        Dim nodeUploadandUpdateSubBudget As Telerik.WinControls.UI.RadTreeNode = nodeparentSubBudget.Nodes("nodeUploadandUpdateSubBudget")
        nodeUploadandUpdateSubBudget.Image = New Bitmap(My.Resources.up, 15, 15)




        Dim nodeManageuser As Telerik.WinControls.UI.RadTreeNode = treeModules.Nodes("nodeManageuser")
        nodeManageuser.Image = New Bitmap(My.Resources.user, 25, 25)


        openchildform.openChildform(frmhome, pnlBody)


        btnhome.Image = New Bitmap(My.Resources.home_button, btnhome.Width, btnhome.Height)

        btnexit.Image = New Bitmap(My.Resources._exit, btnexit.Width, btnexit.Height)



    End Sub

    Private Sub LoadingForm(frm As Form)


        ShowLoading()

        Task.Run(Sub()

                     Threading.Thread.Sleep(15000) '
                     Me.Invoke(Sub()

                                   openchildform.openChildform(frm, pnlBody)

                                   HideLoading()

                               End Sub)

                 End Sub)
    End Sub



    Private Sub treeModules_NodeMouseClick(sender As Object, e As Telerik.WinControls.UI.RadTreeViewEventArgs) Handles treeModules.NodeMouseClick
        Dim bSelectDept As Boolean = checkDept()

        If bSelectDept Then

            Select Case e.Node.Name


                Case "nodeManageuser"

                    Dim frmUser As New FrmRegister

                    ShowLoading()

                    Task.Run(Sub()
                                 ' Background: DB calls only
                                 frmUser.PreloadData()

                                 ' UI thread: show the form (triggers Form_Load which does UI setup)
                                 Me.Invoke(Sub()
                                               openchildform.openChildform(frmUser, pnlBody)
                                               HideLoading()
                                           End Sub)
                             End Sub)

                Case "nodeCreateBudget"
                    Dim frmbcdudget As New frmCreateBudget
                    frmbcdudget.SelectedDept = frmhome.SelectedDept
                    LoadingForm(frmbcdudget)


                Case "nodeNewRequisition"

                    Dim frmaddPR As New FrmAddPurchaseReq
                    frmaddPR.SelectedDept = frmhome.SelectedDept

                    LoadingForm(frmaddPR)


                Case "nodeCreateOrder"

                    Dim frmaddPO As New FrmAddPO
                    frmaddPO.SelectedDept = frmhome.SelectedDept

                    LoadingForm(frmaddPO)
            End Select

        Else
            RadMessageBox.SetThemeName("VisualStudio2022Light")
            RadMessageBox.Show("Please select a department to proceed.", "Department Not Selected", MessageBoxButtons.OK, RadMessageIcon.Error)
            Return
        End If

    End Sub

    Private Sub btnhome_Click(sender As Object, e As EventArgs) Handles btnhome.Click

        frmhome = New FrmHome()

        openchildform.openChildform(frmhome, pnlBody)

    End Sub

    Private Sub btnexit_Click(sender As Object, e As EventArgs) Handles btnexit.Click







        Dim login As New FrmLogin
        login.Show()
        Me.Close()


    End Sub

    Private Sub FrmDashboard_vb1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Application.Exit()
    End Sub

    Private Sub treeModules_SelectedNodeChanged(sender As Object, e As RadTreeViewEventArgs) Handles treeModules.SelectedNodeChanged

    End Sub
End Class
