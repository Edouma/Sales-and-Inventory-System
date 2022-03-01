Imports System.Data.SqlClient
Public Class frmNewUser
    Dim con = New SqlConnection("data source=.; database=SalesAndInventoryDB; integrated security = SSPI")


    Private Sub Label5_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub frmNewUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click

        If txtFirstName.Text.Trim() = "" Or txtLastName.Text.Trim() = "" Or txtPassword.Text.Trim() = "" Or txtUserName.Text.Trim() = "" Then

            MsgBox("All Fields Marked in asterix should be Filled to Continue")

        Else
            Try

                Dim sql As String = "insert into registration(FirstName, LastName, UserName, Password1 )values(@first, @last, @username, @password)"

                Dim cmd = New SqlCommand(sql, con)

                cmd.Parameters.AddWithValue("@first", txtFirstName.Text)
                cmd.Parameters.AddWithValue("@last", txtLastName.Text)
                cmd.Parameters.AddWithValue("@username", txtUserName.Text)
                cmd.Parameters.AddWithValue("@password", txtPassword.Text)

                con.open()

                cmd.ExecuteNonQuery()
                MsgBox("New User Added")


            Catch ex As Exception
                MsgBox(ex.Message)

                con.close()
            End Try
        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

    End Sub
End Class