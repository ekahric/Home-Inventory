<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Dim ItemIDLabel As System.Windows.Forms.Label
        Dim NameItemLabel As System.Windows.Forms.Label
        Dim ItemPriceLabel As System.Windows.Forms.Label
        Dim ItemStockLabel As System.Windows.Forms.Label
        Dim DateImportLabel As System.Windows.Forms.Label
        Dim DescriptionLabel As System.Windows.Forms.Label
        Dim TransactionIDLabel As System.Windows.Forms.Label
        Dim ClientNameLabel As System.Windows.Forms.Label
        Dim ClientLastNameLabel As System.Windows.Forms.Label
        Dim TransactionProtocolLabel As System.Windows.Forms.Label
        Dim TransactionAmountLabel As System.Windows.Forms.Label
        Dim PurposeLabel As System.Windows.Forms.Label
        Dim TransactionDateLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.lbluser = New System.Windows.Forms.Label()
        Me.lbltime = New System.Windows.Forms.Label()
        Me.lbldate = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.btnClients = New System.Windows.Forms.Button()
        Me.btnReport = New System.Windows.Forms.Button()
        Me.btnItems = New System.Windows.Forms.Button()
        Me.btnTransactions = New System.Windows.Forms.Button()
        Me.gbxItems = New System.Windows.Forms.GroupBox()
        Me.btnFind = New System.Windows.Forms.Button()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnNew = New System.Windows.Forms.Button()
        Me.Items_DataDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Items_DataBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me._HomeInventory_accdbDataSet = New HomeInventory._HomeInventory_accdbDataSet()
        Me.Items_DataBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.Items_DataBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.ItemIDTextBox = New System.Windows.Forms.TextBox()
        Me.NameItemTextBox = New System.Windows.Forms.TextBox()
        Me.ItemPriceTextBox = New System.Windows.Forms.TextBox()
        Me.ItemStockTextBox = New System.Windows.Forms.TextBox()
        Me.DateImportDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.DescriptionTextBox = New System.Windows.Forms.TextBox()
        Me.Items_DataTableAdapter = New HomeInventory._HomeInventory_accdbDataSetTableAdapters.Items_DataTableAdapter()
        Me.TableAdapterManager = New HomeInventory._HomeInventory_accdbDataSetTableAdapters.TableAdapterManager()
        Me.gbxTransactions = New System.Windows.Forms.GroupBox()
        Me.BindingNavigator1 = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.Transactions_DataBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me._HomeInventory_accdbDataSet1 = New HomeInventory._HomeInventory_accdbDataSet1()
        Me.BindingNavigatorCountItem1 = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorMoveFirstItem1 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem1 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem1 = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem1 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem1 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorAddNewItem1 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton3 = New System.Windows.Forms.ToolStripButton()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.btnExport = New System.Windows.Forms.Button()
        Me.PrintT = New System.Windows.Forms.Button()
        Me.SaveT = New System.Windows.Forms.Button()
        Me.DeleteT = New System.Windows.Forms.Button()
        Me.Transactions_DataDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TransactionIDTextBox = New System.Windows.Forms.TextBox()
        Me.ClientNameTextBox = New System.Windows.Forms.TextBox()
        Me.ClientLastNameTextBox = New System.Windows.Forms.TextBox()
        Me.TransactionProtocolTextBox = New System.Windows.Forms.TextBox()
        Me.TransactionAmountTextBox = New System.Windows.Forms.TextBox()
        Me.PurposeTextBox = New System.Windows.Forms.TextBox()
        Me.TransactionDateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.btnAddT = New System.Windows.Forms.Button()
        Me.Transactions_DataTableAdapter = New HomeInventory._HomeInventory_accdbDataSet1TableAdapters.Transactions_DataTableAdapter()
        Me.TableAdapterManager1 = New HomeInventory._HomeInventory_accdbDataSet1TableAdapters.TableAdapterManager()
        Me.Transactions_DataTableAdapter1 = New HomeInventory._HomeInventory_accdbDataSet1TableAdapters.Transactions_DataTableAdapter()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        ItemIDLabel = New System.Windows.Forms.Label()
        NameItemLabel = New System.Windows.Forms.Label()
        ItemPriceLabel = New System.Windows.Forms.Label()
        ItemStockLabel = New System.Windows.Forms.Label()
        DateImportLabel = New System.Windows.Forms.Label()
        DescriptionLabel = New System.Windows.Forms.Label()
        TransactionIDLabel = New System.Windows.Forms.Label()
        ClientNameLabel = New System.Windows.Forms.Label()
        ClientLastNameLabel = New System.Windows.Forms.Label()
        TransactionProtocolLabel = New System.Windows.Forms.Label()
        TransactionAmountLabel = New System.Windows.Forms.Label()
        PurposeLabel = New System.Windows.Forms.Label()
        TransactionDateLabel = New System.Windows.Forms.Label()
        Me.gbxItems.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        CType(Me.Items_DataDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Items_DataBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._HomeInventory_accdbDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Items_DataBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Items_DataBindingNavigator.SuspendLayout()
        Me.gbxTransactions.SuspendLayout()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BindingNavigator1.SuspendLayout()
        CType(Me.Transactions_DataBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._HomeInventory_accdbDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Transactions_DataDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'ItemIDLabel
        '
        ItemIDLabel.AutoSize = True
        ItemIDLabel.Location = New System.Drawing.Point(10, 77)
        ItemIDLabel.Name = "ItemIDLabel"
        ItemIDLabel.Size = New System.Drawing.Size(44, 13)
        ItemIDLabel.TabIndex = 0
        ItemIDLabel.Text = "Item ID:"
        '
        'NameItemLabel
        '
        NameItemLabel.AutoSize = True
        NameItemLabel.Location = New System.Drawing.Point(10, 103)
        NameItemLabel.Name = "NameItemLabel"
        NameItemLabel.Size = New System.Drawing.Size(61, 13)
        NameItemLabel.TabIndex = 2
        NameItemLabel.Text = "Name Item:"
        '
        'ItemPriceLabel
        '
        ItemPriceLabel.AutoSize = True
        ItemPriceLabel.Location = New System.Drawing.Point(10, 129)
        ItemPriceLabel.Name = "ItemPriceLabel"
        ItemPriceLabel.Size = New System.Drawing.Size(57, 13)
        ItemPriceLabel.TabIndex = 4
        ItemPriceLabel.Text = "Item Price:"
        '
        'ItemStockLabel
        '
        ItemStockLabel.AutoSize = True
        ItemStockLabel.Location = New System.Drawing.Point(287, 76)
        ItemStockLabel.Name = "ItemStockLabel"
        ItemStockLabel.Size = New System.Drawing.Size(61, 13)
        ItemStockLabel.TabIndex = 6
        ItemStockLabel.Text = "Item Stock:"
        '
        'DateImportLabel
        '
        DateImportLabel.AutoSize = True
        DateImportLabel.Location = New System.Drawing.Point(287, 103)
        DateImportLabel.Name = "DateImportLabel"
        DateImportLabel.Size = New System.Drawing.Size(65, 13)
        DateImportLabel.TabIndex = 8
        DateImportLabel.Text = "Date Import:"
        '
        'DescriptionLabel
        '
        DescriptionLabel.AutoSize = True
        DescriptionLabel.Location = New System.Drawing.Point(287, 128)
        DescriptionLabel.Name = "DescriptionLabel"
        DescriptionLabel.Size = New System.Drawing.Size(63, 13)
        DescriptionLabel.TabIndex = 10
        DescriptionLabel.Text = "Description:"
        '
        'TransactionIDLabel
        '
        TransactionIDLabel.AutoSize = True
        TransactionIDLabel.Location = New System.Drawing.Point(9, 364)
        TransactionIDLabel.Name = "TransactionIDLabel"
        TransactionIDLabel.Size = New System.Drawing.Size(80, 13)
        TransactionIDLabel.TabIndex = 1
        TransactionIDLabel.Text = "Transaction ID:"
        '
        'ClientNameLabel
        '
        ClientNameLabel.AutoSize = True
        ClientNameLabel.Location = New System.Drawing.Point(9, 390)
        ClientNameLabel.Name = "ClientNameLabel"
        ClientNameLabel.Size = New System.Drawing.Size(67, 13)
        ClientNameLabel.TabIndex = 3
        ClientNameLabel.Text = "Client Name:"
        '
        'ClientLastNameLabel
        '
        ClientLastNameLabel.AutoSize = True
        ClientLastNameLabel.Location = New System.Drawing.Point(9, 416)
        ClientLastNameLabel.Name = "ClientLastNameLabel"
        ClientLastNameLabel.Size = New System.Drawing.Size(90, 13)
        ClientLastNameLabel.TabIndex = 5
        ClientLastNameLabel.Text = "Client Last Name:"
        '
        'TransactionProtocolLabel
        '
        TransactionProtocolLabel.AutoSize = True
        TransactionProtocolLabel.Location = New System.Drawing.Point(9, 442)
        TransactionProtocolLabel.Name = "TransactionProtocolLabel"
        TransactionProtocolLabel.Size = New System.Drawing.Size(108, 13)
        TransactionProtocolLabel.TabIndex = 7
        TransactionProtocolLabel.Text = "Transaction Protocol:"
        '
        'TransactionAmountLabel
        '
        TransactionAmountLabel.AutoSize = True
        TransactionAmountLabel.Location = New System.Drawing.Point(344, 364)
        TransactionAmountLabel.Name = "TransactionAmountLabel"
        TransactionAmountLabel.Size = New System.Drawing.Size(105, 13)
        TransactionAmountLabel.TabIndex = 9
        TransactionAmountLabel.Text = "Transaction Amount:"
        '
        'PurposeLabel
        '
        PurposeLabel.AutoSize = True
        PurposeLabel.Location = New System.Drawing.Point(344, 390)
        PurposeLabel.Name = "PurposeLabel"
        PurposeLabel.Size = New System.Drawing.Size(49, 13)
        PurposeLabel.TabIndex = 11
        PurposeLabel.Text = "Purpose:"
        '
        'TransactionDateLabel
        '
        TransactionDateLabel.AutoSize = True
        TransactionDateLabel.Location = New System.Drawing.Point(344, 417)
        TransactionDateLabel.Name = "TransactionDateLabel"
        TransactionDateLabel.Size = New System.Drawing.Size(92, 13)
        TransactionDateLabel.TabIndex = 13
        TransactionDateLabel.Text = "Transaction Date:"
        '
        'lbluser
        '
        Me.lbluser.AutoSize = True
        Me.lbluser.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbluser.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.lbluser.Location = New System.Drawing.Point(81, 25)
        Me.lbluser.Name = "lbluser"
        Me.lbluser.Size = New System.Drawing.Size(53, 22)
        Me.lbluser.TabIndex = 12
        Me.lbluser.Text = "Date:"
        '
        'lbltime
        '
        Me.lbltime.AutoSize = True
        Me.lbltime.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltime.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.lbltime.Location = New System.Drawing.Point(81, 60)
        Me.lbltime.Name = "lbltime"
        Me.lbltime.Size = New System.Drawing.Size(53, 22)
        Me.lbltime.TabIndex = 11
        Me.lbltime.Text = "Date:"
        '
        'lbldate
        '
        Me.lbldate.AutoSize = True
        Me.lbldate.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldate.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.lbldate.Location = New System.Drawing.Point(83, 102)
        Me.lbldate.Name = "lbldate"
        Me.lbldate.Size = New System.Drawing.Size(53, 22)
        Me.lbldate.TabIndex = 10
        Me.lbldate.Text = "Date:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label4.Location = New System.Drawing.Point(14, 102)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 22)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Date:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label3.Location = New System.Drawing.Point(12, 60)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 22)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Time:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label2.Location = New System.Drawing.Point(12, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 22)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "User:"
        '
        'btnLogout
        '
        Me.btnLogout.BackColor = System.Drawing.Color.SteelBlue
        Me.btnLogout.FlatAppearance.BorderSize = 0
        Me.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogout.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogout.ForeColor = System.Drawing.Color.Azure
        Me.btnLogout.Location = New System.Drawing.Point(0, 406)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(234, 51)
        Me.btnLogout.TabIndex = 11
        Me.btnLogout.Text = "Log Out"
        Me.btnLogout.UseVisualStyleBackColor = False
        '
        'btnClients
        '
        Me.btnClients.BackColor = System.Drawing.Color.SteelBlue
        Me.btnClients.FlatAppearance.BorderSize = 0
        Me.btnClients.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClients.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClients.ForeColor = System.Drawing.Color.Azure
        Me.btnClients.Location = New System.Drawing.Point(-2, 253)
        Me.btnClients.Name = "btnClients"
        Me.btnClients.Size = New System.Drawing.Size(236, 51)
        Me.btnClients.TabIndex = 8
        Me.btnClients.Text = "Clients"
        Me.btnClients.UseVisualStyleBackColor = False
        '
        'btnReport
        '
        Me.btnReport.BackColor = System.Drawing.Color.SteelBlue
        Me.btnReport.FlatAppearance.BorderSize = 0
        Me.btnReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReport.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReport.ForeColor = System.Drawing.Color.Azure
        Me.btnReport.Location = New System.Drawing.Point(-2, 355)
        Me.btnReport.Name = "btnReport"
        Me.btnReport.Size = New System.Drawing.Size(236, 51)
        Me.btnReport.TabIndex = 10
        Me.btnReport.Text = "Report"
        Me.btnReport.UseVisualStyleBackColor = False
        '
        'btnItems
        '
        Me.btnItems.BackColor = System.Drawing.Color.SteelBlue
        Me.btnItems.FlatAppearance.BorderSize = 0
        Me.btnItems.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnItems.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnItems.ForeColor = System.Drawing.Color.Azure
        Me.btnItems.Location = New System.Drawing.Point(0, 202)
        Me.btnItems.Name = "btnItems"
        Me.btnItems.Size = New System.Drawing.Size(234, 51)
        Me.btnItems.TabIndex = 7
        Me.btnItems.Text = "Items"
        Me.btnItems.UseVisualStyleBackColor = False
        '
        'btnTransactions
        '
        Me.btnTransactions.BackColor = System.Drawing.Color.SteelBlue
        Me.btnTransactions.FlatAppearance.BorderSize = 0
        Me.btnTransactions.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTransactions.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTransactions.ForeColor = System.Drawing.Color.Azure
        Me.btnTransactions.Location = New System.Drawing.Point(0, 304)
        Me.btnTransactions.Name = "btnTransactions"
        Me.btnTransactions.Size = New System.Drawing.Size(234, 51)
        Me.btnTransactions.TabIndex = 9
        Me.btnTransactions.Text = "Transactions"
        Me.btnTransactions.UseVisualStyleBackColor = False
        '
        'gbxItems
        '
        Me.gbxItems.Controls.Add(Me.btnFind)
        Me.gbxItems.Controls.Add(Me.StatusStrip1)
        Me.gbxItems.Controls.Add(Me.btnDelete)
        Me.gbxItems.Controls.Add(Me.btnSave)
        Me.gbxItems.Controls.Add(Me.btnNew)
        Me.gbxItems.Controls.Add(Me.Items_DataDataGridView)
        Me.gbxItems.Controls.Add(Me.Items_DataBindingNavigator)
        Me.gbxItems.Controls.Add(ItemIDLabel)
        Me.gbxItems.Controls.Add(Me.ItemIDTextBox)
        Me.gbxItems.Controls.Add(NameItemLabel)
        Me.gbxItems.Controls.Add(Me.NameItemTextBox)
        Me.gbxItems.Controls.Add(ItemPriceLabel)
        Me.gbxItems.Controls.Add(Me.ItemPriceTextBox)
        Me.gbxItems.Controls.Add(ItemStockLabel)
        Me.gbxItems.Controls.Add(Me.ItemStockTextBox)
        Me.gbxItems.Controls.Add(DateImportLabel)
        Me.gbxItems.Controls.Add(Me.DateImportDateTimePicker)
        Me.gbxItems.Controls.Add(DescriptionLabel)
        Me.gbxItems.Controls.Add(Me.DescriptionTextBox)
        Me.gbxItems.Location = New System.Drawing.Point(280, 23)
        Me.gbxItems.Name = "gbxItems"
        Me.gbxItems.Size = New System.Drawing.Size(620, 541)
        Me.gbxItems.TabIndex = 12
        Me.gbxItems.TabStop = False
        Me.gbxItems.Text = "Items"
        '
        'btnFind
        '
        Me.btnFind.Location = New System.Drawing.Point(354, 164)
        Me.btnFind.Name = "btnFind"
        Me.btnFind.Size = New System.Drawing.Size(81, 45)
        Me.btnFind.TabIndex = 18
        Me.btnFind.Text = "Find"
        Me.btnFind.UseVisualStyleBackColor = True
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1})
        Me.StatusStrip1.Location = New System.Drawing.Point(3, 516)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(614, 22)
        Me.StatusStrip1.TabIndex = 17
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(39, 17)
        Me.ToolStripStatusLabel1.Text = "Status"
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(441, 164)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(81, 45)
        Me.btnDelete.TabIndex = 16
        Me.btnDelete.Text = "Delete Item"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(267, 164)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(81, 45)
        Me.btnSave.TabIndex = 15
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnNew
        '
        Me.btnNew.Location = New System.Drawing.Point(94, 164)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(81, 45)
        Me.btnNew.TabIndex = 14
        Me.btnNew.Text = "New Item"
        Me.btnNew.UseVisualStyleBackColor = True
        '
        'Items_DataDataGridView
        '
        Me.Items_DataDataGridView.AllowUserToAddRows = False
        Me.Items_DataDataGridView.AllowUserToDeleteRows = False
        Me.Items_DataDataGridView.AutoGenerateColumns = False
        Me.Items_DataDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Items_DataDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6})
        Me.Items_DataDataGridView.DataSource = Me.Items_DataBindingSource
        Me.Items_DataDataGridView.Location = New System.Drawing.Point(6, 240)
        Me.Items_DataDataGridView.Name = "Items_DataDataGridView"
        Me.Items_DataDataGridView.ReadOnly = True
        Me.Items_DataDataGridView.Size = New System.Drawing.Size(608, 220)
        Me.Items_DataDataGridView.TabIndex = 13
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "ItemID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "ItemID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "NameItem"
        Me.DataGridViewTextBoxColumn2.HeaderText = "NameItem"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "ItemPrice"
        Me.DataGridViewTextBoxColumn3.HeaderText = "ItemPrice"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "ItemStock"
        Me.DataGridViewTextBoxColumn4.HeaderText = "ItemStock"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "DateImport"
        Me.DataGridViewTextBoxColumn5.HeaderText = "DateImport"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Description"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Description"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        '
        'Items_DataBindingSource
        '
        Me.Items_DataBindingSource.DataMember = "Items_Data"
        Me.Items_DataBindingSource.DataSource = Me._HomeInventory_accdbDataSet
        '
        '_HomeInventory_accdbDataSet
        '
        Me._HomeInventory_accdbDataSet.DataSetName = "_HomeInventory_accdbDataSet"
        Me._HomeInventory_accdbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Items_DataBindingNavigator
        '
        Me.Items_DataBindingNavigator.AddNewItem = Nothing
        Me.Items_DataBindingNavigator.BindingSource = Me.Items_DataBindingSource
        Me.Items_DataBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.Items_DataBindingNavigator.DeleteItem = Nothing
        Me.Items_DataBindingNavigator.Dock = System.Windows.Forms.DockStyle.None
        Me.Items_DataBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.Items_DataBindingNavigatorSaveItem})
        Me.Items_DataBindingNavigator.Location = New System.Drawing.Point(3, 16)
        Me.Items_DataBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.Items_DataBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.Items_DataBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.Items_DataBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.Items_DataBindingNavigator.Name = "Items_DataBindingNavigator"
        Me.Items_DataBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.Items_DataBindingNavigator.Size = New System.Drawing.Size(278, 25)
        Me.Items_DataBindingNavigator.TabIndex = 13
        Me.Items_DataBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'Items_DataBindingNavigatorSaveItem
        '
        Me.Items_DataBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Items_DataBindingNavigatorSaveItem.Image = CType(resources.GetObject("Items_DataBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.Items_DataBindingNavigatorSaveItem.Name = "Items_DataBindingNavigatorSaveItem"
        Me.Items_DataBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.Items_DataBindingNavigatorSaveItem.Text = "Save Data"
        '
        'ItemIDTextBox
        '
        Me.ItemIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Items_DataBindingSource, "ItemID", True))
        Me.ItemIDTextBox.Location = New System.Drawing.Point(81, 74)
        Me.ItemIDTextBox.Name = "ItemIDTextBox"
        Me.ItemIDTextBox.Size = New System.Drawing.Size(200, 20)
        Me.ItemIDTextBox.TabIndex = 1
        '
        'NameItemTextBox
        '
        Me.NameItemTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Items_DataBindingSource, "NameItem", True))
        Me.NameItemTextBox.Location = New System.Drawing.Point(81, 100)
        Me.NameItemTextBox.Name = "NameItemTextBox"
        Me.NameItemTextBox.Size = New System.Drawing.Size(200, 20)
        Me.NameItemTextBox.TabIndex = 3
        '
        'ItemPriceTextBox
        '
        Me.ItemPriceTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Items_DataBindingSource, "ItemPrice", True))
        Me.ItemPriceTextBox.Location = New System.Drawing.Point(81, 126)
        Me.ItemPriceTextBox.Name = "ItemPriceTextBox"
        Me.ItemPriceTextBox.Size = New System.Drawing.Size(200, 20)
        Me.ItemPriceTextBox.TabIndex = 5
        '
        'ItemStockTextBox
        '
        Me.ItemStockTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Items_DataBindingSource, "ItemStock", True))
        Me.ItemStockTextBox.Location = New System.Drawing.Point(358, 73)
        Me.ItemStockTextBox.Name = "ItemStockTextBox"
        Me.ItemStockTextBox.Size = New System.Drawing.Size(200, 20)
        Me.ItemStockTextBox.TabIndex = 7
        '
        'DateImportDateTimePicker
        '
        Me.DateImportDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.Items_DataBindingSource, "DateImport", True))
        Me.DateImportDateTimePicker.Location = New System.Drawing.Point(358, 99)
        Me.DateImportDateTimePicker.Name = "DateImportDateTimePicker"
        Me.DateImportDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.DateImportDateTimePicker.TabIndex = 9
        '
        'DescriptionTextBox
        '
        Me.DescriptionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Items_DataBindingSource, "Description", True))
        Me.DescriptionTextBox.Location = New System.Drawing.Point(358, 125)
        Me.DescriptionTextBox.Name = "DescriptionTextBox"
        Me.DescriptionTextBox.Size = New System.Drawing.Size(200, 20)
        Me.DescriptionTextBox.TabIndex = 11
        '
        'Items_DataTableAdapter
        '
        Me.Items_DataTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Items_DataTableAdapter = Me.Items_DataTableAdapter
        Me.TableAdapterManager.UpdateOrder = HomeInventory._HomeInventory_accdbDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'gbxTransactions
        '
        Me.gbxTransactions.Controls.Add(Me.BindingNavigator1)
        Me.gbxTransactions.Controls.Add(Me.Button6)
        Me.gbxTransactions.Controls.Add(Me.btnExport)
        Me.gbxTransactions.Controls.Add(Me.PrintT)
        Me.gbxTransactions.Controls.Add(Me.SaveT)
        Me.gbxTransactions.Controls.Add(Me.DeleteT)
        Me.gbxTransactions.Controls.Add(Me.Transactions_DataDataGridView)
        Me.gbxTransactions.Controls.Add(TransactionIDLabel)
        Me.gbxTransactions.Controls.Add(Me.TransactionIDTextBox)
        Me.gbxTransactions.Controls.Add(ClientNameLabel)
        Me.gbxTransactions.Controls.Add(Me.ClientNameTextBox)
        Me.gbxTransactions.Controls.Add(ClientLastNameLabel)
        Me.gbxTransactions.Controls.Add(Me.ClientLastNameTextBox)
        Me.gbxTransactions.Controls.Add(TransactionProtocolLabel)
        Me.gbxTransactions.Controls.Add(Me.TransactionProtocolTextBox)
        Me.gbxTransactions.Controls.Add(TransactionAmountLabel)
        Me.gbxTransactions.Controls.Add(Me.TransactionAmountTextBox)
        Me.gbxTransactions.Controls.Add(PurposeLabel)
        Me.gbxTransactions.Controls.Add(Me.PurposeTextBox)
        Me.gbxTransactions.Controls.Add(TransactionDateLabel)
        Me.gbxTransactions.Controls.Add(Me.TransactionDateDateTimePicker)
        Me.gbxTransactions.Controls.Add(Me.btnAddT)
        Me.gbxTransactions.Location = New System.Drawing.Point(234, 23)
        Me.gbxTransactions.Name = "gbxTransactions"
        Me.gbxTransactions.Size = New System.Drawing.Size(686, 569)
        Me.gbxTransactions.TabIndex = 13
        Me.gbxTransactions.TabStop = False
        Me.gbxTransactions.Text = "Transactions"
        '
        'BindingNavigator1
        '
        Me.BindingNavigator1.AddNewItem = Nothing
        Me.BindingNavigator1.AutoSize = False
        Me.BindingNavigator1.BindingSource = Me.Transactions_DataBindingSource
        Me.BindingNavigator1.CountItem = Me.BindingNavigatorCountItem1
        Me.BindingNavigator1.DeleteItem = Nothing
        Me.BindingNavigator1.Dock = System.Windows.Forms.DockStyle.None
        Me.BindingNavigator1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem1, Me.BindingNavigatorMovePreviousItem1, Me.BindingNavigatorSeparator3, Me.BindingNavigatorPositionItem1, Me.BindingNavigatorCountItem1, Me.BindingNavigatorSeparator4, Me.BindingNavigatorMoveNextItem1, Me.BindingNavigatorMoveLastItem1, Me.BindingNavigatorSeparator5, Me.BindingNavigatorAddNewItem1, Me.BindingNavigatorDeleteItem1, Me.ToolStripButton3})
        Me.BindingNavigator1.Location = New System.Drawing.Point(12, 16)
        Me.BindingNavigator1.MoveFirstItem = Me.BindingNavigatorMoveFirstItem1
        Me.BindingNavigator1.MoveLastItem = Me.BindingNavigatorMoveLastItem1
        Me.BindingNavigator1.MoveNextItem = Me.BindingNavigatorMoveNextItem1
        Me.BindingNavigator1.MovePreviousItem = Me.BindingNavigatorMovePreviousItem1
        Me.BindingNavigator1.Name = "BindingNavigator1"
        Me.BindingNavigator1.PositionItem = Me.BindingNavigatorPositionItem1
        Me.BindingNavigator1.Size = New System.Drawing.Size(311, 22)
        Me.BindingNavigator1.TabIndex = 21
        Me.BindingNavigator1.Text = "BindingNavigator1"
        '
        'Transactions_DataBindingSource
        '
        Me.Transactions_DataBindingSource.DataMember = "Transactions_Data"
        Me.Transactions_DataBindingSource.DataSource = Me._HomeInventory_accdbDataSet1
        '
        '_HomeInventory_accdbDataSet1
        '
        Me._HomeInventory_accdbDataSet1.DataSetName = "_HomeInventory_accdbDataSet1"
        Me._HomeInventory_accdbDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BindingNavigatorCountItem1
        '
        Me.BindingNavigatorCountItem1.Name = "BindingNavigatorCountItem1"
        Me.BindingNavigatorCountItem1.Size = New System.Drawing.Size(35, 19)
        Me.BindingNavigatorCountItem1.Text = "of {0}"
        Me.BindingNavigatorCountItem1.ToolTipText = "Total number of items"
        '
        'BindingNavigatorMoveFirstItem1
        '
        Me.BindingNavigatorMoveFirstItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem1.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem1.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem1.Name = "BindingNavigatorMoveFirstItem1"
        Me.BindingNavigatorMoveFirstItem1.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem1.Size = New System.Drawing.Size(23, 19)
        Me.BindingNavigatorMoveFirstItem1.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem1
        '
        Me.BindingNavigatorMovePreviousItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem1.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem1.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem1.Name = "BindingNavigatorMovePreviousItem1"
        Me.BindingNavigatorMovePreviousItem1.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem1.Size = New System.Drawing.Size(23, 19)
        Me.BindingNavigatorMovePreviousItem1.Text = "Move previous"
        '
        'BindingNavigatorSeparator3
        '
        Me.BindingNavigatorSeparator3.Name = "BindingNavigatorSeparator3"
        Me.BindingNavigatorSeparator3.Size = New System.Drawing.Size(6, 22)
        '
        'BindingNavigatorPositionItem1
        '
        Me.BindingNavigatorPositionItem1.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem1.AutoSize = False
        Me.BindingNavigatorPositionItem1.Name = "BindingNavigatorPositionItem1"
        Me.BindingNavigatorPositionItem1.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem1.Text = "0"
        Me.BindingNavigatorPositionItem1.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator4
        '
        Me.BindingNavigatorSeparator4.Name = "BindingNavigatorSeparator4"
        Me.BindingNavigatorSeparator4.Size = New System.Drawing.Size(6, 22)
        '
        'BindingNavigatorMoveNextItem1
        '
        Me.BindingNavigatorMoveNextItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem1.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem1.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem1.Name = "BindingNavigatorMoveNextItem1"
        Me.BindingNavigatorMoveNextItem1.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem1.Size = New System.Drawing.Size(23, 19)
        Me.BindingNavigatorMoveNextItem1.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem1
        '
        Me.BindingNavigatorMoveLastItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem1.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem1.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem1.Name = "BindingNavigatorMoveLastItem1"
        Me.BindingNavigatorMoveLastItem1.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem1.Size = New System.Drawing.Size(23, 19)
        Me.BindingNavigatorMoveLastItem1.Text = "Move last"
        '
        'BindingNavigatorSeparator5
        '
        Me.BindingNavigatorSeparator5.Name = "BindingNavigatorSeparator5"
        Me.BindingNavigatorSeparator5.Size = New System.Drawing.Size(6, 22)
        '
        'BindingNavigatorAddNewItem1
        '
        Me.BindingNavigatorAddNewItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem1.Image = CType(resources.GetObject("BindingNavigatorAddNewItem1.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem1.Name = "BindingNavigatorAddNewItem1"
        Me.BindingNavigatorAddNewItem1.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem1.Size = New System.Drawing.Size(23, 19)
        Me.BindingNavigatorAddNewItem1.Text = "Add new"
        '
        'BindingNavigatorDeleteItem1
        '
        Me.BindingNavigatorDeleteItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem1.Image = CType(resources.GetObject("BindingNavigatorDeleteItem1.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem1.Name = "BindingNavigatorDeleteItem1"
        Me.BindingNavigatorDeleteItem1.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem1.Size = New System.Drawing.Size(23, 19)
        Me.BindingNavigatorDeleteItem1.Text = "Delete"
        '
        'ToolStripButton3
        '
        Me.ToolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton3.Image = CType(resources.GetObject("ToolStripButton3.Image"), System.Drawing.Image)
        Me.ToolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton3.Name = "ToolStripButton3"
        Me.ToolStripButton3.Size = New System.Drawing.Size(23, 19)
        Me.ToolStripButton3.Text = "ToolStripButton3"
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(406, 480)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(75, 45)
        Me.Button6.TabIndex = 20
        Me.Button6.Text = "Close"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'btnExport
        '
        Me.btnExport.Location = New System.Drawing.Point(265, 480)
        Me.btnExport.Name = "btnExport"
        Me.btnExport.Size = New System.Drawing.Size(75, 45)
        Me.btnExport.TabIndex = 19
        Me.btnExport.Text = "Export"
        Me.btnExport.UseVisualStyleBackColor = True
        '
        'PrintT
        '
        Me.PrintT.Location = New System.Drawing.Point(541, 281)
        Me.PrintT.Name = "PrintT"
        Me.PrintT.Size = New System.Drawing.Size(75, 45)
        Me.PrintT.TabIndex = 18
        Me.PrintT.Text = "Print"
        Me.PrintT.UseVisualStyleBackColor = True
        '
        'SaveT
        '
        Me.SaveT.Location = New System.Drawing.Point(400, 281)
        Me.SaveT.Name = "SaveT"
        Me.SaveT.Size = New System.Drawing.Size(75, 45)
        Me.SaveT.TabIndex = 17
        Me.SaveT.Text = "Save"
        Me.SaveT.UseVisualStyleBackColor = True
        '
        'DeleteT
        '
        Me.DeleteT.Location = New System.Drawing.Point(252, 281)
        Me.DeleteT.Name = "DeleteT"
        Me.DeleteT.Size = New System.Drawing.Size(75, 45)
        Me.DeleteT.TabIndex = 16
        Me.DeleteT.Text = "Delete"
        Me.DeleteT.UseVisualStyleBackColor = True
        '
        'Transactions_DataDataGridView
        '
        Me.Transactions_DataDataGridView.AllowUserToAddRows = False
        Me.Transactions_DataDataGridView.AllowUserToDeleteRows = False
        Me.Transactions_DataDataGridView.AutoGenerateColumns = False
        Me.Transactions_DataDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Transactions_DataDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn13})
        Me.Transactions_DataDataGridView.DataSource = Me.Transactions_DataBindingSource
        Me.Transactions_DataDataGridView.Location = New System.Drawing.Point(6, 44)
        Me.Transactions_DataDataGridView.Name = "Transactions_DataDataGridView"
        Me.Transactions_DataDataGridView.ReadOnly = True
        Me.Transactions_DataDataGridView.Size = New System.Drawing.Size(660, 220)
        Me.Transactions_DataDataGridView.TabIndex = 15
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "TransactionID"
        Me.DataGridViewTextBoxColumn7.HeaderText = "TransactionID"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "ClientName"
        Me.DataGridViewTextBoxColumn8.HeaderText = "ClientName"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "ClientLastName"
        Me.DataGridViewTextBoxColumn9.HeaderText = "ClientLastName"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "TransactionProtocol"
        Me.DataGridViewTextBoxColumn10.HeaderText = "TransactionProtocol"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.ReadOnly = True
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "TransactionAmount"
        Me.DataGridViewTextBoxColumn11.HeaderText = "TransactionAmount"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.ReadOnly = True
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "Purpose"
        Me.DataGridViewTextBoxColumn12.HeaderText = "Purpose"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        Me.DataGridViewTextBoxColumn12.ReadOnly = True
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "TransactionDate"
        Me.DataGridViewTextBoxColumn13.HeaderText = "TransactionDate"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        Me.DataGridViewTextBoxColumn13.ReadOnly = True
        '
        'TransactionIDTextBox
        '
        Me.TransactionIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Transactions_DataBindingSource, "TransactionID", True))
        Me.TransactionIDTextBox.Location = New System.Drawing.Point(123, 361)
        Me.TransactionIDTextBox.Name = "TransactionIDTextBox"
        Me.TransactionIDTextBox.Size = New System.Drawing.Size(200, 20)
        Me.TransactionIDTextBox.TabIndex = 2
        '
        'ClientNameTextBox
        '
        Me.ClientNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Transactions_DataBindingSource, "ClientName", True))
        Me.ClientNameTextBox.Location = New System.Drawing.Point(123, 387)
        Me.ClientNameTextBox.Name = "ClientNameTextBox"
        Me.ClientNameTextBox.Size = New System.Drawing.Size(200, 20)
        Me.ClientNameTextBox.TabIndex = 4
        '
        'ClientLastNameTextBox
        '
        Me.ClientLastNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Transactions_DataBindingSource, "ClientLastName", True))
        Me.ClientLastNameTextBox.Location = New System.Drawing.Point(123, 413)
        Me.ClientLastNameTextBox.Name = "ClientLastNameTextBox"
        Me.ClientLastNameTextBox.Size = New System.Drawing.Size(200, 20)
        Me.ClientLastNameTextBox.TabIndex = 6
        '
        'TransactionProtocolTextBox
        '
        Me.TransactionProtocolTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Transactions_DataBindingSource, "TransactionProtocol", True))
        Me.TransactionProtocolTextBox.Location = New System.Drawing.Point(123, 439)
        Me.TransactionProtocolTextBox.Name = "TransactionProtocolTextBox"
        Me.TransactionProtocolTextBox.Size = New System.Drawing.Size(200, 20)
        Me.TransactionProtocolTextBox.TabIndex = 8
        '
        'TransactionAmountTextBox
        '
        Me.TransactionAmountTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Transactions_DataBindingSource, "TransactionAmount", True))
        Me.TransactionAmountTextBox.Location = New System.Drawing.Point(458, 361)
        Me.TransactionAmountTextBox.Name = "TransactionAmountTextBox"
        Me.TransactionAmountTextBox.Size = New System.Drawing.Size(200, 20)
        Me.TransactionAmountTextBox.TabIndex = 10
        '
        'PurposeTextBox
        '
        Me.PurposeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Transactions_DataBindingSource, "Purpose", True))
        Me.PurposeTextBox.Location = New System.Drawing.Point(458, 387)
        Me.PurposeTextBox.Name = "PurposeTextBox"
        Me.PurposeTextBox.Size = New System.Drawing.Size(200, 20)
        Me.PurposeTextBox.TabIndex = 12
        '
        'TransactionDateDateTimePicker
        '
        Me.TransactionDateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.Transactions_DataBindingSource, "TransactionDate", True))
        Me.TransactionDateDateTimePicker.Location = New System.Drawing.Point(458, 413)
        Me.TransactionDateDateTimePicker.Name = "TransactionDateDateTimePicker"
        Me.TransactionDateDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.TransactionDateDateTimePicker.TabIndex = 14
        '
        'btnAddT
        '
        Me.btnAddT.Location = New System.Drawing.Point(99, 281)
        Me.btnAddT.Name = "btnAddT"
        Me.btnAddT.Size = New System.Drawing.Size(75, 45)
        Me.btnAddT.TabIndex = 0
        Me.btnAddT.Text = "New Transaction"
        Me.btnAddT.UseVisualStyleBackColor = True
        '
        'Transactions_DataTableAdapter
        '
        Me.Transactions_DataTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager1
        '
        Me.TableAdapterManager1.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager1.Clients_DataTableAdapter = Nothing
        Me.TableAdapterManager1.Items_DataTableAdapter = Nothing
        Me.TableAdapterManager1.Transactions_DataTableAdapter = Me.Transactions_DataTableAdapter
        Me.TableAdapterManager1.UpdateOrder = HomeInventory._HomeInventory_accdbDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Transactions_DataTableAdapter1
        '
        Me.Transactions_DataTableAdapter1.ClearBeforeFill = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Panel1.BackgroundImage = Global.HomeInventory.My.Resources.Resources.Gradient_blue_1
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel1.Location = New System.Drawing.Point(-2, -2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(236, 594)
        Me.Panel1.TabIndex = 14
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Calibri", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label5.Location = New System.Drawing.Point(14, 154)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(198, 33)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Home Inventory"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Controls.Add(Me.lbldate)
        Me.Panel2.Controls.Add(Me.lbluser)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.lbltime)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.ForeColor = System.Drawing.Color.SkyBlue
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(233, 141)
        Me.Panel2.TabIndex = 13
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.Highlight
        Me.Panel3.Location = New System.Drawing.Point(-2, 139)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(241, 10)
        Me.Panel3.TabIndex = 14
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(920, 592)
        Me.Controls.Add(Me.btnItems)
        Me.Controls.Add(Me.gbxTransactions)
        Me.Controls.Add(Me.gbxItems)
        Me.Controls.Add(Me.btnLogout)
        Me.Controls.Add(Me.btnClients)
        Me.Controls.Add(Me.btnReport)
        Me.Controls.Add(Me.btnTransactions)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Main Panel"
        Me.gbxItems.ResumeLayout(False)
        Me.gbxItems.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        CType(Me.Items_DataDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Items_DataBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._HomeInventory_accdbDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Items_DataBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Items_DataBindingNavigator.ResumeLayout(False)
        Me.Items_DataBindingNavigator.PerformLayout()
        Me.gbxTransactions.ResumeLayout(False)
        Me.gbxTransactions.PerformLayout()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BindingNavigator1.ResumeLayout(False)
        Me.BindingNavigator1.PerformLayout()
        CType(Me.Transactions_DataBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._HomeInventory_accdbDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Transactions_DataDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lbluser As Label
    Friend WithEvents lbltime As Label
    Friend WithEvents lbldate As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnLogout As Button
    Friend WithEvents btnClients As Button
    Friend WithEvents btnReport As Button
    Friend WithEvents btnItems As Button
    Friend WithEvents btnTransactions As Button
    Friend WithEvents gbxItems As GroupBox
    Friend WithEvents _HomeInventory_accdbDataSet As _HomeInventory_accdbDataSet
    Friend WithEvents Items_DataBindingSource As BindingSource
    Friend WithEvents Items_DataTableAdapter As _HomeInventory_accdbDataSetTableAdapters.Items_DataTableAdapter
    Friend WithEvents TableAdapterManager As _HomeInventory_accdbDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Items_DataBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents Items_DataBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents btnNew As Button
    Friend WithEvents Items_DataDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents ItemIDTextBox As TextBox
    Friend WithEvents NameItemTextBox As TextBox
    Friend WithEvents ItemPriceTextBox As TextBox
    Friend WithEvents ItemStockTextBox As TextBox
    Friend WithEvents DateImportDateTimePicker As DateTimePicker
    Friend WithEvents DescriptionTextBox As TextBox
    Friend WithEvents btnFind As Button
    Friend WithEvents gbxTransactions As GroupBox
    Friend WithEvents btnAddT As Button
    Friend WithEvents _HomeInventory_accdbDataSet1 As _HomeInventory_accdbDataSet1
    Friend WithEvents Transactions_DataBindingSource As BindingSource
    Friend WithEvents Transactions_DataTableAdapter As _HomeInventory_accdbDataSet1TableAdapters.Transactions_DataTableAdapter
    Friend WithEvents TableAdapterManager1 As _HomeInventory_accdbDataSet1TableAdapters.TableAdapterManager
    Friend WithEvents Transactions_DataDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As DataGridViewTextBoxColumn
    Friend WithEvents TransactionIDTextBox As TextBox
    Friend WithEvents ClientNameTextBox As TextBox
    Friend WithEvents ClientLastNameTextBox As TextBox
    Friend WithEvents TransactionProtocolTextBox As TextBox
    Friend WithEvents TransactionAmountTextBox As TextBox
    Friend WithEvents PurposeTextBox As TextBox
    Friend WithEvents TransactionDateDateTimePicker As DateTimePicker
    Friend WithEvents Button6 As Button
    Friend WithEvents btnExport As Button
    Friend WithEvents PrintT As Button
    Friend WithEvents SaveT As Button
    Friend WithEvents DeleteT As Button
    Friend WithEvents Transactions_DataTableAdapter1 As _HomeInventory_accdbDataSet1TableAdapters.Transactions_DataTableAdapter
    Friend WithEvents BindingNavigator1 As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem1 As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem1 As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem1 As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem1 As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem1 As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator3 As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem1 As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator4 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem1 As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem1 As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator5 As ToolStripSeparator
    Friend WithEvents ToolStripButton3 As ToolStripButton
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label5 As Label
End Class
