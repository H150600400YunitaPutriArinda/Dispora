<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Keuangan
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
        Dim Id_keuanganLabel As System.Windows.Forms.Label
        Dim Gaji_karyawanLabel As System.Windows.Forms.Label
        Dim Gaji_atletLabel As System.Windows.Forms.Label
        Dim Pemasukan_kejuaraanLabel As System.Windows.Forms.Label
        Dim Pengeluaran_atletLabel As System.Windows.Forms.Label
        Dim Perlengkapan_kantorLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Keuangan))
        Me.Db_disporaDataSet = New Dispora2.db_disporaDataSet()
        Me.KeuanganBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.KeuanganTableAdapter = New Dispora2.db_disporaDataSetTableAdapters.keuanganTableAdapter()
        Me.TableAdapterManager = New Dispora2.db_disporaDataSetTableAdapters.TableAdapterManager()
        Me.KeuanganBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.KeuanganBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.KeuanganDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.BatalButton = New System.Windows.Forms.Button()
        Me.KeluarButton = New System.Windows.Forms.Button()
        Me.RefreshButton = New System.Windows.Forms.Button()
        Me.EditButton = New System.Windows.Forms.Button()
        Me.SimpanButton = New System.Windows.Forms.Button()
        Me.TambahButton = New System.Windows.Forms.Button()
        Me.Id_keuanganTextBox = New System.Windows.Forms.TextBox()
        Me.Gaji_karyawanTextBox = New System.Windows.Forms.TextBox()
        Me.Gaji_atletTextBox = New System.Windows.Forms.TextBox()
        Me.Pemasukan_kejuaraanTextBox = New System.Windows.Forms.TextBox()
        Me.Pengeluaran_atletTextBox = New System.Windows.Forms.TextBox()
        Me.Perlengkapan_kantorTextBox = New System.Windows.Forms.TextBox()
        Me.cariButton1 = New System.Windows.Forms.Button()
        Me.cariText1 = New System.Windows.Forms.TextBox()
        Me.CariButton = New System.Windows.Forms.Button()
        Me.HapusButton = New System.Windows.Forms.Button()
        Id_keuanganLabel = New System.Windows.Forms.Label()
        Gaji_karyawanLabel = New System.Windows.Forms.Label()
        Gaji_atletLabel = New System.Windows.Forms.Label()
        Pemasukan_kejuaraanLabel = New System.Windows.Forms.Label()
        Pengeluaran_atletLabel = New System.Windows.Forms.Label()
        Perlengkapan_kantorLabel = New System.Windows.Forms.Label()
        CType(Me.Db_disporaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KeuanganBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KeuanganBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KeuanganBindingNavigator.SuspendLayout()
        CType(Me.KeuanganDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Id_keuanganLabel
        '
        Id_keuanganLabel.AutoSize = True
        Id_keuanganLabel.Location = New System.Drawing.Point(14, 34)
        Id_keuanganLabel.Name = "Id_keuanganLabel"
        Id_keuanganLabel.Size = New System.Drawing.Size(69, 13)
        Id_keuanganLabel.TabIndex = 0
        Id_keuanganLabel.Text = "id keuangan:"
        '
        'Gaji_karyawanLabel
        '
        Gaji_karyawanLabel.AutoSize = True
        Gaji_karyawanLabel.Location = New System.Drawing.Point(14, 60)
        Gaji_karyawanLabel.Name = "Gaji_karyawanLabel"
        Gaji_karyawanLabel.Size = New System.Drawing.Size(75, 13)
        Gaji_karyawanLabel.TabIndex = 2
        Gaji_karyawanLabel.Text = "gaji karyawan:"
        '
        'Gaji_atletLabel
        '
        Gaji_atletLabel.AutoSize = True
        Gaji_atletLabel.Location = New System.Drawing.Point(14, 86)
        Gaji_atletLabel.Name = "Gaji_atletLabel"
        Gaji_atletLabel.Size = New System.Drawing.Size(49, 13)
        Gaji_atletLabel.TabIndex = 4
        Gaji_atletLabel.Text = "gaji atlet:"
        '
        'Pemasukan_kejuaraanLabel
        '
        Pemasukan_kejuaraanLabel.AutoSize = True
        Pemasukan_kejuaraanLabel.Location = New System.Drawing.Point(14, 112)
        Pemasukan_kejuaraanLabel.Name = "Pemasukan_kejuaraanLabel"
        Pemasukan_kejuaraanLabel.Size = New System.Drawing.Size(115, 13)
        Pemasukan_kejuaraanLabel.TabIndex = 6
        Pemasukan_kejuaraanLabel.Text = "pemasukan kejuaraan:"
        '
        'Pengeluaran_atletLabel
        '
        Pengeluaran_atletLabel.AutoSize = True
        Pengeluaran_atletLabel.Location = New System.Drawing.Point(14, 138)
        Pengeluaran_atletLabel.Name = "Pengeluaran_atletLabel"
        Pengeluaran_atletLabel.Size = New System.Drawing.Size(92, 13)
        Pengeluaran_atletLabel.TabIndex = 8
        Pengeluaran_atletLabel.Text = "pengeluaran atlet:"
        '
        'Perlengkapan_kantorLabel
        '
        Perlengkapan_kantorLabel.AutoSize = True
        Perlengkapan_kantorLabel.Location = New System.Drawing.Point(14, 164)
        Perlengkapan_kantorLabel.Name = "Perlengkapan_kantorLabel"
        Perlengkapan_kantorLabel.Size = New System.Drawing.Size(108, 13)
        Perlengkapan_kantorLabel.TabIndex = 10
        Perlengkapan_kantorLabel.Text = "perlengkapan kantor:"
        '
        'Db_disporaDataSet
        '
        Me.Db_disporaDataSet.DataSetName = "db_disporaDataSet"
        Me.Db_disporaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'KeuanganBindingSource
        '
        Me.KeuanganBindingSource.DataMember = "keuangan"
        Me.KeuanganBindingSource.DataSource = Me.Db_disporaDataSet
        '
        'KeuanganTableAdapter
        '
        Me.KeuanganTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.atletTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.cabang_olahragaTableAdapter = Nothing
        Me.TableAdapterManager.event_kejuaraan_has_cabang_olahragaTableAdapter = Nothing
        Me.TableAdapterManager.event_kejuaraanTableAdapter = Nothing
        Me.TableAdapterManager.keuanganTableAdapter = Me.KeuanganTableAdapter
        Me.TableAdapterManager.sekretariatTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Dispora2.db_disporaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'KeuanganBindingNavigator
        '
        Me.KeuanganBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.KeuanganBindingNavigator.BindingSource = Me.KeuanganBindingSource
        Me.KeuanganBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.KeuanganBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.KeuanganBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.KeuanganBindingNavigatorSaveItem})
        Me.KeuanganBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.KeuanganBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.KeuanganBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.KeuanganBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.KeuanganBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.KeuanganBindingNavigator.Name = "KeuanganBindingNavigator"
        Me.KeuanganBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.KeuanganBindingNavigator.Size = New System.Drawing.Size(953, 25)
        Me.KeuanganBindingNavigator.TabIndex = 0
        Me.KeuanganBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'KeuanganBindingNavigatorSaveItem
        '
        Me.KeuanganBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.KeuanganBindingNavigatorSaveItem.Image = CType(resources.GetObject("KeuanganBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.KeuanganBindingNavigatorSaveItem.Name = "KeuanganBindingNavigatorSaveItem"
        Me.KeuanganBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.KeuanganBindingNavigatorSaveItem.Text = "Save Data"
        '
        'KeuanganDataGridView
        '
        Me.KeuanganDataGridView.AutoGenerateColumns = False
        Me.KeuanganDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.KeuanganDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6})
        Me.KeuanganDataGridView.DataSource = Me.KeuanganBindingSource
        Me.KeuanganDataGridView.Location = New System.Drawing.Point(280, 68)
        Me.KeuanganDataGridView.Name = "KeuanganDataGridView"
        Me.KeuanganDataGridView.Size = New System.Drawing.Size(661, 358)
        Me.KeuanganDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "id_keuangan"
        Me.DataGridViewTextBoxColumn1.HeaderText = "id_keuangan"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "gaji_karyawan"
        Me.DataGridViewTextBoxColumn2.HeaderText = "gaji_karyawan"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "gaji_atlet"
        Me.DataGridViewTextBoxColumn3.HeaderText = "gaji_atlet"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "pemasukan_kejuaraan"
        Me.DataGridViewTextBoxColumn4.HeaderText = "pemasukan_kejuaraan"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "pengeluaran_atlet"
        Me.DataGridViewTextBoxColumn5.HeaderText = "pengeluaran_atlet"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "perlengkapan_kantor"
        Me.DataGridViewTextBoxColumn6.HeaderText = "perlengkapan_kantor"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.BatalButton)
        Me.GroupBox1.Controls.Add(Me.KeluarButton)
        Me.GroupBox1.Controls.Add(Me.RefreshButton)
        Me.GroupBox1.Controls.Add(Me.HapusButton)
        Me.GroupBox1.Controls.Add(Me.EditButton)
        Me.GroupBox1.Controls.Add(Me.SimpanButton)
        Me.GroupBox1.Controls.Add(Me.TambahButton)
        Me.GroupBox1.Controls.Add(Id_keuanganLabel)
        Me.GroupBox1.Controls.Add(Me.Id_keuanganTextBox)
        Me.GroupBox1.Controls.Add(Gaji_karyawanLabel)
        Me.GroupBox1.Controls.Add(Me.Gaji_karyawanTextBox)
        Me.GroupBox1.Controls.Add(Gaji_atletLabel)
        Me.GroupBox1.Controls.Add(Me.Gaji_atletTextBox)
        Me.GroupBox1.Controls.Add(Pemasukan_kejuaraanLabel)
        Me.GroupBox1.Controls.Add(Me.Pemasukan_kejuaraanTextBox)
        Me.GroupBox1.Controls.Add(Pengeluaran_atletLabel)
        Me.GroupBox1.Controls.Add(Me.Pengeluaran_atletTextBox)
        Me.GroupBox1.Controls.Add(Perlengkapan_kantorLabel)
        Me.GroupBox1.Controls.Add(Me.Perlengkapan_kantorTextBox)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 39)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(251, 347)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Data Keuangan"
        '
        'BatalButton
        '
        Me.BatalButton.Location = New System.Drawing.Point(88, 289)
        Me.BatalButton.Name = "BatalButton"
        Me.BatalButton.Size = New System.Drawing.Size(75, 23)
        Me.BatalButton.TabIndex = 19
        Me.BatalButton.Text = "Batal"
        Me.BatalButton.UseVisualStyleBackColor = True
        '
        'KeluarButton
        '
        Me.KeluarButton.Location = New System.Drawing.Point(160, 289)
        Me.KeluarButton.Name = "KeluarButton"
        Me.KeluarButton.Size = New System.Drawing.Size(75, 23)
        Me.KeluarButton.TabIndex = 18
        Me.KeluarButton.Text = "Keluar"
        Me.KeluarButton.UseVisualStyleBackColor = True
        '
        'RefreshButton
        '
        Me.RefreshButton.Location = New System.Drawing.Point(17, 289)
        Me.RefreshButton.Name = "RefreshButton"
        Me.RefreshButton.Size = New System.Drawing.Size(75, 23)
        Me.RefreshButton.TabIndex = 16
        Me.RefreshButton.Text = "Refresh"
        Me.RefreshButton.UseVisualStyleBackColor = True
        '
        'EditButton
        '
        Me.EditButton.Location = New System.Drawing.Point(88, 246)
        Me.EditButton.Name = "EditButton"
        Me.EditButton.Size = New System.Drawing.Size(75, 23)
        Me.EditButton.TabIndex = 14
        Me.EditButton.Text = "Edit"
        Me.EditButton.UseVisualStyleBackColor = True
        '
        'SimpanButton
        '
        Me.SimpanButton.Location = New System.Drawing.Point(17, 246)
        Me.SimpanButton.Name = "SimpanButton"
        Me.SimpanButton.Size = New System.Drawing.Size(75, 23)
        Me.SimpanButton.TabIndex = 13
        Me.SimpanButton.Text = "Simpan"
        Me.SimpanButton.UseVisualStyleBackColor = True
        '
        'TambahButton
        '
        Me.TambahButton.Location = New System.Drawing.Point(88, 205)
        Me.TambahButton.Name = "TambahButton"
        Me.TambahButton.Size = New System.Drawing.Size(75, 23)
        Me.TambahButton.TabIndex = 12
        Me.TambahButton.Text = "Tambah"
        Me.TambahButton.UseVisualStyleBackColor = True
        '
        'Id_keuanganTextBox
        '
        Me.Id_keuanganTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.KeuanganBindingSource, "id_keuangan", True))
        Me.Id_keuanganTextBox.Location = New System.Drawing.Point(135, 31)
        Me.Id_keuanganTextBox.Name = "Id_keuanganTextBox"
        Me.Id_keuanganTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Id_keuanganTextBox.TabIndex = 1
        '
        'Gaji_karyawanTextBox
        '
        Me.Gaji_karyawanTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.KeuanganBindingSource, "gaji_karyawan", True))
        Me.Gaji_karyawanTextBox.Location = New System.Drawing.Point(135, 57)
        Me.Gaji_karyawanTextBox.Name = "Gaji_karyawanTextBox"
        Me.Gaji_karyawanTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Gaji_karyawanTextBox.TabIndex = 3
        '
        'Gaji_atletTextBox
        '
        Me.Gaji_atletTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.KeuanganBindingSource, "gaji_atlet", True))
        Me.Gaji_atletTextBox.Location = New System.Drawing.Point(135, 83)
        Me.Gaji_atletTextBox.Name = "Gaji_atletTextBox"
        Me.Gaji_atletTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Gaji_atletTextBox.TabIndex = 5
        '
        'Pemasukan_kejuaraanTextBox
        '
        Me.Pemasukan_kejuaraanTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.KeuanganBindingSource, "pemasukan_kejuaraan", True))
        Me.Pemasukan_kejuaraanTextBox.Location = New System.Drawing.Point(135, 109)
        Me.Pemasukan_kejuaraanTextBox.Name = "Pemasukan_kejuaraanTextBox"
        Me.Pemasukan_kejuaraanTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Pemasukan_kejuaraanTextBox.TabIndex = 7
        '
        'Pengeluaran_atletTextBox
        '
        Me.Pengeluaran_atletTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.KeuanganBindingSource, "pengeluaran_atlet", True))
        Me.Pengeluaran_atletTextBox.Location = New System.Drawing.Point(135, 135)
        Me.Pengeluaran_atletTextBox.Name = "Pengeluaran_atletTextBox"
        Me.Pengeluaran_atletTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Pengeluaran_atletTextBox.TabIndex = 9
        '
        'Perlengkapan_kantorTextBox
        '
        Me.Perlengkapan_kantorTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.KeuanganBindingSource, "perlengkapan_kantor", True))
        Me.Perlengkapan_kantorTextBox.Location = New System.Drawing.Point(135, 161)
        Me.Perlengkapan_kantorTextBox.Name = "Perlengkapan_kantorTextBox"
        Me.Perlengkapan_kantorTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Perlengkapan_kantorTextBox.TabIndex = 11
        '
        'cariButton1
        '
        Me.cariButton1.Location = New System.Drawing.Point(543, 39)
        Me.cariButton1.Name = "cariButton1"
        Me.cariButton1.Size = New System.Drawing.Size(75, 23)
        Me.cariButton1.TabIndex = 7
        Me.cariButton1.Text = "cari"
        Me.cariButton1.UseVisualStyleBackColor = True
        '
        'cariText1
        '
        Me.cariText1.Location = New System.Drawing.Point(281, 39)
        Me.cariText1.Name = "cariText1"
        Me.cariText1.Size = New System.Drawing.Size(255, 20)
        Me.cariText1.TabIndex = 6
        '
        'CariButton
        '
        Me.CariButton.Location = New System.Drawing.Point(88, 289)
        Me.CariButton.Name = "CariButton"
        Me.CariButton.Size = New System.Drawing.Size(75, 23)
        Me.CariButton.TabIndex = 17
        Me.CariButton.Text = "Cari"
        Me.CariButton.UseVisualStyleBackColor = True
        '
        'HapusButton
        '
        Me.HapusButton.Location = New System.Drawing.Point(160, 246)
        Me.HapusButton.Name = "HapusButton"
        Me.HapusButton.Size = New System.Drawing.Size(75, 23)
        Me.HapusButton.TabIndex = 15
        Me.HapusButton.Text = "Hapus"
        Me.HapusButton.UseVisualStyleBackColor = True
        '
        'Keuangan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(953, 435)
        Me.Controls.Add(Me.cariButton1)
        Me.Controls.Add(Me.cariText1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.KeuanganDataGridView)
        Me.Controls.Add(Me.KeuanganBindingNavigator)
        Me.Name = "Keuangan"
        Me.Text = "KEUANGAN"
        CType(Me.Db_disporaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KeuanganBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KeuanganBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KeuanganBindingNavigator.ResumeLayout(False)
        Me.KeuanganBindingNavigator.PerformLayout()
        CType(Me.KeuanganDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Db_disporaDataSet As Dispora2.db_disporaDataSet
    Friend WithEvents KeuanganBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents KeuanganTableAdapter As Dispora2.db_disporaDataSetTableAdapters.keuanganTableAdapter
    Friend WithEvents TableAdapterManager As Dispora2.db_disporaDataSetTableAdapters.TableAdapterManager
    Friend WithEvents KeuanganBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents KeuanganBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents KeuanganDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Id_keuanganTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Gaji_karyawanTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Gaji_atletTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Pemasukan_kejuaraanTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Pengeluaran_atletTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Perlengkapan_kantorTextBox As System.Windows.Forms.TextBox
    Friend WithEvents KeluarButton As System.Windows.Forms.Button
    Friend WithEvents RefreshButton As System.Windows.Forms.Button
    Friend WithEvents EditButton As System.Windows.Forms.Button
    Friend WithEvents SimpanButton As System.Windows.Forms.Button
    Friend WithEvents TambahButton As System.Windows.Forms.Button
    Friend WithEvents cariButton1 As System.Windows.Forms.Button
    Friend WithEvents cariText1 As System.Windows.Forms.TextBox
    Friend WithEvents BatalButton As System.Windows.Forms.Button
    Friend WithEvents CariButton As System.Windows.Forms.Button
    Friend WithEvents HapusButton As System.Windows.Forms.Button
End Class
