Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Button
Public Class Form1


    Private Sub CheckBoxL_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxL.CheckedChanged
        If CheckBoxL.Checked = True Then
            CheckBoxP.Checked = False

            ' Lanjutkan dengan CheckBox lainnya...
        End If
    End Sub

    Private Sub CheckBoxP_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxP.CheckedChanged
        If CheckBoxP.Checked = True Then
            CheckBoxL.Checked = False

            ' Lanjutkan dengan CheckBox lainnya...
        End If
    End Sub

    Private Sub CheckBoxIslam_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxIslam.CheckedChanged
        If CheckBoxIslam.Checked Then
            CheckBoxKatholik.Checked = False
            CheckBoxKristen.Checked = False
            CheckBoxHindu.Checked = False
            CheckBoxBudha.Checked = False
            CheckBoxlainnya.Checked = False
        End If
    End Sub

    Private Sub CheckBoxKatholik_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxKatholik.CheckedChanged
        If CheckBoxKatholik.Checked Then
            CheckBoxIslam.Checked = False
            CheckBoxKristen.Checked = False
            CheckBoxHindu.Checked = False
            CheckBoxBudha.Checked = False
            CheckBoxlainnya.Checked = False
        End If
    End Sub

    Private Sub CheckBoxKristen_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxKristen.CheckedChanged
        If CheckBoxKristen.Checked Then
            CheckBoxIslam.Checked = False
            CheckBoxKatholik.Checked = False
            CheckBoxHindu.Checked = False
            CheckBoxBudha.Checked = False
            CheckBoxlainnya.Checked = False
        End If
    End Sub

    Private Sub CheckBoxHindu_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxHindu.CheckedChanged
        If CheckBoxHindu.Checked Then
            CheckBoxIslam.Checked = False
            CheckBoxKatholik.Checked = False
            CheckBoxKristen.Checked = False
            CheckBoxBudha.Checked = False
            CheckBoxlainnya.Checked = False
        End If
    End Sub

    Private Sub CheckBoxBudha_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxBudha.CheckedChanged
        If CheckBoxBudha.Checked Then
            CheckBoxIslam.Checked = False
            CheckBoxKatholik.Checked = False
            CheckBoxKristen.Checked = False
            CheckBoxHindu.Checked = False
            CheckBoxlainnya.Checked = False
        End If
    End Sub

    Private Sub CheckBoxlainnya_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxlainnya.CheckedChanged
        If CheckBoxlainnya.Checked Then
            CheckBoxIslam.Checked = False
            CheckBoxKatholik.Checked = False
            CheckBoxKristen.Checked = False
            CheckBoxHindu.Checked = False
            CheckBoxBudha.Checked = False
        End If
    End Sub

    Private Sub CheckBoxKawin_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxKawin.CheckedChanged
        If CheckBoxKawin.Checked Then
            CheckBoxDudaJanda.Checked = False
            CheckBoxBelumKawin.Checked = False
            CheckBoxDibawahUmur.Checked = False
        End If
    End Sub

    Private Sub CheckBoxDudaJanda_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxDudaJanda.CheckedChanged
        If CheckBoxDudaJanda.Checked Then
            CheckBoxKawin.Checked = False
            CheckBoxBelumKawin.Checked = False
            CheckBoxDibawahUmur.Checked = False
        End If
    End Sub

    Private Sub CheckBoxBelumKawin_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxBelumKawin.CheckedChanged
        If CheckBoxBelumKawin.Checked Then
            CheckBoxKawin.Checked = False
            CheckBoxDudaJanda.Checked = False
            CheckBoxDibawahUmur.Checked = False
        End If
    End Sub

    Private Sub CheckBoxDibawahUmur_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxDibawahUmur.CheckedChanged
        If CheckBoxDibawahUmur.Checked Then
            CheckBoxKawin.Checked = False
            CheckBoxDudaJanda.Checked = False
            CheckBoxBelumKawin.Checked = False
        End If
    End Sub

    Private Sub CheckBox10_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxBelumTidakSekolah.CheckedChanged
        If CheckBoxBelumTidakSekolah.Checked Then
            CheckBoxSD.Checked = False
            CheckBoxSLTP.Checked = False
            CheckBoxSLTA.Checked = False
            CheckBoxDiploma.Checked = False
            CheckBoxSarjana.Checked = False
        End If
    End Sub

    Private Sub CheckBoxSd_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxSD.CheckedChanged
        If CheckBoxSD.Checked Then
            CheckBoxBelumTidakSekolah.Checked = False
            CheckBoxSLTP.Checked = False
            CheckBoxSLTA.Checked = False
            CheckBoxDiploma.Checked = False
            CheckBoxSarjana.Checked = False
        End If
    End Sub

    Private Sub CheckBoxSltp_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxSLTP.CheckedChanged
        If CheckBoxSLTP.Checked Then
            CheckBoxBelumTidakSekolah.Checked = False
            CheckBoxSD.Checked = False
            CheckBoxSLTA.Checked = False
            CheckBoxDiploma.Checked = False
            CheckBoxSarjana.Checked = False
        End If
    End Sub

    Private Sub CheckBoxSlta_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxSLTA.CheckedChanged
        If CheckBoxSLTA.Checked Then
            CheckBoxBelumTidakSekolah.Checked = False
            CheckBoxSD.Checked = False
            CheckBoxSLTP.Checked = False
            CheckBoxDiploma.Checked = False
            CheckBoxSarjana.Checked = False
        End If
    End Sub

    Private Sub CheckBoxDiploma_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxDiploma.CheckedChanged
        If CheckBoxDiploma.Checked Then
            CheckBoxBelumTidakSekolah.Checked = False
            CheckBoxSD.Checked = False
            CheckBoxSLTP.Checked = False
            CheckBoxSLTA.Checked = False
            CheckBoxSarjana.Checked = False
        End If
    End Sub

    Private Sub CheckBoxSarjana_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxSarjana.CheckedChanged
        If CheckBoxSarjana.Checked Then
            CheckBoxBelumTidakSekolah.Checked = False
            CheckBoxSD.Checked = False
            CheckBoxSLTP.Checked = False
            CheckBoxSLTA.Checked = False
            CheckBoxDiploma.Checked = False
        End If
    End Sub

    Private Sub CheckBoxSendiri_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxSendiri.CheckedChanged
        If CheckBoxSendiri.Checked = True Then
            CheckBoxInstansi.Checked = False

            ' Lanjutkan dengan CheckBox lainnya...
        End If
    End Sub

    Private Sub CheckBoxInstansi_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxInstansi.CheckedChanged
        If CheckBoxInstansi.Checked = True Then
            CheckBoxSendiri.Checked = False

            ' Lanjutkan dengan CheckBox lainnya...
        End If
    End Sub

    Private Sub CheckBoxIgd_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxIgd.CheckedChanged
        If CheckBoxIgd.Checked Then
            CheckBoxKamarBersalin.Checked = False
            CheckBoxPerinatologi.Checked = False
            CheckBoxLaboratorium.Checked = False
            CheckBoxRadiologi.Checked = False
            CheckBoxPoli.Checked = False
        End If
    End Sub

    Private Sub CheckBoxKamarBersalin_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxKamarBersalin.CheckedChanged
        If CheckBoxKamarBersalin.Checked Then
            CheckBoxIgd.Checked = False
            CheckBoxPerinatologi.Checked = False
            CheckBoxLaboratorium.Checked = False
            CheckBoxRadiologi.Checked = False
            CheckBoxPoli.Checked = False
        End If
    End Sub

    Private Sub CheckBoxPerinatologi_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxPerinatologi.CheckedChanged
        If CheckBoxPerinatologi.Checked Then
            CheckBoxIgd.Checked = False
            CheckBoxKamarBersalin.Checked = False
            CheckBoxLaboratorium.Checked = False
            CheckBoxRadiologi.Checked = False
            CheckBoxPoli.Checked = False
        End If
    End Sub

    Private Sub CheckBoxLaboratorium_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxLaboratorium.CheckedChanged
        If CheckBoxLaboratorium.Checked Then
            CheckBoxIgd.Checked = False
            CheckBoxKamarBersalin.Checked = False
            CheckBoxPerinatologi.Checked = False
            CheckBoxRadiologi.Checked = False
            CheckBoxPoli.Checked = False
        End If
    End Sub

    Private Sub CheckBoxRadiologi_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxRadiologi.CheckedChanged
        If CheckBoxRadiologi.Checked Then
            CheckBoxIgd.Checked = False
            CheckBoxKamarBersalin.Checked = False
            CheckBoxPerinatologi.Checked = False
            CheckBoxLaboratorium.Checked = False
            CheckBoxPoli.Checked = False
        End If
    End Sub

    Private Sub CheckBoxPoli_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxPoli.CheckedChanged
        If CheckBoxPoli.Checked Then
            CheckBoxIgd.Checked = False
            CheckBoxKamarBersalin.Checked = False
            CheckBoxPerinatologi.Checked = False
            CheckBoxLaboratorium.Checked = False
            CheckBoxRadiologi.Checked = False
        End If
    End Sub

    Private Sub ButtonSubmit_Click(sender As Object, e As EventArgs) Handles ButtonSubmit.Click
        Dim message As String = ""

        ' Mengambil nilai dari TextBox dan menambahkannya ke pesan
        message += "Data Pasien" & vbCrLf
        message += "" & vbCrLf
        message += "No Rekam Medis: " & TextBoxNoRekamMedis.Text & vbCrLf
        message += "Nama Lengkap: " & TextBoxNamaLengkap.Text & vbCrLf
        message += "Tempat Tanggal Lahir: " & TextBoxTempat.Text & vbCrLf
        message += "Umur: " & jdtUmur.Value.ToShortDateString() & vbCrLf

        ' Memeriksa apakah CheckBox dipilih dan menambahkannya ke pesan
        If CheckBoxL.Checked Then
            message += "Jenis Kelamin: Laki-Laki" & vbCrLf
        ElseIf CheckBoxP.Checked Then
            message += "Jenis Kelamin: Perempuan" & vbCrLf
        Else
            message += "Jenis Kelamin: Tidak dipilih" & vbCrLf
        End If

        ' Mengambil nilai dari TextBox dan menambahkannya ke pesan
        message += "Alamat: " & TextBoxAlamat.Text & vbCrLf
        message += "RT: " & TextBoxRt.Text & vbCrLf
        message += "RW: " & TextBoxRw.Text & vbCrLf
        message += "Kelurahan: " & TextBoxKel.Text & vbCrLf
        message += "Kecamatan: " & TextBoxKec.Text & vbCrLf
        message += "Kota/Kabupaten: " & TextBoxKotaKab.Text & vbCrLf
        message += "Telepon Rumah: " & TextBoxTelepon.Text & vbCrLf
        message += "Nomer Hp: " & TextBoxHp.Text & vbCrLf



        ' Memeriksa apakah CheckBox Agama Islam dicentang dan menambahkannya ke pesan
        If CheckBoxIslam.Checked Then
            message += "Agama: Islam" & vbCrLf
        End If

        ' Memeriksa apakah CheckBox Agama Katholik dicentang dan menambahkannya ke pesan
        If CheckBoxKatholik.Checked Then
            message += "Agama: Katholik" & vbCrLf
        End If

        ' Memeriksa apakah CheckBox Agama Kristen dicentang dan menambahkannya ke pesan
        If CheckBoxKristen.Checked Then
            message += "Agama: Kristen" & vbCrLf
        End If

        ' Memeriksa apakah CheckBox Agama Hindu dicentang dan menambahkannya ke pesan
        If CheckBoxHindu.Checked Then
            message += "Agama: Hindu" & vbCrLf
        End If

        ' Memeriksa apakah CheckBox Agama Budha dicentang dan menambahkannya ke pesan
        If CheckBoxBudha.Checked Then
            message += "Agama: Budha" & vbCrLf
        End If

        'Mengambil nilai dari TextBox dan menambahkannya ke pesan
        message += "Bahasa Yang Digunakan Sehari-hari: " & TextBoxBahasa.Text & vbCrLf

        ' Memeriksa apakah CheckBox Kawin dicentang dan menambahkannya ke pesan
        If CheckBoxKawin.Checked Then
            message += "Status: Kawin" & vbCrLf
        End If

        ' Memeriksa apakah CheckBox DudaJanda dicentang dan menambahkannya ke pesan
        If CheckBoxDudaJanda.Checked Then
            message += "Status: Duda / Janda" & vbCrLf
        End If

        ' Memeriksa apakah CheckBox Belum Kawin  dicentang dan menambahkannya ke pesan
        If CheckBoxBelumKawin.Checked Then
            message += "Status: Belum Kawin" & vbCrLf
        End If

        ' Memeriksa apakah CheckBox Dibawah Umur dicentang dan menambahkannya ke pesan
        If CheckBoxDibawahUmur.Checked Then
            message += "Status: Dibawah Umur" & vbCrLf
        End If


        ' Memeriksa apakah CheckBox Belum atau Tidak Sekolah dicentang dan menambahkannya ke pesan
        If CheckBoxBelumTidakSekolah.Checked Then
            message += "Pendidikan: Belum Atau Tidak Sekolah" & vbCrLf
        End If

        ' Memeriksa apakah CheckBox Sd  dicentang dan menambahkannya ke pesan
        If CheckBoxSD.Checked Then
            message += "Pendidikan: SD" & vbCrLf
        End If
        ' Memeriksa apakah CheckBox Sltp  dicentang dan menambahkannya ke pesan
        If CheckBoxSLTP.Checked Then
            message += "Pendidikan: SLTP" & vbCrLf
        End If

        ' Memeriksa apakah CheckBox Slta dicentang dan menambahkannya ke pesan
        If CheckBoxSLTA.Checked Then
            message += "Pendidikan: SLTA" & vbCrLf
        End If

        ' Memeriksa apakah CheckBox Diploma dicentang dan menambahkannya ke pesan
        If CheckBoxDiploma.Checked Then
            message += "Pendidikan: Diploma" & vbCrLf
        End If

        ' Memeriksa apakah CheckBox Sarjana dicentang dan menambahkannya ke pesan
        If CheckBoxSarjana.Checked Then
            message += "Pendidikan: Sarjana" & vbCrLf
        End If

        ' Mengambil nilai dari TextBox dan menambahkannya ke pesan
        message += "Pekerjaan: " & TextBoxPekerjaan.Text & vbCrLf
        message += "" & vbCrLf

        ' Mengambil nilai dari TextBox dan menambahkannya ke pesan
        message += "Penanggung Jawab" & vbCrLf
        message += "" & vbCrLf
        message += "Nama Penanggung Jawab: " & TextBoxNama.Text & vbCrLf
        message += "Alamat Penanggung Jawab: " & TextBoxAlamatPenanggungJawab.Text & vbCrLf
        message += "No Telepon Penanggung Jawab: " & TextBoxTeleponPenanggungJawab.Text & vbCrLf
        message += "No Hp Penanggung Jawab: " & TextBoxHpPenanggungJawab.Text & vbCrLf


        ' Memeriksa apakah CheckBox Sendiri dicentang dan menambahkannya ke pesan
        If CheckBoxSendiri.Checked Then
            message += "Pembayaran: Sendiri" & vbCrLf
        End If

        ' Memeriksa apakah CheckBox Instansi dicentang dan menambahkannya ke pesan
        message += "Pembayaran" & vbCrLf
        If CheckBoxInstansi.Checked Then
            message += "Pembayaran: Instansi" & vbCrLf
        End If

        ' Mengambil nilai dari TextBox dan menambahkannya ke pesan
        message += "Instansi Kerja: " & TextBoxInstansiKerja.Text & vbCrLf
        message += "Nama Asuransi: " & TextBoxNamaAsuransi.Text & vbCrLf
        message += "No Asuransi: " & TextBoxNoAsuransi.Text & vbCrLf
        message += "" & vbCrLf
        ' Mengambil nilai dari DateTimePicker dan menambahkannya ke pesan
        message += "" & vbCrLf
        message += "Ringkasan Masuk" & vbCrLf
        message += "" & vbCrLf
        message += "Tanggal Datang: " & TanggalDatang.Value.ToShortDateString() & vbCrLf

        ' Mengambil nilai dari TextBox dan menambahkannya ke pesan
        message += "Jam: " & TextBoxJam.Text & vbCrLf
        message += "Nama Perujuk: " & TextBoxNamaPerujuk.Text & vbCrLf
        message += "Alamat Perujuk: " & TextBoxAlamatPerujuk.Text & vbCrLf
        ' Menampilkan pesan MessageBox


        ' Memeriksa apakah CheckBox IGD  dicentang dan menambahkannya ke pesan
        If CheckBoxIgd.Checked Then
            message += "Unit Yang Dituju: IGD" & vbCrLf
        End If

        ' Memeriksa apakah CheckBox Kamar Bersalin dicentang dan menambahkannya ke pesan
        If CheckBoxKamarBersalin.Checked Then
            message += "Unit Yang Dituju: Kamar Bersalin" & vbCrLf
        End If

        ' Memeriksa apakah CheckBox Perinatologi dicentang dan menambahkannya ke pesan
        If CheckBoxPerinatologi.Checked Then
            message += "Unit Yang Dituju: Perinatologi" & vbCrLf
        End If

        ' Memeriksa apakah CheckBox Labolatorium dicentang dan menambahkannya ke pesan
        If CheckBoxLaboratorium.Checked Then
            message += "Unit Yang Dituju: Labolatorium" & vbCrLf
        End If

        ' Memeriksa apakah CheckBox Radiologi dicentang dan menambahkannya ke pesan
        If CheckBoxRadiologi.Checked Then
            message += "Unit Yang Dituju: Radiologi" & vbCrLf
        End If

        ' Memeriksa apakah CheckBox Labolatorium dicentang dan menambahkannya ke pesan
        If CheckBoxPoli.Checked Then
            message += "Unit Yang Dituju: Poli" & vbCrLf
        End If

        MessageBox.Show(message, "Data Pasien")
    End Sub
End Class

