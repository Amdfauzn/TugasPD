<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CbMataKuliah
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
        Me.Txtnip = New System.Windows.Forms.TextBox()
        Me.Txtnama = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BtnNew = New System.Windows.Forms.Button()
        Me.Btsave = New System.Windows.Forms.Button()
        Me.Btdelete = New System.Windows.Forms.Button()
        Me.Btnclose = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.NIP = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nama = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Alamat = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.CbJurusan = New System.Windows.Forms.ComboBox()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.BtnHitungGrade = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Txtnip
        '
        Me.Txtnip.Location = New System.Drawing.Point(267, 26)
        Me.Txtnip.Name = "Txtnip"
        Me.Txtnip.Size = New System.Drawing.Size(299, 26)
        Me.Txtnip.TabIndex = 0
        '
        'Txtnama
        '
        Me.Txtnama.Location = New System.Drawing.Point(267, 66)
        Me.Txtnama.Name = "Txtnama"
        Me.Txtnama.Size = New System.Drawing.Size(380, 26)
        Me.Txtnama.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(21, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 20)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "NIP"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(21, 66)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 20)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Nama"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(21, 167)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 20)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Jurusan"
        '
        'BtnNew
        '
        Me.BtnNew.Location = New System.Drawing.Point(46, 340)
        Me.BtnNew.Name = "BtnNew"
        Me.BtnNew.Size = New System.Drawing.Size(112, 34)
        Me.BtnNew.TabIndex = 6
        Me.BtnNew.Text = "New"
        Me.BtnNew.UseVisualStyleBackColor = True
        '
        'Btsave
        '
        Me.Btsave.Location = New System.Drawing.Point(194, 340)
        Me.Btsave.Name = "Btsave"
        Me.Btsave.Size = New System.Drawing.Size(100, 34)
        Me.Btsave.TabIndex = 7
        Me.Btsave.Text = "Save"
        Me.Btsave.UseVisualStyleBackColor = True
        '
        'Btdelete
        '
        Me.Btdelete.Location = New System.Drawing.Point(327, 340)
        Me.Btdelete.Name = "Btdelete"
        Me.Btdelete.Size = New System.Drawing.Size(97, 34)
        Me.Btdelete.TabIndex = 8
        Me.Btdelete.Text = "Delete"
        Me.Btdelete.UseVisualStyleBackColor = True
        '
        'Btnclose
        '
        Me.Btnclose.BackColor = System.Drawing.Color.LightCoral
        Me.Btnclose.Location = New System.Drawing.Point(462, 340)
        Me.Btnclose.Name = "Btnclose"
        Me.Btnclose.Size = New System.Drawing.Size(391, 34)
        Me.Btnclose.TabIndex = 9
        Me.Btnclose.Text = "Close"
        Me.Btnclose.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NIP, Me.Nama, Me.Alamat})
        Me.DataGridView1.Location = New System.Drawing.Point(46, 432)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 28
        Me.DataGridView1.Size = New System.Drawing.Size(542, 219)
        Me.DataGridView1.TabIndex = 10
        '
        'NIP
        '
        Me.NIP.FillWeight = 150.0!
        Me.NIP.HeaderText = "NIP"
        Me.NIP.Name = "NIP"
        Me.NIP.Width = 150
        '
        'Nama
        '
        Me.Nama.HeaderText = "Nama"
        Me.Nama.Name = "Nama"
        Me.Nama.Width = 150
        '
        'Alamat
        '
        Me.Alamat.HeaderText = "Alamat"
        Me.Alamat.Name = "Alamat"
        Me.Alamat.Width = 200
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(20, 110)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(106, 20)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Jenis Kelamin"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(21, 218)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(88, 20)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "MataKuliah"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(21, 269)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(38, 20)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Nilai"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(216, 275)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(53, 20)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Tugas"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(275, 272)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(90, 26)
        Me.TextBox2.TabIndex = 16
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(430, 272)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(90, 26)
        Me.TextBox3.TabIndex = 18
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(371, 278)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(53, 20)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "Tugas"
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(594, 275)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(90, 26)
        Me.TextBox4.TabIndex = 20
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(535, 278)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(53, 20)
        Me.Label9.TabIndex = 19
        Me.Label9.Text = "Tugas"
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(275, 109)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(98, 24)
        Me.CheckBox1.TabIndex = 21
        Me.CheckBox1.Text = "Laki-Laki"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Location = New System.Drawing.Point(449, 109)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(117, 24)
        Me.CheckBox2.TabIndex = 22
        Me.CheckBox2.Text = "Perempuan"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'CbJurusan
        '
        Me.CbJurusan.FormattingEnabled = True
        Me.CbJurusan.Location = New System.Drawing.Point(275, 164)
        Me.CbJurusan.Name = "CbJurusan"
        Me.CbJurusan.Size = New System.Drawing.Size(372, 28)
        Me.CbJurusan.TabIndex = 23
        '
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(275, 210)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(372, 28)
        Me.ComboBox2.TabIndex = 24
        '
        'BtnHitungGrade
        '
        Me.BtnHitungGrade.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.BtnHitungGrade.Location = New System.Drawing.Point(715, 270)
        Me.BtnHitungGrade.Name = "BtnHitungGrade"
        Me.BtnHitungGrade.Size = New System.Drawing.Size(92, 37)
        Me.BtnHitungGrade.TabIndex = 25
        Me.BtnHitungGrade.Text = "-GRADE-"
        Me.BtnHitungGrade.UseVisualStyleBackColor = False
        '
        'CbMataKuliah
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1295, 831)
        Me.Controls.Add(Me.BtnHitungGrade)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.CbJurusan)
        Me.Controls.Add(Me.CheckBox2)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Btnclose)
        Me.Controls.Add(Me.Btdelete)
        Me.Controls.Add(Me.Btsave)
        Me.Controls.Add(Me.BtnNew)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Txtnama)
        Me.Controls.Add(Me.Txtnip)
        Me.Name = "CbMataKuliah"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Txtnip As System.Windows.Forms.TextBox
    Friend WithEvents Txtnama As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents BtnNew As System.Windows.Forms.Button
    Friend WithEvents Btsave As System.Windows.Forms.Button
    Friend WithEvents Btdelete As System.Windows.Forms.Button
    Friend WithEvents Btnclose As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents NIP As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Nama As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Alamat As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox2 As System.Windows.Forms.CheckBox
    Friend WithEvents CbJurusan As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents BtnHitungGrade As System.Windows.Forms.Button

End Class
