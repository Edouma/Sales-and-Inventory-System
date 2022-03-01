Imports System.Data.Sql
Imports System.Data.SqlClient

Public Class frmEmployees
    Dim con = New SqlConnection("data source=.; database=SalesAndInventoryDB; integrated security = SSPI")


    Private Sub frmEmployees_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Dim cmd = New SqlCommand("select * from employees", con)
        'con.Open()
        'Dim rdr As SqlDataReader = cmd.ExecuteReader()


        'rdr.Read()
        'If rdr.HasRows Then
        '    txtEmpNo.Text = rdr.Item("EmpNo").ToString
        '    txtFirst.Text = rdr.Item("FirstName").ToString
        '    txtLast.Text = rdr.Item("LastName").ToString
        '    cboGender.Text = rdr.Item("Gender").ToString
        '    txtContact.Text = rdr.Item("Contact").ToString
        '    txtCity.Text = rdr.Item("City").ToString
        '    txtAddress.Text = rdr.Item("Address1").ToString
        '    txtEmail.Text = rdr.Item("Email").ToString
        'End If
        'con.Close()




    End Sub

    Private Sub btnEmployees_Click(sender As Object, e As EventArgs) Handles btnEmployees.Click
        frmList.Show()
        Me.Hide()

    End Sub

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        txtEmpNo.Clear()
        txtFirst.Clear()
        txtLast.Clear()
        txtEmail.Clear()
        txtContact.Clear()
        txtCity.Clear()
        txtAddress.Clear()
        cboGender.SelectedIndex = -1
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try

            Dim sql As String = "insert into employees(FirstName, LastName, Gender, Contact, City, Address1, Email)values(@firstname, @lastname, @gender, @contact, @city, @address, @email)"

            Dim cmd = New SqlCommand(sql, con)

            cmd.Parameters.AddWithValue("@firstname", txtFirst.Text)
            cmd.Parameters.AddWithValue("@lastname", txtLast.Text)
            cmd.Parameters.AddWithValue("@gender", cboGender.Text)
            cmd.Parameters.AddWithValue("@contact", txtContact.Text)
            cmd.Parameters.AddWithValue("@city", txtCity.Text)
            cmd.Parameters.AddWithValue("@address", txtAddress.Text)
            cmd.Parameters.AddWithValue("@email", txtEmail.Text)
            con.open()

            cmd.ExecuteNonQuery()
            MsgBox("New Record Added")

            con.close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        
    End Sub
End Class