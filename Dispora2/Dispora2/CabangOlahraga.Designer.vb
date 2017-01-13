<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CabangOlahraga
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
        Dim Id_olahragaLabel As System.Windows.Forms.Label
        Dim Nama_olahragaLabel As System.Windows.Forms.Label
        Dim KelasLabel As System.Windows.Forms.Label
        Dim Kelompok_usiaLabel As System.Windows.Forms.Label
        Dim Nama_induk_organisasiLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CabangOlahraga))
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cabang_olahragaTableAdapter = New Dispora2.db_disporaDataSetTableAdapters.cabang_olahragaTableAdapter()
        Me.Cabang_olahragaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Db_disporaDataSet = New Dispora2.db_disporaDataSet()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.KeluarButton = New System.Windows.Forms.Button()
        Me.RefreshButton = New System.Windows.Forms.Button()
        Me.BatalButton = New System.Windows.Forms.Button()
        Me.HapusButton = New System.Windows.Forms.Button()
        Me.EditButton = New System.Windows.Forms.Button()
        Me.SimpanButton = New System.Windows.Forms.Button()
        Me.TambahButton = New System.Windows.Forms.Button()
        Me.Id_olahragaTextBox = New System.Windows.Forms.TextBox()
        Me.Nama_olahragaTextBox = New System.Windows.Forms.TextBox()
        Me.KelasTextBox = New System.Windows.Forms.TextBox()
        Me.Kelompok_usiaTextBox = New System.Windows.Forms.TextBox()
        Me.Nama_induk_organisasiTextBox = New System.Windows.Forms.TextBox()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TableAdapterManager = New Dispora2.db_disporaDataSetTableAdapters.TableAdapterManager()
        Me.Cabang_olahragaDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cariButton1 = New System.Windows.Forms.Button()
        Me.cariText1 = New System.Windows.Forms.TextBox()
        Id_olahragaLabel = New System.Windows.Forms.Label()
        Nama_olahragaLabel = New System.Windows.Forms.Label()
        KelasLabel = New System.Windows.Forms.Label()
        Kelompok_usiaLabel = New System.Windows.Forms.Label()
        Nama_induk_organisasiLabel = New System.Windows.Forms.Label()
        CType(Me.Cabang_olahragaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Db_disporaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.Cabang_olahragaDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Id_olahragaLabel
        '
        Id_olahragaLabel.AutoSize = True
        Id_olahragaLabel.Location = New System.Drawing.Point(28, 39)
        Id_olahragaLabel.Name = "Id_olahragaLabel"
        Id_olahragaLabel.Size = New System.Drawing.Size(62, 13)
        Id_olahragaLabel.TabIndex = 0
        Id_olahragaLabel.Text = "id olahraga:"
        '
        'Nama_olahragaLabel
        '
        Nama_olahragaLabel.AutoSize = True
        Nama_olahragaLabel.Location = New System.Drawing.Point(28, 65)
        Nama_olahragaLabel.Name = "Nama_olahragaLabel"
        Nama_olahragaLabel.Size = New System.Drawing.Size(80, 13)
        Nama_olahragaLabel.TabIndex = 2
        Nama_olahragaLabel.Text = "nama olahraga:"
        '
        'KelasLabel
        '
        KelasLabel.AutoSize = True
        KelasLabel.Location = New System.Drawing.Point(28, 91)
        KelasLabel.Name = "KelasLabel"
        KelasLabel.Size = New System.Drawing.Size(35, 13)
        KelasLabel.TabIndex = 4
        KelasLabel.Text = "kelas:"
        '
        'Kelompok_usiaLabel
        '
        Kelompok_usiaLabel.AutoSize = True
        Kelompok_usiaLabel.Location = New System.Drawing.Point(28, 117)
        Kelompok_usiaLabel.Name = "Kelompok_usiaLabel"
        Kelompok_usiaLabel.Size = New System.Drawing.Size(78, 13)
        Kelompok_usiaLabel.TabIndex = 6
        Kelompok_usiaLabel.Text = "kelompok usia:"
        '
        'Nama_induk_organisasiLabel
        '
        Nama_induk_organisasiLabel.AutoSize = True
        Nama_induk_organisasiLabel.Location = New System.Drawing.Point(28, 143)
        Nama_induk_organisasiLabel.Name = "Nama_induk_organisasiLabel"
        Nama_induk_organisasiLabel.Size = New System.Drawing.Size(115, 13)
        Nama_induk_organisasiLabel.TabIndex = 8
        Nama_induk_organisasiLabel.Text = "nama induk organisasi:"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "nama_induk_organisasi"
        Me.DataGridViewTextBoxColumn5.HeaderText = "nama_induk_organisasi"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'Cabang_olahragaTableAdapter
        '
        Me.Cabang_olahragaTableAdapter.ClearBeforeFill = True
        '
        'Cabang_olahragaBindingSource
        '
        Me.Cabang_olahragaBindingSource.DataMember = "cabang_olahraga"
        Me.Cabang_olahragaBindingSource.DataSource = Me.Db_disporaDataSet
        '
        'Db_disporaDataSet
        '
        Me.Db_disporaDataSet.DataSetName = "db_disporaDataSet"
        Me.Db_disporaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(18, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(259, 33)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Cabang Olahraga"
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
        Me.GroupBox1.Controls.Add(Id_olahragaLabel)
        Me.GroupBox1.Controls.Add(Me.Id_olahragaTextBox)
        Me.GroupBox1.Controls.Add(Nama_olahragaLabel)
        Me.GroupBox1.Controls.Add(Me.Nama_olahragaTextBox)
        Me.GroupBox1.Controls.Add(KelasLabel)
        Me.GroupBox1.Controls.Add(Me.KelasTextBox)
        Me.GroupBox1.Controls.Add(Kelompok_usiaLabel)
        Me.GroupBox1.Controls.Add(Me.Kelompok_usiaTextBox)
        Me.GroupBox1.Controls.Add(Nama_induk_organisasiLabel)
        Me.GroupBox1.Controls.Add(Me.Nama_induk_organisasiTextBox)
        Me.GroupBox1.Location = New System.Drawing.Point(19, 52)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(366, 337)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Cabang Olahraga"
        '
        'KeluarButton
        '
        Me.KeluarButton.Location = New System.Drawing.Point(149, 260)
        Me.KeluarButton.Name = "KeluarButton"
        Me.KeluarButton.Size = New System.Drawing.Size(75, 25)
        Me.KeluarButton.TabIndex = 16
        Me.KeluarButton.Text = "Keluar"
        Me.KeluarButton.UseVisualStyleBackColor = True
        '
        'RefreshButton
        '
        Me.RefreshButton.Location = New System.Drawing.Point(274, 217)
        Me.RefreshButton.Name = "RefreshButton"
        Me.RefreshButton.Size = New System.Drawing.Size(75, 25)
        Me.RefreshButton.TabIndex = 15
        Me.RefreshButton.Text = "Refresh"
        Me.RefreshButton.UseVisualStyleBackColor = True
        '
        'BatalButton
        '
        Me.BatalButton.Enabled = False
        Me.BatalButton.Location = New System.Drawing.Point(274, 175)
        Me.BatalButton.Name = "BatalButton"
        Me.BatalButton.Size = New System.Drawing.Size(75, 25)
        Me.BatalButton.TabIndex = 14
        Me.BatalButton.Text = "Batal"
        Me.BatalButton.UseVisualStyleBackColor = True
        '
        'HapusButton
        '
        Me.HapusButton.Location = New System.Drawing.Point(149, 217)
        Me.HapusButton.Name = "HapusButton"
        Me.HapusButton.Size = New System.Drawing.Size(75, 25)
        Me.HapusButton.TabIndex = 13
        Me.HapusButton.Text = "Hapus"
        Me.HapusButton.UseVisualStyleBackColor = True
        '
        'EditButton
        '
        Me.EditButton.Location = New System.Drawing.Point(149, 175)
        Me.EditButton.Name = "EditButton"
        Me.EditButton.Size = New System.Drawing.Size(75, 25)
        Me.EditButton.TabIndex = 12
        Me.EditButton.Text = "Edit"
        Me.EditButton.UseVisualStyleBackColor = True
        '
        'SimpanButton
        '
        Me.SimpanButton.Enabled = False
        Me.SimpanButton.Location = New System.Drawing.Point(15, 217)
        Me.SimpanButton.Name = "SimpanButton"
        Me.SimpanButton.Size = New System.Drawing.Size(75, 25)
        Me.SimpanButton.TabIndex = 11
        Me.SimpanButton.Text = "Simpan"
        Me.SimpanButton.UseVisualStyleBackColor = True
        '
        'TambahButton
        '
        Me.TambahButton.Location = New System.Drawing.Point(15, 175)
        Me.TambahButton.Name = "TambahButton"
        Me.TambahButton.Size = New System.Drawing.Size(75, 25)
        Me.TambahButton.TabIndex = 10
        Me.TambahButton.Text = "Tambah"
        Me.TambahButton.UseVisualStyleBackColor = True
        '
        'Id_olahragaTextBox
        '
        Me.Id_olahragaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Cabang_olahragaBindingSource, "id_olahraga", True))
        Me.Id_olahragaTextBox.Enabled = False
        Me.Id_olahragaTextBox.Location = New System.Drawing.Point(149, 36)
        Me.Id_olahragaTextBox.Name = "Id_olahragaTextBox"
        Me.Id_olahragaTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Id_olahragaTextBox.TabIndex = 1
        '
        'Nama_olahragaTextBox
        '
        Me.Nama_olahragaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Cabang_olahragaBindingSource, "nama_olahraga", True))
        Me.Nama_olahragaTextBox.Enabled = False
        Me.Nama_olahragaTextBox.Location = New System.Drawing.Point(149, 62)
        Me.Nama_olahragaTextBox.Name = "Nama_olahragaTextBox"
        Me.Nama_olahragaTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Nama_olahragaTextBox.TabIndex = 3
        '
        'KelasTextBox
        '
        Me.KelasTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Cabang_olahragaBindingSource, "kelas", True))
        Me.KelasTextBox.Enabled = False
        Me.KelasTextBox.Location = New System.Drawing.Point(149, 88)
        Me.KelasTextBox.Name = "KelasTextBox"
        Me.KelasTextBox.Size = New System.Drawing.Size(100, 20)
        Me.KelasTextBox.TabIndex = 5
        '
        'Kelompok_usiaTextBox
        '
        Me.Kelompok_usiaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Cabang_olahragaBindingSource, "kelompok_usia", True))
        Me.Kelompok_usiaTextBox.Enabled = False
        Me.Kelompok_usiaTextBox.Location = New System.Drawing.Point(149, 114)
        Me.Kelompok_usiaTextBox.Name = "Kelompok_usiaTextBox"
        Me.Kelompok_usiaTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Kelompok_usiaTextBox.TabIndex = 7
        '
        'Nama_induk_organisasiTextBox
        '
        Me.Nama_induk_organisasiTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Cabang_olahragaBindingSource, "nama_induk_organisasi", True))
        Me.Nama_induk_organisasiTextBox.Enabled = False
        Me.Nama_induk_organisasiTextBox.Location = New System.Drawing.Point(149, 143)
        Me.Nama_induk_organisasiTextBox.Name = "Nama_induk_organisasiTextBox"
        Me.Nama_induk_organisasiTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Nama_induk_organisasiTextBox.TabIndex = 9
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "kelompok_usia"
        Me.DataGridViewTextBoxColumn4.HeaderText = "kelompok_usia"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "kelas"
        Me.DataGridViewTextBoxColumn3.HeaderText = "kelas"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "nama_olahraga"
        Me.DataGridViewTextBoxColumn2.HeaderText = "nama_olahraga"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.atletTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.cabang_olahragaTableAdapter = Me.Cabang_olahragaTableAdapter
        Me.TableAdapterManager.event_kejuaraan_has_cabang_olahragaTableAdapter = Nothing
        Me.TableAdapterManager.event_kejuaraanTableAdapter = Nothing
        Me.TableAdapterManager.keuanganTableAdapter = Nothing
        Me.TableAdapterManager.sekretariatTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Dispora2.db_disporaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Cabang_olahragaDataGridView
        '
        Me.Cabang_olahragaDataGridView.AutoGenerateColumns = False
        Me.Cabang_olahragaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Cabang_olahragaDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5})
        Me.Cabang_olahragaDataGridView.DataSource = Me.Cabang_olahragaBindingSource
        Me.Cabang_olahragaDataGridView.Location = New System.Drawing.Point(391, 52)
        Me.Cabang_olahragaDataGridView.Name = "Cabang_olahragaDataGridView"
        Me.Cabang_olahragaDataGridView.Size = New System.Drawing.Size(544, 337)
        Me.Cabang_olahragaDataGridView.TabIndex = 4
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "id_olahraga"
        Me.DataGridViewTextBoxColumn1.HeaderText = "id_olahraga"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'cariButton1
        '
        Me.cariButton1.Location = New System.Drawing.Point(653, 12)
        Me.cariButton1.Name = "cariButton1"
        Me.cariButton1.Size = New System.Drawing.Size(75, 23)
        Me.cariButton1.TabIndex = 9
        Me.cariButton1.Text = "cari"
        Me.cariButton1.UseVisualStyleBackColor = True
        '
        'cariText1
        '
        Me.cariText1.Location = New System.Drawing.Point(391, 12)
        Me.cariText1.Name = "cariText1"
        Me.cariText1.Size = New System.Drawing.Size(255, 20)
        Me.cariText1.TabIndex = 8
        '
        'CabangOlahraga
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(947, 462)
        Me.Controls.Add(Me.cariButton1)
        Me.Controls.Add(Me.cariText1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Cabang_olahragaDataGridView)
        Me.Name = "CabangOlahraga"
        Me.Text = "CabangOlahraga"
        CType(Me.Cabang_olahragaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Db_disporaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.Cabang_olahragaDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Cabang_olahragaTableAdapter As Dispora2.db_disporaDataSetTableAdapters.cabang_olahragaTableAdapter
    Friend WithEvents Cabang_olahragaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Db_disporaDataSet As Dispora2.db_disporaDataSet
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents KeluarButton As System.Windows.Forms.Button
    Friend WithEvents RefreshButton As System.Windows.Forms.Button
    Friend WithEvents BatalButton As System.Windows.Forms.Button
    Friend WithEvents HapusButton As System.Windows.Forms.Button
    Friend WithEvents EditButton As System.Windows.Forms.Button
    Friend WithEvents SimpanButton As System.Windows.Forms.Button
    Friend WithEvents TambahButton As System.Windows.Forms.Button
    Friend WithEvents Id_olahragaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Nama_olahragaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents KelasTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Kelompok_usiaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Nama_induk_organisasiTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TableAdapterManager As Dispora2.db_disporaDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Cabang_olahragaDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cariButton1 As System.Windows.Forms.Button
    Friend WithEvents cariText1 As System.Windows.Forms.TextBox
End Class
