<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Order_Submission
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
        Me.txtQuantity = New System.Windows.Forms.TextBox()
        Me.txtProductID = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtTotalOrderCost = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnAddItem = New System.Windows.Forms.Button()
        Me.txtSubmitOrder = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtQuantity
        '
        Me.txtQuantity.Location = New System.Drawing.Point(132, 103)
        Me.txtQuantity.Name = "txtQuantity"
        Me.txtQuantity.Size = New System.Drawing.Size(197, 22)
        Me.txtQuantity.TabIndex = 16
        '
        'txtProductID
        '
        Me.txtProductID.Location = New System.Drawing.Point(132, 58)
        Me.txtProductID.Name = "txtProductID"
        Me.txtProductID.Size = New System.Drawing.Size(197, 22)
        Me.txtProductID.TabIndex = 14
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 106)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 17)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Quantity"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 61)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 17)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Product ID"
        '
        'txtTotalOrderCost
        '
        Me.txtTotalOrderCost.Location = New System.Drawing.Point(132, 225)
        Me.txtTotalOrderCost.Name = "txtTotalOrderCost"
        Me.txtTotalOrderCost.Size = New System.Drawing.Size(197, 22)
        Me.txtTotalOrderCost.TabIndex = 18
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(16, 228)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(113, 17)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "Total Order Cost"
        '
        'btnAddItem
        '
        Me.btnAddItem.Location = New System.Drawing.Point(228, 23)
        Me.btnAddItem.Name = "btnAddItem"
        Me.btnAddItem.Size = New System.Drawing.Size(100, 29)
        Me.btnAddItem.TabIndex = 19
        Me.btnAddItem.Text = "+ Add Item"
        Me.btnAddItem.UseVisualStyleBackColor = True
        '
        'txtSubmitOrder
        '
        Me.txtSubmitOrder.Location = New System.Drawing.Point(229, 261)
        Me.txtSubmitOrder.Name = "txtSubmitOrder"
        Me.txtSubmitOrder.Size = New System.Drawing.Size(100, 29)
        Me.txtSubmitOrder.TabIndex = 20
        Me.txtSubmitOrder.Text = "Submit Order"
        Me.txtSubmitOrder.UseVisualStyleBackColor = True
        '
        'Order_Submission
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(349, 302)
        Me.Controls.Add(Me.txtSubmitOrder)
        Me.Controls.Add(Me.btnAddItem)
        Me.Controls.Add(Me.txtTotalOrderCost)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtQuantity)
        Me.Controls.Add(Me.txtProductID)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Order_Submission"
        Me.Text = "Order Submission"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtQuantity As TextBox
    Friend WithEvents txtProductID As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtTotalOrderCost As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents btnAddItem As Button
    Friend WithEvents txtSubmitOrder As Button
End Class
