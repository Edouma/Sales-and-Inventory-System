Imports System.Data.SqlClient
Public Class frmSales
    Dim con = New SqlConnection("data source=.; database=SalesAndInventoryDB; integrated security = SSPI")


    Private Sub frmSales_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try

            Dim con = New SqlConnection("data source=.; database=SalesAndInventoryDB; integrated security = SSPI")

            con.Open()
            Dim adaptor As New SqlDataAdapter("select * from MakePurchase", con)
            Dim table As New DataTable()
            adaptor.Fill(table)
            DataGridView1.DataSource = table

            con.Close()
        Catch ex As Exception

        End Try

    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Try
            Dim cmd = New SqlCommand("select * from MakePurchase where productId = '" & txtSearch.Text & "'", con)
            con.Open()
            Dim rdr As SqlDataReader = cmd.ExecuteReader()

            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        

    End Sub
End Class