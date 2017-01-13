<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Atlet
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Atlet))
        Dim Cabang_olahraga_id_olahragaLabel As System.Windows.Forms.Label
        Dim Sekretariat_keuangan_id_keuanganLabel As System.Windows.Forms.Label
        Dim Sekretariat_NIKLabel As System.Windows.Forms.Label
        Dim NO_HPLabel As System.Windows.Forms.Label
        Dim AlamatLabel As System.Windows.Forms.Label
        Dim Asal_sekolah_PTLabel As System.Windows.Forms.Label
        Dim TTLLabel As System.Windows.Forms.Label
        Dim Nama_atletLabel As System.Windows.Forms.Label
        Dim NIALabel As System.Windows.Forms.Label
        Me.Db_disporaDataSet = New Dispora2.db_disporaDataSet()
        Me.AtletBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AtletTableAdapter = New Dispora2.db_disporaDataSetTableAdapters.atletTableAdapter()
        Me.TableAdapterManager = New Dispora2.db_disporaDataSetTableAdapters.TableAdapterManager()
        Me.AtletBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.AtletBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.AtletDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.BatalButton = New System.Windows.Forms.Button()
        Me.KeluarButton = New System.Windows.Forms.Button()
        Me.RefreshButton = New System.Windows.Forms.Button()
        Me.HapusButton = New System.Windows.Forms.Button()
        Me.EditButton = New System.Windows.Forms.Button()
        Me.SimpanButton = New System.Windows.Forms.Button()
        Me.TambahButton = New System.Windows.Forms.Button()
        Me.cariButton1 = New System.Windows.Forms.Button()
        Me.cariText1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Cabang_olahraga_id_olahragaTextBox = New System.Windows.Forms.TextBox()
        Me.Sekretariat_keuangan_id_keuanganTextBox = New System.Windows.Forms.TextBox()
        Me.Sekretariat_NIKTextBox = New System.Windows.Forms.TextBox()
        Me.NO_HPTextBox = New System.Windows.Forms.TextBox()
        Me.AlamatTextBox = New System.Windows.Forms.TextBox()
        Me.Asal_sekolah_PTTextBox = New System.Windows.Forms.TextBox()
        Me.TTLTextBox = New System.Windows.Forms.TextBox()
        Me.Nama_atletTextBox = New System.Windows.Forms.TextBox()
        Me.NIATextBox = New System.Windows.Forms.TextBox()
        Cabang_olahraga_id_olahragaLabel = New System.Windows.Forms.Label()
        Sekretariat_keuangan_id_keuanganLabel = New System.Windows.Forms.Label()
        Sekretariat_NIKLabel = New System.Windows.Forms.Label()
        NO_HPLabel = New System.Windows.Forms.Label()
        AlamatLabel = New System.Windows.Forms.Label()
        Asal_sekolah_PTLabel = New System.Windows.Forms.Label()
        TTLLabel = New System.Windows.Forms.Label()
        Nama_atletLabel = New System.Windows.Forms.Label()
        NIALabel = New System.Windows.Forms.Label()
        CType(Me.Db_disporaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AtletBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AtletBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.AtletBindingNavigator.SuspendLayout()
        CType(Me.AtletDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Db_disporaDataSet
        '
        Me.Db_disporaDataSet.DataSetName = "db_disporaDataSet"
        Me.Db_disporaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'AtletBindingSource
        '
        Me.AtletBindingSource.DataMember = "atlet"
        Me.AtletBindingSource.DataSource = Me.Db_disporaDataSet
        '
        'AtletTableAdapter
        '
        Me.AtletTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.atletTableAdapter = Me.AtletTableAdapter
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.cabang_olahragaTableAdapter = Nothing
        Me.TableAdapterManager.event_kejuaraan_has_cabang_olahragaTableAdapter = Nothing
        Me.TableAdapterManager.event_kejuaraanTableAdapter = Nothing
        Me.TableAdapterManager.keuanganTableAdapter = Nothing
        Me.TableAdapterManager.sekretariatTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Dispora2.db_disporaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'AtletBindingNavigator
        '
        Me.AtletBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.AtletBindingNavigator.BindingSource = Me.AtletBindingSource
        Me.AtletBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.AtletBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.AtletBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.AtletBindingNavigatorSaveItem})
        Me.AtletBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.AtletBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.AtletBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.AtletBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.AtletBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.AtletBindingNavigator.Name = "AtletBindingNavigator"
        Me.AtletBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.AtletBindingNavigator.Size = New System.Drawing.Size(1290, 25)
        Me.AtletBindingNavigator.TabIndex = 0
        Me.AtletBindingNavigator.Text = "BindingNavigator1"
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
        'AtletBindingNavigatorSaveItem
        '
        Me.AtletBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.AtletBindingNavigatorSaveItem.Image = CType(resources.GetObject("AtletBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.AtletBindingNavigatorSaveItem.Name = "AtletBindingNavigatorSaveItem"
        Me.AtletBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.AtletBindingNavigatorSaveItem.Text = "Save Data"
        '
        'AtletDataGridView
        '
        Me.AtletDataGridView.AutoGenerateColumns = False
        Me.AtletDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.AtletDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9})
        Me.AtletDataGridView.DataSource = Me.AtletBindingSource
        Me.AtletDataGridView.Location = New System.Drawing.Point(327, 57)
        Me.AtletDataGridView.Name = "AtletDataGridView"
        Me.AtletDataGridView.Size = New System.Drawing.Size(951, 220)
        Me.AtletDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "NIA"
        Me.DataGridViewTextBoxColumn1.HeaderText = "NIA"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "nama_atlet"
        Me.DataGridViewTextBoxColumn2.HeaderText = "nama_atlet"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "TTL"
        Me.DataGridViewTextBoxColumn3.HeaderText = "TTL"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "asal_sekolah/PT"
        Me.DataGridViewTextBoxColumn4.HeaderText = "asal_sekolah/PT"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "alamat"
        Me.DataGridViewTextBoxColumn5.HeaderText = "alamat"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "NO_HP"
        Me.DataGridViewTextBoxColumn6.HeaderText = "NO_HP"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "sekretariat_NIK"
        Me.DataGridViewTextBoxColumn7.HeaderText = "sekretariat_NIK"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "sekretariat_keuangan_id_keuangan"
        Me.DataGridViewTextBoxColumn8.HeaderText = "sekretariat_keuangan_id_keuangan"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "cabang_olahraga_id_olahraga"
        Me.DataGridViewTextBoxColumn9.HeaderText = "cabang_olahraga_id_olahraga"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.BatalButton)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.KeluarButton)
        Me.GroupBox1.Controls.Add(NIALabel)
        Me.GroupBox1.Controls.Add(Me.RefreshButton)
        Me.GroupBox1.Controls.Add(Me.NIATextBox)
        Me.GroupBox1.Controls.Add(Me.HapusButton)
        Me.GroupBox1.Controls.Add(Nama_atletLabel)
        Me.GroupBox1.Controls.Add(Me.Nama_atletTextBox)
        Me.GroupBox1.Controls.Add(Me.EditButton)
        Me.GroupBox1.Controls.Add(TTLLabel)
        Me.GroupBox1.Controls.Add(Me.TTLTextBox)
        Me.GroupBox1.Controls.Add(Me.SimpanButton)
        Me.GroupBox1.Controls.Add(Asal_sekolah_PTLabel)
        Me.GroupBox1.Controls.Add(Me.TambahButton)
        Me.GroupBox1.Controls.Add(Me.Asal_sekolah_PTTextBox)
        Me.GroupBox1.Controls.Add(AlamatLabel)
        Me.GroupBox1.Controls.Add(Me.AlamatTextBox)
        Me.GroupBox1.Controls.Add(NO_HPLabel)
        Me.GroupBox1.Controls.Add(Me.NO_HPTextBox)
        Me.GroupBox1.Controls.Add(Sekretariat_NIKLabel)
        Me.GroupBox1.Controls.Add(Me.Sekretariat_NIKTextBox)
        Me.GroupBox1.Controls.Add(Sekretariat_keuangan_id_keuanganLabel)
        Me.GroupBox1.Controls.Add(Me.Sekretariat_keuangan_id_keuanganTextBox)
        Me.GroupBox1.Controls.Add(Cabang_olahraga_id_olahragaLabel)
        Me.GroupBox1.Controls.Add(Me.Cabang_olahraga_id_olahragaTextBox)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 28)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(304, 394)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'BatalButton
        '
        Me.BatalButton.Location = New System.Drawing.Point(103, 347)
        Me.BatalButton.Name = "BatalButton"
        Me.BatalButton.Size = New System.Drawing.Size(75, 23)
        Me.BatalButton.TabIndex = 28
        Me.BatalButton.Text = "Batal"
        Me.BatalButton.UseVisualStyleBackColor = True
        '
        'KeluarButton
        '
        Me.KeluarButton.Location = New System.Drawing.Point(175, 347)
        Me.KeluarButton.Name = "KeluarButton"
        Me.KeluarButton.Size = New System.Drawing.Size(75, 23)
        Me.KeluarButton.TabIndex = 27
        Me.KeluarButton.Text = "Keluar"
        Me.KeluarButton.UseVisualStyleBackColor = True
        '
        'RefreshButton
        '
        Me.RefreshButton.Location = New System.Drawing.Point(32, 347)
        Me.RefreshButton.Name = "RefreshButton"
        Me.RefreshButton.Size = New System.Drawing.Size(75, 23)
        Me.RefreshButton.TabIndex = 26
        Me.RefreshButton.Text = "Refresh"
        Me.RefreshButton.UseVisualStyleBackColor = True
        '
        'HapusButton
        '
        Me.HapusButton.Location = New System.Drawing.Point(175, 304)
        Me.HapusButton.Name = "HapusButton"
        Me.HapusButton.Size = New System.Drawing.Size(75, 23)
        Me.HapusButton.TabIndex = 25
        Me.HapusButton.Text = "Hapus"
        Me.HapusButton.UseVisualStyleBackColor = True
        '
        'EditButton
        '
        Me.EditButton.Location = New System.Drawing.Point(103, 304)
        Me.EditButton.Name = "EditButton"
        Me.EditButton.Size = New System.Drawing.Size(75, 23)
        Me.EditButton.TabIndex = 24
        Me.EditButton.Text = "Edit"
        Me.EditButton.UseVisualStyleBackColor = True
        '
        'SimpanButton
        '
        Me.SimpanButton.Location = New System.Drawing.Point(32, 304)
        Me.SimpanButton.Name = "SimpanButton"
        Me.SimpanButton.Size = New System.Drawing.Size(75, 23)
        Me.SimpanButton.TabIndex = 23
        Me.SimpanButton.Text = "Simpan"
        Me.SimpanButton.UseVisualStyleBackColor = True
        '
        'TambahButton
        '
        Me.TambahButton.Location = New System.Drawing.Point(103, 263)
        Me.TambahButton.Name = "TambahButton"
        Me.TambahButton.Size = New System.Drawing.Size(75, 23)
        Me.TambahButton.TabIndex = 22
        Me.TambahButton.Text = "Tambah"
        Me.TambahButton.UseVisualStyleBackColor = True
        '
        'cariButton1
        '
        Me.cariButton1.Location = New System.Drawing.Point(667, 28)
        Me.cariButton1.Name = "cariButton1"
        Me.cariButton1.Size = New System.Drawing.Size(75, 23)
        Me.cariButton1.TabIndex = 21
        Me.cariButton1.Text = "cari"
        Me.cariButton1.UseVisualStyleBackColor = True
        '
        'cariText1
        '
        Me.cariText1.Location = New System.Drawing.Point(393, 28)
        Me.cariText1.Name = "cariText1"
        Me.cariText1.Size = New System.Drawing.Size(255, 20)
        Me.cariText1.TabIndex = 20
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(-2, -3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 20)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Data Atlet"
        '
        'Cabang_olahraga_id_olahragaTextBox
        '
        Me.Cabang_olahraga_id_olahragaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AtletBindingSource, "cabang_olahraga_id_olahraga", True))
        Me.Cabang_olahraga_id_olahragaTextBox.Location = New System.Drawing.Point(184, 227)
        Me.Cabang_olahraga_id_olahragaTextBox.Name = "Cabang_olahraga_id_olahragaTextBox"
        Me.Cabang_olahraga_id_olahragaTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Cabang_olahraga_id_olahragaTextBox.TabIndex = 17
        '
        'Cabang_olahraga_id_olahragaLabel
        '
        Cabang_olahraga_id_olahragaLabel.AutoSize = True
        Cabang_olahraga_id_olahragaLabel.Location = New System.Drawing.Point(6, 230)
        Cabang_olahraga_id_olahragaLabel.Name = "Cabang_olahraga_id_olahragaLabel"
        Cabang_olahraga_id_olahragaLabel.Size = New System.Drawing.Size(145, 13)
        Cabang_olahraga_id_olahragaLabel.TabIndex = 16
        Cabang_olahraga_id_olahragaLabel.Text = "cabang olahraga id olahraga:"
        '
        'Sekretariat_keuangan_id_keuanganTextBox
        '
        Me.Sekretariat_keuangan_id_keuanganTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AtletBindingSource, "sekretariat_keuangan_id_keuangan", True))
        Me.Sekretariat_keuangan_id_keuanganTextBox.Location = New System.Drawing.Point(184, 201)
        Me.Sekretariat_keuangan_id_keuanganTextBox.Name = "Sekretariat_keuangan_id_keuanganTextBox"
        Me.Sekretariat_keuangan_id_keuanganTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Sekretariat_keuangan_id_keuanganTextBox.TabIndex = 15
        '
        'Sekretariat_keuangan_id_keuanganLabel
        '
        Sekretariat_keuangan_id_keuanganLabel.AutoSize = True
        Sekretariat_keuangan_id_keuanganLabel.Location = New System.Drawing.Point(6, 204)
        Sekretariat_keuangan_id_keuanganLabel.Name = "Sekretariat_keuangan_id_keuanganLabel"
        Sekretariat_keuangan_id_keuanganLabel.Size = New System.Drawing.Size(172, 13)
        Sekretariat_keuangan_id_keuanganLabel.TabIndex = 14
        Sekretariat_keuangan_id_keuanganLabel.Text = "sekretariat keuangan id keuangan:"
        '
        'Sekretariat_NIKTextBox
        '
        Me.Sekretariat_NIKTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AtletBindingSource, "sekretariat_NIK", True))
        Me.Sekretariat_NIKTextBox.Location = New System.Drawing.Point(184, 175)
        Me.Sekretariat_NIKTextBox.Name = "Sekretariat_NIKTextBox"
        Me.Sekretariat_NIKTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Sekretariat_NIKTextBox.TabIndex = 13
        '
        'Sekretariat_NIKLabel
        '
        Sekretariat_NIKLabel.AutoSize = True
        Sekretariat_NIKLabel.Location = New System.Drawing.Point(6, 178)
        Sekretariat_NIKLabel.Name = "Sekretariat_NIKLabel"
        Sekretariat_NIKLabel.Size = New System.Drawing.Size(80, 13)
        Sekretariat_NIKLabel.TabIndex = 12
        Sekretariat_NIKLabel.Text = "sekretariat NIK:"
        '
        'NO_HPTextBox
        '
        Me.NO_HPTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AtletBindingSource, "NO_HP", True))
        Me.NO_HPTextBox.Location = New System.Drawing.Point(184, 149)
        Me.NO_HPTextBox.Name = "NO_HPTextBox"
        Me.NO_HPTextBox.Size = New System.Drawing.Size(100, 20)
        Me.NO_HPTextBox.TabIndex = 11
        '
        'NO_HPLabel
        '
        NO_HPLabel.AutoSize = True
        NO_HPLabel.Location = New System.Drawing.Point(6, 152)
        NO_HPLabel.Name = "NO_HPLabel"
        NO_HPLabel.Size = New System.Drawing.Size(44, 13)
        NO_HPLabel.TabIndex = 10
        NO_HPLabel.Text = "NO HP:"
        '
        'AlamatTextBox
        '
        Me.AlamatTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AtletBindingSource, "alamat", True))
        Me.AlamatTextBox.Location = New System.Drawing.Point(184, 123)
        Me.AlamatTextBox.Name = "AlamatTextBox"
        Me.AlamatTextBox.Size = New System.Drawing.Size(100, 20)
        Me.AlamatTextBox.TabIndex = 9
        '
        'AlamatLabel
        '
        AlamatLabel.AutoSize = True
        AlamatLabel.Location = New System.Drawing.Point(6, 126)
        AlamatLabel.Name = "AlamatLabel"
        AlamatLabel.Size = New System.Drawing.Size(41, 13)
        AlamatLabel.TabIndex = 8
        AlamatLabel.Text = "alamat:"
        '
        'Asal_sekolah_PTTextBox
        '
        Me.Asal_sekolah_PTTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AtletBindingSource, "asal_sekolah/PT", True))
        Me.Asal_sekolah_PTTextBox.Location = New System.Drawing.Point(184, 97)
        Me.Asal_sekolah_PTTextBox.Name = "Asal_sekolah_PTTextBox"
        Me.Asal_sekolah_PTTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Asal_sekolah_PTTextBox.TabIndex = 7
        '
        'Asal_sekolah_PTLabel
        '
        Asal_sekolah_PTLabel.AutoSize = True
        Asal_sekolah_PTLabel.Location = New System.Drawing.Point(6, 100)
        Asal_sekolah_PTLabel.Name = "Asal_sekolah_PTLabel"
        Asal_sekolah_PTLabel.Size = New System.Drawing.Size(88, 13)
        Asal_sekolah_PTLabel.TabIndex = 6
        Asal_sekolah_PTLabel.Text = "asal sekolah/PT:"
        '
        'TTLTextBox
        '
        Me.TTLTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AtletBindingSource, "TTL", True))
        Me.TTLTextBox.Location = New System.Drawing.Point(184, 71)
        Me.TTLTextBox.Name = "TTLTextBox"
        Me.TTLTextBox.Size = New System.Drawing.Size(100, 20)
        Me.TTLTextBox.TabIndex = 5
        '
        'TTLLabel
        '
        TTLLabel.AutoSize = True
        TTLLabel.Location = New System.Drawing.Point(6, 74)
        TTLLabel.Name = "TTLLabel"
        TTLLabel.Size = New System.Drawing.Size(30, 13)
        TTLLabel.TabIndex = 4
        TTLLabel.Text = "TTL:"
        '
        'Nama_atletTextBox
        '
        Me.Nama_atletTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AtletBindingSource, "nama_atlet", True))
        Me.Nama_atletTextBox.Location = New System.Drawing.Point(184, 45)
        Me.Nama_atletTextBox.Name = "Nama_atletTextBox"
        Me.Nama_atletTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Nama_atletTextBox.TabIndex = 3
        '
        'Nama_atletLabel
        '
        Nama_atletLabel.AutoSize = True
        Nama_atletLabel.Location = New System.Drawing.Point(6, 48)
        Nama_atletLabel.Name = "Nama_atletLabel"
        Nama_atletLabel.Size = New System.Drawing.Size(59, 13)
        Nama_atletLabel.TabIndex = 2
        Nama_atletLabel.Text = "nama atlet:"
        '
        'NIATextBox
        '
        Me.NIATextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AtletBindingSource, "NIA", True))
        Me.NIATextBox.Location = New System.Drawing.Point(184, 19)
        Me.NIATextBox.Name = "NIATextBox"
        Me.NIATextBox.Size = New System.Drawing.Size(100, 20)
        Me.NIATextBox.TabIndex = 1
        '
        'NIALabel
        '
        NIALabel.AutoSize = True
        NIALabel.Location = New System.Drawing.Point(6, 22)
        NIALabel.Name = "NIALabel"
        NIALabel.Size = New System.Drawing.Size(28, 13)
        NIALabel.TabIndex = 0
        NIALabel.Text = "NIA:"
        '
        'Atlet
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1290, 434)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.AtletDataGridView)
        Me.Controls.Add(Me.AtletBindingNavigator)
        Me.Controls.Add(Me.cariText1)
        Me.Controls.Add(Me.cariButton1)
        Me.Name = "Atlet"
        Me.Text = "ATLET"
        CType(Me.Db_disporaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AtletBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AtletBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.AtletBindingNavigator.ResumeLayout(False)
        Me.AtletBindingNavigator.PerformLayout()
        CType(Me.AtletDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Db_disporaDataSet As Dispora2.db_disporaDataSet
    Friend WithEvents AtletBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents AtletTableAdapter As Dispora2.db_disporaDataSetTableAdapters.atletTableAdapter
    Friend WithEvents TableAdapterManager As Dispora2.db_disporaDataSetTableAdapters.TableAdapterManager
    Friend WithEvents AtletBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents AtletBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents AtletDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents BatalButton As System.Windows.Forms.Button
    Friend WithEvents KeluarButton As System.Windows.Forms.Button
    Friend WithEvents RefreshButton As System.Windows.Forms.Button
    Friend WithEvents HapusButton As System.Windows.Forms.Button
    Friend WithEvents EditButton As System.Windows.Forms.Button
    Friend WithEvents SimpanButton As System.Windows.Forms.Button
    Friend WithEvents TambahButton As System.Windows.Forms.Button
    Friend WithEvents cariButton1 As System.Windows.Forms.Button
    Friend WithEvents cariText1 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents NIATextBox As System.Windows.Forms.TextBox
    Friend WithEvents Nama_atletTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TTLTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Asal_sekolah_PTTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AlamatTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NO_HPTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Sekretariat_NIKTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Sekretariat_keuangan_id_keuanganTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Cabang_olahraga_id_olahragaTextBox As System.Windows.Forms.TextBox
End Class
