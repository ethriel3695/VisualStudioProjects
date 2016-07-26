<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Process_Payment
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
        Dim PaymentTypeLabel As System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtCardNumber = New System.Windows.Forms.TextBox()
        Me.txtExpirationDate = New System.Windows.Forms.TextBox()
        Me.txtCVV = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.txtCashReceived = New System.Windows.Forms.TextBox()
        Me.txtOrderAmount = New System.Windows.Forms.TextBox()
        Me.btnProcessPayment = New System.Windows.Forms.Button()
        Me.PaymentTypeComboBox = New System.Windows.Forms.ComboBox()
        PaymentTypeLabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'PaymentTypeLabel
        '
        PaymentTypeLabel.AutoSize = True
        PaymentTypeLabel.Location = New System.Drawing.Point(15, 56)
        PaymentTypeLabel.Name = "PaymentTypeLabel"
        PaymentTypeLabel.Size = New System.Drawing.Size(103, 17)
        PaymentTypeLabel.TabIndex = 16
        PaymentTypeLabel.Text = "Payment Type:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 92)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(97, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Card Payment"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(31, 127)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(92, 17)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Card Number"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(31, 164)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(104, 17)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Expiration Date"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(31, 196)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(35, 17)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "CVV"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(31, 348)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(87, 17)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Change Due"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(31, 314)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(139, 17)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "Total Cash Received"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(31, 277)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(97, 17)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Order Amount"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(12, 245)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(99, 17)
        Me.Label9.TabIndex = 6
        Me.Label9.Text = "Cash Payment"
        '
        'txtCardNumber
        '
        Me.txtCardNumber.Location = New System.Drawing.Point(129, 124)
        Me.txtCardNumber.Name = "txtCardNumber"
        Me.txtCardNumber.Size = New System.Drawing.Size(185, 22)
        Me.txtCardNumber.TabIndex = 10
        '
        'txtExpirationDate
        '
        Me.txtExpirationDate.Location = New System.Drawing.Point(213, 161)
        Me.txtExpirationDate.Name = "txtExpirationDate"
        Me.txtExpirationDate.Size = New System.Drawing.Size(100, 22)
        Me.txtExpirationDate.TabIndex = 11
        '
        'txtCVV
        '
        Me.txtCVV.Location = New System.Drawing.Point(214, 193)
        Me.txtCVV.Name = "txtCVV"
        Me.txtCVV.Size = New System.Drawing.Size(100, 22)
        Me.txtCVV.TabIndex = 12
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(185, 343)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(129, 22)
        Me.TextBox1.TabIndex = 15
        '
        'txtCashReceived
        '
        Me.txtCashReceived.Location = New System.Drawing.Point(184, 311)
        Me.txtCashReceived.Name = "txtCashReceived"
        Me.txtCashReceived.Size = New System.Drawing.Size(129, 22)
        Me.txtCashReceived.TabIndex = 14
        '
        'txtOrderAmount
        '
        Me.txtOrderAmount.Location = New System.Drawing.Point(185, 274)
        Me.txtOrderAmount.Name = "txtOrderAmount"
        Me.txtOrderAmount.Size = New System.Drawing.Size(129, 22)
        Me.txtOrderAmount.TabIndex = 13
        '
        'btnProcessPayment
        '
        Me.btnProcessPayment.Location = New System.Drawing.Point(184, 391)
        Me.btnProcessPayment.Name = "btnProcessPayment"
        Me.btnProcessPayment.Size = New System.Drawing.Size(129, 27)
        Me.btnProcessPayment.TabIndex = 16
        Me.btnProcessPayment.Text = "Process Payment"
        Me.btnProcessPayment.UseVisualStyleBackColor = True
        '
        'PaymentTypeComboBox
        '
        Me.PaymentTypeComboBox.FormattingEnabled = True
        Me.PaymentTypeComboBox.Location = New System.Drawing.Point(124, 53)
        Me.PaymentTypeComboBox.Name = "PaymentTypeComboBox"
        Me.PaymentTypeComboBox.Size = New System.Drawing.Size(190, 24)
        Me.PaymentTypeComboBox.TabIndex = 17
        '
        'Process_Payment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(413, 446)
        Me.Controls.Add(PaymentTypeLabel)
        Me.Controls.Add(Me.PaymentTypeComboBox)
        Me.Controls.Add(Me.btnProcessPayment)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.txtCashReceived)
        Me.Controls.Add(Me.txtOrderAmount)
        Me.Controls.Add(Me.txtCVV)
        Me.Controls.Add(Me.txtExpirationDate)
        Me.Controls.Add(Me.txtCardNumber)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Name = "Process_Payment"
        Me.Text = "Process Payment"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents txtCardNumber As TextBox
    Friend WithEvents txtExpirationDate As TextBox
    Friend WithEvents txtCVV As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents txtCashReceived As TextBox
    Friend WithEvents txtOrderAmount As TextBox
    Friend WithEvents btnProcessPayment As Button
    Friend WithEvents Database1DataSet As Database1DataSet
    Friend WithEvents PaymentsTableAdapter As Database1DataSetTableAdapters.PaymentsTableAdapter
    Friend WithEvents TableAdapterManager As Database1DataSetTableAdapters.TableAdapterManager
    Friend WithEvents PaymentTypeComboBox As ComboBox
End Class
