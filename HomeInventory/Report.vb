Imports System.Drawing.Imaging

Public Class frmReport

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Application.Exit()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        frmMain.Show()
        Me.Hide()
    End Sub

    Private Sub Clients_DataBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.Clients_DataBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me._HomeInventory_accdbDataSet1)

    End Sub

    Private Sub frmReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the '_HomeInventory_accdbDataSet1.Transactions_Data' table. You can move, or remove it, as needed.
        Me.Transactions_DataTableAdapter.Fill(Me._HomeInventory_accdbDataSet1.Transactions_Data)
        'TODO: This line of code loads data into the '_HomeInventory_accdbDataSet1.Items_Data' table. You can move, or remove it, as needed.
        Me.Items_DataTableAdapter.Fill(Me._HomeInventory_accdbDataSet1.Items_Data)
        'TODO: This line of code loads data into the '_HomeInventory_accdbDataSet1.Clients_Data' table. You can move, or remove it, as needed.
        Me.Clients_DataTableAdapter.Fill(Me._HomeInventory_accdbDataSet1.Clients_Data)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        gbxritems.Visible = True
        gbxClientsR.Visible = False

        Dim bmpScreenshot As Bitmap = New Bitmap(Width, Height, PixelFormat.Format32bppArgb)
        ' Create a graphics object from the bitmap  
        Dim gfxScreenshot As Graphics = Graphics.FromImage(bmpScreenshot)
        ' Take a screenshot of the entire Form1  
        gfxScreenshot.CopyFromScreen(Me.Location.X, Me.Location.Y, 0, 0, Me.Size, CopyPixelOperation.SourceCopy)
        ' Save the screenshot   
        bmpScreenshot.Save("C:\Users\ekahr\Desktop\ReportClients.jpg", ImageFormat.Jpeg)
        MessageBox.Show("The item has been saved in local directory", "Save Report ", MessageBoxButtons.OK, MessageBoxIcon.Information)

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        gbxClientsR.Visible = True
        gbxritems.Visible = False
        Dim bmpScreenshot As Bitmap = New Bitmap(Width, Height, PixelFormat.Format32bppArgb)
        ' Create a graphics object from the bitmap  
        Dim gfxScreenshot As Graphics = Graphics.FromImage(bmpScreenshot)
        ' Take a screenshot of the entire Form1  
        gfxScreenshot.CopyFromScreen(Me.Location.X, Me.Location.Y, 0, 0, Me.Size, CopyPixelOperation.SourceCopy)
        ' Save the screenshot   
        bmpScreenshot.Save("C:\Users\ekahr\Desktop\ReportClients.jpg", ImageFormat.Jpeg)
        MessageBox.Show("The item has been saved in local directory", "Save Report ", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        RTransact.Show()
        Me.Hide()

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        CTR.Show()
        Me.Hide()
    End Sub
End Class