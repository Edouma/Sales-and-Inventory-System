<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNew
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnNewProduct = New System.Windows.Forms.Button()
        Me.BtnUpdateQuantity = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnNewProduct
        '
        Me.btnNewProduct.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNewProduct.Location = New System.Drawing.Point(128, 80)
        Me.btnNewProduct.Name = "btnNewProduct"
        Me.btnNewProduct.Size = New System.Drawing.Size(115, 33)
        Me.btnNewProduct.TabIndex = 0
        Me.btnNewProduct.Text = "Add New Product"
        Me.btnNewProduct.UseVisualStyleBackColor = True
        '
        'BtnUpdateQuantity
        '
        Me.BtnUpdateQuantity.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnUpdateQuantity.Location = New System.Drawing.Point(128, 128)
        Me.BtnUpdateQuantity.Name = "BtnUpdateQuantity"
        Me.BtnUpdateQuantity.Size = New System.Drawing.Size(115, 33)
        Me.BtnUpdateQuantity.TabIndex = 1
        Me.BtnUpdateQuantity.Text = "Update Quantity"
        Me.BtnUpdateQuantity.UseVisualStyleBackColor = True
        '
        'frmNew
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MintCream
        Me.ClientSize = New System.Drawing.Size(364, 267)
        Me.Controls.Add(Me.BtnUpdateQuantity)
        Me.Controls.Add(Me.btnNewProduct)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmNew"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "New"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnNewProduct As System.Windows.Forms.Button
    Friend WithEvents BtnUpdateQuantity As System.Windows.Forms.Button
End Class
