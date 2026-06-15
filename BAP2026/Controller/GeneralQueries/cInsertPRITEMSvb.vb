Imports MySql.Data.MySqlClient



Public Class cInsertPRITEMSvb

    Dim dbMain As New cMainDb


    Public Function InsertPRITEMS(TransCode As String, BudRef As String, ICode As String, _Desc As String, QTY As Decimal, Unit As String, Signature As String, MO As Date,
                                  _Class As String, Dept As String, _Process As String, Rate As Decimal, UnitPrice As Decimal, TotalCost As Decimal, SubRefNo As String,
                                  UnitPriceJPY As Decimal, TotalCostJPY As Decimal, PEZA As String, FAClass As String, FAType As String, AssemblyType As String, pFixedAssCategory As String,
                                  ItemNo As Decimal, PrincipalNO As String)

        Dim dt As DataTable


        GlobalVariables.myParam.Clear()
        GlobalVariables.myParam.Add(New MySqlParameter("@TransCode", TransCode))
        GlobalVariables.myParam.Add(New MySqlParameter("@BudRefNum", BudRef))
        GlobalVariables.myParam.Add(New MySqlParameter("@ICode", ICode))
        GlobalVariables.myParam.Add(New MySqlParameter("@_Desc", _Desc))
        GlobalVariables.myParam.Add(New MySqlParameter("@QTY", QTY))
        GlobalVariables.myParam.Add(New MySqlParameter("@Unit", Unit))
        GlobalVariables.myParam.Add(New MySqlParameter("@Signature", Signature))
        GlobalVariables.myParam.Add(New MySqlParameter("@MO", MO))
        GlobalVariables.myParam.Add(New MySqlParameter("@Class", _Class))
        GlobalVariables.myParam.Add(New MySqlParameter("@Dept", Dept))
        GlobalVariables.myParam.Add(New MySqlParameter("@_Process", _Process))
        GlobalVariables.myParam.Add(New MySqlParameter("@Rate", Rate))
        GlobalVariables.myParam.Add(New MySqlParameter("@UnitPrice", UnitPrice))
        GlobalVariables.myParam.Add(New MySqlParameter("@TotalCost", TotalCost))
        GlobalVariables.myParam.Add(New MySqlParameter("@FAType", FAType))
        GlobalVariables.myParam.Add(New MySqlParameter("@SubRefNo", SubRefNo))
        GlobalVariables.myParam.Add(New MySqlParameter("@UnitPriceJPY", UnitPriceJPY))
        GlobalVariables.myParam.Add(New MySqlParameter("@TotalCostJPY", TotalCostJPY))
        GlobalVariables.myParam.Add(New MySqlParameter("@Peza", PEZA))
        GlobalVariables.myParam.Add(New MySqlParameter("@FAClass", FAClass))
        GlobalVariables.myParam.Add(New MySqlParameter("@AssemblyType", AssemblyType))
        GlobalVariables.myParam.Add(New MySqlParameter("@pFixedAssCategory", pFixedAssCategory))
        GlobalVariables.myParam.Add(New MySqlParameter("@ItemNo", ItemNo))
        GlobalVariables.myParam.Add(New MySqlParameter("@PrincipalNo", PrincipalNO))

        dt = dbMain.dbSelect("SP_InsertMOIv3")

        Return dt
    End Function

End Class
