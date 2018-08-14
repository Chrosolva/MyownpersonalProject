-- phpMyAdmin SQL Dump
-- version 4.7.4
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Aug 14, 2018 at 09:45 PM
-- Server version: 10.1.29-MariaDB
-- PHP Version: 7.0.26

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `material_management`
--

-- --------------------------------------------------------

--
-- Table structure for table `bahan`
--

CREATE TABLE `bahan` (
  `ID_Bahan` int(8) NOT NULL,
  `Nama_Bahan` varchar(30) DEFAULT NULL,
  `Grade` varchar(1) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `bahan`
--

INSERT INTO `bahan` (`ID_Bahan`, `Nama_Bahan`, `Grade`) VALUES
(75511000, 'Tembakau 1', 'A'),
(75511001, 'Tembakau 1', 'B'),
(75511002, 'Tembakau 1', 'C'),
(75511003, 'Tembakau 2', 'A'),
(75511004, 'Tembakau 2', 'B'),
(75511005, 'Tembakau 2', 'C'),
(75511006, 'Tembakau 3', 'A'),
(75511007, 'Tembakau 3', 'B'),
(75511008, 'Tembakau 3', 'C'),
(75511009, 'Tembakau 4', 'A');

-- --------------------------------------------------------

--
-- Table structure for table `rak`
--

CREATE TABLE `rak` (
  `ID_Rak` varchar(4) NOT NULL,
  `ID_Bahan` int(8) NOT NULL DEFAULT '0',
  `Tanggal_Masuk` date NOT NULL DEFAULT '2001-01-01'
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `rak`
--

INSERT INTO `rak` (`ID_Rak`, `ID_Bahan`, `Tanggal_Masuk`) VALUES
('LA1', 75511000, '2018-05-14'),
('LA2', 75511000, '2018-05-14'),
('LA3', 75511000, '2018-05-14'),
('LA4', 75511000, '2018-05-14'),
('LA5', 75511000, '2018-05-14'),
('LB1', 75511000, '2018-05-14'),
('LB2', 75511000, '2018-05-14'),
('LB3', 75511000, '2018-05-14'),
('LB4', 75511000, '2018-05-14'),
('LB5', 75511000, '2018-05-14'),
('LC1', 75511000, '2018-05-14'),
('LC2', 75511000, '2018-05-14'),
('LC3', 75511000, '2018-05-14'),
('LC4', 75511000, '2018-05-14'),
('LC5', 75511000, '2018-05-14'),
('LD1', 75511000, '2018-05-14'),
('LD2', 75511000, '2018-05-14'),
('LD3', 0, '2000-01-01'),
('LD4', 0, '2000-01-01'),
('LD5', 0, '2000-01-01'),
('LE1', 0, '2000-01-01'),
('LE2', 0, '2000-01-01'),
('LE3', 0, '2000-01-01'),
('LE4', 0, '2000-01-01'),
('LE5', 0, '2000-01-01'),
('LF1', 0, '2000-01-01'),
('LF2', 0, '2000-01-01'),
('LF3', 0, '2000-01-01'),
('LF4', 0, '2000-01-01'),
('LF5', 0, '2000-01-01'),
('LG1', 0, '2000-01-01'),
('LG2', 0, '2000-01-01'),
('LG3', 0, '2000-01-01'),
('LG4', 0, '2000-01-01'),
('LG5', 0, '2000-01-01'),
('LH1', 0, '2000-01-01'),
('LH2', 0, '2000-01-01'),
('LH3', 0, '2000-01-01'),
('LH4', 0, '2000-01-01'),
('LH5', 0, '2000-01-01'),
('LI1', 0, '2000-01-01'),
('LI2', 0, '2000-01-01'),
('LI3', 0, '2000-01-01'),
('LI4', 0, '2000-01-01'),
('LI5', 0, '2000-01-01'),
('LJ1', 0, '2000-01-01'),
('LJ2', 0, '2000-01-01'),
('LJ3', 0, '2000-01-01'),
('LJ4', 0, '2000-01-01'),
('LJ5', 0, '2000-01-01'),
('LK1', 0, '2000-01-01'),
('LK2', 0, '2000-01-01'),
('LK3', 0, '2000-01-01'),
('LK4', 0, '2000-01-01'),
('LK5', 0, '2000-01-01'),
('LL1', 0, '2000-01-01'),
('LL2', 0, '2000-01-01'),
('LL3', 0, '2000-01-01'),
('LL4', 0, '2000-01-01'),
('LL5', 0, '2000-01-01'),
('LM1', 0, '2000-01-01'),
('LM2', 0, '2000-01-01'),
('LM3', 0, '2000-01-01'),
('LM4', 0, '2000-01-01'),
('LM5', 0, '2000-01-01'),
('LN1', 0, '2000-01-01'),
('LN2', 0, '2000-01-01'),
('LN3', 0, '2000-01-01'),
('LN4', 0, '2000-01-01'),
('LN5', 0, '2000-01-01'),
('LO1', 0, '2000-01-01'),
('LO2', 0, '2000-01-01'),
('LO3', 0, '2000-01-01'),
('LO4', 0, '2000-01-01'),
('LO5', 0, '2000-01-01'),
('RA1', 75511000, '2018-05-14'),
('RA2', 75511000, '2018-05-14'),
('RA3', 75511000, '2018-05-14'),
('RA4', 75511000, '2018-05-14'),
('RA5', 75511000, '2018-05-14'),
('RB1', 75511000, '2018-05-14'),
('RB2', 75511000, '2018-05-14'),
('RB3', 75511000, '2018-05-14'),
('RB4', 75511000, '2018-05-14'),
('RB5', 75511000, '2018-05-14'),
('RC1', 75511000, '2018-05-14'),
('RC2', 75511000, '2018-05-14'),
('RC3', 75511000, '2018-05-14'),
('RC4', 75511000, '2018-05-14'),
('RC5', 75511000, '2018-05-14'),
('RD1', 75511000, '2018-05-14'),
('RD2', 0, '2000-01-01'),
('RD3', 0, '2000-01-01'),
('RD4', 0, '2000-01-01'),
('RD5', 0, '2000-01-01'),
('RE1', 0, '2000-01-01'),
('RE2', 0, '2000-01-01'),
('RE3', 0, '2000-01-01'),
('RE4', 0, '2000-01-01'),
('RE5', 0, '2000-01-01'),
('RF1', 0, '2000-01-01'),
('RF2', 0, '2000-01-01'),
('RF3', 0, '2000-01-01'),
('RF4', 0, '2000-01-01'),
('RF5', 0, '2000-01-01'),
('RG1', 0, '2000-01-01'),
('RG2', 0, '2000-01-01'),
('RG3', 0, '2000-01-01'),
('RG4', 0, '2000-01-01'),
('RG5', 0, '2000-01-01'),
('RH1', 0, '2000-01-01'),
('RH2', 0, '2000-01-01'),
('RH3', 0, '2000-01-01'),
('RH4', 0, '2000-01-01'),
('RH5', 0, '2000-01-01'),
('RI1', 0, '2000-01-01'),
('RI2', 0, '2000-01-01'),
('RI3', 0, '2000-01-01'),
('RI4', 0, '2000-01-01'),
('RI5', 0, '2000-01-01'),
('RJ1', 0, '2000-01-01'),
('RJ2', 0, '2000-01-01'),
('RJ3', 0, '2000-01-01'),
('RJ4', 0, '2000-01-01'),
('RJ5', 0, '2000-01-01'),
('RK1', 0, '2000-01-01'),
('RK2', 0, '2000-01-01'),
('RK3', 0, '2000-01-01'),
('RK4', 0, '2000-01-01'),
('RK5', 0, '2000-01-01'),
('RL1', 0, '2000-01-01'),
('RL2', 0, '2000-01-01'),
('RL3', 0, '2000-01-01'),
('RL4', 0, '2000-01-01'),
('RL5', 0, '2000-01-01'),
('RM1', 0, '2000-01-01'),
('RM2', 0, '2000-01-01'),
('RM3', 0, '2000-01-01'),
('RM4', 0, '2000-01-01'),
('RM5', 0, '2000-01-01'),
('RN1', 0, '2000-01-01'),
('RN2', 0, '2000-01-01'),
('RN3', 0, '2000-01-01'),
('RN4', 0, '2000-01-01'),
('RN5', 0, '2000-01-01'),
('RO1', 0, '2000-01-01'),
('RO2', 0, '2000-01-01'),
('RO3', 0, '2000-01-01'),
('RO4', 0, '2000-01-01'),
('RO5', 0, '2000-01-01');

-- --------------------------------------------------------

--
-- Table structure for table `resep`
--

CREATE TABLE `resep` (
  `ID_Rokok` int(11) NOT NULL,
  `ID_Bahan` int(11) NOT NULL,
  `nama_resep` varchar(40) NOT NULL,
  `Nama_Bahan` varchar(30) DEFAULT NULL,
  `Nama_Rokok` varchar(30) DEFAULT NULL,
  `Grade` varchar(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `resep`
--

INSERT INTO `resep` (`ID_Rokok`, `ID_Bahan`, `nama_resep`, `Nama_Bahan`, `Nama_Rokok`, `Grade`) VALUES
(45510000, 75511000, 'Resep Rokok Surya', 'Tembakau 1', 'Surya', 'A'),
(45510000, 75511001, 'Resep Rokok Surya', 'Tembakau 1', 'Surya', 'B'),
(45510000, 75511003, 'Resep Rokok Surya', 'Tembakau 2', 'Surya', 'A'),
(45510000, 75511005, 'Resep Rokok Surya', 'Tembakau 2', 'Surya', 'C'),
(45510000, 75511006, 'Resep Rokok Surya', 'Tembakau 3', 'Surya', 'A'),
(45510001, 75511001, 'Resep Rokok Marcopollo', 'Tembakau 1', 'Marcopollo', 'B'),
(45510001, 75511002, 'Resep Rokok Marcopollo', 'Tembakau 1', 'Marcopollo', 'C'),
(45510001, 75511004, 'Resep Rokok Marcopollo', 'Tembakau 2', 'Marcopollo', 'B'),
(45510001, 75511005, 'Resep Rokok Marcopollo', 'Tembakau 2', 'Marcopollo', 'C'),
(45510001, 75511007, 'Resep Rokok Marcopollo', 'Tembakau 3', 'Marcopollo', 'B'),
(45510001, 75511008, 'Resep Rokok Marcopollo', 'Tembakau 3', 'Marcopollo', 'C'),
(45510002, 75511000, 'Resep Rokok Gudang Garam', 'Tembakau 1', 'Gudang Garam', 'A'),
(45510002, 75511001, 'Resep Rokok Gudang Garam', 'Tembakau 1', 'Gudang Garam', 'B'),
(45510002, 75511002, 'Resep Rokok Gudang Garam', 'Tembakau 1', 'Gudang Garam', 'C'),
(45510002, 75511003, 'Resep Rokok Gudang Garam', 'Tembakau 2', 'Gudang Garam', 'A'),
(45510002, 75511004, 'Resep Rokok Gudang Garam', 'Tembakau 2', 'Gudang Garam', 'B'),
(45510003, 75511000, 'Resep Rokok Magnum', 'Tembakau 1', 'Magnum', 'A'),
(45510003, 75511001, 'Resep Rokok Magnum', 'Tembakau 1', 'Magnum', 'B'),
(45510003, 75511002, 'Resep Rokok Magnum', 'Tembakau 1', 'Magnum', 'C'),
(45510003, 75511003, 'Resep Rokok Magnum', 'Tembakau 2', 'Magnum', 'A'),
(45510003, 75511004, 'Resep Rokok Magnum', 'Tembakau 2', 'Magnum', 'B'),
(45510004, 75511001, 'Resep Rokok Marlboro', 'Tembakau 1', 'Marlboro', 'B'),
(45510004, 75511002, 'Resep Rokok Marlboro', 'Tembakau 1', 'Marlboro', 'C'),
(45510004, 75511003, 'Resep Rokok Marlboro', 'Tembakau 2', 'Marlboro', 'A'),
(45510004, 75511005, 'Resep Rokok Marlboro', 'Tembakau 2', 'Marlboro', 'C'),
(45510004, 75511006, 'Resep Rokok Marlboro', 'Tembakau 3', 'Marlboro', 'A');

-- --------------------------------------------------------

--
-- Table structure for table `rokok`
--

CREATE TABLE `rokok` (
  `ID_Rokok` int(5) NOT NULL,
  `Nama_Rokok` varchar(30) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `rokok`
--

INSERT INTO `rokok` (`ID_Rokok`, `Nama_Rokok`) VALUES
(45510000, 'Surya'),
(45510001, 'Marcopollo'),
(45510002, 'Gudang Garam'),
(45510003, 'Magnum'),
(45510004, 'Marlboro');

-- --------------------------------------------------------

--
-- Table structure for table `user`
--

CREATE TABLE `user` (
  `Id_User` int(11) NOT NULL,
  `Username` varchar(20) NOT NULL,
  `Password` varchar(32) NOT NULL,
  `Address` varchar(50) NOT NULL,
  `Role` tinyint(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `user`
--

INSERT INTO `user` (`Id_User`, `Username`, `Password`, `Address`, `Role`) VALUES
(1, 'Gunawan', '1234', 'Jalan Ahmad Yani no 222 Pematangsiantar', 0),
(2, 'Stephen', '4321', 'well well', 1);

--
-- Indexes for dumped tables
--

--
-- Indexes for table `bahan`
--
ALTER TABLE `bahan`
  ADD PRIMARY KEY (`ID_Bahan`);

--
-- Indexes for table `rak`
--
ALTER TABLE `rak`
  ADD PRIMARY KEY (`ID_Rak`);

--
-- Indexes for table `resep`
--
ALTER TABLE `resep`
  ADD PRIMARY KEY (`ID_Rokok`,`ID_Bahan`);

--
-- Indexes for table `rokok`
--
ALTER TABLE `rokok`
  ADD PRIMARY KEY (`ID_Rokok`);

--
-- Indexes for table `user`
--
ALTER TABLE `user`
  ADD PRIMARY KEY (`Id_User`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `bahan`
--
ALTER TABLE `bahan`
  MODIFY `ID_Bahan` int(8) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=75511010;

--
-- AUTO_INCREMENT for table `rokok`
--
ALTER TABLE `rokok`
  MODIFY `ID_Rokok` int(5) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=45510005;

--
-- AUTO_INCREMENT for table `user`
--
ALTER TABLE `user`
  MODIFY `Id_User` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
