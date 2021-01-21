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
-- Database: `icerikyonetimsistemi`
--

-- --------------------------------------------------------

--
-- Table structure for table `formlars`
--

CREATE TABLE `formlars` (
  `FormID` int(11) NOT NULL,
  `AdSoyad` longtext NOT NULL,
  `EPosta` longtext NOT NULL,
  `MesajIcerigi` varchar(1000) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Table structure for table `fotografgaleris`
--

CREATE TABLE `fotografgaleris` (
  `GorselID` int(11) NOT NULL,
  `Baslik` varchar(50) NOT NULL,
  `Detay` varchar(255) NOT NULL,
  `Adres` longtext NOT NULL,
  `OlusturmaTarihi` datetime NOT NULL,
  `DuzenlemeTarihi` datetime NOT NULL,
  `Etkin` tinyint(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Table structure for table `kullanicis`
--

CREATE TABLE `kullanicis` (
  `KullaniciID` int(11) NOT NULL,
  `KullaniciYetkiID` int(11) NOT NULL,
  `EPosta` varchar(50) NOT NULL,
  `Sifre` varchar(25) NOT NULL,
  `KullaniciAdi` varchar(15) NOT NULL,
  `ProfilFotografi` longtext,
  `Ad` varchar(25) DEFAULT NULL,
  `Soyad` varchar(25) DEFAULT NULL,
  `KayitTarihi` datetime NOT NULL,
  `Etkin` tinyint(1) NOT NULL,
  `Guid` char(36) CHARACTER SET utf8 COLLATE utf8_bin NOT NULL DEFAULT ''
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `kullanicis`
--

INSERT INTO `kullanicis` (`KullaniciID`, `KullaniciYetkiID`, `EPosta`, `Sifre`, `KullaniciAdi`, `ProfilFotografi`, `Ad`, `Soyad`, `KayitTarihi`, `Etkin`, `Guid`) VALUES
(1, 1, 'admin@admin.com', '123456', 'admin', NULL, NULL, NULL, '2018-08-14 20:11:00', 1, '63794ee7-035c-4af0-a497-2e69a81b2d9f');

-- --------------------------------------------------------

--
-- Table structure for table `kullaniciyetkis`
--

CREATE TABLE `kullaniciyetkis` (
  `KullaniciYetkiID` int(11) NOT NULL,
  `KullaniciYetkiAdi` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `kullaniciyetkis`
--

INSERT INTO `kullaniciyetkis` (`KullaniciYetkiID`, `KullaniciYetkiAdi`) VALUES
(1, 'Site Yöneticisi'),
(2, 'İçerik Yöneticisi'),
(3, 'Kullanıcı');

-- --------------------------------------------------------

--
-- Table structure for table `sayfaalticeriks`
--

CREATE TABLE `sayfaalticeriks` (
  `SayfaAltIcerikID` int(11) NOT NULL,
  `SayfaIcerikID` int(11) NOT NULL,
  `Baslik` varchar(100) NOT NULL,
  `Detay` longtext,
  `Gorsel` longtext,
  `SayfaID` int(11) NOT NULL,
  `OlusturmaTarihi` datetime NOT NULL,
  `DuzenlemeTarihi` datetime NOT NULL,
  `Ikon` longtext,
  `GosterimSirasi` int(11) NOT NULL,
  `Etkin` tinyint(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Table structure for table `sayfaicerikgaleris`
--

CREATE TABLE `sayfaicerikgaleris` (
  `SayfaIcerikGorselID` int(11) NOT NULL,
  `SayfaIcerikID` int(11) NOT NULL,
  `Gorsel` longtext,
  `Baslik` varchar(25) NOT NULL,
  `Detay` varchar(1000) DEFAULT NULL,
  `SayfaID` int(11) NOT NULL,
  `OlusturmaTarihi` datetime NOT NULL,
  `DuzenlemeTarihi` datetime NOT NULL,
  `Ikon` longtext,
  `GosterimSirasi` int(11) NOT NULL,
  `Etkin` tinyint(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Table structure for table `sayfaiceriks`
--

CREATE TABLE `sayfaiceriks` (
  `SayfaIcerikID` int(11) NOT NULL,
  `Baslik` varchar(50) NOT NULL,
  `Detay` longtext,
  `Gorsel` longtext,
  `Yorum` tinyint(1) NOT NULL,
  `SayfaID` int(11) NOT NULL,
  `OlusturmaTarihi` datetime NOT NULL,
  `DuzenlemeTarihi` datetime NOT NULL,
  `Ikon` longtext,
  `GosterimSirasi` int(11) NOT NULL,
  `Etkin` tinyint(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `sayfaiceriks`
--

INSERT INTO `sayfaiceriks` (`SayfaIcerikID`, `Baslik`, `Detay`, `Gorsel`, `Yorum`, `SayfaID`, `OlusturmaTarihi`, `DuzenlemeTarihi`, `Ikon`, `GosterimSirasi`, `Etkin`) VALUES
(1, 'Hakkımızda', 'Lorem Ipsum, dizgi ve baskı endüstrisinde kullanılan mıgır metinlerdir. Lorem Ipsum, adı bilinmeyen bir matbaacının bir hurufat numune kitabı oluşturmak üzere bir yazı galerisini alarak karıştırdığı 1500\'lerden beri endüstri standardı sahte metinler olarak kullanılmıştır. Beşyüz yıl boyunca varlığını sürdürmekle kalmamış, aynı zamanda pek değişmeden elektronik dizgiye de sıçramıştır. 1960\'larda Lorem Ipsum pasajları da içeren Letraset yapraklarının yayınlanması ile ve yakın zamanda Aldus PageMaker gibi Lorem Ipsum sürümleri içeren masaüstü yayıncılık yazılımları ile popüler olmuştur.', '~/Images/hakkimizda1.jpg', 0, 1, '2018-08-14 20:11:01', '2018-08-14 20:11:01', '<i class=\"icon-info-sign\"></i>', 1, 1);

-- --------------------------------------------------------

--
-- Table structure for table `sayfaicerikyorums`
--

CREATE TABLE `sayfaicerikyorums` (
  `SayfaIcerikYorumID` int(11) NOT NULL,
  `SayfaIcerikID` int(11) NOT NULL,
  `AdSoyad` varchar(50) NOT NULL,
  `EPosta` varchar(50) NOT NULL,
  `YorumMetni` varchar(255) NOT NULL,
  `SayfaID` int(11) NOT NULL,
  `OlusturmaTarihi` datetime NOT NULL,
  `DuzenlemeTarihi` datetime NOT NULL,
  `Ikon` longtext,
  `GosterimSirasi` int(11) NOT NULL,
  `Etkin` tinyint(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Table structure for table `sayfalars`
--

CREATE TABLE `sayfalars` (
  `SayfaID` int(11) NOT NULL,
  `SayfaBasligi` varchar(25) NOT NULL,
  `Ikon` longtext,
  `Etkin` tinyint(1) NOT NULL,
  `GosterimSirasi` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `sayfalars`
--

INSERT INTO `sayfalars` (`SayfaID`, `SayfaBasligi`, `Ikon`, `Etkin`, `GosterimSirasi`) VALUES
(1, 'Hakkımızda', NULL, 1, 0),
(3, 'Anasayfa', NULL, 0, 0);

-- --------------------------------------------------------

--
-- Table structure for table `__migrationhistory`
--

CREATE TABLE `__migrationhistory` (
  `MigrationId` varchar(150) NOT NULL,
  `ContextKey` varchar(300) NOT NULL,
  `Model` longblob NOT NULL,
  `ProductVersion` varchar(32) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `__migrationhistory`
--

INSERT INTO `__migrationhistory` (`MigrationId`, `ContextKey`, `Model`, `ProductVersion`) VALUES
('201808141710519_InitialCreate', 'IcerikYonetimSistemi.VeriErisimKatmani.DatabaseContext', 0x1f8b0800000000000400ed5ddb6ee338127d5f60ff41d0e32213276904d8099c19a47369043de934dadd83e9a70663d18eb675f14a7423dec57ed93eec27ed2f0c75b528de294a9603232fb1445591c5e2a96289aafaff7fff37fdf5250c9c1f3049fd38ba744f8f4f5c0746f3d8f3a3e5a5bb468b9ffeeefefacb5fff32bdf5c217e7f7aadd9bac1d7e324a2fdd6784561793493a7f8621488f437f9ec469bc40c7f3389c002f9e9c9d9cfc3c393d9d404cc2c5b41c67fa691d213f84f90ffcf33a8ee67085d62078883d18a4e5757c679653753e8010a62b308797eefd1c26fef7af71043185999f2218fac7b863fe6de2a77ef81ea01044beeb5c053ec0bd9bc160e13a208a620410eefbc59714ce501247cbd90a5f00c1e7cd0ae2760b10a4b01cd3c5b6b9eaf04eceb2e14db60f56a4e6eb14c5a126c1d337a5bc26edc78da4eed6f2c412bdc592479b6cd4b9542fddbb38090390b84e9bd7c5759064ed78320749e07f2fe57d5c523972e46d8f6a3dc2ea96fd1d39d7eb00ad137819c1354a4070e47c5c3f05fefc3ddc7c8ebfc3e8325a07417314781cf81e71015ffa98c42b98a0cd27b8688cedfec67526e4b393f6c3f5a3ade7cae147e8cd99eb7cc09d004f01ac95a521aa198a13f80e463001087a1f014230c1737defc15cdc540f5afcaebc59bc015ec5102b285e7faef3005e7e83d1123d5fbaf85fd7b9f35fa0575d293bf125f2f172c50fa1640d199d1433befd18a7080ccff701a6e01fb9aa2c7d01f7d3939393eeeca793add24b96028a970958bc0301ee59e715d12436b285f12e4e5218982c8ded93432d8eb720c5321268c9b9051da1d9de40043602ae67e7e77db0bdf212980ebf201f03acebeb24049f41e23fd76bf206cfd8676ca9f5a5b7fe178c0218424bf46ed1773faaa8bc8de30082c8d6b27f9f51c1d2ebbae26b3a235bec75bf4cd63bf1f0504bbe66fa15e2799773ee68e4fa019099bf48a01040fae05a8beeca135ad65e98e39f0b3fa82c9f88bf2a8cc9c0b2bb7c259328f1cbac30790f363eda1d50328cfcdaaf075dfc2f23f001fcf097f9da172e65d7f90483bc59faecaf8aedd931d9e45bfd33df95dc2571f8290e284a44b36f58784b8870976379db59bc4ee69d6d45391c3b0623273656ab5163b0b1e95044f1beec871809cfec80bf7c01e4eadc8ffa572aada2fed5523152ff19d82cc055800a4deda8fe24b191a93fd93913f5a7290ca5fe396755b61d375fa73676e8fabb2f3bfe43b199ed9d4d311f1d6762ec3bb4fbef7134c08461544832744840ea77dc1618794a5c9ccf279909f024107c2b1b6e919d759f8274662316964bfb586137afa74d0e0da86ff597d98af2c3044d3bb96139adee51eb8acc186d8fb1c919dcd2e4364218c7ed67ab3b08e2d8d94f75812d7bab59b888e56bd7c292b5e7378ed769ece8310eef2e8e34c0be572eded73859875d61e2e0271efc4475bc667a88ddddc386cbd7878728ed35ed4c1ad8c3ea0dae780445ab6f8465620e826e28b2968cd62ccba938941259c423c91b290c846a271a07ddd8960360e5053b456fbcce80f9eb7626913d8c230d6486a5ae4c3f3b11992ba37c8ee5e01f1cfc0315ffa06962146c96c8ea12ed7a0c287531b68add17f80d2656aab4bcb68c544e6ebc362aef5e471355d3d8430b253f83d9cf367847a753f2a97a802812c7ed7a3197073b76b063d41643be6311998166b31e8d98f93e4badef0616ec2a4de3b99ff79979fa813c50408ae436f21c8dd305852ed36716b06263fbe4afb045c21dc4eeaedbb63c8fd10d0c2082ced5bcf80ae21aa473e0d1ea8407e999f4b1dec632fad8eededf28aed820c224b33820b8c6538f4dac1f21da7afad1dc5f81405d642d1246e76c32a1d4acdb776ee00a4699ad541791ad3ed5ac5b132893e574d2d058b122d301319e6a08a2635b852096ad4c2544b419cab67d21d9e3523052536ef7551481f326524b27b973d3b103bb50c06db453595b18a14f2595ec0944555edeb7fad708f1f602a47291a96b0ae7dd5b3785a54464a53fc3ea2f113150500e76f880a9b95534d7085299e1877d0356d6207600afac39db2b9065c488345548096aad29ac04380700769b9adb03c675d5e21eccc0b01adddce02a281773b7cbd4aa323869a4c2accdf2be412e630c3b405cc67ced15e0d2f10c3df551825b4baabaff60cb1dccceb0963b957b05b5edb3d542bde21eb436dff54838ec1fc472463028c072e6696cf05a0465f133083f0193ea650240e009a430bb0e5f10e325e2177cb3788f9896a1feb64e65746710355292e40ab38d0297ba54dfa1b4b24d01c595e7cb2042a6be90d06ac45629528d7baa54ca28329f54d94042afbd6e297aed062af4d842dfde52a121ee904e6fc80d8c889ee24cd2765a44b46cd2a2d9581abcc96d7dd6d8788239d5829716daaf2dea11d30a47e183decb0616651a9749e928488e0e7b33e425898d2b46c71b2310a8a26238bc4d8cb53c2c48a3b17e15c4c289d8eac66c6d088a8eb4b6a9f2a1a993dcc8d34242a1f1c3845a8142b6b8d890a41519ec5dc758c7949425a6a36982a8956de949b4ae0f95235eec0be5c78d90e8c448d843625a2b9da048efdac6384fa02a2c1d5de3efd8ed0a6e5045a3bea8e5484eb83b54df1f2a63b5fa86b09b7a550742eabd477d6f3a29f2669617a6134e82cde90358adfc68d948b8595e716645b6cdeb9f66fa2927c382c6649e32324fd6bdad39a138014bd8ba8b59e39edef9498aaabd94eb5c7b21d5acbdd3e278bb1537723345cf5be5fa56edb3ffcbf35ca5b28b138f1e73486f457b87471b667bddfce8634305b84f3a591ed44c3938592aafe3601d46e4b5b64af2a9d4e71e9b64ea8bea74aa738c4d32d535752a6462c8262df20e4d713a690998dafb53b34b055048655154a57a57dd8b3611db7213a51213e0cdc3f66393e61cf0be631151aa3ec968d2a9aea95329bfb06812292fe9687a9e5a91d4f3fc923a0dead469931a7553637cedd3a7c448db3735566571a8935894c5a5d1aca0edd6b98705c425aeb07604cff2c44d644b6c0a5d908351895e7d108f49947b4c4fa01856e0bacc71d824525e3218639ea78b39befc8e3a452a0d61932875530740dae8a1252bdacc6a1b5922532021aae68d7ee0816b2af204818499c8af8c0f608aa85f9f28c3e4a003351c02c3e30323851e9f34677dee68bea571bfcef32de6a030df32025c0c219e6bcf377d57039dc897b91459139ae371fdaacf8f6967565f464ce968c965df9cc8e253a626b1e28a8efcc9ef94c87920efbd2ae7b68eebf4854266b106fea37deb7efe489d318c2256df19523bad78419d347c97dad9b399ec66238d0ce4c18c09a994d1fd26114ec05f26e783293c984213b0e92f602a65a2073cba61d3e6a3cc082ab3c16ebd743ba0321e903c40d3019acca1a9b084fd221393871e30714828e0469da385031e9c3c308ad4ada1d2b85e4b36b3a5507e5379fd805032ba078492201475a4a3dda4e65e5ea97fd7473acae314f242aad4f98aa289eb60e1fcf0bdec6cc5c366f6cfe038bb7f9cff7b1df878c0db160f18d7163045450e2af7fcf8bc5577753c35502769ea058ce3288dcc5fccf31743d619f533d94a1362754b6b15c4d1b2f822a1539a2a6332acc29fd10f90cc9ff38f61da29137ba9eb6930c1f6ea65f632c964da4ba63ccf65d2a4a912592d9944f3fc605d0a5c1aeb1127fb9787e589f26c5d1f1338f78b6ad5062367e702b3449d48b4f514c781fd4296062a6ebb4a642f8ace2b299633a3beb1ba8f3cf872e9fe3b7ff8c2b9ffe35bfbf923e731c186ecc23971fed311126dad3aa26c2467d559a90ac9865d7ddad4810afed2d6abe9a83078ed128e9668322a36ee081c1816a751bc71292fde685afab00bc4582f293800d8c856ce99357745743860d7c5eb7a11742b48a007e9c4c39df05cc18b3a953aa51237ca1415c9fce9a654ea18838988bb09779f1db6662a57f30964656acd67602cee23fb50c0b025cbfac3975695325b9e950dddb060f30db5cba87a97b17a74b3468398a20176d2bb350144a12a235d3b1891831151020af3709bc25bf24ea5735eb3176b07261470d0c058ca238aedb0efc1ab3d0092354062bc341f439994d78c46add74fb61caa7e42af744d146b6f3d0e1875c0a8fa721f253b46549e63875538765871e31517d6c8f3923093df0d5db2c0bc9e8779324cf61736ca21302d6d127f31a1c573f4e531c65008a391c4479026b2efaa17bbc8ff2bfa7ad580f9588b598c07baaaf46de26c9daf0ec6b85f618c18ccccca508c01cfc6a16abb4335439d1b0db029978b180fae112f140c53ffef1daaf1bee01831a819957a180fa6ed56cd768d68bafa360240d32aca300638dbf55e60702833d902ecb2a8029d11b43d9fda25138a6f5e2e5def29c6b35e04f2ca9b545a4066418566cd04061bb2019b5bb38d9ca962e50516abfab60617d5ca0c427e791b39d3f652a398b61bb098926d1499ca6a3c701929e9096137d95ca423d21a0ee9e78b388a34936aa6c55dbd98848477de8a663d969a139deb4bec591989c6521126aee67b949c142f3d0cb8d74a11e635212888dbd702105d75814428b57a077b52dda16bc590e145d34bc586ae1a425811a52a057b518fa1ab760c27969e8a2c98eb8565f0d428a2407f598f7738eb283be550fcba81a9bfdc9298629a119c137b9bbacd7db488ab3d56ab475513eacb69043cbcf1b94a90bf0073846fcf619afad1d2757e07c13a3b9f103e41ef3e7a5ca3d51ae121c3f0292052e7645b3511ffbc5204d9e7e9e32afb95da1802eea69f1d0c798cdeaefdc0abfb7dc7383ac12191ed01cb5352d95ca2ecb4d4725353fa10478a844af1d55bd7cf305c059858fa18cdc00f68d2b72f29fc0d2ec17c53e547e013914f0429f6e98d0ff02e314c4b1adbe7f14facc35ef8f2cb9fb29d1556cfb70000, '6.2.0-61023');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `formlars`
--
ALTER TABLE `formlars`
  ADD PRIMARY KEY (`FormID`);

--
-- Indexes for table `fotografgaleris`
--
ALTER TABLE `fotografgaleris`
  ADD PRIMARY KEY (`GorselID`);

--
-- Indexes for table `kullanicis`
--
ALTER TABLE `kullanicis`
  ADD PRIMARY KEY (`KullaniciID`),
  ADD KEY `IX_KullaniciYetkiID` (`KullaniciYetkiID`) USING HASH;

--
-- Indexes for table `kullaniciyetkis`
--
ALTER TABLE `kullaniciyetkis`
  ADD PRIMARY KEY (`KullaniciYetkiID`);

--
-- Indexes for table `sayfaalticeriks`
--
ALTER TABLE `sayfaalticeriks`
  ADD PRIMARY KEY (`SayfaAltIcerikID`),
  ADD KEY `IX_SayfaIcerikID` (`SayfaIcerikID`) USING HASH,
  ADD KEY `IX_SayfaID` (`SayfaID`) USING HASH;

--
-- Indexes for table `sayfaicerikgaleris`
--
ALTER TABLE `sayfaicerikgaleris`
  ADD PRIMARY KEY (`SayfaIcerikGorselID`),
  ADD KEY `IX_SayfaIcerikID` (`SayfaIcerikID`) USING HASH,
  ADD KEY `IX_SayfaID` (`SayfaID`) USING HASH;

--
-- Indexes for table `sayfaiceriks`
--
ALTER TABLE `sayfaiceriks`
  ADD PRIMARY KEY (`SayfaIcerikID`),
  ADD KEY `IX_SayfaID` (`SayfaID`) USING HASH;

--
-- Indexes for table `sayfaicerikyorums`
--
ALTER TABLE `sayfaicerikyorums`
  ADD PRIMARY KEY (`SayfaIcerikYorumID`),
  ADD KEY `IX_SayfaIcerikID` (`SayfaIcerikID`) USING HASH,
  ADD KEY `IX_SayfaID` (`SayfaID`) USING HASH;

--
-- Indexes for table `sayfalars`
--
ALTER TABLE `sayfalars`
  ADD PRIMARY KEY (`SayfaID`);

--
-- Indexes for table `__migrationhistory`
--
ALTER TABLE `__migrationhistory`
  ADD PRIMARY KEY (`MigrationId`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `formlars`
--
ALTER TABLE `formlars`
  MODIFY `FormID` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `fotografgaleris`
--
ALTER TABLE `fotografgaleris`
  MODIFY `GorselID` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `kullanicis`
--
ALTER TABLE `kullanicis`
  MODIFY `KullaniciID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT for table `kullaniciyetkis`
--
ALTER TABLE `kullaniciyetkis`
  MODIFY `KullaniciYetkiID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT for table `sayfaalticeriks`
--
ALTER TABLE `sayfaalticeriks`
  MODIFY `SayfaAltIcerikID` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `sayfaicerikgaleris`
--
ALTER TABLE `sayfaicerikgaleris`
  MODIFY `SayfaIcerikGorselID` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `sayfaiceriks`
--
ALTER TABLE `sayfaiceriks`
  MODIFY `SayfaIcerikID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT for table `sayfaicerikyorums`
--
ALTER TABLE `sayfaicerikyorums`
  MODIFY `SayfaIcerikYorumID` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `sayfalars`
--
ALTER TABLE `sayfalars`
  MODIFY `SayfaID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `kullanicis`
--
ALTER TABLE `kullanicis`
  ADD CONSTRAINT `FK_Kullanicis_KullaniciYetkis_KullaniciYetkiID` FOREIGN KEY (`KullaniciYetkiID`) REFERENCES `kullaniciyetkis` (`KullaniciYetkiID`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `sayfaalticeriks`
--
ALTER TABLE `sayfaalticeriks`
  ADD CONSTRAINT `FK_SayfaAltIceriks_SayfaIceriks_SayfaIcerikID` FOREIGN KEY (`SayfaIcerikID`) REFERENCES `sayfaiceriks` (`SayfaIcerikID`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `FK_SayfaAltIceriks_Sayfalars_SayfaID` FOREIGN KEY (`SayfaID`) REFERENCES `sayfalars` (`SayfaID`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `sayfaicerikgaleris`
--
ALTER TABLE `sayfaicerikgaleris`
  ADD CONSTRAINT `FK_SayfaIcerikGaleris_SayfaIceriks_SayfaIcerikID` FOREIGN KEY (`SayfaIcerikID`) REFERENCES `sayfaiceriks` (`SayfaIcerikID`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `FK_SayfaIcerikGaleris_Sayfalars_SayfaID` FOREIGN KEY (`SayfaID`) REFERENCES `sayfalars` (`SayfaID`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `sayfaiceriks`
--
ALTER TABLE `sayfaiceriks`
  ADD CONSTRAINT `FK_SayfaIceriks_Sayfalars_SayfaID` FOREIGN KEY (`SayfaID`) REFERENCES `sayfalars` (`SayfaID`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `sayfaicerikyorums`
--
ALTER TABLE `sayfaicerikyorums`
  ADD CONSTRAINT `FK_SayfaIcerikYorums_SayfaIceriks_SayfaIcerikID` FOREIGN KEY (`SayfaIcerikID`) REFERENCES `sayfaiceriks` (`SayfaIcerikID`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `FK_SayfaIcerikYorums_Sayfalars_SayfaID` FOREIGN KEY (`SayfaID`) REFERENCES `sayfalars` (`SayfaID`) ON DELETE CASCADE ON UPDATE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
