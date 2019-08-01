Public Class AidatNesnesi
	Private _aidatId As Integer
	Private _uye As String
	Private _aidatTutari As Integer

	Public Property AidatId() As Integer
		Get
			Return _aidatId
		End Get
		Set(ByVal value As Integer)
			_aidatId = value
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

	Public Property AidatTutari() As Integer
		Get
			Return _aidatTutari
		End Get
		Set(ByVal value As Integer)
			_aidatTutari = value
		End Set
	End Property
End Class
