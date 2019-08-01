Public Class Gorevler
	Dim id As String
	Dim VeriIslemleri As VeriIslemleri = New VeriIslemleri()

	Public Sub New()
		InitializeComponent()
		DataGridView1.DataSource = VeriIslemleri.TabloyaYaz("Gorevler")
		Try
			If DataGridView1.Rows(0).Cells(0).Value IsNot Nothing Then
				id = DataGridView1.Rows(0).Cells(0).Value.ToString()
			End If
		Catch ex As Exception

		End Try
	End Sub

	Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
		Dim GorevEkle As GorevEkle = New GorevEkle()
		GorevEkle.ShowDialog()
		DataGridView1.DataSource = VeriIslemleri.TabloyaYaz("Gorevler")
		DataGridView1.Update()
		Try
			id = DataGridView1.Rows(0).Cells(0).Value.ToString()
		Catch ex As Exception

		End Try
	End Sub

	Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
		If id Is Nothing Then
			MessageBox.Show("Lütfen tablodan düzeltilecek değeri seçiniz!")
		Else
			Dim bilgiler As String() = VeriIslemleri.BilgileriAl("Gorevler", "GorevId", id)
			Dim GorevEkle As GorevEkle = New GorevEkle(bilgiler)
			GorevEkle.ShowDialog()
			DataGridView1.DataSource = VeriIslemleri.TabloyaYaz("Gorevler")
			DataGridView1.Update()
		End If
	End Sub

	Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
		Dim durum As Boolean = False
		If id Is Nothing Then
			MessageBox.Show("Lütfen tablodan silinecek değeri seçiniz!")
		Else
			Dim cevap As DialogResult = MessageBox.Show(id & " Silinecek. Silmek İstediğinize Emin Misiniz?", "Görev Silinecek", MessageBoxButtons.OKCancel)
			If cevap.ToString() Is "OK" Then
				durum = VeriIslemleri.VeriSil("Gorevler", "GorevId", id)
			End If
		End If
		If durum Then
			MessageBox.Show("Silme işlemi başarılı!")
			DataGridView1.DataSource = VeriIslemleri.TabloyaYaz("Gorevler")
			DataGridView1.Update()
		End If
	End Sub

	Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
		id = DataGridView1.CurrentRow.Cells(0).Value
	End Sub
End Class