--Create Database TedarikZinciri

Use TedarikZinciri

Create Table Il
(
	IlKodu int Primary Key,
	IlAdi nvarchar(15) Unique
);

Create Table Yetki
(
	YetkiID int Primary Key Identity(1,1),
	YetkiAdi nvarchar(10) Unique not null,
	YetkiAciklamasi nvarchar(255) not null
);

Create Table Kullanici
(
	KullaniciID int Primary Key Identity(1,1),
	EPosta nvarchar(50) Unique not null,
	Sifre nvarchar(25),
	YetkiID int Foreign Key References Yetki(YetkiID),
	Bakiye money not null,
	GercekFormal bit not null,
	KisiAdi nvarchar(25),
	KisiSoyad nvarchar(25),
	KisiAdres nvarchar(255)
);

Create Table TesisKategori
(
	TesisKategoriID int Primary Key Identity(1,1),
	TesisKategoriAdi nvarchar(50) Unique,
	TesisKategoriAciklama nvarchar(255) not null
);

Create Table UrunKategori
(
	UrunKategoriID int Primary Key Identity(1,1),
	UrunKategoriAdi nvarchar(25) Unique not null,
	UrunKategoriAciklama nvarchar(255) not null
);

Create Table UretimTesisi
(
	UretimTesisiID int Primary Key Identity(1,1),
	TesisKategoriID int Foreign Key References TesisKategori(TesisKategoriID),
	IlKodu int Foreign Key References Il(IlKodu),
	Adres nvarchar(255) not null,
	UretimKapasitesi decimal not null,
	YetkiliKisi int Foreign Key References Kullanici(KullaniciID),
);

Create Table Urun
(
	UrunID int Primary Key Identity(1,1),
	UrunKategoriID int Foreign Key References UrunKategori(UrunKategoriID),
	UretimTesisi int Foreign Key References UretimTesisi(UretimTesisiID),
	EldekiStok int not null
);

Create Table Talep
(
	TalepID int Primary Key Identity(1,1),
	UrunKategoriID int Foreign Key References UrunKategori(UrunKategoriID),
	UrunID int Foreign Key References Urun(UrunID),
	MusteriID int Foreign Key References Kullanici(KullaniciID),
	TalepMiktar int not null,
);

Create Table Tedarik
(
	TedarikID int Primary Key Identity(1,1),
	TalepID int Foreign Key References Talep(TalepID),
	SaticiID int Foreign Key References Kullanici(KullaniciID),
	TeslimatAdresi nvarchar(255) not null,
	PlanlananTeslimatTarihi datetime not null,
	TeslimTarihi datetime not null
);

Create Table BlokZinciri
(
	BlokID int Primary Key Identity(1,1),
	OncekiBlok int Foreign Key References BlokZinciri(BlokID),
	HashKodu nvarchar(64) not null,
	Difficulty int not null,
	OlusturmaTarihi datetime not null
);
