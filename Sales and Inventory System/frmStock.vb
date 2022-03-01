Imports System.Data.SqlClient
Public Class frmStock


    Private Sub frmStock_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try

            Dim con = New SqlConnection("data source=.; database=SalesAndInventoryDB; integrated security = SSPI")

            con.Open()
            Dim adaptor As New SqlDataAdapter("select * from Product", con)
            Dim table As New DataTable()
            adaptor.Fill(table)
            DataGridView1.DataSource = table

            con.Close()
        Catch ex As Exception

        End Try
    End Sub
End Class