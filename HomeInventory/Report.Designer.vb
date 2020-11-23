<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReport
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.gbxritems = New System.Windows.Forms.GroupBox()
        Me._HomeInventory_accdbDataSet1 = New HomeInventory._HomeInventory_accdbDataSet1()
        Me.Clients_DataBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Clients_DataTableAdapter = New HomeInventory._HomeInventory_accdbDataSet1TableAdapters.Clients_DataTableAdapter()
        Me.TableAdapterManager = New HomeInventory._HomeInventory_accdbDataSet1TableAdapters.TableAdapterManager()
        Me.Clients_DataDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.gbxClientsR = New System.Windows.Forms.GroupBox()
        Me.Items_DataBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Items_DataTableAdapter = New HomeInventory._HomeInventory_accdbDataSet1TableAdapters.Items_DataTableAdapter()
        Me.Items_DataDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn16 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Transactions_DataBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Transactions_DataTableAdapter = New HomeInventory._HomeInventory_accdbDataSet1TableAdapters.Transactions_DataTableAdapter()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.gbxritems.SuspendLayout()
        CType(Me._HomeInventory_accdbDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Clients_DataBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Clients_DataDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbxClientsR.SuspendLayout()
        CType(Me.Items_DataBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Items_DataDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Transactions_DataBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Button6)
        Me.Panel1.Controls.Add(Me.Button5)
        Me.Panel1.Controls.Add(Me.Button4)
        Me.Panel1.Controls.Add(Me.Button3)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(576, 220)
        Me.Panel1.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.SteelBlue
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Azure
        Me.Button1.Location = New System.Drawing.Point(0, 0)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(229, 112)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Report Items"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.SteelBlue
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.Azure
        Me.Button2.Location = New System.Drawing.Point(225, 0)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(190, 112)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Report Transactions"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.SteelBlue
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.Azure
        Me.Button3.Location = New System.Drawing.Point(0, 110)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(229, 110)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "Report Clients"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.SteelBlue
        Me.Button4.FlatAppearance.BorderSize = 0
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.Color.Azure
        Me.Button4.Location = New System.Drawing.Point(225, 110)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(190, 110)
        Me.Button4.TabIndex = 3
        Me.Button4.Text = "Report Clients and Transactions"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.SteelBlue
        Me.Button5.FlatAppearance.BorderSize = 0
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.ForeColor = System.Drawing.Color.Azure
        Me.Button5.Location = New System.Drawing.Point(411, 0)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(165, 112)
        Me.Button5.TabIndex = 4
        Me.Button5.Text = "Main Menu"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.SteelBlue
        Me.Button6.FlatAppearance.BorderSize = 0
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button6.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.ForeColor = System.Drawing.Color.Azure
        Me.Button6.Location = New System.Drawing.Point(411, 110)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(165, 110)
        Me.Button6.TabIndex = 5
        Me.Button6.Text = "Exit"
        Me.Button6.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Panel2.Controls.Add(Me.gbxClientsR)
        Me.Panel2.Controls.Add(Me.gbxritems)
        Me.Panel2.Location = New System.Drawing.Point(-2, 227)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(576, 360)
        Me.Panel2.TabIndex = 1
        '
        'gbxritems
        '
        Me.gbxritems.Controls.Add(Me.Clients_DataDataGridView)
        Me.gbxritems.Location = New System.Drawing.Point(3, 12)
        Me.gbxritems.Name = "gbxritems"
        Me.gbxritems.Size = New System.Drawing.Size(550, 339)
        Me.gbxritems.TabIndex = 0
        Me.gbxritems.TabStop = False
        Me.gbxritems.Text = "Items"
        Me.gbxritems.Visible = False
        '
        '_HomeInventory_accdbDataSet1
        '
        Me._HomeInventory_accdbDataSet1.DataSetName = "_HomeInventory_accdbDataSet1"
        Me._HomeInventory_accdbDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Clients_DataBindingSource
        '
        Me.Clients_DataBindingSource.DataMember = "Clients_Data"
        Me.Clients_DataBindingSource.DataSource = Me._HomeInventory_accdbDataSet1
        '
        'Clients_DataTableAdapter
        '
        Me.Clients_DataTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Clients_DataTableAdapter = Me.Clients_DataTableAdapter
        Me.TableAdapterManager.Items_DataTableAdapter = Me.Items_DataTableAdapter
        Me.TableAdapterManager.Transactions_DataTableAdapter = Me.Transactions_DataTableAdapter
        Me.TableAdapterManager.UpdateOrder = HomeInventory._HomeInventory_accdbDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Clients_DataDataGridView
        '
        Me.Clients_DataDataGridView.AllowUserToAddRows = False
        Me.Clients_DataDataGridView.AllowUserToDeleteRows = False
        Me.Clients_DataDataGridView.AutoGenerateColumns = False
        Me.Clients_DataDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Clients_DataDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10})
        Me.Clients_DataDataGridView.DataSource = Me.Clients_DataBindingSource
        Me.Clients_DataDataGridView.Location = New System.Drawing.Point(6, 19)
        Me.Clients_DataDataGridView.Name = "Clients_DataDataGridView"
        Me.Clients_DataDataGridView.ReadOnly = True
        Me.Clients_DataDataGridView.Size = New System.Drawing.Size(538, 309)
        Me.Clients_DataDataGridView.TabIndex = 0
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "ClientID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "ClientID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "ClientName"
        Me.DataGridViewTextBoxColumn2.HeaderText = "ClientName"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "ClientLastName"
        Me.DataGridViewTextBoxColumn3.HeaderText = "ClientLastName"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Address"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Address"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "PhoneNumber"
        Me.DataGridViewTextBoxColumn5.HeaderText = "PhoneNumber"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "City"
        Me.DataGridViewTextBoxColumn6.HeaderText = "City"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Country"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Country"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "Email"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Email"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "Date"
        Me.DataGridViewTextBoxColumn9.HeaderText = "Date"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "Notes"
        Me.DataGridViewTextBoxColumn10.HeaderText = "Notes"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.ReadOnly = True
        '
        'gbxClientsR
        '
        Me.gbxClientsR.Controls.Add(Me.Items_DataDataGridView)
        Me.gbxClientsR.Location = New System.Drawing.Point(3, 3)
        Me.gbxClientsR.Name = "gbxClientsR"
        Me.gbxClientsR.Size = New System.Drawing.Size(570, 354)
        Me.gbxClientsR.TabIndex = 1
        Me.gbxClientsR.TabStop = False
        Me.gbxClientsR.Text = "Clients"
        Me.gbxClientsR.Visible = False
        '
        'Items_DataBindingSource
        '
        Me.Items_DataBindingSource.DataMember = "Items_Data"
        Me.Items_DataBindingSource.DataSource = Me._HomeInventory_accdbDataSet1
        '
        'Items_DataTableAdapter
        '
        Me.Items_DataTableAdapter.ClearBeforeFill = True
        '
        'Items_DataDataGridView
        '
        Me.Items_DataDataGridView.AutoGenerateColumns = False
        Me.Items_DataDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Items_DataDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn13, Me.DataGridViewTextBoxColumn14, Me.DataGridViewTextBoxColumn15, Me.DataGridViewTextBoxColumn16})
        Me.Items_DataDataGridView.DataSource = Me.Items_DataBindingSource
        Me.Items_DataDataGridView.Location = New System.Drawing.Point(9, 19)
        Me.Items_DataDataGridView.Name = "Items_DataDataGridView"
        Me.Items_DataDataGridView.Size = New System.Drawing.Size(552, 323)
        Me.Items_DataDataGridView.TabIndex = 0
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "ItemID"
        Me.DataGridViewTextBoxColumn11.HeaderText = "ItemID"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "NameItem"
        Me.DataGridViewTextBoxColumn12.HeaderText = "NameItem"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "ItemPrice"
        Me.DataGridViewTextBoxColumn13.HeaderText = "ItemPrice"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "ItemStock"
        Me.DataGridViewTextBoxColumn14.HeaderText = "ItemStock"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.DataPropertyName = "DateImport"
        Me.DataGridViewTextBoxColumn15.HeaderText = "DateImport"
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        '
        'DataGridViewTextBoxColumn16
        '
        Me.DataGridViewTextBoxColumn16.DataPropertyName = "Description"
        Me.DataGridViewTextBoxColumn16.HeaderText = "Description"
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        '
        'Transactions_DataBindingSource
        '
        Me.Transactions_DataBindingSource.DataMember = "Transactions_Data"
        Me.Transactions_DataBindingSource.DataSource = Me._HomeInventory_accdbDataSet1
        '
        'Transactions_DataTableAdapter
        '
        Me.Transactions_DataTableAdapter.ClearBeforeFill = True
        '
        'frmReport
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(574, 587)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.Name = "frmReport"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Report"
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.gbxritems.ResumeLayout(False)
        CType(Me._HomeInventory_accdbDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Clients_DataBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Clients_DataDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbxClientsR.ResumeLayout(False)
        CType(Me.Items_DataBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Items_DataDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Transactions_DataBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button6 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents gbxritems As GroupBox
    Friend WithEvents _HomeInventory_accdbDataSet1 As _HomeInventory_accdbDataSet1
    Friend WithEvents Clients_DataBindingSource As BindingSource
    Friend WithEvents Clients_DataTableAdapter As _HomeInventory_accdbDataSet1TableAdapters.Clients_DataTableAdapter
    Friend WithEvents TableAdapterManager As _HomeInventory_accdbDataSet1TableAdapters.TableAdapterManager
    Friend WithEvents Clients_DataDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
    Friend WithEvents gbxClientsR As GroupBox
    Friend WithEvents Items_DataTableAdapter As _HomeInventory_accdbDataSet1TableAdapters.Items_DataTableAdapter
    Friend WithEvents Items_DataBindingSource As BindingSource
    Friend WithEvents Items_DataDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn11 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn15 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn16 As DataGridViewTextBoxColumn
    Friend WithEvents Transactions_DataTableAdapter As _HomeInventory_accdbDataSet1TableAdapters.Transactions_DataTableAdapter
    Friend WithEvents Transactions_DataBindingSource As BindingSource
End Class
