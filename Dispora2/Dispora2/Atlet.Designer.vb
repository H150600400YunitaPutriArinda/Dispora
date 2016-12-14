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
        Dim NIALabel As System.Windows.Forms.Label
        Dim Nama_atletLabel As System.Windows.Forms.Label
        Dim TTLLabel As System.Windows.Forms.Label
        Dim Asal_sekolah_PTLabel As System.Windows.Forms.Label
        Dim AlamatLabel As System.Windows.Forms.Label
        Dim NO_HPLabel As System.Windows.Forms.Label
        Dim Sekretariat_NIKLabel As System.Windows.Forms.Label
        Dim Sekretariat_keuangan_id_keuanganLabel As System.Windows.Forms.Label
        Dim Cabang_olahraga_id_olahragaLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Atlet))
        Me.Db_disporaDataSet = New Dispora2.db_disporaDataSet()
        Me.AtletBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AtletTableAdapter = New Dispora2.db_disporaDataSetTableAdapters.atletTableAdapter()
        Me.TableAdapterManager = New Dispora2.db_disporaDataSetTableAdapters.TableAdapterManager()
        Me.cariText = New System.Windows.Forms.TextBox()
        Me.cariButton = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.batalButton = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.NIASpinEdit = New DevExpress.XtraEditors.SpinEdit()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.hapusButton = New System.Windows.Forms.Button()
        Me.Nama_atletTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.editButton = New System.Windows.Forms.Button()
        Me.refresButton = New System.Windows.Forms.Button()
        Me.TTLTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Cabang_olahraga_id_olahragaSpinEdit = New DevExpress.XtraEditors.SpinEdit()
        Me.Asal_sekolah_PTTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.Sekretariat_keuangan_id_keuanganSpinEdit = New DevExpress.XtraEditors.SpinEdit()
        Me.AlamatTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.Sekretariat_NIKSpinEdit = New DevExpress.XtraEditors.SpinEdit()
        Me.NO_HPSpinEdit = New DevExpress.XtraEditors.SpinEdit()
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
        NIALabel = New System.Windows.Forms.Label()
        Nama_atletLabel = New System.Windows.Forms.Label()
        TTLLabel = New System.Windows.Forms.Label()
        Asal_sekolah_PTLabel = New System.Windows.Forms.Label()
        AlamatLabel = New System.Windows.Forms.Label()
        NO_HPLabel = New System.Windows.Forms.Label()
        Sekretariat_NIKLabel = New System.Windows.Forms.Label()
        Sekretariat_keuangan_id_keuanganLabel = New System.Windows.Forms.Label()
        Cabang_olahraga_id_olahragaLabel = New System.Windows.Forms.Label()
        CType(Me.Db_disporaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AtletBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.NIASpinEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Nama_atletTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TTLTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Cabang_olahraga_id_olahragaSpinEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Asal_sekolah_PTTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Sekretariat_keuangan_id_keuanganSpinEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AlamatTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Sekretariat_NIKSpinEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NO_HPSpinEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AtletDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AtletBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.AtletBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'NIALabel
        '
        NIALabel.AutoSize = True
        NIALabel.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        NIALabel.Location = New System.Drawing.Point(8, 30)
        NIALabel.Name = "NIALabel"
        NIALabel.Size = New System.Drawing.Size(41, 17)
        NIALabel.TabIndex = 54
        NIALabel.Text = "NIA:"
        '
        'Nama_atletLabel
        '
        Nama_atletLabel.AutoSize = True
        Nama_atletLabel.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Nama_atletLabel.Location = New System.Drawing.Point(6, 56)
        Nama_atletLabel.Name = "Nama_atletLabel"
        Nama_atletLabel.Size = New System.Drawing.Size(80, 17)
        Nama_atletLabel.TabIndex = 56
        Nama_atletLabel.Text = "nama atlet:"
        '
        'TTLLabel
        '
        TTLLabel.AutoSize = True
        TTLLabel.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TTLLabel.Location = New System.Drawing.Point(6, 82)
        TTLLabel.Name = "TTLLabel"
        TTLLabel.Size = New System.Drawing.Size(43, 17)
        TTLLabel.TabIndex = 58
        TTLLabel.Text = "TTL:"
        '
        'Asal_sekolah_PTLabel
        '
        Asal_sekolah_PTLabel.AutoSize = True
        Asal_sekolah_PTLabel.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Asal_sekolah_PTLabel.Location = New System.Drawing.Point(6, 108)
        Asal_sekolah_PTLabel.Name = "Asal_sekolah_PTLabel"
        Asal_sekolah_PTLabel.Size = New System.Drawing.Size(115, 17)
        Asal_sekolah_PTLabel.TabIndex = 60
        Asal_sekolah_PTLabel.Text = "asal sekolah/PT:"
        '
        'AlamatLabel
        '
        AlamatLabel.AutoSize = True
        AlamatLabel.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        AlamatLabel.Location = New System.Drawing.Point(6, 134)
        AlamatLabel.Name = "AlamatLabel"
        AlamatLabel.Size = New System.Drawing.Size(55, 17)
        AlamatLabel.TabIndex = 62
        AlamatLabel.Text = "alamat:"
        '
        'NO_HPLabel
        '
        NO_HPLabel.AutoSize = True
        NO_HPLabel.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        NO_HPLabel.Location = New System.Drawing.Point(6, 160)
        NO_HPLabel.Name = "NO_HPLabel"
        NO_HPLabel.Size = New System.Drawing.Size(61, 17)
        NO_HPLabel.TabIndex = 64
        NO_HPLabel.Text = "NO HP:"
        '
        'Sekretariat_NIKLabel
        '
        Sekretariat_NIKLabel.AutoSize = True
        Sekretariat_NIKLabel.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Sekretariat_NIKLabel.Location = New System.Drawing.Point(6, 186)
        Sekretariat_NIKLabel.Name = "Sekretariat_NIKLabel"
        Sekretariat_NIKLabel.Size = New System.Drawing.Size(118, 17)
        Sekretariat_NIKLabel.TabIndex = 66
        Sekretariat_NIKLabel.Text = "sekretariat NIK:"
        '
        'Sekretariat_keuangan_id_keuanganLabel
        '
        Sekretariat_keuangan_id_keuanganLabel.AutoSize = True
        Sekretariat_keuangan_id_keuanganLabel.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Sekretariat_keuangan_id_keuanganLabel.Location = New System.Drawing.Point(6, 212)
        Sekretariat_keuangan_id_keuanganLabel.Name = "Sekretariat_keuangan_id_keuanganLabel"
        Sekretariat_keuangan_id_keuanganLabel.Size = New System.Drawing.Size(235, 17)
        Sekretariat_keuangan_id_keuanganLabel.TabIndex = 68
        Sekretariat_keuangan_id_keuanganLabel.Text = "sekretariat keuangan id keuangan:"
        '
        'Cabang_olahraga_id_olahragaLabel
        '
        Cabang_olahraga_id_olahragaLabel.AutoSize = True
        Cabang_olahraga_id_olahragaLabel.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Cabang_olahraga_id_olahragaLabel.Location = New System.Drawing.Point(6, 238)
        Cabang_olahraga_id_olahragaLabel.Name = "Cabang_olahraga_id_olahragaLabel"
        Cabang_olahraga_id_olahragaLabel.Size = New System.Drawing.Size(192, 17)
        Cabang_olahraga_id_olahragaLabel.TabIndex = 70
        Cabang_olahraga_id_olahragaLabel.Text = "cabang olahraga id olahraga:"
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
        'cariText
        '
        Me.cariText.Location = New System.Drawing.Point(382, 98)
        Me.cariText.Name = "cariText"
        Me.cariText.Size = New System.Drawing.Size(343, 20)
        Me.cariText.TabIndex = 28
        '
        'cariButton
        '
        Me.cariButton.Location = New System.Drawing.Point(731, 96)
        Me.cariButton.Name = "cariButton"
        Me.cariButton.Size = New System.Drawing.Size(75, 23)
        Me.cariButton.TabIndex = 29
        Me.cariButton.Text = "Cari"
        Me.cariButton.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.batalButton)
        Me.GroupBox1.Controls.Add(Sekretariat_NIKLabel)
        Me.GroupBox1.Controls.Add(NIALabel)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.NIASpinEdit)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Nama_atletLabel)
        Me.GroupBox1.Controls.Add(Me.hapusButton)
        Me.GroupBox1.Controls.Add(Me.Nama_atletTextEdit)
        Me.GroupBox1.Controls.Add(Me.editButton)
        Me.GroupBox1.Controls.Add(TTLLabel)
        Me.GroupBox1.Controls.Add(Me.refresButton)
        Me.GroupBox1.Controls.Add(Me.TTLTextEdit)
        Me.GroupBox1.Controls.Add(Me.Button3)
        Me.GroupBox1.Controls.Add(Asal_sekolah_PTLabel)
        Me.GroupBox1.Controls.Add(Me.Cabang_olahraga_id_olahragaSpinEdit)
        Me.GroupBox1.Controls.Add(Me.Asal_sekolah_PTTextEdit)
        Me.GroupBox1.Controls.Add(Cabang_olahraga_id_olahragaLabel)
        Me.GroupBox1.Controls.Add(AlamatLabel)
        Me.GroupBox1.Controls.Add(Me.Sekretariat_keuangan_id_keuanganSpinEdit)
        Me.GroupBox1.Controls.Add(Me.AlamatTextEdit)
        Me.GroupBox1.Controls.Add(Sekretariat_keuangan_id_keuanganLabel)
        Me.GroupBox1.Controls.Add(NO_HPLabel)
        Me.GroupBox1.Controls.Add(Me.Sekretariat_NIKSpinEdit)
        Me.GroupBox1.Controls.Add(Me.NO_HPSpinEdit)
        Me.GroupBox1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(13, 79)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(363, 385)
        Me.GroupBox1.TabIndex = 30
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "DATA ATLET"
        '
        'batalButton
        '
        Me.batalButton.Location = New System.Drawing.Point(276, 319)
        Me.batalButton.Name = "batalButton"
        Me.batalButton.Size = New System.Drawing.Size(75, 23)
        Me.batalButton.TabIndex = 72
        Me.batalButton.Text = "BATAL"
        Me.batalButton.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(25, 278)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(93, 23)
        Me.Button1.TabIndex = 48
        Me.Button1.Text = "TAMBAH"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'NIASpinEdit
        '
        Me.NIASpinEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.AtletBindingSource, "NIA", True))
        Me.NIASpinEdit.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.NIASpinEdit.Location = New System.Drawing.Point(251, 30)
        Me.NIASpinEdit.Name = "NIASpinEdit"
        Me.NIASpinEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.NIASpinEdit.Size = New System.Drawing.Size(100, 20)
        Me.NIASpinEdit.TabIndex = 55
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(136, 278)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(98, 23)
        Me.Button2.TabIndex = 49
        Me.Button2.Text = "SIMPAN"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'hapusButton
        '
        Me.hapusButton.Location = New System.Drawing.Point(251, 278)
        Me.hapusButton.Name = "hapusButton"
        Me.hapusButton.Size = New System.Drawing.Size(75, 23)
        Me.hapusButton.TabIndex = 50
        Me.hapusButton.Text = "HAPUS"
        Me.hapusButton.UseVisualStyleBackColor = True
        '
        'Nama_atletTextEdit
        '
        Me.Nama_atletTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.AtletBindingSource, "nama_atlet", True))
        Me.Nama_atletTextEdit.Location = New System.Drawing.Point(251, 56)
        Me.Nama_atletTextEdit.Name = "Nama_atletTextEdit"
        Me.Nama_atletTextEdit.Size = New System.Drawing.Size(100, 20)
        Me.Nama_atletTextEdit.TabIndex = 57
        '
        'editButton
        '
        Me.editButton.Location = New System.Drawing.Point(6, 319)
        Me.editButton.Name = "editButton"
        Me.editButton.Size = New System.Drawing.Size(75, 23)
        Me.editButton.TabIndex = 51
        Me.editButton.Text = "EDIT"
        Me.editButton.UseVisualStyleBackColor = True
        '
        'refresButton
        '
        Me.refresButton.Location = New System.Drawing.Point(83, 319)
        Me.refresButton.Name = "refresButton"
        Me.refresButton.Size = New System.Drawing.Size(97, 23)
        Me.refresButton.TabIndex = 52
        Me.refresButton.Text = "REFRESH"
        Me.refresButton.UseVisualStyleBackColor = True
        '
        'TTLTextEdit
        '
        Me.TTLTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.AtletBindingSource, "TTL", True))
        Me.TTLTextEdit.Location = New System.Drawing.Point(251, 82)
        Me.TTLTextEdit.Name = "TTLTextEdit"
        Me.TTLTextEdit.Size = New System.Drawing.Size(100, 20)
        Me.TTLTextEdit.TabIndex = 59
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(182, 319)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(93, 23)
        Me.Button3.TabIndex = 53
        Me.Button3.Text = "KELUAR"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Cabang_olahraga_id_olahragaSpinEdit
        '
        Me.Cabang_olahraga_id_olahragaSpinEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.AtletBindingSource, "cabang_olahraga_id_olahraga", True))
        Me.Cabang_olahraga_id_olahragaSpinEdit.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.Cabang_olahraga_id_olahragaSpinEdit.Location = New System.Drawing.Point(251, 238)
        Me.Cabang_olahraga_id_olahragaSpinEdit.Name = "Cabang_olahraga_id_olahragaSpinEdit"
        Me.Cabang_olahraga_id_olahragaSpinEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Cabang_olahraga_id_olahragaSpinEdit.Size = New System.Drawing.Size(100, 20)
        Me.Cabang_olahraga_id_olahragaSpinEdit.TabIndex = 71
        '
        'Asal_sekolah_PTTextEdit
        '
        Me.Asal_sekolah_PTTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.AtletBindingSource, "asal_sekolah/PT", True))
        Me.Asal_sekolah_PTTextEdit.Location = New System.Drawing.Point(251, 108)
        Me.Asal_sekolah_PTTextEdit.Name = "Asal_sekolah_PTTextEdit"
        Me.Asal_sekolah_PTTextEdit.Size = New System.Drawing.Size(100, 20)
        Me.Asal_sekolah_PTTextEdit.TabIndex = 61
        '
        'Sekretariat_keuangan_id_keuanganSpinEdit
        '
        Me.Sekretariat_keuangan_id_keuanganSpinEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.AtletBindingSource, "sekretariat_keuangan_id_keuangan", True))
        Me.Sekretariat_keuangan_id_keuanganSpinEdit.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.Sekretariat_keuangan_id_keuanganSpinEdit.Location = New System.Drawing.Point(251, 212)
        Me.Sekretariat_keuangan_id_keuanganSpinEdit.Name = "Sekretariat_keuangan_id_keuanganSpinEdit"
        Me.Sekretariat_keuangan_id_keuanganSpinEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Sekretariat_keuangan_id_keuanganSpinEdit.Size = New System.Drawing.Size(100, 20)
        Me.Sekretariat_keuangan_id_keuanganSpinEdit.TabIndex = 69
        '
        'AlamatTextEdit
        '
        Me.AlamatTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.AtletBindingSource, "alamat", True))
        Me.AlamatTextEdit.Location = New System.Drawing.Point(251, 134)
        Me.AlamatTextEdit.Name = "AlamatTextEdit"
        Me.AlamatTextEdit.Size = New System.Drawing.Size(100, 20)
        Me.AlamatTextEdit.TabIndex = 63
        '
        'Sekretariat_NIKSpinEdit
        '
        Me.Sekretariat_NIKSpinEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.AtletBindingSource, "sekretariat_NIK", True))
        Me.Sekretariat_NIKSpinEdit.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.Sekretariat_NIKSpinEdit.Location = New System.Drawing.Point(251, 186)
        Me.Sekretariat_NIKSpinEdit.Name = "Sekretariat_NIKSpinEdit"
        Me.Sekretariat_NIKSpinEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Sekretariat_NIKSpinEdit.Size = New System.Drawing.Size(100, 20)
        Me.Sekretariat_NIKSpinEdit.TabIndex = 67
        '
        'NO_HPSpinEdit
        '
        Me.NO_HPSpinEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.AtletBindingSource, "NO_HP", True))
        Me.NO_HPSpinEdit.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.NO_HPSpinEdit.Location = New System.Drawing.Point(251, 160)
        Me.NO_HPSpinEdit.Name = "NO_HPSpinEdit"
        Me.NO_HPSpinEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.NO_HPSpinEdit.Size = New System.Drawing.Size(100, 20)
        Me.NO_HPSpinEdit.TabIndex = 65
        '
        'AtletDataGridView
        '
        Me.AtletDataGridView.AutoGenerateColumns = False
        Me.AtletDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.AtletDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9})
        Me.AtletDataGridView.DataSource = Me.AtletBindingSource
        Me.AtletDataGridView.Location = New System.Drawing.Point(382, 124)
        Me.AtletDataGridView.Name = "AtletDataGridView"
        Me.AtletDataGridView.Size = New System.Drawing.Size(952, 305)
        Me.AtletDataGridView.TabIndex = 30
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
        Me.AtletBindingNavigator.Size = New System.Drawing.Size(1346, 25)
        Me.AtletBindingNavigator.TabIndex = 31
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
        'Atlet
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1346, 476)
        Me.Controls.Add(Me.AtletBindingNavigator)
        Me.Controls.Add(Me.AtletDataGridView)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.cariButton)
        Me.Controls.Add(Me.cariText)
        Me.Name = "Atlet"
        Me.Text = "Atlet"
        CType(Me.Db_disporaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AtletBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.NIASpinEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Nama_atletTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TTLTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Cabang_olahraga_id_olahragaSpinEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Asal_sekolah_PTTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Sekretariat_keuangan_id_keuanganSpinEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AlamatTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Sekretariat_NIKSpinEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NO_HPSpinEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AtletDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AtletBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.AtletBindingNavigator.ResumeLayout(False)
        Me.AtletBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Db_disporaDataSet As Dispora2.db_disporaDataSet
    Friend WithEvents AtletBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents AtletTableAdapter As Dispora2.db_disporaDataSetTableAdapters.atletTableAdapter
    Friend WithEvents TableAdapterManager As Dispora2.db_disporaDataSetTableAdapters.TableAdapterManager
    Friend WithEvents cariText As System.Windows.Forms.TextBox
    Friend WithEvents cariButton As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents batalButton As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents NIASpinEdit As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents hapusButton As System.Windows.Forms.Button
    Friend WithEvents Nama_atletTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents editButton As System.Windows.Forms.Button
    Friend WithEvents refresButton As System.Windows.Forms.Button
    Friend WithEvents TTLTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Cabang_olahraga_id_olahragaSpinEdit As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents Asal_sekolah_PTTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Sekretariat_keuangan_id_keuanganSpinEdit As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents AlamatTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Sekretariat_NIKSpinEdit As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents NO_HPSpinEdit As DevExpress.XtraEditors.SpinEdit
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
End Class
