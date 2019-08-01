Public Class GorevEkle
	Dim gonderen As Boolean
	Dim gn As GorevlerNesnesi
	Dim VeriIslemleri As VeriIslemleri = New VeriIslemleri()

	Public Sub New()
		InitializeComponent()
		gonderen = True
		gn = New GorevlerNesnesi()
		cb_uye.Items.AddRange(VeriIslemleri.Uyeler().ToArray())
	End Sub
	Public Sub New(ByVal kayitlar As String())
		InitializeComponent()
		gonderen = False
		gn = New GorevlerNesnesi()
		cb_uye.Items.AddRange(VeriIslemleri.Uyeler().ToArray())
		gn.GorevId = Convert.ToInt32(kayitlar(0))
		cb_uye.Text = kayitlar(1)
		tb_uyeGorev.Text = kayitlar(2)
	End Sub

	Public Sub GirdiKontrol()
		Try
			gn.Uye = cb_uye.Text
			gn.UyeGorev = tb_uyeGorev.Text
		Catch ex As Exception

		End Try
	End Sub

	Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
		GirdiKontrol()
		If gonderen Then
			If VeriIslemleri.GorevEkle(gn) Then
				MessageBox.Show("Görev Ekleme İşlemi Başarılı!")
				Me.Close()
			End If
		Else
			If VeriIslemleri.GorevDuzenle(gn) Then
				MessageBox.Show("Görev Düzenleme İşlemi Başarılı!")
				Me.Close()
			End If
		End If
	End Sub
End Class