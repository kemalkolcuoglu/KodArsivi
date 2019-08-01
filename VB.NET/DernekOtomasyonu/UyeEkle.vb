Public Class UyeEkle
	Dim gonderen As Boolean
	Dim un As UyelerNesnesi
	Dim VeriIslemleri As VeriIslemleri = New VeriIslemleri()

	Public Sub New()
		InitializeComponent()
		gonderen = True
		un = New UyelerNesnesi()
	End Sub
	Public Sub New(ByVal kayitlar As String())
		InitializeComponent()
		gonderen = False
		un = New UyelerNesnesi()
		un.UyeId = Convert.ToInt32(kayitlar(0))
		tb_adi.Text = kayitlar(1)
		tb_soyadi.Text = kayitlar(2)
		tb_tckno.Text = kayitlar(3)
		dtp_uyelikTarihi.Text = kayitlar(4)
		cb_aktif.Checked = (If(kayitlar(5) Is "Evet", True, False))
		tb_ikamet.Text = kayitlar(6)
	End Sub

	Public Sub GirdiKontrol()
		Try
			un.UyeAdi = tb_adi.Text
			un.UyeSoyadi = tb_soyadi.Text
			un.TCKNO = tb_tckno.Text
			un.UyelikTarihi = dtp_uyelikTarihi.Value
			un.Aktif = cb_aktif.Checked
			un.Ikamet = tb_ikamet.Text
		Catch ex As Exception

		End Try
	End Sub

	Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
		GirdiKontrol()
		If gonderen Then
			If VeriIslemleri.UyeEkle(un) Then
				MessageBox.Show("Üye Ekleme İşlemi Başarılı!")
				Me.Close()
			End If
		Else
			If VeriIslemleri.UyeDuzenle(un) Then
				MessageBox.Show("Üye Düzenleme İşlemi Başarılı!")
				Me.Close()
			End If
		End If
	End Sub
End Class