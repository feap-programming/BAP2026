Imports MySql.Data.MySqlClient

Public Class cCreatePO


    Dim dbMain As New cMainDb


    Public Function CreatePo(pSupplier As String, pVCode As String, pMOrdered As Date, pDDate As Date, pCurrency As String, pDiscount As Decimal, pDAmount As Decimal,
                             pPTO As Decimal, pPOAmt As Decimal, pRemarks As String, pSignature As String, pRate As Decimal)

        Dim dt As DataTable

        GlobalVariables.myParam.Clear()

        GlobalVariables.myParam.Add(New MySql.Data.MySqlClient.MySqlParameter("@pSupplier", pSupplier))
        GlobalVariables.myParam.Add(New MySql.Data.MySqlClient.MySqlParameter("@pVCode", pVCode))
        GlobalVariables.myParam.Add(New MySql.Data.MySqlClient.MySqlParameter("@pMOrdered", pMOrdered))
        GlobalVariables.myParam.Add(New MySql.Data.MySqlClient.MySqlParameter("@pDDate", pDDate))
        GlobalVariables.myParam.Add(New MySql.Data.MySqlClient.MySqlParameter("@pCurrency", pCurrency))
        GlobalVariables.myParam.Add(New MySql.Data.MySqlClient.MySqlParameter("@pDiscount", pDiscount))
        GlobalVariables.myParam.Add(New MySql.Data.MySqlClient.MySqlParameter("@pDAmount", pDAmount))
        GlobalVariables.myParam.Add(New MySql.Data.MySqlClient.MySqlParameter("@pTPO", pPTO))
        GlobalVariables.myParam.Add(New MySql.Data.MySqlClient.MySqlParameter("@pPOAmt", pPOAmt))
        GlobalVariables.myParam.Add(New MySql.Data.MySqlClient.MySqlParameter("@pRemarks", pRemarks))
        GlobalVariables.myParam.Add(New MySql.Data.MySqlClient.MySqlParameter("@pSignature", pSignature))
        GlobalVariables.myParam.Add(New MySql.Data.MySqlClient.MySqlParameter("@pRate", pRate))

        dt = dbMain.dbSelect("SP_CREATEPO")

        Return dt




    End Function




End Class
