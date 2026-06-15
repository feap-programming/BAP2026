Imports MySql.Data.MySqlClient
Imports Org.BouncyCastle.Crypto.Agreement.Srp
Public Class cInsertInvestmentPR

    Dim dbMain As New cMainDb
    Public Function InsertInvestmentPR(BudRefNum As String, TransCode As String, Monthorder As Date, OrderDesc As String, Classification As String, OrderDepartment As String,
                                       _Process As String, QTY As Decimal, UOM As String, OrderStatus As String, OrderRemarks As String, Signature As String,
                                       MO As Date, DN As Date, EC As String, EOA As Decimal, EJPY As Decimal, TOPRA As Decimal, RN As String, Rate As Decimal,
                                       MoldDie As String, InvestmentNo As String)


        Dim dt As DataTable

        GlobalVariables.myParam.Clear()

        GlobalVariables.myParam.Add(New MySqlParameter("@BudRefNum", BudRefNum))
        GlobalVariables.myParam.Add(New MySqlParameter("@TransCode", TransCode))
        GlobalVariables.myParam.Add(New MySqlParameter("@MonthOrder", Monthorder))
        GlobalVariables.myParam.Add(New MySqlParameter("@OrderDesc", OrderDesc))
        GlobalVariables.myParam.Add(New MySqlParameter("@Classification", Classification))
        GlobalVariables.myParam.Add(New MySqlParameter("@OrderDepartment", OrderDepartment))
        GlobalVariables.myParam.Add(New MySqlParameter("@_Process", _Process))
        GlobalVariables.myParam.Add(New MySqlParameter("@QTY", QTY))
        GlobalVariables.myParam.Add(New MySqlParameter("@UOM", UOM))
        GlobalVariables.myParam.Add(New MySqlParameter("@OrderStatus", OrderStatus))
        GlobalVariables.myParam.Add(New MySqlParameter("@OrderRemarks", OrderRemarks))
        GlobalVariables.myParam.Add(New MySqlParameter("@Signature", Signature))
        GlobalVariables.myParam.Add(New MySqlParameter("@MO", MO))
        GlobalVariables.myParam.Add(New MySqlParameter("@DN", DN))
        GlobalVariables.myParam.Add(New MySqlParameter("@EC", EC))
        GlobalVariables.myParam.Add(New MySqlParameter("@EOA", EOA))
        GlobalVariables.myParam.Add(New MySqlParameter("EJPY", EJPY))
        GlobalVariables.myParam.Add(New MySqlParameter("TOPRA", TOPRA))
        GlobalVariables.myParam.Add(New MySqlParameter("RN", RN))
        GlobalVariables.myParam.Add(New MySqlParameter("Rate", Rate))
        GlobalVariables.myParam.Add(New MySqlParameter("MoldDie", MoldDie))
        GlobalVariables.myParam.Add(New MySqlParameter("InvestmentNo", InvestmentNo))


        dt = dbMain.dbSelect("SP_InsertInvestmentRecord")


        Return dt

    End Function

End Class
