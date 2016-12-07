Public Class Keuangan
    Private Sub FormPengrajin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'TODO: This line of code loads data into the 'Db_ukmsejahteraDataSet.tb_pengrajin' table. You can move, or remove it, as needed.
        Me.KeuanganTableAdapter.Fill(Me.Db_disporaDataSet.keuangan)

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles editButton.Click
        Id_keuanganTextBox.Enabled = True
        Gaji_karyawanTextBox.Enabled = True
        Gaji_atletTextBox.Enabled = True
        Pemasukan_kejuaraanTextBox.Enabled = True
        Pengeluaran_atletTextBox.Enabled = True
        Perlengkapan_kantorTextBox.Enabled = True

        tambahButton.Enabled = False
        hapusButton.Enabled = False
        editButton.Enabled = False
        simpanButton.Enabled = True
        refreshButton.Enabled = False
        BatalButton.Enabled = True
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tambahButton.Click
        Id_keuanganTextBox.Enabled = True
        Gaji_karyawanTextBox.Enabled = True
        Gaji_atletTextBox.Enabled = True
        Pemasukan_kejuaraanTextBox.Enabled = True
        Pengeluaran_atletTextBox.Enabled = True
        Perlengkapan_kantorTextBox.Enabled = True

        tambahButton.Enabled = False
        hapusButton.Enabled = False
        editButton.Enabled = False
        simpanButton.Enabled = True
        refreshButton.Enabled = False
        batalButton.Enabled = True

        KeuanganBindingSource.AddNew()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles simpanButton.Click
        Me.Validate()
        Me.KeuanganBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Db_disporaDataSet)

        MessageBox.Show("Data Telah Tersimpan")

        Id_keuanganTextBox.Enabled = False
        Gaji_karyawanTextBox.Enabled = False
        Gaji_atletTextBox.Enabled = False
        Pemasukan_kejuaraanTextBox.Enabled = False
        Pengeluaran_atletTextBox.Enabled = False
        Perlengkapan_kantorTextBox.Enabled = False

        tambahButton.Enabled = True
        hapusButton.Enabled = True
        editButton.Enabled = True
        simpanButton.Enabled = False
    End Sub

    Private Sub hapusButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles hapusButton.Click
        If MessageBox.Show("Mau Hapus Data?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            KeuanganBindingSource.RemoveCurrent()

            Me.Validate()
            Me.KeuanganBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.Db_disporaDataSet)

            MessageBox.Show("Data Telah Terhapus")
        End If

    End Sub

    Private Sub keluarButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles keluarButton.Click
        Me.Close()
    End Sub

    Private Sub batalButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles batalButton.Click
        KeuanganBindingSource.CancelEdit()

        tambahButton.Enabled = True
        hapusButton.Enabled = True
        editButton.Enabled = True
        simpanButton.Enabled = False
        refreshButton.Enabled = True
        batalButton.Enabled = False
    End Sub
    Private Sub refreshButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles refreshButton.Click
        Me.KeuanganTableAdapter.Fill(Me.Db_disporaDataSet.keuangan)
    End Sub
    Private Sub cariButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cariButton1.Click
        KeuanganTableAdapter.cariQuery(Db_disporaDataSet.keuangan, "%" & cariText1.Text & "%")
    End Sub

    Private Sub cariText1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cariText1.TextChanged
        KeuanganTableAdapter.cariQuery(Db_disporaDataSet.keuangan, "%" & cariText1.Text & "%")
    End Sub
End Class
