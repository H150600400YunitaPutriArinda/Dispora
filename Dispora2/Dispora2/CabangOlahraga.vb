Public Class CabangOlahraga
    Private Sub CabangOlahraga_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Db_disporaDataSet.cabang_olahraga' table. You can move, or remove it, as needed.
        Me.Cabang_olahragaTableAdapter.Fill(Me.Db_disporaDataSet.cabang_olahraga)

    End Sub

    Private Sub TambahButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TambahButton.Click
        Id_olahragaTextBox.Enabled = True
        Nama_olahragaTextBox.Enabled = True
        KelasTextBox.Enabled = True
        Kelompok_usiaTextBox.Enabled = True

        TambahButton.Enabled = False
        HapusButton.Enabled = False
        EditButton.Enabled = False
        RefreshButton.Enabled = False
        BatalButton.Enabled = True
        SimpanButton.Enabled = True

        Cabang_olahragaBindingSource.AddNew()
    End Sub

    Private Sub SimpanButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpanButton.Click
        Me.vaildate()
        Me.Cabang_olahragaBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Db_disporaDataSet)

        MessageBox.Show("Data Telah Disimpan")

        Id_olahragaTextBox.Enabled = False
        Nama_olahragaTextBox.Enabled = False
        KelasTextBox.Enabled = False
        Kelompok_usiaTextBox.Enabled = False

        TambahButton.Enabled = True
        HapusButton.Enabled = True
        EditButton.Enabled = True
        SimpanButton.Enabled = False
    End Sub

    Private Sub vaildate()
        Throw New NotImplementedException
    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub EditButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditButton.Click
        Nama_olahragaTextBox.Enabled = True
        KelasTextBox.Enabled = True
        Kelompok_usiaTextBox.Enabled = True

        TambahButton.Enabled = False
        HapusButton.Enabled = False
        EditButton.Enabled = False
        RefreshButton.Enabled = False
        BatalButton.Enabled = True
        SimpanButton.Enabled = True
    End Sub

    Private Sub HapusButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HapusButton.Click
        If MessageBox.Show("Hapus Data?", "konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Cabang_olahragaBindingSource.RemoveCurrent()

            Me.vaildate()
            Me.Cabang_olahragaBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.Db_disporaDataSet)

            MessageBox.Show("Data Telah Terhapus")
        End If
    End Sub

    Private Sub KeluarButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KeluarButton.Click
        Me.Close()
    End Sub

    Private Sub BatalButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BatalButton.Click
        Cabang_olahragaBindingSource.CancelEdit()

        TambahButton.Enabled = True
        EditButton.Enabled = True
        HapusButton.Enabled = True
        RefreshButton.Enabled = True
        SimpanButton.Enabled = False
        BatalButton.Enabled = False
    End Sub
End Class