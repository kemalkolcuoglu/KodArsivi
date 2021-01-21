-- phpMyAdmin SQL Dump
-- version 4.8.2
-- https://www.phpmyadmin.net/
--
-- Host: localhost
-- Generation Time: Mar 19, 2019 at 12:46 AM
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
-- Database: `amedya`
--
CREATE DATABASE IF NOT EXISTS `amedya` DEFAULT CHARACTER SET utf8 COLLATE utf8_general_ci;
USE `amedya`;

-- --------------------------------------------------------

--
-- Table structure for table `ayarlar`
--

CREATE TABLE `ayarlar` (
  `Id` bigint(20) UNSIGNED NOT NULL,
  `Title` varchar(255) DEFAULT NULL,
  `Webmaster` varchar(250) DEFAULT NULL,
  `MailServer` varchar(255) DEFAULT NULL,
  `MailPort` varchar(255) DEFAULT NULL,
  `MailAdress` varchar(255) DEFAULT NULL,
  `MailPassword` varchar(255) DEFAULT NULL,
  `MailSsl` varchar(25) DEFAULT 'false',
  `SlaytSize` varchar(120) DEFAULT NULL,
  `Ziyaretci` int(11) DEFAULT '0',
  `GZip` varchar(15) DEFAULT 'true',
  `HtmlCompress` varchar(15) DEFAULT 'true',
  `Dil` int(11) DEFAULT '1',
  `Reg_date` timestamp NULL DEFAULT CURRENT_TIMESTAMP
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `ayarlar`
--

INSERT INTO `ayarlar` (`Id`, `Title`, `Webmaster`, `MailServer`, `MailPort`, `MailAdress`, `MailPassword`, `MailSsl`, `SlaytSize`, `Ziyaretci`, `GZip`, `HtmlCompress`, `Dil`, `Reg_date`) VALUES
(1, 'AMEDYA', '7Qae8WsEuB80qOip1KrS2XEXKyRIfe7sDwOcWLFox5E=', '', '', '', '', 'false', '1920x1200', 0, 'false', 'true', 1, '2017-06-10 23:42:44');

-- --------------------------------------------------------

--
-- Table structure for table `dil`
--

CREATE TABLE `dil` (
  `DilID` bigint(20) UNSIGNED NOT NULL,
  `DilAd` varchar(255) DEFAULT NULL,
  `Bayrak` varchar(255) DEFAULT NULL,
  `Baslik` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `dil`
--

INSERT INTO `dil` (`DilID`, `DilAd`, `Bayrak`, `Baslik`) VALUES
(1, 'TR', NULL, 'Türkçe'),
(2, 'EN', NULL, 'İNGİLİZCE');

-- --------------------------------------------------------

--
-- Table structure for table `dokuman`
--

CREATE TABLE `dokuman` (
  `Id` bigint(20) UNSIGNED NOT NULL,
  `Yol` varchar(255) DEFAULT NULL,
  `Resim` varchar(250) DEFAULT NULL,
  `icerik_Id` int(11) DEFAULT NULL,
  `Baslik` varchar(255) DEFAULT NULL,
  `Sira` int(11) NOT NULL DEFAULT '0',
  `DilID` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Table structure for table `form`
--

CREATE TABLE `form` (
  `Id` bigint(20) UNSIGNED NOT NULL,
  `Baslik` varchar(250) DEFAULT NULL,
  `Detay` longtext,
  `Reg_date` timestamp NULL DEFAULT CURRENT_TIMESTAMP
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Table structure for table `icerik`
--

CREATE TABLE `icerik` (
  `Id` bigint(20) UNSIGNED NOT NULL,
  `YoneticiID` int(11) DEFAULT '1',
  `Baslik` varchar(255) DEFAULT NULL,
  `Tarih` varchar(255) DEFAULT NULL,
  `Resim` varchar(255) DEFAULT NULL,
  `Banner` varchar(255) DEFAULT NULL,
  `Form` longtext,
  `Tur` int(11) DEFAULT NULL,
  `Ust` int(11) DEFAULT NULL,
  `Yonlendirme` int(11) DEFAULT '0',
  `Yonlendirme_Tur_Id` int(11) DEFAULT '0',
  `Yonlendirme_Icerik_Id` int(11) DEFAULT '0',
  `DilID` int(11) DEFAULT '0',
  `Sira` int(11) NOT NULL DEFAULT '0',
  `Paylasim` int(11) DEFAULT '0',
  `Okuma` int(11) DEFAULT '0',
  `Modul` int(11) DEFAULT '0',
  `Menu` int(11) DEFAULT '1',
  `Dropdown` int(11) DEFAULT '1',
  `Url` int(11) DEFAULT '1',
  `ResimGoster` int(11) DEFAULT '1',
  `BannerGoster` int(11) DEFAULT '1',
  `Extra1` varchar(255) DEFAULT NULL,
  `Extra2` varchar(255) DEFAULT NULL,
  `Durum` int(11) DEFAULT '0'
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `icerik`
--

INSERT INTO `icerik` (`Id`, `YoneticiID`, `Baslik`, `Tarih`, `Resim`, `Banner`, `Form`, `Tur`, `Ust`, `Yonlendirme`, `Yonlendirme_Tur_Id`, `Yonlendirme_Icerik_Id`, `DilID`, `Sira`, `Paylasim`, `Okuma`, `Modul`, `Menu`, `Dropdown`, `Url`, `ResimGoster`, `BannerGoster`, `Extra1`, `Extra2`, `Durum`) VALUES
(46, 1, NULL, '2018-02-15 16:40:54', NULL, NULL, '[{\"FieldName\": \"lang_ad_soyad\",\"FieldType\": \"textbox\",\"FieldValue\": \"\"},{\"FieldName\": \"lang_eposta\",\"FieldType\": \"textbox\",\"FieldValue\": \"\"},{\"FieldName\": \"lang_mesajiniz\",\"FieldType\": \"textarea\",\"FieldValue\": \"\"},{\"FieldName\": \"0\",\"FieldType\": \"form_mail\",\"FieldValue\": \"\"}]', 11, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, '', '', 1),
(52, 1, NULL, '2018-06-20 14:25:54', 'Upload/hakkimizda-19072018_171431.jpg', NULL, NULL, 12, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, '', '', 1),
(103, 1, NULL, '2018-07-19 11:36:34', 'Upload/konya_export.png', NULL, NULL, 13, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 1, 1, 1, 1, '', '', 1),
(104, 1, NULL, '2018-07-19 11:38:12', 'Upload/tarim_tr.png', NULL, NULL, 13, 0, 0, 0, 0, 0, 2, 0, 0, 0, 1, 1, 1, 1, 1, '', '', 1),
(105, 1, NULL, '2018-07-19 11:38:57', 'Upload/konya_automotive.png', NULL, NULL, 13, 0, 0, 0, 0, 0, 3, 0, 0, 0, 1, 1, 1, 1, 1, '', '', 1),
(106, 1, NULL, '2018-07-19 11:39:29', 'Upload/dijital_medya.png', NULL, NULL, 13, 0, 0, 0, 0, 0, 4, 0, 0, 0, 1, 1, 1, 1, 1, '', '', 1),
(107, 1, NULL, '2018-07-19 11:40:23', 'Upload/turkiye_gazetesi.png', NULL, NULL, 13, 0, 0, 0, 0, 0, 5, 0, 0, 0, 1, 1, 1, 1, 1, '', '', 1),
(108, 1, NULL, '2018-07-19 11:41:44', 'Upload/pegasus_magazin.png', NULL, NULL, 13, 0, 0, 0, 0, 0, 6, 0, 0, 0, 1, 1, 1, 1, 1, '', '', 1),
(109, 1, NULL, '2018-07-19 11:42:35', 'Upload/e_katalog.png', NULL, NULL, 13, 0, 0, 0, 0, 0, 7, 0, 0, 0, 1, 1, 1, 1, 1, '', '', 1),
(110, 1, NULL, '2018-07-19 11:43:17', 'Upload/glober.png', NULL, NULL, 13, 0, 0, 0, 0, 0, 8, 0, 0, 0, 1, 1, 1, 1, 1, '', '', 1),
(111, 1, NULL, '2018-07-19 11:44:03', 'Upload/suntimes.png', NULL, NULL, 13, 0, 0, 0, 0, 0, 9, 0, 0, 0, 1, 1, 1, 1, 1, '', '', 1),
(112, 1, NULL, '2018-07-19 11:44:59', 'Upload/tahsilat_sistemi.png', NULL, NULL, 13, 0, 0, 0, 0, 0, 10, 0, 0, 0, 1, 1, 1, 1, 1, '', '', 1),
(113, 1, NULL, '2018-07-19 11:45:29', 'Upload/harita_kaydi.png', NULL, NULL, 13, 0, 0, 0, 0, 0, 11, 0, 0, 0, 1, 1, 1, 1, 1, '', '', 1),
(114, 1, NULL, '2018-07-19 12:00:47', 'Upload/turkiye_cocuk.png', NULL, NULL, 13, 0, 0, 0, 0, 0, 12, 0, 0, 0, 1, 1, 1, 1, 1, '', '', 1),
(115, 1, NULL, '2018-07-19 12:01:13', 'Upload/yemek_zevki.png', NULL, NULL, 13, 0, 0, 0, 0, 0, 13, 0, 0, 0, 1, 1, 1, 1, 1, '', '', 1),
(116, 1, NULL, '2018-07-19 12:02:06', 'Upload/hotel_restaurant.png', NULL, NULL, 13, 0, 0, 0, 0, 0, 14, 0, 0, 0, 1, 1, 1, 1, 1, '', '', 1),
(117, 1, NULL, '2018-07-19 12:03:03', 'Upload/food_turkey.png', NULL, NULL, 13, 0, 0, 0, 0, 0, 15, 0, 0, 0, 1, 1, 1, 1, 1, '', '', 1),
(118, 1, NULL, '2018-07-19 12:04:19', 'Upload/tekstil_teknik.png', NULL, NULL, 13, 0, 0, 0, 0, 0, 16, 0, 0, 0, 1, 1, 1, 1, 1, '', '', 1),
(119, 1, NULL, '2018-07-19 12:05:02', 'Upload/sleep_well.png', NULL, NULL, 13, 0, 0, 0, 0, 0, 17, 0, 0, 0, 1, 1, 1, 1, 1, '', '', 1),
(120, 1, NULL, '2018-07-19 12:05:37', 'Upload/automotive_exports.png', NULL, NULL, 13, 0, 0, 0, 0, 0, 18, 0, 0, 0, 1, 1, 1, 1, 1, '', '', 1),
(121, 1, NULL, '2018-07-19 12:06:05', 'Upload/made_in_turkey.png', NULL, NULL, 13, 0, 0, 0, 0, 0, 19, 0, 0, 0, 1, 1, 1, 1, 1, '', '', 1),
(122, 1, NULL, '2018-07-19 12:06:53', 'Upload/nalbur_teknik.png', NULL, NULL, 13, 0, 0, 0, 0, 0, 20, 0, 0, 0, 1, 1, 1, 1, 1, '', '', 1),
(123, 1, NULL, '2018-07-19 12:07:37', 'Upload/yapi_malzeme.png', NULL, NULL, 13, 0, 0, 0, 0, 0, 21, 0, 0, 0, 1, 1, 1, 1, 1, '', '', 1),
(124, 1, NULL, '2018-07-19 12:08:06', 'Upload/medikal_teknik.png', NULL, NULL, 13, 0, 0, 0, 0, 0, 22, 0, 0, 0, 1, 1, 1, 1, 1, '', '', 1),
(125, 1, NULL, '2018-07-19 12:08:34', 'Upload/it_network.png', NULL, NULL, 13, 0, 0, 0, 0, 0, 23, 0, 0, 0, 1, 1, 1, 1, 1, '', '', 1),
(126, 1, NULL, '2018-07-19 14:12:15', 'Upload/web_sitemiz_guncellenmistir.jpg', NULL, NULL, 20, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, '', '', 1),
(127, 1, NULL, '2018-07-19 16:59:02', NULL, NULL, NULL, 18, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 1, 1, 1, 1, '', '', 1),
(128, 1, NULL, '2018-07-19 17:00:00', NULL, NULL, NULL, 18, 0, 0, 0, 0, 0, 2, 0, 0, 0, 1, 1, 1, 1, 1, '', '', 1),
(129, 1, NULL, '2018-07-19 17:00:59', NULL, NULL, NULL, 18, 0, 0, 0, 0, 0, 4, 0, 0, 0, 1, 1, 1, 1, 1, '', '', 1),
(130, 1, NULL, '2018-07-19 17:06:16', NULL, NULL, NULL, 18, 0, 0, 0, 0, 0, 3, 0, 0, 0, 1, 1, 1, 1, 1, '', '', 1),
(131, 1, NULL, '2018-07-19 17:17:35', 'Upload/tarim_tr_yeni_sayisi_bayilerde.jpg', NULL, NULL, 20, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, '', '', 1);

-- --------------------------------------------------------

--
-- Table structure for table `icerikdetay`
--

CREATE TABLE `icerikdetay` (
  `Id` bigint(20) UNSIGNED NOT NULL,
  `icerik_Id` int(11) DEFAULT NULL,
  `Baslik` varchar(255) DEFAULT NULL,
  `Detay` longtext,
  `slug` varchar(255) DEFAULT NULL,
  `DilID` int(11) DEFAULT NULL,
  `Keywords` longtext,
  `Descriptions` longtext,
  `Title` longtext,
  `SeoField` longtext,
  `Layer1` longtext,
  `Layer2` longtext,
  `Layer3` longtext,
  `Layer4` longtext,
  `Layer5` longtext,
  `Layer6` longtext,
  `Layer7` longtext,
  `Layer8` longtext,
  `seo_url` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `icerikdetay`
--

INSERT INTO `icerikdetay` (`Id`, `icerik_Id`, `Baslik`, `Detay`, `slug`, `DilID`, `Keywords`, `Descriptions`, `Title`, `SeoField`, `Layer1`, `Layer2`, `Layer3`, `Layer4`, `Layer5`, `Layer6`, `Layer7`, `Layer8`, `seo_url`) VALUES
(46, 46, 'İletişim Bilgileri', '<h5 style=\"margin-bottom: 0px; padding: 0px; border: 0px; vertical-align: baseline; line-height: 1; font-size: 15px; color: rgb(119, 119, 119); font-family: &quot;Open Sans&quot;, Arial, sans-serif;\">Adres:</h5><p style=\"margin-bottom: 20px; padding: 0px; border: 0px; vertical-align: baseline; line-height: 22px; color: rgb(119, 119, 119);\">Hazım Uluşahin İş Merkezi C Blok Kat : 6 No: 604 Selçuklu/KONYA</p><h5 style=\"margin-bottom: 0px; padding: 0px; border: 0px; vertical-align: baseline; line-height: 1; font-size: 15px; color: rgb(119, 119, 119); font-family: &quot;Open Sans&quot;, Arial, sans-serif;\">E-Posta:</h5><p style=\"margin-bottom: 20px; padding: 0px; border: 0px; vertical-align: baseline; line-height: 22px; color: rgb(119, 119, 119);\">amedya@amedya.com.tr</p><h5 style=\"margin-bottom: 0px; padding: 0px; border: 0px; vertical-align: baseline; line-height: 1; font-size: 15px; color: rgb(119, 119, 119); font-family: &quot;Open Sans&quot;, Arial, sans-serif;\">Telefon:</h5><p style=\"margin-bottom: 20px; padding: 0px; border: 0px; vertical-align: baseline; line-height: 22px; color: rgb(119, 119, 119);\">+90 332 238 1071</p><h5 style=\"margin-bottom: 0px; padding: 0px; border: 0px; vertical-align: baseline; line-height: 1; font-size: 15px; color: rgb(119, 119, 119); font-family: &quot;Open Sans&quot;, Arial, sans-serif;\">Fax:</h5><p style=\"margin-bottom: 20px; padding: 0px; border: 0px; vertical-align: baseline; line-height: 22px; color: rgb(119, 119, 119);\">+90 332 238 0174</p>', NULL, 1, '', '', '', '', '+90 332 238 1071', 'Hazım Uluşahin İş Merkezi C Blok Kat : 6 No: 604 Selçuklu/KONYA', 'amedya@amedya.com.tr', '<iframe src=\"https://www.google.com/maps/embed?pb=!1m14!1m8!1m3!1d6298.58155614622!2d32.481056!3d37.876882!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x0%3A0xac29ddce2e6195bf!2zQW1lZHlhIFJla2xhbSBWZSDEsGxldGnFn2ltIEEuxZ4u!5e0!3m2!1str!2sus!4v1531295572777\" width=\"100%\" height=\"400\" frameborder=\"0\" style=\"border:0\" allowfullscreen=\"\"></iframe>', 'Pzt-Cmt: 9.30-18.30', '', '', '', ''),
(90, 46, 'İletişim Bilgileri', '<p><strong style=\"color: rgb(0, 0, 0); margin: 0px; padding: 0px; font-size: 14px; text-align: justify;\">Telefon :&nbsp;</strong><span style=\"margin: 0px; padding: 0px; font-size: 14px; text-align: justify;\">+90 332 999 99 98</span></p><p><span style=\"margin: 0px; padding: 0px; font-size: 14px; text-align: justify;\"><strong style=\"color: rgb(0, 0, 0); margin: 0px; padding: 0px;\">Fax:&nbsp;</strong><span style=\"margin: 0px; padding: 0px;\">+90 332 999 99 99</span></span></p><p><span style=\"margin: 0px; padding: 0px; font-size: 14px; text-align: justify;\"><span style=\"margin: 0px; padding: 0px;\"><strong style=\"color: rgb(0, 0, 0); margin: 0px; padding: 0px;\">Eposta:&nbsp;</strong><span style=\"margin: 0px; padding: 0px;\">bilgi@asm.com</span><br></span><br></span></p><p><strong style=\"margin: 0px; padding: 0px; color: rgb(0, 0, 0); font-size: 14px; text-align: justify;\">Lorem Ipsum</strong><span style=\"font-size: 14px; text-align: justify;\">, dizgi ve baskı endüstrisinde kullanılan mıgır metinlerdir.</span><br></p>', NULL, 2, '', '', '', '', '+90 332 999 99 98', '+90 332 999 99 99', 'bilgi@asm.com', '<iframe src=\"https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d201550.39177761006!2d32.36639818662086!3d37.87842350771473!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x14d08568d615f745%3A0x240dd0fc08060967!2sKonya!5e0!3m2!1str!2str!4v1518701936596\" width=\"100%\" height=\"250\" frameborder=\"0\" style=\"border:0\" allowfullscreen></iframe>', NULL, NULL, NULL, NULL, NULL),
(96, 52, 'Hakkımızda', '<p style=\"box-sizing: border-box; margin: 20px 0px 0px; padding: 0px; border: 0px; vertical-align: baseline; line-height: 22px; font-size: 13px;\">Amedya A.Ş , yenilikçi ve istikrarlı kimliğiyle Türkiye’de sektörel yayıncılığa yön veren İhlas Dergi Gurubu, Pegasus Magazin Ve Capital Dergisinin Konya Bolge temsilcisidir.</p><p style=\"box-sizing: border-box; margin: 20px 0px 0px; padding: 0px; border: 0px; vertical-align: baseline; line-height: 22px; font-size: 13px;\"><span style=\"box-sizing: border-box; margin: 0px; padding: 0px; border: 0px; vertical-align: baseline;\">1994 yılından beri sektorel dergilerle firmaların tanıtımını yapan Amedya A.Ş &nbsp;, çocuk, yemek, tekstil, ekonomi, otomotiv, yapı, güzellik, sağlık, bilişim ve dijital dallarında yayınladığı dergileri ile dünya çapında önemli marka ve kuruluşlarla çalışmakta ve sektöründe önemli atılımlar yapmaya devam etmektedir.</span><span style=\"box-sizing: border-box; margin: 0px; padding: 0px; border: 0px; vertical-align: baseline;\"></span></p><p style=\"box-sizing: border-box; margin: 20px 0px 0px; padding: 0px; border: 0px; vertical-align: baseline; line-height: 22px; font-size: 13px;\"><span style=\"box-sizing: border-box; margin: 0px; padding: 0px; border: 0px; vertical-align: baseline;\">Sektörel yayıncılıktaki başarısını internet yayıncılığına da taşıyan Amedya Google sertifikalı iş ortagı olup. Farklı sektörlere yönelik internet reklam calısmaları yapmaktadır.</span><span style=\"box-sizing: border-box; margin: 0px; padding: 0px; border: 0px; vertical-align: baseline;\"></span></p><p style=\"box-sizing: border-box; margin: 20px 0px 0px; padding: 0px; border: 0px; vertical-align: baseline; line-height: 22px; font-size: 13px;\"><span style=\"box-sizing: border-box; margin: 0px; padding: 0px; border: 0px; vertical-align: baseline;\">Hemen hemen bütün sektörlere yönelik dergisi bulunan AMEDYA ‘nın temsilcisi oldugu yayınların tamamı sektörlerinde Türkiye’de bir numara, dünyada ise en büyükler arasındadır.</span><span style=\"box-sizing: border-box; margin: 0px; padding: 0px; border: 0px; vertical-align: baseline;\"></span></p><p style=\"box-sizing: border-box; margin: 20px 0px 0px; padding: 0px; border: 0px; vertical-align: baseline; line-height: 22px; font-size: 13px;\"><span style=\"box-sizing: border-box; margin: 0px; padding: 0px; border: 0px; vertical-align: baseline;\">Amedya, kurulduğu günden itibaren sürdürdüğü kaliteli ve ilkeli yayıncılığı, istikrarı, profesyonel, etik değerlere saygılı, kalite odaklı bakış açısı, güven ve sadakat duygusunu sürekli güncel tutmaktadır.</span><span style=\"box-sizing: border-box; margin: 0px; padding: 0px; border: 0px; vertical-align: baseline;\"></span></p><p style=\"box-sizing: border-box; margin: 20px 0px 0px; padding: 0px; border: 0px; vertical-align: baseline; line-height: 22px; font-size: 13px;\"><span style=\"box-sizing: border-box; margin: 0px; padding: 0px; border: 0px; vertical-align: baseline;\">Amedya, yaptığı atılımlar ve Türk medya endüstrisine kattığı yeniliklerle sürekli olarak bir gelişim, fark oluşturma beklentisini doğurmakta ve bu beklentileri karşılama motivasyonu ile ilerlemektedir.</span></p><p style=\"margin-bottom: 15px; padding: 0px; text-align: justify; font-size: 14px;\"><strong style=\"margin: 0px; padding: 0px; border: 0px; vertical-align: baseline; color: rgb(119, 119, 119); font-size: 13px; text-align: start;\"></strong></p><p style=\"box-sizing: border-box; margin: 20px 0px 0px; padding: 0px; border: 0px; vertical-align: baseline; line-height: 22px; font-size: 13px;\">Amedya&nbsp; Konya icin ozel hazırlamıs oldugu Konya Exports Konya Automotive ve Tarım tr Dergileri ile de Konya Sanayisine ve Konyalı firmalara yardımcı olmayı ve onları Ulasal ve ulaslarası alanlarda tanıtmayı da vazife edinmistir.</p>', NULL, 1, '', '', '', '', '', '', '', '', '', '', '', '', ''),
(97, 52, 'Hakkımızda', '<p><br></p><table border=\"0\" width=\"100%\" cellspacing=\"0\" cellpadding=\"0\" style=\"font-family: &quot;Times New Roman&quot;; background-color: rgb(250, 250, 250);\"><tbody><tr><td><table border=\"0\" width=\"100%\" cellspacing=\"0\" cellpadding=\"0\"><tbody><tr><td width=\"600\" valign=\"top\"><table border=\"0\" width=\"100%\" cellspacing=\"0\" cellpadding=\"0\"><tbody><tr><td><p align=\"justify\"><font face=\"Arial\" style=\"font-size: 9pt; font-weight: 700;\">MOGESAN MOTOR GÖMLEK PİSTON SANAYİ VE TİC. LTD. ŞTİ.</font></p></td></tr><tr><td><font face=\"Arial\" style=\"font-size: 9pt;\"><img border=\"0\" src=\"http://www.mogesan.com/images/ccc_hak.jpg\" width=\"1\" height=\"11\"></font></td></tr><tr><td><p align=\"justify\"><font face=\"Arial\" style=\"font-size: 9pt;\">Mogesan 1994 yılında Konya Motorlu Araçlar Sanayisinde atölye ölçeğindeki işletmesinde kısıtlı imkânlarla içten yanmalı motorlara ait silindir gömleklerinin imalatı ile faaliyete başlamıştır. 1999 yılında zafer sanayine taşınarak faaliyetine devam etmiştir. bulunduğu yerin darlığından dolayı artan taleplere cevap veremez olduğu için 250 m2 olan imalat alanını 600 m2 ye çıkarmıştır. 2001 yılında imalat alanını 1000 m2 ye çıkartıp piston imalatına başlamıştır.Piston imalatında genişleyip büyüme sağlanmış, bulunduğu yerin kapalı alanı küçük gelmeye başlamış 2003 yılında Konya 1. Organize Sanayi Bölgesi’nde 7500 m2 arsa üzerine kurulu 4500 m2 kapalı alana sahip iş yerine taşınmış kendini yenileyerek, geliştirerek halen burada imalatına devam etmektedir. Mogesan 2013 yılının ortalarından sonra Konya 2. Organize Sanayi Bölgesindeki toplam 30.000 m2 alan üzerine kurulu yeni fabrikasına taşınmayı hedeflemektedir.</font></p></td></tr></tbody></table></td></tr></tbody></table></td></tr><tr><td><img border=\"0\" src=\"http://www.mogesan.com/images/ccc_hak.jpg\" width=\"1\" height=\"12\"></td></tr><tr><td><p align=\"justify\"><font face=\"Arial\" style=\"font-size: 9pt;\">Ürün kalitemizi sürekli olarak geliştirmek, tüm çalışanlarımızın müşteri memnuniyetini ilke edinmesini sağlamak amacıyla 2005 yılında TS-EN-ISO 9001:2000 Kalite Güvence Sistemini kurmuş ve uygulamakta olan kuruluşumuz, 2010 yılında da yeni kalite revizyonları gerçekleştirerek TS-EN-ISO 9001:2008 Kalite Güvence Sistemini kurmuş ve iç pazarda ve resmi/tüzel kuruluşlarda pazar payını artırmak için TS 1106 (Pistonlar-Alüminyum Alaşımı-Benzin ve Diesel Motorları İçin), TS 482 (İçten Yanmalı Motorlar Silindir Gömlekleri) standardı belgesini almıştır ve uygulamaya devam ermektedir.<br><br>Kuruluşumuzda, belirlenen şartlara uygun ürün üretimin güvence altına alınmasını sağlamak amacıyla hammadde girişinden sevkiyata kadar ki tüm aşamalarda kalite kontrolü uygulanmaktadır.<br><br>Çalışan personelimizin yeterliliği, bilinci ve eğitimi sürekli olarak artırılarak üretimin ve hizmetin eksiksiz yapılması sağlanmaktadır.<br><br>MOGESAN Motor Gömlek Piston Sanayi ve Tic. Ltd. Şti. yılda 260.000 adet piston ve 140.000 adet motor gömleği imalatı yapmaktadır. Ürettiği piston ve motor gömleklerin yaklaşık % 75 ini doğrudan ve dolaylı olarak yurt dışına ihraç etmekte ve ürettiği ürünlerin geri kalanını da yurt içinde pazarlamaktadır. İç ve dış pazarda müşterilerimizin beğenisini kazanan ürünlerimiz başta Ortadoğu ve Afrika olmak üzere 60 ın üzerinde ülkeye ihraç edilmektedir.<br><br>Kaliteden taviz vermeden en üst düzeyde müşteri memnuniyeti sağlamayı amaç edinen kuruluşumuz, müşteri istekleri, teknolojik gelişmeler ve sipariş artışına bağlı olarak teknik imkanlarını geliştirmeyi ve üretim kapasitesini artırmayı sürdürmektedir.<br><br>Mogesan; bu gelişmelerin sonucunda müşterilerimize ulusal ve uluslararası standartların öngördüğü kalite özelliklerine sahip ürünler sunmaya devam edecek, üretim kapasitemizi yükselterek işgücü istihdamının artırılması, ihracat yapılan ülkelerin özellikle AB ülkelerinin sayısının artması düşünüldüğünden, kuruluşumuzun karlılığı yükselecek, ülke ekonomisine olan katkıda büyüme olacak ve bu sayede müşterilerimizin, işverenimizin ve çalışanlarımızın memnuniyetinin artırılması sağlanacaktır.<br><br>MOGESAN, ürün kalitesinin sürekliliği ve müşteri memnuniyetine verdiği önem ile 21. yüzyılda bir dünya markası olmayı hedeflemektedir.</font></p></td></tr></tbody></table>', NULL, 2, NULL, NULL, NULL, NULL, '', '', '', '', '', '', '', '', NULL),
(198, 103, 'Konya Export', '<p>Yılda bir kez cıkarttığı Yayınımız 10.000 adet basılıp Konya da buyuk ve orta olcekli firmalara ( kobilere ) 3.000 adet dagıtılmakta ,yine ofislerimizin oldugu İzmir, Ankara, Denizli, Bursa ve merkez İSTANBUL da da kobilere ve sanayiye 2.500 adet dagıtılmaktadır. 3.000 Adet yurt dısı adres gonderisi yapılan Yaynımız ayrıca.yurtdısında belirlenen sektorlerin en secme 3-4 fuarında da 1.500 adet dagıtılmaktadır. KONYA’mızın yurt içi ve dışında daha iyi tanıtılabilmesi icin konyanın sanayi, ekonomi, turizm ve sehircilik olarak incelendigi ve anlatıldıgı bir yayındır.<br></p>', NULL, 1, NULL, NULL, NULL, NULL, 'http://www.konyaexports.com/', '', '', '', '', '', '', '', NULL),
(199, 103, 'Konya Export', '<p>Yılda bir kez cıkarttığı Yayınımız 10.000 adet basılıp Konya da buyuk ve orta olcekli firmalara ( kobilere ) 3.000 adet dagıtılmakta ,yine ofislerimizin oldugu İzmir, Ankara, Denizli, Bursa ve merkez İSTANBUL da da kobilere ve sanayiye 2.500 adet dagıtılmaktadır. 3.000 Adet yurt dısı adres gonderisi yapılan Yaynımız ayrıca.yurtdısında belirlenen sektorlerin en secme 3-4 fuarında da 1.500 adet dagıtılmaktadır. KONYA’mızın yurt içi ve dışında daha iyi tanıtılabilmesi icin konyanın sanayi, ekonomi, turizm ve sehircilik olarak incelendigi ve anlatıldıgı bir yayındır.<br></p>', NULL, 2, NULL, NULL, NULL, NULL, 'http://www.konyaexports.com/', '', '', '', '', '', '', '', NULL),
(200, 104, 'Tarım TR', '<p>Dogru, güvenilir ve objektif olarak tarım dünyasından haber almak isteyen herkese; çiftçimize,sanayicilerimize, ziraatçilerimize, tarıma gönül veren derneklerden, kooperatiflere varıncaya kadar tüm tarım dünyasına 5 yıldır hizmet vermenin mutluluğunu yaşıyoruz.<br></p>', NULL, 1, NULL, NULL, NULL, NULL, 'http://www.tarimtr.com/', '', '', '', '', '', '', '', NULL),
(201, 104, 'Tarım TR', '<p>Dogru, güvenilir ve objektif olarak tarım dünyasından haber almak isteyen herkese; çiftçimize,sanayicilerimize, ziraatçilerimize, tarıma gönül veren derneklerden, kooperatiflere varıncaya kadar tüm tarım dünyasına 5 yıldır hizmet vermenin mutluluğunu yaşıyoruz.<br></p>', NULL, 2, NULL, NULL, NULL, NULL, 'http://www.tarimtr.com/', '', '', '', '', '', '', '', NULL),
(202, 105, 'Konya Automotive', '<p style=\"margin-bottom: 20px; padding: 0px; border: 0px; vertical-align: baseline; line-height: 22px;\"><span style=\"border-style: initial; border-color: initial; border-image: initial;\">KONYA AUTOMOTİVE ile yedek parça sektörünü tek kaynaktan görebilmek ..</span></p><p style=\"margin-bottom: 20px; padding: 0px; border: 0px; vertical-align: baseline; line-height: 22px;\">Yedek parça sektörümdeli çeşitliliği ve kalitenizi&nbsp;<span style=\"border-style: initial; border-color: initial; border-image: initial;\">KONYA AUTOMOTİVE</span>&nbsp;den yansıtın.<br>Geniş dağıtım ağıyla sesinizi dünyaya duyuralım .&nbsp;</p>', NULL, 1, NULL, NULL, NULL, NULL, 'http://www.konyaautomotive.com/', '', '', '', '', '', '', '', NULL),
(203, 105, 'Konya Automotive', '<p style=\"margin-bottom: 20px; padding: 0px; border: 0px; vertical-align: baseline; line-height: 22px;\"><span style=\"border-style: initial; border-color: initial; border-image: initial;\">KONYA AUTOMOTİVE ile yedek parça sektörünü tek kaynaktan görebilmek ..</span></p><p style=\"margin-bottom: 20px; padding: 0px; border: 0px; vertical-align: baseline; line-height: 22px;\">Yedek parça sektörümdeli çeşitliliği ve kalitenizi&nbsp;<span style=\"border-style: initial; border-color: initial; border-image: initial;\">KONYA AUTOMOTİVE</span>&nbsp;den yansıtın.<br>Geniş dağıtım ağıyla sesinizi dünyaya duyuralım .&nbsp;</p>', NULL, 2, NULL, NULL, NULL, NULL, 'http://www.konyaautomotive.com/', '', '', '', '', '', '', '', NULL),
(204, 106, 'Dijital Medya', '<h4 style=\"padding: 0px; border: 0px; vertical-align: baseline; line-height: 1;\">Dijital Medya Planlama Ve Satın Alma</h4><p style=\"margin-bottom: 20px; padding: 0px; border: 0px; vertical-align: baseline; line-height: 22px;\"><span style=\"border-style: initial; border-color: initial; border-image: initial;\">DOĞRU EKİP…</span></p><p style=\"margin-bottom: 20px; padding: 0px; border: 0px; vertical-align: baseline; line-height: 22px;\"><span style=\"border-style: initial; border-color: initial; border-image: initial;\">DOĞRU İŞ…</span></p><p style=\"margin-bottom: 20px; padding: 0px; border: 0px; vertical-align: baseline; line-height: 22px;\"><span style=\"border-style: initial; border-color: initial; border-image: initial;\">DOĞRU SONUÇ…</span></p><p style=\"margin-bottom: 20px; padding: 0px; border: 0px; vertical-align: baseline; line-height: 22px;\">İnternet mecrasında dijital reklamların yükselişe geçmesi, medya planlama ve satınalma ajanslarında dijital mecralara yönelik planlamaların artmasına ve uzmanlığı sadece internet mecrasında dijital medya planlama ve satınalma olan ajansların doğmasına sebep olmuştur. 1994 yılından başladığımız geleneksel medya planlama ve satışına, 2009 yılında müşteri portföyümüzün ve tecrübelerimizin verdiği güç ile dijital medya servisini de dahil ettik.</p><p style=\"margin-bottom: 20px; padding: 0px; border: 0px; vertical-align: baseline; line-height: 22px;\">Dijital medya planlamasının amacı; dijital medya analizi ve medya planlaması çerçevesinde, verilecek mesajın istenilen hedef kitleye mümkün olduğunca etkin bir şekilde ulaşmasını sağlamaktır.</p><p style=\"margin-bottom: 20px; padding: 0px; border: 0px; vertical-align: baseline; line-height: 22px;\">Ancak reklam mesajımız ne kadar çarpıcı ve etkili olursa olsun, hedef kitleye ulaşmamızı sağlayacak olan medya aracını yanlış seçmemiz halinde, belki mesajımızın duyulması hatta hakkında söz edilmesi sağlanır, fakat istenen geri dönüş elde edilemeyebilir.</p><p style=\"margin-bottom: 20px; padding: 0px; border: 0px; vertical-align: baseline; line-height: 22px;\">Ajansımız dijital medya planlamasını yapmadan önce kurum veya marka ile görüşerek, yapılacak olan çalışmanın esas amaçlarını (Kampanyanın satışa yönelik mi? Marka bilinirliğine yönelik mi? Üyelik ya da site ziyaretini arttırmaya yönelik mi olduğu) ve hedef kitlesini belirler. Edinilen bilgiler doğrultusunda size en uygun planlamayı ve bütçeyi hazırlar.&nbsp;</p><p style=\"margin-bottom: 20px; padding: 0px; border: 0px; vertical-align: baseline; line-height: 22px;\">Yapılan planlama esnasında, hedef kitle, mecraların demografik dağılımları, kampanya hedefleri, fiyatlar, geçmiş kampanya tecrübeleri gibi birçok veri kullanılarak, bütçenin en yüksek geri dönüşü sağlayacak planlama hazırlanır.&nbsp;<br><br>Dijital medya planlama sürecinde verilmek istenilen mesajın hangi tüketici kitlesine ulaştırılacağı, kampanyaların hangi aralıklar ile yayınlanacağı önceden tespit edilmelidir.&nbsp;</p><p style=\"margin-bottom: 20px; padding: 0px; border: 0px; vertical-align: baseline; line-height: 22px;\">Dijital medya planının en önemli unsuru, belirlenen kurguların nasıl sonuçlar doğurduğu ve geri dönüşlerin faydalı olup olmadığını gözlemlemek ve raporlamaktır.</p><p style=\"margin-bottom: 20px; padding: 0px; border: 0px; vertical-align: baseline; line-height: 22px;\">Kaliteli hizmet anlayışını kendisine ilke edinmiş, dijital medya planlaması alanında uzman ekip ve çözüm ortaklarıyla şuana kadar firma ve kurumlara hizmet vermiş olan ajansımız ile çalışmalarınızı yürütmeniz sizi hedefinize sorunsuz ve bir şekilde ulaştıracaktır.&nbsp;</p><p style=\"margin-bottom: 20px; padding: 0px; border: 0px; vertical-align: baseline; line-height: 22px;\">&nbsp;</p><p style=\"margin-bottom: 20px; padding: 0px; border: 0px; vertical-align: baseline; line-height: 22px;\"><span style=\"border-style: initial; border-color: initial; border-image: initial;\">Özetle;</span></p><p style=\"margin-bottom: 20px; padding: 0px; border: 0px; vertical-align: baseline; line-height: 22px;\"><span style=\"border-style: initial; border-color: initial; border-image: initial;\">&nbsp;Online Pazarlama Çözümümüz</span></p><ul style=\"margin-bottom: 0px; margin-left: 0px; border: 0px; vertical-align: baseline; list-style: none;\"><li style=\"margin: 0px; padding: 0px; border: 0px; vertical-align: baseline; list-style: none;\">Markanıza özel butik hizmet,</li><li style=\"margin: 0px; padding: 0px; border: 0px; vertical-align: baseline; list-style: none;\">Kısa sürede sonuç,</li><li style=\"margin: 0px; padding: 0px; border: 0px; vertical-align: baseline; list-style: none;\">İnceler, araştırır, sorgular ve planlar,</li><li style=\"margin: 0px; padding: 0px; border: 0px; vertical-align: baseline; list-style: none;\">Netlik ve ölçülebilirlik kazandırır,</li><li style=\"margin: 0px; padding: 0px; border: 0px; vertical-align: baseline; list-style: none;\">Şeffaf ve analitik yapı ile<br>Online dünyayı markanız için tasarlar.</li></ul>', NULL, 1, NULL, NULL, NULL, NULL, '', '', '', '', '', '', '', '', NULL),
(205, 106, 'Dijital Medya', '<h4 style=\"padding: 0px; border: 0px; vertical-align: baseline; line-height: 1;\">Dijital Medya Planlama Ve Satın Alma</h4><p style=\"margin-bottom: 20px; padding: 0px; border: 0px; vertical-align: baseline; line-height: 22px;\"><span style=\"border-style: initial; border-color: initial; border-image: initial;\">DOĞRU EKİP…</span></p><p style=\"margin-bottom: 20px; padding: 0px; border: 0px; vertical-align: baseline; line-height: 22px;\"><span style=\"border-style: initial; border-color: initial; border-image: initial;\">DOĞRU İŞ…</span></p><p style=\"margin-bottom: 20px; padding: 0px; border: 0px; vertical-align: baseline; line-height: 22px;\"><span style=\"border-style: initial; border-color: initial; border-image: initial;\">DOĞRU SONUÇ…</span></p><p style=\"margin-bottom: 20px; padding: 0px; border: 0px; vertical-align: baseline; line-height: 22px;\">İnternet mecrasında dijital reklamların yükselişe geçmesi, medya planlama ve satınalma ajanslarında dijital mecralara yönelik planlamaların artmasına ve uzmanlığı sadece internet mecrasında dijital medya planlama ve satınalma olan ajansların doğmasına sebep olmuştur. 1994 yılından başladığımız geleneksel medya planlama ve satışına, 2009 yılında müşteri portföyümüzün ve tecrübelerimizin verdiği güç ile dijital medya servisini de dahil ettik.</p><p style=\"margin-bottom: 20px; padding: 0px; border: 0px; vertical-align: baseline; line-height: 22px;\">Dijital medya planlamasının amacı; dijital medya analizi ve medya planlaması çerçevesinde, verilecek mesajın istenilen hedef kitleye mümkün olduğunca etkin bir şekilde ulaşmasını sağlamaktır.</p><p style=\"margin-bottom: 20px; padding: 0px; border: 0px; vertical-align: baseline; line-height: 22px;\">Ancak reklam mesajımız ne kadar çarpıcı ve etkili olursa olsun, hedef kitleye ulaşmamızı sağlayacak olan medya aracını yanlış seçmemiz halinde, belki mesajımızın duyulması hatta hakkında söz edilmesi sağlanır, fakat istenen geri dönüş elde edilemeyebilir.</p><p style=\"margin-bottom: 20px; padding: 0px; border: 0px; vertical-align: baseline; line-height: 22px;\">Ajansımız dijital medya planlamasını yapmadan önce kurum veya marka ile görüşerek, yapılacak olan çalışmanın esas amaçlarını (Kampanyanın satışa yönelik mi? Marka bilinirliğine yönelik mi? Üyelik ya da site ziyaretini arttırmaya yönelik mi olduğu) ve hedef kitlesini belirler. Edinilen bilgiler doğrultusunda size en uygun planlamayı ve bütçeyi hazırlar.&nbsp;</p><p style=\"margin-bottom: 20px; padding: 0px; border: 0px; vertical-align: baseline; line-height: 22px;\">Yapılan planlama esnasında, hedef kitle, mecraların demografik dağılımları, kampanya hedefleri, fiyatlar, geçmiş kampanya tecrübeleri gibi birçok veri kullanılarak, bütçenin en yüksek geri dönüşü sağlayacak planlama hazırlanır.&nbsp;<br><br>Dijital medya planlama sürecinde verilmek istenilen mesajın hangi tüketici kitlesine ulaştırılacağı, kampanyaların hangi aralıklar ile yayınlanacağı önceden tespit edilmelidir.&nbsp;</p><p style=\"margin-bottom: 20px; padding: 0px; border: 0px; vertical-align: baseline; line-height: 22px;\">Dijital medya planının en önemli unsuru, belirlenen kurguların nasıl sonuçlar doğurduğu ve geri dönüşlerin faydalı olup olmadığını gözlemlemek ve raporlamaktır.</p><p style=\"margin-bottom: 20px; padding: 0px; border: 0px; vertical-align: baseline; line-height: 22px;\">Kaliteli hizmet anlayışını kendisine ilke edinmiş, dijital medya planlaması alanında uzman ekip ve çözüm ortaklarıyla şuana kadar firma ve kurumlara hizmet vermiş olan ajansımız ile çalışmalarınızı yürütmeniz sizi hedefinize sorunsuz ve bir şekilde ulaştıracaktır.&nbsp;</p><p style=\"margin-bottom: 20px; padding: 0px; border: 0px; vertical-align: baseline; line-height: 22px;\">&nbsp;</p><p style=\"margin-bottom: 20px; padding: 0px; border: 0px; vertical-align: baseline; line-height: 22px;\"><span style=\"border-style: initial; border-color: initial; border-image: initial;\">Özetle;</span></p><p style=\"margin-bottom: 20px; padding: 0px; border: 0px; vertical-align: baseline; line-height: 22px;\"><span style=\"border-style: initial; border-color: initial; border-image: initial;\">&nbsp;Online Pazarlama Çözümümüz</span></p><ul style=\"margin-bottom: 0px; margin-left: 0px; border: 0px; vertical-align: baseline; list-style: none;\"><li style=\"margin: 0px; padding: 0px; border: 0px; vertical-align: baseline; list-style: none;\">Markanıza özel butik hizmet,</li><li style=\"margin: 0px; padding: 0px; border: 0px; vertical-align: baseline; list-style: none;\">Kısa sürede sonuç,</li><li style=\"margin: 0px; padding: 0px; border: 0px; vertical-align: baseline; list-style: none;\">İnceler, araştırır, sorgular ve planlar,</li><li style=\"margin: 0px; padding: 0px; border: 0px; vertical-align: baseline; list-style: none;\">Netlik ve ölçülebilirlik kazandırır,</li><li style=\"margin: 0px; padding: 0px; border: 0px; vertical-align: baseline; list-style: none;\">Şeffaf ve analitik yapı ile<br>Online dünyayı markanız için tasarlar.</li></ul>', NULL, 2, NULL, NULL, NULL, NULL, '', '', '', '', '', '', '', '', NULL),
(206, 107, 'Türkiye Gazetesi', '<p class=\"MsoNormal\" style=\"margin-bottom: 20px; padding: 0px; border: 0px; vertical-align: baseline; line-height: 22px;\"><span style=\"border-style: initial; border-color: initial; border-image: initial;\">İşletmenize ve markanıza değer katacak reklam çalışmalarında gazete reklamlarının katkısı tartışılmaz.</span></p><p class=\"MsoNormal\" style=\"margin-bottom: 20px; padding: 0px; border: 0px; vertical-align: baseline; line-height: 22px;\">Sanayi işletmelerimiz istihdam oluşturma, piyasa koşullarına uyma ve ekonomik kalkınmaya katkı sağlama yetenekleri sayesinde hem gelişmiş hem gelişmekte olan ekonomiler için büyük önem taşımaktadır.</p><p class=\"MsoNormal\" style=\"margin-bottom: 20px; padding: 0px; border: 0px; vertical-align: baseline; line-height: 22px;\">Çoğunluk okuyucuları işletmeler oluşan Türkiye Gazetesi, ekonomimizin her geçen gün gelişmesi ve işletmelerimizin dünya pazarında hak ettiği yerlere gelmesi için tanıtım ve pazarlama faaliyetlerinizin başarıya ulaşması için profesyonel ve ekonomik çözümlerle yanınızda.</p>', NULL, 1, NULL, NULL, NULL, NULL, '', '', '', '', '', '', '', '', NULL),
(207, 107, 'Türkiye Gazetesi', '<p class=\"MsoNormal\" style=\"margin-bottom: 20px; padding: 0px; border: 0px; vertical-align: baseline; line-height: 22px;\"><span style=\"border-style: initial; border-color: initial; border-image: initial;\">İşletmenize ve markanıza değer katacak reklam çalışmalarında gazete reklamlarının katkısı tartışılmaz.</span></p><p class=\"MsoNormal\" style=\"margin-bottom: 20px; padding: 0px; border: 0px; vertical-align: baseline; line-height: 22px;\">Sanayi işletmelerimiz istihdam oluşturma, piyasa koşullarına uyma ve ekonomik kalkınmaya katkı sağlama yetenekleri sayesinde hem gelişmiş hem gelişmekte olan ekonomiler için büyük önem taşımaktadır.</p><p class=\"MsoNormal\" style=\"margin-bottom: 20px; padding: 0px; border: 0px; vertical-align: baseline; line-height: 22px;\">Çoğunluk okuyucuları işletmeler oluşan Türkiye Gazetesi, ekonomimizin her geçen gün gelişmesi ve işletmelerimizin dünya pazarında hak ettiği yerlere gelmesi için tanıtım ve pazarlama faaliyetlerinizin başarıya ulaşması için profesyonel ve ekonomik çözümlerle yanınızda.</p>', NULL, 2, NULL, NULL, NULL, NULL, '', '', '', '', '', '', '', '', NULL),
(208, 108, 'Pegasus Magazin', '<p class=\"MsoNormal\" style=\"margin-bottom: 20px; padding: 0px; border: 0px; vertical-align: baseline; line-height: 22px;\">Pegasus Magazine, Pegasus Havayollarına ait yurtiçi ve yurtdışı tüm uçaklarda dağıtılan içeriğindeki konuları İngilizce ve Türkçe olarak veren özel bir dergidir. Türkiye’nin tarihi, turistik ve kültürel değerlerini tanıtan konular, Türk ünlülerini anlatan portreler, yaşam tarzına yönelik konular, teknolojik ürün haberleri, alışveriş sayfaları, uluslar arası etkinlikler, kültür, müzik ve sanat haberleri, yolculuk ve gezi rotaları, gurme, uçuş ve havacılıkla ilgili konular ve Pegasus Havayolları ile ilgili güncel bilgiler derginin içeriğini oluşturuyor.</p><p class=\"MsoNormal\" style=\"margin-bottom: 20px; padding: 0px; border: 0px; vertical-align: baseline; line-height: 22px;\"><span style=\"border-style: initial; border-color: initial; border-image: initial;\">HEDEF KİTLESİ</span></p><p class=\"MsoNormal\" style=\"margin-bottom: 20px; padding: 0px; border: 0px; vertical-align: baseline; line-height: 22px;\">Pegasus Magazin oldukça geniş bir okur kitlesiyle buluşmaktadır. Yurtiçi ve yurtdışına uçakla seyahat etmeyi tercih edenler, sık seyahat eden iş insanları, turistik amaçla seyahat edenler, yurtdışında yaşayanlar… Dolayısıyla çok farklı yaşam tarzı olan, bunun yanında yüksek sosyo-ekonomik statüdeki binlerce kişi Pegasus Magazin’in sayfalarında buluşuyor.</p><p class=\"MsoNormal\" style=\"margin-bottom: 20px; padding: 0px; border: 0px; vertical-align: baseline; line-height: 22px;\"><span style=\"border-style: initial; border-color: initial; border-image: initial;\">KONUMLANDIRMA</span></p><p class=\"MsoNormal\" style=\"margin-bottom: 20px; padding: 0px; border: 0px; vertical-align: baseline; line-height: 22px;\">Pegasus Magazine, uçak yolcularını, zengin içeriği ile bilgilendirirken aynı zamanda keyifli bir yolculuk geçirme imkanı da sunan güçlü bir dergidir.</p><p class=\"MsoNormal\" style=\"margin-bottom: 20px; padding: 0px; border: 0px; vertical-align: baseline; line-height: 22px;\">Pegasus yeni hatları ile yurtiçinde 31 yurtdışında 64 olmak üzere toplamda 37 ülkede 95 noktaya tarifeli seferler düzenlemektedir.</p><p class=\"MsoNormal\" style=\"margin-bottom: 20px; padding: 0px; border: 0px; vertical-align: baseline; line-height: 22px;\">Aylık 100.000 tirajı olan&nbsp; dergimiz&nbsp; 2 milyon okuyucuya ulasmaktadır.</p>', NULL, 1, NULL, NULL, NULL, NULL, 'http://www.amedya.eu/dergiler/pegasus/index.html', '', '', '', '', '', '', '', NULL),
(209, 108, 'Pegasus Magazin', '<p class=\"MsoNormal\" style=\"margin-bottom: 20px; padding: 0px; border: 0px; vertical-align: baseline; line-height: 22px;\">Pegasus Magazine, Pegasus Havayollarına ait yurtiçi ve yurtdışı tüm uçaklarda dağıtılan içeriğindeki konuları İngilizce ve Türkçe olarak veren özel bir dergidir. Türkiye’nin tarihi, turistik ve kültürel değerlerini tanıtan konular, Türk ünlülerini anlatan portreler, yaşam tarzına yönelik konular, teknolojik ürün haberleri, alışveriş sayfaları, uluslar arası etkinlikler, kültür, müzik ve sanat haberleri, yolculuk ve gezi rotaları, gurme, uçuş ve havacılıkla ilgili konular ve Pegasus Havayolları ile ilgili güncel bilgiler derginin içeriğini oluşturuyor.</p><p class=\"MsoNormal\" style=\"margin-bottom: 20px; padding: 0px; border: 0px; vertical-align: baseline; line-height: 22px;\"><span style=\"border-style: initial; border-color: initial; border-image: initial;\">HEDEF KİTLESİ</span></p><p class=\"MsoNormal\" style=\"margin-bottom: 20px; padding: 0px; border: 0px; vertical-align: baseline; line-height: 22px;\">Pegasus Magazin oldukça geniş bir okur kitlesiyle buluşmaktadır. Yurtiçi ve yurtdışına uçakla seyahat etmeyi tercih edenler, sık seyahat eden iş insanları, turistik amaçla seyahat edenler, yurtdışında yaşayanlar… Dolayısıyla çok farklı yaşam tarzı olan, bunun yanında yüksek sosyo-ekonomik statüdeki binlerce kişi Pegasus Magazin’in sayfalarında buluşuyor.</p><p class=\"MsoNormal\" style=\"margin-bottom: 20px; padding: 0px; border: 0px; vertical-align: baseline; line-height: 22px;\"><span style=\"border-style: initial; border-color: initial; border-image: initial;\">KONUMLANDIRMA</span></p><p class=\"MsoNormal\" style=\"margin-bottom: 20px; padding: 0px; border: 0px; vertical-align: baseline; line-height: 22px;\">Pegasus Magazine, uçak yolcularını, zengin içeriği ile bilgilendirirken aynı zamanda keyifli bir yolculuk geçirme imkanı da sunan güçlü bir dergidir.</p><p class=\"MsoNormal\" style=\"margin-bottom: 20px; padding: 0px; border: 0px; vertical-align: baseline; line-height: 22px;\">Pegasus yeni hatları ile yurtiçinde 31 yurtdışında 64 olmak üzere toplamda 37 ülkede 95 noktaya tarifeli seferler düzenlemektedir.</p><p class=\"MsoNormal\" style=\"margin-bottom: 20px; padding: 0px; border: 0px; vertical-align: baseline; line-height: 22px;\">Aylık 100.000 tirajı olan&nbsp; dergimiz&nbsp; 2 milyon okuyucuya ulasmaktadır.</p>', NULL, 2, NULL, NULL, NULL, NULL, 'http://www.amedya.eu/dergiler/pegasus/index.html', '', '', '', '', '', '', '', NULL),
(210, 109, 'E-Katalog', '<p>Artık ürün / hizmet katalogunuzu unutmak gibi bir derdiniz yok . Kataloğunuz daima yanınızda . İsterseniz cep telefonunuzdan, isterseniz tabletden, istersenizde bilgiyasayarınızda çok rahat bir şekilde kataloğunuza ulaşabileceksiniz . Hem sayfa atlama efektleriyle gerçek kitap/dergi tadına varacaksınız . Hemde hızlı erişim menüsü sayesinde derginizdeki reklam,hizmet,ürün vesaire bulunan sayfaları uğraşmadan bulabileceksiniz . Sayfa içi arama sayesinde &nbsp;istediğiniz bilgiye saniyeler içerisinde erişebileceksiniz.<br></p>', NULL, 1, NULL, NULL, NULL, NULL, 'http://www.amedya.eu/TR/Hizmetler/e-katalog/konyaexports.com/EKatalog/index.html', '', '', '', '', '', '', '', NULL),
(211, 109, 'E-Katalog', '<p>Artık ürün / hizmet katalogunuzu unutmak gibi bir derdiniz yok . Kataloğunuz daima yanınızda . İsterseniz cep telefonunuzdan, isterseniz tabletden, istersenizde bilgiyasayarınızda çok rahat bir şekilde kataloğunuza ulaşabileceksiniz . Hem sayfa atlama efektleriyle gerçek kitap/dergi tadına varacaksınız . Hemde hızlı erişim menüsü sayesinde derginizdeki reklam,hizmet,ürün vesaire bulunan sayfaları uğraşmadan bulabileceksiniz . Sayfa içi arama sayesinde &nbsp;istediğiniz bilgiye saniyeler içerisinde erişebileceksiniz.<br></p>', NULL, 2, NULL, NULL, NULL, NULL, 'http://www.amedya.eu/TR/Hizmetler/e-katalog/konyaexports.com/EKatalog/index.html', '', '', '', '', '', '', '', NULL),
(212, 110, 'Glober', '<p style=\"margin-bottom: 20px; padding: 0px; border: 0px; vertical-align: baseline; line-height: 22px;\"><span style=\"border-style: initial; border-color: initial; border-image: initial;\">GLOBER DERGİSİ INGILIZCE&nbsp; - TÜRKÇE OLARAK YAYIMLANIR.</span></p><p style=\"margin-bottom: 20px; padding: 0px; border: 0px; vertical-align: baseline; line-height: 22px;\">Ücretsiz yayımlandığı için okuyucuya ulaşmama ya da satılmama kaygısı yoktur. Prestijli bir yayın olan GLOBER dergisi, uçakla seyahat etmeyi tercih eden, gezmeyi seven, farklı etkinlikleri takip eden, eğitim ve gelir seviyesi bakımından orta ve üst seviyede bir okuyucu kitlesine her ay ulaşmaktadır. Atlas Global’in yurtdışı uçuşlarında Business Class’ı uygulayan tek havayolu olması ve firmalarla anlaşmalar yoluyla sürdürülen kurumsal politikalar neticesinde, yolcu profili ağırlıklı olarak iş adamları, üst düzey yönetici ve çalışan kesimden oluşmaktadır.</p><p style=\"margin-bottom: 20px; padding: 0px; border: 0px; vertical-align: baseline; line-height: 22px;\">28 Ucaga sahip atlas jetin&nbsp; tüm yurt ici ve yurt dısı uçuşlarında ucretsiz olarak misafirlerimize ulaşmaktadır.</p>', NULL, 1, NULL, NULL, NULL, NULL, '', '', '', '', '', '', '', '', NULL),
(213, 110, 'Glober', '<p style=\"margin-bottom: 20px; padding: 0px; border: 0px; vertical-align: baseline; line-height: 22px;\"><span style=\"border-style: initial; border-color: initial; border-image: initial;\">GLOBER DERGİSİ INGILIZCE&nbsp; - TÜRKÇE OLARAK YAYIMLANIR.</span></p><p style=\"margin-bottom: 20px; padding: 0px; border: 0px; vertical-align: baseline; line-height: 22px;\">Ücretsiz yayımlandığı için okuyucuya ulaşmama ya da satılmama kaygısı yoktur. Prestijli bir yayın olan GLOBER dergisi, uçakla seyahat etmeyi tercih eden, gezmeyi seven, farklı etkinlikleri takip eden, eğitim ve gelir seviyesi bakımından orta ve üst seviyede bir okuyucu kitlesine her ay ulaşmaktadır. Atlas Global’in yurtdışı uçuşlarında Business Class’ı uygulayan tek havayolu olması ve firmalarla anlaşmalar yoluyla sürdürülen kurumsal politikalar neticesinde, yolcu profili ağırlıklı olarak iş adamları, üst düzey yönetici ve çalışan kesimden oluşmaktadır.</p><p style=\"margin-bottom: 20px; padding: 0px; border: 0px; vertical-align: baseline; line-height: 22px;\">28 Ucaga sahip atlas jetin&nbsp; tüm yurt ici ve yurt dısı uçuşlarında ucretsiz olarak misafirlerimize ulaşmaktadır.</p>', NULL, 2, NULL, NULL, NULL, NULL, '', '', '', '', '', '', '', '', NULL),
(214, 111, 'SunTimes', '<p style=\"margin-bottom: 20px; padding: 0px; border: 0px; vertical-align: baseline; line-height: 22px;\">Türk Hava Yolları ile Lufthansa’nın ortak kuruluşu&nbsp; Sun Express 1989 yılında Antalya da kuruldu.</p><p style=\"margin-bottom: 20px; padding: 0px; border: 0px; vertical-align: baseline; line-height: 22px;\">Sun Express, Türkiye ve Almanya merkezli olmak üzere haftalık ortalama 110 destinasyona 1020 den fazla uçuş gerçekleştirmektedir.27 yıldır sektörün içince olan Sun Express toplamda 63 adet Boeing uçağıyla Avrupa’nın en modern filolarından biridir.%90 doluluk oranı ile yaklaşık 13 milyon dan fazla yolcuya hizmet veren Sun Express son yıllarda yakaladığı büyüme ile Türkiye’nin satışlarda en büyük 50 şirketi arasına girdi.</p><p style=\"margin-bottom: 20px; padding: 0px; border: 0px; vertical-align: baseline; line-height: 22px;\">Yolcuların uçak içinde keyifli zaman geçirmelerini sağlayan&nbsp;<span style=\"border-style: initial; border-color: initial; border-image: initial;\">Sun Times</span><font color=\"#777777\">&nbsp;</font>Destinasyonların yanı sıra teknoloji,yaşam eğlence ve bilgi dolu içeriği ,kaliteli görselleri,90 bin tirajı ve Türkçe- Almanca ve İngilizce dil seçenekleri&nbsp; ve modern 13 milyon Sun Express yolcusu ile buluşuyor.</p>', NULL, 1, NULL, NULL, NULL, NULL, '', '', '', '', '', '', '', '', NULL),
(215, 111, 'SunTimes', '<p style=\"margin-bottom: 20px; padding: 0px; border: 0px; vertical-align: baseline; line-height: 22px;\">Türk Hava Yolları ile Lufthansa’nın ortak kuruluşu&nbsp; Sun Express 1989 yılında Antalya da kuruldu.</p><p style=\"margin-bottom: 20px; padding: 0px; border: 0px; vertical-align: baseline; line-height: 22px;\">Sun Express, Türkiye ve Almanya merkezli olmak üzere haftalık ortalama 110 destinasyona 1020 den fazla uçuş gerçekleştirmektedir.27 yıldır sektörün içince olan Sun Express toplamda 63 adet Boeing uçağıyla Avrupa’nın en modern filolarından biridir.%90 doluluk oranı ile yaklaşık 13 milyon dan fazla yolcuya hizmet veren Sun Express son yıllarda yakaladığı büyüme ile Türkiye’nin satışlarda en büyük 50 şirketi arasına girdi.</p><p style=\"margin-bottom: 20px; padding: 0px; border: 0px; vertical-align: baseline; line-height: 22px;\">Yolcuların uçak içinde keyifli zaman geçirmelerini sağlayan&nbsp;<span style=\"border-style: initial; border-color: initial; border-image: initial;\">Sun Times</span><font color=\"#777777\">&nbsp;</font>Destinasyonların yanı sıra teknoloji,yaşam eğlence ve bilgi dolu içeriği ,kaliteli görselleri,90 bin tirajı ve Türkçe- Almanca ve İngilizce dil seçenekleri&nbsp; ve modern 13 milyon Sun Express yolcusu ile buluşuyor.</p>', NULL, 2, NULL, NULL, NULL, NULL, '', '', '', '', '', '', '', '', NULL),
(216, 112, 'Tahsilat Sistemi', '<p style=\"margin-bottom: 20px; padding: 0px; border: 0px; vertical-align: baseline; line-height: 22px;\"><span style=\"border-style: initial; border-color: initial; border-image: initial;\">Amedya tahsilat sistemi</span></p><p style=\"margin-bottom: 20px; padding: 0px; border: 0px; vertical-align: baseline; line-height: 22px;\">* Kategori bazlı tahsilat sistemi<br>* Firma Yönetimi<br>* Müşteri Yönetimi<br>* Üyeliksiz Ödeme Alımı<br>* Hizmet Paketi Oluşturma<br>* Eposta ile Tahsilat</p><p style=\"margin-bottom: 20px; padding: 0px; border: 0px; vertical-align: baseline; line-height: 22px;\">Firma için yönetim<br>- Süper Kullanıcı [ Kendi firması altında bulunan tüm kullanıcıları ve ödemeleri yönetir ve izler]<br>- Kullanıcı [ Sadece kendi yampış olduğu ödemeleri izer ve yönetir.]<br>- Ödeme Kullanıcısı [ Sadece ödeme yapabilir .]</p>', NULL, 1, NULL, NULL, NULL, NULL, '', '', '', '', '', '', '', '', NULL),
(217, 112, 'Tahsilat Sistemi', '<p style=\"margin-bottom: 20px; padding: 0px; border: 0px; vertical-align: baseline; line-height: 22px;\"><span style=\"border-style: initial; border-color: initial; border-image: initial;\">Amedya tahsilat sistemi</span></p><p style=\"margin-bottom: 20px; padding: 0px; border: 0px; vertical-align: baseline; line-height: 22px;\">* Kategori bazlı tahsilat sistemi<br>* Firma Yönetimi<br>* Müşteri Yönetimi<br>* Üyeliksiz Ödeme Alımı<br>* Hizmet Paketi Oluşturma<br>* Eposta ile Tahsilat</p><p style=\"margin-bottom: 20px; padding: 0px; border: 0px; vertical-align: baseline; line-height: 22px;\">Firma için yönetim<br>- Süper Kullanıcı [ Kendi firması altında bulunan tüm kullanıcıları ve ödemeleri yönetir ve izler]<br>- Kullanıcı [ Sadece kendi yampış olduğu ödemeleri izer ve yönetir.]<br>- Ödeme Kullanıcısı [ Sadece ödeme yapabilir .]</p>', NULL, 2, NULL, NULL, NULL, NULL, '', '', '', '', '', '', '', '', NULL),
(218, 113, 'Harita Kaydı', '<p>Google haritalara işletmenizin kaydedilmesi sonrasında, arama sonuçlarında yükselir ve sektörde rakipleriniz arasından öne çıkabilirsiniz. Potansiyel müşterilerinizi gerçek birer müşteriye dönüştürmenize olanak tanır.<br></p>', NULL, 1, NULL, NULL, NULL, NULL, '', '', '', '', '', '', '', '', NULL),
(219, 113, 'Harita Kaydı', '<p>Google haritalara işletmenizin kaydedilmesi sonrasında, arama sonuçlarında yükselir ve sektörde rakipleriniz arasından öne çıkabilirsiniz. Potansiyel müşterilerinizi gerçek birer müşteriye dönüştürmenize olanak tanır.<br></p>', NULL, 2, NULL, NULL, NULL, NULL, '', '', '', '', '', '', '', '', NULL),
(220, 114, 'Türkiye Çocuk', '<p>İhlas Magazin Grubu’nun en ilk yayını olan ve Türkiye’nin en iyi çocuk dergisi “Türkiye Çocuk”, tam 33 asırdır çocukların hizmetinde. Öyle ki derginin ilk okuyucuları, bugün ülkeyi yöneten kadronun büyük bir bölümünü oluşturmaktadır. 15 Kasım 1981’den beri yayın hayatına devam eden Türkiye Çocuk Dergisi, zamanla küçüklerin hayatının en önemli parçalarından biri olmayı başardı. Uzman kadrosu, yazar ve çizerleri ile okuyucusuna kaliteyi sunan Türkiye Çocuk Dergisi, çocukların aktif ve sosyal bir kişilik kazanmalarına yardımcı oldu. Okurken eğlendiren, eğlenirken öğreten dergi, sürekli bir gelişim ve değişim içinde olan dünyayı çocukların evine kadar getirdi. Çocukların öğüte değil, örneğe ihtiyacı olduğunu bilen ve bu doğrultuda hareket eden Türkiye Çocuk, okuyucularına bir öğretmenden çok, bir arkadaş gibi yaklaşmayı prensip edindi. Yıllarca, örnek insanları sayfalarına taşıdı. Çocukların başarılı, yardımsever, vatanını, milletini, bayrağını seven, mert ve “erdemli” insanlar olarak yetişmesi için çok gayret sarf etti. Çocuk edebiyatı, bulmaca, çizgi roman, magazin, bilim, spor, kültür ve sanat haberleri, zekâ bulmacaları, hediyeli yarışmalardan oluşan içeriğiyle minik yüreklerde bambaşka bir tat bırakan ve onların hayatında benzersiz bir renk olan Türkiye Çocuk Dergisi’nin bunca yıllık başarısının sırrı, tamamıyla yerli ve bizden bir yayın olmasında yatmaktadır.<br></p>', NULL, 1, NULL, NULL, NULL, NULL, '', '', '', '', '', '', '', '', NULL),
(221, 114, 'Türkiye Çocuk', '<p>İhlas Magazin Grubu’nun en ilk yayını olan ve Türkiye’nin en iyi çocuk dergisi “Türkiye Çocuk”, tam 33 asırdır çocukların hizmetinde. Öyle ki derginin ilk okuyucuları, bugün ülkeyi yöneten kadronun büyük bir bölümünü oluşturmaktadır. 15 Kasım 1981’den beri yayın hayatına devam eden Türkiye Çocuk Dergisi, zamanla küçüklerin hayatının en önemli parçalarından biri olmayı başardı. Uzman kadrosu, yazar ve çizerleri ile okuyucusuna kaliteyi sunan Türkiye Çocuk Dergisi, çocukların aktif ve sosyal bir kişilik kazanmalarına yardımcı oldu. Okurken eğlendiren, eğlenirken öğreten dergi, sürekli bir gelişim ve değişim içinde olan dünyayı çocukların evine kadar getirdi. Çocukların öğüte değil, örneğe ihtiyacı olduğunu bilen ve bu doğrultuda hareket eden Türkiye Çocuk, okuyucularına bir öğretmenden çok, bir arkadaş gibi yaklaşmayı prensip edindi. Yıllarca, örnek insanları sayfalarına taşıdı. Çocukların başarılı, yardımsever, vatanını, milletini, bayrağını seven, mert ve “erdemli” insanlar olarak yetişmesi için çok gayret sarf etti. Çocuk edebiyatı, bulmaca, çizgi roman, magazin, bilim, spor, kültür ve sanat haberleri, zekâ bulmacaları, hediyeli yarışmalardan oluşan içeriğiyle minik yüreklerde bambaşka bir tat bırakan ve onların hayatında benzersiz bir renk olan Türkiye Çocuk Dergisi’nin bunca yıllık başarısının sırrı, tamamıyla yerli ve bizden bir yayın olmasında yatmaktadır.<br></p>', NULL, 2, NULL, NULL, NULL, NULL, '', '', '', '', '', '', '', '', NULL),
(222, 115, 'Yemek Zevki', '<p>Yemek Zevki Dergisi, yayın hayatına başladığı günden itibaren Türk mutfağının en güzel ve özel geleneksel tatlarının bozulmamasına özen gösteren öncü kimliğiyle okurlarına hizmet vermektedir. Evde her zaman bulunabilecek malzemelerle kolayca yapılabilen yemek tarifleri ve şölen havasındaki şık fotoğrafları, Yemek Zevki’ni okurlarının vazgeçilmezi yapmıştır.<br></p>', NULL, 1, NULL, NULL, NULL, NULL, '', '', '', '', '', '', '', '', NULL),
(223, 115, 'Yemek Zevki', '<p>Yemek Zevki Dergisi, yayın hayatına başladığı günden itibaren Türk mutfağının en güzel ve özel geleneksel tatlarının bozulmamasına özen gösteren öncü kimliğiyle okurlarına hizmet vermektedir. Evde her zaman bulunabilecek malzemelerle kolayca yapılabilen yemek tarifleri ve şölen havasındaki şık fotoğrafları, Yemek Zevki’ni okurlarının vazgeçilmezi yapmıştır.<br></p>', NULL, 2, NULL, NULL, NULL, NULL, '', '', '', '', '', '', '', '', NULL),
(224, 116, 'Hotel Restaurant', '<p>Ağırlama sanayinin teknolojik gelişmelerini yakından takip eden Hi-Tech Dergisi, sektöründe rakipsizdir. Zengin içeriği ve kaliteli dağıtımı sayesinde yurt içinden ve yurt dışından geniş bir okuyucu potansiyeline ulaşan dergi, ağırlama endüstrisi tarafından yakından takip edilmektedir. Sektörde tek aylık olarak yayımlanan Hi-Tech’in benimsemiş olduğu iki çeşit dağıtım sistemi vardır: Bunlar dönüşümlü ücretsiz dağıtım ve abonelere dağıtım şeklindedir.<br></p>', NULL, 1, NULL, NULL, NULL, NULL, '', '', '', '', '', '', '', '', NULL),
(225, 116, 'Hotel Restaurant', '<p>Ağırlama sanayinin teknolojik gelişmelerini yakından takip eden Hi-Tech Dergisi, sektöründe rakipsizdir. Zengin içeriği ve kaliteli dağıtımı sayesinde yurt içinden ve yurt dışından geniş bir okuyucu potansiyeline ulaşan dergi, ağırlama endüstrisi tarafından yakından takip edilmektedir. Sektörde tek aylık olarak yayımlanan Hi-Tech’in benimsemiş olduğu iki çeşit dağıtım sistemi vardır: Bunlar dönüşümlü ücretsiz dağıtım ve abonelere dağıtım şeklindedir.<br></p>', NULL, 2, NULL, NULL, NULL, NULL, '', '', '', '', '', '', '', '', NULL),
(226, 117, 'Food Turkey', '<p>Türkiye’nin önemli ihracat kalemlerinden olan gıda sektörünün önünde bulunan 2023 ihracat hedeflerine ulaşmak için artık yayıncılık anlamında çok ciddi bir dergi var: FOOD TURKEY MAGAZINE. Grubumuz yayınlarının en yenilerinden biri olan Food Turkey’de tamamı İngilizce olan sektör haberleri, özel firma tanıtımları, makaleler, yeni ürün lansmanları ve gıda sektörünün meslek örgütlerinin haberleri yer almakta. Sektörün ambalaj kalitesinin de yükselmesiyle cıvıl cıvıl görsellerle birlikte yayınlanan reklamlar ile dergi daha bir güzelleşiyor. Binlerce üst düzey alım yapan uluslararası gıda ithalatçısı adresine ücretsiz ulaşan dergi, Türk gıda sanayinin dünyadaki en büyük ve etkin sesi durumunda. Yüksek baskı kalitesinde yayınlanan Food Turkey, SIAL, ANUGA, GULFOOD, JAPON FOOD vs uluslararası fuarlara da iştirak ederek ziyaretçilere ücretsiz olarak dağıtılmaktadır.<br></p>', NULL, 1, NULL, NULL, NULL, NULL, '', '', '', '', '', '', '', '', NULL),
(227, 117, 'Food Turkey', '<p>Türkiye’nin önemli ihracat kalemlerinden olan gıda sektörünün önünde bulunan 2023 ihracat hedeflerine ulaşmak için artık yayıncılık anlamında çok ciddi bir dergi var: FOOD TURKEY MAGAZINE. Grubumuz yayınlarının en yenilerinden biri olan Food Turkey’de tamamı İngilizce olan sektör haberleri, özel firma tanıtımları, makaleler, yeni ürün lansmanları ve gıda sektörünün meslek örgütlerinin haberleri yer almakta. Sektörün ambalaj kalitesinin de yükselmesiyle cıvıl cıvıl görsellerle birlikte yayınlanan reklamlar ile dergi daha bir güzelleşiyor. Binlerce üst düzey alım yapan uluslararası gıda ithalatçısı adresine ücretsiz ulaşan dergi, Türk gıda sanayinin dünyadaki en büyük ve etkin sesi durumunda. Yüksek baskı kalitesinde yayınlanan Food Turkey, SIAL, ANUGA, GULFOOD, JAPON FOOD vs uluslararası fuarlara da iştirak ederek ziyaretçilere ücretsiz olarak dağıtılmaktadır.<br></p>', NULL, 2, NULL, NULL, NULL, NULL, '', '', '', '', '', '', '', '', NULL);
INSERT INTO `icerikdetay` (`Id`, `icerik_Id`, `Baslik`, `Detay`, `slug`, `DilID`, `Keywords`, `Descriptions`, `Title`, `SeoField`, `Layer1`, `Layer2`, `Layer3`, `Layer4`, `Layer5`, `Layer6`, `Layer7`, `Layer8`, `seo_url`) VALUES
(228, 118, 'Tekstil Teknik', '<p>Tekstil &amp; Teknik Dergisi kendi alanında Türkiye’de yayınlanan ilk sektör yayınıdır. Derginin tamamı Türkçe ve İngilizcedir. Yayın hayatına 1985 yılında başlayan Tekstil &amp; Teknik, tekstil sektörüne hizmet vermektedir. Dergi, tarihi boyunca bütün ilgili sahaların en üst üretim metotlarını ve tedarikçilerini aydınlatıcı biçimde tanıtmaktadır. Bütün makine ve ekipman üreticileri ile sıkı bir ilişki içerisinde, yerli ve yabancı firmaların ürünlerini ve en son teknolojilerini okuyucularına tanıtan dünyadaki önemli yayınlardan biridir. Türkiye’de 6.517, Avrupa’da 1.034, Ortadoğu’da 569, Uzakdoğu’da 284, Bağımsız Devletler Topluluğu ve Doğu Avrupa’da 358, Amerika’da 137 adet dağıtılan Tekstil&amp; Teknik, ulusal hakemli bir dergidir. Yayın kurulundan geçen makaleler yayınlandığında makale sahiplerine akademik hayattan avantajlar sağlar. Bugüne kadar bir çok başarılı projeye imza atarak adından söz ettiren Tekstil &amp; Teknik, “Türk Tekstil Sanayiinin Sesi’dir.”<br></p>', NULL, 1, NULL, NULL, NULL, NULL, '', '', '', '', '', '', '', '', NULL),
(229, 118, 'Tekstil Teknik', '<p>Tekstil &amp; Teknik Dergisi kendi alanında Türkiye’de yayınlanan ilk sektör yayınıdır. Derginin tamamı Türkçe ve İngilizcedir. Yayın hayatına 1985 yılında başlayan Tekstil &amp; Teknik, tekstil sektörüne hizmet vermektedir. Dergi, tarihi boyunca bütün ilgili sahaların en üst üretim metotlarını ve tedarikçilerini aydınlatıcı biçimde tanıtmaktadır. Bütün makine ve ekipman üreticileri ile sıkı bir ilişki içerisinde, yerli ve yabancı firmaların ürünlerini ve en son teknolojilerini okuyucularına tanıtan dünyadaki önemli yayınlardan biridir. Türkiye’de 6.517, Avrupa’da 1.034, Ortadoğu’da 569, Uzakdoğu’da 284, Bağımsız Devletler Topluluğu ve Doğu Avrupa’da 358, Amerika’da 137 adet dağıtılan Tekstil&amp; Teknik, ulusal hakemli bir dergidir. Yayın kurulundan geçen makaleler yayınlandığında makale sahiplerine akademik hayattan avantajlar sağlar. Bugüne kadar bir çok başarılı projeye imza atarak adından söz ettiren Tekstil &amp; Teknik, “Türk Tekstil Sanayiinin Sesi’dir.”<br></p>', NULL, 2, NULL, NULL, NULL, NULL, '', '', '', '', '', '', '', '', NULL),
(230, 119, 'Sleep Well', '<p>Yatak sektörüne yönelik Ar-Ge çalışmalarını, yatırımları ve nonwoven teknolojileri yakından takip edenlerin merakla beklediği sektörel dergi Sleep Well, İhlas Magazin Grubu’nun en önemli yayınlarından biridir. Yatak sektörünün ve diğer uyku ürünlerinin nabzını elinde tutmak isteyenler, uluslararası pazarlarda firmalarının ve ürünlerinin doğru hedeflere ulaşması için, iki ayda bir yayınlanan Sleep Well Dergisi’ni takip ediyorlar.<br></p>', NULL, 1, NULL, NULL, NULL, NULL, '', '', '', '', '', '', '', '', NULL),
(231, 119, 'Sleep Well', '<p>Yatak sektörüne yönelik Ar-Ge çalışmalarını, yatırımları ve nonwoven teknolojileri yakından takip edenlerin merakla beklediği sektörel dergi Sleep Well, İhlas Magazin Grubu’nun en önemli yayınlarından biridir. Yatak sektörünün ve diğer uyku ürünlerinin nabzını elinde tutmak isteyenler, uluslararası pazarlarda firmalarının ve ürünlerinin doğru hedeflere ulaşması için, iki ayda bir yayınlanan Sleep Well Dergisi’ni takip ediyorlar.<br></p>', NULL, 2, NULL, NULL, NULL, NULL, '', '', '', '', '', '', '', '', NULL),
(232, 120, 'Automotive Exports', '<p>Yayın hayatına başladığı 1997 yılından bu yana Türk otomotiv yan sanayisine yön veren ve her ay düzenli olarak yayımlanan Automotive Exports, otomobil yedek parça dünyasından en son yenilikleri tamamen İngilizce olarak yayınlayarak tanıtımını üstlendiği ihracatçıların uluslararası rekabette bir adım önde olmalarını sağlar.Automotive Exports Dergisi 8.500 adet basılmakta ve yurt dışı ağırlıklı dağıtılmaktadır. Yurt dışında düzenlenen sektör fuarlarına dünya çapında en çok katılan birkaç dergiden biri olan Auomotive Exports, müşterilerine dünyanın en uzak ülkelerinden bile sipariş kazandırmasıyla ve güvenilir olmasıyla ünlüdür. Profesyonel bir ekiple hazırlanan dergi, her sayfasında arkasındaki birikimi yansıtan yüksek bir kalitenin izlerini taşır. Çıktığı ilk günden beri pazar liderliğini koruyan Automotive Exports, otomobil yedek parça danışmanı niteliğinde bir dergidir.<br></p>', NULL, 1, NULL, NULL, NULL, NULL, '', '', '', '', '', '', '', '', NULL),
(233, 120, 'Automotive Exports', '<p>Yayın hayatına başladığı 1997 yılından bu yana Türk otomotiv yan sanayisine yön veren ve her ay düzenli olarak yayımlanan Automotive Exports, otomobil yedek parça dünyasından en son yenilikleri tamamen İngilizce olarak yayınlayarak tanıtımını üstlendiği ihracatçıların uluslararası rekabette bir adım önde olmalarını sağlar.Automotive Exports Dergisi 8.500 adet basılmakta ve yurt dışı ağırlıklı dağıtılmaktadır. Yurt dışında düzenlenen sektör fuarlarına dünya çapında en çok katılan birkaç dergiden biri olan Auomotive Exports, müşterilerine dünyanın en uzak ülkelerinden bile sipariş kazandırmasıyla ve güvenilir olmasıyla ünlüdür. Profesyonel bir ekiple hazırlanan dergi, her sayfasında arkasındaki birikimi yansıtan yüksek bir kalitenin izlerini taşır. Çıktığı ilk günden beri pazar liderliğini koruyan Automotive Exports, otomobil yedek parça danışmanı niteliğinde bir dergidir.<br></p>', NULL, 2, NULL, NULL, NULL, NULL, '', '', '', '', '', '', '', '', NULL),
(234, 121, 'Made In Turkey', '<p>1982 yılından beri kesintisiz her ay yayınlanan “Made in Turkey” İngilizce Ekonomi Gazetesi, Türkiye’nin dışa açılmaya başladığı o yıldan beri her ay basılmakta ve 120 ülkede dağıtılmaktadır. 2 yıl Türk hükümeti tarafından resmi olarak desteklenen gazete, kısa sürede güçlenerek kendi gelişimini sürdürebilecek güce erdi. Halen tamamı İngilizce yayınlan ve yurt dışında dağıtılan tek aylık gazete olan Made in Turkey, yurt içinde sektörün önemli ihracatçı kuruluşlarına ve ekonomi bürokrasisine, yabancı ülkelerin ticaret müşavirliklerine, ekonomi ile ilgili dernek ve birliklere, ticaret ve sanayi odaları ile diğer ilgililere 4.500 adet dağıtılmaktadır. Bunun yanında yurt dışında 120 ülkeden seçkin ithalatçı firmaya, Türk ticaret müşavirliklerine, önemli oda, sektör kuruluşları ve ekonomik çevrelere toplam 11.000 adet gönderilmektedir. Uluslararası fuarlarda ekibimiz tarafından da (ayda 3- 4.000 adet) dağıtılmaktadır.<br></p>', NULL, 1, NULL, NULL, NULL, NULL, '', '', '', '', '', '', '', '', NULL),
(235, 121, 'Made In Turkey', '<p>1982 yılından beri kesintisiz her ay yayınlanan “Made in Turkey” İngilizce Ekonomi Gazetesi, Türkiye’nin dışa açılmaya başladığı o yıldan beri her ay basılmakta ve 120 ülkede dağıtılmaktadır. 2 yıl Türk hükümeti tarafından resmi olarak desteklenen gazete, kısa sürede güçlenerek kendi gelişimini sürdürebilecek güce erdi. Halen tamamı İngilizce yayınlan ve yurt dışında dağıtılan tek aylık gazete olan Made in Turkey, yurt içinde sektörün önemli ihracatçı kuruluşlarına ve ekonomi bürokrasisine, yabancı ülkelerin ticaret müşavirliklerine, ekonomi ile ilgili dernek ve birliklere, ticaret ve sanayi odaları ile diğer ilgililere 4.500 adet dağıtılmaktadır. Bunun yanında yurt dışında 120 ülkeden seçkin ithalatçı firmaya, Türk ticaret müşavirliklerine, önemli oda, sektör kuruluşları ve ekonomik çevrelere toplam 11.000 adet gönderilmektedir. Uluslararası fuarlarda ekibimiz tarafından da (ayda 3- 4.000 adet) dağıtılmaktadır.<br></p>', NULL, 2, NULL, NULL, NULL, NULL, '', '', '', '', '', '', '', '', NULL),
(236, 122, 'Nalbur Teknik', '<p>İlk sayılarında gazete olarak okuyucularıyla buluşan Nalbur &amp; Teknik; aylık periyodik dergi formatında Türkiye’nin dört bir yanına ulaşmaktadır. Doyurucu içerik ve estetik mizanpaj derginin dikkat çekici özellikleri arasındadır. Dergimizin okuyucu adres portföyü Türkiye Gazetesi dağıtım ağı ile sağlanmıştır. 9 bin tiraj ile yurdun dört bir tarafındaki nalburlara dağıtılan dergi, sürekli yükselen bir grafik içerisindedir. Sektördeki gündem, yenilikler, yeni ürünler ve uygulama örneklerini inceleyen Nallbur &amp; Teknik, malzeme üreticileri ile nalbur esnafı arasındaki önemli bir iletişim platformudur. Dergi aynı zamanda yurt dışı dağıtım kanalları sayesinde üreticilere yeni pazarların kapılarını aralamaktadır.<br></p>', NULL, 1, NULL, NULL, NULL, NULL, '', '', '', '', '', '', '', '', NULL),
(237, 122, 'Nalbur Teknik', '<p>İlk sayılarında gazete olarak okuyucularıyla buluşan Nalbur &amp; Teknik; aylık periyodik dergi formatında Türkiye’nin dört bir yanına ulaşmaktadır. Doyurucu içerik ve estetik mizanpaj derginin dikkat çekici özellikleri arasındadır. Dergimizin okuyucu adres portföyü Türkiye Gazetesi dağıtım ağı ile sağlanmıştır. 9 bin tiraj ile yurdun dört bir tarafındaki nalburlara dağıtılan dergi, sürekli yükselen bir grafik içerisindedir. Sektördeki gündem, yenilikler, yeni ürünler ve uygulama örneklerini inceleyen Nallbur &amp; Teknik, malzeme üreticileri ile nalbur esnafı arasındaki önemli bir iletişim platformudur. Dergi aynı zamanda yurt dışı dağıtım kanalları sayesinde üreticilere yeni pazarların kapılarını aralamaktadır.<br></p>', NULL, 2, NULL, NULL, NULL, NULL, '', '', '', '', '', '', '', '', NULL),
(238, 123, 'Yapı Malzeme', '<p>Türk yapı sektörüne yönelik olarak 1995 yılından beri yayın hayatına devam eden Yapı Malzeme Dergisi, aylık yayın periyodu ile başarılı ve istikrarlı bir grafik çizmektedir. Yapı malzemeleri sektörüne profesyonel bir bakış açısıyla yaklaşan dergimiz, sektörün lider dergisi olarak tanımlanmaktadır. Yapı Malzeme Dergisi, gündemi yakından takip ederek güncel haberleri, hızla gelişmekte olan teknolojik gelişmeleri firmalar ve okuyucularıyla paylaşmaktadır. Yaklaşık 12 bin tiraj ile okuyucularına ulaşan derginin hedef kitlesini, proje mühendisleri ve ofisleri, mimarlık şirketleri, şantiye şefleri, uluslararası ve ulusal inşaat yatırımcıları ve müteahhitlik firmaları , inşaat sektörünün üst düzey yöneticileri ve son karar alıcıları, akademisyenler, bürokratlar ve yapı malzeme sektöründeki satın alma yöneticileri oluşturmaktadır.<br></p>', NULL, 1, NULL, NULL, NULL, NULL, '', '', '', '', '', '', '', '', NULL),
(239, 123, 'Yapı Malzeme', '<p>Türk yapı sektörüne yönelik olarak 1995 yılından beri yayın hayatına devam eden Yapı Malzeme Dergisi, aylık yayın periyodu ile başarılı ve istikrarlı bir grafik çizmektedir. Yapı malzemeleri sektörüne profesyonel bir bakış açısıyla yaklaşan dergimiz, sektörün lider dergisi olarak tanımlanmaktadır. Yapı Malzeme Dergisi, gündemi yakından takip ederek güncel haberleri, hızla gelişmekte olan teknolojik gelişmeleri firmalar ve okuyucularıyla paylaşmaktadır. Yaklaşık 12 bin tiraj ile okuyucularına ulaşan derginin hedef kitlesini, proje mühendisleri ve ofisleri, mimarlık şirketleri, şantiye şefleri, uluslararası ve ulusal inşaat yatırımcıları ve müteahhitlik firmaları , inşaat sektörünün üst düzey yöneticileri ve son karar alıcıları, akademisyenler, bürokratlar ve yapı malzeme sektöründeki satın alma yöneticileri oluşturmaktadır.<br></p>', NULL, 2, NULL, NULL, NULL, NULL, '', '', '', '', '', '', '', '', NULL),
(240, 124, 'Medikal Teknik', '<p>İhlas Magazin Grubu’nun çıkardığı ilk dergilerden olan Medikal &amp; Teknik, aynı zamanda kendi sahası olan medikal sektörünün de ilk ve en etkili ihtisas yayınıdır. Derginin tamamı Türkçe ve İngilizce dilindedir. Yayın hayatına 1985 yılında başlayan Medikal Teknik Dergisi, genel olarak aktüel, panorama, tıbbi ekipman, hastane &amp; donanım, ayın dosyası gibi çeşitli bölümden oluşur. Aktüel bölümünde o ay içindeki güncel olaylar; tıbbi ekipman bölümünde sektörün her dalındaki cihazların tanıtım bilgileri; hastane- yapı organizasyon bölümünde hastanelerin işleyişine, tanıtımına ve ihtiyaçlarına yönelik haberler; fuar ve kongre bölümünde ise tıp dünyasına dair etkinlik ve organizasyon haberlerine yer verilir. Medikal Teknik Dergisi, bütün ilgili sahaların en son imalat metotlarını ve tedarikçi kuruluşları aydınlatıcı biçimde tanıtmaktadır. Ekipman üreticileri ve tedarikçileriyle sıkı bir ilişki içerisindedir.<br></p>', NULL, 1, NULL, NULL, NULL, NULL, '', '', '', '', '', '', '', '', NULL),
(241, 124, 'Medikal Teknik', '<p>İhlas Magazin Grubu’nun çıkardığı ilk dergilerden olan Medikal &amp; Teknik, aynı zamanda kendi sahası olan medikal sektörünün de ilk ve en etkili ihtisas yayınıdır. Derginin tamamı Türkçe ve İngilizce dilindedir. Yayın hayatına 1985 yılında başlayan Medikal Teknik Dergisi, genel olarak aktüel, panorama, tıbbi ekipman, hastane &amp; donanım, ayın dosyası gibi çeşitli bölümden oluşur. Aktüel bölümünde o ay içindeki güncel olaylar; tıbbi ekipman bölümünde sektörün her dalındaki cihazların tanıtım bilgileri; hastane- yapı organizasyon bölümünde hastanelerin işleyişine, tanıtımına ve ihtiyaçlarına yönelik haberler; fuar ve kongre bölümünde ise tıp dünyasına dair etkinlik ve organizasyon haberlerine yer verilir. Medikal Teknik Dergisi, bütün ilgili sahaların en son imalat metotlarını ve tedarikçi kuruluşları aydınlatıcı biçimde tanıtmaktadır. Ekipman üreticileri ve tedarikçileriyle sıkı bir ilişki içerisindedir.<br></p>', NULL, 2, NULL, NULL, NULL, NULL, '', '', '', '', '', '', '', '', NULL),
(242, 125, 'IT Network', '<p>IT Network Dergisi, Türkiye’deki bilgi teknolojisi sektöründeki kurumsal işbirliğinin dünya standartlarına ulaşması için bilgilendirme, haber, alış ve satış konularında profesyonel tanıtım hizmeti sunmaktadır. IT Network Dergisi 16.000 tiraja sahiptir. Bilişim teknolojileri sektörü başta olmak üzere; kamu, finans, sağlık, eğitim, gıda gibi birçok sektörün üst düzey yöneticilerine, bilgi-işlem ve satın alma müdürlerine gönderilmektedir. Kurumsal IT teknolojisine yönelik her türlü alım yapan kurum, kuruluş ve uzmanlar derginin ana dağıtım kitlesini oluşturmaktadır. Yöneticiler IT Network Dergisi ile firmalarının faaliyet alanlarını, ürün ve hizmetlerini, sektör içindeki konumlarını, pazar paylarını ve yeniliklerini duyurmaktadır. IT Network Dergisi, güncel IT çözümleri arayan ve satın alma yapmak isteyen firmalara öncülük etmekte ve tüm bilişim sektörü tarafından ilgiyle takip edilmektedir. Ana yayın alanı firmadan-firmaya (Business to Business) olan dergi 15 günde bir yayınlanmaktadır.<br></p>', NULL, 1, NULL, NULL, NULL, NULL, '', '', '', '', '', '', '', '', NULL),
(243, 125, 'IT Network', '<p>IT Network Dergisi, Türkiye’deki bilgi teknolojisi sektöründeki kurumsal işbirliğinin dünya standartlarına ulaşması için bilgilendirme, haber, alış ve satış konularında profesyonel tanıtım hizmeti sunmaktadır. IT Network Dergisi 16.000 tiraja sahiptir. Bilişim teknolojileri sektörü başta olmak üzere; kamu, finans, sağlık, eğitim, gıda gibi birçok sektörün üst düzey yöneticilerine, bilgi-işlem ve satın alma müdürlerine gönderilmektedir. Kurumsal IT teknolojisine yönelik her türlü alım yapan kurum, kuruluş ve uzmanlar derginin ana dağıtım kitlesini oluşturmaktadır. Yöneticiler IT Network Dergisi ile firmalarının faaliyet alanlarını, ürün ve hizmetlerini, sektör içindeki konumlarını, pazar paylarını ve yeniliklerini duyurmaktadır. IT Network Dergisi, güncel IT çözümleri arayan ve satın alma yapmak isteyen firmalara öncülük etmekte ve tüm bilişim sektörü tarafından ilgiyle takip edilmektedir. Ana yayın alanı firmadan-firmaya (Business to Business) olan dergi 15 günde bir yayınlanmaktadır.<br></p>', NULL, 2, NULL, NULL, NULL, NULL, '', '', '', '', '', '', '', '', NULL),
(244, 126, 'Web Sitemiz Güncellenmiştir', 'Web Sitemiz yeni yüzü ile karşınızda!', NULL, 1, '', '', '', '', '', '', '', '', '', '', '', '', ''),
(245, 126, 'Web Sitemiz Güncellenmiştir', 'Web Sitemiz yeni yüzü ile karşınızda!', NULL, 2, NULL, NULL, NULL, NULL, '', '', '', '', '', '', '', '', NULL),
(246, 127, 'Web Hizmetleri', '<p>Tecrübeli ekibi ile web hizmetleri sunmaktadır.</p>', NULL, 1, NULL, NULL, NULL, NULL, '<i class=\"fas fa-desktop\"></i>', '', '', '', NULL, NULL, NULL, NULL, NULL),
(247, 127, 'Web Hizmetleri', '<p>Tecrübeli ekibi ile web hizmetleri sunmaktadır.</p>', NULL, 2, NULL, NULL, NULL, NULL, '<i class=\"fas fa-desktop\"></i>', '', '', '', NULL, NULL, NULL, NULL, NULL),
(248, 128, 'Tasarım', '<p>Uzman tasarımcılar ile isteğe yönelik tasarımlar yaptırılmaktadır.</p>', NULL, 1, '', '', '', '', '<i class=\"fas fa-pencil-alt\"></i>', '', '', '', '', '', '', '', ''),
(249, 128, 'Tasarım', '<p>Uzman tasarımcılar ile isteğe yönelik tasarımlar yaptırılmaktadır.</p>', NULL, 2, NULL, NULL, NULL, NULL, '<i class=\"fas fa-pen-fancy\"></i>', '', '', '', NULL, NULL, NULL, NULL, NULL),
(250, 129, 'SEO', '<p>SEO hizmeti sunulmaktadır</p>', NULL, 1, NULL, NULL, NULL, NULL, '<i class=\"fas fa-search\"></i>', '', '', '', NULL, NULL, NULL, NULL, NULL),
(251, 129, 'SEO', '<p>SEO hizmeti sunulmaktadır</p>', NULL, 2, NULL, NULL, NULL, NULL, '<i class=\"fas fa-search\"></i>', '', '', '', NULL, NULL, NULL, NULL, NULL),
(252, 130, 'Mobil Yazılım', '<p>Mobil platformda hizmet vermekteyiz.</p>', NULL, 1, NULL, NULL, NULL, NULL, '<i class=\"fas fa-mobile-alt\"></i>', '', '', '', NULL, NULL, NULL, NULL, NULL),
(253, 130, 'Mobil Yazılım', '<p>Mobil platformda hizmet vermekteyiz.</p>', NULL, 2, NULL, NULL, NULL, NULL, '<i class=\"fas fa-mobile-alt\"></i>', '', '', '', NULL, NULL, NULL, NULL, NULL),
(254, 131, 'Tarım TR Yeni Sayısı Bayilerde', '<p>Temmuz 2018 sayısı yayınlanan Tarım TR dergisini yetkili bayilerde bulabilirsiniz.</p>', NULL, 1, NULL, NULL, NULL, NULL, '', '', '', '', '', '', '', '', NULL),
(255, 131, 'Tarım TR Yeni Sayısı Bayilerde', '<p>Temmuz 2018 sayısı yayınlanan Tarım TR dergisini yetkili bayilerde bulabilirsiniz.</p>', NULL, 2, NULL, NULL, NULL, NULL, '', '', '', '', '', '', '', '', NULL);

-- --------------------------------------------------------

--
-- Table structure for table `icerikgaleri`
--

CREATE TABLE `icerikgaleri` (
  `Id` bigint(20) UNSIGNED NOT NULL,
  `Grup` varchar(255) DEFAULT NULL,
  `Yol` varchar(255) DEFAULT NULL,
  `Yol2` varchar(255) DEFAULT NULL,
  `icerik_Id` bigint(20) DEFAULT NULL,
  `Baslik` varchar(255) DEFAULT NULL,
  `Sira` int(11) DEFAULT '0'
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `icerikgaleri`
--

INSERT INTO `icerikgaleri` (`Id`, `Grup`, `Yol`, `Yol2`, `icerik_Id`, `Baslik`, `Sira`) VALUES
(1, NULL, 'Upload/2124172475620151555531.JPG', NULL, 42, '', 0),
(2, NULL, 'Upload/72476066627420142348231.JPG', NULL, 42, '', 0),
(3, NULL, 'Upload/72476066627420142337191.JPG', NULL, 42, '', 0),
(4, NULL, 'Upload/72476066627420142330541.JPG', NULL, 42, '', 0),
(5, NULL, 'Upload/2124172475620151555531_15022018-163013.JPG', NULL, 43, '', 0),
(6, NULL, 'Upload/72476066627420142348231_15022018-163015.JPG', NULL, 43, '', 0),
(7, NULL, 'Upload/72476066627420142337191_15022018-163017.JPG', NULL, 43, '', 0);

-- --------------------------------------------------------

--
-- Table structure for table `icerik_yorum`
--

CREATE TABLE `icerik_yorum` (
  `Id` bigint(20) UNSIGNED NOT NULL,
  `Icerik_Id` int(11) DEFAULT '0',
  `Adsoyad` varchar(255) DEFAULT NULL,
  `Eposta` varchar(255) DEFAULT NULL,
  `Baslik` varchar(255) DEFAULT NULL,
  `Detay` longtext,
  `Durum` int(11) DEFAULT '0',
  `Reg_date` timestamp NULL DEFAULT CURRENT_TIMESTAMP
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `icerik_yorum`
--

INSERT INTO `icerik_yorum` (`Id`, `Icerik_Id`, `Adsoyad`, `Eposta`, `Baslik`, `Detay`, `Durum`, `Reg_date`) VALUES
(14, 44, 'asdsa', 'dsa', 'das', 'dasd', 1, '2018-02-15 15:36:11');

-- --------------------------------------------------------

--
-- Table structure for table `modul`
--

CREATE TABLE `modul` (
  `Id` bigint(20) UNSIGNED NOT NULL,
  `Baslik` varchar(255) DEFAULT NULL,
  `Dosya` varchar(120) DEFAULT NULL,
  `Reg_date` timestamp NULL DEFAULT CURRENT_TIMESTAMP
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Table structure for table `sablon`
--

CREATE TABLE `sablon` (
  `Id` bigint(20) UNSIGNED NOT NULL,
  `Baslik` varchar(255) DEFAULT NULL,
  `Dosya` varchar(120) DEFAULT NULL,
  `Tema` int(11) DEFAULT '0',
  `Reg_date` timestamp NULL DEFAULT CURRENT_TIMESTAMP
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `sablon`
--

INSERT INTO `sablon` (`Id`, `Baslik`, `Dosya`, `Tema`, `Reg_date`) VALUES
(0, 'Varsayilan', 'default', -1, '2017-03-10 13:43:50');

-- --------------------------------------------------------

--
-- Table structure for table `site`
--

CREATE TABLE `site` (
  `SiteID` bigint(20) UNSIGNED NOT NULL,
  `Title` longtext,
  `Keywords` longtext,
  `Description` longtext,
  `DilID` bigint(20) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `site`
--

INSERT INTO `site` (`SiteID`, `Title`, `Keywords`, `Description`, `DilID`) VALUES
(1, 'AMEDYA A.Ş.', 'AMEDYA', 'AMEDYA A.Ş.', 1),
(2, 'ASM', 'ASM', 'ASM', 2);

-- --------------------------------------------------------

--
-- Table structure for table `slayt`
--

CREATE TABLE `slayt` (
  `Id` bigint(20) UNSIGNED NOT NULL,
  `Yol` varchar(255) DEFAULT NULL,
  `Detay` longtext,
  `Link` varchar(255) DEFAULT NULL,
  `DilID` int(11) DEFAULT NULL,
  `Sira` int(11) NOT NULL DEFAULT '0',
  `Baslik` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `slayt`
--

INSERT INTO `slayt` (`Id`, `Yol`, `Detay`, `Link`, `DilID`, `Sira`, `Baslik`) VALUES
(17, 'Upload/slide2.jpg', ' Konya\'nın Dünya\'ya Açılan Kapısı', '#', 0, 0, 'Konya Exports'),
(18, 'Upload/slide3.jpg', 'Doğru, Güvenilir ve Objektif Tarım', '#', 0, 0, 'Tarım TR'),
(19, 'Upload/slide1.jpg', 'Otomotive Sektörünü Yakından Takip Edin', '#', 0, 0, 'Konya Automotive');

-- --------------------------------------------------------

--
-- Table structure for table `sosyalmedya`
--

CREATE TABLE `sosyalmedya` (
  `Id` bigint(20) UNSIGNED NOT NULL,
  `Baslik` varchar(255) DEFAULT NULL,
  `Url` varchar(255) DEFAULT NULL,
  `Ikon` varchar(255) DEFAULT NULL,
  `Sira` int(11) DEFAULT '0'
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `sosyalmedya`
--

INSERT INTO `sosyalmedya` (`Id`, `Baslik`, `Url`, `Ikon`, `Sira`) VALUES
(1, 'Facebook', '#', '<i class=\"fab fa-facebook\"></i>', 1),
(2, 'Twitter', '#', '<i class=\"fab fa-twitter\"></i>', 2),
(3, 'Instagram', '#', '<i class=\"fab fa-instagram\"></i>', 4),
(4, 'Linked In', '#', '<i class=\"fab fa-linkedin\"></i>', 3);

-- --------------------------------------------------------

--
-- Table structure for table `tema`
--

CREATE TABLE `tema` (
  `Id` bigint(20) UNSIGNED NOT NULL,
  `Baslik` varchar(255) DEFAULT NULL,
  `Klasor` varchar(255) DEFAULT NULL,
  `Sablon` int(11) DEFAULT '0',
  `Ayarlar` longtext,
  `Durum` int(11) DEFAULT '0',
  `Reg_date` timestamp NULL DEFAULT CURRENT_TIMESTAMP
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `tema`
--

INSERT INTO `tema` (`Id`, `Baslik`, `Klasor`, `Sablon`, `Ayarlar`, `Durum`, `Reg_date`) VALUES
(1, 'default', 'default', 0, '{\'renk\': \'dark-red\',\'logo\': \'/Upload/logo.png\',\'footer-logo\': \'/Upload/logo.png\',\'staticfiles\': \'assets/css/custom.css,assets/js/custom.js\'}', 1, '2017-09-27 23:21:32');

-- --------------------------------------------------------

--
-- Table structure for table `tur`
--

CREATE TABLE `tur` (
  `Id` bigint(20) UNSIGNED NOT NULL,
  `Baslik` varchar(255) DEFAULT NULL,
  `Size` varchar(255) DEFAULT NULL,
  `AltIcerikSize` varchar(255) DEFAULT NULL,
  `GaleriSize` varchar(255) DEFAULT NULL,
  `AltIcerikGaleriSize` varchar(255) DEFAULT NULL,
  `BannerSize` varchar(255) DEFAULT NULL,
  `Layer1` varchar(255) DEFAULT NULL,
  `Layer2` varchar(255) DEFAULT NULL,
  `Layer3` varchar(255) DEFAULT NULL,
  `Layer4` varchar(255) DEFAULT NULL,
  `Layer5` varchar(255) DEFAULT NULL,
  `Layer6` varchar(255) DEFAULT NULL,
  `Layer7` varchar(255) DEFAULT NULL,
  `Layer8` varchar(255) DEFAULT NULL,
  `Sablon` int(11) DEFAULT '0',
  `AltIcerik` int(11) DEFAULT '0',
  `Dokuman` int(11) DEFAULT '0',
  `Detay` int(11) DEFAULT '0',
  `Yonlendirme` int(11) DEFAULT '0',
  `Form` int(11) DEFAULT '0',
  `Menu` int(11) DEFAULT '1',
  `Sidebar` int(11) DEFAULT '0',
  `Dropdown` int(11) DEFAULT '1',
  `Url` int(11) DEFAULT '1',
  `Anasayfa` int(11) DEFAULT '0',
  `Yorum` int(11) DEFAULT '0',
  `Sira` int(11) DEFAULT '0'
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `tur`
--

INSERT INTO `tur` (`Id`, `Baslik`, `Size`, `AltIcerikSize`, `GaleriSize`, `AltIcerikGaleriSize`, `BannerSize`, `Layer1`, `Layer2`, `Layer3`, `Layer4`, `Layer5`, `Layer6`, `Layer7`, `Layer8`, `Sablon`, `AltIcerik`, `Dokuman`, `Detay`, `Yonlendirme`, `Form`, `Menu`, `Sidebar`, `Dropdown`, `Url`, `Anasayfa`, `Yorum`, `Sira`) VALUES
(11, 'İletişim', '0', '0', '0', '0', '0', 'Telefon', 'Adres', 'Eposta', 'Harita', '', '', '', '', 0, 0, 1, 1, 0, 1, 1, 0, 0, 1, 0, 0, 4),
(12, 'Hakkımızda', '800x600', '0', '0', '0', '0', '', '', '', '', '', '', '', '', 0, 0, 0, 1, 0, 0, 1, 0, 0, 1, 0, 0, 1),
(13, 'Ürünlerimiz', '301x395', '0', '0', '0', '0', 'Link', '', '', '', '', '', '', '', 0, 1, 0, 1, 0, 0, 1, 0, 1, 1, 0, 0, 3),
(18, 'Hizmetlerimiz', '0', '0', '0', '0', '0', 'Ikon', '', '', '', '', '', '', '', 0, 0, 0, 1, 0, 0, 0, 0, 1, 1, 0, 0, 5),
(20, 'Haberler', '800x600', '0', '0', '0', '0', '', '', '', '', '', '', '', '', 0, 0, 0, 1, 0, 0, 1, 0, 1, 1, 0, 0, 2);

-- --------------------------------------------------------

--
-- Table structure for table `turdetay`
--

CREATE TABLE `turdetay` (
  `Id` bigint(20) UNSIGNED NOT NULL,
  `DilID` int(11) DEFAULT NULL,
  `Tur_Id` int(11) DEFAULT NULL,
  `Baslik` varchar(255) DEFAULT NULL,
  `seo_url` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `turdetay`
--

INSERT INTO `turdetay` (`Id`, `DilID`, `Tur_Id`, `Baslik`, `seo_url`) VALUES
(11, 1, 11, 'İletişim', ''),
(20, 2, 11, 'İletişim', NULL),
(21, 1, 12, 'Kurumsal', ''),
(22, 2, 12, 'Hakkımızda', NULL),
(23, 1, 13, 'Ürünlerimiz', ''),
(24, 2, 13, 'Ürünlerimiz', NULL),
(33, 1, 18, 'Hizmetlerimiz', ''),
(34, 2, 18, 'Hizmetlerimiz', NULL),
(37, 1, 20, 'Duyurular', ''),
(38, 2, 20, 'Haberler', NULL);

-- --------------------------------------------------------

--
-- Table structure for table `yonetici`
--

CREATE TABLE `yonetici` (
  `YoneticiID` bigint(20) UNSIGNED NOT NULL,
  `Adsoyad` varchar(255) DEFAULT NULL,
  `Eposta` varchar(255) DEFAULT NULL,
  `Resim` varchar(255) DEFAULT NULL,
  `YoneticiAd` varchar(255) DEFAULT NULL,
  `YoneticiSifre` varchar(255) DEFAULT NULL,
  `Yetki` int(11) DEFAULT '0',
  `FirmaSahibi` int(11) DEFAULT '0',
  `Sil` int(11) DEFAULT '0',
  `Turler` varchar(255) DEFAULT '0',
  `Moduller` varchar(255) DEFAULT '0',
  `Sayfalar` varchar(255) DEFAULT NULL,
  `Onay_Yetki` int(11) DEFAULT '0',
  `List_Yetki` int(11) DEFAULT '0',
  `Yorum_Yetki` int(11) DEFAULT '0',
  `DilID` int(11) DEFAULT '0'
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `yonetici`
--

INSERT INTO `yonetici` (`YoneticiID`, `Adsoyad`, `Eposta`, `Resim`, `YoneticiAd`, `YoneticiSifre`, `Yetki`, `FirmaSahibi`, `Sil`, `Turler`, `Moduller`, `Sayfalar`, `Onay_Yetki`, `List_Yetki`, `Yorum_Yetki`, `DilID`) VALUES
(1, 'Sistem Yöneticisi', 'info@website.com', '', 'admin', 'O60/7vejA72Z6znGxHhdQw==', 0, 1, 0, '0', '0', '', 0, 0, 0, 0),
(4, 'paket2', 'paket2', NULL, 'paket2', 'EaNIGHTvf1jxBFNB/XQUeg==', 1, 1, 1, '3,4,5,7,8,9,10,11,0', '0', 'sosyalmedya,dil/index,dil/edit,dil/fieldedit,slayt/index,site/index,form/index,yonetici/index,tema/options', 1, 1, 1, 0),
(5, 'paket3', 'paket3', NULL, 'paket3', 'IAVIQh0CC9VNZ+YoaEcFBg==', 1, 0, 1, '3,4,5,7,8,9,10,11,0', '0', 'sosyalmedya,dil/index,dil/edit,dil/fieldedit,slayt/index,site/index,form/index,yonetici/index,tema/options', 1, 1, 0, 0);

--
-- Indexes for dumped tables
--

--
-- Indexes for table `ayarlar`
--
ALTER TABLE `ayarlar`
  ADD PRIMARY KEY (`Id`);

--
-- Indexes for table `dil`
--
ALTER TABLE `dil`
  ADD PRIMARY KEY (`DilID`);

--
-- Indexes for table `dokuman`
--
ALTER TABLE `dokuman`
  ADD PRIMARY KEY (`Id`);

--
-- Indexes for table `form`
--
ALTER TABLE `form`
  ADD PRIMARY KEY (`Id`);

--
-- Indexes for table `icerik`
--
ALTER TABLE `icerik`
  ADD PRIMARY KEY (`Id`);

--
-- Indexes for table `icerikdetay`
--
ALTER TABLE `icerikdetay`
  ADD PRIMARY KEY (`Id`);

--
-- Indexes for table `icerikgaleri`
--
ALTER TABLE `icerikgaleri`
  ADD PRIMARY KEY (`Id`);

--
-- Indexes for table `icerik_yorum`
--
ALTER TABLE `icerik_yorum`
  ADD PRIMARY KEY (`Id`);

--
-- Indexes for table `modul`
--
ALTER TABLE `modul`
  ADD PRIMARY KEY (`Id`);

--
-- Indexes for table `sablon`
--
ALTER TABLE `sablon`
  ADD PRIMARY KEY (`Id`);

--
-- Indexes for table `site`
--
ALTER TABLE `site`
  ADD PRIMARY KEY (`SiteID`);

--
-- Indexes for table `slayt`
--
ALTER TABLE `slayt`
  ADD PRIMARY KEY (`Id`);

--
-- Indexes for table `sosyalmedya`
--
ALTER TABLE `sosyalmedya`
  ADD PRIMARY KEY (`Id`);

--
-- Indexes for table `tema`
--
ALTER TABLE `tema`
  ADD PRIMARY KEY (`Id`);

--
-- Indexes for table `tur`
--
ALTER TABLE `tur`
  ADD PRIMARY KEY (`Id`);

--
-- Indexes for table `turdetay`
--
ALTER TABLE `turdetay`
  ADD PRIMARY KEY (`Id`);

--
-- Indexes for table `yonetici`
--
ALTER TABLE `yonetici`
  ADD PRIMARY KEY (`YoneticiID`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `ayarlar`
--
ALTER TABLE `ayarlar`
  MODIFY `Id` bigint(20) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT for table `dil`
--
ALTER TABLE `dil`
  MODIFY `DilID` bigint(20) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT for table `dokuman`
--
ALTER TABLE `dokuman`
  MODIFY `Id` bigint(20) UNSIGNED NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `form`
--
ALTER TABLE `form`
  MODIFY `Id` bigint(20) UNSIGNED NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `icerik`
--
ALTER TABLE `icerik`
  MODIFY `Id` bigint(20) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=132;

--
-- AUTO_INCREMENT for table `icerikdetay`
--
ALTER TABLE `icerikdetay`
  MODIFY `Id` bigint(20) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=256;

--
-- AUTO_INCREMENT for table `icerikgaleri`
--
ALTER TABLE `icerikgaleri`
  MODIFY `Id` bigint(20) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;

--
-- AUTO_INCREMENT for table `icerik_yorum`
--
ALTER TABLE `icerik_yorum`
  MODIFY `Id` bigint(20) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=15;

--
-- AUTO_INCREMENT for table `modul`
--
ALTER TABLE `modul`
  MODIFY `Id` bigint(20) UNSIGNED NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `sablon`
--
ALTER TABLE `sablon`
  MODIFY `Id` bigint(20) UNSIGNED NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `site`
--
ALTER TABLE `site`
  MODIFY `SiteID` bigint(20) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT for table `slayt`
--
ALTER TABLE `slayt`
  MODIFY `Id` bigint(20) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=20;

--
-- AUTO_INCREMENT for table `sosyalmedya`
--
ALTER TABLE `sosyalmedya`
  MODIFY `Id` bigint(20) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT for table `tema`
--
ALTER TABLE `tema`
  MODIFY `Id` bigint(20) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT for table `tur`
--
ALTER TABLE `tur`
  MODIFY `Id` bigint(20) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=21;

--
-- AUTO_INCREMENT for table `turdetay`
--
ALTER TABLE `turdetay`
  MODIFY `Id` bigint(20) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=39;

--
-- AUTO_INCREMENT for table `yonetici`
--
ALTER TABLE `yonetici`
  MODIFY `YoneticiID` bigint(20) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
