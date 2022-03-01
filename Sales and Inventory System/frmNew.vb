Public Class frmNew

    Private Sub btnNewProduct_Click(sender As Object, e As EventArgs) Handles btnNewProduct.Click
        frmAddNew_Product.Show()
        Me.Hide()

    End Sub

    Private Sub BtnUpdateQuantity_Click(sender As Object, e As EventArgs) Handles BtnUpdateQuantity.Click
        frmUpdate__Quantity.Show()
        Me.Hide()

    End Sub
End Class