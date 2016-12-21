Public Class EventKejuaraan
    Private Sub EventKejuaraan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Db_disporaDataSet.event_kejuaraan' table. You can move, or remove it, as needed.
        Me.Event_kejuaraanTableAdapter.Fill(Me.Db_disporaDataSet.event_kejuaraan)

    End Sub

    Private Sub TambahButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TambahButton.Click
        Id_eventTextBox.Enabled = True
        Nama_eventTextBox.Enabled = True
        WaktuDateTimePicker.Enabled = True
        TempatTextBox.Enabled = True

        TambahButton.Enabled = False
        HapusButton.Enabled = False
        EditButton.Enabled = False
        RefreshButton.Enabled = False
        BatalButton.Enabled = True
        SimpanButton.Enabled = True

        Event_kejuaraanBindingSource.AddNew()
    End Sub

    Private Sub SimpanButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpanButton.Click
        Me.vaildate()
        Me.Event_kejuaraanBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Db_disporaDataSet)

        MessageBox.Show("Data Telah Disimpan")

        Id_eventTextBox.Enabled = True
        Nama_eventTextBox.Enabled = True
        WaktuDateTimePicker.Enabled = True
        TempatTextBox.Enabled = True

        TambahButton.Enabled = True
        HapusButton.Enabled = True
        EditButton.Enabled = True
        SimpanButton.Enabled = False
    End Sub

    Private Sub vaildate()
        Throw New NotImplementedException
    End Sub

    Private Sub EditButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditButton.Click
        Nama_eventTextBox.Enabled = True
        WaktuDateTimePicker.Enabled = True
        TempatTextBox.Enabled = True

        TambahButton.Enabled = False
        HapusButton.Enabled = False
        EditButton.Enabled = False
        RefreshButton.Enabled = False
        BatalButton.Enabled = True
        SimpanButton.Enabled = True
    End Sub

    Private Sub HapusButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HapusButton.Click
        If MessageBox.Show("Hapus Data?", "konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Event_kejuaraanBindingSource.RemoveCurrent()

            Me.vaildate()
            Me.Event_kejuaraanBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.Db_disporaDataSet)

            MessageBox.Show("Data Telah Terhapus")
        End If
    End Sub

    Private Sub KeluarButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KeluarButton.Click
        Me.Close()
    End Sub

    Private Sub BatalButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BatalButton.Click
        Event_kejuaraanBindingSource.CancelEdit()

        TambahButton.Enabled = True
        EditButton.Enabled = True
        HapusButton.Enabled = True
        RefreshButton.Enabled = True
        SimpanButton.Enabled = False
        BatalButton.Enabled = False
    End Sub

    Private Sub RefreshButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RefreshButton.Click
        Me.Event_kejuaraanTableAdapter.Fill(Me.Db_disporaDataSet.event_kejuaraan)
    End Sub
End Class