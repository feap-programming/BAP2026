Imports System.Windows.Controls
Imports Telerik.WinControls.UI

Public Class cGvAllMajorRef

    Public Sub DesignGrid(gv As RadGridView)
        ' Clear existing columns
        gv.Columns.Clear()


        ' Set grid properties
        gv.AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.Fill
        gv.ReadOnly = True
        gv.AllowAddNewRow = False
        gv.AllowDeleteRow = False
        'gv.EnableFiltering = True
        gv.ShowFilteringRow = True
        gv.MasterTemplate.ShowRowHeaderColumn = False


        gv.EnableAlternatingRowColor = True
        gv.TableElement.BackColor = Color.Lavender
        gv.TableElement.AlternatingRowColor = Color.Lavender
        gv.TableElement.DrawFill = True



        gv.EnableHotTracking = True
        gv.SelectionMode = Telerik.WinControls.UI.GridViewSelectionMode.FullRowSelect
        gv.MultiSelect = False



        'gv.TableElement.AlternatingRowColor = Color.AliceBlue

        ' Define columns
        Dim colMRID As New GridViewTextBoxColumn()
        colMRID.FieldName = "fldMID"
        colMRID.HeaderText = "ID"
        colMRID.Width = 50
        colMRID.IsVisible = False

        'PIN - major ref, desc 1, desc 2
        'width
        Dim colMajorRefNo As New GridViewTextBoxColumn()
        colMajorRefNo.FieldName = "fldMajorRefNo"
        colMajorRefNo.HeaderText = "Major Reference No"
        colMajorRefNo.TextAlignment = ContentAlignment.MiddleCenter
        colMajorRefNo.Width = 120
        colMajorRefNo.IsPinned = True
        colMajorRefNo.PinPosition = Telerik.WinControls.UI.PinnedColumnPosition.Left


        Dim colfldDesc1 As New GridViewTextBoxColumn()
        colfldDesc1.FieldName = "fldDesc1"
        colfldDesc1.HeaderText = "Description 1"
        colfldDesc1.TextAlignment = ContentAlignment.MiddleCenter
        colfldDesc1.Width = 200
        colfldDesc1.IsPinned = True
        colfldDesc1.PinPosition = Telerik.WinControls.UI.PinnedColumnPosition.Left

        Dim colflDesc2 As New GridViewTextBoxColumn()
        colflDesc2.FieldName = "fldDesc2"
        colflDesc2.HeaderText = "Description 2"
        colflDesc2.TextAlignment = ContentAlignment.MiddleCenter
        colflDesc2.Width = 200
        colflDesc2.IsPinned = True
        colflDesc2.PinPosition = Telerik.WinControls.UI.PinnedColumnPosition.Left


        Dim colJpyAmount As New GridViewTextBoxColumn()
        colJpyAmount.FieldName = "fldJpyAmount"
        colJpyAmount.HeaderText = "Jpy Amount"
        colJpyAmount.TextAlignment = ContentAlignment.MiddleCenter
        colJpyAmount.Width = 70

        Dim colTotalAmount As New GridViewTextBoxColumn()
        colTotalAmount.FieldName = "fldTotalAmount"
        colTotalAmount.HeaderText = "Total Amount"
        colTotalAmount.TextAlignment = ContentAlignment.MiddleCenter
        colTotalAmount.Width = 70

        Dim colDept As New GridViewTextBoxColumn()
        colDept.FieldName = "fldDept"
        colDept.HeaderText = "Department"
        colDept.TextAlignment = ContentAlignment.MiddleCenter
        colDept.Width = 30

        Dim colSubRefNo As New GridViewTextBoxColumn()
        colSubRefNo.FieldName = "fldSubRefNo"
        colSubRefNo.HeaderText = "Sub Reference No."
        colSubRefNo.TextAlignment = ContentAlignment.MiddleCenter
        colSubRefNo.Width = 70

        Dim colProject As New GridViewTextBoxColumn()
        colProject.FieldName = "fldProject"
        colProject.HeaderText = "Project"
        colProject.TextAlignment = ContentAlignment.MiddleCenter
        colProject.Width = 50

        Dim colQty As New GridViewTextBoxColumn()
        colQty.FieldName = "fldQty"
        colQty.HeaderText = "Quatnity"
        colQty.TextAlignment = ContentAlignment.MiddleCenter
        colQty.Width = 30

        Dim colProcess As New GridViewTextBoxColumn()
        colProcess.FieldName = "fldProcess"
        colProcess.HeaderText = "Process"
        colProcess.TextAlignment = ContentAlignment.MiddleCenter
        colProcess.Width = 30


        Dim colDateAdded As New GridViewDateTimeColumn()
        colDateAdded.FieldName = "fldDateAdded"
        colDateAdded.HeaderText = "Date Added"
        colDateAdded.TextAlignment = ContentAlignment.MiddleCenter
        colDateAdded.Width = 130
        colDateAdded.Format = DateTimePickerFormat.Custom
        colDateAdded.CustomFormat = "yyyy-MM-dd"



        ' columns to grid
        gv.Columns.Add(colMRID)
        gv.Columns.Add(colMajorRefNo)
        gv.Columns.Add(colfldDesc1)
        gv.Columns.Add(colflDesc2)
        gv.Columns.Add(colJpyAmount)
        gv.Columns.Add(colTotalAmount)
        gv.Columns.Add(colDept)
        gv.Columns.Add(colSubRefNo)
        gv.Columns.Add(colProject)
        gv.Columns.Add(colProcess)
        gv.Columns.Add(colQty)
        gv.Columns.Add(colDateAdded)


        gv.TableElement.TableHeaderHeight = 50
        gv.EnableAlternatingRowColor = True
        'gv.EnableFiltering = True
        gv.ShowFilteringRow = True
        gv.EnableGrouping = True
        gv.ShowGroupPanel = False

        gv.AllowRowReorder = True
        gv.MultiSelect = False
        gv.AllowRowResize = False
        gv.AllowAddNewRow = False

    End Sub

    Public Sub desgincolumn(column As RadGridView, combo As RadMultiColumnComboBox)

        column.AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.Fill
        column.AllowEditRow = False
        column.AllowDeleteRow = False
        column.ReadOnly = False
        column.EnableFiltering = True


        column.TableElement.TableHeaderHeight = 35

        combo.MultiColumnComboBoxElement.DropDownWidth = 600

        For Each col As GridViewDataColumn In column.Columns
            col.HeaderTextAlignment = ContentAlignment.MiddleCenter
            col.TextAlignment = ContentAlignment.MiddleCenter



            Select Case col.FieldName


                Case "fldMajorRefNo"
                    col.HeaderText = "Major Reference No"
                    col.Width = 150


                Case "fldJpyAmount"
                    col.HeaderText = "JYP Amount"
                    col.Width = 130

                Case "fldProject"
                    col.HeaderText = "Projects"
                    col.Width = 120

                Case "fldTotalAmount"
                    col.IsVisible = False

                Case "fldSubRefNo"
                    col.IsVisible = False


                Case "fldClassDesc"
                    col.IsVisible = False

                Case "fldClassCode"
                    col.IsVisible = False



                    col.HeaderTextAlignment = ContentAlignment.MiddleCenter

                    col.TextAlignment = ContentAlignment.MiddleCenter

            End Select
        Next

        column.TableElement.RowHeight = 28
        column.TableElement.AlternatingRowColor = Color.FromArgb(240, 245, 255)




    End Sub

    Public Sub colsubrefcb(column As RadGridView, combo As RadMultiColumnComboBox)

        column.AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.Fill
        column.AllowEditRow = False
        column.AllowDeleteRow = False
        column.ReadOnly = False
        column.EnableFiltering = True
        column.TableElement.TableHeaderHeight = 35

        combo.MultiColumnComboBoxElement.DropDownWidth = 800

        For Each col As GridViewDataColumn In column.Columns
            col.HeaderTextAlignment = ContentAlignment.MiddleCenter
            col.TextAlignment = ContentAlignment.MiddleCenter

            'subref' 
            'description'
            'class

            Select Case col.FieldName
                Case "fldMajorRefNo"
                    col.IsVisible = False

                Case "fldJpyAmount"
                    col.IsVisible = False

                Case "fldProject"
                    col.IsVisible = False

                Case "fldSubRefNo"
                    col.PinPosition = PinnedColumnPosition.Left
                    col.HeaderText = "Sub Major Ref No"
                    col.Width = 140

                Case "fldClassCode"
                    col.HeaderText = "Class Code"
                    col.Width = 120

                Case "fldClassDesc"
                    col.HeaderText = "Class Description"
                    col.Width = 120

            End Select


        Next

    End Sub


End Class