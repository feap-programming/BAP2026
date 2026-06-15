Imports MySql.Data.MySqlClient
Imports Telerik.WinControls

Public Class cUpdateMajorBudget


    Dim dbMain As New cMainDb



    Public Function UpdateMajorBudget(
        ByVal p_MID As Integer,
        ByVal p_Desc1 As String,
        ByVal p_Desc2 As String,
        ByVal p_Project As String,
        ByVal p_Process As String,
        ByVal p_Qty As Integer) As Boolean

        Dim result As Boolean




        Try
            Dim conn As New MySqlConnection(GlobalVariables.BAPconnString)
            conn.Open()

            Dim cmd As New MySqlCommand("SP_UpdateMajorBudget", conn)
            cmd.CommandType = CommandType.StoredProcedure

            cmd.Parameters.AddWithValue("p_MID", p_MID)
            cmd.Parameters.AddWithValue("p_Desc1", p_Desc1)
            cmd.Parameters.AddWithValue("p_Desc2", p_Desc2)
            cmd.Parameters.AddWithValue("p_Project", p_Project)
            cmd.Parameters.AddWithValue("p_Process", p_Process)
            cmd.Parameters.AddWithValue("p_Qty", p_Qty)

            cmd.ExecuteNonQuery()
            conn.Close()

            result = True

        Catch ex As Exception
            RadMessageBox.Show(ex.Message, "WARNING", MessageBoxButtons.OK, RadMessageIcon.Exclamation)
            result = False
        End Try

        Return result

    End Function



End Class
