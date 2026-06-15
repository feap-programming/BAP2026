Imports System.Windows.Media.Animation
Imports MySql.Data.MySqlClient

Public Class cInsertMPR

    Dim dbMain As New cMainDb

    Public Function InsertMPR(BudRefNum As String, TransCode As String, MonthOrder As Date, OrderDesc As String, Classification As String, OrderDepartment As String,
                          _Process As String, Qty As Decimal, UOM As String, OrderStatus As String, OrderRemarks As String, Signature As String, MO As Date, DN As Date,
                          EC As String, EOA As Decimal, EJPY As Decimal, TOPRA As Decimal, RN As String, Rate As Decimal, Moldie As String, NReason As String,
                          InsRequirements As String, pAccount As String, pFixedAssCategory As String, pExclusive As String, pExclusiveSupplier As String, pExclusiveReason As String
                         ) As DataTable
        Dim dt As DataTable
        GlobalVariables.myParam.Clear()
        GlobalVariables.myParam.Add(New MySqlParameter("@BudRefNum", BudRefNum))
        GlobalVariables.myParam.Add(New MySqlParameter("@TransCode", TransCode))
        GlobalVariables.myParam.Add(New MySqlParameter("@MonthOrder", MonthOrder))
        GlobalVariables.myParam.Add(New MySqlParameter("@OrderDesc", OrderDesc))
        GlobalVariables.myParam.Add(New MySqlParameter("@Classification", Classification))
        GlobalVariables.myParam.Add(New MySqlParameter("@OrderDepartment", OrderDepartment))
        GlobalVariables.myParam.Add(New MySqlParameter("@_Process", _Process))
        GlobalVariables.myParam.Add(New MySqlParameter("@QTY", Qty))
        GlobalVariables.myParam.Add(New MySqlParameter("@UOM", UOM))
        GlobalVariables.myParam.Add(New MySqlParameter("@OrderStatus", OrderStatus))
        GlobalVariables.myParam.Add(New MySqlParameter("@OrderRemarks", OrderRemarks))
        GlobalVariables.myParam.Add(New MySqlParameter("@Signature", Signature))
        GlobalVariables.myParam.Add(New MySqlParameter("@MO", MO))
        GlobalVariables.myParam.Add(New MySqlParameter("@DN", DN))
        GlobalVariables.myParam.Add(New MySqlParameter("@EC", EC))
        GlobalVariables.myParam.Add(New MySqlParameter("@EOA", EOA))
        GlobalVariables.myParam.Add(New MySqlParameter("@EJPY", EJPY))
        GlobalVariables.myParam.Add(New MySqlParameter("@TOPRA", TOPRA))
        GlobalVariables.myParam.Add(New MySqlParameter("@RN", RN))
        GlobalVariables.myParam.Add(New MySqlParameter("@Rate", Rate))
        GlobalVariables.myParam.Add(New MySqlParameter("@MoldDie", Moldie))
        GlobalVariables.myParam.Add(New MySqlParameter("@NReason", NReason))       ' 
        GlobalVariables.myParam.Add(New MySqlParameter("@InsRequirements", InsRequirements))
        GlobalVariables.myParam.Add(New MySqlParameter("@pAccount", pAccount))     ' 
        GlobalVariables.myParam.Add(New MySqlParameter("@pFixedAssCategory", pFixedAssCategory))
        GlobalVariables.myParam.Add(New MySqlParameter("@pExclusive", pExclusive)) ' 
        GlobalVariables.myParam.Add(New MySqlParameter("@pExclusiveSupplier", pExclusiveSupplier))
        GlobalVariables.myParam.Add(New MySqlParameter("@pExclusiveReason", pExclusiveReason))



        dt = dbMain.dbSelect("SP_InsertOrderv4")
        Return dt
    End Function


End Class
