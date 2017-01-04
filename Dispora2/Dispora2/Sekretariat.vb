Public Class Sekretariat

    Private Sub SekretariatBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SekretariatBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.SekretariatBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Db_disporaDataSet)

    End Sub

    Private Sub Sekretariat_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Db_disporaDataSet.sekretariat' table. You can move, or remove it, as needed.
        Me.SekretariatTableAdapter.Fill(Me.Db_disporaDataSet.sekretariat)

    End Sub

    Private Sub tambahButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tambahButton.Click
        NIKTextBox.Enabled = True
        Nama_pegawaiTextBox.Enabled = True
        AlamatTextBox.Enabled = True
        NO_HPTextBox.Enabled = True
        Keuangan_id_keuanganTextBox.Enabled = True

        tambahButton.Enabled = False
        editButton.Enabled = False
        hapusButton.Enabled = False
        batalButton.Enabled = False
        refreshButton.Enabled = True
        simpanButton.Enabled = True
        SekretariatBindingSource.AddNew()
    End Sub

    Private Sub simpanButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles simpanButton.Click
        Me.Validate()
        Me.SekretariatBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Db_disporaDataSet)

        MessageBox.Show("Data Berhasil Disimpan")

        NIKTextBox.Enabled = True
        Nama_pegawaiTextBox.Enabled = True
        AlamatTextBox.Enabled = True
        NO_HPTextBox.Enabled = True
        Keuangan_id_keuanganTextBox.Enabled = True

        tambahButton.Enabled = True
        editButton.Enabled = True
        hapusButton.Enabled = True
        simpanButton.Enabled = False

    End Sub

    Private Sub editButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles editButton.Click
        Nama_pegawaiTextBox.Enabled = True
        AlamatTextBox.Enabled = True
        NO_HPTextBox.Enabled = True
        Keuangan_id_keuanganTextBox.Enabled = True

        tambahButton.Enabled = False
        editButton.Enabled = False
        hapusButton.Enabled = False
        refreshButton.Enabled = False
        batalButton.Enabled = True
        simpanButton.Enabled = True
    End Sub

    Private Sub hapusButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles hapusButton.Click
        If MessageBox.Show("Hapus Data?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            SekretariatBindingSource.RemoveCurrent()

            Me.Validate()
            Me.SekretariatBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.Db_disporaDataSet)

            MessageBox.Show("Data Telah Terhapus")
        End If
    End Sub

    Private Sub keluarButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles keluarButton.Click
        Me.Close()
    End Sub

    Private Sub batalButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles batalButton.Click
        SekretariatBindingSource.CancelEdit()

        tambahButton.Enabled = True
        editButton.Enabled = True
        hapusButton.Enabled = True
        refreshButton.Enabled = True
        simpanButton.Enabled = False
        batalButton.Enabled = False
    End Sub

    Private Sub refreshButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles refreshButton.Click
        Me.SekretariatTableAdapter.Fill(Me.Db_disporaDataSet.sekretariat)
    End Sub

    Private Sub cariButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cariButton.Click
        SekretariatTableAdapter.cariQuery(Db_disporaDataSet.sekretariat, "%" & cariText.Text & "%")
    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter
        SekretariatTableAdapter.cariQuery(Db_disporaDataSet.sekretariat, "%" & cariText.Text & "%")
    End Sub
End Class