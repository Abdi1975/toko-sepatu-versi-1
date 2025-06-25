<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMasterKategori
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormMasterKategori))
        Me.ButtonBatal = New System.Windows.Forms.Button()
        Me.ButtonHapus = New System.Windows.Forms.Button()
        Me.ButtonUbah = New System.Windows.Forms.Button()
        Me.ButtonSimpan = New System.Windows.Forms.Button()
        Me.DataGridViewKategori = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TextBoxNamaKategori = New System.Windows.Forms.TextBox()
        Me.TextBoxKodeKategori = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.DataGridViewKategori, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ButtonBatal
        '
        Me.ButtonBatal.BackColor = System.Drawing.Color.Silver
        Me.ButtonBatal.Location = New System.Drawing.Point(317, 476)
        Me.ButtonBatal.Name = "ButtonBatal"
        Me.ButtonBatal.Size = New System.Drawing.Size(75, 27)
        Me.ButtonBatal.TabIndex = 55
        Me.ButtonBatal.Text = "Batal"
        Me.ButtonBatal.UseVisualStyleBackColor = False
        '
        'ButtonHapus
        '
        Me.ButtonHapus.BackColor = System.Drawing.Color.Red
        Me.ButtonHapus.Location = New System.Drawing.Point(218, 476)
        Me.ButtonHapus.Name = "ButtonHapus"
        Me.ButtonHapus.Size = New System.Drawing.Size(75, 27)
        Me.ButtonHapus.TabIndex = 54
        Me.ButtonHapus.Text = "Hapus"
        Me.ButtonHapus.UseVisualStyleBackColor = False
        '
        'ButtonUbah
        '
        Me.ButtonUbah.BackColor = System.Drawing.Color.Yellow
        Me.ButtonUbah.Location = New System.Drawing.Point(122, 476)
        Me.ButtonUbah.Name = "ButtonUbah"
        Me.ButtonUbah.Size = New System.Drawing.Size(75, 27)
        Me.ButtonUbah.TabIndex = 53
        Me.ButtonUbah.Text = "Ubah"
        Me.ButtonUbah.UseVisualStyleBackColor = False
        '
        'ButtonSimpan
        '
        Me.ButtonSimpan.BackColor = System.Drawing.Color.Lime
        Me.ButtonSimpan.Location = New System.Drawing.Point(29, 476)
        Me.ButtonSimpan.Name = "ButtonSimpan"
        Me.ButtonSimpan.Size = New System.Drawing.Size(75, 27)
        Me.ButtonSimpan.TabIndex = 52
        Me.ButtonSimpan.Text = "Simpan"
        Me.ButtonSimpan.UseVisualStyleBackColor = False
        '
        'DataGridViewKategori
        '
        Me.DataGridViewKategori.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewKategori.Location = New System.Drawing.Point(-3, 238)
        Me.DataGridViewKategori.Name = "DataGridViewKategori"
        Me.DataGridViewKategori.Size = New System.Drawing.Size(420, 233)
        Me.DataGridViewKategori.TabIndex = 51
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TextBoxNamaKategori)
        Me.GroupBox1.Controls.Add(Me.TextBoxKodeKategori)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Location = New System.Drawing.Point(17, 84)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(385, 152)
        Me.GroupBox1.TabIndex = 50
        Me.GroupBox1.TabStop = False
        '
        'TextBoxNamaKategori
        '
        Me.TextBoxNamaKategori.Location = New System.Drawing.Point(105, 83)
        Me.TextBoxNamaKategori.Name = "TextBoxNamaKategori"
        Me.TextBoxNamaKategori.Size = New System.Drawing.Size(245, 20)
        Me.TextBoxNamaKategori.TabIndex = 5
        '
        'TextBoxKodeKategori
        '
        Me.TextBoxKodeKategori.Location = New System.Drawing.Point(105, 44)
        Me.TextBoxKodeKategori.Name = "TextBoxKodeKategori"
        Me.TextBoxKodeKategori.Size = New System.Drawing.Size(245, 20)
        Me.TextBoxKodeKategori.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(15, 86)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(77, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Nama Kategori"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(18, 47)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(74, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Kode Kategori"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(-3, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(420, 82)
        Me.Panel1.TabIndex = 49
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(96, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(228, 39)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Data Kategori"
        '
        'FormMasterKategori
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(415, 508)
        Me.Controls.Add(Me.ButtonBatal)
        Me.Controls.Add(Me.ButtonHapus)
        Me.Controls.Add(Me.ButtonUbah)
        Me.Controls.Add(Me.ButtonSimpan)
        Me.Controls.Add(Me.DataGridViewKategori)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormMasterKategori"
        Me.Text = "FormMasterKategori"
        CType(Me.DataGridViewKategori, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ButtonBatal As Button
    Friend WithEvents ButtonHapus As Button
    Friend WithEvents ButtonUbah As Button
    Friend WithEvents ButtonSimpan As Button
    Friend WithEvents DataGridViewKategori As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TextBoxNamaKategori As TextBox
    Friend WithEvents TextBoxKodeKategori As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
End Class
