Imports System.Data.SqlClient
Public Class FrmMakePurchase
    Dim con = New SqlConnection("data source=.; database=SalesAndInventoryDB; integrated security = SSPI")

    Private Sub FrmMakePurchase_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        'Dim a, b, c, d
        'a = Trim(txtProductId.Text)
        'b = Trim(txtQuantity.Text)
        'c = Trim(txtSalesEmpNo.Text)
        'd = Trim(txtUnitPrice.Text)

        If txtQuantity.Text = "" Or txtUnitPrice.Text = "" Or txtSalesEmpNo.Text = "" Or txtProductId.Text = "" Then

            MsgBox("Please Fill in ProductId or Unit price or Quantity  or EmpNo to proceed")

        Else
            Try
                Dim sql As String = "insert into MakePurchase(item, unitPrice, Quantity, Date1, ProductID, EmpNo)values('" & cboItem.Text & "','" & txtUnitPrice.Text & "','" & txtQuantity.Text & "','" & DateTimePicker1.Value & "','" & txtProductId.Text & "','" & txtSalesEmpNo.Text & "')"
                Dim cmd = New SqlCommand(sql, con)
                con.open()

                cmd.ExecuteNonQuery()
                MsgBox("New Sale has been made")

                con.close()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If

    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Try

            Dim con = New SqlConnection("data source=.; database=SalesAndInventoryDB; integrated security = SSPI")
            Dim sql As String = "update Product set Quantity = Quantity - '" & txtQuantity.Text & "' where item ='" & cboItem.Text & "'"

            'Dim sql As String = "update Product set Quantity = @Quantity where item = @Item "

            Dim cmd As New SqlCommand(sql, con)
            'cmd.Parameters.AddWithValue("@Quantity", txtQuantity.Text)
            'cmd.Parameters.AddWithValue("@Item", cboItem.Text)
            con.Open()


            cmd.ExecuteNonQuery()
            MsgBox("Quantity Updated")

            con.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        txtProductId.Clear()
        txtQuantity.Clear()
        txtUnitPrice.Clear()

    End Sub
End Class