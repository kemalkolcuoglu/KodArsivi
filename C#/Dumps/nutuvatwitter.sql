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
-- Database: `nutuvatwitter`
--

-- --------------------------------------------------------

--
-- Table structure for table `gorsellers`
--

CREATE TABLE `gorsellers` (
  `GorselID` int(11) NOT NULL,
  `GorselAdres` longtext
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Table structure for table `tweets`
--

CREATE TABLE `tweets` (
  `TweetID` int(11) NOT NULL,
  `ProfilResmi` longtext,
  `Nickname` longtext,
  `KullaniciAdi` longtext,
  `TweetDetay` longtext,
  `EkGorsel` longtext
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `tweets`
--

INSERT INTO `tweets` (`TweetID`, `ProfilResmi`, `Nickname`, `KullaniciAdi`, `TweetDetay`, `EkGorsel`) VALUES
(1, NULL, 'KemalKolcuoglu', 'Kemal Kolcuoğlu', 'Deneme Tweet', NULL);

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
('201810020048300_InitialCreate', 'NutuvaTwitter.Islemler.DatabaseContext', 0x1f8b0800000000000400cd58db6ee336107d2fd07f10f89c1573c1026d20efc2b59385b1eb2488bcfb4e4b63870845a92295b5bfad0ffda4fe4287badf7cad93147eb149ce999933e45cfccf5f7f3b9f5781b05e20563c940372619f130ba417fa5c2e0724d18b0fbf91cf9f7efdc5b9f18395f5a3387765cea1a45403f2a475744da9f29e2060ca0eb817872a5c68db0b03cafc905e9e9fff4e2f2e282004412ccb721e13a97900e90ffc390aa507914e9898863e0895afe38e9ba25a772c0015310f06e42ed1c90b9bfde45a436c4f948040404caca1e00cad71412c88c5a40c35d368ebf57705ae8e43b974235c6062b68e00cf2d985090fb705d1ddfd79df34be30ead040b282f513a0c0e04bcb8caf9a16df1a35826257fc8e00d32add7c6eb94c501f912c60a44ca595bdbf548c4e6649be52c2a7629796635f6cfca8b81f7c77cceac51227412c34042a26326ceac87642eb8f715d6b3f019e4402642d4cd444371afb1804b0f711841acd78fb068183f19138b36a5695bbc14ee48661e4ea4beba24e888106c2ea0bc1135365c1dc6f00524c44c83ffc08caf18d0890f29a71d1b7a350efd1854a1146f223e2c624dd9ea1bc8a57e1a10fc4aac5bbe02bf58c90df92e39be4314d271024d5d0eada2ba35d6b39f00fae038a752ef17e354fd31212e05df2ac2f873c1c523a8809f38c25d5d77dc7b96f8edd5157d357ca1001ffaafef551ab23168b67e755537cfd9837cd3b788954d338ef72b3762cc349b3305661d567d4f13eb55fe3a55aeaee95586eb82eea6f3ca90ac0edab53dba1d258d433f489e43fa7c2ebdab0a36cd2a7651d9e986d2ee4c591421fdb5529faf586e56e7471fdcc38b5f9061504ff5d4c0d2da5213be7eb684d62eaa464b6f79ac74112d628dfca073ac1dcb0d0c17dadae16a27c28af842c27ccf1f7f6fd3636f04abe8bc450f03cc66a9b3501ab5c59054daf59860f1c6123a0a4512c8ed257937525e1abb60f94617cfa12db7da24d20e8bad1ad20ecb5e412b5fc70962963da7c3e3b5416e13c3652dacb3bba1b26ec36994b83a5663637fbcaa8cd5c1aad5fd919a75aa8ed6dcd91fb15e8c3ab4e5ebfba355f5a68e55adbef1edeee4ecf691527b99bb5b39dac9f3e5ee19ad9340b323c4428a5eb86f92e774edfe296cb36fa75f4782a3c3d589290670014a67ad24f9687f6c8d78ff9f718b2ae58b7d67ae779d79b8617867cfdb69980f1e73048edb597b5361fde729e61d278957e1ad6778d88fb7ddb3c1b1387dadffb158ddcefe58a476e37e8adbd5eecbbb2ddf49baee2cef0d883f0fd1faccd472bbd3e1f477e59b5bf23ef4744b1dddae7753bc43eb7fd63963507c594198bfee2478267756a0c599895c84452cd1a9ba45c59156a8a7785f7c8cc030d67cc13c8ddb1e2895ce693f9848cc6d08e6e04fe47da2a3440f9582602e1a75d9a1dbf5a73349d366e73e32bfd4295c403339ba00f7f28f840bbfb4fbb69b13364198cb98271ab40ae754845bae4ba4bb50ee0994d3378608a449533308228160ea5ebaec058eb10dc7d36fb064deba28d49b417607a249bb33e66c19b340e51895bcf9039a9a7fa03ffd0bf63a7f27b3160000, '6.2.0-61023');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `gorsellers`
--
ALTER TABLE `gorsellers`
  ADD PRIMARY KEY (`GorselID`);

--
-- Indexes for table `tweets`
--
ALTER TABLE `tweets`
  ADD PRIMARY KEY (`TweetID`);

--
-- Indexes for table `__migrationhistory`
--
ALTER TABLE `__migrationhistory`
  ADD PRIMARY KEY (`MigrationId`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `gorsellers`
--
ALTER TABLE `gorsellers`
  MODIFY `GorselID` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `tweets`
--
ALTER TABLE `tweets`
  MODIFY `TweetID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
