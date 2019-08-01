Public Class GorevlerNesnesi
	Private _gorevId As Integer
	Private _uye As String
	Private _uyeGorev As String

	Public Property GorevId() As Integer
		Get
			Return _gorevId
		End Get
		Set(ByVal value As Integer)
			_gorevId = value
		End Set
	End Property

	Public Property Uye() As String
		Get
			Return _uye
		End Get
		Set(ByVal value As String)
			_uye = value
		End Set
	End Property

	Public Property UyeGorev() As String
		Get
			Return _uyeGorev
		End Get
		Set(ByVal value As String)
			_uyeGorev = value
		End Set
	End Property
End Class
