Imports System.Data.SqlClient
Public Class frmAddNew_Product
    Dim con = New SqlConnection("data source=.; database=SalesAndInventoryDB; integrated security = SSPI")
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtItem.Clear()
        txtQuantity.Clear()

    End Sub

    Private Sub btnAddNewProduct_Click(sender As Object, e As EventArgs) Handles btnAddNewProduct.Click
        Try

            Dim sql = "insert into Product (item , Quantity) values (@item, @Quantity)"
            Dim cmd = New SqlCommand(sql, con)

            cmd.Parameters.AddWithValue("@item", txtItem.Text)
            cmd.Parameters.AddWithValue("@Quantity", txtQuantity.Text)
            con.open()

            cmd.ExecuteNonQuery()
            MsgBox("New Item Added")


        Catch ex As Exception
            MsgBox(ex.Message)

        Finally
            con.close()
        End Try
    End Sub

    Private Sub frmAddNew_Product_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class