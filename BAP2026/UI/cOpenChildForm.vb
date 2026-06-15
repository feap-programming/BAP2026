Imports Telerik.WinControls.UI

Public Class cOpenChildForm

    Private currentchildform As Form
    Public Sub openChildform(ByVal childform As Form, ByVal pnlBody As Panel, ByVal lblform As RadLabel)


        If currentchildform IsNot Nothing Then
            currentchildform.Close()
        End If
        currentchildform = childform

        childform.TopLevel = False
        childform.FormBorderStyle = FormBorderStyle.None
        childform.AutoScaleMode = AutoScaleMode.Font
        childform.Dock = DockStyle.Fill
        pnlBody.Controls.Add(childform)
        pnlBody.Tag = childform
        childform.BringToFront()
        lblform.Text = childform.Text
        childform.Show()

    End Sub


    Public Sub openChildform(ByVal childform As Form, ByVal pnlBody As RadScrollablePanel)
        If currentchildform IsNot Nothing Then
            currentchildform.Close()
        End If
        currentchildform = childform

        childform.AutoScaleMode = AutoScaleMode.Font

        childform.TopLevel = False
        childform.FormBorderStyle = FormBorderStyle.None
        childform.Dock = DockStyle.Fill
        pnlBody.Controls.Add(childform)
        pnlBody.Tag = childform
        childform.BringToFront()
        childform.Show()
    End Sub

End Class
