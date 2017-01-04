<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EventKejuaraan
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim Id_eventLabel As System.Windows.Forms.Label
        Dim Nama_eventLabel As System.Windows.Forms.Label
        Dim WaktuLabel As System.Windows.Forms.Label
        Dim TempatLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EventKejuaraan))
        Me.KeluarButton = New System.Windows.Forms.Button()
        Me.RefreshButton = New System.Windows.Forms.Button()
        Me.BatalButton = New System.Windows.Forms.Button()
        Me.HapusButton = New System.Windows.Forms.Button()
        Me.EditButton = New System.Windows.Forms.Button()
        Me.SimpanButton = New System.Windows.Forms.Button()
        Me.TambahButton = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Id_eventTextBox = New System.Windows.Forms.TextBox()
        Me.Event_kejuaraanBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Db_disporaDataSet = New Dispora2.db_disporaDataSet()
        Me.Nama_eventTextBox = New System.Windows.Forms.TextBox()
        Me.WaktuDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.TempatTextBox = New System.Windows.Forms.TextBox()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Event_kejuaraanTableAdapter = New Dispora2.db_disporaDataSetTableAdapters.event_kejuaraanTableAdapter()
        Me.TableAdapterManager = New Dispora2.db_disporaDataSetTableAdapters.TableAdapterManager()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Event_kejuaraanDataGridView = New System.Windows.Forms.DataGridView()
        Id_eventLabel = New System.Windows.Forms.Label()
        Nama_eventLabel = New System.Windows.Forms.Label()
        WaktuLabel = New System.Windows.Forms.Label()
        TempatLabel = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.Event_kejuaraanBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Db_disporaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Event_kejuaraanDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Id_eventLabel
        '
        Id_eventLabel.AutoSize = True
        Id_eventLabel.Enabled = False
        Id_eventLabel.Location = New System.Drawing.Point(19, 25)
        Id_eventLabel.Name = "Id_eventLabel"
        Id_eventLabel.Size = New System.Drawing.Size(48, 13)
        Id_eventLabel.TabIndex = 0
        Id_eventLabel.Text = "id event:"
        '
        'Nama_eventLabel
        '
        Nama_eventLabel.AutoSize = True
        Nama_eventLabel.Enabled = False
        Nama_eventLabel.Location = New System.Drawing.Point(19, 51)
        Nama_eventLabel.Name = "Nama_eventLabel"
        Nama_eventLabel.Size = New System.Drawing.Size(66, 13)
        Nama_eventLabel.TabIndex = 2
        Nama_eventLabel.Text = "nama event:"
        '
        'WaktuLabel
        '
        WaktuLabel.AutoSize = True
        WaktuLabel.Enabled = False
        WaktuLabel.Location = New System.Drawing.Point(19, 78)
        WaktuLabel.Name = "WaktuLabel"
        WaktuLabel.Size = New System.Drawing.Size(39, 13)
        WaktuLabel.TabIndex = 4
        WaktuLabel.Text = "waktu:"
        '
        'TempatLabel
        '
        TempatLabel.AutoSize = True
        TempatLabel.Enabled = False
        TempatLabel.Location = New System.Drawing.Point(19, 103)
        TempatLabel.Name = "TempatLabel"
        TempatLabel.Size = New System.Drawing.Size(42, 13)
        TempatLabel.TabIndex = 6
        TempatLabel.Text = "tempat:"
        '
        'KeluarButton
        '
        Me.KeluarButton.Location = New System.Drawing.Point(142, 236)
        Me.KeluarButton.Name = "KeluarButton"
        Me.KeluarButton.Size = New System.Drawing.Size(75, 23)
        Me.KeluarButton.TabIndex = 14
        Me.KeluarButton.Text = "Keluar"
        Me.KeluarButton.UseVisualStyleBackColor = True
        '
        'RefreshButton
        '
        Me.RefreshButton.Location = New System.Drawing.Point(264, 189)
        Me.RefreshButton.Name = "RefreshButton"
        Me.RefreshButton.Size = New System.Drawing.Size(75, 23)
        Me.RefreshButton.TabIndex = 13
        Me.RefreshButton.Text = "Refresh"
        Me.RefreshButton.UseVisualStyleBackColor = True
        '
        'BatalButton
        '
        Me.BatalButton.Enabled = False
        Me.BatalButton.Location = New System.Drawing.Point(264, 142)
        Me.BatalButton.Name = "BatalButton"
        Me.BatalButton.Size = New System.Drawing.Size(75, 23)
        Me.BatalButton.TabIndex = 12
        Me.BatalButton.Text = "Batal"
        Me.BatalButton.UseVisualStyleBackColor = True
        '
        'HapusButton
        '
        Me.HapusButton.Location = New System.Drawing.Point(142, 189)
        Me.HapusButton.Name = "HapusButton"
        Me.HapusButton.Size = New System.Drawing.Size(75, 23)
        Me.HapusButton.TabIndex = 11
        Me.HapusButton.Text = "Hapus"
        Me.HapusButton.UseVisualStyleBackColor = True
        '
        'EditButton
        '
        Me.EditButton.Location = New System.Drawing.Point(142, 142)
        Me.EditButton.Name = "EditButton"
        Me.EditButton.Size = New System.Drawing.Size(75, 23)
        Me.EditButton.TabIndex = 10
        Me.EditButton.Text = "Edit"
        Me.EditButton.UseVisualStyleBackColor = True
        '
        'SimpanButton
        '
        Me.SimpanButton.Enabled = False
        Me.SimpanButton.Location = New System.Drawing.Point(22, 189)
        Me.SimpanButton.Name = "SimpanButton"
        Me.SimpanButton.Size = New System.Drawing.Size(75, 23)
        Me.SimpanButton.TabIndex = 9
        Me.SimpanButton.Text = "Simpan"
        Me.SimpanButton.UseVisualStyleBackColor = True
        '
        'TambahButton
        '
        Me.TambahButton.Location = New System.Drawing.Point(22, 142)
        Me.TambahButton.Name = "TambahButton"
        Me.TambahButton.Size = New System.Drawing.Size(75, 23)
        Me.TambahButton.TabIndex = 8
        Me.TambahButton.Text = "Tambah"
        Me.TambahButton.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.KeluarButton)
        Me.GroupBox1.Controls.Add(Me.RefreshButton)
        Me.GroupBox1.Controls.Add(Me.BatalButton)
        Me.GroupBox1.Controls.Add(Me.HapusButton)
        Me.GroupBox1.Controls.Add(Me.EditButton)
        Me.GroupBox1.Controls.Add(Me.SimpanButton)
        Me.GroupBox1.Controls.Add(Me.TambahButton)
        Me.GroupBox1.Controls.Add(Id_eventLabel)
        Me.GroupBox1.Controls.Add(Me.Id_eventTextBox)
        Me.GroupBox1.Controls.Add(Nama_eventLabel)
        Me.GroupBox1.Controls.Add(Me.Nama_eventTextBox)
        Me.GroupBox1.Controls.Add(WaktuLabel)
        Me.GroupBox1.Controls.Add(Me.WaktuDateTimePicker)
        Me.GroupBox1.Controls.Add(TempatLabel)
        Me.GroupBox1.Controls.Add(Me.TempatTextBox)
        Me.GroupBox1.Location = New System.Drawing.Point(49, 77)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(363, 341)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Event Kejuaraan"
        '
        'Id_eventTextBox
        '
        Me.Id_eventTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Event_kejuaraanBindingSource, "id_event", True))
        Me.Id_eventTextBox.Enabled = False
        Me.Id_eventTextBox.Location = New System.Drawing.Point(91, 22)
        Me.Id_eventTextBox.Name = "Id_eventTextBox"
        Me.Id_eventTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Id_eventTextBox.TabIndex = 1
        '
        'Event_kejuaraanBindingSource
        '
        Me.Event_kejuaraanBindingSource.DataMember = "event_kejuaraan"
        Me.Event_kejuaraanBindingSource.DataSource = Me.Db_disporaDataSet
        '
        'Db_disporaDataSet
        '
        Me.Db_disporaDataSet.DataSetName = "db_disporaDataSet"
        Me.Db_disporaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Nama_eventTextBox
        '
        Me.Nama_eventTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Event_kejuaraanBindingSource, "nama_event", True))
        Me.Nama_eventTextBox.Enabled = False
        Me.Nama_eventTextBox.Location = New System.Drawing.Point(91, 48)
        Me.Nama_eventTextBox.Name = "Nama_eventTextBox"
        Me.Nama_eventTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Nama_eventTextBox.TabIndex = 3
        '
        'WaktuDateTimePicker
        '
        Me.WaktuDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.Event_kejuaraanBindingSource, "waktu", True))
        Me.WaktuDateTimePicker.Enabled = False
        Me.WaktuDateTimePicker.Location = New System.Drawing.Point(91, 74)
        Me.WaktuDateTimePicker.Name = "WaktuDateTimePicker"
        Me.WaktuDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.WaktuDateTimePicker.TabIndex = 5
        '
        'TempatTextBox
        '
        Me.TempatTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Event_kejuaraanBindingSource, "tempat", True))
        Me.TempatTextBox.Enabled = False
        Me.TempatTextBox.Location = New System.Drawing.Point(91, 100)
        Me.TempatTextBox.Name = "TempatTextBox"
        Me.TempatTextBox.Size = New System.Drawing.Size(200, 20)
        Me.TempatTextBox.TabIndex = 7
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "tempat"
        Me.DataGridViewTextBoxColumn4.HeaderText = "tempat"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'Event_kejuaraanTableAdapter
        '
        Me.Event_kejuaraanTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.atletTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.cabang_olahragaTableAdapter = Nothing
        Me.TableAdapterManager.event_kejuaraan_has_cabang_olahragaTableAdapter = Nothing
        Me.TableAdapterManager.event_kejuaraanTableAdapter = Me.Event_kejuaraanTableAdapter
        Me.TableAdapterManager.keuanganTableAdapter = Nothing
        Me.TableAdapterManager.sekretariatTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Dispora2.db_disporaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "waktu"
        Me.DataGridViewTextBoxColumn3.HeaderText = "waktu"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "nama_event"
        Me.DataGridViewTextBoxColumn2.HeaderText = "nama_event"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "id_event"
        Me.DataGridViewTextBoxColumn1.HeaderText = "id_event"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(49, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(244, 33)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Event Kejuaraan"
        '
        'Event_kejuaraanDataGridView
        '
        Me.Event_kejuaraanDataGridView.AutoGenerateColumns = False
        Me.Event_kejuaraanDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Event_kejuaraanDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4})
        Me.Event_kejuaraanDataGridView.DataSource = Me.Event_kejuaraanBindingSource
        Me.Event_kejuaraanDataGridView.Location = New System.Drawing.Point(427, 77)
        Me.Event_kejuaraanDataGridView.Name = "Event_kejuaraanDataGridView"
        Me.Event_kejuaraanDataGridView.Size = New System.Drawing.Size(443, 341)
        Me.Event_kejuaraanDataGridView.TabIndex = 4
        '
        'EventKejuaraan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(918, 455)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Event_kejuaraanDataGridView)
        Me.Name = "EventKejuaraan"
        Me.Text = "EventKejuaraan"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.Event_kejuaraanBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Db_disporaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Event_kejuaraanDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents KeluarButton As System.Windows.Forms.Button
    Friend WithEvents RefreshButton As System.Windows.Forms.Button
    Friend WithEvents BatalButton As System.Windows.Forms.Button
    Friend WithEvents HapusButton As System.Windows.Forms.Button
    Friend WithEvents EditButton As System.Windows.Forms.Button
    Friend WithEvents SimpanButton As System.Windows.Forms.Button
    Friend WithEvents TambahButton As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Id_eventTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Event_kejuaraanBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Db_disporaDataSet As Dispora2.db_disporaDataSet
    Friend WithEvents Nama_eventTextBox As System.Windows.Forms.TextBox
    Friend WithEvents WaktuDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents TempatTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Event_kejuaraanTableAdapter As Dispora2.db_disporaDataSetTableAdapters.event_kejuaraanTableAdapter
    Friend WithEvents TableAdapterManager As Dispora2.db_disporaDataSetTableAdapters.TableAdapterManager
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Event_kejuaraanDataGridView As System.Windows.Forms.DataGridView
End Class
