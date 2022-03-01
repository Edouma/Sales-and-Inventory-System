Imports System.Data.SqlClient
Public Class frmLogin
    Dim con = New SqlConnection("data source=.; database=SalesAndInventoryDB; integrated security = SSPI")

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtnLogin.Click

        Try
            Dim cmd = New SqlCommand("select UserName, Password1 from registration where UserName= '" & txtUsername.Text & "' and Password1 = '" & txtPassword.Text & "'", con)
            con.Open()
            Dim rdr As SqlDataReader = cmd.ExecuteReader()

            If rdr.HasRows Then
                frmDashBoard.Show()
                Me.Hide()
                txtUsername.Clear()
                txtPassword.Clear()
            Else

                MessageBox.Show("Invalid Username or Password!..", " Invalid Login.. ")

            End If

            con.close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try



    End Sub

    Private Sub lblCancel_Click(sender As Object, e As EventArgs) Handles lblCancel.Click
        txtPassword.Clear()
        txtUsername.Clear()

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class



