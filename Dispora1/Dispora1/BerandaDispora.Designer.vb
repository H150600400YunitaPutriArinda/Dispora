﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BerandaDispora
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BerandaDispora))
        Me.EventKejuaraanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WelcomeLabel = New System.Windows.Forms.Label()
        Me.KeuanganToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CabangOlahragaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SekretariatToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AtletToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.ServerDataToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.PROFILEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'EventKejuaraanToolStripMenuItem
        '
        Me.EventKejuaraanToolStripMenuItem.Name = "EventKejuaraanToolStripMenuItem"
        Me.EventKejuaraanToolStripMenuItem.Size = New System.Drawing.Size(234, 26)
        Me.EventKejuaraanToolStripMenuItem.Text = "Event Kejuaraan"
        '
        'WelcomeLabel
        '
        Me.WelcomeLabel.AutoSize = True
        Me.WelcomeLabel.BackColor = System.Drawing.Color.White
        Me.WelcomeLabel.Font = New System.Drawing.Font("Lucida Calligraphy", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WelcomeLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.WelcomeLabel.Location = New System.Drawing.Point(136, 192)
        Me.WelcomeLabel.Name = "WelcomeLabel"
        Me.WelcomeLabel.Size = New System.Drawing.Size(658, 31)
        Me.WelcomeLabel.TabIndex = 3
        Me.WelcomeLabel.Text = "Welcome To Our Project ""DISPORA"" Database "
        '
        'KeuanganToolStripMenuItem
        '
        Me.KeuanganToolStripMenuItem.Name = "KeuanganToolStripMenuItem"
        Me.KeuanganToolStripMenuItem.Size = New System.Drawing.Size(234, 26)
        Me.KeuanganToolStripMenuItem.Text = "Keuangan"
        '
        'CabangOlahragaToolStripMenuItem
        '
        Me.CabangOlahragaToolStripMenuItem.Name = "CabangOlahragaToolStripMenuItem"
        Me.CabangOlahragaToolStripMenuItem.Size = New System.Drawing.Size(234, 26)
        Me.CabangOlahragaToolStripMenuItem.Text = "Cabang Olahraga"
        '
        'SekretariatToolStripMenuItem
        '
        Me.SekretariatToolStripMenuItem.Name = "SekretariatToolStripMenuItem"
        Me.SekretariatToolStripMenuItem.Size = New System.Drawing.Size(234, 26)
        Me.SekretariatToolStripMenuItem.Text = "Sekretariat"
        '
        'AtletToolStripMenuItem
        '
        Me.AtletToolStripMenuItem.Name = "AtletToolStripMenuItem"
        Me.AtletToolStripMenuItem.Size = New System.Drawing.Size(234, 26)
        Me.AtletToolStripMenuItem.Text = "Atlet"
        '
        'Timer1
        '
        Me.Timer1.Interval = 50
        '
        'ServerDataToolStripMenuItem
        '
        Me.ServerDataToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AtletToolStripMenuItem, Me.CabangOlahragaToolStripMenuItem, Me.EventKejuaraanToolStripMenuItem, Me.KeuanganToolStripMenuItem, Me.SekretariatToolStripMenuItem})
        Me.ServerDataToolStripMenuItem.Font = New System.Drawing.Font("Footlight MT Light", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ServerDataToolStripMenuItem.ForeColor = System.Drawing.Color.Teal
        Me.ServerDataToolStripMenuItem.Name = "ServerDataToolStripMenuItem"
        Me.ServerDataToolStripMenuItem.Size = New System.Drawing.Size(153, 26)
        Me.ServerDataToolStripMenuItem.Text = "ENTITAS DATA"
        '
        'Timer2
        '
        Me.Timer2.Interval = 50
        '
        'PROFILEToolStripMenuItem
        '
        Me.PROFILEToolStripMenuItem.Font = New System.Drawing.Font("Footlight MT Light", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PROFILEToolStripMenuItem.ForeColor = System.Drawing.Color.Teal
        Me.PROFILEToolStripMenuItem.Name = "PROFILEToolStripMenuItem"
        Me.PROFILEToolStripMenuItem.Size = New System.Drawing.Size(93, 26)
        Me.PROFILEToolStripMenuItem.Text = "PROFILE"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ServerDataToolStripMenuItem, Me.PROFILEToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(899, 30)
        Me.MenuStrip1.TabIndex = 4
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'BerandaDispora
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(899, 491)
        Me.Controls.Add(Me.WelcomeLabel)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Name = "BerandaDispora"
        Me.Text = "BERANDA DISPORA"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents EventKejuaraanToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents WelcomeLabel As System.Windows.Forms.Label
    Friend WithEvents KeuanganToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CabangOlahragaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SekretariatToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AtletToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents ServerDataToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents PROFILEToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
End Class
