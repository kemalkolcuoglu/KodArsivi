Create Database SiteYonetimSistemi;

Create Table KullaniciYetki
(
	KullaniciYetkiNo int Primary Key Identity(1,1),
	KullaniciYetkiAdi nvarchar(10) not null,
	KullaniciYetkiAciklama nvarchar(255) not null
);

Create Table Kullanici
(
	TCKNO nvarchar(11) Primary Key,
	KullaniciYetki int Foreign Key References KullaniciYetki(KullaniciYetkiNo),
	EPosta nvarchar(50) Unique not null,
	Sifre nvarchar(50) not null,
	KullaniciAd nvarchar(25) not null,
	KullaniciSoyad nvarchar(25) not null,
	TelefonNo1 nvarchar(15) not null,
	TelefonNo2 nvarchar(15),
	IsAdresi nvarchar(255),
	Etkin bit
);

Create Table Il
(
	IlKodu int Primary Key,
	IlAdi nvarchar(15) not null
);

Create Table Ilce
(
	IlKodu int Foreign Key References Il(IlKodu),
	IlceKodu int Primary Key Identity(1,1),
	IlceAdi nvarchar(25) not null
);

Create Table Siteler
(
	SiteNo int Primary Key Identity(1,1),
	SiteAdi nvarchar(25) not null,
	IlKodu int Foreign Key References Il(IlKodu),
	IlceKodu int Foreign Key References Ilce(IlceKodu),
	SiteAdres nvarchar(255) not null,
	SiteYoneticisi nvarchar(11) Foreign Key References Kullanici(TCKNO)
);

Create Table Blok
(
	BlokNo int Primary Key Identity(1,1),
	SiteNo int Foreign Key References Siteler(SiteNo),
	BlokAdi nvarchar(10) not null,
	DaireSayisi int not null
);

Create Table Daire
(
	DaireNo int Primary Key Identity(1,1),
	SiteNo int Foreign Key References Siteler(SiteNo),
	BlokNo int Foreign Key References Blok(BlokNo),
	DaireNumarasi int not null,
	KatNo int not null
);

Create Table DaireKayitlari
(
	DaireKayitNo int Primary Key Identity(1,1),
	SiteNo int Foreign Key References Siteler(SiteNo),
	BlokNo int Foreign Key References Blok(BlokNo),
	DaireNo int Foreign Key References Daire(DaireNo),
	DaireSahibi nvarchar(11) Foreign Key References Kullanici(TCKNO),
	DaireSakini nvarchar(11) Foreign Key References Kullanici(TCKNO),
	GirisTarihi datetime not null,
	CikisTarihi datetime not null,
	Aciklama nvarchar(255),
	Etkin bit
);

Create Table Aidat
(
	AidatNo int Primary Key Identity(1,1),
	SiteNo int Foreign Key References Siteler(SiteNo),
	BlokNo int Foreign Key References Blok(BlokNo),
	DaireNo int Foreign Key References Daire(DaireNo),
	AidatMakbuzNo int not null,
	Tarih date not null,
	AidatTutar money not null,
	OrtakTutar money,
	DemirbasTutar money,
	ToplamTutar money not null,
	OdenmeDurumu bit not null
);

Create Table Yakit
(
	YakitNo int Primary Key Identity(1,1),
	SiteNo int Foreign Key References Siteler(SiteNo),
	BlokNo int Foreign Key References Blok(BlokNo),
	DaireNo int Foreign Key References Daire(DaireNo),
	YakitMakbuzNo int not null,
	Tarih date not null,
	ToplamTutar money not null,
	OdenmeDurumu bit not null
);

Create Table GiderTuru
(
	GiderTuruNo int Primary Key Identity(1,1),
	GiderTuruAdi nvarchar(25) not null,
	GiderTuruAciklama nvarchar(255) not null
);

Create Table SiteGiderleri
(
	SiteGiderNo int Primary Key Identity(1,1),
	SiteNo int Foreign Key References Siteler(SiteNo),
	BlokNo int Foreign Key References Blok(BlokNo),
	GiderTuru int Foreign Key References GiderTuru(GiderTuruNo),
	Tutar money not null,
	Tarih date not null,
	Aciklama nvarchar(255),
);

Create Table Arac
(
	AracPlaka nvarchar(10) Primary Key,
	AracMarka nvarchar(15) not null,
	AracModel nvarchar(20) not null,
	IrtibatNo nvarchar(15) not null
);

Insert Into KullaniciYetki Values('Yetkili', 'En yetkili kullanýcý');
Insert Into KullaniciYetki Values('Yönetici', 'Site yöneticileri');
Insert Into KullaniciYetki Values('Kullanýcý', 'Site sahibi ya da sakini olan kisi');

Insert Into Kullanici(TCKNO, KullaniciYetki, EPosta, Sifre, KullaniciAd, KullaniciSoyad, TelefonNo1, IsAdresi, Etkin) Values('13155044508', 1, 'kemal.kolcuoglu@outlook.com.tr', '412345', 'Kemal', 'Kolcuoðlu', '05318128687', 'Selçuk Üniversitesi Selçuklu/KONYA', 1);
Insert Into Kullanici(TCKNO, KullaniciYetki, EPosta, Sifre, KullaniciAd, KullaniciSoyad, TelefonNo1, IsAdresi, Etkin) Values('12345678910', 3, 'roket_atar@gmail.com', '12345', 'Roket', 'Atar', '0535313131', 'Selçuklu/KONYA', 1);

Insert Into Il Values(70, 'KARAMAN');
Insert Into Il Values(42, 'KONYA');
Insert Into Il Values(06, 'ANKARA');
Insert Into Il Values(07, 'ANTALYA');
Insert Into Il Values(34, 'ÝSTANBUL');
Insert Into Il Values(31, 'HATAY');

Insert Into Ilce Values(70, 'Merkez');
Insert Into Ilce Values(70, 'Ayrancý');
Insert Into Ilce Values(70, 'Kazým Karabekir');
Insert Into Ilce Values(70, 'Ermenek');
Insert Into Ilce Values(70, 'Sarýveliler');
Insert Into Ilce Values(70, 'Baþyayla');
Insert Into Ilce Values(7, 'Muratpaþa');
Insert Into Ilce Values(7, 'Alanya');
Insert Into Ilce Values(7, 'Manavgat');
Insert Into Ilce Values(34, 'Bakýrköy');
Insert Into Ilce Values(34, 'Pendik');
Insert Into Ilce Values(34, 'Küçükçekmece');
Insert Into Ilce Values(34, 'Þiþli');
Insert Into Ilce Values(34, 'Kadýköy');