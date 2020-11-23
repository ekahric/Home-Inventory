

Imports System.Drawing.Imaging

Public Class frmMain
    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the '_HomeInventory_accdbDataSet1.Transactions_Data' table. You can move, or remove it, as needed.
        Me.Transactions_DataTableAdapter.Fill(Me._HomeInventory_accdbDataSet1.Transactions_Data)
        'TODO: This line of code loads data into the '_HomeInventory_accdbDataSet.Items_Data' table. You can move, or remove it, as needed.
        Me.Items_DataTableAdapter.Fill(Me._HomeInventory_accdbDataSet.Items_Data)
        gbxItems.Hide()
        gbxTransactions.Hide()

        lbldate.Text = System.DateTime.Now.ToShortDateString()
        lbltime.Text = DateTime.Now.ToString("h:mm:ss")
        lbluser.Text = "Username"
    End Sub

    Private Sub btnItems_Click(sender As Object, e As EventArgs) Handles btnItems.Click
        gbxItems.Show()
        gbxTransactions.Hide()

    End Sub

    Private Sub Items_DataBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles Items_DataBindingNavigatorSaveItem.Click
        'Me.Validate()
        'Me.Items_DataBindingSource.EndEdit()
        'Me.TableAdapterManager.UpdateAll(Me._HomeInventory_accdbDataSet)
        btnSave.PerformClick()

    End Sub

    Private Sub BindingNavigatorAddNewItem_Click(sender As Object, e As EventArgs) Handles BindingNavigatorAddNewItem.Click
        'Add new Item'
        btnNew.PerformClick()

    End Sub

    Private Sub BindingNavigatorDeleteItem_Click(sender As Object, e As EventArgs) Handles BindingNavigatorDeleteItem.Click
        btnDelete.PerformClick()
    End Sub

    Private Sub gbxItems_Enter(sender As Object, e As EventArgs) Handles gbxItems.Enter

    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Application.Exit()
    End Sub

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        'add new'
        Try
            With btnNew
                If .Text = "Add New Item" Then
                    Items_DataBindingSource.AddNew()
                    .Text = "Cancel"
                Else
                    RefreshData()
                    .Text = "Add New Item"
                End If

            End With

            With NameItemTextBox
                If (.CanSelect) Then
                    .Text = String.Empty
                    .Select()
                End If
            End With
        Catch ex As Exception
            MsgBox("An Error Occured" & ex.Message.ToString(), MsgBoxStyle.OkOnly Or MsgBoxStyle.Information, "Add new item failed.")
        End Try
    End Sub

    Private Sub RefreshData()
        Try
            Me.Items_DataBindingSource.Filter = Nothing
            Me.Items_DataTableAdapter.Fill(Me._HomeInventory_accdbDataSet.Items_Data)
            Me.Transactions_DataBindingSource.Filter = Nothing
            Me.Transactions_DataTableAdapter.Fill(Me._HomeInventory_accdbDataSet1.Transactions_Data)

        Catch ex As Exception
            MsgBox("Refresh Data error!")
        End Try
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            Dim result As DialogResult
            result = MessageBox.Show("Do you want to save the selected Item?", "Save Item", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If (result = DialogResult.Yes) Then
                Validate()
                Items_DataBindingSource.EndEdit()
                TableAdapterManager.UpdateAll(Me._HomeInventory_accdbDataSet)


                MessageBox.Show("The item has been saved successfully", "Save data ", MessageBoxButtons.OK, MessageBoxIcon.Error)

                RefreshData()

                btnNew.Text = "Add New Record"
            Else
                'Exit Sub
                Return

            End If
        Catch ex As Exception
            MessageBox.Show("Save and Update Data Failed: " & ex.Message.ToString(), "Save data ", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Try
            If MessageBox.Show("Do you want to permanently delete selected item? ", "Delete Item", MessageBoxButtons.YesNo, MessageBoxIcon.Question) Then
                Items_DataBindingSource.RemoveCurrent()
                Items_DataBindingSource.EndEdit()
                Items_DataTableAdapter.Update(_HomeInventory_accdbDataSet.Items_Data)

                RefreshData()

                MessageBox.Show("The record has been deleted Succesfully!", "deleted record", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show("Delete Failed: " & ex.Message.ToString(), "Delete data ", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnClients_Click(sender As Object, e As EventArgs) Handles btnClients.Click
        frmClients.Show()

    End Sub

    Private Sub btnTransactions_Click(sender As Object, e As EventArgs) Handles btnTransactions.Click
        gbxItems.Hide()
        gbxTransactions.Show()
    End Sub



    Private Sub btnAddT_Click(sender As Object, e As EventArgs) Handles btnAddT.Click
        Try
            With btnAddT
                If .Text = "New Transaction" Then
                    Transactions_DataBindingSource.AddNew()
                    .Text = "Cancel"
                Else
                    RefreshData()
                    .Text = "Add New Item"
                End If

            End With

            With ClientNameTextBox
                If (.CanSelect) Then
                    .Text = String.Empty
                    .Select()
                End If
            End With
        Catch ex As Exception
            MsgBox("An Error Occured" & ex.Message.ToString(), MsgBoxStyle.OkOnly Or MsgBoxStyle.Information, "Add new transaction failed.")
        End Try
    End Sub

    Private Sub BindingNavigatorAddNewItem1_Click(sender As Object, e As EventArgs) Handles BindingNavigatorAddNewItem1.Click
        btnAddT.PerformClick()
        MessageBox.Show("wutt")
    End Sub

    Private Sub BindingNavigatorDeleteItem1_Click(sender As Object, e As EventArgs) Handles BindingNavigatorDeleteItem1.Click
        DeleteT.PerformClick()
        MsgBox("wut2t")
    End Sub

    Private Sub DeleteT_Click(sender As Object, e As EventArgs) Handles DeleteT.Click
        Try
            If MessageBox.Show("Do you want to permanently delete selected item? ", "Delete Item", MessageBoxButtons.YesNo, MessageBoxIcon.Question) Then
                Transactions_DataBindingSource.RemoveCurrent()
                Transactions_DataBindingSource.EndEdit()
                Transactions_DataTableAdapter1.Update(_HomeInventory_accdbDataSet1.Transactions_Data)

                RefreshData()

                MessageBox.Show("The record has been deleted Succesfully!", "deleted record", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show("Delete Failed: " & ex.Message.ToString(), "Delete data ", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub SaveT_Click(sender As Object, e As EventArgs) Handles SaveT.Click
        Try
            Dim result1 As DialogResult
            result1 = MessageBox.Show("Do you want to save the selected Item?", "Save Item", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If (result1 = DialogResult.Yes) Then
                Validate()
                Transactions_DataBindingSource.EndEdit()
                TableAdapterManager1.UpdateAll(Me._HomeInventory_accdbDataSet1)


                MessageBox.Show("The item has been saved successfully", "Save data ", MessageBoxButtons.OK, MessageBoxIcon.Information)

                RefreshData()

                btnAddT.Text = " New Transaction"
            Else
                'Exit Sub
                Return

            End If
        Catch ex As Exception
            MessageBox.Show("Save and Update Data Failed: " & ex.Message.ToString(), "Save data ", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub PrintT_Click(sender As Object, e As EventArgs) Handles PrintT.Click
        Dim r As New Rectangle(0, 0, Me.Width, Me.Height)
        Using bm As New Bitmap(Me.Width, Me.Height)
            Me.DrawToBitmap(bm, r)

            bm.Save("C:\Users\ekahr\Desktop\HomeInventory\pnlimage.png", Imaging.ImageFormat.Png)
            MessageBox.Show("The item has been stored in local directory", "Save Report ", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Using
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        gbxTransactions.Hide()
        gbxItems.Hide()
    End Sub

    Private Sub btnExport_Click(sender As Object, e As EventArgs) Handles btnExport.Click
        Dim bmpScreenshot As Bitmap = New Bitmap(Width, Height, PixelFormat.Format32bppArgb)
        ' Create a graphics object from the bitmap  
        Dim gfxScreenshot As Graphics = Graphics.FromImage(bmpScreenshot)
        ' Take a screenshot of the entire Form1  
        gfxScreenshot.CopyFromScreen(Me.Location.X, Me.Location.Y, 0, 0, Me.Size, CopyPixelOperation.SourceCopy)
        ' Save the screenshot   
        bmpScreenshot.Save("C:\Users\ekahr\Desktop\transactions.jpg", ImageFormat.Jpeg)
        MessageBox.Show("The item has been exported in local directory", "Save Report ", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub btnItems_MouseHover(sender As Object, e As EventArgs) Handles btnItems.MouseHover

    End Sub

    Private Sub btnItems_MouseLeave(sender As Object, e As EventArgs) Handles btnItems.MouseLeave
        btnItems.BackColor = Color.SteelBlue
    End Sub

    Private Sub btnItems_MouseEnter(sender As Object, e As EventArgs) Handles btnItems.MouseEnter
        btnItems.BackColor = Color.LightSkyBlue
    End Sub

    Private Sub btnItems_MouseClick(sender As Object, e As MouseEventArgs) Handles btnItems.MouseClick
        btnItems.BackColor = Color.LightSkyBlue
    End Sub

    Private Sub btnClients_MouseEnter(sender As Object, e As EventArgs) Handles btnClients.MouseEnter
        btnClients.BackColor = Color.LightSkyBlue
    End Sub

    Private Sub btnClients_MouseHover(sender As Object, e As EventArgs) Handles btnClients.MouseHover
        btnClients.BackColor = Color.LightSkyBlue
    End Sub

    Private Sub btnClients_MouseLeave(sender As Object, e As EventArgs) Handles btnClients.MouseLeave
        btnClients.BackColor = Color.SteelBlue
    End Sub

    Private Sub btnItems_Enter(sender As Object, e As EventArgs) Handles btnItems.Enter
        btnItems.BackColor = Color.LightSkyBlue
    End Sub

    Private Sub btnReport_Click(sender As Object, e As EventArgs) Handles btnReport.Click
        frmReport.Show()
        Me.Hide()
    End Sub
End Class