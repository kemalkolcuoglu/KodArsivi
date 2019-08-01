Public Class UyelerNesnesi
	Private _uyeId As Integer
	Private _uyeAdi As String
	Private _uyeSoyadi As String
	Private _tckno As String
	Private _uyelikTarihi As DateTime
	Private _aktif As Boolean
	Private _ikamet As String

	Public Property UyeId() As Integer
		Get
			Return _uyeId
		End Get
		Set(ByVal value As Integer)
			_uyeId = value
		End Set
	End Property

	Public Property UyeAdi() As String
		Get
			Return _uyeAdi
		End Get
		Set(ByVal value As String)
			_uyeAdi = value
		End Set
	End Property

	Public Property UyeSoyadi() As String
		Get
			Return _uyeSoyadi
		End Get
		Set(ByVal value As String)
			_uyeSoyadi = value
		End Set
	End Property

	Public Property TCKNO() As String
		Get
			Return _tckno
		End Get
		Set(ByVal value As String)
			_tckno = value
		End Set
	End Property

	Public Property UyelikTarihi() As DateTime
		Get
			Return _uyelikTarihi
		End Get
		Set(ByVal value As DateTime)
			_uyelikTarihi = value
		End Set
	End Property

	Public Property Aktif() As Boolean
		Get
			Return _aktif
		End Get
		Set(ByVal value As Boolean)
			_aktif = value
		End Set
	End Property

	Public Property Ikamet() As String
		Get
			Return _ikamet
		End Get
		Set(ByVal value As String)
			_ikamet = value
		End Set
	End Property
End Class
