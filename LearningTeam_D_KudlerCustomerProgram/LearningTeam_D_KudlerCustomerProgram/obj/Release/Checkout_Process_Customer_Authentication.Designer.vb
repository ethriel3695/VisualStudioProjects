<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Checkout_Process_Customer_Authentication
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtCustomerPhoneNumber = New System.Windows.Forms.TextBox()
        Me.txtNext = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtRegisterAnAccount = New System.Windows.Forms.Button()
        Me.btnCancelOrder = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(105, 92)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(243, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Enter Customer Phone Number"
        '
        'txtCustomerPhoneNumber
        '
        Me.txtCustomerPhoneNumber.Location = New System.Drawing.Point(109, 129)
        Me.txtCustomerPhoneNumber.Name = "txtCustomerPhoneNumber"
        Me.txtCustomerPhoneNumber.Size = New System.Drawing.Size(239, 22)
        Me.txtCustomerPhoneNumber.TabIndex = 1
        '
        'txtNext
        '
        Me.txtNext.Location = New System.Drawing.Point(251, 170)
        Me.txtNext.Name = "txtNext"
        Me.txtNext.Size = New System.Drawing.Size(97, 28)
        Me.txtNext.TabIndex = 2
        Me.txtNext.Text = "Next"
        Me.txtNext.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(105, 215)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(150, 20)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Create An Account"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 54)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(390, 20)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Enter Customer Identification or Create an Account"
        '
        'txtRegisterAnAccount
        '
        Me.txtRegisterAnAccount.Location = New System.Drawing.Point(251, 250)
        Me.txtRegisterAnAccount.Name = "txtRegisterAnAccount"
        Me.txtRegisterAnAccount.Size = New System.Drawing.Size(97, 27)
        Me.txtRegisterAnAccount.TabIndex = 5
        Me.txtRegisterAnAccount.Text = "Register"
        Me.txtRegisterAnAccount.UseVisualStyleBackColor = True
        '
        'btnCancelOrder
        '
        Me.btnCancelOrder.Location = New System.Drawing.Point(109, 170)
        Me.btnCancelOrder.Name = "btnCancelOrder"
        Me.btnCancelOrder.Size = New System.Drawing.Size(107, 28)
        Me.btnCancelOrder.TabIndex = 6
        Me.btnCancelOrder.Text = "Cancel Order"
        Me.btnCancelOrder.UseVisualStyleBackColor = True
        '
        'Checkout_Process_Customer_Authentication
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(424, 313)
        Me.Controls.Add(Me.btnCancelOrder)
        Me.Controls.Add(Me.txtRegisterAnAccount)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtNext)
        Me.Controls.Add(Me.txtCustomerPhoneNumber)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Checkout_Process_Customer_Authentication"
        Me.Text = "Checkout Customer Authentication"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtCustomerPhoneNumber As TextBox
    Friend WithEvents txtNext As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtRegisterAnAccount As Button
    Friend WithEvents btnCancelOrder As Button
End Class
