<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RTransact
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RTransact))
        Me._HomeInventory_accdbDataSet1 = New HomeInventory._HomeInventory_accdbDataSet1()
        Me.Transactions_DataBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Transactions_DataTableAdapter = New HomeInventory._HomeInventory_accdbDataSet1TableAdapters.Transactions_DataTableAdapter()
        Me.TableAdapterManager = New HomeInventory._HomeInventory_accdbDataSet1TableAdapters.TableAdapterManager()
        Me.Transactions_DataBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.Transactions_DataBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.Transactions_DataDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        CType(Me._HomeInventory_accdbDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Transactions_DataBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Transactions_DataBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Transactions_DataBindingNavigator.SuspendLayout()
        CType(Me.Transactions_DataDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        '_HomeInventory_accdbDataSet1
        '
        Me._HomeInventory_accdbDataSet1.DataSetName = "_HomeInventory_accdbDataSet1"
        Me._HomeInventory_accdbDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Clients_DataTableAdapter = Nothing
        Me.TableAdapterManager.Items_DataTableAdapter = Nothing
        Me.TableAdapterManager.Transactions_DataTableAdapter = Me.Transactions_DataTableAdapter
        Me.TableAdapterManager.UpdateOrder = HomeInventory._HomeInventory_accdbDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Transactions_DataBindingNavigator
        '
        Me.Transactions_DataBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.Transactions_DataBindingNavigator.BindingSource = Me.Transactions_DataBindingSource
        Me.Transactions_DataBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.Transactions_DataBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.Transactions_DataBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.Transactions_DataBindingNavigatorSaveItem})
        Me.Transactions_DataBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.Transactions_DataBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.Transactions_DataBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.Transactions_DataBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.Transactions_DataBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.Transactions_DataBindingNavigator.Name = "Transactions_DataBindingNavigator"
        Me.Transactions_DataBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.Transactions_DataBindingNavigator.Size = New System.Drawing.Size(800, 25)
        Me.Transactions_DataBindingNavigator.TabIndex = 0
        Me.Transactions_DataBindingNavigator.Text = "BindingNavigator1"
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
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 15)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 6)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 6)
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
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'Transactions_DataBindingNavigatorSaveItem
        '
        Me.Transactions_DataBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Transactions_DataBindingNavigatorSaveItem.Image = CType(resources.GetObject("Transactions_DataBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.Transactions_DataBindingNavigatorSaveItem.Name = "Transactions_DataBindingNavigatorSaveItem"
        Me.Transactions_DataBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 23)
        Me.Transactions_DataBindingNavigatorSaveItem.Text = "Save Data"
        '
        'Transactions_DataDataGridView
        '
        Me.Transactions_DataDataGridView.AutoGenerateColumns = False
        Me.Transactions_DataDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Transactions_DataDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7})
        Me.Transactions_DataDataGridView.DataSource = Me.Transactions_DataBindingSource
        Me.Transactions_DataDataGridView.Location = New System.Drawing.Point(12, 49)
        Me.Transactions_DataDataGridView.Name = "Transactions_DataDataGridView"
        Me.Transactions_DataDataGridView.Size = New System.Drawing.Size(741, 220)
        Me.Transactions_DataDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "TransactionID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "TransactionID"
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
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "TransactionProtocol"
        Me.DataGridViewTextBoxColumn4.HeaderText = "TransactionProtocol"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "TransactionAmount"
        Me.DataGridViewTextBoxColumn5.HeaderText = "TransactionAmount"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Purpose"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Purpose"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "TransactionDate"
        Me.DataGridViewTextBoxColumn7.HeaderText = "TransactionDate"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(278, 291)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(102, 66)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Print"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(442, 291)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(102, 66)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "Back"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'RTransact
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Transactions_DataDataGridView)
        Me.Controls.Add(Me.Transactions_DataBindingNavigator)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "RTransact"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "RTransact"
        CType(Me._HomeInventory_accdbDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Transactions_DataBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Transactions_DataBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Transactions_DataBindingNavigator.ResumeLayout(False)
        Me.Transactions_DataBindingNavigator.PerformLayout()
        CType(Me.Transactions_DataDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents _HomeInventory_accdbDataSet1 As _HomeInventory_accdbDataSet1
    Friend WithEvents Transactions_DataBindingSource As BindingSource
    Friend WithEvents Transactions_DataTableAdapter As _HomeInventory_accdbDataSet1TableAdapters.Transactions_DataTableAdapter
    Friend WithEvents TableAdapterManager As _HomeInventory_accdbDataSet1TableAdapters.TableAdapterManager
    Friend WithEvents Transactions_DataBindingNavigator As BindingNavigator
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
    Friend WithEvents Transactions_DataBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents Transactions_DataDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
End Class
