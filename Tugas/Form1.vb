Public Class Form1
    Private Sub PegawaiBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles PegawaiBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.PegawaiBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Datanya)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Datanya.Pegawai' table. You can move, or remove it, as needed.
        Me.PegawaiTableAdapter.Fill(Me.Datanya.Pegawai)

    End Sub
	
	Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

		Me.PegawaiBindingSource.AddNew()
		PegawaiDataGridView.Enabled = True

	End Sub
End Class
