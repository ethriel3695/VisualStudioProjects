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
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtNext = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtRegisterAnAccount = New System.Windows.Forms.Button()
        Me.btnCancelOrder = New System.Windows.Forms.Button()
        Me.Database1DataSet = New LearningTeam_D_KudlerCustomerProgram.Database1DataSet()
        Me.CustomerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CustomerTableAdapter = New LearningTeam_D_KudlerCustomerProgram.Database1DataSetTableAdapters.CustomerTableAdapter()
        Me.TableAdapterManager = New LearningTeam_D_KudlerCustomerProgram.Database1DataSetTableAdapters.TableAdapterManager()
        Me.PhoneNumberTextBox = New System.Windows.Forms.TextBox()
        CType(Me.Database1DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'txtNext
        '
        Me.txtNext.Location = New System.Drawing.Point(251, 170)
        Me.txtNext.Name = "txtNext"
        Me.txtNext.Size = New System.Drawing.Size(97, 28)
        Me.txtNext.TabIndex = 2
        Me.txtNext.Text = "Finish"
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
        Me.txtRegisterAnAccount.TabIndex = 3
        Me.txtRegisterAnAccount.Text = "Register"
        Me.txtRegisterAnAccount.UseVisualStyleBackColor = True
        '
        'btnCancelOrder
        '
        Me.btnCancelOrder.Location = New System.Drawing.Point(109, 170)
        Me.btnCancelOrder.Name = "btnCancelOrder"
        Me.btnCancelOrder.Size = New System.Drawing.Size(107, 28)
        Me.btnCancelOrder.TabIndex = 1
        Me.btnCancelOrder.Text = "Close"
        Me.btnCancelOrder.UseVisualStyleBackColor = True
        '
        'Database1DataSet
        '
        Me.Database1DataSet.DataSetName = "Database1DataSet"
        Me.Database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CustomerBindingSource
        '
        Me.CustomerBindingSource.DataMember = "Customer"
        Me.CustomerBindingSource.DataSource = Me.Database1DataSet
        '
        'CustomerTableAdapter
        '
        Me.CustomerTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CustomerTableAdapter = Me.CustomerTableAdapter
        Me.TableAdapterManager.ItemsTableAdapter = Nothing
        Me.TableAdapterManager.OrderItemsTableAdapter = Nothing
        Me.TableAdapterManager.OrdersTableAdapter = Nothing
        Me.TableAdapterManager.PaymentsTableAdapter = Nothing
        Me.TableAdapterManager.RewardsTableAdapter = Nothing
        Me.TableAdapterManager.StoreLocationTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = LearningTeam_D_KudlerCustomerProgram.Database1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'PhoneNumberTextBox
        '
        Me.PhoneNumberTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerBindingSource, "PhoneNumber", True))
        Me.PhoneNumberTextBox.Location = New System.Drawing.Point(109, 131)
        Me.PhoneNumberTextBox.Name = "PhoneNumberTextBox"
        Me.PhoneNumberTextBox.Size = New System.Drawing.Size(239, 22)
        Me.PhoneNumberTextBox.TabIndex = 0
        '
        'Checkout_Process_Customer_Authentication
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(461, 313)
        Me.Controls.Add(Me.PhoneNumberTextBox)
        Me.Controls.Add(Me.btnCancelOrder)
        Me.Controls.Add(Me.txtRegisterAnAccount)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtNext)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Checkout_Process_Customer_Authentication"
        Me.Text = "Checkout Customer Authentication"
        CType(Me.Database1DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtNext As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtRegisterAnAccount As Button
    Friend WithEvents btnCancelOrder As Button
    Friend WithEvents Database1DataSet As Database1DataSet
    Friend WithEvents CustomerBindingSource As BindingSource
    Friend WithEvents CustomerTableAdapter As Database1DataSetTableAdapters.CustomerTableAdapter
    Friend WithEvents TableAdapterManager As Database1DataSetTableAdapters.TableAdapterManager
    Friend WithEvents PhoneNumberTextBox As TextBox
End Class
