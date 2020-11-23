Imports System.Drawing.Imaging

Public Class RTransact
    Private Sub Transactions_DataBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles Transactions_DataBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Transactions_DataBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me._HomeInventory_accdbDataSet1)

    End Sub

    Private Sub RTransact_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the '_HomeInventory_accdbDataSet1.Transactions_Data' table. You can move, or remove it, as needed.
        Me.Transactions_DataTableAdapter.Fill(Me._HomeInventory_accdbDataSet1.Transactions_Data)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim bmpScreenshot As Bitmap = New Bitmap(Width, Height, PixelFormat.Format32bppArgb)
        ' Create a graphics object from the bitmap  
        Dim gfxScreenshot As Graphics = Graphics.FromImage(bmpScreenshot)
        ' Take a screenshot of the entire Form1  
        gfxScreenshot.CopyFromScreen(Me.Location.X, Me.Location.Y, 0, 0, Me.Size, CopyPixelOperation.SourceCopy)
        ' Save the screenshot   
        bmpScreenshot.Save("C:\Users\ekahr\Desktop\ReportRTransact.jpg", ImageFormat.Jpeg)

        MessageBox.Show("The item has been saved in local directory", "Save Report ", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        frmReport.Show()
        Me.Hide()
    End Sub
End Class