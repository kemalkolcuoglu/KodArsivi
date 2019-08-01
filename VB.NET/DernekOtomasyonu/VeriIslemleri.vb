Public Class VeriIslemleri
	Private con As OleDb.OleDbConnection = New OleDb.OleDbConnection("Provider = Microsoft.Jet.OLEDB.4.0; Data Source = .\\..\\..\\Dernek.mdb")

	Function BilgileriGetir(ByVal veritabani As String) As OleDb.OleDbDataAdapter
		Dim da As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter("Select * From " & veritabani, con)
		Return da
	End Function

	Function TabloyaYaz(ByVal veritabani As String) As DataTable
		Dim dt As DataTable = New DataTable()
		Try
			BilgileriGetir(veritabani).Fill(dt)
			Return dt
		Catch
			Return Nothing
		End Try
	End Function

	Private Function Sorgu(ByVal cmd As OleDb.OleDbCommand) As Boolean
		Try
			If con.State = ConnectionState.Closed Then
				con.Open()
			End If
			Dim etki As Integer = cmd.ExecuteNonQuery()
			If con.State = ConnectionState.Open Then
				con.Close()
			End If
			Return (If(etki > 0, True, False))
		Catch ex As Exception
			Return False
		End Try
	End Function

	Function UyeEkle(ByVal Uye As UyelerNesnesi) As Boolean
		Dim cmd As OleDb.OleDbCommand = New OleDb.OleDbCommand("Insert Into Uyeler(UyeAdi, UyeSoyadi, TCKNO, UyelikTarihi, AktifUye, IkametAdresi) Values (@s1, @s2, @s3, @s4, @s5, @s6)", con)

		cmd.Parameters.AddWithValue("@s1", Uye.UyeAdi)
		cmd.Parameters.AddWithValue("@s2", Uye.UyeSoyadi)
		cmd.Parameters.AddWithValue("@s3", Uye.TCKNO)
		cmd.Parameters.AddWithValue("@s4", Uye.UyelikTarihi)
		cmd.Parameters.AddWithValue("@s5", Uye.Aktif)
		cmd.Parameters.AddWithValue("@s6", Uye.Ikamet)

		Return Sorgu(cmd)
	End Function

	Function AidatEkle(ByVal Aidat As AidatNesnesi) As Boolean
		Dim cmd As OleDb.OleDbCommand = New OleDb.OleDbCommand("Insert Into Aidat(Uye, AidatTutari) Values (@s1, @s2)", con)

		cmd.Parameters.AddWithValue("@s1", Aidat.Uye)
		cmd.Parameters.AddWithValue("@s2", Aidat.AidatTutari)

		Return Sorgu(cmd)
	End Function

	Function GorevEkle(ByVal Gorev As GorevlerNesnesi) As Boolean
		Dim cmd As OleDb.OleDbCommand = New OleDb.OleDbCommand("Insert Into Gorevler(Uye, UyeGorev) Values (@s1, @s2)", con)

		cmd.Parameters.AddWithValue("@s1", Gorev.Uye)
		cmd.Parameters.AddWithValue("@s2", Gorev.UyeGorev)

		Return Sorgu(cmd)
	End Function

	Function UyeDuzenle(ByVal Uye As UyelerNesnesi) As Boolean
		Dim cmd As OleDb.OleDbCommand = New OleDb.OleDbCommand("Update Uyeler Set UyeAdi = @s1, UyeSoyadi = @s2, TCKNO = @s3, UyelikTarihi = @s4, AktifUye = @s5, IkametAdresi = @s6 Where UyeId = @s7", con)

		cmd.Parameters.AddWithValue("@s1", Uye.UyeAdi)
		cmd.Parameters.AddWithValue("@s2", Uye.UyeSoyadi)
		cmd.Parameters.AddWithValue("@s3", Uye.TCKNO)
		cmd.Parameters.AddWithValue("@s4", Uye.UyelikTarihi)
		cmd.Parameters.AddWithValue("@s5", Uye.Aktif)
		cmd.Parameters.AddWithValue("@s6", Uye.Ikamet)
		cmd.Parameters.AddWithValue("@s7", Uye.UyeId)

		Return Sorgu(cmd)
	End Function

	Function AidatDuzenle(ByVal Aidat As AidatNesnesi) As Boolean
		Dim cmd As OleDb.OleDbCommand = New OleDb.OleDbCommand("Update Aidat Set Uye = @s1, AidatTutari = @s2 Where AidatId = @s3", con)

		cmd.Parameters.AddWithValue("@s1", Aidat.Uye)
		cmd.Parameters.AddWithValue("@s2", Aidat.AidatTutari)
		cmd.Parameters.AddWithValue("@s3", Aidat.AidatId)

		Return Sorgu(cmd)
	End Function

	Function GorevDuzenle(ByVal Gorev As GorevlerNesnesi) As Boolean
		Dim cmd As OleDb.OleDbCommand = New OleDb.OleDbCommand("Update Gorevler Set Uye = @s1, UyeGorev = @s2 Where GorevId = @s3", con)

		cmd.Parameters.AddWithValue("@s1", Gorev.Uye)
		cmd.Parameters.AddWithValue("@s2", Gorev.UyeGorev)
		cmd.Parameters.AddWithValue("@s2", Gorev.GorevId)

		Return Sorgu(cmd)
	End Function

	Function VeriSil(ByVal veritabani As String, ByVal id As Integer, ByVal silinecek As String) As Boolean
		Dim s As String = "Delete From " & veritabani + " Where " & id & " = " & silinecek
		Dim cmd As OleDb.OleDbCommand = New OleDb.OleDbCommand(s, con)
		Return Sorgu(cmd)
	End Function

	Function BilgileriAl(ByVal veritabani, ByVal istenen, ByVal aranan) As String()
		Dim cmd As OleDb.OleDbCommand
		Dim bilgiler As String() = New String(10) {}
		cmd = New OleDb.OleDbCommand("Select * From " & veritabani & " Where " & istenen & " = " & aranan, con)
		Try
			con.Open()
			Dim dr As OleDb.OleDbDataReader = cmd.ExecuteReader()
			While dr.Read()
				For i = 0 To 10
					bilgiler(i) = dr(i).ToString()
				Next
			End While
		Catch ex As Exception
			Console.WriteLine(ex.Message)
		Finally
			con.Close()
		End Try
		Return bilgiler
	End Function

	Function Uyeler() As List(Of String)
		Dim uyeListesi As List(Of String) = New List(Of String)()
		Dim cmd As New OleDb.OleDbCommand("Select UyeId, UyeAdi, UyeSoyadi From Uyeler", con)
		Try
			Dim sayac As Integer = 0
			con.Open()
			Dim dr As OleDb.OleDbDataReader = cmd.ExecuteReader()
			While dr.Read()
				uyeListesi.Add(dr("UyeId").ToString() & " - " & dr("UyeAdi").ToString() & " " & dr("UyeSoyadi").ToString())
			End While
		Catch ex As Exception
			Console.WriteLine(ex.Message)
		Finally
			con.Close()
		End Try
		Return uyeListesi
	End Function
End Class
