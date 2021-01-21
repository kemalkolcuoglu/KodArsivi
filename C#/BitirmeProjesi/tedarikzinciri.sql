Create Database tedarikzinciri;

Use tedarikzinciri;
Go

SET DATEFORMAT ymd
-- File name: C:\Users\QRyazılım\Desktop\tedarikzinciri.sql\n-- Created by MSSQL Library http://www.dbconvert.com\n

---- Table structure for table `yetki` 
----

CREATE TABLE [yetki] ([YetkiID] INT IDENTITY(1,1)  ,[YetkiAdi] VARCHAR(15) NULL  ,[YetkiAciklama] VARCHAR(100) NULL  ,CONSTRAINT [yetki_yetki_PRIMARY]  PRIMARY KEY  NONCLUSTERED  ([YetkiID])); 
 CREATE  NONCLUSTERED  INDEX [yetki_YetkiID] ON [yetki] ([YetkiID]);
 CREATE  NONCLUSTERED  INDEX [yetki_YetkiID_2] ON [yetki] ([YetkiID]);
 CREATE  NONCLUSTERED  INDEX [yetki_YetkiID_3] ON [yetki] ([YetkiID]);
 CREATE  NONCLUSTERED  INDEX [yetki_YetkiID_4] ON [yetki] ([YetkiID]);

---- Table structure for table `il` 
----

CREATE TABLE [il] ([IlKodu] INT NOT NULL  ,[IlAdi] VARCHAR(20) NULL  ,CONSTRAINT [il_il_PRIMARY]  PRIMARY KEY  NONCLUSTERED  ([IlKodu])); 
 CREATE  NONCLUSTERED  INDEX [il_IlKodu] ON [il] ([IlKodu]);
 CREATE  NONCLUSTERED  INDEX [il_IlKodu_2] ON [il] ([IlKodu]);
 CREATE  NONCLUSTERED  INDEX [il_IlKodu_3] ON [il] ([IlKodu]);
 CREATE  NONCLUSTERED  INDEX [il_IlKodu_4] ON [il] ([IlKodu]);

---- Table structure for table `ilce` 
----

CREATE TABLE [ilce] ([IlceKodu] INT NOT NULL  ,[IlceAdi] VARCHAR(25) NULL  ,[IlKodu] INT NULL  ,CONSTRAINT [ilce_ilce_PRIMARY]  PRIMARY KEY  NONCLUSTERED  ([IlceKodu]), CONSTRAINT [ilce_FK_IlKodu_Ilce] FOREIGN KEY ("IlKodu") REFERENCES "il" ( "IlKodu" ) ON UPDATE NO ACTION ON DELETE NO ACTION); 
 CREATE  NONCLUSTERED  INDEX [ilce_IlceKodu] ON [ilce] ([IlceKodu]);
 CREATE  NONCLUSTERED  INDEX [ilce_IX_IlKodu] ON [ilce] ([IlKodu]);
ALTER TABLE [ilce] NOCHECK CONSTRAINT [ilce_FK_IlKodu_Ilce];

---- Table structure for table `tesiskategori` 
----

CREATE TABLE [tesiskategori] ([TesisKategoriID] INT IDENTITY(1,1)  ,[TesisKategoriAdi] VARCHAR(30) NULL  ,[TesisKategoriAciklama] VARCHAR(255) NULL  ,CONSTRAINT [tesiskategori_tesiskategori_PRIMARY]  PRIMARY KEY  NONCLUSTERED  ([TesisKategoriID])); 
 CREATE  NONCLUSTERED  INDEX [tesiskategori_TesisKategoriID] ON [tesiskategori] ([TesisKategoriID]);
 CREATE  NONCLUSTERED  INDEX [tesiskategori_TesisKategoriID_2] ON [tesiskategori] ([TesisKategoriID]);
 CREATE  NONCLUSTERED  INDEX [tesiskategori_TesisKategoriID_3] ON [tesiskategori] ([TesisKategoriID]);

---- Table structure for table `adres` 
----

CREATE TABLE [adres] ([AdresID] INT IDENTITY(1,1)  ,[IlKodu] INT NULL  ,[IlceKodu] INT NULL  ,[AdresAciklama] VARCHAR(255) NULL  ,CONSTRAINT [adres_adres_PRIMARY]  PRIMARY KEY  NONCLUSTERED  ([AdresID]), CONSTRAINT [adres_FK_IlKodu_Adres] FOREIGN KEY ("IlKodu") REFERENCES "il" ( "IlKodu" ) ON UPDATE NO ACTION ON DELETE NO ACTION, CONSTRAINT [adres_FK_IlceKodu_Adres] FOREIGN KEY ("IlceKodu") REFERENCES "ilce" ( "IlceKodu" ) ON UPDATE NO ACTION ON DELETE NO ACTION); 
 CREATE  NONCLUSTERED  INDEX [adres_AdresID] ON [adres] ([AdresID]);
 CREATE  NONCLUSTERED  INDEX [adres_IX_IlKodu] ON [adres] ([IlKodu]);
 CREATE  NONCLUSTERED  INDEX [adres_IX_IlceKodu] ON [adres] ([IlceKodu]);
 CREATE  NONCLUSTERED  INDEX [adres_AdresID_2] ON [adres] ([AdresID]);
 CREATE  NONCLUSTERED  INDEX [adres_AdresID_3] ON [adres] ([AdresID]);
 CREATE  NONCLUSTERED  INDEX [adres_AdresID_4] ON [adres] ([AdresID]);
 CREATE  NONCLUSTERED  INDEX [adres_AdresID_5] ON [adres] ([AdresID]);
 CREATE  NONCLUSTERED  INDEX [adres_AdresID_6] ON [adres] ([AdresID]);
ALTER TABLE [adres] CHECK CONSTRAINT [adres_FK_IlKodu_Adres];
ALTER TABLE [adres] CHECK CONSTRAINT [adres_FK_IlceKodu_Adres];

---- Table structure for table `kisi` 
----

CREATE TABLE [kisi] ([KisiID] INT IDENTITY(1,1)  ,[TCKNO] VARCHAR(11) NULL  ,[YetkiID] INT NULL  ,[Ad] VARCHAR(25) NULL  ,[Soyad] VARCHAR(25) NULL  ,[EPosta] VARCHAR(75) NULL  ,[Telefon] VARCHAR(25) NULL  ,[Etkin] SMALLINT NULL  ,[Guid] NVARCHAR(40) NULL  ,CONSTRAINT [kisi_kisi_PRIMARY]  PRIMARY KEY  NONCLUSTERED  ([KisiID]), CONSTRAINT [kisi_FK_YetkiID_Kisi] FOREIGN KEY ("YetkiID") REFERENCES "yetki" ( "YetkiID" ) ON UPDATE NO ACTION ON DELETE NO ACTION); 
 CREATE  NONCLUSTERED  INDEX [kisi_KisiID] ON [kisi] ([KisiID]);
 CREATE  NONCLUSTERED  INDEX [kisi_IX_YetkiID] ON [kisi] ([YetkiID]);
ALTER TABLE [kisi] NOCHECK CONSTRAINT [kisi_FK_YetkiID_Kisi];

---- Table structure for table `firma` 
----

CREATE TABLE [firma] ([FirmaID] INT IDENTITY(1,1)  ,[FirmaAdi] VARCHAR(255) NULL  ,[FirmaAciklama] VARCHAR(255) NULL  ,[Telefon] VARCHAR(25) NULL  ,[Fax] VARCHAR(25) NULL  ,[EPosta] VARCHAR(100) NULL  ,[Etkin] SMALLINT NULL  ,[AdresID] INT NULL  ,[FirmaTipi] VARCHAR(20) NULL  ,CONSTRAINT [firma_firma_PRIMARY]  PRIMARY KEY  NONCLUSTERED  ([FirmaID]), CONSTRAINT [firma_FK_AdresID] FOREIGN KEY ("AdresID") REFERENCES "adres" ( "AdresID" ) ON UPDATE NO ACTION ON DELETE NO ACTION); 
 CREATE  NONCLUSTERED  INDEX [firma_FirmaID] ON [firma] ([FirmaID]);
 CREATE  NONCLUSTERED  INDEX [firma_IX_AdresID] ON [firma] ([AdresID]);
 CREATE  NONCLUSTERED  INDEX [firma_FirmaID_2] ON [firma] ([FirmaID]);
 CREATE  NONCLUSTERED  INDEX [firma_FirmaID_3] ON [firma] ([FirmaID]);
ALTER TABLE [firma] NOCHECK CONSTRAINT [firma_FK_AdresID];

---- Table structure for table `uretimtesisi` 
----

CREATE TABLE [uretimtesisi] ([UretimTesisiID] INT IDENTITY(1,1)  ,[TesisKategoriID] INT NULL  ,[AdresID] INT NULL  ,[FirmaID] INT NULL  ,[TesisAdi] VARCHAR(255) NULL  ,[TesisAciklama] VARCHAR(255) NULL  ,[UretimKapasitesi] REAL NULL  ,CONSTRAINT [uretimtesisi_uretimtesisi_PRIMARY]  PRIMARY KEY  NONCLUSTERED  ([UretimTesisiID]), CONSTRAINT [uretimtesisi_FK_AdresID_UretimTesisi] FOREIGN KEY ("AdresID") REFERENCES "adres" ( "AdresID" ) ON UPDATE NO ACTION ON DELETE NO ACTION, CONSTRAINT [uretimtesisi_FK_FirmaID_UretimTesisi] FOREIGN KEY ("FirmaID") REFERENCES "firma" ( "FirmaID" ) ON UPDATE NO ACTION ON DELETE NO ACTION, CONSTRAINT [uretimtesisi_FK_TesisKategoriID_UretimTesisi] FOREIGN KEY ("TesisKategoriID") REFERENCES "tesiskategori" ( "TesisKategoriID" ) ON UPDATE NO ACTION ON DELETE NO ACTION); 
 CREATE  NONCLUSTERED  INDEX [uretimtesisi_UretimTesisiID] ON [uretimtesisi] ([UretimTesisiID]);
 CREATE  NONCLUSTERED  INDEX [uretimtesisi_IX_TesisKategoiriID] ON [uretimtesisi] ([TesisKategoriID]);
 CREATE  NONCLUSTERED  INDEX [uretimtesisi_IX_AdresID] ON [uretimtesisi] ([AdresID]);
 CREATE  NONCLUSTERED  INDEX [uretimtesisi_IX_FirmaID] ON [uretimtesisi] ([FirmaID]);
 CREATE  NONCLUSTERED  INDEX [uretimtesisi_UretimTesisiID_2] ON [uretimtesisi] ([UretimTesisiID]);
ALTER TABLE [uretimtesisi] NOCHECK CONSTRAINT [uretimtesisi_FK_AdresID_UretimTesisi];
ALTER TABLE [uretimtesisi] CHECK CONSTRAINT [uretimtesisi_FK_FirmaID_UretimTesisi];
ALTER TABLE [uretimtesisi] NOCHECK CONSTRAINT [uretimtesisi_FK_TesisKategoriID_UretimTesisi];

---- Table structure for table `urunkategori` 
----

CREATE TABLE [urunkategori] ([UrunKategoriID] INT IDENTITY(1,1)  ,[UrunKategoriAdi] VARCHAR(30) NULL  ,[UrunKategoriAciklama] VARCHAR(255) NULL  ,CONSTRAINT [urunkategori_urunkategori_PRIMARY]  PRIMARY KEY  NONCLUSTERED  ([UrunKategoriID])); 
 CREATE  NONCLUSTERED  INDEX [urunkategori_UrunKategoriID] ON [urunkategori] ([UrunKategoriID]);
 CREATE  NONCLUSTERED  INDEX [urunkategori_UrunKategoriID_2] ON [urunkategori] ([UrunKategoriID]);

---- Table structure for table `urun` 
----

CREATE TABLE [urun] ([UrunID] INT IDENTITY(1,1)  ,[UrunKategoriID] INT NULL  ,[UretimTesisiID] INT NULL  ,[UrunAdi] VARCHAR(50) NULL  ,[UrunAciklama] VARCHAR(255) NULL  ,[UrunBirimi] VARCHAR(255) NULL  ,[UrunFiyati] REAL NULL  ,[Stok] REAL NULL  ,CONSTRAINT [urun_urun_PRIMARY]  PRIMARY KEY  NONCLUSTERED  ([UrunID]), CONSTRAINT [urun_FK_UretimTesisiID_Urun] FOREIGN KEY ("UretimTesisiID") REFERENCES "uretimtesisi" ( "UretimTesisiID" ) ON UPDATE NO ACTION ON DELETE NO ACTION, CONSTRAINT [urun_FK_UrunKategoriID_Urun] FOREIGN KEY ("UrunKategoriID") REFERENCES "urunkategori" ( "UrunKategoriID" ) ON UPDATE NO ACTION ON DELETE NO ACTION); 
 CREATE  NONCLUSTERED  INDEX [urun_UrunID] ON [urun] ([UrunID]);
 CREATE  NONCLUSTERED  INDEX [urun_IX_UrunKategoriID] ON [urun] ([UrunKategoriID]);
 CREATE  NONCLUSTERED  INDEX [urun_IX_UretimTesisiID] ON [urun] ([UretimTesisiID]);
 CREATE  NONCLUSTERED  INDEX [urun_UrunID_2] ON [urun] ([UrunID]);
ALTER TABLE [urun] NOCHECK CONSTRAINT [urun_FK_UretimTesisiID_Urun];
ALTER TABLE [urun] NOCHECK CONSTRAINT [urun_FK_UrunKategoriID_Urun];

---- Table structure for table `talep` 
----

CREATE TABLE [talep] ([TalepID] INT IDENTITY(1,1)  ,[UrunID] INT NULL  ,[FirmaID] INT NULL  ,[TalepMiktari] REAL NULL  ,[TalepTarihi] DATETIME NULL  ,CONSTRAINT [talep_talep_PRIMARY]  PRIMARY KEY  NONCLUSTERED  ([TalepID]), CONSTRAINT [talep_FK_FirmaID_Talep] FOREIGN KEY ("FirmaID") REFERENCES "firma" ( "FirmaID" ) ON UPDATE NO ACTION ON DELETE NO ACTION, CONSTRAINT [talep_FK_UrunID_Talep] FOREIGN KEY ("UrunID") REFERENCES "urun" ( "UrunID" ) ON UPDATE NO ACTION ON DELETE NO ACTION); 
 CREATE  NONCLUSTERED  INDEX [talep_TalepID] ON [talep] ([TalepID]);
 CREATE  NONCLUSTERED  INDEX [talep_IX_UrunID] ON [talep] ([UrunID]);
 CREATE  NONCLUSTERED  INDEX [talep_IX_FirmaID] ON [talep] ([FirmaID]);
ALTER TABLE [talep] NOCHECK CONSTRAINT [talep_FK_FirmaID_Talep];
ALTER TABLE [talep] NOCHECK CONSTRAINT [talep_FK_UrunID_Talep];

---- Table structure for table `firmapersonel` 
----

CREATE TABLE [firmapersonel] ([FirmaPersonelID] INT IDENTITY(1,1)  ,[FirmaID] INT NULL  ,[KisiID] INT NULL  ,CONSTRAINT [firmapersonel_firmapersonel_PRIMARY]  PRIMARY KEY  NONCLUSTERED  ([FirmaPersonelID]), CONSTRAINT [firmapersonel_FK_FirmaID_FirmaPersonel] FOREIGN KEY ("FirmaID") REFERENCES "firma" ( "FirmaID" ) ON UPDATE NO ACTION ON DELETE NO ACTION, CONSTRAINT [firmapersonel_FK_KisiID_FirmaPersonel] FOREIGN KEY ("KisiID") REFERENCES "kisi" ( "KisiID" ) ON UPDATE NO ACTION ON DELETE NO ACTION); 
 CREATE  NONCLUSTERED  INDEX [firmapersonel_FirmaPersonelID] ON [firmapersonel] ([FirmaPersonelID]);
 CREATE  NONCLUSTERED  INDEX [firmapersonel_IX_FirmaID] ON [firmapersonel] ([FirmaID]);
 CREATE  NONCLUSTERED  INDEX [firmapersonel_IX_KisiID] ON [firmapersonel] ([KisiID]);
ALTER TABLE [firmapersonel] CHECK CONSTRAINT [firmapersonel_FK_FirmaID_FirmaPersonel];
ALTER TABLE [firmapersonel] NOCHECK CONSTRAINT [firmapersonel_FK_KisiID_FirmaPersonel];

---- Table structure for table `tedarik` 
----

CREATE TABLE [tedarik] ([TedarikID] INT IDENTITY(1,1)  ,[KisiID] INT NULL  ,[TalepID] INT NULL  ,[TeslimAdresiID] INT NULL  ,[CikisAdresiID] INT NULL  ,[TeslimTarihi] DATETIME NULL  ,[Durum] VARCHAR(25) NULL  ,[TedarikUcreti] REAL NULL  ,CONSTRAINT [tedarik_tedarik_PRIMARY]  PRIMARY KEY  NONCLUSTERED  ([TedarikID]), CONSTRAINT [tedarik_FK_CikisAdresiID_Tedarik] FOREIGN KEY ("CikisAdresiID") REFERENCES "adres" ( "AdresID" ) ON UPDATE NO ACTION ON DELETE NO ACTION, CONSTRAINT [tedarik_FK_KisiID_Tedarik] FOREIGN KEY ("KisiID") REFERENCES "kisi" ( "KisiID" ) ON UPDATE NO ACTION ON DELETE NO ACTION, CONSTRAINT [tedarik_FK_TalepID_Tedarik] FOREIGN KEY ("TalepID") REFERENCES "talep" ( "TalepID" ) ON UPDATE NO ACTION ON DELETE NO ACTION, CONSTRAINT [tedarik_FK_TeslimAdresiID_Tedarik] FOREIGN KEY ("TeslimAdresiID") REFERENCES "adres" ( "AdresID" ) ON UPDATE NO ACTION ON DELETE NO ACTION); 
 CREATE  NONCLUSTERED  INDEX [tedarik_TedarikID] ON [tedarik] ([TedarikID]);
 CREATE  NONCLUSTERED  INDEX [tedarik_IX_KisiID] ON [tedarik] ([KisiID]);
 CREATE  NONCLUSTERED  INDEX [tedarik_IX_TeslimAdresiID] ON [tedarik] ([TeslimAdresiID]);
 CREATE  NONCLUSTERED  INDEX [tedarik_IX_CikisAdresiID] ON [tedarik] ([CikisAdresiID]);
 CREATE  NONCLUSTERED  INDEX [tedarik_IX_TalepID] ON [tedarik] ([TalepID]);
ALTER TABLE [tedarik] NOCHECK CONSTRAINT [tedarik_FK_CikisAdresiID_Tedarik];
ALTER TABLE [tedarik] NOCHECK CONSTRAINT [tedarik_FK_KisiID_Tedarik];
ALTER TABLE [tedarik] NOCHECK CONSTRAINT [tedarik_FK_TalepID_Tedarik];
ALTER TABLE [tedarik] NOCHECK CONSTRAINT [tedarik_FK_TeslimAdresiID_Tedarik];

---- Table structure for table `kisisifre` 
----

CREATE TABLE [kisisifre] ([KisiSifreID] INT IDENTITY(1,1)  ,[KisiID] INT NULL  ,[Sifre] VARCHAR(15) NULL  ,CONSTRAINT [kisisifre_kisisifre_PRIMARY]  PRIMARY KEY  NONCLUSTERED  ([KisiSifreID]), CONSTRAINT [kisisifre_FK_KisiID_KisiSifre] FOREIGN KEY ("KisiID") REFERENCES "kisi" ( "KisiID" ) ON UPDATE NO ACTION ON DELETE NO ACTION); 
 CREATE  NONCLUSTERED  INDEX [kisisifre_KisiSifreID] ON [kisisifre] ([KisiSifreID]);
 CREATE  NONCLUSTERED  INDEX [kisisifre_IX_KisiID] ON [kisisifre] ([KisiID]);
 CREATE  NONCLUSTERED  INDEX [kisisifre_KisiSifreID_2] ON [kisisifre] ([KisiSifreID]);
ALTER TABLE [kisisifre] NOCHECK CONSTRAINT [kisisifre_FK_KisiID_KisiSifre];
