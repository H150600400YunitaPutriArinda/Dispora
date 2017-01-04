<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Sekretariat
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
        Dim NIKLabel As System.Windows.Forms.Label
        Dim Nama_pegawaiLabel As System.Windows.Forms.Label
        Dim AlamatLabel As System.Windows.Forms.Label
        Dim NO_HPLabel As System.Windows.Forms.Label
        Dim Keuangan_id_keuanganLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Sekretariat))
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.batalButton = New System.Windows.Forms.Button()
        Me.keluarButton = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.editButton = New System.Windows.Forms.Button()
        Me.hapusButton = New System.Windows.Forms.Button()
        Me.refreshButton = New System.Windows.Forms.Button()
        Me.NIKTextBox = New System.Windows.Forms.TextBox()
        Me.SekretariatBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Db_disporaDataSet = New Dispora2.db_disporaDataSet()
        Me.Nama_pegawaiTextBox = New System.Windows.Forms.TextBox()
        Me.simpanButton = New System.Windows.Forms.Button()
        Me.tambahButton = New System.Windows.Forms.Button()
        Me.AlamatTextBox = New System.Windows.Forms.TextBox()
        Me.NO_HPTextBox = New System.Windows.Forms.TextBox()
        Me.Keuangan_id_keuanganTextBox = New System.Windows.Forms.TextBox()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cariButton = New System.Windows.Forms.Button()
        Me.cariText = New System.Windows.Forms.TextBox()
        Me.SekretariatTableAdapter = New Dispora2.db_disporaDataSetTableAdapters.sekretariatTableAdapter()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SekretariatDataGridView = New System.Windows.Forms.DataGridView()
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.SekretariatBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.SekretariatBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.TableAdapterManager = New Dispora2.db_disporaDataSetTableAdapters.TableAdapterManager()
        NIKLabel = New System.Windows.Forms.Label()
        Nama_pegawaiLabel = New System.Windows.Forms.Label()
        AlamatLabel = New System.Windows.Forms.Label()
        NO_HPLabel = New System.Windows.Forms.Label()
        Keuangan_id_keuanganLabel = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.SekretariatBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Db_disporaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SekretariatDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SekretariatBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SekretariatBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'NIKLabel
        '
        NIKLabel.AutoSize = True
        NIKLabel.Enabled = False
        NIKLabel.Location = New System.Drawing.Point(13, 27)
        NIKLabel.Name = "NIKLabel"
        NIKLabel.Size = New System.Drawing.Size(28, 13)
        NIKLabel.TabIndex = 0
        NIKLabel.Text = "NIK:"
        '
        'Nama_pegawaiLabel
        '
        Nama_pegawaiLabel.AutoSize = True
        Nama_pegawaiLabel.Enabled = False
        Nama_pegawaiLabel.Location = New System.Drawing.Point(13, 53)
        Nama_pegawaiLabel.Name = "Nama_pegawaiLabel"
        Nama_pegawaiLabel.Size = New System.Drawing.Size(79, 13)
        Nama_pegawaiLabel.TabIndex = 2
        Nama_pegawaiLabel.Text = "nama pegawai:"
        '
        'AlamatLabel
        '
        AlamatLabel.AutoSize = True
        AlamatLabel.Enabled = False
        AlamatLabel.Location = New System.Drawing.Point(13, 79)
        AlamatLabel.Name = "AlamatLabel"
        AlamatLabel.Size = New System.Drawing.Size(41, 13)
        AlamatLabel.TabIndex = 4
        AlamatLabel.Text = "alamat:"
        '
        'NO_HPLabel
        '
        NO_HPLabel.AutoSize = True
        NO_HPLabel.Enabled = False
        NO_HPLabel.Location = New System.Drawing.Point(13, 105)
        NO_HPLabel.Name = "NO_HPLabel"
        NO_HPLabel.Size = New System.Drawing.Size(44, 13)
        NO_HPLabel.TabIndex = 6
        NO_HPLabel.Text = "NO HP:"
        '
        'Keuangan_id_keuanganLabel
        '
        Keuangan_id_keuanganLabel.AutoSize = True
        Keuangan_id_keuanganLabel.Enabled = False
        Keuangan_id_keuanganLabel.Location = New System.Drawing.Point(13, 131)
        Keuangan_id_keuanganLabel.Name = "Keuangan_id_keuanganLabel"
        Keuangan_id_keuanganLabel.Size = New System.Drawing.Size(120, 13)
        Keuangan_id_keuanganLabel.TabIndex = 8
        Keuangan_id_keuanganLabel.Text = "keuangan id keuangan:"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "alamat"
        Me.DataGridViewTextBoxColumn3.HeaderText = "alamat"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'batalButton
        '
        Me.batalButton.Location = New System.Drawing.Point(112, 249)
        Me.batalButton.Name = "batalButton"
        Me.batalButton.Size = New System.Drawing.Size(75, 23)
        Me.batalButton.TabIndex = 24
        Me.batalButton.Text = "BATAL"
        Me.batalButton.UseVisualStyleBackColor = True
        '
        'keluarButton
        '
        Me.keluarButton.Location = New System.Drawing.Point(212, 210)
        Me.keluarButton.Name = "keluarButton"
        Me.keluarButton.Size = New System.Drawing.Size(75, 23)
        Me.keluarButton.TabIndex = 23
        Me.keluarButton.Text = "KELUAR"
        Me.keluarButton.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.batalButton)
        Me.GroupBox1.Controls.Add(Me.keluarButton)
        Me.GroupBox1.Controls.Add(NIKLabel)
        Me.GroupBox1.Controls.Add(Me.editButton)
        Me.GroupBox1.Controls.Add(Me.hapusButton)
        Me.GroupBox1.Controls.Add(Me.refreshButton)
        Me.GroupBox1.Controls.Add(Me.NIKTextBox)
        Me.GroupBox1.Controls.Add(Nama_pegawaiLabel)
        Me.GroupBox1.Controls.Add(Me.Nama_pegawaiTextBox)
        Me.GroupBox1.Controls.Add(Me.simpanButton)
        Me.GroupBox1.Controls.Add(Me.tambahButton)
        Me.GroupBox1.Controls.Add(AlamatLabel)
        Me.GroupBox1.Controls.Add(Me.AlamatTextBox)
        Me.GroupBox1.Controls.Add(NO_HPLabel)
        Me.GroupBox1.Controls.Add(Me.NO_HPTextBox)
        Me.GroupBox1.Controls.Add(Keuangan_id_keuanganLabel)
        Me.GroupBox1.Controls.Add(Me.Keuangan_id_keuanganTextBox)
        Me.GroupBox1.Location = New System.Drawing.Point(42, 54)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(299, 278)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'editButton
        '
        Me.editButton.Location = New System.Drawing.Point(14, 210)
        Me.editButton.Name = "editButton"
        Me.editButton.Size = New System.Drawing.Size(75, 23)
        Me.editButton.TabIndex = 21
        Me.editButton.Text = "EDIT"
        Me.editButton.UseVisualStyleBackColor = True
        '
        'hapusButton
        '
        Me.hapusButton.Location = New System.Drawing.Point(212, 171)
        Me.hapusButton.Name = "hapusButton"
        Me.hapusButton.Size = New System.Drawing.Size(75, 23)
        Me.hapusButton.TabIndex = 22
        Me.hapusButton.Text = "HAPUS"
        Me.hapusButton.UseVisualStyleBackColor = True
        '
        'refreshButton
        '
        Me.refreshButton.Location = New System.Drawing.Point(112, 210)
        Me.refreshButton.Name = "refreshButton"
        Me.refreshButton.Size = New System.Drawing.Size(75, 23)
        Me.refreshButton.TabIndex = 20
        Me.refreshButton.Text = "REFRESH"
        Me.refreshButton.UseVisualStyleBackColor = True
        '
        'NIKTextBox
        '
        Me.NIKTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SekretariatBindingSource, "NIK", True))
        Me.NIKTextBox.Enabled = False
        Me.NIKTextBox.Location = New System.Drawing.Point(139, 24)
        Me.NIKTextBox.Name = "NIKTextBox"
        Me.NIKTextBox.Size = New System.Drawing.Size(100, 20)
        Me.NIKTextBox.TabIndex = 1
        '
        'SekretariatBindingSource
        '
        Me.SekretariatBindingSource.DataMember = "sekretariat"
        Me.SekretariatBindingSource.DataSource = Me.Db_disporaDataSet
        '
        'Db_disporaDataSet
        '
        Me.Db_disporaDataSet.DataSetName = "db_disporaDataSet"
        Me.Db_disporaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Nama_pegawaiTextBox
        '
        Me.Nama_pegawaiTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SekretariatBindingSource, "nama_pegawai", True))
        Me.Nama_pegawaiTextBox.Enabled = False
        Me.Nama_pegawaiTextBox.Location = New System.Drawing.Point(139, 50)
        Me.Nama_pegawaiTextBox.Name = "Nama_pegawaiTextBox"
        Me.Nama_pegawaiTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Nama_pegawaiTextBox.TabIndex = 3
        '
        'simpanButton
        '
        Me.simpanButton.Location = New System.Drawing.Point(112, 171)
        Me.simpanButton.Name = "simpanButton"
        Me.simpanButton.Size = New System.Drawing.Size(75, 23)
        Me.simpanButton.TabIndex = 19
        Me.simpanButton.Text = "SIMPAN"
        Me.simpanButton.UseVisualStyleBackColor = True
        '
        'tambahButton
        '
        Me.tambahButton.Location = New System.Drawing.Point(13, 171)
        Me.tambahButton.Name = "tambahButton"
        Me.tambahButton.Size = New System.Drawing.Size(75, 23)
        Me.tambahButton.TabIndex = 18
        Me.tambahButton.Text = "TAMBAH"
        Me.tambahButton.UseVisualStyleBackColor = True
        '
        'AlamatTextBox
        '
        Me.AlamatTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SekretariatBindingSource, "alamat", True))
        Me.AlamatTextBox.Enabled = False
        Me.AlamatTextBox.Location = New System.Drawing.Point(139, 76)
        Me.AlamatTextBox.Name = "AlamatTextBox"
        Me.AlamatTextBox.Size = New System.Drawing.Size(100, 20)
        Me.AlamatTextBox.TabIndex = 5
        '
        'NO_HPTextBox
        '
        Me.NO_HPTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SekretariatBindingSource, "NO_HP", True))
        Me.NO_HPTextBox.Enabled = False
        Me.NO_HPTextBox.Location = New System.Drawing.Point(139, 102)
        Me.NO_HPTextBox.Name = "NO_HPTextBox"
        Me.NO_HPTextBox.Size = New System.Drawing.Size(100, 20)
        Me.NO_HPTextBox.TabIndex = 7
        '
        'Keuangan_id_keuanganTextBox
        '
        Me.Keuangan_id_keuanganTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SekretariatBindingSource, "keuangan_id_keuangan", True))
        Me.Keuangan_id_keuanganTextBox.Enabled = False
        Me.Keuangan_id_keuanganTextBox.Location = New System.Drawing.Point(139, 128)
        Me.Keuangan_id_keuanganTextBox.Name = "Keuangan_id_keuanganTextBox"
        Me.Keuangan_id_keuanganTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Keuangan_id_keuanganTextBox.TabIndex = 9
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "keuangan_id_keuangan"
        Me.DataGridViewTextBoxColumn5.HeaderText = "keuangan_id_keuangan"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "NO_HP"
        Me.DataGridViewTextBoxColumn4.HeaderText = "NO_HP"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'cariButton
        '
        Me.cariButton.Location = New System.Drawing.Point(683, 51)
        Me.cariButton.Name = "cariButton"
        Me.cariButton.Size = New System.Drawing.Size(75, 23)
        Me.cariButton.TabIndex = 9
        Me.cariButton.Text = "cari"
        Me.cariButton.UseVisualStyleBackColor = True
        '
        'cariText
        '
        Me.cariText.Location = New System.Drawing.Point(347, 54)
        Me.cariText.Name = "cariText"
        Me.cariText.Size = New System.Drawing.Size(330, 20)
        Me.cariText.TabIndex = 8
        Me.cariText.Text = "cari"
        '
        'SekretariatTableAdapter
        '
        Me.SekretariatTableAdapter.ClearBeforeFill = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "nama_pegawai"
        Me.DataGridViewTextBoxColumn2.HeaderText = "nama_pegawai"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "NIK"
        Me.DataGridViewTextBoxColumn1.HeaderText = "NIK"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'SekretariatDataGridView
        '
        Me.SekretariatDataGridView.AutoGenerateColumns = False
        Me.SekretariatDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.SekretariatDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5})
        Me.SekretariatDataGridView.DataSource = Me.SekretariatBindingSource
        Me.SekretariatDataGridView.Location = New System.Drawing.Point(347, 78)
        Me.SekretariatDataGridView.Name = "SekretariatDataGridView"
        Me.SekretariatDataGridView.Size = New System.Drawing.Size(541, 220)
        Me.SekretariatDataGridView.TabIndex = 6
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
        'SekretariatBindingNavigator
        '
        Me.SekretariatBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.SekretariatBindingNavigator.BindingSource = Me.SekretariatBindingSource
        Me.SekretariatBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.SekretariatBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.SekretariatBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.SekretariatBindingNavigatorSaveItem})
        Me.SekretariatBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.SekretariatBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.SekretariatBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.SekretariatBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.SekretariatBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.SekretariatBindingNavigator.Name = "SekretariatBindingNavigator"
        Me.SekretariatBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.SekretariatBindingNavigator.Size = New System.Drawing.Size(947, 25)
        Me.SekretariatBindingNavigator.TabIndex = 5
        Me.SekretariatBindingNavigator.Text = "BindingNavigator1"
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
        'SekretariatBindingNavigatorSaveItem
        '
        Me.SekretariatBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.SekretariatBindingNavigatorSaveItem.Image = CType(resources.GetObject("SekretariatBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.SekretariatBindingNavigatorSaveItem.Name = "SekretariatBindingNavigatorSaveItem"
        Me.SekretariatBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.SekretariatBindingNavigatorSaveItem.Text = "Save Data"
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.atletTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.cabang_olahragaTableAdapter = Nothing
        Me.TableAdapterManager.event_kejuaraan_has_cabang_olahragaTableAdapter = Nothing
        Me.TableAdapterManager.event_kejuaraanTableAdapter = Nothing
        Me.TableAdapterManager.keuanganTableAdapter = Nothing
        Me.TableAdapterManager.sekretariatTableAdapter = Me.SekretariatTableAdapter
        Me.TableAdapterManager.UpdateOrder = Dispora2.db_disporaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Sekretariat
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(947, 443)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.cariButton)
        Me.Controls.Add(Me.cariText)
        Me.Controls.Add(Me.SekretariatDataGridView)
        Me.Controls.Add(Me.SekretariatBindingNavigator)
        Me.Name = "Sekretariat"
        Me.Text = "Sekretariat"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.SekretariatBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Db_disporaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SekretariatDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SekretariatBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SekretariatBindingNavigator.ResumeLayout(False)
        Me.SekretariatBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents batalButton As System.Windows.Forms.Button
    Friend WithEvents keluarButton As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents editButton As System.Windows.Forms.Button
    Friend WithEvents hapusButton As System.Windows.Forms.Button
    Friend WithEvents refreshButton As System.Windows.Forms.Button
    Friend WithEvents NIKTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SekretariatBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Db_disporaDataSet As Dispora2.db_disporaDataSet
    Friend WithEvents Nama_pegawaiTextBox As System.Windows.Forms.TextBox
    Friend WithEvents simpanButton As System.Windows.Forms.Button
    Friend WithEvents tambahButton As System.Windows.Forms.Button
    Friend WithEvents AlamatTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NO_HPTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Keuangan_id_keuanganTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cariButton As System.Windows.Forms.Button
    Friend WithEvents cariText As System.Windows.Forms.TextBox
    Friend WithEvents SekretariatTableAdapter As Dispora2.db_disporaDataSetTableAdapters.sekretariatTableAdapter
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SekretariatDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents SekretariatBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents SekretariatBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents TableAdapterManager As Dispora2.db_disporaDataSetTableAdapters.TableAdapterManager
End Class
