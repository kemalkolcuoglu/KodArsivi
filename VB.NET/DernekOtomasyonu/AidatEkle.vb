Public Class AidatEkle
	Dim gonderen As Boolean
	Dim an As AidatNesnesi
	Dim VeriIslemleri As VeriIslemleri = New VeriIslemleri()

	Public Sub New()
		InitializeComponent()
		gonderen = True
		an = New AidatNesnesi()
		cb_uye.Items.AddRange(VeriIslemleri.Uyeler().ToArray())
	End Sub
	Public Sub New(ByVal kayitlar As String())
		InitializeComponent()
		gonderen = False
		an = New AidatNesnesi()
		cb_uye.Items.AddRange(VeriIslemleri.Uyeler().ToArray())
		an.AidatId = Convert.ToInt32(kayitlar(0))
		cb_uye.Text = kayitlar(1)
		tb_aidatTutari.Text = kayitlar(2)
	End Sub

	Public Sub GirdiKontrol()
		Try
			an.Uye = cb_uye.Text
			an.AidatTutari = Convert.ToInt32(tb_aidatTutari.Text)
		Catch ex As Exception

		End Try
	End Sub

	Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
		GirdiKontrol()
		If gonderen Then
			If VeriIslemleri.AidatEkle(an) Then
				MessageBox.Show("Aidat Ekleme İşlemi Başarılı!")
				Me.Close()
			End If
		Else
			If VeriIslemleri.AidatDuzenle(an) Then
				MessageBox.Show("Aidat Düzenleme İşlemi Başarılı!")
				Me.Close()
			End If
		End If
	End Sub
End Class