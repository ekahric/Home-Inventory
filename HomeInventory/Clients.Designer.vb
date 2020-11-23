<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmClients
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
        Dim ClientIDLabel As System.Windows.Forms.Label
        Dim ClientNameLabel As System.Windows.Forms.Label
        Dim ClientLastNameLabel As System.Windows.Forms.Label
        Dim AddressLabel As System.Windows.Forms.Label
        Dim PhoneNumberLabel As System.Windows.Forms.Label
        Dim CityLabel As System.Windows.Forms.Label
        Dim CountryLabel As System.Windows.Forms.Label
        Dim EmailLabel As System.Windows.Forms.Label
        Dim DateLabel As System.Windows.Forms.Label
        Dim NotesLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmClients))
        Me._HomeInventory_accdbDataSet1 = New HomeInventory._HomeInventory_accdbDataSet1()
        Me.Clients_DataBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Clients_DataTableAdapter = New HomeInventory._HomeInventory_accdbDataSet1TableAdapters.Clients_DataTableAdapter()
        Me.TableAdapterManager = New HomeInventory._HomeInventory_accdbDataSet1TableAdapters.TableAdapterManager()
        Me.Clients_DataBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.Clients_DataBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.ClientIDTextBox = New System.Windows.Forms.TextBox()
        Me.ClientNameTextBox = New System.Windows.Forms.TextBox()
        Me.ClientLastNameTextBox = New System.Windows.Forms.TextBox()
        Me.AddressTextBox = New System.Windows.Forms.TextBox()
        Me.PhoneNumberTextBox = New System.Windows.Forms.TextBox()
        Me.CityTextBox = New System.Windows.Forms.TextBox()
        Me.CountryTextBox = New System.Windows.Forms.TextBox()
        Me.EmailTextBox = New System.Windows.Forms.TextBox()
        Me.DateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.NotesTextBox = New System.Windows.Forms.TextBox()
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
        Me.gbxCommands = New System.Windows.Forms.GroupBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.AddClientButton = New System.Windows.Forms.Button()
        Me.SaveClientButton = New System.Windows.Forms.Button()
        Me.DeleteClientButton = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        ClientIDLabel = New System.Windows.Forms.Label()
        ClientNameLabel = New System.Windows.Forms.Label()
        ClientLastNameLabel = New System.Windows.Forms.Label()
        AddressLabel = New System.Windows.Forms.Label()
        PhoneNumberLabel = New System.Windows.Forms.Label()
        CityLabel = New System.Windows.Forms.Label()
        CountryLabel = New System.Windows.Forms.Label()
        EmailLabel = New System.Windows.Forms.Label()
        DateLabel = New System.Windows.Forms.Label()
        NotesLabel = New System.Windows.Forms.Label()
        CType(Me._HomeInventory_accdbDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Clients_DataBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Clients_DataBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Clients_DataBindingNavigator.SuspendLayout()
        CType(Me.Clients_DataDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbxCommands.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ClientIDLabel
        '
        ClientIDLabel.AutoSize = True
        ClientIDLabel.Location = New System.Drawing.Point(6, 20)
        ClientIDLabel.Name = "ClientIDLabel"
        ClientIDLabel.Size = New System.Drawing.Size(50, 13)
        ClientIDLabel.TabIndex = 1
        ClientIDLabel.Text = "Client ID:"
        '
        'ClientNameLabel
        '
        ClientNameLabel.AutoSize = True
        ClientNameLabel.Location = New System.Drawing.Point(6, 46)
        ClientNameLabel.Name = "ClientNameLabel"
        ClientNameLabel.Size = New System.Drawing.Size(67, 13)
        ClientNameLabel.TabIndex = 3
        ClientNameLabel.Text = "Client Name:"
        '
        'ClientLastNameLabel
        '
        ClientLastNameLabel.AutoSize = True
        ClientLastNameLabel.Location = New System.Drawing.Point(6, 72)
        ClientLastNameLabel.Name = "ClientLastNameLabel"
        ClientLastNameLabel.Size = New System.Drawing.Size(90, 13)
        ClientLastNameLabel.TabIndex = 5
        ClientLastNameLabel.Text = "Client Last Name:"
        '
        'AddressLabel
        '
        AddressLabel.AutoSize = True
        AddressLabel.Location = New System.Drawing.Point(6, 98)
        AddressLabel.Name = "AddressLabel"
        AddressLabel.Size = New System.Drawing.Size(48, 13)
        AddressLabel.TabIndex = 7
        AddressLabel.Text = "Address:"
        '
        'PhoneNumberLabel
        '
        PhoneNumberLabel.AutoSize = True
        PhoneNumberLabel.Location = New System.Drawing.Point(6, 124)
        PhoneNumberLabel.Name = "PhoneNumberLabel"
        PhoneNumberLabel.Size = New System.Drawing.Size(81, 13)
        PhoneNumberLabel.TabIndex = 9
        PhoneNumberLabel.Text = "Phone Number:"
        '
        'CityLabel
        '
        CityLabel.AutoSize = True
        CityLabel.Location = New System.Drawing.Point(245, 16)
        CityLabel.Name = "CityLabel"
        CityLabel.Size = New System.Drawing.Size(27, 13)
        CityLabel.TabIndex = 11
        CityLabel.Text = "City:"
        '
        'CountryLabel
        '
        CountryLabel.AutoSize = True
        CountryLabel.Location = New System.Drawing.Point(245, 42)
        CountryLabel.Name = "CountryLabel"
        CountryLabel.Size = New System.Drawing.Size(46, 13)
        CountryLabel.TabIndex = 13
        CountryLabel.Text = "Country:"
        '
        'EmailLabel
        '
        EmailLabel.AutoSize = True
        EmailLabel.Location = New System.Drawing.Point(245, 68)
        EmailLabel.Name = "EmailLabel"
        EmailLabel.Size = New System.Drawing.Size(35, 13)
        EmailLabel.TabIndex = 15
        EmailLabel.Text = "Email:"
        '
        'DateLabel
        '
        DateLabel.AutoSize = True
        DateLabel.Location = New System.Drawing.Point(245, 95)
        DateLabel.Name = "DateLabel"
        DateLabel.Size = New System.Drawing.Size(33, 13)
        DateLabel.TabIndex = 17
        DateLabel.Text = "Date:"
        '
        'NotesLabel
        '
        NotesLabel.AutoSize = True
        NotesLabel.Location = New System.Drawing.Point(245, 120)
        NotesLabel.Name = "NotesLabel"
        NotesLabel.Size = New System.Drawing.Size(38, 13)
        NotesLabel.TabIndex = 19
        NotesLabel.Text = "Notes:"
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
        Me.TableAdapterManager.Items_DataTableAdapter = Nothing
        Me.TableAdapterManager.Transactions_DataTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = HomeInventory._HomeInventory_accdbDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Clients_DataBindingNavigator
        '
        Me.Clients_DataBindingNavigator.AddNewItem = Nothing
        Me.Clients_DataBindingNavigator.BindingSource = Me.Clients_DataBindingSource
        Me.Clients_DataBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.Clients_DataBindingNavigator.DeleteItem = Nothing
        Me.Clients_DataBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.Clients_DataBindingNavigatorSaveItem})
        Me.Clients_DataBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.Clients_DataBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.Clients_DataBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.Clients_DataBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.Clients_DataBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.Clients_DataBindingNavigator.Name = "Clients_DataBindingNavigator"
        Me.Clients_DataBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.Clients_DataBindingNavigator.Size = New System.Drawing.Size(854, 25)
        Me.Clients_DataBindingNavigator.TabIndex = 0
        Me.Clients_DataBindingNavigator.Text = "BindingNavigator1"
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
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
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
        'Clients_DataBindingNavigatorSaveItem
        '
        Me.Clients_DataBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Clients_DataBindingNavigatorSaveItem.Image = CType(resources.GetObject("Clients_DataBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.Clients_DataBindingNavigatorSaveItem.Name = "Clients_DataBindingNavigatorSaveItem"
        Me.Clients_DataBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.Clients_DataBindingNavigatorSaveItem.Text = "Save Data"
        '
        'ClientIDTextBox
        '
        Me.ClientIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Clients_DataBindingSource, "ClientID", True))
        Me.ClientIDTextBox.Location = New System.Drawing.Point(102, 17)
        Me.ClientIDTextBox.Name = "ClientIDTextBox"
        Me.ClientIDTextBox.Size = New System.Drawing.Size(124, 20)
        Me.ClientIDTextBox.TabIndex = 2
        '
        'ClientNameTextBox
        '
        Me.ClientNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Clients_DataBindingSource, "ClientName", True))
        Me.ClientNameTextBox.Location = New System.Drawing.Point(102, 43)
        Me.ClientNameTextBox.Name = "ClientNameTextBox"
        Me.ClientNameTextBox.Size = New System.Drawing.Size(124, 20)
        Me.ClientNameTextBox.TabIndex = 4
        '
        'ClientLastNameTextBox
        '
        Me.ClientLastNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Clients_DataBindingSource, "ClientLastName", True))
        Me.ClientLastNameTextBox.Location = New System.Drawing.Point(102, 69)
        Me.ClientLastNameTextBox.Name = "ClientLastNameTextBox"
        Me.ClientLastNameTextBox.Size = New System.Drawing.Size(124, 20)
        Me.ClientLastNameTextBox.TabIndex = 6
        '
        'AddressTextBox
        '
        Me.AddressTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Clients_DataBindingSource, "Address", True))
        Me.AddressTextBox.Location = New System.Drawing.Point(102, 95)
        Me.AddressTextBox.Name = "AddressTextBox"
        Me.AddressTextBox.Size = New System.Drawing.Size(124, 20)
        Me.AddressTextBox.TabIndex = 8
        '
        'PhoneNumberTextBox
        '
        Me.PhoneNumberTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Clients_DataBindingSource, "PhoneNumber", True))
        Me.PhoneNumberTextBox.Location = New System.Drawing.Point(102, 121)
        Me.PhoneNumberTextBox.Name = "PhoneNumberTextBox"
        Me.PhoneNumberTextBox.Size = New System.Drawing.Size(124, 20)
        Me.PhoneNumberTextBox.TabIndex = 10
        '
        'CityTextBox
        '
        Me.CityTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Clients_DataBindingSource, "City", True))
        Me.CityTextBox.Location = New System.Drawing.Point(341, 13)
        Me.CityTextBox.Name = "CityTextBox"
        Me.CityTextBox.Size = New System.Drawing.Size(114, 20)
        Me.CityTextBox.TabIndex = 12
        '
        'CountryTextBox
        '
        Me.CountryTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Clients_DataBindingSource, "Country", True))
        Me.CountryTextBox.Location = New System.Drawing.Point(341, 39)
        Me.CountryTextBox.Name = "CountryTextBox"
        Me.CountryTextBox.Size = New System.Drawing.Size(114, 20)
        Me.CountryTextBox.TabIndex = 14
        '
        'EmailTextBox
        '
        Me.EmailTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Clients_DataBindingSource, "Email", True))
        Me.EmailTextBox.Location = New System.Drawing.Point(341, 65)
        Me.EmailTextBox.Name = "EmailTextBox"
        Me.EmailTextBox.Size = New System.Drawing.Size(114, 20)
        Me.EmailTextBox.TabIndex = 16
        '
        'DateDateTimePicker
        '
        Me.DateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.Clients_DataBindingSource, "Date", True))
        Me.DateDateTimePicker.Location = New System.Drawing.Point(341, 91)
        Me.DateDateTimePicker.Name = "DateDateTimePicker"
        Me.DateDateTimePicker.Size = New System.Drawing.Size(114, 20)
        Me.DateDateTimePicker.TabIndex = 18
        '
        'NotesTextBox
        '
        Me.NotesTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Clients_DataBindingSource, "Notes", True))
        Me.NotesTextBox.Location = New System.Drawing.Point(341, 117)
        Me.NotesTextBox.Name = "NotesTextBox"
        Me.NotesTextBox.Size = New System.Drawing.Size(114, 20)
        Me.NotesTextBox.TabIndex = 20
        '
        'Clients_DataDataGridView
        '
        Me.Clients_DataDataGridView.AllowUserToAddRows = False
        Me.Clients_DataDataGridView.AllowUserToDeleteRows = False
        Me.Clients_DataDataGridView.AutoGenerateColumns = False
        Me.Clients_DataDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Clients_DataDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10})
        Me.Clients_DataDataGridView.DataSource = Me.Clients_DataBindingSource
        Me.Clients_DataDataGridView.Location = New System.Drawing.Point(15, 213)
        Me.Clients_DataDataGridView.Name = "Clients_DataDataGridView"
        Me.Clients_DataDataGridView.ReadOnly = True
        Me.Clients_DataDataGridView.Size = New System.Drawing.Size(827, 287)
        Me.Clients_DataDataGridView.TabIndex = 21
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "ClientID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "ClientID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "ClientName"
        Me.DataGridViewTextBoxColumn2.HeaderText = "ClientName"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "ClientLastName"
        Me.DataGridViewTextBoxColumn3.HeaderText = "ClientLastName"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Address"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Address"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "PhoneNumber"
        Me.DataGridViewTextBoxColumn5.HeaderText = "PhoneNumber"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "City"
        Me.DataGridViewTextBoxColumn6.HeaderText = "City"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Country"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Country"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "Email"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Email"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "Date"
        Me.DataGridViewTextBoxColumn9.HeaderText = "Date"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "Notes"
        Me.DataGridViewTextBoxColumn10.HeaderText = "Notes"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        '
        'gbxCommands
        '
        Me.gbxCommands.Controls.Add(Me.btnExit)
        Me.gbxCommands.Controls.Add(Me.DeleteClientButton)
        Me.gbxCommands.Controls.Add(Me.SaveClientButton)
        Me.gbxCommands.Controls.Add(Me.AddClientButton)
        Me.gbxCommands.Location = New System.Drawing.Point(568, 50)
        Me.gbxCommands.Name = "gbxCommands"
        Me.gbxCommands.Size = New System.Drawing.Size(208, 133)
        Me.gbxCommands.TabIndex = 22
        Me.gbxCommands.TabStop = False
        Me.gbxCommands.Text = "Commands"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(ClientNameLabel)
        Me.GroupBox1.Controls.Add(Me.NotesTextBox)
        Me.GroupBox1.Controls.Add(ClientIDLabel)
        Me.GroupBox1.Controls.Add(NotesLabel)
        Me.GroupBox1.Controls.Add(Me.ClientIDTextBox)
        Me.GroupBox1.Controls.Add(Me.DateDateTimePicker)
        Me.GroupBox1.Controls.Add(DateLabel)
        Me.GroupBox1.Controls.Add(Me.ClientNameTextBox)
        Me.GroupBox1.Controls.Add(Me.EmailTextBox)
        Me.GroupBox1.Controls.Add(ClientLastNameLabel)
        Me.GroupBox1.Controls.Add(EmailLabel)
        Me.GroupBox1.Controls.Add(Me.ClientLastNameTextBox)
        Me.GroupBox1.Controls.Add(Me.CountryTextBox)
        Me.GroupBox1.Controls.Add(AddressLabel)
        Me.GroupBox1.Controls.Add(CountryLabel)
        Me.GroupBox1.Controls.Add(Me.AddressTextBox)
        Me.GroupBox1.Controls.Add(Me.CityTextBox)
        Me.GroupBox1.Controls.Add(PhoneNumberLabel)
        Me.GroupBox1.Controls.Add(CityLabel)
        Me.GroupBox1.Controls.Add(Me.PhoneNumberTextBox)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 39)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(482, 144)
        Me.GroupBox1.TabIndex = 23
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Client Information"
        '
        'AddClientButton
        '
        Me.AddClientButton.Location = New System.Drawing.Point(16, 21)
        Me.AddClientButton.Name = "AddClientButton"
        Me.AddClientButton.Size = New System.Drawing.Size(75, 49)
        Me.AddClientButton.TabIndex = 0
        Me.AddClientButton.Text = "Add Client"
        Me.AddClientButton.UseVisualStyleBackColor = True
        '
        'SaveClientButton
        '
        Me.SaveClientButton.Location = New System.Drawing.Point(118, 21)
        Me.SaveClientButton.Name = "SaveClientButton"
        Me.SaveClientButton.Size = New System.Drawing.Size(75, 49)
        Me.SaveClientButton.TabIndex = 1
        Me.SaveClientButton.Text = "Save"
        Me.SaveClientButton.UseVisualStyleBackColor = True
        '
        'DeleteClientButton
        '
        Me.DeleteClientButton.Location = New System.Drawing.Point(16, 80)
        Me.DeleteClientButton.Name = "DeleteClientButton"
        Me.DeleteClientButton.Size = New System.Drawing.Size(75, 40)
        Me.DeleteClientButton.TabIndex = 2
        Me.DeleteClientButton.Text = "Delete"
        Me.DeleteClientButton.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(118, 80)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 40)
        Me.btnExit.TabIndex = 3
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'frmClients
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(854, 512)
        Me.Controls.Add(Me.gbxCommands)
        Me.Controls.Add(Me.Clients_DataDataGridView)
        Me.Controls.Add(Me.Clients_DataBindingNavigator)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmClients"
        Me.Text = "Clients"
        CType(Me._HomeInventory_accdbDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Clients_DataBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Clients_DataBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Clients_DataBindingNavigator.ResumeLayout(False)
        Me.Clients_DataBindingNavigator.PerformLayout()
        CType(Me.Clients_DataDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbxCommands.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents _HomeInventory_accdbDataSet1 As _HomeInventory_accdbDataSet1
    Friend WithEvents Clients_DataBindingSource As BindingSource
    Friend WithEvents Clients_DataTableAdapter As _HomeInventory_accdbDataSet1TableAdapters.Clients_DataTableAdapter
    Friend WithEvents TableAdapterManager As _HomeInventory_accdbDataSet1TableAdapters.TableAdapterManager
    Friend WithEvents Clients_DataBindingNavigator As BindingNavigator
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
    Friend WithEvents Clients_DataBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents ClientIDTextBox As TextBox
    Friend WithEvents ClientNameTextBox As TextBox
    Friend WithEvents ClientLastNameTextBox As TextBox
    Friend WithEvents AddressTextBox As TextBox
    Friend WithEvents PhoneNumberTextBox As TextBox
    Friend WithEvents CityTextBox As TextBox
    Friend WithEvents CountryTextBox As TextBox
    Friend WithEvents EmailTextBox As TextBox
    Friend WithEvents DateDateTimePicker As DateTimePicker
    Friend WithEvents NotesTextBox As TextBox
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
    Friend WithEvents gbxCommands As GroupBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnExit As Button
    Friend WithEvents DeleteClientButton As Button
    Friend WithEvents SaveClientButton As Button
    Friend WithEvents AddClientButton As Button
End Class
