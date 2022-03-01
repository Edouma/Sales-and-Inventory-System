Imports System.Data.SqlClient
Public Class frmList

    Private Sub frmList_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim con = New SqlConnection("data source=.; database=SalesAndInventoryDB; integrated security = SSPI")
        'Dim cmd = New SqlCommand("select * from employees", con)


        'con.open()
        'Dim rdr As SqlDataReader = cmd.ExecuteReader()

        'DataGridView1.DataSource = rdr


        'con.Close()
        Dim adaptor As New SqlDataAdapter("select * from employees", con)
        Dim table As New DataTable()
        adaptor.Fill(table)
        DataGridView1.DataSource = table

    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox4.TextChanged

    End Sub
End Class