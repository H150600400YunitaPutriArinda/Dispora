Public Class Atlet

    Private Sub AtletBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.AtletBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Db_disporaDataSet)

    End Sub

    Private Sub Atlet_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Db_disporaDataSet.atlet' table. You can move, or remove it, as needed.
        Me.AtletTableAdapter.Fill(Me.Db_disporaDataSet.atlet)
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        AtletBindingSource.AddNew()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Validate()
        Me.AtletBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Db_disporaDataSet)
    End Sub

    Private Sub hapusButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles hapusButton.Click
        If MessageBox.Show("Hapus Data?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            AtletBindingSource.RemoveCurrent()

            Me.Validate()
            Me.AtletBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.Db_disporaDataSet)

            MessageBox.Show("Data Telah Terhapus")
        End If
    End Sub

    Private Sub editButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles editButton.Click
        NIASpinEdit.Enabled = True
        Nama_atletTextEdit.Enabled = True
        TTLTextEdit.Enabled = True
        NO_HPSpinEdit.Enabled = True
        Asal_sekolah_PTTextEdit.Enabled = True
        Sekretariat_NIKSpinEdit.Enabled = True
        Sekretariat_keuangan_id_keuanganSpinEdit.Enabled = True
        Cabang_olahraga_id_olahragaSpinEdit.Enabled = True
    End Sub

    Private Sub refresButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles refresButton.Click
        Me.AtletTableAdapter.Fill(Me.Db_disporaDataSet.atlet)
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Close()
    End Sub

    Private Sub batalButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles batalButton.Click
        Db_disporaDataSet.EndInit()

        Button1.Enabled = True
        Button2.Enabled = True
        Button3.Enabled = True
        editButton.Enabled = True
        batalButton.Enabled = True
        hapusButton.Enabled = True

        Button1.Enabled = False
        Button2.Enabled = False
        Button3.Enabled = False
        editButton.Enabled = False
        batalButton.Enabled = False
        hapusButton.Enabled = False

        AtletBindingSource.AddNew()
    End Sub

    Private Sub cariButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cariButton.Click
        AtletTableAdapter.cariQuery(Db_disporaDataSet.atlet, " " & cariText.Text & " ")
    End Sub

    Private Sub cariText_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cariText.TextChanged
        AtletTableAdapter.cariQuery(Db_disporaDataSet.atlet, " " & cariText.Text & " ")
    End Sub
End Class