-- phpMyAdmin SQL Dump
-- version 4.8.2
-- https://www.phpmyadmin.net/
--
-- Host: localhost
-- Generation Time: Mar 19, 2019 at 12:47 AM
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
-- Database: `mogesan`
--

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
(1, 'AMEDYA A.Ş.', '7Qae8WsEuB80qOip1KrS2XEXKyRIfe7sDwOcWLFox5E=', '', '', '', '', 'false', '1920x1000', 0, 'false', 'false', 1, '2017-06-10 23:42:44');

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
(51, 1, NULL, '2018-05-17 15:59:17', NULL, NULL, NULL, 9, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, '', '', 1),
(52, 1, NULL, '2018-06-20 14:25:54', 'Upload/hakkimizda.png', 'Upload/hakkimizda_banner.jpg', NULL, 12, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, '', '', 1),
(53, 1, NULL, '2018-06-20 14:27:05', 'Upload/misyon__vizyon.jpg', 'Upload/misyon__vizyon_banner.jpg', NULL, 12, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, '', '', 1),
(55, 1, NULL, '2018-06-20 14:44:45', NULL, NULL, NULL, 14, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 1, 1, 1, 1, '', '', 1),
(56, 1, NULL, '2018-06-20 14:48:16', NULL, NULL, NULL, 14, 0, 0, 0, 0, 0, 2, 0, 0, 0, 1, 1, 1, 1, 1, '', '', 1),
(57, 1, NULL, '2018-06-20 14:49:26', NULL, NULL, NULL, 14, 0, 0, 0, 0, 0, 3, 0, 0, 0, 1, 1, 1, 1, 1, '', '', 1),
(58, 1, NULL, '2018-06-20 14:50:02', NULL, NULL, NULL, 14, 0, 0, 0, 0, 0, 4, 0, 0, 0, 1, 1, 1, 1, 1, '', '', 1),
(59, 1, NULL, '2018-06-20 14:51:00', NULL, NULL, NULL, 14, 0, 0, 0, 0, 0, 5, 0, 0, 0, 1, 1, 1, 1, 1, '', '', 1),
(60, 1, NULL, '2018-06-20 15:26:17', NULL, NULL, NULL, 14, 0, 0, 0, 0, 0, 6, 0, 0, 0, 1, 1, 1, 1, 1, '', '', 1),
(61, 1, NULL, '2018-06-20 15:27:48', NULL, NULL, NULL, 14, 0, 0, 0, 0, 0, 7, 0, 0, 0, 1, 1, 1, 1, 1, '', '', 1),
(62, 1, NULL, '2018-06-20 15:28:26', NULL, NULL, NULL, 14, 0, 0, 0, 0, 0, 8, 0, 0, 0, 1, 1, 1, 1, 1, '', '', 1),
(63, 1, NULL, '2018-06-20 15:31:06', NULL, NULL, NULL, 15, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, '', '', 1),
(64, 1, NULL, '2018-06-20 15:32:51', NULL, NULL, NULL, 16, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, '', '', 1),
(65, 1, NULL, '2018-06-20 15:47:03', 'Upload/fuar-20062018_162903.jpg', NULL, NULL, 17, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, '', '', 1),
(66, 1, NULL, '2018-06-20 16:20:29', 'Upload/piston-20062018_164435.jpg', NULL, NULL, 13, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 1, 1, 1, 1, '', '', 1),
(67, 1, NULL, '2018-06-20 16:21:49', 'Upload/liner-20062018_164448.jpg', NULL, NULL, 13, 0, 0, 0, 0, 0, 2, 0, 0, 0, 1, 1, 1, 1, 1, '', '', 1),
(68, 1, NULL, '2018-06-20 16:22:39', 'Upload/ring-20062018_164519.jpg', NULL, NULL, 13, 0, 0, 0, 0, 0, 3, 0, 0, 0, 1, 1, 1, 1, 1, '', '', 1),
(69, 1, NULL, '2018-06-20 16:29:38', 'Upload/hakkimizda-10072018_114936.jpg', NULL, NULL, 17, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, '', '', 1),
(70, 1, NULL, '2018-06-20 16:30:01', 'Upload/segman.png', NULL, NULL, 17, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, '', '', 1);

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
(46, 46, 'İletişim Bilgileri', '<p>Adres<span style=\"white-space:pre\">	</span>:MOGESAN MOTOR GÖMLEK PİSTON SAN. ve TİC. LTD. ŞTİ.</p><p>&nbsp;<span style=\"white-space:pre\">	</span> <span style=\"white-space:pre\">	</span>2. Organize Sanayi Bölgesi Evrenköy Caddesi No:2/1 Konya/TÜRKİYE</p><p>Telefon<span style=\"white-space:pre\">	</span>:0 332.239 02 20</p><p>&nbsp;<span style=\"white-space:pre\">	</span> <span style=\"white-space:pre\">	</span>0 332.239 05 70</p><p>&nbsp;<span style=\"white-space:pre\">	</span> <span style=\"white-space:pre\">	</span>0 332.251 25 78</p><p>Faks<span style=\"white-space:pre\">	</span>:0 332 249 01 43</p><p>Web&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span style=\"white-space:pre\">	</span>:http://www.mogesan.com</p><p>E-Posta<span style=\"white-space:pre\">	</span>:mgs@mogesan.com</p><p>&nbsp;<span style=\"white-space:pre\">	</span> <span style=\"white-space:pre\">	</span>info@mogesan.com</p><p>&nbsp;<span style=\"white-space:pre\">	</span> <span style=\"white-space:pre\">	</span>sales@mogesan.com</p><p>&nbsp;<span style=\"white-space:pre\">	</span> <span style=\"white-space:pre\">	</span>ferahim@mogesan.com</p><p>&nbsp;<span style=\"white-space:pre\">	</span> <span style=\"white-space:pre\">	</span>export@mogesan.com</p>', NULL, 1, '', '', '', '', '+90 332.239 02 20', '+90 332 249 01 43', 'mgs@mogesan.com', '<iframe src=\"https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d3144.918202233693!2d32.60622731557352!3d37.979038208153305!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x14d08fb8f13a89f9%3A0xb7fb27bb6ca0e365!2sMogesan+Motor+G%C3%B6mlek+%26+Piston!5e0!3m2!1str!2str!4v1529499038237\" width=\"600\" height=\"450\" frameborder=\"0\" style=\"border:0\" allowfullscreen></iframe>', '', '', '', '', ''),
(90, 46, 'İletişim Bilgileri', '<p><strong style=\"color: rgb(0, 0, 0); margin: 0px; padding: 0px; font-size: 14px; text-align: justify;\">Telefon :&nbsp;</strong><span style=\"margin: 0px; padding: 0px; font-size: 14px; text-align: justify;\">+90 332 999 99 98</span></p><p><span style=\"margin: 0px; padding: 0px; font-size: 14px; text-align: justify;\"><strong style=\"color: rgb(0, 0, 0); margin: 0px; padding: 0px;\">Fax:&nbsp;</strong><span style=\"margin: 0px; padding: 0px;\">+90 332 999 99 99</span></span></p><p><span style=\"margin: 0px; padding: 0px; font-size: 14px; text-align: justify;\"><span style=\"margin: 0px; padding: 0px;\"><strong style=\"color: rgb(0, 0, 0); margin: 0px; padding: 0px;\">Eposta:&nbsp;</strong><span style=\"margin: 0px; padding: 0px;\">bilgi@asm.com</span><br></span><br></span></p><p><strong style=\"margin: 0px; padding: 0px; color: rgb(0, 0, 0); font-size: 14px; text-align: justify;\">Lorem Ipsum</strong><span style=\"font-size: 14px; text-align: justify;\">, dizgi ve baskı endüstrisinde kullanılan mıgır metinlerdir.</span><br></p>', NULL, 2, '', '', '', '', '+90 332 999 99 98', '+90 332 999 99 99', 'bilgi@asm.com', '<iframe src=\"https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d201550.39177761006!2d32.36639818662086!3d37.87842350771473!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x14d08568d615f745%3A0x240dd0fc08060967!2sKonya!5e0!3m2!1str!2str!4v1518701936596\" width=\"100%\" height=\"250\" frameborder=\"0\" style=\"border:0\" allowfullscreen></iframe>', NULL, NULL, NULL, NULL, NULL),
(94, 51, 'foto galeri', '', NULL, 1, '', '', '', '', '', '', '', '', '', '', '', '', ''),
(95, 51, 'Mutfak Dolabı', '', NULL, 2, NULL, NULL, NULL, NULL, '', '', '', '', NULL, NULL, NULL, NULL, NULL),
(96, 52, 'Hakkımızda', '<p><b>MOGESAN</b>1994 yılında Konya Motorlu Araçlar Sanayisinde atölye ölçeğindeki işletmesinde kısıtlı imkânlarla içten yanmalı motorlara ait silindir gömleklerinin imalatı ile faaliyete başlamıştır. 1999 yılında zafer sanayine taşınarak faaliyetine devam etmiştir. bulunduğu yerin darlığından dolayı artan taleplere cevap veremez olduğu için 250 m2 olan imalat alanını 600 m2 ye çıkarmıştır. 2001 yılında imalat alanını 1000 m2 ye çıkartıp piston imalatına başlamıştır.Piston imalatında genişleyip büyüme sağlanmış, bulunduğu yerin kapalı alanı küçük gelmeye başlamış 2003 yılında Konya 1. Organize Sanayi Bölgesi’nde 7500 m2 arsa üzerine kurulu 4500 m2 kapalı alana sahip iş yerine taşınmış kendini yenileyerek, geliştirerek halen burada imalatına devam etmektedir. Mogesan 2013 yılının ortalarından sonra Konya 2. Organize Sanayi Bölgesindeki toplam 30.000 m2 alan üzerine kurulu yeni fabrikasına taşınmayı hedeflemektedir.<br></p><p>Ürün kalitemizi sürekli olarak geliştirmek, tüm çalışanlarımızın müşteri memnuniyetini ilke edinmesini sağlamak amacıyla 2005 yılında TS-EN-ISO 9001:2000 Kalite Güvence Sistemini kurmuş ve uygulamakta olan kuruluşumuz, 2010 yılında da yeni kalite revizyonları gerçekleştirerek TS-EN-ISO 9001:2008 Kalite Güvence Sistemini kurmuş ve iç pazarda ve resmi/tüzel kuruluşlarda pazar payını artırmak için TS 1106 (Pistonlar-Alüminyum Alaşımı-Benzin ve Diesel Motorları İçin), TS 482 (İçten Yanmalı Motorlar Silindir Gömlekleri) standardı belgesini almıştır ve uygulamaya devam ermektedir.</p><p>Kuruluşumuzda, belirlenen şartlara uygun ürün üretimin güvence altına alınmasını sağlamak amacıyla hammadde girişinden sevkiyata kadar ki tüm aşamalarda kalite kontrolü uygulanmaktadır.</p><p>Çalışan personelimizin yeterliliği, bilinci ve eğitimi sürekli olarak artırılarak üretimin ve hizmetin eksiksiz yapılması sağlanmaktadır.</p><p><b>MOGESAN Motor Gömlek Piston Sanayi ve Tic. Ltd. Şti.</b> yılda 260.000 adet piston ve 140.000 adet motor gömleği imalatı yapmaktadır. Ürettiği piston ve motor gömleklerin yaklaşık % 75 ini doğrudan ve dolaylı olarak yurt dışına ihraç etmekte ve ürettiği ürünlerin geri kalanını da yurt içinde pazarlamaktadır. İç ve dış pazarda müşterilerimizin beğenisini kazanan ürünlerimiz başta Ortadoğu ve Afrika olmak üzere 60 ın üzerinde ülkeye ihraç edilmektedir.</p><p>Kaliteden taviz vermeden en üst düzeyde müşteri memnuniyeti sağlamayı amaç edinen kuruluşumuz, müşteri istekleri, teknolojik gelişmeler ve sipariş artışına bağlı olarak teknik imkanlarını geliştirmeyi ve üretim kapasitesini artırmayı sürdürmektedir.</p><p><b>MOGESAN</b>; bu gelişmelerin sonucunda müşterilerimize ulusal ve uluslararası standartların öngördüğü kalite özelliklerine sahip ürünler sunmaya devam edecek, üretim kapasitemizi yükselterek işgücü istihdamının artırılması, ihracat yapılan ülkelerin özellikle AB ülkelerinin sayısının artması düşünüldüğünden, kuruluşumuzun karlılığı yükselecek, ülke ekonomisine olan katkıda büyüme olacak ve bu sayede müşterilerimizin, işverenimizin ve çalışanlarımızın memnuniyetinin artırılması sağlanacaktır.</p><p><b>MOGESAN</b>, ürün kalitesinin sürekliliği ve müşteri memnuniyetine verdiği önem ile 21. yüzyılda bir dünya markası olmayı hedeflemektedir.</p><div><br></div>', NULL, 1, '', '', '', '', '', '', '', '', '', '', '', '', ''),
(97, 52, 'Hakkımızda', '<p><br></p><table border=\"0\" width=\"100%\" cellspacing=\"0\" cellpadding=\"0\" style=\"font-family: &quot;Times New Roman&quot;; background-color: rgb(250, 250, 250);\"><tbody><tr><td><table border=\"0\" width=\"100%\" cellspacing=\"0\" cellpadding=\"0\"><tbody><tr><td width=\"600\" valign=\"top\"><table border=\"0\" width=\"100%\" cellspacing=\"0\" cellpadding=\"0\"><tbody><tr><td><p align=\"justify\"><font face=\"Arial\" style=\"font-size: 9pt; font-weight: 700;\">MOGESAN MOTOR GÖMLEK PİSTON SANAYİ VE TİC. LTD. ŞTİ.</font></p></td></tr><tr><td><font face=\"Arial\" style=\"font-size: 9pt;\"><img border=\"0\" src=\"http://www.mogesan.com/images/ccc_hak.jpg\" width=\"1\" height=\"11\"></font></td></tr><tr><td><p align=\"justify\"><font face=\"Arial\" style=\"font-size: 9pt;\">Mogesan 1994 yılında Konya Motorlu Araçlar Sanayisinde atölye ölçeğindeki işletmesinde kısıtlı imkânlarla içten yanmalı motorlara ait silindir gömleklerinin imalatı ile faaliyete başlamıştır. 1999 yılında zafer sanayine taşınarak faaliyetine devam etmiştir. bulunduğu yerin darlığından dolayı artan taleplere cevap veremez olduğu için 250 m2 olan imalat alanını 600 m2 ye çıkarmıştır. 2001 yılında imalat alanını 1000 m2 ye çıkartıp piston imalatına başlamıştır.Piston imalatında genişleyip büyüme sağlanmış, bulunduğu yerin kapalı alanı küçük gelmeye başlamış 2003 yılında Konya 1. Organize Sanayi Bölgesi’nde 7500 m2 arsa üzerine kurulu 4500 m2 kapalı alana sahip iş yerine taşınmış kendini yenileyerek, geliştirerek halen burada imalatına devam etmektedir. Mogesan 2013 yılının ortalarından sonra Konya 2. Organize Sanayi Bölgesindeki toplam 30.000 m2 alan üzerine kurulu yeni fabrikasına taşınmayı hedeflemektedir.</font></p></td></tr></tbody></table></td></tr></tbody></table></td></tr><tr><td><img border=\"0\" src=\"http://www.mogesan.com/images/ccc_hak.jpg\" width=\"1\" height=\"12\"></td></tr><tr><td><p align=\"justify\"><font face=\"Arial\" style=\"font-size: 9pt;\">Ürün kalitemizi sürekli olarak geliştirmek, tüm çalışanlarımızın müşteri memnuniyetini ilke edinmesini sağlamak amacıyla 2005 yılında TS-EN-ISO 9001:2000 Kalite Güvence Sistemini kurmuş ve uygulamakta olan kuruluşumuz, 2010 yılında da yeni kalite revizyonları gerçekleştirerek TS-EN-ISO 9001:2008 Kalite Güvence Sistemini kurmuş ve iç pazarda ve resmi/tüzel kuruluşlarda pazar payını artırmak için TS 1106 (Pistonlar-Alüminyum Alaşımı-Benzin ve Diesel Motorları İçin), TS 482 (İçten Yanmalı Motorlar Silindir Gömlekleri) standardı belgesini almıştır ve uygulamaya devam ermektedir.<br><br>Kuruluşumuzda, belirlenen şartlara uygun ürün üretimin güvence altına alınmasını sağlamak amacıyla hammadde girişinden sevkiyata kadar ki tüm aşamalarda kalite kontrolü uygulanmaktadır.<br><br>Çalışan personelimizin yeterliliği, bilinci ve eğitimi sürekli olarak artırılarak üretimin ve hizmetin eksiksiz yapılması sağlanmaktadır.<br><br>MOGESAN Motor Gömlek Piston Sanayi ve Tic. Ltd. Şti. yılda 260.000 adet piston ve 140.000 adet motor gömleği imalatı yapmaktadır. Ürettiği piston ve motor gömleklerin yaklaşık % 75 ini doğrudan ve dolaylı olarak yurt dışına ihraç etmekte ve ürettiği ürünlerin geri kalanını da yurt içinde pazarlamaktadır. İç ve dış pazarda müşterilerimizin beğenisini kazanan ürünlerimiz başta Ortadoğu ve Afrika olmak üzere 60 ın üzerinde ülkeye ihraç edilmektedir.<br><br>Kaliteden taviz vermeden en üst düzeyde müşteri memnuniyeti sağlamayı amaç edinen kuruluşumuz, müşteri istekleri, teknolojik gelişmeler ve sipariş artışına bağlı olarak teknik imkanlarını geliştirmeyi ve üretim kapasitesini artırmayı sürdürmektedir.<br><br>Mogesan; bu gelişmelerin sonucunda müşterilerimize ulusal ve uluslararası standartların öngördüğü kalite özelliklerine sahip ürünler sunmaya devam edecek, üretim kapasitemizi yükselterek işgücü istihdamının artırılması, ihracat yapılan ülkelerin özellikle AB ülkelerinin sayısının artması düşünüldüğünden, kuruluşumuzun karlılığı yükselecek, ülke ekonomisine olan katkıda büyüme olacak ve bu sayede müşterilerimizin, işverenimizin ve çalışanlarımızın memnuniyetinin artırılması sağlanacaktır.<br><br>MOGESAN, ürün kalitesinin sürekliliği ve müşteri memnuniyetine verdiği önem ile 21. yüzyılda bir dünya markası olmayı hedeflemektedir.</font></p></td></tr></tbody></table>', NULL, 2, NULL, NULL, NULL, NULL, '', '', '', '', '', '', '', '', NULL),
(98, 53, 'Misyon & Vizyon', '<p><span style=\"color: rgb(51, 51, 51); font-family: inherit; font-size: 16px; font-weight: bold;\">Misyonumuz:</span><br></p><p>Mogesan ürünlerini aranılan marka haline getirerek sektörde lider firmalar arasında yer almak.</p><p><br></p><h4>Vizyonumuz:</h4><p>Mogesan</p><p>• Üstün performans,</p><p>• Yüksek güç,</p><p>• Uzun ömür ve Mutlu müşteri demektir.</p><div><br></div>', NULL, 1, '', '', '', '', '', '', '', '', '', '', '', '', ''),
(99, 53, 'Misyon && Vizyom', '<p><br></p><table border=\"0\" width=\"100%\" cellspacing=\"0\" cellpadding=\"0\" style=\"font-family: &quot;Times New Roman&quot;; background-color: rgb(250, 250, 250);\"><tbody><tr><td width=\"600\" valign=\"top\"><table border=\"0\" width=\"100%\" cellspacing=\"0\" cellpadding=\"0\"><tbody><tr><td><font face=\"Arial\" style=\"font-size: 9pt;\"><b>Misyonumuz:</b><br>Mogesan ürünlerini aranılan marka haline getirerek sektörde lider firmalar arasında yer almak.</font></td></tr><tr><td><font face=\"Arial\" style=\"font-size: 9pt;\"><img border=\"0\" src=\"http://www.mogesan.com/images/ccc_hak.jpg\" width=\"1\" height=\"12\"></font></td></tr><tr><td><font face=\"Arial\" style=\"font-size: 9pt;\"><b>Vizyonumuz:</b><br>Mogesan<br>• Üstün performans,<br>• Yüksek güç,<br>• Uzun ömür ve Mutlu müşteri demektir.</font></td></tr></tbody></table></td></tr></tbody></table>', NULL, 2, NULL, NULL, NULL, NULL, '', '', '', '', '', '', '', '', NULL),
(102, 55, 'Ana Piston Ölçüleri', '<table border=\"0\" width=\"100%\" cellspacing=\"0\" cellpadding=\"0\" style=\"font-family: &quot;Times New Roman&quot;;\"><tbody><tr><td height=\"18\"><p><img src=\"/Upload/social_icons/teknikolcu.gif\" style=\"width: auto; margin: 0px auto; max-width: 100%;\"><span style=\"font-weight: 700;\"><font face=\"Verdana\" style=\"font-size: 8pt;\"><br></font></span></p><p><span style=\"font-weight: 700;\"><font face=\"Verdana\" style=\"font-size: 8pt;\">ANA PİSTON ÖLÇÜLERİ</font></span></p></td></tr><tr><td height=\"17\"><font face=\"Verdana\" style=\"font-size: 8pt;\">1- Çap</font></td></tr><tr><td height=\"17\"><font face=\"Verdana\" style=\"font-size: 8pt;\">2- Kompresyon yüksekliği</font></td></tr><tr><td height=\"17\"><font face=\"Verdana\" style=\"font-size: 8pt;\">3- Toplam boy</font></td></tr><tr><td height=\"17\"><font face=\"Verdana\" style=\"font-size: 8pt;\">4- Pim deliği çapı</font></td></tr><tr><td height=\"17\"><font face=\"Verdana\" style=\"font-size: 8pt;\">5- Pim yuvaları arasındaki mesafe</font></td></tr><tr><td height=\"17\"><font face=\"Verdana\" style=\"font-size: 8pt;\">6- Etek boyu</font></td></tr><tr><td height=\"17\"><font face=\"Verdana\" style=\"font-size: 8pt;\">7- Çelik plaka</font></td></tr><tr><td height=\"17\"><font face=\"Verdana\" style=\"font-size: 8pt;\">8- Segman seti genişliği</font></td></tr><tr><td height=\"17\"><font face=\"Verdana\" style=\"font-size: 8pt;\">9- Alfin - segman taşıyıcı</font></td></tr><tr><td height=\"17\"><font face=\"Verdana\" style=\"font-size: 8pt;\">10- Piston başı alt yüzeyinin pim deliğine olan mesafesi</font></td></tr><tr><td height=\"17\"><font face=\"Verdana\" style=\"font-size: 8pt;\">11- Yanma hücresi çapı</font></td></tr><tr><td height=\"17\"><font face=\"Verdana\" style=\"font-size: 8pt;\">12- Yanma hücre kaçıklığı</font></td></tr><tr><td height=\"17\"><font face=\"Verdana\" style=\"font-size: 8pt;\">13- Piston başı kalınlığı</font></td></tr><tr><td height=\"17\"><font face=\"Verdana\" style=\"font-size: 8pt;\">14- Yanma hücre derinliği</font></td></tr><tr><td height=\"17\"><font face=\"Verdana\" style=\"font-size: 8pt;\">15- Fazlalık</font></td></tr><tr><td height=\"17\"><font face=\"Verdana\" style=\"font-size: 8pt;\">16- Supap yuvası derinliği</font></td></tr><tr><td height=\"17\"><font face=\"Verdana\" style=\"font-size: 8pt;\">17- Ateşleme seti yüksekliği</font></td></tr><tr><td height=\"17\"><font face=\"Verdana\" style=\"font-size: 8pt;\">18- Segman kanal yüksekliği</font></td></tr><tr><td height=\"17\"><font face=\"Verdana\" style=\"font-size: 8pt;\">19- Yağ delikleri</font></td></tr></tbody></table>', NULL, 1, '', '', '', '', '', '', '', '', '', '', '', '', ''),
(103, 55, 'Ana Piston Ölçüleri', '', NULL, 2, NULL, NULL, NULL, NULL, '', '', '', '', NULL, NULL, NULL, NULL, NULL),
(104, 56, 'Kısaltmalar', '<table border=\"0\" width=\"100%\" cellspacing=\"0\" cellpadding=\"0\" style=\"font-family: &quot;Times New Roman&quot;;\"><tbody><tr><td height=\"24\"><b><font face=\"Arial\" size=\"2\">Kısaltmalar</font></b></td></tr><tr><td><font face=\"Verdana\" style=\"font-size: 8pt;\">Cr</font>&nbsp;<font face=\"Verdana\" style=\"font-size: 8pt;\">=</font>&nbsp;<span style=\"font-size: 8pt; font-family: Verdana;\">Krom kaplama<br></span><font face=\"Verdana\" style=\"font-size: 8pt;\">Fe</font>&nbsp;<font face=\"Verdana\" style=\"font-size: 8pt;\">=</font>&nbsp;<span style=\"font-size: 8pt; font-family: Verdana;\">Demir kaplama<br></span><font face=\"Verdana\" style=\"font-size: 8pt;\">P</font>&nbsp;<font face=\"Verdana\" style=\"font-size: 8pt;\">=</font>&nbsp;<span style=\"font-size: 8pt; font-family: Verdana;\">Fosfatlı<br></span><font face=\"Verdana\" style=\"font-size: 8pt;\">SW</font>&nbsp;<font face=\"Verdana\" style=\"font-size: 8pt;\">=</font>&nbsp;<span style=\"font-size: 8pt; font-family: Verdana;\">Özel malzeme</span><font face=\"Verdana\" style=\"font-size: 8pt;\"><br>IF</font>&nbsp;<font face=\"Verdana\" style=\"font-size: 8pt;\">=</font>&nbsp;<span style=\"font-size: 8pt; font-family: Verdana;\">Tepe özel eğimli</span><font face=\"Verdana\" style=\"font-size: 8pt;\"><br>IFU</font>&nbsp;<font face=\"Verdana\" style=\"font-size: 8pt;\">=</font>&nbsp;<span style=\"font-size: 8pt; font-family: Verdana;\">Altta özel eğimli</span><font face=\"Verdana\" style=\"font-size: 8pt;\"><br>IW</font>&nbsp;<font face=\"Verdana\" style=\"font-size: 8pt;\">=</font>&nbsp;<span style=\"font-size: 8pt; font-family: Verdana;\">Üst kademeli<br></span><font face=\"Verdana\" style=\"font-size: 8pt;\">IWU</font>&nbsp;<font face=\"Verdana\" style=\"font-size: 8pt;\">=</font>&nbsp;<span style=\"font-size: 8pt; font-family: Verdana;\">Alt kademeli</span><font face=\"Verdana\" style=\"font-size: 8pt;\"><br>CrK</font>&nbsp;<font face=\"Verdana\" style=\"font-size: 8pt;\">=</font>&nbsp;<span style=\"font-size: 8pt; font-family: Verdana;\">Krom – seramik kaplama</span><font face=\"Verdana\" style=\"font-size: 8pt;\"><br>Cu</font>&nbsp;<font face=\"Verdana\" style=\"font-size: 8pt;\">=</font>&nbsp;<span style=\"font-size: 8pt; font-family: Verdana;\">Bakır kaplama</span><font face=\"Verdana\" style=\"font-size: 8pt;\"><br>Mo</font>&nbsp;<font face=\"Verdana\" style=\"font-size: 8pt;\">=</font>&nbsp;<span style=\"font-size: 8pt; font-family: Verdana;\">Molibden kaplama</span><font face=\"Verdana\" style=\"font-size: 8pt;\"><br>N</font>&nbsp;<font face=\"Verdana\" style=\"font-size: 8pt;\">=</font>&nbsp;<span style=\"font-size: 8pt; font-family: Verdana;\">Nitratlı</span><font face=\"Verdana\" style=\"font-size: 8pt;\"><br>Sn</font>&nbsp;<font face=\"Verdana\" style=\"font-size: 8pt;\">=</font>&nbsp;<span style=\"font-size: 8pt; font-family: Verdana;\">Kalay kaplama</span><font face=\"Verdana\" style=\"font-size: 8pt;\"><br>So</font>&nbsp;<font face=\"Verdana\" style=\"font-size: 8pt;\">=</font>&nbsp;<span style=\"font-size: 8pt; font-family: Verdana;\">Özel kaplama</span></td></tr></tbody></table>', NULL, 1, NULL, NULL, NULL, NULL, '', '', '', '', NULL, NULL, NULL, NULL, NULL),
(105, 56, 'Kısaltmalar', '<table border=\"0\" width=\"100%\" cellspacing=\"0\" cellpadding=\"0\" style=\"font-family: &quot;Times New Roman&quot;;\"><tbody><tr><td height=\"24\"><b><font face=\"Arial\" size=\"2\">Kısaltmalar</font></b></td></tr><tr><td><font face=\"Verdana\" style=\"font-size: 8pt;\">Cr</font>&nbsp;<font face=\"Verdana\" style=\"font-size: 8pt;\">=</font>&nbsp;<span style=\"font-size: 8pt; font-family: Verdana;\">Krom kaplama<br></span><font face=\"Verdana\" style=\"font-size: 8pt;\">Fe</font>&nbsp;<font face=\"Verdana\" style=\"font-size: 8pt;\">=</font>&nbsp;<span style=\"font-size: 8pt; font-family: Verdana;\">Demir kaplama<br></span><font face=\"Verdana\" style=\"font-size: 8pt;\">P</font>&nbsp;<font face=\"Verdana\" style=\"font-size: 8pt;\">=</font>&nbsp;<span style=\"font-size: 8pt; font-family: Verdana;\">Fosfatlı<br></span><font face=\"Verdana\" style=\"font-size: 8pt;\">SW</font>&nbsp;<font face=\"Verdana\" style=\"font-size: 8pt;\">=</font>&nbsp;<span style=\"font-size: 8pt; font-family: Verdana;\">Özel malzeme</span><font face=\"Verdana\" style=\"font-size: 8pt;\"><br>IF</font>&nbsp;<font face=\"Verdana\" style=\"font-size: 8pt;\">=</font>&nbsp;<span style=\"font-size: 8pt; font-family: Verdana;\">Tepe özel eğimli</span><font face=\"Verdana\" style=\"font-size: 8pt;\"><br>IFU</font>&nbsp;<font face=\"Verdana\" style=\"font-size: 8pt;\">=</font>&nbsp;<span style=\"font-size: 8pt; font-family: Verdana;\">Altta özel eğimli</span><font face=\"Verdana\" style=\"font-size: 8pt;\"><br>IW</font>&nbsp;<font face=\"Verdana\" style=\"font-size: 8pt;\">=</font>&nbsp;<span style=\"font-size: 8pt; font-family: Verdana;\">Üst kademeli<br></span><font face=\"Verdana\" style=\"font-size: 8pt;\">IWU</font>&nbsp;<font face=\"Verdana\" style=\"font-size: 8pt;\">=</font>&nbsp;<span style=\"font-size: 8pt; font-family: Verdana;\">Alt kademeli</span><font face=\"Verdana\" style=\"font-size: 8pt;\"><br>CrK</font>&nbsp;<font face=\"Verdana\" style=\"font-size: 8pt;\">=</font>&nbsp;<span style=\"font-size: 8pt; font-family: Verdana;\">Krom – seramik kaplama</span><font face=\"Verdana\" style=\"font-size: 8pt;\"><br>Cu</font>&nbsp;<font face=\"Verdana\" style=\"font-size: 8pt;\">=</font>&nbsp;<span style=\"font-size: 8pt; font-family: Verdana;\">Bakır kaplama</span><font face=\"Verdana\" style=\"font-size: 8pt;\"><br>Mo</font>&nbsp;<font face=\"Verdana\" style=\"font-size: 8pt;\">=</font>&nbsp;<span style=\"font-size: 8pt; font-family: Verdana;\">Molibden kaplama</span><font face=\"Verdana\" style=\"font-size: 8pt;\"><br>N</font>&nbsp;<font face=\"Verdana\" style=\"font-size: 8pt;\">=</font>&nbsp;<span style=\"font-size: 8pt; font-family: Verdana;\">Nitratlı</span><font face=\"Verdana\" style=\"font-size: 8pt;\"><br>Sn</font>&nbsp;<font face=\"Verdana\" style=\"font-size: 8pt;\">=</font>&nbsp;<span style=\"font-size: 8pt; font-family: Verdana;\">Kalay kaplama</span><font face=\"Verdana\" style=\"font-size: 8pt;\"><br>So</font>&nbsp;<font face=\"Verdana\" style=\"font-size: 8pt;\">=</font>&nbsp;<span style=\"font-size: 8pt; font-family: Verdana;\">Özel kaplama</span></td></tr></tbody></table>', NULL, 2, NULL, NULL, NULL, NULL, '', '', '', '', NULL, NULL, NULL, NULL, NULL),
(106, 57, 'Kompresyon Segmanları', '<p><img src=\"/Upload/social_icons/r.gif\" style=\"width: auto; margin: 0px auto; max-width: 100%;\"><br></p>', NULL, 1, '', '', '', '', '', '', '', '', '', '', '', '', ''),
(107, 57, 'Kompresyon Segmanları', '', NULL, 2, NULL, NULL, NULL, NULL, '', '', '', '', NULL, NULL, NULL, NULL, NULL),
(108, 58, 'Yag Segmanları', '<p><img src=\"/Upload/social_icons/yagsegman.gif\" style=\"width: auto; margin: 0px auto; max-width: 100%;\"><br></p>', NULL, 1, '', '', '', '', '', '', '', '', '', '', '', '', ''),
(109, 58, 'Yag Segmanları', '', NULL, 2, NULL, NULL, NULL, NULL, '', '', '', '', NULL, NULL, NULL, NULL, NULL),
(110, 59, 'Piston Montaj İşlemleri', '<table border=\"0\" width=\"100%\" cellspacing=\"0\" cellpadding=\"0\" style=\"font-family: &quot;Times New Roman&quot;;\"><tbody><tr><td height=\"24\"><b><font face=\"Arial\" size=\"2\">Piston Montaj İşlemleri</font></b></td></tr><tr><td><font face=\"Arial\" style=\"font-size: 9pt;\"><b>Piston</b><br>Piston - pim ürünleri titiz bir test ve kontrolden geçirildikten sonra eşleştirilip koruma yağlarıyla yağlandıktan sonra paketlenerek piyasaya arz edilir. Diğer bazı üreticilerin uyguladığı piston - pim renk uygulamasına, firmamız gerek görmemiştir. Eğilim de bu yöndedir. Montaj esnasında aynı kutudan çıkan piston ve pimler, aynı silindirlere takılmalıdır. Piston takma yönleri, üzerlerindeki işaretlere göre yapılmalıdır.<br><br><b>Pim</b><br>Pistonlarla birlikte arz edilen pimler de yine hem malzeme hem de tolerans olarak standartlarında belirtilen özelliklerde imal edilmişlerdir. Her pistona göre farklılık gösterebilen ve tecrübelerle tespit edilmiş olan geçme toleranslarıyla, biyel koluna ve piston üzerindeki pim yuvalarına yataklamalar çalışma performansına direkt etkilidir. Eskiden uygulanan sıkı geçme, üretim kalitesi ve hassasiyetiyle yerini, yumuşak veya hafif geçmelere bırakmıştır. Hiçbir şekilde pimler yuvalarına zorlanarak takılıp sökülmemelidir. Eğer üst ölçü grubunda imal edilmişlerse, sıkı geçme olacağından pim yuvasının ısıtılması gerekebilir. Ayrıca biyele sıkı geçme montajlar, yardımcı ekipmanlar kullanarak dikkatlice yapılmalıdır. Pim emniyet segmanları da tip ve ölçülerine uygun olarak, ambalajları içine konmuştur.<br><br><b>Segman</b><br>Segmanların, üretici firmalarının talimatlarına uygun olarak, kalıcı şekil bozuklukları oluşturacak şekilde zorlanarak ağızları açılmamalıdır. Bu hem silindire zarar verecek, hem de motor verimini düşürecektir. Segmanlar birbirlerine ve sayılarına göre uygun açılarla yerleştirilmelidir.<br><br><b>Genel</b><br>Fabrikamızın üretimi olan pistonların, herhangi bir ek işleme gerek duyulmaksızın kendilerine uygun olarak imal edilmiş gömlek ve biyel kollarına montajı kolaylıkla yapılır. Montaj öncesi motor bloğu, silindir, kater, krank, silindir kafası gibi aksamlardaki olası muhtemel talaş ve parçacıkların özenle temizlenmesi gerekir.<br><br>Yağlama maddeleri uzun süre beklemeden dolayı kurumuş, matlaşmış olabilir. Bu halde piston ve pimi, temizleme sıvılarıyla temizlenerek yeniden yağlanmalıdır. Motorun alıştırılması % 70 - 80 güç ve devirde motor tahrikiyle yapılmalıdır.<br><br>Yağ ve yağ filtresi değiştirme işlemi zamanında, talimatlara, evsafına uygun olanları ile yapılmalıdır.</font></td></tr></tbody></table>', NULL, 1, NULL, NULL, NULL, NULL, '', '', '', '', NULL, NULL, NULL, NULL, NULL),
(111, 59, 'Piston Montaj İşlemleri', '<table border=\"0\" width=\"100%\" cellspacing=\"0\" cellpadding=\"0\" style=\"font-family: &quot;Times New Roman&quot;;\"><tbody><tr><td height=\"24\"><b><font face=\"Arial\" size=\"2\">Piston Montaj İşlemleri</font></b></td></tr><tr><td><font face=\"Arial\" style=\"font-size: 9pt;\"><b>Piston</b><br>Piston - pim ürünleri titiz bir test ve kontrolden geçirildikten sonra eşleştirilip koruma yağlarıyla yağlandıktan sonra paketlenerek piyasaya arz edilir. Diğer bazı üreticilerin uyguladığı piston - pim renk uygulamasına, firmamız gerek görmemiştir. Eğilim de bu yöndedir. Montaj esnasında aynı kutudan çıkan piston ve pimler, aynı silindirlere takılmalıdır. Piston takma yönleri, üzerlerindeki işaretlere göre yapılmalıdır.<br><br><b>Pim</b><br>Pistonlarla birlikte arz edilen pimler de yine hem malzeme hem de tolerans olarak standartlarında belirtilen özelliklerde imal edilmişlerdir. Her pistona göre farklılık gösterebilen ve tecrübelerle tespit edilmiş olan geçme toleranslarıyla, biyel koluna ve piston üzerindeki pim yuvalarına yataklamalar çalışma performansına direkt etkilidir. Eskiden uygulanan sıkı geçme, üretim kalitesi ve hassasiyetiyle yerini, yumuşak veya hafif geçmelere bırakmıştır. Hiçbir şekilde pimler yuvalarına zorlanarak takılıp sökülmemelidir. Eğer üst ölçü grubunda imal edilmişlerse, sıkı geçme olacağından pim yuvasının ısıtılması gerekebilir. Ayrıca biyele sıkı geçme montajlar, yardımcı ekipmanlar kullanarak dikkatlice yapılmalıdır. Pim emniyet segmanları da tip ve ölçülerine uygun olarak, ambalajları içine konmuştur.<br><br><b>Segman</b><br>Segmanların, üretici firmalarının talimatlarına uygun olarak, kalıcı şekil bozuklukları oluşturacak şekilde zorlanarak ağızları açılmamalıdır. Bu hem silindire zarar verecek, hem de motor verimini düşürecektir. Segmanlar birbirlerine ve sayılarına göre uygun açılarla yerleştirilmelidir.<br><br><b>Genel</b><br>Fabrikamızın üretimi olan pistonların, herhangi bir ek işleme gerek duyulmaksızın kendilerine uygun olarak imal edilmiş gömlek ve biyel kollarına montajı kolaylıkla yapılır. Montaj öncesi motor bloğu, silindir, kater, krank, silindir kafası gibi aksamlardaki olası muhtemel talaş ve parçacıkların özenle temizlenmesi gerekir.<br><br>Yağlama maddeleri uzun süre beklemeden dolayı kurumuş, matlaşmış olabilir. Bu halde piston ve pimi, temizleme sıvılarıyla temizlenerek yeniden yağlanmalıdır. Motorun alıştırılması % 70 - 80 güç ve devirde motor tahrikiyle yapılmalıdır.<br><br>Yağ ve yağ filtresi değiştirme işlemi zamanında, talimatlara, evsafına uygun olanları ile yapılmalıdır.</font></td></tr></tbody></table>', NULL, 2, NULL, NULL, NULL, NULL, '', '', '', '', NULL, NULL, NULL, NULL, NULL),
(112, 60, 'Gomlek Montaj İşlemleri', '<table border=\"0\" width=\"100%\" cellspacing=\"0\" cellpadding=\"0\" style=\"font-family: &quot;Times New Roman&quot;;\"><tbody><tr><td height=\"24\"><b><font face=\"Arial\" size=\"2\">Gömlek Montaj İşlemleri</font></b></td></tr><tr><td><font face=\"Arial\" style=\"font-size: 9pt;\">Üretilen Gömlekler :<br>-Kuru Gömlek<br>-Sulu Gömlek olarak iki tiptir.&nbsp;<br>Savurma döküm metoduyla üretilen gömlekler orijinal motor üreticisinin spesifikasyonlarına uygun olarak üretilmelidir. A tipi grafit yapısı ve fosfit dağılımı ile diğer piston segman üreticilerinin segmanları ile uyum içinde çalışır. Silindir gömlekleri hassas işlenmiş parçalardır ve bu nedenle darbelere karşı çok hassastır. Taşıma, paket açma ve motora takmalarda çok dikkatli davranmak gerekir. Depolamada her zaman dik tutmak ve rutubetli ortamda bulundurmamak lazımdır.</font></td></tr><tr><td><p><img src=\"/Upload/social_icons/gomlek1.gif\" style=\"width: auto; margin: 0px auto; max-width: 100%;\"></p><p><font face=\"Arial\" style=\"font-size: 9pt;\"><b>Sulu Gömleklerin Montajı</b></font><font face=\"Verdana\" style=\"font-size: medium;\"><span style=\"font-size: 8pt;\"><br>Montajdan önce silindir bloğunun çok iyi temizlenmesi lazımdır. Gömlek önce lastiksiz olarak takılmalı, rahat girip girmediği kontrol edilmeli sonra oringlere sıvı sabun sürülerek gömlek takılmalıdır. Takıldıktan sonra flanş yüksekliği ve iç çap kontrol edilmelidir.</span></font></p><p><img src=\"/Upload/social_icons/gomlek2.gif\" style=\"width: auto; margin: 0px auto; max-width: 100%;\"><font face=\"Verdana\" style=\"font-size: medium;\"><span style=\"font-size: 8pt;\"><br></span></font></p><p><font face=\"Arial\" style=\"font-size: 9pt;\"><b>Kuru (Semi) Gömleklerin Montajı</b></font><font face=\"Verdana\" style=\"font-size: medium;\"><span style=\"font-size: 8pt;\"><br>Montajdan önce blok çok iyi temizlenmeli, gömleğin geçeceği yuva çapı ölçüleri kontrol edilmeli daha sonra hidrolik preste 3000 kg ile 5000 kg kuvvet arasında bloğa geçirilmeli daha sonra eksen değiştirmeyecek şekilde rektefiyeleme ve honlama yapılmalıdır ve iç çaplar 20&nbsp;<sup>o</sup>C ‘ de ölçülmelidir.</span></font></p><table border=\"0\" width=\"100%\" cellspacing=\"0\" cellpadding=\"0\"><tbody><tr><td><font face=\"Arial\" style=\"font-size: 9pt;\"><b>Kuru Gömlek (Standart)<br></b></font><font face=\"Verdana\"><span style=\"font-size: 8pt;\">Dışı ve içi standart olan gömlekler için uygulanan tolerans :</span></font></td></tr><tr><td><span style=\"font-size: 8pt; font-family: Verdana;\">Blok Çapı ( f</span><font face=\"Verdana\"><span style=\"font-size: 8pt;\">B ) için&nbsp;</span></font><b><font face=\"Verdana\" style=\"font-size: 8pt;\">:</font></b>&nbsp;<span style=\"font-size: 8pt; font-family: Verdana;\">+0.015 mm<br>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; +0.00</span></td></tr><tr><td><span style=\"font-size: 8pt; font-family: Verdana;\">Blok Flanş Çapı ( fA )</span>&nbsp;<b><font face=\"Verdana\" style=\"font-size: 8pt;\">:</font></b>&nbsp;<span style=\"font-size: 8pt; font-family: Verdana;\">&nbsp;+0.025 mm<br>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; +0.10</span></td></tr><tr><td><span style=\"font-size: 8pt; font-family: Verdana;\">Blok Flanş Derinliği ( C ) için</span>&nbsp;<b><font face=\"Verdana\" style=\"font-size: 8pt;\">:</font></b>&nbsp;<span style=\"font-size: 8pt; font-family: Verdana;\">+0.00 mm<br>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; +0.15</span></td></tr></tbody></table><p><font face=\"Verdana\" style=\"font-size: medium;\"><span style=\"font-size: 8pt;\"><br></span></font><br></p></td></tr></tbody></table>', NULL, 1, NULL, NULL, NULL, NULL, '', '', '', '', NULL, NULL, NULL, NULL, NULL),
(113, 60, 'Gomlek Montaj İşlemleri', '<table border=\"0\" width=\"100%\" cellspacing=\"0\" cellpadding=\"0\" style=\"font-family: &quot;Times New Roman&quot;;\"><tbody><tr><td height=\"24\"><b><font face=\"Arial\" size=\"2\">Gömlek Montaj İşlemleri</font></b></td></tr><tr><td><font face=\"Arial\" style=\"font-size: 9pt;\">Üretilen Gömlekler :<br>-Kuru Gömlek<br>-Sulu Gömlek olarak iki tiptir.&nbsp;<br>Savurma döküm metoduyla üretilen gömlekler orijinal motor üreticisinin spesifikasyonlarına uygun olarak üretilmelidir. A tipi grafit yapısı ve fosfit dağılımı ile diğer piston segman üreticilerinin segmanları ile uyum içinde çalışır. Silindir gömlekleri hassas işlenmiş parçalardır ve bu nedenle darbelere karşı çok hassastır. Taşıma, paket açma ve motora takmalarda çok dikkatli davranmak gerekir. Depolamada her zaman dik tutmak ve rutubetli ortamda bulundurmamak lazımdır.</font></td></tr><tr><td><p><img src=\"/Upload/social_icons/gomlek1.gif\" style=\"width: auto; margin: 0px auto; max-width: 100%;\"></p><p><font face=\"Arial\" style=\"font-size: 9pt;\"><b>Sulu Gömleklerin Montajı</b></font><font face=\"Verdana\" style=\"font-size: medium;\"><span style=\"font-size: 8pt;\"><br>Montajdan önce silindir bloğunun çok iyi temizlenmesi lazımdır. Gömlek önce lastiksiz olarak takılmalı, rahat girip girmediği kontrol edilmeli sonra oringlere sıvı sabun sürülerek gömlek takılmalıdır. Takıldıktan sonra flanş yüksekliği ve iç çap kontrol edilmelidir.</span></font></p><p><img src=\"/Upload/social_icons/gomlek2.gif\" style=\"width: auto; margin: 0px auto; max-width: 100%;\"><font face=\"Verdana\" style=\"font-size: medium;\"><span style=\"font-size: 8pt;\"><br></span></font></p><p><font face=\"Arial\" style=\"font-size: 9pt;\"><b>Kuru (Semi) Gömleklerin Montajı</b></font><font face=\"Verdana\" style=\"font-size: medium;\"><span style=\"font-size: 8pt;\"><br>Montajdan önce blok çok iyi temizlenmeli, gömleğin geçeceği yuva çapı ölçüleri kontrol edilmeli daha sonra hidrolik preste 3000 kg ile 5000 kg kuvvet arasında bloğa geçirilmeli daha sonra eksen değiştirmeyecek şekilde rektefiyeleme ve honlama yapılmalıdır ve iç çaplar 20&nbsp;<sup>o</sup>C ‘ de ölçülmelidir.</span></font></p><table border=\"0\" width=\"100%\" cellspacing=\"0\" cellpadding=\"0\"><tbody><tr><td><font face=\"Arial\" style=\"font-size: 9pt;\"><b>Kuru Gömlek (Standart)<br></b></font><font face=\"Verdana\"><span style=\"font-size: 8pt;\">Dışı ve içi standart olan gömlekler için uygulanan tolerans :</span></font></td></tr><tr><td><span style=\"font-size: 8pt; font-family: Verdana;\">Blok Çapı ( f</span><font face=\"Verdana\"><span style=\"font-size: 8pt;\">B ) için&nbsp;</span></font><b><font face=\"Verdana\" style=\"font-size: 8pt;\">:</font></b>&nbsp;<span style=\"font-size: 8pt; font-family: Verdana;\">+0.015 mm<br>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; +0.00</span></td></tr><tr><td><span style=\"font-size: 8pt; font-family: Verdana;\">Blok Flanş Çapı ( fA )</span>&nbsp;<b><font face=\"Verdana\" style=\"font-size: 8pt;\">:</font></b>&nbsp;<span style=\"font-size: 8pt; font-family: Verdana;\">&nbsp;+0.025 mm<br>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; +0.10</span></td></tr><tr><td><span style=\"font-size: 8pt; font-family: Verdana;\">Blok Flanş Derinliği ( C ) için</span>&nbsp;<b><font face=\"Verdana\" style=\"font-size: 8pt;\">:</font></b>&nbsp;<span style=\"font-size: 8pt; font-family: Verdana;\">+0.00 mm<br>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; +0.15</span></td></tr></tbody></table><p><font face=\"Verdana\" style=\"font-size: medium;\"><span style=\"font-size: 8pt;\"><br></span></font><br></p></td></tr></tbody></table>', NULL, 2, NULL, NULL, NULL, NULL, '', '', '', '', NULL, NULL, NULL, NULL, NULL),
(114, 61, 'Kullanım Klavuzu', '<p><img src=\"/Upload/social_icons/kullanim1.gif\" style=\"width: auto; margin: 0px auto; max-width: 100%;\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<br></p><p><br></p><table border=\"0\" width=\"100%\" cellspacing=\"0\" cellpadding=\"0\" style=\"font-family: &quot;Times New Roman&quot;;\"><tbody><tr><td valign=\"top\"><font face=\"Verdana\"><span style=\"font-size: 8pt;\">1</span></font>&nbsp;<span style=\"font-size: 8pt; font-family: Verdana;\">Araç motor üreticisi, motor türü, motorun veya aracın teknik bilgileri<br></span><font face=\"Verdana\"><span style=\"font-size: 8pt;\">2</span></font>&nbsp;<span style=\"font-size: 8pt; font-family: Verdana;\">Piston veya piston kalıbının nominal ölçüsü ve numarası<br></span><font face=\"Verdana\"><span style=\"font-size: 8pt;\">3</span></font>&nbsp;<span style=\"font-size: 8pt; font-family: Verdana;\">Kompresyon yüksekliği ve toplam piston boyu<br></span><font face=\"Verdana\"><span style=\"font-size: 8pt;\">4</span></font>&nbsp;<span style=\"font-size: 8pt; font-family: Verdana;\">Piston tür kısaltması<br></span><font face=\"Verdana\"><span style=\"font-size: 8pt;\">5</span></font>&nbsp;<span style=\"font-size: 8pt; font-family: Verdana;\">Pim çapı ve uzunluğu<br></span><font face=\"Verdana\"><span style=\"font-size: 8pt;\">6</span></font>&nbsp;<span style=\"font-size: 8pt; font-family: Verdana;\">Segmanların sayısı, tipi, boyutları ve gömleğin şekli<br></span><font face=\"Verdana\"><span style=\"font-size: 8pt;\">7</span></font>&nbsp;<span style=\"font-size: 8pt; font-family: Verdana;\">Silindir ölçüleri ve referans numarası<br></span><font face=\"Verdana\"><span style=\"font-size: 8pt;\">8</span></font>&nbsp;<span style=\"font-size: 8pt; font-family: Verdana;\">Piston ve kit referans numarası</span></td></tr></tbody></table>', NULL, 1, NULL, NULL, NULL, NULL, '', '', '', '', NULL, NULL, NULL, NULL, NULL),
(115, 61, 'Kullanım Klavuzu', '<p><img src=\"/Upload/social_icons/kullanim1.gif\" style=\"width: auto; margin: 0px auto; max-width: 100%;\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<br></p><p><br></p><table border=\"0\" width=\"100%\" cellspacing=\"0\" cellpadding=\"0\" style=\"font-family: &quot;Times New Roman&quot;;\"><tbody><tr><td valign=\"top\"><font face=\"Verdana\"><span style=\"font-size: 8pt;\">1</span></font>&nbsp;<span style=\"font-size: 8pt; font-family: Verdana;\">Araç motor üreticisi, motor türü, motorun veya aracın teknik bilgileri<br></span><font face=\"Verdana\"><span style=\"font-size: 8pt;\">2</span></font>&nbsp;<span style=\"font-size: 8pt; font-family: Verdana;\">Piston veya piston kalıbının nominal ölçüsü ve numarası<br></span><font face=\"Verdana\"><span style=\"font-size: 8pt;\">3</span></font>&nbsp;<span style=\"font-size: 8pt; font-family: Verdana;\">Kompresyon yüksekliği ve toplam piston boyu<br></span><font face=\"Verdana\"><span style=\"font-size: 8pt;\">4</span></font>&nbsp;<span style=\"font-size: 8pt; font-family: Verdana;\">Piston tür kısaltması<br></span><font face=\"Verdana\"><span style=\"font-size: 8pt;\">5</span></font>&nbsp;<span style=\"font-size: 8pt; font-family: Verdana;\">Pim çapı ve uzunluğu<br></span><font face=\"Verdana\"><span style=\"font-size: 8pt;\">6</span></font>&nbsp;<span style=\"font-size: 8pt; font-family: Verdana;\">Segmanların sayısı, tipi, boyutları ve gömleğin şekli<br></span><font face=\"Verdana\"><span style=\"font-size: 8pt;\">7</span></font>&nbsp;<span style=\"font-size: 8pt; font-family: Verdana;\">Silindir ölçüleri ve referans numarası<br></span><font face=\"Verdana\"><span style=\"font-size: 8pt;\">8</span></font>&nbsp;<span style=\"font-size: 8pt; font-family: Verdana;\">Piston ve kit referans numarası</span></td></tr></tbody></table>', NULL, 2, NULL, NULL, NULL, NULL, '', '', '', '', NULL, NULL, NULL, NULL, NULL),
(116, 62, 'Piston Teknik Kısaltmaları', '<table border=\"0\" width=\"100%\" cellspacing=\"0\" cellpadding=\"0\" style=\"font-family: &quot;Times New Roman&quot;;\"><tbody><tr><td height=\"24\"><b><font face=\"Arial\" size=\"2\">Piston Teknik Kısaltmaları</font></b></td></tr><tr><td><font face=\"Verdana\" style=\"font-size: 8pt;\">CP</font>&nbsp;<span style=\"font-size: 8pt; font-family: Verdana;\">Çelik plakalı piston<br></span><font face=\"Verdana\" style=\"font-size: 8pt;\">AT</font>&nbsp;<span style=\"font-size: 8pt; font-family: Verdana;\">Alfin taşıyıcılı piston<br></span><font face=\"Verdana\" style=\"font-size: 8pt;\">DAT</font>&nbsp;<font face=\"Verdana\"><span style=\"font-size: 8pt;\">Çift alfin taşıyıcılı piston<br></span></font><font face=\"Verdana\" style=\"font-size: 8pt;\">B</font>&nbsp;<font face=\"Verdana\"><span style=\"font-size: 8pt;\">Sarı burçlu piston<br></span></font><font face=\"Verdana\" style=\"font-size: 8pt;\">YS</font>&nbsp;<font face=\"Verdana\"><span style=\"font-size: 8pt;\">Yağ soğutma kanallı piston</span></font></td></tr></tbody></table>', NULL, 1, NULL, NULL, NULL, NULL, '', '', '', '', NULL, NULL, NULL, NULL, NULL),
(117, 62, 'Piston Teknik Kısaltmaları', '<table border=\"0\" width=\"100%\" cellspacing=\"0\" cellpadding=\"0\" style=\"font-family: &quot;Times New Roman&quot;;\"><tbody><tr><td height=\"24\"><b><font face=\"Arial\" size=\"2\">Piston Teknik Kısaltmaları</font></b></td></tr><tr><td><font face=\"Verdana\" style=\"font-size: 8pt;\">CP</font>&nbsp;<span style=\"font-size: 8pt; font-family: Verdana;\">Çelik plakalı piston<br></span><font face=\"Verdana\" style=\"font-size: 8pt;\">AT</font>&nbsp;<span style=\"font-size: 8pt; font-family: Verdana;\">Alfin taşıyıcılı piston<br></span><font face=\"Verdana\" style=\"font-size: 8pt;\">DAT</font>&nbsp;<font face=\"Verdana\"><span style=\"font-size: 8pt;\">Çift alfin taşıyıcılı piston<br></span></font><font face=\"Verdana\" style=\"font-size: 8pt;\">B</font>&nbsp;<font face=\"Verdana\"><span style=\"font-size: 8pt;\">Sarı burçlu piston<br></span></font><font face=\"Verdana\" style=\"font-size: 8pt;\">YS</font>&nbsp;<font face=\"Verdana\"><span style=\"font-size: 8pt;\">Yağ soğutma kanallı piston</span></font></td></tr></tbody></table>', NULL, 2, NULL, NULL, NULL, NULL, '', '', '', '', NULL, NULL, NULL, NULL, NULL),
(118, 63, 'Kalite Belgeleri', '', NULL, 1, NULL, NULL, NULL, NULL, '', '', '', '', NULL, NULL, NULL, NULL, NULL),
(119, 63, 'Kalite Belgeleri', '', NULL, 2, NULL, NULL, NULL, NULL, '', '', '', '', NULL, NULL, NULL, NULL, NULL),
(120, 64, 'Fuarlar', '', NULL, 1, NULL, NULL, NULL, NULL, '', '', '', '', NULL, NULL, NULL, NULL, NULL),
(121, 64, 'Fuarlar', '', NULL, 2, NULL, NULL, NULL, NULL, '', '', '', '', NULL, NULL, NULL, NULL, NULL),
(122, 65, 'fuar', '<p><span style=\"font-family: Arial; font-size: 12px; text-align: justify; background-color: rgb(250, 250, 250);\">Türk otomotiv sektöründeki ihracat, Almanya\'nın listede 1. sırada olduğu, ilk 5 ayda %44,2 \'ye varan bir artış yakalamıştır.</span><br></p>', NULL, 1, '', '', '', '', '', '', '', '', '', '', '', '', ''),
(123, 65, 'haberler', '', NULL, 2, NULL, NULL, NULL, NULL, '', '', '', '', NULL, NULL, NULL, NULL, NULL),
(124, 66, 'Piston', '', NULL, 1, '', '', '', '', '', '', '', '', '', '', '', '', ''),
(125, 66, 'Piston', '', NULL, 2, NULL, NULL, NULL, NULL, '', '', '', '', '', '', '', '', NULL),
(126, 67, 'Lıner', '', NULL, 1, '', '', '', '', '', '', '', '', '', '', '', '', ''),
(127, 67, 'Lıner', '', NULL, 2, NULL, NULL, NULL, NULL, '', '', '', '', '', '', '', '', NULL),
(128, 68, 'Rıng', '', NULL, 1, '', '', '', '', '', '', '', '', '', '', '', '', ''),
(129, 68, 'Rıng', '', NULL, 2, NULL, NULL, NULL, NULL, '', '', '', '', '', '', '', '', NULL),
(130, 69, 'Hakkımızda', '<p>MOGESAN1994 yılında Konya Motorlu Araçlar Sanayisinde atölye ölçeğindeki işletmesinde kısıtlı imkânlarla içten yanmalı motorlara ait silindir gömleklerinin imalatı ile faaliyete başlamıştır. 1999 yılında zafer sanayine taşınarak faaliyetine devam etmiştir. bulunduğu yerin darlığından dolayı artan taleplere cevap veremez olduğu için 250 m2 olan imalat alanını 600 m2 ye çıkarmıştır. 2001 yılında imalat alanını 1000 m2 ye çıkartıp piston imalatına başlamıştır.Piston imalatında genişleyip büyüme sağlanmış, bulunduğu yerin kapalı alanı küçük gelmeye başlamış 2003 yılında Konya 1. Organize Sanayi Bölgesi’nde 7500 m2 arsa üzerine kurulu 4500 m2 kapalı alana sahip iş yerine taşınmış kendini yenileyerek, geliştirerek halen burada imalatına devam etmektedir. Mogesan 2013 yılının ortalarından sonra Konya 2. Organize Sanayi Bölgesindeki toplam 30.000 m2 alan üzerine kurulu yeni fabrikasına taşınmayı hedeflemektedir.</p><p><br></p><p>Ürün kalitemizi sürekli olarak geliştirmek, tüm çalışanlarımızın müşteri memnuniyetini ilke edinmesini sağlamak amacıyla 2005 yılında TS-EN-ISO 9001:2000 Kalite Güvence Sistemini kurmuş ve uygulamakta olan kuruluşumuz, 2010 yılında da yeni kalite revizyonları gerçekleştirerek TS-EN-ISO 9001:2008 Kalite Güvence Sistemini kurmuş ve iç pazarda ve resmi/tüzel kuruluşlarda pazar payını artırmak için TS 1106 (Pistonlar-Alüminyum Alaşımı-Benzin ve Diesel Motorları İçin), TS 482 (İçten Yanmalı Motorlar Silindir Gömlekleri) standardı belgesini almıştır ve uygulamaya devam ermektedir.</p><p><br></p><p>Kuruluşumuzda, belirlenen şartlara uygun ürün üretimin güvence altına alınmasını sağlamak amacıyla hammadde girişinden sevkiyata kadar ki tüm aşamalarda kalite kontrolü uygulanmaktadır.</p><p><br></p><p>Çalışan personelimizin yeterliliği, bilinci ve eğitimi sürekli olarak artırılarak üretimin ve hizmetin eksiksiz yapılması sağlanmaktadır.</p><p><br></p><p>MOGESAN Motor Gömlek Piston Sanayi ve Tic. Ltd. Şti. yılda 260.000 adet piston ve 140.000 adet motor gömleği imalatı yapmaktadır. Ürettiği piston ve motor gömleklerin yaklaşık % 75 ini doğrudan ve dolaylı olarak yurt dışına ihraç etmekte ve ürettiği ürünlerin geri kalanını da yurt içinde pazarlamaktadır. İç ve dış pazarda müşterilerimizin beğenisini kazanan ürünlerimiz başta Ortadoğu ve Afrika olmak üzere 60 ın üzerinde ülkeye ihraç edilmektedir.</p><p><br></p><p>Kaliteden taviz vermeden en üst düzeyde müşteri memnuniyeti sağlamayı amaç edinen kuruluşumuz, müşteri istekleri, teknolojik gelişmeler ve sipariş artışına bağlı olarak teknik imkanlarını geliştirmeyi ve üretim kapasitesini artırmayı sürdürmektedir.</p><p><br></p><p>MOGESAN; bu gelişmelerin sonucunda müşterilerimize ulusal ve uluslararası standartların öngördüğü kalite özelliklerine sahip ürünler sunmaya devam edecek, üretim kapasitemizi yükselterek işgücü istihdamının artırılması, ihracat yapılan ülkelerin özellikle AB ülkelerinin sayısının artması düşünüldüğünden, kuruluşumuzun karlılığı yükselecek, ülke ekonomisine olan katkıda büyüme olacak ve bu sayede müşterilerimizin, işverenimizin ve çalışanlarımızın memnuniyetinin artırılması sağlanacaktır.</p><p><br></p><p>MOGESAN, ürün kalitesinin sürekliliği ve müşteri memnuniyetine verdiği önem ile 21. yüzyılda bir dünya markası olmayı hedeflemektedir.</p><p><br></p>', NULL, 1, '', '', '', '', '', '', '', '', '', '', '', '', ''),
(131, 69, 'kalıte belgesi', '<p><span style=\"font-family: Arial; font-size: 12px; text-align: justify; background-color: rgb(250, 250, 250);\">Türk otomotiv sektöründeki ihracat, Almanya\'nın listede 1. sırada olduğu, ilk 5 ayda %44,2 \'ye varan bir artış yakalamıştır.</span></p><p><span style=\"font-family: Arial; font-size: 12px; text-align: justify; background-color: rgb(250, 250, 250);\">Türk otomotiv sektöründeki ihracat, Almanya\'nın listede 1. sırada olduğu, ilk 5 ayda %44,2 \'ye varan bir artış yakalamıştır.</span></p><p><span style=\"font-family: Arial; font-size: 12px; text-align: justify; background-color: rgb(250, 250, 250);\">Türk otomotiv sektöründeki ihracat, Almanya\'nın listede 1. sırada olduğu, ilk 5 ayda %44,2 \'ye varan bir artış yakalamıştır.</span><span style=\"font-family: Arial; font-size: 12px; text-align: justify; background-color: rgb(250, 250, 250);\">Türk otomotiv sektöründeki ihracat, Almanya\'nın listede 1. sırada olduğu, ilk 5 ayda %44,2 \'ye varan bir artış yakalamıştır.</span><span style=\"font-family: Arial; font-size: 12px; text-align: justify; background-color: rgb(250, 250, 250);\"><br></span><span style=\"font-family: Arial; font-size: 12px; text-align: justify; background-color: rgb(250, 250, 250);\"><br></span><br></p>', NULL, 2, NULL, NULL, NULL, NULL, '', '', '', '', '', '', '', '', NULL);
INSERT INTO `icerikdetay` (`Id`, `icerik_Id`, `Baslik`, `Detay`, `slug`, `DilID`, `Keywords`, `Descriptions`, `Title`, `SeoField`, `Layer1`, `Layer2`, `Layer3`, `Layer4`, `Layer5`, `Layer6`, `Layer7`, `Layer8`, `seo_url`) VALUES
(132, 70, 'Ürünler', '<p><span style=\"font-family: Arial; font-size: 12px; text-align: justify; background-color: rgb(250, 250, 250);\">Türk otomotiv sektöründeki ihracat, Almanya\'nın listede 1. sırada olduğu, ilk 5 ayda %44,2 \'ye varan bir artış yakalamıştır.</span><span style=\"background-color: rgb(250, 250, 250); font-family: Arial; font-size: 12px; text-align: justify;\">Türk otomotiv sektöründeki ihracat, Almanya\'nın listede 1. sırada olduğu, ilk 5 ayda %44,2 \'ye varan bir artış yakalamıştır.</span><span style=\"background-color: rgb(250, 250, 250); font-family: Arial; font-size: 12px; text-align: justify;\">Türk otomotiv sektöründeki ihracat, Almanya\'nın listede 1. sırada olduğu, ilk 5 ayda %44,2 \'ye varan bir artış yakalamıştır.</span><span style=\"background-color: rgb(250, 250, 250); font-family: Arial; font-size: 12px; text-align: justify;\">Türk otomotiv sektöründeki ihracat, Almanya\'nın listede 1. sırada olduğu, ilk 5 ayda %44,2 \'ye varan bir artış yakalamıştır.</span><span style=\"background-color: rgb(250, 250, 250); font-family: Arial; font-size: 12px; text-align: justify;\">Türk otomotiv sektöründeki ihracat, Almanya\'nın listede 1. sırada olduğu, ilk 5 ayda %44,2 \'ye varan bir artış yakalamıştır.</span><span style=\"background-color: rgb(250, 250, 250); font-family: Arial; font-size: 12px; text-align: justify;\">Türk otomotiv sektöründeki ihracat, Almanya\'nın listede 1. sırada olduğu, ilk 5 ayda %44,2 \'ye varan bir artış yakalamıştır.</span><span style=\"background-color: rgb(250, 250, 250); font-family: Arial; font-size: 12px; text-align: justify;\">Türk otomotiv sektöründeki ihracat, Almanya\'nın listede 1. sırada olduğu, ilk 5 ayda %44,2 \'ye varan bir artış yakalamıştır.</span><br></p>', NULL, 1, '', '', '', '', '', '', '', '', '', '', '', '', ''),
(133, 70, 'segman', '<p><span style=\"font-family: Arial; font-size: 12px; text-align: justify; background-color: rgb(250, 250, 250);\">Türk otomotiv sektöründeki ihracat, Almanya\'nın listede 1. sırada olduğu, ilk 5 ayda %44,2 \'ye varan bir artış yakalamıştır.</span><span style=\"background-color: rgb(250, 250, 250); font-family: Arial; font-size: 12px; text-align: justify;\">Türk otomotiv sektöründeki ihracat, Almanya\'nın listede 1. sırada olduğu, ilk 5 ayda %44,2 \'ye varan bir artış yakalamıştır.</span><span style=\"background-color: rgb(250, 250, 250); font-family: Arial; font-size: 12px; text-align: justify;\">Türk otomotiv sektöründeki ihracat, Almanya\'nın listede 1. sırada olduğu, ilk 5 ayda %44,2 \'ye varan bir artış yakalamıştır.</span><span style=\"background-color: rgb(250, 250, 250); font-family: Arial; font-size: 12px; text-align: justify;\">Türk otomotiv sektöründeki ihracat, Almanya\'nın listede 1. sırada olduğu, ilk 5 ayda %44,2 \'ye varan bir artış yakalamıştır.</span><span style=\"background-color: rgb(250, 250, 250); font-family: Arial; font-size: 12px; text-align: justify;\">Türk otomotiv sektöründeki ihracat, Almanya\'nın listede 1. sırada olduğu, ilk 5 ayda %44,2 \'ye varan bir artış yakalamıştır.</span><span style=\"background-color: rgb(250, 250, 250); font-family: Arial; font-size: 12px; text-align: justify;\">Türk otomotiv sektöründeki ihracat, Almanya\'nın listede 1. sırada olduğu, ilk 5 ayda %44,2 \'ye varan bir artış yakalamıştır.</span><span style=\"background-color: rgb(250, 250, 250); font-family: Arial; font-size: 12px; text-align: justify;\">Türk otomotiv sektöründeki ihracat, Almanya\'nın listede 1. sırada olduğu, ilk 5 ayda %44,2 \'ye varan bir artış yakalamıştır.</span><br></p>', NULL, 2, NULL, NULL, NULL, NULL, '', '', '', '', '', '', '', '', NULL);

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
(7, NULL, 'Upload/72476066627420142337191_15022018-163017.JPG', NULL, 43, '', 0),
(18, NULL, 'Upload/fuar.jpg', NULL, 64, '', 0),
(19, NULL, 'Upload/gal.png', NULL, 51, '', 0),
(20, NULL, 'Upload/gal12.png', NULL, 51, '', 0),
(21, NULL, 'Upload/gal11.png', NULL, 51, '', 0),
(22, NULL, 'Upload/gal10.png', NULL, 51, '', 0),
(23, NULL, 'Upload/gal8.png', NULL, 51, '', 0),
(24, NULL, 'Upload/gal7.png', NULL, 51, '', 0),
(25, NULL, 'Upload/gal6.png', NULL, 51, '', 0),
(26, NULL, 'Upload/gal5.png', NULL, 51, '', 0),
(27, NULL, 'Upload/gal2.jpg', NULL, 51, '', 0),
(28, NULL, 'Upload/gal4.jpg', NULL, 51, '', 0),
(29, NULL, 'Upload/gal9.jpg', NULL, 51, '', 0),
(30, NULL, 'Upload/gal13.png', NULL, 51, '', 0),
(35, NULL, 'Upload/fuar_20062018-154720.jpg', NULL, 65, '', 0),
(36, NULL, 'Upload/6b.jpg', NULL, 63, '', 0),
(37, NULL, 'Upload/5b.jpg', NULL, 63, '', 0),
(38, NULL, 'Upload/2b-1.jpg', NULL, 63, '', 0),
(39, NULL, 'Upload/1b.jpg', NULL, 63, '', 0);

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
(1, 'MOGESAN', 'MOGESAN', 'MOGESAN', 1),
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
(16, 'Upload/95x66.jpg', ' ', '#', 0, 0, NULL),
(18, 'Upload/slayt.jpg', ' ', '#', 0, 0, NULL);

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
(1, 'Facebook', 'https://twitter.com', '<i class=\"fa fa-facebook\"></i>', 1),
(2, 'Twitter', 'https://www.facebook.com/', '<i class=\"fa fa-twitter\"></i>', 2),
(3, 'Instagram', '#', '<i class=\"fa fa-instagram\"></i>', 4),
(4, 'Linked In', '#', '<i class=\"fa fa-linkedin\"></i>', 3);

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
(1, 'default', 'default', 0, '{\'renk\': \'dark-red\',\'logo\': \'/Upload/logo.png\',\'footer-logo\': \'/Upload/Başlıksız-4.png\',\'staticfiles\': \'assets/css/custom.css,assets/js/custom.js\'}', 1, '2017-09-27 23:21:32');

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
(6, 'Anasayfa', '0', '0', '0', '0', '0', '', '', '', '', '', '', '', '', 0, 0, 0, 0, 0, 0, 1, 0, 1, 1, 1, 0, 1),
(9, 'Foto Galeri', '0', '0', '800x800', '0', '0', '', '', '', '', '', '', '', '', 0, 0, 0, 0, 0, 0, 1, 0, 1, 0, 0, 0, 7),
(11, 'İletişim', '0', '0', '0', '0', '0', 'Telefon', 'Fax', 'Eposta', 'Harita', '', '', '', '', 0, 0, 1, 1, 0, 1, 1, 0, 1, 1, 0, 0, 8),
(12, 'Hakkımızda', '800x600', '0', '0', '0', '0', '', '', '', '', '', '', '', '', 0, 1, 0, 1, 0, 0, 1, 0, 1, 1, 0, 0, 2),
(13, 'Ürünlerimiz', '200x200', '0', '0', '0', '0', '', '', '', '', '', '', '', '', 0, 0, 1, 1, 1, 0, 1, 0, 0, 1, 0, 0, 3),
(14, 'Teknik Özellikler', '0', '0', '800x600', '800x600', '0', '', '', '', '', '', '', '', '', 0, 1, 0, 1, 0, 0, 1, 0, 1, 0, 0, 0, 4),
(15, 'Kalite Belğeleri', '0', '0', '611x841', '0', '0', '', '', '', '', '', '', '', '', 0, 0, 0, 1, 0, 0, 1, 0, 0, 1, 0, 0, 5),
(16, 'Fuarlar', '0', '0', '800x600', '0', '0', '', '', '', '', '', '', '', '', 0, 0, 0, 1, 0, 0, 1, 0, 1, 1, 0, 0, 6),
(17, 'haberler', '800x600', '0', '604x265', '0', '0', '', '', '', '', '', '', '', '', 0, 0, 0, 1, 0, 0, 0, 0, 1, 1, 0, 0, 0);

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
(6, 1, 6, 'Anasayfa', ''),
(9, 1, 9, 'Foto Galeri', ''),
(11, 1, 11, 'İletişim', ''),
(15, 2, 6, 'Anasayfa', NULL),
(18, 2, 9, 'Foto Galeri', NULL),
(20, 2, 11, 'İletişim', NULL),
(21, 1, 12, 'Hakkımızda', ''),
(22, 2, 12, 'Hakkımızda', NULL),
(23, 1, 13, 'Ürünlerimiz', ''),
(24, 2, 13, 'Ürünlerimiz', NULL),
(25, 1, 14, 'Teknik Özellikler', ''),
(26, 2, 14, 'Teknik Özellikler', NULL),
(27, 1, 15, 'Kalite Belgeleri', ''),
(28, 2, 15, 'Kalite Belğeleri', NULL),
(29, 1, 16, 'Fuarlar', ''),
(30, 2, 16, 'Fuarlar', NULL),
(31, 1, 17, '', ''),
(32, 2, 17, 'haberler', NULL);

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
  MODIFY `Id` bigint(20) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=71;

--
-- AUTO_INCREMENT for table `icerikdetay`
--
ALTER TABLE `icerikdetay`
  MODIFY `Id` bigint(20) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=134;

--
-- AUTO_INCREMENT for table `icerikgaleri`
--
ALTER TABLE `icerikgaleri`
  MODIFY `Id` bigint(20) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=40;

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
  MODIFY `Id` bigint(20) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=19;

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
  MODIFY `Id` bigint(20) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=18;

--
-- AUTO_INCREMENT for table `turdetay`
--
ALTER TABLE `turdetay`
  MODIFY `Id` bigint(20) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=33;

--
-- AUTO_INCREMENT for table `yonetici`
--
ALTER TABLE `yonetici`
  MODIFY `YoneticiID` bigint(20) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
