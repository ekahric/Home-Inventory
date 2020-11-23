Public Class frmClients
    Private Sub Clients_DataBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles Clients_DataBindingNavigatorSaveItem.Click
        'Me.Validate()
        'Me.Clients_DataBindingSource.EndEdit()
        'Me.TableAdapterManager.UpdateAll(Me._HomeInventory_accdbDataSet1)
        SaveClientButton.PerformClick()
    End Sub

    Private Sub Clients_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the '_HomeInventory_accdbDataSet1.Clients_Data' table. You can move, or remove it, as needed.
        Me.Clients_DataTableAdapter.Fill(Me._HomeInventory_accdbDataSet1.Clients_Data)
        frmMain.Hide()
    End Sub

    Private Sub BindingNavigatorAddNewItem_Click(sender As Object, e As EventArgs) Handles BindingNavigatorAddNewItem.Click
        AddClientButton.PerformClick()

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Hide()
        frmMain.Show()
    End Sub

    Private Sub BindingNavigatorDeleteItem_Click(sender As Object, e As EventArgs) Handles BindingNavigatorDeleteItem.Click
        DeleteClientButton.PerformClick()
    End Sub

    Private Sub AddClientButton_Click(sender As Object, e As EventArgs) Handles AddClientButton.Click
        'add new client
        ' MsgBox("You pressed Add NeW Client Button")

        Try
            With AddClientButton
                If .Text = "Add New Client" Then
                    Clients_DataBindingSource.AddNew()
                    .Text = "Cancel"
                Else
                    RefreshData()
                    .Text = "Add New Client"
                End If
            End With

            With ClientNameTextBox
                If (.CanSelect) Then
                    .Text = String.Empty
                    .Select()
                End If
            End With
        Catch ex As Exception
            MsgBox("An error Ocurred: " & ex.Message.ToString(), MsgBoxStyle.OkOnly Or MsgBoxStyle.Information, "Add new client failed!")
        End Try
    End Sub

    Private Sub RefreshData()
        Try
            Me.Clients_DataBindingSource.Filter = Nothing
            Me.Clients_DataTableAdapter.Fill(Me._HomeInventory_accdbDataSet1.Clients_Data)


        Catch ex As Exception
            MsgBox("Refres Data Error!")
        End Try
    End Sub

    Private Sub SaveClientButton_Click(sender As Object, e As EventArgs) Handles SaveClientButton.Click
        'MsgBox("You pressed Save NeW Client Button")

        Try
            Dim result As DialogResult
            result = MessageBox.Show("Do you want to save the selected Client?", "Saved", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If (result = DialogResult.Yes) Then
                Clients_DataBindingSource.EndEdit()
                TableAdapterManager.UpdateAll(Me._HomeInventory_accdbDataSet1)

                MessageBox.Show("The Client has been saved successfully ", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information)
                RefreshData()
                AddClientButton.Text = "Add New Client"
            Else
                Return

            End If
        Catch ex As Exception
            MessageBox.Show("Save and Update Client Failed" & ex.Message.ToString(), "Fail", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try


    End Sub

    Private Sub DeleteClientButton_Click(sender As Object, e As EventArgs) Handles DeleteClientButton.Click
        ' MsgBox("You pressed Delete NeW Client Button")




        Try
            If MessageBox.Show("Do you want to permanently delete selected client ?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.Yes Then
                Clients_DataBindingSource.RemoveCurrent()
                Clients_DataBindingSource.EndEdit()
                Clients_DataTableAdapter.Update(_HomeInventory_accdbDataSet1.Clients_Data)
                RefreshData()
                MessageBox.Show("Deleted Succesfully", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                Return
            End If
        Catch ex As Exception
            MessageBox.Show("Delete Client Failed" & ex.Message.ToString(), "Fail", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class