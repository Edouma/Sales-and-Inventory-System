Imports System.Data.SqlClient
Public Class frmUpdate__Quantity



    Private Sub frmUpdate__Quantity_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try


            Dim con = New SqlConnection("data source=.; database=SalesAndInventoryDB; integrated security = SSPI")
            Dim adaptor As New SqlDataAdapter("select * from Product", con)
            con.Open()
            Dim table As New DataTable()
            adaptor.Fill(table)
            cboItem.DataSource = table
            cboItem.DisplayMember = "item"
            cboItem.ValueMember = "ProductID"

            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try


    End Sub

    Private Sub btnUpdateQuantity_Click(sender As Object, e As EventArgs) Handles btnUpdateQuantity.Click

        Try

            Dim con = New SqlConnection("data source=.; database=SalesAndInventoryDB; integrated security = SSPI")
            Dim sql As String = "update Product set Quantity = Quantity + '" & txtQuantity.Text & "' where item ='" & cboItem.Text & "'"

            'Dim sql As String = "update Product set Quantity =  @Quantity where item = @Items"


            Dim cmd As New SqlCommand(sql, con)
            'cmd.Parameters.AddWithValue("@Quantity", txtQuantity.Text)
            'cmd.Parameters.AddWithValue("@Items", cboItem.Text)
            con.Open()


            cmd.ExecuteNonQuery()
            MsgBox("Quantity Updated")

            con.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub cboItem_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboItem.SelectedIndexChanged

    End Sub
End Class