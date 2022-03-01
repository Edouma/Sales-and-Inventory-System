Public Class frmDashBoard

    Private Sub LinkLabel3_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkEmployees.LinkClicked
        frmEmployees.Show()

    End Sub

    Private Sub LinkNewUser_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkNewUser.LinkClicked
        frmNewUser.Show()

    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLogOut.LinkClicked

        If MessageBox.Show("Do you really want to Exit from the Dashboard", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Me.Close()
            frmLogin.Show()

        End If


    End Sub

    Private Sub LinkLabel4_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel4.LinkClicked
        frmNew.Show()

    End Sub

    Private Sub LinkStock_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkStock.LinkClicked
        FrmMakePurchase.Show()
    End Sub

    Private Sub LinkSales_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkSales.LinkClicked
        frmSales.show()
    End Sub

    Private Sub LinkLabel3_LinkClicked_1(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel3.LinkClicked
        frmStock.Show()
    End Sub

    Private Sub LinkReports_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)

    End Sub
End Class