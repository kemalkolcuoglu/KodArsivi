-- phpMyAdmin SQL Dump
-- version 4.8.2
-- https://www.phpmyadmin.net/
--
-- Host: localhost
-- Generation Time: Mar 19, 2019 at 12:48 AM
-- Server version: 5.5.45
-- PHP Version: 5.6.31

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `tedarikzinciri`
--

-- --------------------------------------------------------

--
-- Table structure for table `adres`
--

CREATE TABLE `adres` (
  `AdresID` int(11) NOT NULL,
  `IlKodu` int(11) DEFAULT NULL,
  `IlceKodu` int(11) DEFAULT NULL,
  `AdresAciklama` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin5;

-- --------------------------------------------------------

--
-- Table structure for table `firma`
--

CREATE TABLE `firma` (
  `FirmaID` int(11) NOT NULL,
  `FirmaAdi` varchar(255) DEFAULT NULL,
  `FirmaAciklama` varchar(255) DEFAULT NULL,
  `Telefon` varchar(25) DEFAULT NULL,
  `Fax` varchar(25) DEFAULT NULL,
  `EPosta` varchar(100) DEFAULT NULL,
  `Etkin` tinyint(1) DEFAULT NULL,
  `AdresID` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin5;

-- --------------------------------------------------------

--
-- Table structure for table `firmapersonel`
--

CREATE TABLE `firmapersonel` (
  `FirmaPersonelID` int(11) NOT NULL,
  `FirmaID` int(11) DEFAULT NULL,
  `KisiID` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin5;

-- --------------------------------------------------------

--
-- Table structure for table `firmatipi`
--

CREATE TABLE `firmatipi` (
  `FirmaTipiID` int(11) NOT NULL,
  `FirmaID` int(11) DEFAULT NULL,
  `Tipi` varchar(25) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin5;

-- --------------------------------------------------------

--
-- Table structure for table `il`
--

CREATE TABLE `il` (
  `IlKodu` int(11) NOT NULL,
  `IlAdi` varchar(20) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin5;

-- --------------------------------------------------------

--
-- Table structure for table `ilce`
--

CREATE TABLE `ilce` (
  `IlceKodu` int(11) NOT NULL,
  `IlceAdi` varchar(25) DEFAULT NULL,
  `IlKodu` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin5;

-- --------------------------------------------------------

--
-- Table structure for table `kisi`
--

CREATE TABLE `kisi` (
  `KisiID` int(11) NOT NULL,
  `TCKNO` varchar(11) DEFAULT NULL,
  `YetkiID` int(11) DEFAULT NULL,
  `Ad` varchar(25) DEFAULT NULL,
  `Soyad` varchar(25) DEFAULT NULL,
  `EPosta` varchar(75) DEFAULT NULL,
  `Telefon` varchar(25) DEFAULT NULL,
  `Etkin` tinyint(1) DEFAULT NULL,
  `Guid` char(36) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin5;

-- --------------------------------------------------------

--
-- Table structure for table `kisisifre`
--

CREATE TABLE `kisisifre` (
  `KisiSifreID` int(11) NOT NULL,
  `KisiID` int(11) DEFAULT NULL,
  `Sifre` varchar(15) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin5;

-- --------------------------------------------------------

--
-- Table structure for table `talep`
--

CREATE TABLE `talep` (
  `TalepID` int(11) NOT NULL,
  `UrunID` int(11) DEFAULT NULL,
  `FirmaID` int(11) DEFAULT NULL,
  `TalepMiktari` float DEFAULT NULL,
  `TalepTarihi` datetime DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin5;

-- --------------------------------------------------------

--
-- Table structure for table `tedarik`
--

CREATE TABLE `tedarik` (
  `TedarikID` int(11) NOT NULL,
  `KisiID` int(11) DEFAULT NULL,
  `TeslimAdresiID` int(11) DEFAULT NULL,
  `CikisAdresiID` int(11) DEFAULT NULL,
  `TeslimTarihi` datetime DEFAULT NULL,
  `Durum` varchar(25) DEFAULT NULL,
  `TedarikUcreti` float(11,4) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin5;

-- --------------------------------------------------------

--
-- Table structure for table `tesiskategori`
--

CREATE TABLE `tesiskategori` (
  `TesisKategoriID` int(11) NOT NULL,
  `TesisKategoriAdi` varchar(30) DEFAULT NULL,
  `TesisKategoriAciklama` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin5;

-- --------------------------------------------------------

--
-- Table structure for table `uretimtesisi`
--

CREATE TABLE `uretimtesisi` (
  `UretimTesisiID` int(11) NOT NULL,
  `TesisKategoriID` int(11) DEFAULT NULL,
  `AdresID` int(11) DEFAULT NULL,
  `FirmaID` int(11) DEFAULT NULL,
  `UretimKapasitesi` float DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin5;

-- --------------------------------------------------------

--
-- Table structure for table `urun`
--

CREATE TABLE `urun` (
  `UrunID` int(11) NOT NULL,
  `UrunKategoriID` int(11) DEFAULT NULL,
  `UretimTesisiID` int(11) DEFAULT NULL,
  `UrunAdi` varchar(50) DEFAULT NULL,
  `UrunAciklama` varchar(255) DEFAULT NULL,
  `UrunBirimi` varchar(255) DEFAULT NULL,
  `UrunFiyati` float DEFAULT NULL,
  `Stok` float(255,0) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin5;

-- --------------------------------------------------------

--
-- Table structure for table `urunkategori`
--

CREATE TABLE `urunkategori` (
  `UrunKategoriID` int(11) NOT NULL,
  `UrunKategoriAdi` varchar(30) DEFAULT NULL,
  `UrunKategoriAciklama` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin5;

-- --------------------------------------------------------

--
-- Table structure for table `yetki`
--

CREATE TABLE `yetki` (
  `YetkiID` int(11) NOT NULL,
  `YetkiAdi` varchar(15) DEFAULT NULL,
  `YetkiAciklama` varchar(100) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin5;

--
-- Indexes for dumped tables
--

--
-- Indexes for table `adres`
--
ALTER TABLE `adres`
  ADD PRIMARY KEY (`AdresID`),
  ADD KEY `AdresID` (`AdresID`),
  ADD KEY `IX_IlKodu` (`IlKodu`),
  ADD KEY `IX_IlceKodu` (`IlceKodu`),
  ADD KEY `AdresID_2` (`AdresID`);

--
-- Indexes for table `firma`
--
ALTER TABLE `firma`
  ADD PRIMARY KEY (`FirmaID`),
  ADD KEY `FirmaID` (`FirmaID`),
  ADD KEY `IX_AdresID` (`AdresID`);

--
-- Indexes for table `firmapersonel`
--
ALTER TABLE `firmapersonel`
  ADD PRIMARY KEY (`FirmaPersonelID`),
  ADD KEY `FirmaPersonelID` (`FirmaPersonelID`),
  ADD KEY `IX_FirmaID` (`FirmaID`),
  ADD KEY `IX_KisiID` (`KisiID`);

--
-- Indexes for table `firmatipi`
--
ALTER TABLE `firmatipi`
  ADD PRIMARY KEY (`FirmaTipiID`),
  ADD KEY `FirmaTipiID` (`FirmaTipiID`),
  ADD KEY `IX_FirmaID` (`FirmaID`);

--
-- Indexes for table `il`
--
ALTER TABLE `il`
  ADD PRIMARY KEY (`IlKodu`),
  ADD KEY `IlKodu` (`IlKodu`),
  ADD KEY `IlKodu_2` (`IlKodu`),
  ADD KEY `IlKodu_3` (`IlKodu`),
  ADD KEY `IlKodu_4` (`IlKodu`);

--
-- Indexes for table `ilce`
--
ALTER TABLE `ilce`
  ADD PRIMARY KEY (`IlceKodu`),
  ADD KEY `IlceKodu` (`IlceKodu`),
  ADD KEY `IX_IlKodu` (`IlKodu`);

--
-- Indexes for table `kisi`
--
ALTER TABLE `kisi`
  ADD PRIMARY KEY (`KisiID`),
  ADD KEY `KisiID` (`KisiID`),
  ADD KEY `IX_YetkiID` (`YetkiID`),
  ADD KEY `KisiID_2` (`KisiID`);

--
-- Indexes for table `kisisifre`
--
ALTER TABLE `kisisifre`
  ADD PRIMARY KEY (`KisiSifreID`),
  ADD KEY `KisiSifreID` (`KisiSifreID`),
  ADD KEY `IX_KisiID` (`KisiID`);

--
-- Indexes for table `talep`
--
ALTER TABLE `talep`
  ADD PRIMARY KEY (`TalepID`),
  ADD KEY `TalepID` (`TalepID`),
  ADD KEY `IX_UrunID` (`UrunID`),
  ADD KEY `IX_FirmaID` (`FirmaID`);

--
-- Indexes for table `tedarik`
--
ALTER TABLE `tedarik`
  ADD PRIMARY KEY (`TedarikID`),
  ADD KEY `TedarikID` (`TedarikID`),
  ADD KEY `IX_KisiID` (`KisiID`),
  ADD KEY `IX_TeslimAdresiID` (`TeslimAdresiID`),
  ADD KEY `IX_CikisAdresiID` (`CikisAdresiID`);

--
-- Indexes for table `tesiskategori`
--
ALTER TABLE `tesiskategori`
  ADD PRIMARY KEY (`TesisKategoriID`),
  ADD KEY `TesisKategoriID` (`TesisKategoriID`);

--
-- Indexes for table `uretimtesisi`
--
ALTER TABLE `uretimtesisi`
  ADD PRIMARY KEY (`UretimTesisiID`),
  ADD KEY `UretimTesisiID` (`UretimTesisiID`),
  ADD KEY `IX_TesisKategoiriID` (`TesisKategoriID`),
  ADD KEY `IX_AdresID` (`AdresID`),
  ADD KEY `IX_FirmaID` (`FirmaID`),
  ADD KEY `UretimTesisiID_2` (`UretimTesisiID`);

--
-- Indexes for table `urun`
--
ALTER TABLE `urun`
  ADD PRIMARY KEY (`UrunID`),
  ADD KEY `UrunID` (`UrunID`),
  ADD KEY `IX_UrunKategoriID` (`UrunKategoriID`),
  ADD KEY `IX_UretimTesisiID` (`UretimTesisiID`),
  ADD KEY `UrunID_2` (`UrunID`);

--
-- Indexes for table `urunkategori`
--
ALTER TABLE `urunkategori`
  ADD PRIMARY KEY (`UrunKategoriID`),
  ADD KEY `UrunKategoriID` (`UrunKategoriID`),
  ADD KEY `UrunKategoriID_2` (`UrunKategoriID`);

--
-- Indexes for table `yetki`
--
ALTER TABLE `yetki`
  ADD PRIMARY KEY (`YetkiID`),
  ADD KEY `YetkiID` (`YetkiID`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `adres`
--
ALTER TABLE `adres`
  MODIFY `AdresID` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `firma`
--
ALTER TABLE `firma`
  MODIFY `FirmaID` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `firmapersonel`
--
ALTER TABLE `firmapersonel`
  MODIFY `FirmaPersonelID` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `firmatipi`
--
ALTER TABLE `firmatipi`
  MODIFY `FirmaTipiID` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `kisi`
--
ALTER TABLE `kisi`
  MODIFY `KisiID` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `kisisifre`
--
ALTER TABLE `kisisifre`
  MODIFY `KisiSifreID` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `talep`
--
ALTER TABLE `talep`
  MODIFY `TalepID` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `tedarik`
--
ALTER TABLE `tedarik`
  MODIFY `TedarikID` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `tesiskategori`
--
ALTER TABLE `tesiskategori`
  MODIFY `TesisKategoriID` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `uretimtesisi`
--
ALTER TABLE `uretimtesisi`
  MODIFY `UretimTesisiID` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `urun`
--
ALTER TABLE `urun`
  MODIFY `UrunID` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `urunkategori`
--
ALTER TABLE `urunkategori`
  MODIFY `UrunKategoriID` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `yetki`
--
ALTER TABLE `yetki`
  MODIFY `YetkiID` int(11) NOT NULL AUTO_INCREMENT;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `adres`
--
ALTER TABLE `adres`
  ADD CONSTRAINT `FK_IlceKodu_Adres` FOREIGN KEY (`IlceKodu`) REFERENCES `ilce` (`IlceKodu`),
  ADD CONSTRAINT `FK_IlKodu_Adres` FOREIGN KEY (`IlKodu`) REFERENCES `il` (`IlKodu`);

--
-- Constraints for table `firma`
--
ALTER TABLE `firma`
  ADD CONSTRAINT `FK_AdresID` FOREIGN KEY (`AdresID`) REFERENCES `adres` (`AdresID`);

--
-- Constraints for table `firmapersonel`
--
ALTER TABLE `firmapersonel`
  ADD CONSTRAINT `FK_FirmaID_FirmaPersonel` FOREIGN KEY (`FirmaID`) REFERENCES `firma` (`FirmaID`),
  ADD CONSTRAINT `FK_KisiID_FirmaPersonel` FOREIGN KEY (`KisiID`) REFERENCES `kisi` (`KisiID`);

--
-- Constraints for table `firmatipi`
--
ALTER TABLE `firmatipi`
  ADD CONSTRAINT `FK_FirmaID_FirmaTipi` FOREIGN KEY (`FirmaID`) REFERENCES `firma` (`FirmaID`);

--
-- Constraints for table `ilce`
--
ALTER TABLE `ilce`
  ADD CONSTRAINT `FK_IlKodu_Ilce` FOREIGN KEY (`IlKodu`) REFERENCES `il` (`IlKodu`);

--
-- Constraints for table `kisi`
--
ALTER TABLE `kisi`
  ADD CONSTRAINT `FK_YetkiID_Kisi` FOREIGN KEY (`YetkiID`) REFERENCES `yetki` (`yetkiid`);

--
-- Constraints for table `kisisifre`
--
ALTER TABLE `kisisifre`
  ADD CONSTRAINT `FK_KisiID_KisiSifre` FOREIGN KEY (`KisiID`) REFERENCES `kisi` (`KisiID`);

--
-- Constraints for table `talep`
--
ALTER TABLE `talep`
  ADD CONSTRAINT `FK_FirmaID_Talep` FOREIGN KEY (`FirmaID`) REFERENCES `firma` (`FirmaID`),
  ADD CONSTRAINT `FK_UrunID_Talep` FOREIGN KEY (`UrunID`) REFERENCES `urun` (`urunid`);

--
-- Constraints for table `tedarik`
--
ALTER TABLE `tedarik`
  ADD CONSTRAINT `FK_CikisAdresiID_Tedarik` FOREIGN KEY (`CikisAdresiID`) REFERENCES `adres` (`AdresID`),
  ADD CONSTRAINT `FK_KisiID_Tedarik` FOREIGN KEY (`KisiID`) REFERENCES `kisi` (`KisiID`),
  ADD CONSTRAINT `FK_TeslimAdresiID_Tedarik` FOREIGN KEY (`TeslimAdresiID`) REFERENCES `adres` (`AdresID`);

--
-- Constraints for table `uretimtesisi`
--
ALTER TABLE `uretimtesisi`
  ADD CONSTRAINT `FK_AdresID_UretimTesisi` FOREIGN KEY (`AdresID`) REFERENCES `adres` (`AdresID`),
  ADD CONSTRAINT `FK_FirmaID_UretimTesisi` FOREIGN KEY (`FirmaID`) REFERENCES `firma` (`FirmaID`),
  ADD CONSTRAINT `FK_TesisKategoriID_UretimTesisi` FOREIGN KEY (`TesisKategoriID`) REFERENCES `tesiskategori` (`TesisKategoriID`);

--
-- Constraints for table `urun`
--
ALTER TABLE `urun`
  ADD CONSTRAINT `FK_UretimTesisiID_Urun` FOREIGN KEY (`UretimTesisiID`) REFERENCES `uretimtesisi` (`UretimTesisiID`),
  ADD CONSTRAINT `FK_UrunKategoriID_Urun` FOREIGN KEY (`UrunKategoriID`) REFERENCES `urunkategori` (`urunkategoriid`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
