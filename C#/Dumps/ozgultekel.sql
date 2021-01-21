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
-- Database: `ozgultekel`
--

-- --------------------------------------------------------

--
-- Table structure for table `kullanicis`
--

CREATE TABLE `kullanicis` (
  `KullaniciID` int(11) NOT NULL,
  `Yetki` longtext,
  `KullaniciAdi` longtext,
  `Sifre` longtext
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Table structure for table `satis`
--

CREATE TABLE `satis` (
  `SatisID` int(11) NOT NULL,
  `Barkod` longtext,
  `UrunAdi` longtext,
  `Adet` int(11) NOT NULL,
  `BirimFiyat` decimal(18,2) NOT NULL,
  `Tutar` decimal(18,2) NOT NULL,
  `OdemeYontemi` longtext,
  `SatisTarihi` datetime NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `satis`
--

INSERT INTO `satis` (`SatisID`, `Barkod`, `UrunAdi`, `Adet`, `BirimFiyat`, `Tutar`, `OdemeYontemi`, `SatisTarihi`) VALUES
(1, '101000', 'Chester', 2, '10.00', '20.00', 'Nakit', '2018-11-01 21:57:49'),
(2, '15422', 'Marlboro', 3, '12.00', '36.00', 'Nakit', '2018-11-01 21:57:49'),
(3, '101000', 'Chester', 3, '10.00', '30.00', 'Nakit', '2018-11-01 22:00:26'),
(4, '15422', 'Marlboro', 1, '12.00', '12.00', 'Pos', '2018-11-01 22:02:52'),
(5, '15422', 'Marlboro', 1, '12.00', '12.00', 'Veresiye', '2018-11-01 22:03:21');

-- --------------------------------------------------------

--
-- Table structure for table `uruns`
--

CREATE TABLE `uruns` (
  `UrunID` int(11) NOT NULL,
  `Barkod` longtext,
  `UrunAdi` longtext,
  `Adet` int(11) NOT NULL,
  `BirimFiyat` decimal(18,2) NOT NULL,
  `KayitTarihi` datetime NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `uruns`
--

INSERT INTO `uruns` (`UrunID`, `Barkod`, `UrunAdi`, `Adet`, `BirimFiyat`, `KayitTarihi`) VALUES
(1, '101000', 'Chester', 10, '10.00', '2018-11-01 17:18:55'),
(2, '15422', 'Marlboro', 45, '12.00', '2018-11-01 17:22:06'),
(3, '86935449', 'Monte', 80, '9.50', '2018-11-01 23:06:00'),
(4, '4902778653173', 'Tuborg', 10, '10.00', '2018-11-01 23:11:32'),
(5, '8681363827231', '70 Jack', 5, '150.00', '2018-11-01 23:12:02'),
(6, '86935401', 'Chester Kısa', 50, '9.50', '2018-11-10 18:19:41');

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
('201811011418410_InitialCreate', 'OzgulTekel.VeriErisimKatmani.DatabaseContext', 0x1f8b0800000000000400ed5adb6edb38107d5fa0ff20e839b57241816e20b748ed6411a48e83ca29d0475a1a3b44284a4b5281bdbfb60ffb49fb0b3bd4fd665bf6daa951047991879cc399e1197238c8bf7fff637f5ef8cc78012169c0fbe659efd43480bb8147f9bc6f466af6fea3f9f9d3bbdfec6bcf5f18dfb379177a1e6a72d9379f940a2f2d4bba4fe013d9f3a92b0219cc54cf0d7c8b7881757e7afabb757666014298886518f6b7882bea43fc037f0e02ee42a822c24681074ca6721c716254e39ef82043e242df1cff358fd8049e81f5d01c7a2da8a4fe1d513ee1d434ae18256893036c661a84f3401185165f3e4a709408f8dc095140d8641902ce9b112621f5e4b298ded5a9d373ed94552866506e2455e06f0978769146c9aaabef146b338f22c6f11ae3ad96daeb38967df32e620c23e662cceaab5d0e98d033abb12682d1e734cebd5cfbc45835e724670b924aff9d188388a948409f43a4046127c6433465d4bd83e5247806dee7885ab61aedc6b18a00450f220841a8e53798d57db91d9a865505b0ea08b97e9b72e2f62d5717e7a671af47a60c729a9442e4a840c01fc0411005de03510a04eef2ad0771a01b66d416fd01ea9966cb213131db4c6344165f81cfd553dfc44fd3b8a10bf032496ac2235a8a29d237958860d32ab96b57dee11773e84cc09e57b1ad82b76bd9ece0aec89d981c6b1e058b634b766170aef85aecfd42c473e01d9c518f22e2afc1dc2b0fd4a6e06d080815d4bfa14b92e30cc1a53e61a6f120f02bbd5c3f9a86e3128dbafd129348117130f4b1073efc08b802ff154e0acdd70911f4295f6b883c9c6041b0c1f0cee781a6ce4ec781563c8ad3401bb2cb6190e9bd9d05bfee59704796541d2081b00c57842213d27510944c89042d87856a49282cabd39c92697cab8627b80ea866d559189294ebbdd298b51e25bded1b08a97c83767236349413715bb0f2b014cf122b799764ef176bc503c61e913044a2961e34a9c47092d7cce0bdb37d71ef2718962b5b6afcdcda7c254c703287da282e8d96de502155b6cda631f0fcc6b43a095604375badbecff593ae887ba6a1bfd35b68cdd3aeb712b208ea0dfae9e3b115bb0cb9696bcc89b5751e12b1ee59300858e4f38d8f8d757869c55f464a45dd31aaf57cab51f14877c4b4682f43a5a226866dd5c25cdf5aabb1b7b5bbab4e964e544a927a6f346a85eb40a1157a2b039bd5e495d0b657f8eb70b2ebb50c93c9baa3e4b76719261776c7496ec7324822d9c29fd2ed58f1a924ef8e9616c565a054d41da35afa96a1aa235b2455b9be6dec7f36703409165f7c7bcbaf36b40ee9d5aeb68ecff5e46a2f98d7a1bce5d63ab44a9159b96bca03afcce24649569f92af9e9766b512cc4ecba1cd8de6467d944cd1657cf0423d5d1b8d96ce9faca7c77bf1e7805174b89831c28c988154c953d0fcd0fb50eb501f4fb7d892d2635d5bc647d0a3a53ace1bdfae5b3eac2a6d5916e033327ef61428bb765d77c5aa3455bb816cd933fd898dca836c61b51fb16bdc6bed865d61cadd84d8dbffdd4bf00eda57dc3b7a5b5f71e75c68b60d3de48c8abb1e25834ff7da44fc69adbbb7ec3882ec68e9b41d8073f5be5bb333b397ae5a52bfa007d3009d496ccd8737f7cd3674dddad0f7d0906b83d523b23dc01d7a75cd02d0b6caff8f600f41d27901a1ff3b8183ab2bab02349b73cb6741c619f4a86c5136a546a91128821c225742d11971150ebb2065dccefe4e588453aefd2978b77c1ca930525752823f659546bc6dad5f3f6e48566db6c7a1fe25f7e1029a49751a8cf99788322fb7fba685f82b2034c5d3730dad72943edfe6cb1ce93ee01d81d2f00d2104ae4fc509f821433039e60e79815d6c7b94f015e6c45d6665fc6a90cd1b510dbb3da4642e882f538c421f7f22873d7ff1e93fa823ac0c96230000, '6.2.0-61023');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `kullanicis`
--
ALTER TABLE `kullanicis`
  ADD PRIMARY KEY (`KullaniciID`);

--
-- Indexes for table `satis`
--
ALTER TABLE `satis`
  ADD PRIMARY KEY (`SatisID`);

--
-- Indexes for table `uruns`
--
ALTER TABLE `uruns`
  ADD PRIMARY KEY (`UrunID`);

--
-- Indexes for table `__migrationhistory`
--
ALTER TABLE `__migrationhistory`
  ADD PRIMARY KEY (`MigrationId`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `kullanicis`
--
ALTER TABLE `kullanicis`
  MODIFY `KullaniciID` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `satis`
--
ALTER TABLE `satis`
  MODIFY `SatisID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT for table `uruns`
--
ALTER TABLE `uruns`
  MODIFY `UrunID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
