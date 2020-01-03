Public Class Form1
    Private Sub PegawaiBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.PegawaiBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Datanya)
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.PegawaiTableAdapter.Fill(Me.Datanya.Pegawai)
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.PegawaiBindingSource.AddNew()
        PegawaiDataGridView.Enabled = True
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.PegawaiBindingSource.RemoveCurrent()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Validate()
        Me.PegawaiBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Datanya)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Close()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        PegawaiDataGridView.Refresh()
        TextBox1.Text = Nothing
        Label8.Text = Nothing
        Label9.Text = Nothing
        Label10.Text = Nothing
        Label11.Text = Nothing
        Label12.Text = Nothing
        Label13.Text = Nothing
        TextBox2.Text = Nothing
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim indeks As Integer = Nothing

        If TextBox1.Text.Length <> 0 Then
            Dim i As Integer
            Dim ketemu As Boolean = False
            For i = 0 To PegawaiDataGridView.RowCount - 1
                If ketemu = False And PegawaiDataGridView.Item(0, i).Value = TextBox1.Text Then
                    ketemu = True
                    indeks = i
                    Exit For
                End If
            Next
            If ketemu Then
                MessageBox.Show(“Data Ditemukan !”, “Pemberitahuan”, MessageBoxButtons.OK, MessageBoxIcon.Information)
                Label8.Text = PegawaiDataGridView.Item(1, indeks).Value
                Label9.Text = PegawaiDataGridView.Item(2, indeks).Value
                Label10.Text = PegawaiDataGridView.Item(3, indeks).Value
                Label11.Text = PegawaiDataGridView.Item(4, indeks).Value
                Label12.Text = PegawaiDataGridView.Item(5, indeks).Value
                Label13.Text = PegawaiDataGridView.Item(6, indeks).Value
            Else
                MessageBox.Show(“Data tidak ditemukan !”, “Pemberitahuan”, MessageBoxButtons.OK, MessageBoxIcon.Error)
                TextBox1.Focus()
            End If
        Else
            MessageBox.Show(“Nama Belum Diisi !”, “Warning”)
        End If
    End Sub
End Class
