Public Class CbMataKuliah

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Set Judul Form
        Me.Text = "-Form Mahasiswa-"

        ' Inisialisasi DataGridView
        DataGridView1.ColumnCount = 6
        DataGridView1.Columns(0).Name = "NIP"
        DataGridView1.Columns(1).Name = "Nama"
        DataGridView1.Columns(2).Name = "Jenis Kelamin"
        DataGridView1.Columns(3).Name = "Jurusan"
        DataGridView1.Columns(4).Name = "Mata Kuliah"
        DataGridView1.Columns(5).Name = "GRADE"

        ' Pilihan Jurusan
        CbJurusan.Items.Add("Teknik Informatika")
        CbJurusan.Items.Add("Sistem Informasi")
        CbJurusan.Items.Add("Teknik Komputer")
        CbJurusan.Items.Add("Manajemen Informatika")

        ' Pilihan Mata Kuliah
        CbMataKuliah.Items.Add("Algoritma")
        CbMataKuliah.Items.Add("Basis Data")
        CbMataKuliah.Items.Add("Pemrograman Web")
        CbMataKuliah.Items.Add("Jaringan Komputer")
    End Sub

    Private Sub BtnNew_Click(sender As Object, e As EventArgs) Handles BtnNew.Click
        ' Membersihkan Input
        TxtNip.Clear()
        TxtNama.Clear()
        TxtTugas.Clear()
        TxtUTS.Clear()
        TxtUAS.Clear()
        LblGrade.Text = "-GRADE-"
        RbLaki.Checked = False
        RbPerempuan.Checked = False
        CbJurusan.SelectedIndex = -1
        CbMataKuliah.SelectedIndex = -1
    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        ' Mengambil Data dari Form
        Dim nip As String = TxtNip.Text
        Dim nama As String = TxtNama.Text
        Dim jenisKelamin As String = If(RbLaki.Checked, "Laki-Laki", "Perempuan")
        Dim jurusan As String = CbJurusan.Text
        Dim mataKuliah As String = CbMataKuliah.Text
        Dim grade As String = LblGrade.Text

        ' Validasi Input
        If nip = "" Or nama = "" Or jurusan = "" Or mataKuliah = "" Or grade = "-GRADE-" Then
            MessageBox.Show("Pastikan semua data sudah diisi dengan benar!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        ' Menambahkan Data ke DataGridView
        DataGridView1.Rows.Add(nip, nama, jenisKelamin, jurusan, mataKuliah, grade)
    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click
        ' Menghapus Data yang Dipilih
        If DataGridView1.SelectedRows.Count > 0 Then
            DataGridView1.Rows.Remove(DataGridView1.SelectedRows(0))
        Else
            MessageBox.Show("Pilih baris data yang ingin dihapus!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        ' Menutup Aplikasi
        Me.Close()
    End Sub

    Private Sub BtnHitungGrade_Click(sender As Object, e As EventArgs) Handles BtnHitungGrade.Click
        ' Menghitung Grade
        Dim tugas As Integer = Val(TxtTugas.Text)
        Dim uts As Integer = Val(TxtUTS.Text)
        Dim uas As Integer = Val(TxtUAS.Text)
        Dim nilaiAkhir As Double = (tugas * 0.3) + (uts * 0.3) + (uas * 0.4)

        If nilaiAkhir >= 80 Then
            LblGrade.Text = "A"
        ElseIf nilaiAkhir >= 70 Then
            LblGrade.Text = "B"
        ElseIf nilaiAkhir >= 60 Then
            LblGrade.Text = "C"
        ElseIf nilaiAkhir >= 50 Then
            LblGrade.Text = "D"
        Else
            LblGrade.Text = "E"
        End If
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles LblGrade.Click

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles BtnHitungGrade.Click

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click

    End Sub

    Private Sub Button1_Click_2(sender As Object, e As EventArgs) Handles BtnHitungGrade.Click

    End Sub
End Class