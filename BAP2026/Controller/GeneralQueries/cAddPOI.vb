Imports MySql.Data.MySqlClient

Public Class cAddPOI

    Dim dbMain As New cMainDb

    Public Function cAddPOI(pchk As String, pPRNUM As String, pQTY As Decimal, pMO As Date, pSignature As String,
                        pUP As Decimal, pTC As Decimal, pCurrency As String, pDD As Date, pRate As Decimal,
                        pfldMOID As String, pQTYOUT As Decimal) As DataTable
        Dim dt As DataTable
        GlobalVariables.myParam.Clear()
        GlobalVariables.myParam.Add(New MySqlParameter("pchk", pchk))
        GlobalVariables.myParam.Add(New MySqlParameter("pPRNum", pPRNUM))
        GlobalVariables.myParam.Add(New MySqlParameter("pQTY", pQTY))
        GlobalVariables.myParam.Add(New MySqlParameter("pMO", pMO))
        GlobalVariables.myParam.Add(New MySqlParameter("pSignature", pSignature))
        GlobalVariables.myParam.Add(New MySqlParameter("pUP", pUP))
        GlobalVariables.myParam.Add(New MySqlParameter("pTC", pTC))
        GlobalVariables.myParam.Add(New MySqlParameter("pCurrency", pCurrency))
        GlobalVariables.myParam.Add(New MySqlParameter("pDD", pDD))
        GlobalVariables.myParam.Add(New MySqlParameter("pRate", pRate))
        GlobalVariables.myParam.Add(New MySqlParameter("pfldMOID", pfldMOID))
        GlobalVariables.myParam.Add(New MySqlParameter("pQTYOUT", pQTYOUT))
        dt = dbMain.dbSelect("SP_CREATETBLPOI")
        Return dt
    End Function




End Class

