Imports MySql.Data.MySqlClient

Public Class cInsertAddRec

    Dim dbMain As New cMainDb

    Public Function InsertRec(p_MajorRefNo As String, p_SubRefNo As String,
                               p_Desc1 As String, p_Desc2 As String,
                               p_Process As String,
                                p_Dept As String, p_Project As String, p_MonthBudget As Date, p_JpyAmount As Decimal, p_TotalAmount As Decimal, p_Qty As Decimal) As Boolean


        GlobalVariables.myParam.Clear()
        GlobalVariables.myParam.Add(New MySqlParameter("p_MajorRefNo", p_MajorRefNo))
        GlobalVariables.myParam.Add(New MySqlParameter("p_SubRefNo", p_SubRefNo))
        GlobalVariables.myParam.Add(New MySqlParameter("p_Desc1", p_Desc1))
        GlobalVariables.myParam.Add(New MySqlParameter("p_Desc2", p_Desc2))
        GlobalVariables.myParam.Add(New MySqlParameter("p_Process", p_Process))
        GlobalVariables.myParam.Add(New MySqlParameter("p_Dept", p_Dept))
        GlobalVariables.myParam.Add(New MySqlParameter("p_Project", p_Project))
        GlobalVariables.myParam.Add(New MySqlParameter("p_MonthBudget", p_MonthBudget))
        GlobalVariables.myParam.Add(New MySqlParameter("p_JpyAmount", p_JpyAmount))
        GlobalVariables.myParam.Add(New MySqlParameter("p_TotalAmount", p_TotalAmount))
        GlobalVariables.myParam.Add(New MySqlParameter("p_Qty", p_Qty))


        Dim dt As DataTable = dbMain.dbSelect("SP_InsertAddRec")

        If dt IsNot Nothing AndAlso dt.Rows.Count > 0 Then

            Return CInt(dt.Rows(0)("AffectedRows")) > 0

        End If

        Return False

    End Function


End Class
