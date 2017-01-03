Public Class Atlet

    Private Sub AtletBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AtletBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.AtletBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Db_disporaDataSet)

    End Sub

    Private Sub Atlet_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Db_disporaDataSet.atlet' table. You can move, or remove it, as needed.
        Me.AtletTableAdapter.Fill(Me.Db_disporaDataSet.atlet)

    End Sub

    Private Sub EditButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditButton.Click
        NIATextBox.Enabled = True
        Nama_atletTextBox.Enabled = True
        TTLTextBox.Enabled = True
        Asal_sekolah_PTTextBox.Enabled = True
        AlamatTextBox.Enabled = True
        NO_HPTextBox.Enabled = True

        TambahButton.Enabled = False
        HapusButton.Enabled = False
        EditButton.Enabled = False
        SimpanButton.Enabled = True
        RefreshButton.Enabled = False
        BatalButton.Enabled = True
    End Sub

    Private Sub TambahButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TambahButton.Click
        NIATextBox.Enabled = True
        Nama_atletTextBox.Enabled = True
        TTLTextBox.Enabled = True
        Asal_sekolah_PTTextBox.Enabled = True
        AlamatTextBox.Enabled = True
        NO_HPTextBox.Enabled = True

        TambahButton.Enabled = False
        HapusButton.Enabled = False
        EditButton.Enabled = False
        SimpanButton.Enabled = True
        RefreshButton.Enabled = False
        BatalButton.Enabled = True

        AtletBindingSource.AddNew()
    End Sub

    Private Sub SimpanButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpanButton.Click
        Me.Validate()
        Me.AtletBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Db_disporaDataSet)

        MessageBox.Show("Data Telah Tersimpan")

        NIATextBox.Enabled = False
        Nama_atletTextBox.Enabled = False
        TTLTextBox.Enabled = False
        Asal_sekolah_PTTextBox.Enabled = False
        AlamatTextBox.Enabled = False
        NO_HPTextBox.Enabled = False

        TambahButton.Enabled = True
        HapusButton.Enabled = True
        EditButton.Enabled = True
        SimpanButton.Enabled = False
    End Sub

    Private Sub HapusButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HapusButton.Click
        If MessageBox.Show("Mau Hapus Data?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            AtletBindingSource.RemoveCurrent()

            Me.Validate()
            Me.AtletBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.Db_disporaDataSet)

            MessageBox.Show("Data Telah Terhapus")
        End If

    End Sub

    Private Sub KeluarButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KeluarButton.Click
        Me.Close()
    End Sub

    Private Sub BatalButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BatalButton.Click
        AtletBindingSource.CancelEdit()

        TambahButton.Enabled = True
        HapusButton.Enabled = True
        EditButton.Enabled = True
        SimpanButton.Enabled = False
        RefreshButton.Enabled = True
        BatalButton.Enabled = False
    End Sub

    Private Sub RefreshButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RefreshButton.Click
        Me.AtletTableAdapter.Fill(Me.Db_disporaDataSet.atlet)
    End Sub

    Private Sub cariButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cariButton1.Click
        AtletTableAdapter.cariQuery(Db_disporaDataSet.atlet, "%" & cariText1.Text & "%")
    End Sub

    Private Sub cariText1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cariText1.TextChanged
        AtletTableAdapter.cariQuery(Db_disporaDataSet.atlet, "%" & cariText1.Text & "%")
    End Sub
End Class