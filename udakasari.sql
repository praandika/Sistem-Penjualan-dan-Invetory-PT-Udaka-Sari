-- phpMyAdmin SQL Dump
-- version 4.8.5
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Jul 05, 2019 at 02:33 AM
-- Server version: 10.1.40-MariaDB
-- PHP Version: 7.3.5

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `udakasari`
--

-- --------------------------------------------------------

--
-- Table structure for table `barang`
--

CREATE TABLE `barang` (
  `ID_BARANG` varchar(10) NOT NULL,
  `NAMA_BARANG` varchar(150) DEFAULT NULL,
  `JENIS_BARANG` varchar(30) DEFAULT NULL,
  `HARGA_BELI` int(11) DEFAULT NULL,
  `HARGA_JUAL` int(11) DEFAULT NULL,
  `STOK_BARANG` int(11) DEFAULT NULL,
  `STOK_MIN` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `barang`
--

INSERT INTO `barang` (`ID_BARANG`, `NAMA_BARANG`, `JENIS_BARANG`, `HARGA_BELI`, `HARGA_JUAL`, `STOK_BARANG`, `STOK_MIN`) VALUES
('BRG0001', 'Jw Red Label', 'Whiskey', 282000, 350000, 165, 10),
('BRG0002', 'Jw Black Label', 'Whiskey', 457000, 525000, 103, 10),
('BRG0003', 'Tequila Jose', 'Tequila', 282000, 350000, 9, 10),
('BRG0004', 'Absolut Vodka', 'Vodka', 282000, 350000, 149, 10),
('BRG0005', 'Jack Daniels', 'Whiskey', 407000, 475000, 123, 10),
('BRG0006', 'Baileys', 'Liqueur', 382000, 450000, 120, 10),
('BRG0007', 'Smirnoff', 'Vodka', 182000, 250000, 147, 10),
('BRG0008', 'Saint Remy', 'Brandy', 282000, 350000, 165, 10),
('BRG0009', 'Gordon Dry Gin', 'Gin', 222000, 290000, 128, 10),
('BRG0010', 'Myers Rum', 'Rum', 257000, 325000, 166, 10),
('BRG0011', 'Bols Apricot Brandy', 'Brandy', 227000, 295000, 130, 10),
('BRG0012', 'Chivas Regal', 'Whiskey', 507000, 575000, 118, 10),
('BRG0013', 'Bacardi Light', 'Rum', 257000, 325000, 94, 10),
('BRG0014', 'Cabernet Sauvignon', 'Wine', 292000, 360000, 163, 10),
('BRG0015', 'Lindemans Cawara Shiraz Cabernet', 'Wine', 182000, 250000, 9, 10),
('BRG0016', 'Bir Bintang', 'Beer', 20000, 25000, 9, 10),
('BRG0017', 'Heneiken', 'Beer', 20000, 30000, 3, 15);

-- --------------------------------------------------------

--
-- Table structure for table `barang_detail`
--

CREATE TABLE `barang_detail` (
  `ID_BARANG` varchar(10) NOT NULL,
  `TANGGAL` date NOT NULL,
  `TANGGAL_WAKTU` datetime NOT NULL,
  `DESKRIPSI` varchar(100) NOT NULL,
  `QTY_IN` int(11) NOT NULL,
  `QTY_OUT` int(11) NOT NULL,
  `USERNAME` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `barang_detail`
--

INSERT INTO `barang_detail` (`ID_BARANG`, `TANGGAL`, `TANGGAL_WAKTU`, `DESKRIPSI`, `QTY_IN`, `QTY_OUT`, `USERNAME`) VALUES
('BRG0001', '2019-06-23', '2019-06-23 01:19:26', 'Pembelian barang dengan nota NOTA-BY.0001-190623', 12, 0, 'rebintang'),
('BRG0013', '2019-06-23', '2019-06-23 01:19:26', 'Pembelian barang dengan nota NOTA-BY.0002-190623', 48, 0, 'rebintang'),
('BRG0007', '2019-06-23', '2019-06-23 01:19:26', 'Pembelian barang dengan nota NOTA-BY.0002-190623', 12, 0, 'rebintang'),
('BRG0017', '2019-06-23', '2019-06-23 01:22:07', 'Pembelian barang dengan nota NOTA-BY.0004-190623', 15, 0, 'rebintang'),
('BRG0002', '2019-06-23', '2019-06-23 01:22:07', 'Pembelian barang dengan nota NOTA-BY.0004-190623', 10, 0, 'rebintang'),
('BRG0004', '2019-06-23', '2019-06-23 01:22:07', 'Pembelian barang dengan nota NOTA-BY.0006-190623', 12, 0, 'rebintang'),
('BRG0004', '2019-06-23', '2019-06-23 01:22:07', 'Pembelian barang dengan nota NOTA-BY.0007-190623', 12, 0, 'rebintang'),
('BRG0002', '2019-06-23', '2019-06-23 01:22:07', 'Pembelian barang dengan nota NOTA-BY.0007-190623', 4, 0, 'rebintang'),
('BRG0008', '2019-06-23', '2019-06-23 01:29:04', 'Pembelian barang dengan nota NOTA-BY.0009-190623', 20, 0, 'rebintang'),
('BRG0009', '2019-06-23', '2019-06-23 01:29:04', 'Pembelian barang dengan nota NOTA-BY.0010-190623', 7, 0, 'rebintang'),
('BRG0014', '2019-06-23', '2019-06-23 01:29:04', 'Pembelian barang dengan nota NOTA-BY.0010-190623', 40, 0, 'rebintang'),
('BRG0001', '2016-01-01', '2016-01-01 22:17:24', 'Penjualan barang dengan nota No.0001-190624', 0, 12, 'admin'),
('BRG0005', '2016-01-01', '2016-01-01 22:17:24', 'Penjualan barang dengan nota No.0001-190624', 0, 6, 'admin'),
('BRG0007', '2016-02-10', '2016-02-10 22:21:03', 'Penjualan barang dengan nota No.0003-190624', 0, 6, 'admin'),
('BRG0008', '2016-02-10', '2016-02-10 22:21:03', 'Penjualan barang dengan nota No.0003-190624', 0, 6, 'admin'),
('BRG0010', '2016-03-23', '2016-03-23 22:21:03', 'Penjualan barang dengan nota No.0005-190624', 0, 3, 'admin'),
('BRG0006', '2016-03-23', '2016-03-23 22:21:03', 'Penjualan barang dengan nota No.0005-190624', 0, 2, 'admin'),
('BRG0016', '2016-04-29', '2016-04-29 22:21:03', 'Penjualan barang dengan nota No.0007-190624', 0, 12, 'admin'),
('BRG0011', '2016-04-29', '2016-04-29 22:21:03', 'Penjualan barang dengan nota No.0007-190624', 0, 4, 'admin'),
('BRG0005', '2016-04-29', '2016-04-29 22:21:03', 'Penjualan barang dengan nota No.0007-190624', 0, 3, 'admin'),
('BRG0012', '2016-05-20', '2016-05-20 22:21:03', 'Penjualan barang dengan nota No.0010-190624', 0, 6, 'admin'),
('BRG0015', '2016-06-07', '2016-06-07 22:21:03', 'Penjualan barang dengan nota No.0011-190624', 0, 6, 'admin'),
('BRG0007', '2016-06-07', '2016-06-07 22:21:03', 'Penjualan barang dengan nota No.0011-190624', 0, 6, 'admin'),
('BRG0003', '2016-07-31', '2016-07-31 22:21:03', 'Penjualan barang dengan nota No.0013-190624', 0, 6, 'admin'),
('BRG0017', '2016-07-31', '2016-07-31 22:21:03', 'Penjualan barang dengan nota No.0013-190624', 0, 6, 'admin'),
('BRG0010', '2016-08-17', '2016-08-17 22:21:03', 'Penjualan barang dengan nota No.0015-190624', 0, 12, 'admin'),
('BRG0004', '2016-09-18', '2016-09-18 22:21:03', 'Penjualan barang dengan nota No.0016-190624', 0, 12, 'admin'),
('BRG0012', '2016-09-18', '2016-09-18 22:21:03', 'Penjualan barang dengan nota No.0016-190624', 0, 3, 'admin'),
('BRG0014', '2016-10-27', '2016-10-27 22:21:03', 'Penjualan barang dengan nota No.0018-190624', 0, 6, 'admin'),
('BRG0016', '2016-10-27', '2016-10-27 22:21:03', 'Penjualan barang dengan nota No.0018-190624', 0, 12, 'admin'),
('BRG0017', '2016-10-27', '2016-10-27 22:21:03', 'Penjualan barang dengan nota No.0018-190624', 0, 3, 'admin'),
('BRG0013', '2016-11-14', '2016-11-14 22:21:03', 'Penjualan barang dengan nota No.0021-190624', 0, 6, 'admin'),
('BRG0001', '2016-11-14', '2016-11-14 22:21:03', 'Penjualan barang dengan nota No.0021-190624', 0, 6, 'admin'),
('BRG0009', '2016-12-16', '2016-12-16 22:21:03', 'Penjualan barang dengan nota No.0023-190624', 0, 12, 'admin'),
('BRG0008', '2017-01-11', '2017-01-11 22:32:45', 'Penjualan barang dengan nota No.0024-190624', 0, 6, 'admin'),
('BRG0001', '2017-02-20', '2017-02-20 22:32:45', 'Penjualan barang dengan nota No.0025-190624', 0, 6, 'admin'),
('BRG0005', '2017-02-20', '2017-02-20 22:32:45', 'Penjualan barang dengan nota No.0025-190624', 0, 6, 'admin'),
('BRG0005', '2017-03-18', '2017-03-18 22:32:45', 'Penjualan barang dengan nota No.0027-190624', 0, 6, 'admin'),
('BRG0012', '2017-03-18', '2017-03-18 22:32:45', 'Penjualan barang dengan nota No.0027-190624', 0, 3, 'admin'),
('BRG0003', '2017-04-26', '2017-04-26 22:32:45', 'Penjualan barang dengan nota No.0029-190624', 0, 6, 'admin'),
('BRG0013', '2017-04-26', '2017-04-26 22:32:45', 'Penjualan barang dengan nota No.0029-190624', 0, 6, 'admin'),
('BRG0015', '2017-04-26', '2017-04-26 22:32:45', 'Penjualan barang dengan nota No.0029-190624', 0, 3, 'admin'),
('BRG0007', '2017-05-18', '2017-05-18 22:32:45', 'Penjualan barang dengan nota No.0032-190624', 0, 12, 'admin'),
('BRG0014', '2017-05-18', '2017-05-18 22:32:45', 'Penjualan barang dengan nota No.0032-190624', 0, 6, 'admin'),
('BRG0007', '2017-06-19', '2017-06-19 22:32:45', 'Penjualan barang dengan nota No.0034-190624', 0, 6, 'admin'),
('BRG0005', '2017-06-19', '2017-06-19 22:32:45', 'Penjualan barang dengan nota No.0034-190624', 0, 3, 'admin'),
('BRG0007', '2017-07-20', '2017-07-20 22:32:45', 'Penjualan barang dengan nota No.0036-190624', 0, 6, 'admin'),
('BRG0011', '2017-07-20', '2017-07-20 22:32:45', 'Penjualan barang dengan nota No.0036-190624', 0, 6, 'admin'),
('BRG0001', '2017-08-25', '2017-08-25 22:32:45', 'Penjualan barang dengan nota No.0038-190624', 0, 6, 'admin'),
('BRG0005', '2017-08-25', '2017-08-25 22:32:45', 'Penjualan barang dengan nota No.0038-190624', 0, 6, 'admin'),
('BRG0006', '2017-09-22', '2017-09-22 22:32:45', 'Penjualan barang dengan nota No.0040-190624', 0, 12, 'admin'),
('BRG0016', '2017-09-22', '2017-09-22 22:32:45', 'Penjualan barang dengan nota No.0040-190624', 0, 6, 'admin'),
('BRG0010', '2017-10-12', '2017-10-12 22:32:45', 'Penjualan barang dengan nota No.0042-190624', 0, 12, 'admin'),
('BRG0011', '2017-10-12', '2017-10-12 22:32:45', 'Penjualan barang dengan nota No.0042-190624', 0, 6, 'admin'),
('BRG0007', '2017-11-17', '2017-11-17 22:32:45', 'Penjualan barang dengan nota No.0044-190624', 0, 12, 'admin'),
('BRG0009', '2017-12-25', '2017-12-25 22:32:45', 'Penjualan barang dengan nota No.0045-190624', 0, 6, 'admin'),
('BRG0010', '2017-12-25', '2017-12-25 22:32:45', 'Penjualan barang dengan nota No.0045-190624', 0, 6, 'admin'),
('BRG0015', '2017-12-25', '2017-12-25 22:32:45', 'Penjualan barang dengan nota No.0045-190624', 0, 6, 'admin'),
('BRG0001', '2018-01-25', '2018-01-25 22:32:45', 'Penjualan barang dengan nota No.0048-190624', 0, 12, 'admin'),
('BRG0005', '2018-02-19', '2018-02-19 22:32:45', 'Penjualan barang dengan nota No.0049-190624', 0, 6, 'admin'),
('BRG0010', '2018-02-19', '2018-02-19 22:32:45', 'Penjualan barang dengan nota No.0049-190624', 0, 6, 'admin'),
('BRG0009', '2018-03-18', '2018-03-18 22:32:45', 'Penjualan barang dengan nota No.0051-190624', 0, 6, 'admin'),
('BRG0012', '2018-03-18', '2018-03-18 22:32:45', 'Penjualan barang dengan nota No.0051-190624', 0, 2, 'admin'),
('BRG0016', '2018-04-20', '2018-04-20 22:32:45', 'Penjualan barang dengan nota No.0053-190624', 0, 12, 'admin'),
('BRG0011', '2018-04-20', '2018-04-20 22:32:45', 'Penjualan barang dengan nota No.0053-190624', 0, 6, 'admin'),
('BRG0013', '2018-05-24', '2018-05-24 22:32:45', 'Penjualan barang dengan nota No.0055-190624', 0, 6, 'admin'),
('BRG0016', '2018-05-24', '2018-05-24 22:32:45', 'Penjualan barang dengan nota No.0055-190624', 0, 3, 'admin'),
('BRG0005', '2018-06-28', '2018-06-28 22:32:45', 'Penjualan barang dengan nota No.0057-190624', 0, 6, 'admin'),
('BRG0004', '2018-07-18', '2018-07-18 22:32:45', 'Penjualan barang dengan nota No.0058-190624', 0, 6, 'admin'),
('BRG0009', '2018-07-18', '2018-07-18 22:32:45', 'Penjualan barang dengan nota No.0058-190624', 0, 6, 'admin'),
('BRG0009', '2018-08-17', '2018-08-17 22:32:45', 'Penjualan barang dengan nota No.0060-190624', 0, 6, 'admin'),
('BRG0011', '2018-08-17', '2018-08-17 22:32:45', 'Penjualan barang dengan nota No.0060-190624', 0, 6, 'admin'),
('BRG0012', '2018-08-17', '2018-08-17 22:32:45', 'Penjualan barang dengan nota No.0060-190624', 0, 2, 'admin'),
('BRG0003', '2018-09-18', '2018-09-18 22:32:45', 'Penjualan barang dengan nota No.0063-190624', 0, 6, 'admin'),
('BRG0011', '2018-09-18', '2018-09-18 22:32:45', 'Penjualan barang dengan nota No.0063-190624', 0, 3, 'admin'),
('BRG0007', '2018-10-18', '2018-10-18 22:32:45', 'Penjualan barang dengan nota No.0065-190624', 0, 12, 'admin'),
('BRG0006', '2018-11-19', '2018-11-19 22:32:45', 'Penjualan barang dengan nota No.0066-190624', 0, 3, 'admin'),
('BRG0012', '2018-11-19', '2018-11-19 22:32:45', 'Penjualan barang dengan nota No.0066-190624', 0, 1, 'admin'),
('BRG0005', '2018-12-28', '2018-12-28 22:32:45', 'Penjualan barang dengan nota No.0068-190624', 0, 6, 'admin'),
('BRG0013', '2019-01-18', '2019-01-18 22:32:45', 'Penjualan barang dengan nota No.0069-190624', 0, 12, 'admin'),
('BRG0001', '2019-02-21', '2019-02-21 22:32:45', 'Penjualan barang dengan nota No.0070-190624', 0, 6, 'admin'),
('BRG0011', '2019-03-16', '2019-03-16 22:32:45', 'Penjualan barang dengan nota No.0071-190624', 0, 12, 'admin'),
('BRG0004', '2019-04-17', '2019-04-17 22:32:45', 'Penjualan barang dengan nota No.0072-190624', 0, 6, 'admin'),
('BRG0005', '2019-05-24', '2019-05-24 22:32:45', 'Penjualan barang dengan nota No.0073-190624', 0, 6, 'admin'),
('BRG0008', '2019-05-24', '2019-05-24 22:32:45', 'Penjualan barang dengan nota No.0073-190624', 0, 6, 'admin'),
('BRG0005', '2019-06-14', '2019-06-14 22:32:45', 'Penjualan barang dengan nota No.0075-190624', 0, 12, 'admin'),
('BRG0006', '2019-07-26', '2019-07-26 22:32:45', 'Penjualan barang dengan nota No.0076-190624', 0, 6, 'admin'),
('BRG0008', '2019-08-05', '2019-08-05 22:32:45', 'Penjualan barang dengan nota No.0077-190624', 0, 6, 'admin'),
('BRG0007', '2019-08-05', '2019-08-05 22:32:45', 'Penjualan barang dengan nota No.0077-190624', 0, 6, 'admin'),
('BRG0001', '2019-09-19', '2019-09-19 22:32:45', 'Penjualan barang dengan nota No.0079-190624', 0, 6, 'admin'),
('BRG0007', '2019-10-23', '2019-10-23 22:32:45', 'Penjualan barang dengan nota No.0080-190624', 0, 6, 'admin'),
('BRG0012', '2019-10-23', '2019-10-23 22:32:45', 'Penjualan barang dengan nota No.0080-190624', 0, 6, 'admin'),
('BRG0011', '2019-11-03', '2019-11-03 22:32:45', 'Penjualan barang dengan nota No.0082-190624', 0, 6, 'admin'),
('BRG0016', '2019-11-03', '2019-11-03 22:32:45', 'Penjualan barang dengan nota No.0082-190624', 0, 6, 'admin'),
('BRG0006', '2019-12-31', '2019-12-31 22:32:45', 'Penjualan barang dengan nota No.0084-190624', 0, 6, 'admin'),
('BRG0005', '2019-12-31', '2019-12-31 22:32:45', 'Penjualan barang dengan nota No.0084-190624', 0, 3, 'admin'),
('BRG0008', '2019-06-24', '2019-06-24 23:00:39', 'Penjualan barang dengan nota No.0086-190624', 0, 12, 'admin'),
('BRG0009', '2019-06-24', '2019-06-24 23:03:50', 'Pembelian barang dengan nota NOTA-BY.0001-190624', 12, 0, 'admin'),
('BRG0001', '2016-01-13', '2016-01-13 23:03:50', 'Pembelian barang dengan nota NOTA-BY.0002-190624', 24, 0, 'admin'),
('BRG0001', '2016-01-13', '2016-01-13 23:10:38', 'Pembelian barang dengan nota NOTA-BY.0001-190624', 12, 0, 'admin'),
('BRG0008', '2016-01-13', '2016-01-13 23:10:38', 'Pembelian barang dengan nota NOTA-BY.0001-190624', 6, 0, 'admin'),
('BRG0007', '2016-02-10', '2016-02-10 23:10:38', 'Pembelian barang dengan nota NOTA-BY.0003-190624', 12, 0, 'admin'),
('BRG0009', '2016-02-10', '2016-02-10 23:10:38', 'Pembelian barang dengan nota NOTA-BY.0003-190624', 12, 0, 'admin'),
('BRG0011', '2016-03-24', '2016-03-24 23:10:38', 'Pembelian barang dengan nota NOTA-BY.0005-190624', 12, 0, 'admin'),
('BRG0012', '2016-03-24', '2016-03-24 23:10:38', 'Pembelian barang dengan nota NOTA-BY.0005-190624', 12, 0, 'admin'),
('BRG0010', '2016-04-13', '2016-04-13 23:10:38', 'Pembelian barang dengan nota NOTA-BY.0007-190624', 12, 0, 'admin'),
('BRG0014', '2016-05-18', '2016-05-18 23:10:38', 'Pembelian barang dengan nota NOTA-BY.0008-190624', 12, 0, 'admin'),
('BRG0008', '2016-05-18', '2016-05-18 23:10:38', 'Pembelian barang dengan nota NOTA-BY.0008-190624', 12, 0, 'admin'),
('BRG0007', '2016-06-16', '2016-06-16 23:10:38', 'Pembelian barang dengan nota NOTA-BY.0010-190624', 12, 0, 'admin'),
('BRG0009', '2016-06-16', '2016-06-16 23:10:38', 'Pembelian barang dengan nota NOTA-BY.0010-190624', 12, 0, 'admin'),
('BRG0005', '2016-07-21', '2016-07-21 23:10:38', 'Pembelian barang dengan nota NOTA-BY.0012-190624', 12, 0, 'admin'),
('BRG0010', '2016-08-25', '2016-08-25 23:10:38', 'Pembelian barang dengan nota NOTA-BY.0013-190624', 12, 0, 'admin'),
('BRG0014', '2016-08-25', '2016-08-25 23:10:38', 'Pembelian barang dengan nota NOTA-BY.0013-190624', 12, 0, 'admin'),
('BRG0008', '2016-09-30', '2016-09-30 23:10:38', 'Pembelian barang dengan nota NOTA-BY.0015-190624', 12, 0, 'admin'),
('BRG0001', '2016-09-30', '2016-09-30 23:10:38', 'Pembelian barang dengan nota NOTA-BY.0015-190624', 12, 0, 'admin'),
('BRG0006', '2016-09-30', '2016-09-30 23:10:38', 'Pembelian barang dengan nota NOTA-BY.0015-190624', 12, 0, 'admin'),
('BRG0011', '2016-10-13', '2016-10-13 23:10:38', 'Pembelian barang dengan nota NOTA-BY.0018-190624', 12, 0, 'admin'),
('BRG0005', '2016-11-18', '2016-11-18 23:10:38', 'Pembelian barang dengan nota NOTA-BY.0019-190624', 12, 0, 'admin'),
('BRG0002', '2016-11-18', '2016-11-18 23:10:38', 'Pembelian barang dengan nota NOTA-BY.0019-190624', 12, 0, 'admin'),
('BRG0004', '2016-12-12', '2016-12-12 23:10:38', 'Pembelian barang dengan nota NOTA-BY.0021-190624', 12, 0, 'admin'),
('BRG0001', '2019-06-24', '2019-06-24 23:17:56', 'Barang masuk dengan nota NOTA-BM.0001-190624', 12, 0, 'admin'),
('BRG0008', '2019-06-24', '2019-06-24 23:17:56', 'Barang masuk dengan nota NOTA-BM.0001-190624', 6, 0, 'admin'),
('BRG0007', '2019-06-24', '2019-06-24 23:17:56', 'Barang masuk dengan nota NOTA-BM.0003-190624', 12, 0, 'admin'),
('BRG0009', '2019-06-24', '2019-06-24 23:17:56', 'Barang masuk dengan nota NOTA-BM.0003-190624', 12, 0, 'admin'),
('BRG0011', '2019-06-24', '2019-06-24 23:17:56', 'Barang masuk dengan nota NOTA-BM.0005-190624', 12, 0, 'admin'),
('BRG0012', '2019-06-24', '2019-06-24 23:17:56', 'Barang masuk dengan nota NOTA-BM.0005-190624', 12, 0, 'admin'),
('BRG0010', '2019-06-24', '2019-06-24 23:17:56', 'Barang masuk dengan nota NOTA-BM.0007-190624', 12, 0, 'admin'),
('BRG0014', '2019-06-24', '2019-06-24 23:17:56', 'Barang masuk dengan nota NOTA-BM.0008-190624', 12, 0, 'admin'),
('BRG0008', '2019-06-24', '2019-06-24 23:17:56', 'Barang masuk dengan nota NOTA-BM.0008-190624', 12, 0, 'admin'),
('BRG0001', '2019-06-24', '2019-06-24 23:30:01', 'Barang masuk dengan nota NOTA-BM.0001-190624', 12, 0, 'admin'),
('BRG0008', '2019-06-24', '2019-06-24 23:30:01', 'Barang masuk dengan nota NOTA-BM.0001-190624', 6, 0, 'admin'),
('BRG0007', '2019-06-24', '2019-06-24 23:39:08', 'Barang masuk dengan nota NOTA-BM.0003-190624', 12, 0, 'admin'),
('BRG0009', '2019-06-24', '2019-06-24 23:39:08', 'Barang masuk dengan nota NOTA-BM.0003-190624', 12, 0, 'admin'),
('BRG0011', '2019-06-24', '2019-06-24 23:41:51', 'Barang masuk dengan nota NOTA-BM.0005-190624', 12, 0, 'admin'),
('BRG0012', '2019-06-24', '2019-06-24 23:41:51', 'Barang masuk dengan nota NOTA-BM.0005-190624', 12, 0, 'admin'),
('BRG0010', '2019-06-24', '2019-06-24 23:41:51', 'Barang masuk dengan nota NOTA-BM.0007-190624', 12, 0, 'admin'),
('BRG0014', '2019-06-24', '2019-06-24 23:41:51', 'Barang masuk dengan nota NOTA-BM.0008-190624', 12, 0, 'admin'),
('BRG0008', '2019-06-24', '2019-06-24 23:41:51', 'Barang masuk dengan nota NOTA-BM.0008-190624', 12, 0, 'admin'),
('BRG0007', '2019-06-24', '2019-06-24 23:41:51', 'Barang masuk dengan nota NOTA-BM.0010-190624', 12, 0, 'admin'),
('BRG0009', '2019-06-24', '2019-06-24 23:41:51', 'Barang masuk dengan nota NOTA-BM.0010-190624', 12, 0, 'admin'),
('BRG0005', '2019-06-24', '2019-06-24 23:41:51', 'Barang masuk dengan nota NOTA-BM.0012-190624', 12, 0, 'admin'),
('BRG0010', '2019-06-24', '2019-06-24 23:41:51', 'Barang masuk dengan nota NOTA-BM.0013-190624', 12, 0, 'admin'),
('BRG0014', '2019-06-24', '2019-06-24 23:41:51', 'Barang masuk dengan nota NOTA-BM.0013-190624', 12, 0, 'admin'),
('BRG0008', '2019-06-24', '2019-06-24 23:41:51', 'Barang masuk dengan nota NOTA-BM.0015-190624', 12, 0, 'admin'),
('BRG0001', '2019-06-24', '2019-06-24 23:41:51', 'Barang masuk dengan nota NOTA-BM.0015-190624', 12, 0, 'admin'),
('BRG0006', '2019-06-24', '2019-06-24 23:41:51', 'Barang masuk dengan nota NOTA-BM.0015-190624', 12, 0, 'admin'),
('BRG0011', '2019-06-24', '2019-06-24 23:41:51', 'Barang masuk dengan nota NOTA-BM.0018-190624', 12, 0, 'admin'),
('BRG0005', '2019-06-24', '2019-06-24 23:41:51', 'Barang masuk dengan nota NOTA-BM.0019-190624', 12, 0, 'admin'),
('BRG0002', '2019-06-24', '2019-06-24 23:41:51', 'Barang masuk dengan nota NOTA-BM.0019-190624', 12, 0, 'admin'),
('BRG0004', '2019-06-24', '2019-06-24 23:41:51', 'Barang masuk dengan nota NOTA-BM.0021-190624', 12, 0, 'admin'),
('BRG0001', '2016-01-28', '2016-01-28 23:41:51', 'Barang masuk dengan nota NOTA-BM.0022-190624', 12, 0, 'admin'),
('BRG0008', '2016-01-28', '2016-01-28 23:41:51', 'Barang masuk dengan nota NOTA-BM.0022-190624', 6, 0, 'admin'),
('BRG0007', '2016-02-26', '2016-02-26 23:41:51', 'Barang masuk dengan nota NOTA-BM.0003-190624', 12, 0, 'admin'),
('BRG0009', '2016-02-26', '2016-02-26 23:41:51', 'Barang masuk dengan nota NOTA-BM.0003-190624', 12, 0, 'admin'),
('BRG0011', '2016-03-30', '2016-03-30 23:41:51', 'Barang masuk dengan nota NOTA-BM.0005-190624', 12, 0, 'admin'),
('BRG0012', '2016-03-30', '2016-03-30 23:41:51', 'Barang masuk dengan nota NOTA-BM.0005-190624', 12, 0, 'admin'),
('BRG0010', '2016-04-28', '2016-04-28 23:41:51', 'Barang masuk dengan nota NOTA-BM.0007-190624', 12, 0, 'admin'),
('BRG0014', '2016-05-27', '2016-05-27 23:41:51', 'Barang masuk dengan nota NOTA-BM.0008-190624', 12, 0, 'admin'),
('BRG0008', '2016-05-27', '2016-05-27 23:41:51', 'Barang masuk dengan nota NOTA-BM.0008-190624', 12, 0, 'admin'),
('BRG0007', '2016-06-30', '2016-06-30 23:41:51', 'Barang masuk dengan nota NOTA-BM.0010-190624', 12, 0, 'admin'),
('BRG0009', '2016-06-30', '2016-06-30 23:41:51', 'Barang masuk dengan nota NOTA-BM.0010-190624', 12, 0, 'admin'),
('BRG0005', '2016-07-31', '2016-07-31 23:41:51', 'Barang masuk dengan nota NOTA-BM.0012-190624', 12, 0, 'admin'),
('BRG0010', '2016-08-30', '2016-08-30 23:41:51', 'Barang masuk dengan nota NOTA-BM.0013-190624', 12, 0, 'admin'),
('BRG0014', '2016-08-30', '2016-08-30 23:41:51', 'Barang masuk dengan nota NOTA-BM.0013-190624', 12, 0, 'admin'),
('BRG0008', '2016-09-29', '2016-09-29 23:41:51', 'Barang masuk dengan nota NOTA-BM.0015-190624', 12, 0, 'admin'),
('BRG0001', '2016-09-29', '2016-09-29 23:41:51', 'Barang masuk dengan nota NOTA-BM.0015-190624', 12, 0, 'admin'),
('BRG0006', '2016-09-29', '2016-09-29 23:41:51', 'Barang masuk dengan nota NOTA-BM.0015-190624', 12, 0, 'admin'),
('BRG0011', '2016-10-30', '2016-10-30 23:41:51', 'Barang masuk dengan nota NOTA-BM.0018-190624', 12, 0, 'admin'),
('BRG0005', '2016-11-30', '2016-11-30 23:41:51', 'Barang masuk dengan nota NOTA-BM.0019-190624', 12, 0, 'admin'),
('BRG0002', '2016-11-30', '2016-11-30 23:41:51', 'Barang masuk dengan nota NOTA-BM.0019-190624', 12, 0, 'admin'),
('BRG0004', '2016-12-30', '2016-12-30 23:41:51', 'Barang masuk dengan nota NOTA-BM.0021-190624', 12, 0, 'admin'),
('BRG0001', '2017-01-11', '2017-01-11 23:56:40', 'Pembelian barang dengan nota NOTA-BY.0022-190624', 12, 0, 'admin'),
('BRG0002', '2017-02-16', '2017-02-16 23:58:37', 'Pembelian barang dengan nota NOTA-BY.0023-190624', 12, 0, 'admin'),
('BRG0008', '2017-03-15', '2017-03-15 23:58:37', 'Pembelian barang dengan nota NOTA-BY.0024-190624', 12, 0, 'admin'),
('BRG0011', '2017-04-13', '2017-04-13 23:58:37', 'Pembelian barang dengan nota NOTA-BY.0025-190624', 12, 0, 'admin'),
('BRG0002', '2017-05-04', '2017-05-04 23:58:37', 'Pembelian barang dengan nota NOTA-BY.0026-190625', 12, 0, 'admin'),
('BRG0004', '2017-06-04', '2017-06-04 23:58:37', 'Pembelian barang dengan nota NOTA-BY.0027-190625', 12, 0, 'admin'),
('BRG0013', '2017-07-04', '2017-07-04 23:58:37', 'Pembelian barang dengan nota NOTA-BY.0028-190625', 12, 0, 'admin'),
('BRG0006', '2017-08-18', '2017-08-18 23:58:37', 'Pembelian barang dengan nota NOTA-BY.0029-190625', 12, 0, 'admin'),
('BRG0012', '2017-09-18', '2017-09-18 23:58:37', 'Pembelian barang dengan nota NOTA-BY.0030-190625', 12, 0, 'admin'),
('BRG0013', '2017-10-11', '2017-10-11 23:58:37', 'Pembelian barang dengan nota NOTA-BY.0031-190625', 12, 0, 'admin'),
('BRG0005', '2017-11-02', '2017-11-02 23:58:37', 'Pembelian barang dengan nota NOTA-BY.0032-190625', 12, 0, 'admin'),
('BRG0010', '2017-12-13', '2017-12-13 23:58:37', 'Pembelian barang dengan nota NOTA-BY.0033-190625', 12, 0, 'admin'),
('BRG0001', '2017-01-26', '2017-01-26 00:06:00', 'Barang masuk dengan nota NOTA-BM.0022-190625', 12, 0, 'admin'),
('BRG0002', '2017-02-28', '2017-02-28 00:06:00', 'Barang masuk dengan nota NOTA-BM.0023-190625', 12, 0, 'admin'),
('BRG0008', '2017-03-28', '2017-03-28 00:06:00', 'Barang masuk dengan nota NOTA-BM.0024-190625', 12, 0, 'admin'),
('BRG0011', '2017-04-27', '2017-04-27 00:06:00', 'Barang masuk dengan nota NOTA-BM.0025-190625', 12, 0, 'admin'),
('BRG0002', '2017-05-26', '2017-05-26 00:06:00', 'Barang masuk dengan nota NOTA-BM.0026-190625', 12, 0, 'admin'),
('BRG0004', '2017-06-29', '2017-06-29 00:06:00', 'Barang masuk dengan nota NOTA-BM.0027-190625', 12, 0, 'admin'),
('BRG0013', '2017-07-31', '2017-07-31 00:06:00', 'Barang masuk dengan nota NOTA-BM.0028-190625', 12, 0, 'admin'),
('BRG0006', '2017-08-29', '2017-08-29 00:06:00', 'Barang masuk dengan nota NOTA-BM.0029-190625', 12, 0, 'admin'),
('BRG0012', '2017-09-28', '2017-09-28 00:08:21', 'Barang masuk dengan nota NOTA-BM.0030-190625', 12, 0, 'admin'),
('BRG0013', '2017-10-25', '2017-10-25 00:08:21', 'Barang masuk dengan nota NOTA-BM.0031-190625', 12, 0, 'admin'),
('BRG0005', '2017-11-28', '2017-11-28 00:08:21', 'Barang masuk dengan nota NOTA-BM.0032-190625', 12, 0, 'admin'),
('BRG0010', '2017-12-28', '2017-12-28 00:08:21', 'Barang masuk dengan nota NOTA-BM.0033-190625', 12, 0, 'admin'),
('BRG0001', '2018-01-01', '2018-01-01 23:58:37', 'Pembelian barang dengan nota NOTA-BY.0034-190625', 12, 0, 'admin'),
('BRG0002', '2018-02-09', '2018-02-09 23:58:37', 'Pembelian barang dengan nota NOTA-BY.0035-190625', 24, 0, 'admin'),
('BRG0004', '2018-03-14', '2018-03-14 23:58:37', 'Pembelian barang dengan nota NOTA-BY.0036-190625', 12, 0, 'admin'),
('BRG0005', '2018-03-14', '2018-03-14 23:58:37', 'Pembelian barang dengan nota NOTA-BY.0036-190625', 6, 0, 'admin'),
('BRG0011', '2018-04-17', '2018-04-17 23:58:37', 'Pembelian barang dengan nota NOTA-BY.0038-190625', 6, 0, 'admin'),
('BRG0012', '2018-04-17', '2018-04-17 23:58:37', 'Pembelian barang dengan nota NOTA-BY.0038-190625', 12, 0, 'admin'),
('BRG0014', '2018-05-11', '2018-05-11 23:58:37', 'Pembelian barang dengan nota NOTA-BY.0040-190625', 8, 0, 'admin'),
('BRG0011', '2018-06-20', '2018-06-20 23:58:37', 'Pembelian barang dengan nota NOTA-BY.0041-190625', 6, 0, 'admin'),
('BRG0006', '2018-06-20', '2018-06-20 23:58:37', 'Pembelian barang dengan nota NOTA-BY.0041-190625', 12, 0, 'admin'),
('BRG0005', '2018-07-03', '2018-07-03 23:58:37', 'Pembelian barang dengan nota NOTA-BY.0043-190625', 6, 0, 'admin'),
('BRG0001', '2018-08-09', '2018-08-09 23:58:37', 'Pembelian barang dengan nota NOTA-BY.0044-190625', 20, 0, 'admin'),
('BRG0010', '2018-09-17', '2018-09-17 23:58:37', 'Pembelian barang dengan nota NOTA-BY.0045-190625', 6, 0, 'admin'),
('BRG0012', '2018-09-17', '2018-09-17 23:58:37', 'Pembelian barang dengan nota NOTA-BY.0045-190625', 6, 0, 'admin'),
('BRG0004', '2018-10-04', '2018-10-04 23:58:37', 'Pembelian barang dengan nota NOTA-BY.0047-190625', 12, 0, 'admin'),
('BRG0009', '2018-11-18', '2018-11-18 23:58:37', 'Pembelian barang dengan nota NOTA-BY.0048-190625', 6, 0, 'admin'),
('BRG0001', '2018-12-08', '2018-12-08 23:58:37', 'Pembelian barang dengan nota NOTA-BY.0049-190625', 20, 0, 'admin'),
('BRG0001', '2018-01-31', '2018-01-31 00:08:21', 'Barang masuk dengan nota NOTA-BM.0034-190625', 12, 0, 'admin'),
('BRG0002', '2018-02-26', '2018-02-26 00:08:21', 'Barang masuk dengan nota NOTA-BM.0035-190625', 24, 0, 'admin'),
('BRG0004', '2018-03-30', '2018-03-30 00:08:21', 'Barang masuk dengan nota NOTA-BM.0036-190625', 12, 0, 'admin'),
('BRG0005', '2018-03-30', '2018-03-30 00:08:21', 'Barang masuk dengan nota NOTA-BM.0036-190625', 6, 0, 'admin'),
('BRG0011', '2018-04-25', '2018-04-25 00:08:21', 'Barang masuk dengan nota NOTA-BM.0038-190625', 6, 0, 'admin'),
('BRG0012', '2018-04-25', '2018-04-25 00:08:21', 'Barang masuk dengan nota NOTA-BM.0038-190625', 12, 0, 'admin'),
('BRG0014', '2018-05-31', '2018-05-31 00:08:21', 'Barang masuk dengan nota NOTA-BM.0040-190625', 8, 0, 'admin'),
('BRG0011', '2018-06-28', '2018-06-28 00:08:21', 'Barang masuk dengan nota NOTA-BM.0041-190625', 6, 0, 'admin'),
('BRG0006', '2018-06-28', '2018-06-28 00:08:21', 'Barang masuk dengan nota NOTA-BM.0041-190625', 12, 0, 'admin'),
('BRG0005', '2018-07-31', '2018-07-31 00:08:21', 'Barang masuk dengan nota NOTA-BM.0043-190625', 6, 0, 'admin'),
('BRG0001', '2018-08-29', '2018-08-29 00:08:21', 'Barang masuk dengan nota NOTA-BM.0044-190625', 20, 0, 'admin'),
('BRG0010', '2018-09-26', '2018-09-26 00:08:21', 'Barang masuk dengan nota NOTA-BM.0045-190625', 6, 0, 'admin'),
('BRG0012', '2018-09-26', '2018-09-26 00:08:21', 'Barang masuk dengan nota NOTA-BM.0045-190625', 6, 0, 'admin'),
('BRG0004', '2018-10-31', '2018-10-31 00:08:21', 'Barang masuk dengan nota NOTA-BM.0047-190625', 12, 0, 'admin'),
('BRG0009', '2018-11-29', '2018-11-29 00:08:21', 'Barang masuk dengan nota NOTA-BM.0048-190625', 6, 0, 'admin'),
('BRG0001', '2018-12-27', '2018-12-27 00:08:21', 'Barang masuk dengan nota NOTA-BM.0049-190625', 20, 0, 'admin'),
('BRG0004', '2019-01-03', '2019-01-03 23:58:37', 'Pembelian barang dengan nota NOTA-BY.0050-190625', 6, 0, 'admin'),
('BRG0005', '2019-02-07', '2019-02-07 23:58:37', 'Pembelian barang dengan nota NOTA-BY.0051-190625', 12, 0, 'admin'),
('BRG0010', '2019-03-13', '2019-03-13 23:58:37', 'Pembelian barang dengan nota NOTA-BY.0052-190625', 24, 0, 'admin'),
('BRG0006', '2019-04-11', '2019-04-11 23:58:37', 'Pembelian barang dengan nota NOTA-BY.0053-190625', 8, 0, 'admin'),
('BRG0013', '2019-05-10', '2019-05-10 23:58:37', 'Pembelian barang dengan nota NOTA-BY.0054-190625', 12, 0, 'admin'),
('BRG0002', '2019-06-06', '2019-06-06 23:58:37', 'Pembelian barang dengan nota NOTA-BY.0055-190625', 6, 0, 'admin'),
('BRG0001', '2019-06-06', '2019-06-06 23:58:37', 'Pembelian barang dengan nota NOTA-BY.0055-190625', 3, 0, 'admin'),
('BRG0007', '2019-07-13', '2019-07-13 23:58:37', 'Pembelian barang dengan nota NOTA-BY.0057-190625', 12, 0, 'admin'),
('BRG0002', '2019-08-12', '2019-08-12 23:58:37', 'Pembelian barang dengan nota NOTA-BY.0058-190625', 6, 0, 'admin'),
('BRG0012', '2019-09-05', '2019-09-05 23:58:37', 'Pembelian barang dengan nota NOTA-BY.0059-190625', 12, 0, 'admin'),
('BRG0005', '2019-10-17', '2019-10-17 23:58:37', 'Pembelian barang dengan nota NOTA-BY.0060-190625', 5, 0, 'admin'),
('BRG0004', '2019-11-16', '2019-11-16 23:58:37', 'Pembelian barang dengan nota NOTA-BY.0061-190625', 12, 0, 'admin'),
('BRG0012', '2019-12-01', '2019-12-01 23:58:37', 'Pembelian barang dengan nota NOTA-BY.0062-190625', 8, 0, 'admin'),
('BRG0004', '2019-01-25', '2019-01-25 00:08:21', 'Barang masuk dengan nota NOTA-BM.0050-190625', 6, 0, 'admin'),
('BRG0005', '2019-02-27', '2019-02-27 00:08:21', 'Barang masuk dengan nota NOTA-BM.0051-190625', 12, 0, 'admin'),
('BRG0010', '2019-03-29', '2019-03-29 00:08:21', 'Barang masuk dengan nota NOTA-BM.0052-190625', 24, 0, 'admin'),
('BRG0006', '2019-04-28', '2019-04-28 00:08:21', 'Barang masuk dengan nota NOTA-BM.0053-190625', 8, 0, 'admin'),
('BRG0013', '2019-05-30', '2019-05-30 00:08:21', 'Barang masuk dengan nota NOTA-BM.0054-190625', 12, 0, 'admin'),
('BRG0002', '2019-06-20', '2019-06-20 00:08:21', 'Barang masuk dengan nota NOTA-BM.0055-190625', 6, 0, 'admin'),
('BRG0001', '2019-06-20', '2019-06-20 00:08:21', 'Barang masuk dengan nota NOTA-BM.0055-190625', 3, 0, 'admin'),
('BRG0007', '2019-07-31', '2019-07-31 00:08:21', 'Barang masuk dengan nota NOTA-BM.0057-190625', 12, 0, 'admin'),
('BRG0002', '2019-08-21', '2019-08-21 00:08:21', 'Barang masuk dengan nota NOTA-BM.0058-190625', 6, 0, 'admin'),
('BRG0012', '2019-09-18', '2019-09-18 00:08:21', 'Barang masuk dengan nota NOTA-BM.0059-190625', 12, 0, 'admin'),
('BRG0005', '2019-10-24', '2019-10-24 00:08:21', 'Barang masuk dengan nota NOTA-BM.0060-190625', 5, 0, 'admin'),
('BRG0004', '2019-11-27', '2019-11-27 00:29:46', 'Barang masuk dengan nota NOTA-BM.0061-190625', 12, 0, 'admin'),
('BRG0012', '2019-12-12', '2019-12-12 00:29:46', 'Barang masuk dengan nota NOTA-BM.0062-190625', 8, 0, 'admin'),
('BRG0001', '2019-06-25', '2019-06-25 00:34:00', 'Retur penjualan dengan nota RJ.0001-190625', 0, 1, 'admin'),
('BRG0004', '2019-06-25', '2019-06-25 00:34:08', 'Retur pembelian dengan nota RB.0001-190623', 2, 0, 'admin'),
('BRG0014', '2019-06-25', '2019-06-25 00:34:32', 'Stok opname dengan kode SO.0001-190625', 162, 1, 'admin'),
('BRG0003', '2019-07-04', '2019-07-04 02:47:13', 'Pembelian barang dengan nota NOTA-BY.0063-190704', 12, 0, 'admin'),
('BRG0017', '2019-07-04', '2019-07-04 02:47:13', 'Pembelian barang dengan nota NOTA-BY.0063-190704', 12, 0, 'admin'),
('BRG0005', '2019-07-04', '2019-07-04 04:48:49', 'Barang keluar dengan nota NOTA-BK.0001-190704', 6, 0, 'admin'),
('BRG0001', '2019-07-04', '2019-07-04 04:48:49', 'Barang keluar dengan nota NOTA-BK.0001-190704', 12, 0, 'admin');

-- --------------------------------------------------------

--
-- Table structure for table `barang_keluar`
--

CREATE TABLE `barang_keluar` (
  `ID_BARANG_KELUAR` varchar(20) NOT NULL,
  `ID_PELANGGAN` varchar(10) NOT NULL,
  `NOTA_BARANG_KELUAR` varchar(20) NOT NULL,
  `TOTAL_STOK_KELUAR` int(11) NOT NULL,
  `TANGGAL_KELUAR` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `barang_keluar`
--

INSERT INTO `barang_keluar` (`ID_BARANG_KELUAR`, `ID_PELANGGAN`, `NOTA_BARANG_KELUAR`, `TOTAL_STOK_KELUAR`, `TANGGAL_KELUAR`) VALUES
('BK.0001-190704', 'CUS0001', 'NOTA-BK.0001-190704', 18, '2019-07-04');

-- --------------------------------------------------------

--
-- Table structure for table `barang_keluar_detail`
--

CREATE TABLE `barang_keluar_detail` (
  `ID_BARANG` varchar(10) NOT NULL,
  `ID_TRANSAKSI` varchar(30) NOT NULL,
  `ID_BRG_KLR_DETAIL` varchar(30) NOT NULL,
  `NOTA_BARANG_KELUAR` varchar(30) NOT NULL,
  `STOK_KELUAR` int(11) NOT NULL,
  `TANGGAL_KELUAR_DETAIL` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `barang_keluar_detail`
--

INSERT INTO `barang_keluar_detail` (`ID_BARANG`, `ID_TRANSAKSI`, `ID_BRG_KLR_DETAIL`, `NOTA_BARANG_KELUAR`, `STOK_KELUAR`, `TANGGAL_KELUAR_DETAIL`) VALUES
('BRG0005', 'TR.0002-190624', 'BK-D.0001-190704', 'NOTA-BK.0001-190704', 6, '2019-07-04'),
('BRG0001', 'TR.0001-190624', 'BK-D.0002-190704', 'NOTA-BK.0001-190704', 12, '2019-07-04');

-- --------------------------------------------------------

--
-- Table structure for table `barang_masuk`
--

CREATE TABLE `barang_masuk` (
  `ID_BARANG_MASUK` varchar(20) NOT NULL,
  `ID_SUPPLIER` varchar(10) NOT NULL,
  `NOTA_BARANG_MASUK` varchar(20) DEFAULT NULL,
  `TOTAL_STOK_MASUK` int(11) DEFAULT NULL,
  `TANGGAL_MASUK` date DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `barang_masuk`
--

INSERT INTO `barang_masuk` (`ID_BARANG_MASUK`, `ID_SUPPLIER`, `NOTA_BARANG_MASUK`, `TOTAL_STOK_MASUK`, `TANGGAL_MASUK`) VALUES
('BM.0002-190624', 'SUP0001', 'NOTA-BM.0003-190624', 24, '2016-02-26'),
('BM.0003-190624', 'SUP0001', 'NOTA-BM.0005-190624', 24, '2016-03-30'),
('BM.0004-190624', 'SUP0001', 'NOTA-BM.0007-190624', 12, '2016-04-28'),
('BM.0005-190624', 'SUP0002', 'NOTA-BM.0008-190624', 24, '2016-05-27'),
('BM.0006-190624', 'SUP0002', 'NOTA-BM.0010-190624', 24, '2016-06-30'),
('BM.0007-190624', 'SUP0001', 'NOTA-BM.0012-190624', 12, '2016-07-31'),
('BM.0008-190624', 'SUP0004', 'NOTA-BM.0013-190624', 24, '2016-08-30'),
('BM.0009-190624', 'SUP0001', 'NOTA-BM.0015-190624', 36, '2016-09-29'),
('BM.0010-190624', 'SUP0002', 'NOTA-BM.0018-190624', 12, '2016-10-30'),
('BM.0011-190624', 'SUP0004', 'NOTA-BM.0019-190624', 24, '2016-11-30'),
('BM.0012-190624', 'SUP0001', 'NOTA-BM.0021-190624', 12, '2016-12-30'),
('BM.0013-190624', 'SUP0001', 'NOTA-BM.0022-190624', 18, '2016-01-28'),
('BM.0013-190625', 'SUP0002', 'NOTA-BM.0022-190625', 12, '2017-01-26'),
('BM.0014-190625', 'SUP0001', 'NOTA-BM.0023-190625', 12, '2017-02-28'),
('BM.0015-190625', 'SUP0002', 'NOTA-BM.0024-190625', 12, '2017-03-28'),
('BM.0016-190625', 'SUP0002', 'NOTA-BM.0025-190625', 12, '2017-04-27'),
('BM.0017-190625', 'SUP0004', 'NOTA-BM.0026-190625', 12, '2017-05-26'),
('BM.0018-190625', 'SUP0001', 'NOTA-BM.0027-190625', 12, '2017-06-29'),
('BM.0019-190625', 'SUP0001', 'NOTA-BM.0028-190625', 12, '2017-07-31'),
('BM.0020-190625', 'SUP0002', 'NOTA-BM.0029-190625', 12, '2017-08-29'),
('BM.0021-190625', 'SUP0002', 'NOTA-BM.0030-190625', 12, '2017-09-28'),
('BM.0022-190625', 'SUP0001', 'NOTA-BM.0031-190625', 12, '2017-10-25'),
('BM.0023-190625', 'SUP0004', 'NOTA-BM.0032-190625', 12, '2017-11-28'),
('BM.0024-190625', 'SUP0001', 'NOTA-BM.0033-190625', 12, '2017-12-28'),
('BM.0025-190625', 'SUP0001', 'NOTA-BM.0034-190625', 12, '2018-01-31'),
('BM.0026-190625', 'SUP0001', 'NOTA-BM.0035-190625', 24, '2018-02-26'),
('BM.0027-190625', 'SUP0001', 'NOTA-BM.0036-190625', 18, '2018-03-30'),
('BM.0028-190625', 'SUP0002', 'NOTA-BM.0038-190625', 18, '2018-04-25'),
('BM.0029-190625', 'SUP0004', 'NOTA-BM.0040-190625', 8, '2018-05-31'),
('BM.0030-190625', 'SUP0001', 'NOTA-BM.0041-190625', 18, '2018-06-28'),
('BM.0031-190625', 'SUP0002', 'NOTA-BM.0043-190625', 6, '2018-07-31'),
('BM.0032-190625', 'SUP0001', 'NOTA-BM.0044-190625', 20, '2018-08-29'),
('BM.0033-190625', 'SUP0002', 'NOTA-BM.0045-190625', 12, '2018-09-26'),
('BM.0034-190625', 'SUP0001', 'NOTA-BM.0047-190625', 12, '2018-10-31'),
('BM.0035-190625', 'SUP0004', 'NOTA-BM.0048-190625', 6, '2018-11-29'),
('BM.0036-190625', 'SUP0001', 'NOTA-BM.0049-190625', 20, '2018-12-27'),
('BM.0037-190625', 'SUP0001', 'NOTA-BM.0050-190625', 6, '2019-01-25'),
('BM.0038-190625', 'SUP0001', 'NOTA-BM.0051-190625', 12, '2019-02-27'),
('BM.0039-190625', 'SUP0001', 'NOTA-BM.0052-190625', 24, '2019-03-29'),
('BM.0040-190625', 'SUP0001', 'NOTA-BM.0053-190625', 8, '2019-04-28'),
('BM.0041-190625', 'SUP0001', 'NOTA-BM.0054-190625', 12, '2019-05-30'),
('BM.0042-190625', 'SUP0004', 'NOTA-BM.0055-190625', 9, '2019-06-20'),
('BM.0043-190625', 'SUP0001', 'NOTA-BM.0057-190625', 12, '2019-07-31'),
('BM.0044-190625', 'SUP0001', 'NOTA-BM.0058-190625', 6, '2019-08-21'),
('BM.0045-190625', 'SUP0002', 'NOTA-BM.0059-190625', 12, '2019-09-18'),
('BM.0046-190625', 'SUP0004', 'NOTA-BM.0060-190625', 5, '2019-10-24'),
('BM.0047-190625', 'SUP0004', 'NOTA-BM.0061-190625', 12, '2019-11-27'),
('BM.0048-190625', 'SUP0001', 'NOTA-BM.0062-190625', 8, '2019-12-12');

-- --------------------------------------------------------

--
-- Table structure for table `barang_masuk_detail`
--

CREATE TABLE `barang_masuk_detail` (
  `ID_BARANG` varchar(10) NOT NULL,
  `ID_DETAIL` varchar(30) NOT NULL,
  `ID_BRG_MSK_DETAIL` varchar(30) NOT NULL,
  `NOTA_BARANG_MASUK` varchar(30) DEFAULT NULL,
  `STOK_MASUK` int(11) DEFAULT NULL,
  `TANGGAL_MASUK_DETAIL` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `barang_masuk_detail`
--

INSERT INTO `barang_masuk_detail` (`ID_BARANG`, `ID_DETAIL`, `ID_BRG_MSK_DETAIL`, `NOTA_BARANG_MASUK`, `STOK_MASUK`, `TANGGAL_MASUK_DETAIL`) VALUES
('BRG0008', 'PD.0002-190624', 'BM-D.0002-190624', 'NOTA-BM.0022-190624', 6, '2016-01-28'),
('BRG0007', 'PD.0003-190624', 'BM-D.0003-190624', 'NOTA-BM.0003-190624', 12, '2016-02-26'),
('BRG0009', 'PD.0004-190624', 'BM-D.0004-190624', 'NOTA-BM.0003-190624', 12, '2016-02-26'),
('BRG0011', 'PD.0005-190624', 'BM-D.0005-190624', 'NOTA-BM.0005-190624', 12, '2016-03-30'),
('BRG0012', 'PD.0006-190624', 'BM-D.0006-190624', 'NOTA-BM.0005-190624', 12, '2016-03-30'),
('BRG0010', 'PD.0007-190624', 'BM-D.0007-190624', 'NOTA-BM.0007-190624', 12, '2016-04-28'),
('BRG0014', 'PD.0008-190624', 'BM-D.0008-190624', 'NOTA-BM.0008-190624', 12, '2016-05-27'),
('BRG0008', 'PD.0009-190624', 'BM-D.0009-190624', 'NOTA-BM.0008-190624', 12, '2016-05-27'),
('BRG0007', 'PD.0010-190624', 'BM-D.0010-190624', 'NOTA-BM.0010-190624', 12, '2016-06-30'),
('BRG0009', 'PD.0011-190624', 'BM-D.0011-190624', 'NOTA-BM.0010-190624', 12, '2016-06-30'),
('BRG0005', 'PD.0012-190624', 'BM-D.0012-190624', 'NOTA-BM.0012-190624', 12, '2016-07-31'),
('BRG0010', 'PD.0013-190624', 'BM-D.0013-190624', 'NOTA-BM.0013-190624', 12, '2016-08-30'),
('BRG0014', 'PD.0014-190624', 'BM-D.0014-190624', 'NOTA-BM.0013-190624', 12, '2016-08-30'),
('BRG0008', 'PD.0015-190624', 'BM-D.0015-190624', 'NOTA-BM.0015-190624', 12, '2016-09-29'),
('BRG0001', 'PD.0016-190624', 'BM-D.0016-190624', 'NOTA-BM.0015-190624', 12, '2016-09-29'),
('BRG0006', 'PD.0017-190624', 'BM-D.0017-190624', 'NOTA-BM.0015-190624', 12, '2016-09-29'),
('BRG0011', 'PD.0018-190624', 'BM-D.0018-190624', 'NOTA-BM.0018-190624', 12, '2016-10-30'),
('BRG0005', 'PD.0019-190624', 'BM-D.0019-190624', 'NOTA-BM.0019-190624', 12, '2016-11-30'),
('BRG0002', 'PD.0020-190624', 'BM-D.0020-190624', 'NOTA-BM.0019-190624', 12, '2016-11-30'),
('BRG0004', 'PD.0021-190624', 'BM-D.0021-190624', 'NOTA-BM.0021-190624', 12, '2016-12-30'),
('BRG0001', 'PD.0001-190624', 'BM-D.0022-190624', 'NOTA-BM.0022-190624', 12, '2016-01-28'),
('BRG0001', 'PD.0022-190624', 'BM-D.0022-190625', 'NOTA-BM.0022-190625', 12, '2017-01-26'),
('BRG0002', 'PD.0023-190624', 'BM-D.0023-190625', 'NOTA-BM.0023-190625', 12, '2017-02-28'),
('BRG0008', 'PD.0024-190624', 'BM-D.0024-190625', 'NOTA-BM.0024-190625', 12, '2017-03-28'),
('BRG0011', 'PD.0025-190624', 'BM-D.0025-190625', 'NOTA-BM.0025-190625', 12, '2017-04-27'),
('BRG0002', 'PD.0026-190624', 'BM-D.0026-190625', 'NOTA-BM.0026-190625', 12, '2017-05-26'),
('BRG0004', 'PD.0027-190625', 'BM-D.0027-190625', 'NOTA-BM.0027-190625', 12, '2017-06-29'),
('BRG0013', 'PD.0028-190625', 'BM-D.0028-190625', 'NOTA-BM.0028-190625', 12, '2017-07-31'),
('BRG0006', 'PD.0029-190625', 'BM-D.0029-190625', 'NOTA-BM.0029-190625', 12, '2017-08-29'),
('BRG0012', 'PD.0030-190625', 'BM-D.0030-190625', 'NOTA-BM.0030-190625', 12, '2017-09-28'),
('BRG0013', 'PD.0031-190625', 'BM-D.0031-190625', 'NOTA-BM.0031-190625', 12, '2017-10-25'),
('BRG0005', 'PD.0032-190625', 'BM-D.0032-190625', 'NOTA-BM.0032-190625', 12, '2017-11-28'),
('BRG0010', 'PD.0033-190625', 'BM-D.0033-190625', 'NOTA-BM.0033-190625', 12, '2017-12-28'),
('BRG0001', 'PD.0034-190625', 'BM-D.0034-190625', 'NOTA-BM.0034-190625', 12, '2018-01-31'),
('BRG0002', 'PD.0035-190625', 'BM-D.0035-190625', 'NOTA-BM.0035-190625', 24, '2018-02-26'),
('BRG0004', 'PD.0036-190625', 'BM-D.0036-190625', 'NOTA-BM.0036-190625', 12, '2018-03-30'),
('BRG0005', 'PD.0037-190625', 'BM-D.0037-190625', 'NOTA-BM.0036-190625', 6, '2018-03-30'),
('BRG0011', 'PD.0038-190625', 'BM-D.0038-190625', 'NOTA-BM.0038-190625', 6, '2018-04-25'),
('BRG0012', 'PD.0039-190625', 'BM-D.0039-190625', 'NOTA-BM.0038-190625', 12, '2018-04-25'),
('BRG0014', 'PD.0040-190625', 'BM-D.0040-190625', 'NOTA-BM.0040-190625', 8, '2018-05-31'),
('BRG0011', 'PD.0041-190625', 'BM-D.0041-190625', 'NOTA-BM.0041-190625', 6, '2018-06-28'),
('BRG0006', 'PD.0042-190625', 'BM-D.0042-190625', 'NOTA-BM.0041-190625', 12, '2018-06-28'),
('BRG0005', 'PD.0043-190625', 'BM-D.0043-190625', 'NOTA-BM.0043-190625', 6, '2018-07-31'),
('BRG0001', 'PD.0044-190625', 'BM-D.0044-190625', 'NOTA-BM.0044-190625', 20, '2018-08-29'),
('BRG0010', 'PD.0045-190625', 'BM-D.0045-190625', 'NOTA-BM.0045-190625', 6, '2018-09-26'),
('BRG0012', 'PD.0046-190625', 'BM-D.0046-190625', 'NOTA-BM.0045-190625', 6, '2018-09-26'),
('BRG0004', 'PD.0047-190625', 'BM-D.0047-190625', 'NOTA-BM.0047-190625', 12, '2018-10-31'),
('BRG0009', 'PD.0048-190625', 'BM-D.0048-190625', 'NOTA-BM.0048-190625', 6, '2018-11-29'),
('BRG0001', 'PD.0049-190625', 'BM-D.0049-190625', 'NOTA-BM.0049-190625', 20, '2018-12-27'),
('BRG0004', 'PD.0050-190625', 'BM-D.0050-190625', 'NOTA-BM.0050-190625', 6, '2019-01-25'),
('BRG0005', 'PD.0051-190625', 'BM-D.0051-190625', 'NOTA-BM.0051-190625', 12, '2019-02-27'),
('BRG0010', 'PD.0052-190625', 'BM-D.0052-190625', 'NOTA-BM.0052-190625', 24, '2019-03-29'),
('BRG0006', 'PD.0053-190625', 'BM-D.0053-190625', 'NOTA-BM.0053-190625', 8, '2019-04-28'),
('BRG0013', 'PD.0054-190625', 'BM-D.0054-190625', 'NOTA-BM.0054-190625', 12, '2019-05-30'),
('BRG0002', 'PD.0055-190625', 'BM-D.0055-190625', 'NOTA-BM.0055-190625', 6, '2019-06-20'),
('BRG0001', 'PD.0056-190625', 'BM-D.0056-190625', 'NOTA-BM.0055-190625', 3, '2019-06-20'),
('BRG0007', 'PD.0057-190625', 'BM-D.0057-190625', 'NOTA-BM.0057-190625', 12, '2019-07-31'),
('BRG0002', 'PD.0058-190625', 'BM-D.0058-190625', 'NOTA-BM.0058-190625', 6, '2019-08-21'),
('BRG0012', 'PD.0059-190625', 'BM-D.0059-190625', 'NOTA-BM.0059-190625', 12, '2019-09-18'),
('BRG0005', 'PD.0060-190625', 'BM-D.0060-190625', 'NOTA-BM.0060-190625', 5, '2019-10-24'),
('BRG0004', 'PD.0061-190625', 'BM-D.0061-190625', 'NOTA-BM.0061-190625', 12, '2019-11-27'),
('BRG0012', 'PD.0062-190625', 'BM-D.0062-190625', 'NOTA-BM.0062-190625', 8, '2019-12-12');

--
-- Triggers `barang_masuk_detail`
--
DELIMITER $$
CREATE TRIGGER `Kurang_Stok_Barang_dan_MASUK` AFTER DELETE ON `barang_masuk_detail` FOR EACH ROW BEGIN
UPDATE barang SET STOK_BARANG = STOK_BARANG - old.STOK_MASUK
WHERE ID_BARANG = old.ID_BARANG;
UPDATE pembelian_detail SET MASUK = MASUK - old.STOK_MASUK
WHERE ID_DETAIL = old.ID_DETAIL;
END
$$
DELIMITER ;
DELIMITER $$
CREATE TRIGGER `Tambah_Stok_Barang` AFTER INSERT ON `barang_masuk_detail` FOR EACH ROW BEGIN
UPDATE barang SET STOK_BARANG = STOK_BARANG + new.STOK_MASUK
WHERE ID_BARANG = new.ID_BARANG;
END
$$
DELIMITER ;

-- --------------------------------------------------------

--
-- Table structure for table `pelanggan`
--

CREATE TABLE `pelanggan` (
  `ID_PELANGGAN` varchar(10) NOT NULL,
  `NAMA_PELANGGAN` varchar(255) DEFAULT NULL,
  `JENIS_PELANGGAN` varchar(20) DEFAULT NULL,
  `ALAMAT_PELANGGAN` varchar(255) DEFAULT NULL,
  `NO_TELP_PELANGGAN` varchar(13) DEFAULT NULL,
  `EMAIL_PELANGGAN` varchar(20) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `pelanggan`
--

INSERT INTO `pelanggan` (`ID_PELANGGAN`, `NAMA_PELANGGAN`, `JENIS_PELANGGAN`, `ALAMAT_PELANGGAN`, `NO_TELP_PELANGGAN`, `EMAIL_PELANGGAN`) VALUES
('CUS0001', 'Cafe Umasari', 'Cafe', 'Jl. Matahari Terbit, Sanur Kaja', '0361188987', ''),
('CUS0002', 'Glass House', 'Restoran', 'Jl. Danau Tamblingan No.25, Sanur', '0361288696', ''),
('CUS0003', 'Little Bird', 'Restoran', 'Jl. Danau Tamblingan No.34, Sanur', '0361888123', ''),
('CUS0004', 'Cat And Fiddle', 'Restoran', 'Jl. Cemara No.36, Sanur', '0361282218', 'info@catfiddle.com'),
('CUS0005', 'Man Shed', 'Restoran', 'Jl. Tirtanadi II No.9, Sanur', '0397580207', 'sanurautoclassic2010'),
('CUS0006', 'Soul & A Bowl', 'Cafe', 'Jl. Danau Tamblingan No.180, Sanur', '03614720063', 'soulinabowlcafe@gmai'),
('CUS0007', 'Icip Icip Restaurant', 'Restoran', 'Jalan Monkey Forest, Ubud', '03619190934', ''),
('CUS0008', 'Pundi Pundi Restaurant', 'Restoran', 'Jl. Pengosekan, Ubud', '03613084005', ''),
('CUS0009', 'Bali Joe Bar', 'Bar', 'Jl. Camplung Tanduk No.8, Seminyak', '0361730931', 'info@balijoebar.com'),
('CUS0010', 'Zoo Bar', 'Bar', 'Jl. Danau Tamblingan No.82, Sanur', '0361288807', ''),
('CUS0011', 'Doner Kebab', 'Restoran', 'Jl. Danau Toba No.3, Sanur', '0361270237', 'sisiliaanastasia@hot'),
('CUS0012', 'Grand Inna Bali Beach', 'Hotel', 'Jalan Hang Tuah, Sanur', '0361288511', 'sales@grandinnabalib'),
('CUS0013', 'The Kayon Resort', 'Villa', 'Banjar Kepitu, Desa Kendran, Tegallalang, Ubud', '03614792553', 'info@thekayonresort.'),
('CUS0014', 'The Bars', 'Bar', 'Jl. Danau Tamblingan', '0361276409', 'infothebars@gmail.co'),
('CUS0015', 'Diuma Cafe', 'Cafe', 'Jl. Penyaringan, Sanur', '081234545654', 'diumacafe@gmail.com');

-- --------------------------------------------------------

--
-- Table structure for table `pembelian`
--

CREATE TABLE `pembelian` (
  `ID_PEMBELIAN` varchar(30) NOT NULL,
  `ID_SUPPLIER` varchar(10) DEFAULT NULL,
  `NOTA_PEMBELIAN` varchar(30) DEFAULT NULL,
  `TGL_BELI` date DEFAULT NULL,
  `TGL_BAYAR` date DEFAULT NULL,
  `JENIS_BAYAR` varchar(10) DEFAULT NULL,
  `GRAND_TOTAL_BELI` int(11) DEFAULT NULL,
  `TOTAL_QTY` int(11) NOT NULL,
  `PAJAK_BELI` varchar(5) NOT NULL,
  `DISKON_BELI` varchar(5) NOT NULL,
  `PEMBAYARAN` int(11) DEFAULT NULL,
  `TAGIHAN` int(11) DEFAULT NULL,
  `STATUS_TRANSAKSI_BELI` varchar(20) DEFAULT NULL,
  `PENGGUNA` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `pembelian`
--

INSERT INTO `pembelian` (`ID_PEMBELIAN`, `ID_SUPPLIER`, `NOTA_PEMBELIAN`, `TGL_BELI`, `TGL_BAYAR`, `JENIS_BAYAR`, `GRAND_TOTAL_BELI`, `TOTAL_QTY`, `PAJAK_BELI`, `DISKON_BELI`, `PEMBAYARAN`, `TAGIHAN`, `STATUS_TRANSAKSI_BELI`, `PENGGUNA`) VALUES
('BY.0001-190624', 'SUP0001', 'NOTA-BY.0001-190624', '2016-01-13', '2016-01-13', 'CASH', 5076000, 0, '', '0', 5076000, 0, 'LUNAS', 'Admin'),
('BY.0002-190624', 'SUP0001', 'NOTA-BY.0003-190624', '2016-02-10', '2016-02-10', 'CASH', 4848000, 0, '', '0', 4848000, 0, 'LUNAS', 'Admin'),
('BY.0003-190624', 'SUP0001', 'NOTA-BY.0005-190624', '2016-03-24', '2019-06-25', 'KREDIT', 8808000, 0, '', '0', 8808000, 0, 'LUNAS', 'Admin'),
('BY.0004-190624', 'SUP0001', 'NOTA-BY.0007-190624', '2016-04-13', '2016-04-13', 'CASH', 3084000, 0, '', '0', 3084000, 0, 'LUNAS', 'Admin'),
('BY.0005-190624', 'SUP0002', 'NOTA-BY.0008-190624', '2016-05-18', '2016-05-18', 'KREDIT', 6888000, 0, '', '0', 5000000, 1888000, 'UTANG', 'Admin'),
('BY.0006-190624', 'SUP0002', 'NOTA-BY.0010-190624', '2016-06-16', '2016-06-16', 'CASH', 4848000, 0, '', '0', 4848000, 0, 'LUNAS', 'Admin'),
('BY.0007-190624', 'SUP0001', 'NOTA-BY.0012-190624', '2016-07-21', '2016-07-21', 'CASH', 4884000, 0, '', '0', 4884000, 0, 'LUNAS', 'Admin'),
('BY.0008-190624', 'SUP0004', 'NOTA-BY.0013-190624', '2016-08-25', '2016-08-25', 'CASH', 6588000, 0, '', '0', 6588000, 0, 'LUNAS', 'Admin'),
('BY.0009-190624', 'SUP0001', 'NOTA-BY.0015-190624', '2016-09-30', '2016-09-30', 'KREDIT', 11352000, 0, '', '0', 8000000, 3352000, 'UTANG', 'Admin'),
('BY.0010-190624', 'SUP0002', 'NOTA-BY.0018-190624', '2016-10-13', '2016-10-13', 'CASH', 2724000, 0, '', '0', 2724000, 0, 'LUNAS', 'Admin'),
('BY.0011-190624', 'SUP0004', 'NOTA-BY.0019-190624', '2016-11-18', '2016-11-18', 'KREDIT', 10368000, 0, '', '0', 5000000, 5368000, 'UTANG', 'Admin'),
('BY.0012-190624', 'SUP0001', 'NOTA-BY.0021-190624', '2016-12-12', '2016-12-12', 'CASH', 3384000, 0, '', '0', 3384000, 0, 'LUNAS', 'Admin'),
('BY.0013-190624', 'SUP0002', 'NOTA-BY.0022-190624', '2017-01-11', '2017-01-11', 'CASH', 3384000, 0, '', '0', 3384000, 0, 'LUNAS', 'Admin'),
('BY.0014-190624', 'SUP0001', 'NOTA-BY.0023-190624', '2017-02-16', '2017-02-16', 'CASH', 5484000, 0, '', '0', 5484000, 0, 'LUNAS', 'Admin'),
('BY.0015-190624', 'SUP0002', 'NOTA-BY.0024-190624', '2017-03-15', '2017-03-15', 'CASH', 3384000, 0, '', '0', 3384000, 0, 'LUNAS', 'Admin'),
('BY.0016-190624', 'SUP0002', 'NOTA-BY.0025-190624', '2017-04-13', '2017-04-13', 'CASH', 2724000, 0, '', '0', 2724000, 0, 'LUNAS', 'Admin'),
('BY.0017-190624', 'SUP0004', 'NOTA-BY.0026-190625', '2017-05-04', '2017-05-04', 'CASH', 5484000, 0, '', '0', 5484000, 0, 'LUNAS', 'Admin'),
('BY.0018-190625', 'SUP0001', 'NOTA-BY.0027-190625', '2017-06-04', '2017-06-04', 'CASH', 3384000, 0, '', '0', 3384000, 0, 'LUNAS', 'Admin'),
('BY.0019-190625', 'SUP0001', 'NOTA-BY.0028-190625', '2017-07-04', '2017-07-04', 'CASH', 3084000, 0, '', '0', 3084000, 0, 'LUNAS', 'Admin'),
('BY.0020-190625', 'SUP0002', 'NOTA-BY.0029-190625', '2017-08-18', '2017-08-18', 'CASH', 4584000, 0, '', '0', 4584000, 0, 'LUNAS', 'Admin'),
('BY.0021-190625', 'SUP0002', 'NOTA-BY.0030-190625', '2017-09-18', '2017-09-18', 'CASH', 6084000, 0, '', '0', 6084000, 0, 'LUNAS', 'Admin'),
('BY.0022-190625', 'SUP0001', 'NOTA-BY.0031-190625', '2017-10-11', '2017-10-11', 'CASH', 3084000, 0, '', '0', 3084000, 0, 'LUNAS', 'Admin'),
('BY.0023-190625', 'SUP0004', 'NOTA-BY.0032-190625', '2017-11-02', '2017-11-02', 'CASH', 4884000, 0, '', '0', 4884000, 0, 'LUNAS', 'Admin'),
('BY.0024-190625', 'SUP0001', 'NOTA-BY.0033-190625', '2017-12-13', '2017-12-13', 'CASH', 3084000, 0, '', '0', 3084000, 0, 'LUNAS', 'Admin'),
('BY.0025-190625', 'SUP0001', 'NOTA-BY.0034-190625', '2018-01-01', '2018-01-01', 'CASH', 3384000, 0, '', '0', 3384000, 0, 'LUNAS', 'Admin'),
('BY.0026-190625', 'SUP0001', 'NOTA-BY.0035-190625', '2018-02-09', '2018-02-09', 'CASH', 10968000, 0, '', '0', 10968000, 0, 'LUNAS', 'Admin'),
('BY.0027-190625', 'SUP0001', 'NOTA-BY.0036-190625', '2018-03-14', '2018-03-14', 'CASH', 5826000, 0, '', '0', 5826000, 0, 'LUNAS', 'Admin'),
('BY.0028-190625', 'SUP0002', 'NOTA-BY.0038-190625', '2018-04-17', '2018-04-17', 'CASH', 7446000, 0, '', '0', 7446000, 0, 'LUNAS', 'Admin'),
('BY.0029-190625', 'SUP0004', 'NOTA-BY.0040-190625', '2018-05-11', '2018-05-11', 'CASH', 2336000, 0, '', '0', 2336000, 0, 'LUNAS', 'Admin'),
('BY.0030-190625', 'SUP0001', 'NOTA-BY.0041-190625', '2018-06-20', '2018-06-20', 'KREDIT', 5946000, 0, '', '0', 4000000, 1946000, 'UTANG', 'Admin'),
('BY.0031-190625', 'SUP0002', 'NOTA-BY.0043-190625', '2018-07-03', '2018-07-03', 'CASH', 2442000, 0, '', '0', 2442000, 0, 'LUNAS', 'Admin'),
('BY.0032-190625', 'SUP0001', 'NOTA-BY.0044-190625', '2018-08-09', '2018-08-09', 'KREDIT', 5640000, 0, '', '0', 3000000, 2640000, 'UTANG', 'Admin'),
('BY.0033-190625', 'SUP0002', 'NOTA-BY.0045-190625', '2018-09-17', '2018-09-17', 'CASH', 4584000, 0, '', '0', 4584000, 0, 'LUNAS', 'Admin'),
('BY.0034-190625', 'SUP0001', 'NOTA-BY.0047-190625', '2018-10-04', '2018-10-04', 'CASH', 3384000, 0, '', '0', 3384000, 0, 'LUNAS', 'Admin'),
('BY.0035-190625', 'SUP0004', 'NOTA-BY.0048-190625', '2018-11-18', '2018-11-18', 'KREDIT', 1332000, 0, '', '0', 850000, 482000, 'UTANG', 'Admin'),
('BY.0036-190625', 'SUP0001', 'NOTA-BY.0049-190625', '2018-12-08', '2018-12-08', 'KREDIT', 5640000, 0, '', '0', 2840000, 2800000, 'UTANG', 'Admin'),
('BY.0037-190625', 'SUP0001', 'NOTA-BY.0050-190625', '2019-01-03', '2019-01-03', 'CASH', 1692000, 0, '', '0', 1692000, 0, 'LUNAS', 'Admin'),
('BY.0038-190625', 'SUP0001', 'NOTA-BY.0051-190625', '2019-02-07', '2019-02-07', 'CASH', 4884000, 0, '', '0', 4884000, 0, 'LUNAS', 'Admin'),
('BY.0039-190625', 'SUP0001', 'NOTA-BY.0052-190625', '2019-03-13', '2019-03-13', 'KREDIT', 6168000, 0, '', '0', 6000000, 168000, 'UTANG', 'Admin'),
('BY.0040-190625', 'SUP0001', 'NOTA-BY.0053-190625', '2019-04-11', '2019-04-11', 'CASH', 3056000, 0, '', '0', 3056000, 0, 'LUNAS', 'Admin'),
('BY.0041-190625', 'SUP0001', 'NOTA-BY.0054-190625', '2019-05-10', '2019-05-10', 'KREDIT', 3084000, 0, '', '0', 1200000, 1884000, 'UTANG', 'Admin'),
('BY.0042-190625', 'SUP0004', 'NOTA-BY.0055-190625', '2019-06-06', '2019-06-06', 'CASH', 3588000, 0, '', '0', 3588000, 0, 'LUNAS', 'Admin'),
('BY.0043-190625', 'SUP0001', 'NOTA-BY.0057-190625', '2019-07-13', '2019-07-13', 'CASH', 2184000, 0, '', '0', 2184000, 0, 'LUNAS', 'Admin'),
('BY.0044-190625', 'SUP0001', 'NOTA-BY.0058-190625', '2019-08-12', '2019-08-12', 'CASH', 2742000, 0, '', '0', 2742000, 0, 'LUNAS', 'Admin'),
('BY.0045-190625', 'SUP0002', 'NOTA-BY.0059-190625', '2019-09-05', '2019-09-05', 'KREDIT', 6084000, 0, '', '0', 5600000, 484000, 'UTANG', 'Admin'),
('BY.0046-190625', 'SUP0004', 'NOTA-BY.0060-190625', '2019-10-17', '2019-10-17', 'CASH', 2035000, 0, '', '0', 2035000, 0, 'LUNAS', 'Admin'),
('BY.0047-190625', 'SUP0004', 'NOTA-BY.0061-190625', '2019-11-16', '2019-11-16', 'KREDIT', 3384000, 0, '', '0', 2000000, 1384000, 'UTANG', 'Admin'),
('BY.0048-190625', 'SUP0001', 'NOTA-BY.0062-190625', '2019-12-01', '2019-12-01', 'KREDIT', 4056000, 0, '', '0', 2700000, 1356000, 'UTANG', 'Admin'),
('BY.0049-190704', 'SUP0005', 'NOTA-BY.0063-190704', '2019-07-04', '2019-07-04', 'CASH', 3624000, 24, '', '0', 3624000, 0, 'LUNAS', 'Admin');

-- --------------------------------------------------------

--
-- Table structure for table `pembelian_detail`
--

CREATE TABLE `pembelian_detail` (
  `ID_BARANG` varchar(10) NOT NULL,
  `ID_SUPPLIER` varchar(10) NOT NULL,
  `ID_DETAIL` varchar(30) NOT NULL,
  `NOTA_PEMBELIAN` varchar(30) DEFAULT NULL,
  `TGL_BELI_DETAIL` datetime DEFAULT NULL,
  `TGL_BELI` date DEFAULT NULL,
  `HARGA_BELI_BARANG` int(11) DEFAULT NULL,
  `QTY_BELI` int(11) DEFAULT NULL,
  `TOTAL_HARGA_BELI` int(11) DEFAULT NULL,
  `MASUK` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `pembelian_detail`
--

INSERT INTO `pembelian_detail` (`ID_BARANG`, `ID_SUPPLIER`, `ID_DETAIL`, `NOTA_PEMBELIAN`, `TGL_BELI_DETAIL`, `TGL_BELI`, `HARGA_BELI_BARANG`, `QTY_BELI`, `TOTAL_HARGA_BELI`, `MASUK`) VALUES
('BRG0001', 'SUP0001', 'PD.0001-190624', 'NOTA-BY.0001-190624', '2016-01-13 23:10:38', '2016-01-13', 282000, 12, 3384000, 12),
('BRG0008', 'SUP0001', 'PD.0002-190624', 'NOTA-BY.0001-190624', '2016-01-13 23:10:38', '2016-01-13', 282000, 6, 1692000, 6),
('BRG0007', 'SUP0001', 'PD.0003-190624', 'NOTA-BY.0003-190624', '2016-02-10 23:10:38', '2016-02-10', 182000, 12, 2184000, 12),
('BRG0009', 'SUP0001', 'PD.0004-190624', 'NOTA-BY.0003-190624', '2016-02-10 23:10:38', '2016-02-10', 222000, 12, 2664000, 12),
('BRG0011', 'SUP0001', 'PD.0005-190624', 'NOTA-BY.0005-190624', '2016-03-24 23:10:38', '2016-03-24', 227000, 12, 2724000, 12),
('BRG0012', 'SUP0001', 'PD.0006-190624', 'NOTA-BY.0005-190624', '2016-03-24 23:10:38', '2016-03-24', 507000, 12, 6084000, 12),
('BRG0010', 'SUP0001', 'PD.0007-190624', 'NOTA-BY.0007-190624', '2016-04-13 23:10:38', '2016-04-13', 257000, 12, 3084000, 12),
('BRG0014', 'SUP0002', 'PD.0008-190624', 'NOTA-BY.0008-190624', '2016-05-18 23:10:38', '2016-05-18', 292000, 12, 3504000, 12),
('BRG0008', 'SUP0002', 'PD.0009-190624', 'NOTA-BY.0008-190624', '2016-05-18 23:10:38', '2016-05-18', 282000, 12, 3384000, 12),
('BRG0007', 'SUP0002', 'PD.0010-190624', 'NOTA-BY.0010-190624', '2016-06-16 23:10:38', '2016-06-16', 182000, 12, 2184000, 12),
('BRG0009', 'SUP0002', 'PD.0011-190624', 'NOTA-BY.0010-190624', '2016-06-16 23:10:38', '2016-06-16', 222000, 12, 2664000, 12),
('BRG0005', 'SUP0001', 'PD.0012-190624', 'NOTA-BY.0012-190624', '2016-07-21 23:10:38', '2016-07-21', 407000, 12, 4884000, 12),
('BRG0010', 'SUP0004', 'PD.0013-190624', 'NOTA-BY.0013-190624', '2016-08-25 23:10:38', '2016-08-25', 257000, 12, 3084000, 12),
('BRG0014', 'SUP0004', 'PD.0014-190624', 'NOTA-BY.0013-190624', '2016-08-25 23:10:38', '2016-08-25', 292000, 12, 3504000, 12),
('BRG0008', 'SUP0001', 'PD.0015-190624', 'NOTA-BY.0015-190624', '2016-09-30 23:10:38', '2016-09-30', 282000, 12, 3384000, 12),
('BRG0001', 'SUP0001', 'PD.0016-190624', 'NOTA-BY.0015-190624', '2016-09-30 23:10:38', '2016-09-30', 282000, 12, 3384000, 12),
('BRG0006', 'SUP0001', 'PD.0017-190624', 'NOTA-BY.0015-190624', '2016-09-30 23:10:38', '2016-09-30', 382000, 12, 4584000, 12),
('BRG0011', 'SUP0002', 'PD.0018-190624', 'NOTA-BY.0018-190624', '2016-10-13 23:10:38', '2016-10-13', 227000, 12, 2724000, 12),
('BRG0005', 'SUP0004', 'PD.0019-190624', 'NOTA-BY.0019-190624', '2016-11-18 23:10:38', '2016-11-18', 407000, 12, 4884000, 12),
('BRG0002', 'SUP0004', 'PD.0020-190624', 'NOTA-BY.0019-190624', '2016-11-18 23:10:38', '2016-11-18', 457000, 12, 5484000, 12),
('BRG0004', 'SUP0001', 'PD.0021-190624', 'NOTA-BY.0021-190624', '2016-12-12 23:10:38', '2016-12-12', 282000, 12, 3384000, 12),
('BRG0001', 'SUP0002', 'PD.0022-190624', 'NOTA-BY.0022-190624', '2017-01-11 23:56:40', '2017-01-11', 282000, 12, 3384000, 12),
('BRG0002', 'SUP0001', 'PD.0023-190624', 'NOTA-BY.0023-190624', '2017-02-16 23:58:37', '2017-02-16', 457000, 12, 5484000, 12),
('BRG0008', 'SUP0002', 'PD.0024-190624', 'NOTA-BY.0024-190624', '2017-03-15 23:58:37', '2017-03-15', 282000, 12, 3384000, 12),
('BRG0011', 'SUP0002', 'PD.0025-190624', 'NOTA-BY.0025-190624', '2017-04-13 23:58:37', '2017-04-13', 227000, 12, 2724000, 12),
('BRG0002', 'SUP0004', 'PD.0026-190624', 'NOTA-BY.0026-190625', '2017-05-04 23:58:37', '2017-05-04', 457000, 12, 5484000, 12),
('BRG0004', 'SUP0001', 'PD.0027-190625', 'NOTA-BY.0027-190625', '2017-06-04 23:58:37', '2017-06-04', 282000, 12, 3384000, 12),
('BRG0013', 'SUP0001', 'PD.0028-190625', 'NOTA-BY.0028-190625', '2017-07-04 23:58:37', '2017-07-04', 257000, 12, 3084000, 12),
('BRG0006', 'SUP0002', 'PD.0029-190625', 'NOTA-BY.0029-190625', '2017-08-18 23:58:37', '2017-08-18', 382000, 12, 4584000, 12),
('BRG0012', 'SUP0002', 'PD.0030-190625', 'NOTA-BY.0030-190625', '2017-09-18 23:58:37', '2017-09-18', 507000, 12, 6084000, 12),
('BRG0013', 'SUP0001', 'PD.0031-190625', 'NOTA-BY.0031-190625', '2017-10-11 23:58:37', '2017-10-11', 257000, 12, 3084000, 12),
('BRG0005', 'SUP0004', 'PD.0032-190625', 'NOTA-BY.0032-190625', '2017-11-02 23:58:37', '2017-11-02', 407000, 12, 4884000, 12),
('BRG0010', 'SUP0001', 'PD.0033-190625', 'NOTA-BY.0033-190625', '2017-12-13 23:58:37', '2017-12-13', 257000, 12, 3084000, 12),
('BRG0001', 'SUP0001', 'PD.0034-190625', 'NOTA-BY.0034-190625', '2018-01-01 23:58:37', '2018-01-01', 282000, 12, 3384000, 12),
('BRG0002', 'SUP0001', 'PD.0035-190625', 'NOTA-BY.0035-190625', '2018-02-09 23:58:37', '2018-02-09', 457000, 24, 10968000, 24),
('BRG0004', 'SUP0001', 'PD.0036-190625', 'NOTA-BY.0036-190625', '2018-03-14 23:58:37', '2018-03-14', 282000, 12, 3384000, 12),
('BRG0005', 'SUP0001', 'PD.0037-190625', 'NOTA-BY.0036-190625', '2018-03-14 23:58:37', '2018-03-14', 407000, 6, 2442000, 6),
('BRG0011', 'SUP0002', 'PD.0038-190625', 'NOTA-BY.0038-190625', '2018-04-17 23:58:37', '2018-04-17', 227000, 6, 1362000, 6),
('BRG0012', 'SUP0002', 'PD.0039-190625', 'NOTA-BY.0038-190625', '2018-04-17 23:58:37', '2018-04-17', 507000, 12, 6084000, 12),
('BRG0014', 'SUP0004', 'PD.0040-190625', 'NOTA-BY.0040-190625', '2018-05-11 23:58:37', '2018-05-11', 292000, 8, 2336000, 8),
('BRG0011', 'SUP0001', 'PD.0041-190625', 'NOTA-BY.0041-190625', '2018-06-20 23:58:37', '2018-06-20', 227000, 6, 1362000, 6),
('BRG0006', 'SUP0001', 'PD.0042-190625', 'NOTA-BY.0041-190625', '2018-06-20 23:58:37', '2018-06-20', 382000, 12, 4584000, 12),
('BRG0005', 'SUP0002', 'PD.0043-190625', 'NOTA-BY.0043-190625', '2018-07-03 23:58:37', '2018-07-03', 407000, 6, 2442000, 6),
('BRG0001', 'SUP0001', 'PD.0044-190625', 'NOTA-BY.0044-190625', '2018-08-09 23:58:37', '2018-08-09', 282000, 20, 5640000, 20),
('BRG0010', 'SUP0002', 'PD.0045-190625', 'NOTA-BY.0045-190625', '2018-09-17 23:58:37', '2018-09-17', 257000, 6, 1542000, 6),
('BRG0012', 'SUP0002', 'PD.0046-190625', 'NOTA-BY.0045-190625', '2018-09-17 23:58:37', '2018-09-17', 507000, 6, 3042000, 6),
('BRG0004', 'SUP0001', 'PD.0047-190625', 'NOTA-BY.0047-190625', '2018-10-04 23:58:37', '2018-10-04', 282000, 12, 3384000, 12),
('BRG0009', 'SUP0004', 'PD.0048-190625', 'NOTA-BY.0048-190625', '2018-11-18 23:58:37', '2018-11-18', 222000, 6, 1332000, 6),
('BRG0001', 'SUP0001', 'PD.0049-190625', 'NOTA-BY.0049-190625', '2018-12-08 23:58:37', '2018-12-08', 282000, 20, 5640000, 20),
('BRG0004', 'SUP0001', 'PD.0050-190625', 'NOTA-BY.0050-190625', '2019-01-03 23:58:37', '2019-01-03', 282000, 6, 1692000, 6),
('BRG0005', 'SUP0001', 'PD.0051-190625', 'NOTA-BY.0051-190625', '2019-02-07 23:58:37', '2019-02-07', 407000, 12, 4884000, 12),
('BRG0010', 'SUP0001', 'PD.0052-190625', 'NOTA-BY.0052-190625', '2019-03-13 23:58:37', '2019-03-13', 257000, 24, 6168000, 24),
('BRG0006', 'SUP0001', 'PD.0053-190625', 'NOTA-BY.0053-190625', '2019-04-11 23:58:37', '2019-04-11', 382000, 8, 3056000, 8),
('BRG0013', 'SUP0001', 'PD.0054-190625', 'NOTA-BY.0054-190625', '2019-05-10 23:58:37', '2019-05-10', 257000, 12, 3084000, 12),
('BRG0002', 'SUP0004', 'PD.0055-190625', 'NOTA-BY.0055-190625', '2019-06-06 23:58:37', '2019-06-06', 457000, 6, 2742000, 6),
('BRG0001', 'SUP0004', 'PD.0056-190625', 'NOTA-BY.0055-190625', '2019-06-06 23:58:37', '2019-06-06', 282000, 3, 846000, 3),
('BRG0007', 'SUP0001', 'PD.0057-190625', 'NOTA-BY.0057-190625', '2019-07-13 23:58:37', '2019-07-13', 182000, 12, 2184000, 12),
('BRG0002', 'SUP0001', 'PD.0058-190625', 'NOTA-BY.0058-190625', '2019-08-12 23:58:37', '2019-08-12', 457000, 6, 2742000, 6),
('BRG0012', 'SUP0002', 'PD.0059-190625', 'NOTA-BY.0059-190625', '2019-09-05 23:58:37', '2019-09-05', 507000, 12, 6084000, 12),
('BRG0005', 'SUP0004', 'PD.0060-190625', 'NOTA-BY.0060-190625', '2019-10-17 23:58:37', '2019-10-17', 407000, 5, 2035000, 5),
('BRG0004', 'SUP0004', 'PD.0061-190625', 'NOTA-BY.0061-190625', '2019-11-16 23:58:37', '2019-11-16', 282000, 12, 3384000, 12),
('BRG0012', 'SUP0001', 'PD.0062-190625', 'NOTA-BY.0062-190625', '2019-12-01 23:58:37', '2019-12-01', 507000, 8, 4056000, 8),
('BRG0003', 'SUP0005', 'PD.0063-190704', 'NOTA-BY.0063-190704', '2019-07-04 02:47:13', '2019-07-04', 282000, 12, 3384000, 0),
('BRG0017', 'SUP0005', 'PD.0064-190704', 'NOTA-BY.0063-190704', '2019-07-04 02:47:13', '2019-07-04', 20000, 12, 240000, 0);

-- --------------------------------------------------------

--
-- Table structure for table `pengguna`
--

CREATE TABLE `pengguna` (
  `USERNAME` varchar(20) NOT NULL,
  `PASSWORD` varchar(255) DEFAULT NULL,
  `NAMA_DEPAN` varchar(30) DEFAULT NULL,
  `NAMA_BELAKANG` varchar(50) DEFAULT NULL,
  `HAK_AKSES` varchar(20) DEFAULT NULL,
  `DESK` varchar(255) NOT NULL,
  `FOTO` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `pengguna`
--

INSERT INTO `pengguna` (`USERNAME`, `PASSWORD`, `NAMA_DEPAN`, `NAMA_BELAKANG`, `HAK_AKSES`, `DESK`, `FOTO`) VALUES
('admin', 'c4ca4238a0b923820dcc509a6f75849b', 'Admin', 'Master', 'Admin', 'D:\\Program\\220px-Logo_stikiindonesia.jpg', '220px-Logo_stikiindonesia.jpg'),
('andika', '7e51eea5fa101ed4dade9ad3a7a072bb', 'Andika', 'Pranayoga', 'Penjualan', 'D:\\Program\\Andika.jpg', 'Andika.jpg'),
('mahasiswa', '5787be38ee03a9ae5360f54d9026465f', 'Mahasiswa', 'Teladan', 'Admin', '', ''),
('rebintang', '202cb962ac59075b964b07152d234b70', 'Rebintang', 'Pratika Sari', 'Inventory', 'D:\\Program\\smile-simple-background_23-2148051319.jpg', 'smile-simple-background_23-2148051319.jpg');

-- --------------------------------------------------------

--
-- Table structure for table `penjualan`
--

CREATE TABLE `penjualan` (
  `ID_PENJUALAN` varchar(30) NOT NULL,
  `ID_PELANGGAN` varchar(10) DEFAULT NULL,
  `NO_NOTA` varchar(30) DEFAULT NULL,
  `TGL_TRANSAKSI` date DEFAULT NULL,
  `TGL_PEMBAYARAN` date DEFAULT NULL,
  `JENIS_PEMBAYARAN` varchar(10) DEFAULT NULL,
  `GRAND_TOTAL` int(11) DEFAULT NULL,
  `PAJAK` varchar(5) NOT NULL,
  `DISKON` varchar(5) NOT NULL,
  `BAYAR` int(11) DEFAULT NULL,
  `SISA_TAGIHAN` int(11) DEFAULT NULL,
  `JATUH_TEMPO` date DEFAULT NULL,
  `STATUS_TRANSAKSI` varchar(20) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `penjualan`
--

INSERT INTO `penjualan` (`ID_PENJUALAN`, `ID_PELANGGAN`, `NO_NOTA`, `TGL_TRANSAKSI`, `TGL_PEMBAYARAN`, `JENIS_PEMBAYARAN`, `GRAND_TOTAL`, `PAJAK`, `DISKON`, `BAYAR`, `SISA_TAGIHAN`, `JATUH_TEMPO`, `STATUS_TRANSAKSI`) VALUES
('SL.0001-190624', 'CUS0001', 'No.0001-190624', '2016-01-01', '2016-01-01', 'CASH', 7050000, '-', '0 %', 7050000, 0, '2019-06-24', 'LUNAS'),
('SL.0002-190624', 'CUS0002', 'No.0003-190624', '2016-02-10', '2019-06-25', 'KREDIT', 3600000, '-', '0 %', 3600000, 0, '2019-06-24', 'LUNAS'),
('SL.0003-190624', 'CUS0003', 'No.0005-190624', '2016-03-23', '2016-03-23', 'KREDIT', 1875000, '-', '0 %', 1000000, 875000, '2019-06-24', 'UTANG'),
('SL.0004-190624', 'CUS0003', 'No.0007-190624', '2016-04-29', '2016-04-29', 'CASH', 2905000, '-', '0 %', 2905000, 0, '2019-06-24', 'LUNAS'),
('SL.0005-190624', 'CUS0009', 'No.0010-190624', '2016-05-20', '2016-05-20', 'CASH', 3450000, '-', '0 %', 3450000, 0, '2019-06-24', 'LUNAS'),
('SL.0006-190624', 'CUS0012', 'No.0011-190624', '2016-06-07', '2016-06-07', 'KREDIT', 3000000, '-', '0 %', 2500000, 500000, '2019-06-24', 'UTANG'),
('SL.0007-190624', 'CUS0005', 'No.0013-190624', '2016-07-31', '2016-07-31', 'CASH', 2280000, '-', '0 %', 2280000, 0, '2019-06-24', 'LUNAS'),
('SL.0008-190624', 'CUS0014', 'No.0015-190624', '2016-08-17', '2016-08-17', 'CASH', 3900000, '-', '0 %', 3900000, 0, '2019-06-24', 'LUNAS'),
('SL.0009-190624', 'CUS0011', 'No.0016-190624', '2016-09-18', '2016-09-18', 'KREDIT', 5925000, '-', '0 %', 2500000, 3425000, '2019-06-24', 'UTANG'),
('SL.0010-190624', 'CUS0015', 'No.0018-190624', '2016-10-27', '2016-10-27', 'CASH', 2550000, '-', '0 %', 2550000, 0, '2019-06-24', 'LUNAS'),
('SL.0011-190624', 'CUS0006', 'No.0021-190624', '2016-11-14', '2016-11-14', 'CASH', 4050000, '-', '0 %', 4050000, 0, '2019-06-24', 'LUNAS'),
('SL.0012-190624', 'CUS0010', 'No.0023-190624', '2016-12-16', '2016-12-16', 'KREDIT', 3480000, '-', '0 %', 2000000, 1480000, '2019-06-24', 'UTANG'),
('SL.0013-190624', 'CUS0013', 'No.0024-190624', '2017-01-11', '2017-01-11', 'CASH', 2100000, '-', '0 %', 2100000, 0, '2019-06-24', 'LUNAS'),
('SL.0014-190624', 'CUS0004', 'No.0025-190624', '2017-02-20', '2017-02-20', 'KREDIT', 4950000, '-', '0 %', 3200000, 1750000, '2019-06-24', 'UTANG'),
('SL.0015-190624', 'CUS0002', 'No.0027-190624', '2017-03-18', '2017-03-18', 'CASH', 4575000, '-', '0 %', 4575000, 0, '2019-06-24', 'LUNAS'),
('SL.0016-190624', 'CUS0011', 'No.0029-190624', '2017-04-26', '2017-04-26', 'CASH', 4800000, '-', '0 %', 4800000, 0, '2019-06-24', 'LUNAS'),
('SL.0017-190624', 'CUS0012', 'No.0032-190624', '2017-05-18', '2017-05-18', 'KREDIT', 5160000, '-', '0 %', 3000000, 2160000, '2019-06-24', 'UTANG'),
('SL.0018-190624', 'CUS0007', 'No.0034-190624', '2017-06-19', '2017-06-19', 'CASH', 2925000, '-', '0 %', 2925000, 0, '2019-06-24', 'LUNAS'),
('SL.0019-190624', 'CUS0003', 'No.0036-190624', '2017-07-20', '2017-07-20', 'KREDIT', 3270000, '-', '0 %', 2600000, 670000, '2019-06-24', 'UTANG'),
('SL.0020-190624', 'CUS0002', 'No.0038-190624', '2017-08-25', '2017-08-25', 'CASH', 4950000, '-', '0 %', 4950000, 0, '2019-06-24', 'LUNAS'),
('SL.0021-190624', 'CUS0009', 'No.0040-190624', '2017-09-22', '2017-09-22', 'KREDIT', 5550000, '-', '0 %', 2300000, 3250000, '2019-06-24', 'UTANG'),
('SL.0022-190624', 'CUS0011', 'No.0042-190624', '2017-10-12', '2017-10-12', 'CASH', 5670000, '-', '0 %', 5670000, 0, '2019-06-24', 'LUNAS'),
('SL.0023-190624', 'CUS0013', 'No.0044-190624', '2017-11-17', '2017-11-17', 'CASH', 3000000, '-', '0 %', 3000000, 0, '2019-06-24', 'LUNAS'),
('SL.0024-190624', 'CUS0006', 'No.0045-190624', '2017-12-25', '2017-12-25', 'KREDIT', 5190000, '-', '0 %', 4800000, 390000, '2019-06-24', 'UTANG'),
('SL.0025-190624', 'CUS0001', 'No.0048-190624', '2018-01-25', '2018-01-25', 'CASH', 4200000, '-', '0 %', 4200000, 0, '2019-06-24', 'LUNAS'),
('SL.0026-190624', 'CUS0002', 'No.0049-190624', '2018-02-19', '2018-02-19', 'CASH', 4800000, '-', '0 %', 4800000, 0, '2019-06-24', 'LUNAS'),
('SL.0027-190624', 'CUS0003', 'No.0051-190624', '2018-03-18', '2018-03-18', 'KREDIT', 2890000, '-', '0 %', 2000000, 890000, '2019-06-24', 'UTANG'),
('SL.0028-190624', 'CUS0004', 'No.0053-190624', '2018-04-20', '2018-04-20', 'CASH', 2070000, '-', '0 %', 2070000, 0, '2019-06-24', 'LUNAS'),
('SL.0029-190624', 'CUS0006', 'No.0055-190624', '2018-05-24', '2018-05-24', 'CASH', 2025000, '-', '0 %', 2025000, 0, '2019-06-24', 'LUNAS'),
('SL.0030-190624', 'CUS0010', 'No.0057-190624', '2018-06-28', '2018-06-28', 'CASH', 2850000, '-', '0 %', 2850000, 0, '2019-06-24', 'LUNAS'),
('SL.0031-190624', 'CUS0012', 'No.0058-190624', '2018-07-18', '2018-07-18', 'KREDIT', 3840000, '-', '0 %', 2500000, 1340000, '2019-06-24', 'UTANG'),
('SL.0032-190624', 'CUS0008', 'No.0060-190624', '2018-08-17', '2018-08-17', 'CASH', 4660000, '-', '0 %', 4660000, 0, '2019-06-24', 'LUNAS'),
('SL.0033-190624', 'CUS0005', 'No.0063-190624', '2018-09-18', '2018-09-18', 'CASH', 2985000, '-', '0 %', 2985000, 0, '2019-06-24', 'LUNAS'),
('SL.0034-190624', 'CUS0014', 'No.0065-190624', '2018-10-18', '2018-10-18', 'KREDIT', 3000000, '-', '0 %', 2800000, 200000, '2019-06-24', 'UTANG'),
('SL.0035-190624', 'CUS0009', 'No.0066-190624', '2018-11-19', '2018-11-19', 'CASH', 1925000, '-', '0 %', 1925000, 0, '2019-06-24', 'LUNAS'),
('SL.0036-190624', 'CUS0011', 'No.0068-190624', '2018-12-28', '2018-12-28', 'KREDIT', 2850000, '-', '0 %', 1500000, 1350000, '2019-06-24', 'UTANG'),
('SL.0037-190624', 'CUS0012', 'No.0069-190624', '2019-01-18', '2019-01-18', 'CASH', 3900000, '-', '0 %', 3900000, 0, '2019-06-24', 'LUNAS'),
('SL.0038-190624', 'CUS0010', 'No.0070-190624', '2019-02-21', '2019-02-21', 'KREDIT', 2100000, '-', '0 %', 800000, 1300000, '2019-06-24', 'UTANG'),
('SL.0039-190624', 'CUS0007', 'No.0071-190624', '2019-03-16', '2019-03-16', 'CASH', 3540000, '-', '0 %', 3540000, 0, '2019-06-24', 'LUNAS'),
('SL.0040-190624', 'CUS0015', 'No.0072-190624', '2019-04-17', '2019-04-17', 'CASH', 2100000, '-', '0 %', 2100000, 0, '2019-06-24', 'LUNAS'),
('SL.0041-190624', 'CUS0009', 'No.0073-190624', '2019-05-24', '2019-05-24', 'KREDIT', 4950000, '-', '0 %', 3500000, 1450000, '2019-06-24', 'UTANG'),
('SL.0042-190624', 'CUS0013', 'No.0075-190624', '2019-06-14', '2019-06-14', 'CASH', 5700000, '-', '0 %', 5700000, 0, '2019-06-24', 'LUNAS'),
('SL.0043-190624', 'CUS0009', 'No.0076-190624', '2019-07-26', '2019-07-26', 'KREDIT', 2700000, '-', '0 %', 1200000, 1500000, '2019-06-24', 'UTANG'),
('SL.0044-190624', 'CUS0012', 'No.0077-190624', '2019-08-05', '2019-08-05', 'CASH', 3600000, '-', '0 %', 3600000, 0, '2019-06-24', 'LUNAS'),
('SL.0045-190624', 'CUS0001', 'No.0079-190624', '2019-09-19', '2019-09-19', 'CASH', 2100000, '-', '0 %', 2100000, 0, '2019-06-24', 'LUNAS'),
('SL.0046-190624', 'CUS0004', 'No.0080-190624', '2019-10-23', '2019-10-23', 'KREDIT', 4950000, '-', '0 %', 4000000, 950000, '2019-06-24', 'UTANG'),
('SL.0047-190624', 'CUS0013', 'No.0082-190624', '2019-11-03', '2019-11-03', 'CASH', 1920000, '-', '0 %', 1920000, 0, '2019-06-24', 'LUNAS'),
('SL.0048-190624', 'CUS0003', 'No.0084-190624', '2019-12-31', '2019-12-31', 'KREDIT', 4125000, '-', '0 %', 2950000, 1175000, '2019-06-24', 'UTANG'),
('SL.0049-190624', 'CUS0001', 'No.0086-190624', '2019-06-24', '2019-06-24', 'CASH', 4200000, '-', '0 %', 4200000, 0, '2019-06-24', 'LUNAS');

-- --------------------------------------------------------

--
-- Table structure for table `retur_pembelian`
--

CREATE TABLE `retur_pembelian` (
  `ID_RETUR_PEMBELIAN` varchar(30) NOT NULL,
  `ID_BARANG` varchar(10) DEFAULT NULL,
  `ID_SUPPLIER` varchar(10) DEFAULT NULL,
  `ID_PEMBELIAN` varchar(30) DEFAULT NULL,
  `QTY_NOTA_BELI` int(11) DEFAULT NULL,
  `QTY_RETUR_BELI` int(11) DEFAULT NULL,
  `TOTAL_RETUR_BELI` int(11) DEFAULT NULL,
  `TANGGAL_RETUR_BELI` date DEFAULT NULL,
  `ALASAN_RETUR_BELI` varchar(255) NOT NULL,
  `KETERANGAN_RETUR` varchar(100) NOT NULL,
  `STATUS_RETUR_BELI` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `retur_pembelian`
--

INSERT INTO `retur_pembelian` (`ID_RETUR_PEMBELIAN`, `ID_BARANG`, `ID_SUPPLIER`, `ID_PEMBELIAN`, `QTY_NOTA_BELI`, `QTY_RETUR_BELI`, `TOTAL_RETUR_BELI`, `TANGGAL_RETUR_BELI`, `ALASAN_RETUR_BELI`, `KETERANGAN_RETUR`, `STATUS_RETUR_BELI`) VALUES
('RB.0001-190623', 'BRG0004', 'SUP0002', 'BY.0004-190623', 12, 2, 564000, '2019-06-23', 'pecah ', 'Tukar Barang', 'Selesai'),
('RB.0002-190625', 'BRG0001', 'SUP0001', 'BY.0001-190624', 12, 1, 282000, '2019-06-25', 'Segel Tutup Rusak', 'Tukar Barang', 'Ditunda'),
('RB.0003-190625', 'BRG0014', 'SUP0004', 'BY.0008-190624', 12, 1, 292000, '2019-06-25', 'Rusak', 'Tukar Barang', 'Ditunda'),
('RB.0004-190704', 'BRG0005', 'SUP0004', 'BY.0046-190625', 5, 1, 407000, '2019-07-04', 'Segel rusak', 'Tukar Barang', 'Ditunda');

--
-- Triggers `retur_pembelian`
--
DELIMITER $$
CREATE TRIGGER `Stok_Berkurang_Saat_Retur_Beli` AFTER INSERT ON `retur_pembelian` FOR EACH ROW BEGIN
UPDATE barang SET STOK_BARANG = STOK_BARANG - new.QTY_RETUR_BELI
WHERE ID_BARANG = new.ID_BARANG;
END
$$
DELIMITER ;

-- --------------------------------------------------------

--
-- Table structure for table `retur_penjualan`
--

CREATE TABLE `retur_penjualan` (
  `ID_RETUR_PENJUALAN` varchar(30) NOT NULL,
  `ID_BARANG` varchar(10) DEFAULT NULL,
  `ID_PELANGGAN` varchar(10) DEFAULT NULL,
  `ID_PENJUALAN` varchar(30) DEFAULT NULL,
  `QTY_NOTA` int(11) DEFAULT NULL,
  `QTY_RETUR` int(11) DEFAULT NULL,
  `TOTAL_RETUR` int(11) DEFAULT NULL,
  `TANGGAL_RETUR` date DEFAULT NULL,
  `ALASAN_RETUR` varchar(255) NOT NULL,
  `KETERANGAN` varchar(100) NOT NULL,
  `STATUS_RETUR` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `retur_penjualan`
--

INSERT INTO `retur_penjualan` (`ID_RETUR_PENJUALAN`, `ID_BARANG`, `ID_PELANGGAN`, `ID_PENJUALAN`, `QTY_NOTA`, `QTY_RETUR`, `TOTAL_RETUR`, `TANGGAL_RETUR`, `ALASAN_RETUR`, `KETERANGAN`, `STATUS_RETUR`) VALUES
('RJ.0001-190625', 'BRG0001', 'CUS0001', 'SL.0001-190624', 12, 1, 350000, '2019-06-25', 'Segel rusak', 'Tukar Barang', 'Selesai'),
('RJ.0002-190625', 'BRG0017', 'CUS0005', 'SL.0007-190624', 6, 2, 60000, '2019-06-25', 'Pecah', 'Tukar Barang', 'Ditunda');

--
-- Triggers `retur_penjualan`
--
DELIMITER $$
CREATE TRIGGER `Stok_Bertambah_Saat_Retur_Jual` AFTER INSERT ON `retur_penjualan` FOR EACH ROW BEGIN
UPDATE barang SET STOK_BARANG = STOK_BARANG + new.QTY_RETUR
WHERE ID_BARANG = new.ID_BARANG;
END
$$
DELIMITER ;

-- --------------------------------------------------------

--
-- Table structure for table `stok_opname`
--

CREATE TABLE `stok_opname` (
  `ID_STOK_OPNAME` varchar(20) NOT NULL,
  `ID_BARANG` varchar(10) DEFAULT NULL,
  `TGL_STOK_OPNAME` date DEFAULT NULL,
  `TGL_UBAH_STOK_OPNAME` date NOT NULL,
  `STOK_BRG_OPNAME` int(11) DEFAULT NULL,
  `JUMLAH_BAIK` int(11) DEFAULT NULL,
  `JUMLAH_RUSAK` int(11) DEFAULT NULL,
  `JUMLAH_HILANG` int(11) DEFAULT NULL,
  `SELISIH` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `stok_opname`
--

INSERT INTO `stok_opname` (`ID_STOK_OPNAME`, `ID_BARANG`, `TGL_STOK_OPNAME`, `TGL_UBAH_STOK_OPNAME`, `STOK_BRG_OPNAME`, `JUMLAH_BAIK`, `JUMLAH_RUSAK`, `JUMLAH_HILANG`, `SELISIH`) VALUES
('SO.0001-190625', 'BRG0014', '2019-06-25', '2019-06-25', 163, 162, 1, 0, 1);

-- --------------------------------------------------------

--
-- Table structure for table `supplier`
--

CREATE TABLE `supplier` (
  `ID_SUPPLIER` varchar(10) NOT NULL,
  `NAMA_SUPPLIER` varchar(255) DEFAULT NULL,
  `ALAMAT_SUPPLIER` varchar(255) DEFAULT NULL,
  `NO_TELP_SUPPLIER` varchar(13) DEFAULT NULL,
  `EMAIL_SUPPLIER` varchar(30) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `supplier`
--

INSERT INTO `supplier` (`ID_SUPPLIER`, `NAMA_SUPPLIER`, `ALAMAT_SUPPLIER`, `NO_TELP_SUPPLIER`, `EMAIL_SUPPLIER`) VALUES
('SUP0001', 'PT Pratama Agung Niaga', 'Jl. Mahendradatta No.100A, Denpasar', '03614716381', '-'),
('SUP0002', 'PT Wana Sari', 'Jl. Danau Beratan Gg VI', '0361789123', 'info-wanasari@gmail.com'),
('SUP0003', 'PT maju mundur', 'jalan mertasari no 9', '0831111567669', '-'),
('SUP0004', 'PT. Ayu Dewi', 'Jalan Intaran', '567890', '-'),
('SUP0005', 'PT. MINUM BERALKOHOL', 'Jalan Pemudi 1 no 23x', '098765432', 'minum@gmail.com');

-- --------------------------------------------------------

--
-- Table structure for table `transaksi`
--

CREATE TABLE `transaksi` (
  `ID_BARANG` varchar(10) NOT NULL,
  `ID_PELANGGAN` varchar(10) NOT NULL,
  `ID_TRANSAKSI` varchar(30) NOT NULL,
  `NO_NOTA` varchar(30) DEFAULT NULL,
  `TGL_TRANSAKSI_DETAIL` datetime DEFAULT NULL,
  `TGL_TRANSAKSI` date DEFAULT NULL,
  `HARGA_BARANG` int(11) DEFAULT NULL,
  `QTY` int(11) DEFAULT NULL,
  `TOTAL_HARGA` int(11) DEFAULT NULL,
  `KELUAR` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `transaksi`
--

INSERT INTO `transaksi` (`ID_BARANG`, `ID_PELANGGAN`, `ID_TRANSAKSI`, `NO_NOTA`, `TGL_TRANSAKSI_DETAIL`, `TGL_TRANSAKSI`, `HARGA_BARANG`, `QTY`, `TOTAL_HARGA`, `KELUAR`) VALUES
('BRG0001', 'CUS0001', 'TR.0001-190624', 'No.0001-190624', '2016-01-01 22:17:24', '2016-01-01', 350000, 12, 4200000, 12),
('BRG0005', 'CUS0001', 'TR.0002-190624', 'No.0001-190624', '2016-01-01 22:17:24', '2016-01-01', 475000, 6, 2850000, 6),
('BRG0007', 'CUS0002', 'TR.0003-190624', 'No.0003-190624', '2016-02-10 22:21:03', '2016-02-10', 250000, 6, 1500000, 0),
('BRG0008', 'CUS0002', 'TR.0004-190624', 'No.0003-190624', '2016-02-10 22:21:03', '2016-02-10', 350000, 6, 2100000, 0),
('BRG0010', 'CUS0003', 'TR.0005-190624', 'No.0005-190624', '2016-03-23 22:21:03', '2016-03-23', 325000, 3, 975000, 0),
('BRG0006', 'CUS0003', 'TR.0006-190624', 'No.0005-190624', '2016-03-23 22:21:03', '2016-03-23', 450000, 2, 900000, 0),
('BRG0016', 'CUS0003', 'TR.0007-190624', 'No.0007-190624', '2016-04-29 22:21:03', '2016-04-29', 25000, 12, 300000, 0),
('BRG0011', 'CUS0003', 'TR.0008-190624', 'No.0007-190624', '2016-04-29 22:21:03', '2016-04-29', 295000, 4, 1180000, 0),
('BRG0005', 'CUS0003', 'TR.0009-190624', 'No.0007-190624', '2016-04-29 22:21:03', '2016-04-29', 475000, 3, 1425000, 0),
('BRG0012', 'CUS0009', 'TR.0010-190624', 'No.0010-190624', '2016-05-20 22:21:03', '2016-05-20', 575000, 6, 3450000, 0),
('BRG0015', 'CUS0012', 'TR.0011-190624', 'No.0011-190624', '2016-06-07 22:21:03', '2016-06-07', 250000, 6, 1500000, 0),
('BRG0007', 'CUS0012', 'TR.0012-190624', 'No.0011-190624', '2016-06-07 22:21:03', '2016-06-07', 250000, 6, 1500000, 0),
('BRG0003', 'CUS0005', 'TR.0013-190624', 'No.0013-190624', '2016-07-31 22:21:03', '2016-07-31', 350000, 6, 2100000, 0),
('BRG0017', 'CUS0005', 'TR.0014-190624', 'No.0013-190624', '2016-07-31 22:21:03', '2016-07-31', 30000, 6, 180000, 0),
('BRG0010', 'CUS0014', 'TR.0015-190624', 'No.0015-190624', '2016-08-17 22:21:03', '2016-08-17', 325000, 12, 3900000, 0),
('BRG0004', 'CUS0011', 'TR.0016-190624', 'No.0016-190624', '2016-09-18 22:21:03', '2016-09-18', 350000, 12, 4200000, 0),
('BRG0012', 'CUS0011', 'TR.0017-190624', 'No.0016-190624', '2016-09-18 22:21:03', '2016-09-18', 575000, 3, 1725000, 0),
('BRG0014', 'CUS0015', 'TR.0018-190624', 'No.0018-190624', '2016-10-27 22:21:03', '2016-10-27', 360000, 6, 2160000, 0),
('BRG0016', 'CUS0015', 'TR.0019-190624', 'No.0018-190624', '2016-10-27 22:21:03', '2016-10-27', 25000, 12, 300000, 0),
('BRG0017', 'CUS0015', 'TR.0020-190624', 'No.0018-190624', '2016-10-27 22:21:03', '2016-10-27', 30000, 3, 90000, 0),
('BRG0013', 'CUS0006', 'TR.0021-190624', 'No.0021-190624', '2016-11-14 22:21:03', '2016-11-14', 325000, 6, 1950000, 0),
('BRG0001', 'CUS0006', 'TR.0022-190624', 'No.0021-190624', '2016-11-14 22:21:03', '2016-11-14', 350000, 6, 2100000, 0),
('BRG0009', 'CUS0010', 'TR.0023-190624', 'No.0023-190624', '2016-12-16 22:21:03', '2016-12-16', 290000, 12, 3480000, 0),
('BRG0008', 'CUS0013', 'TR.0024-190624', 'No.0024-190624', '2017-01-11 22:32:45', '2017-01-11', 350000, 6, 2100000, 0),
('BRG0001', 'CUS0004', 'TR.0025-190624', 'No.0025-190624', '2017-02-20 22:32:45', '2017-02-20', 350000, 6, 2100000, 0),
('BRG0005', 'CUS0004', 'TR.0026-190624', 'No.0025-190624', '2017-02-20 22:32:45', '2017-02-20', 475000, 6, 2850000, 0),
('BRG0005', 'CUS0002', 'TR.0027-190624', 'No.0027-190624', '2017-03-18 22:32:45', '2017-03-18', 475000, 6, 2850000, 0),
('BRG0012', 'CUS0002', 'TR.0028-190624', 'No.0027-190624', '2017-03-18 22:32:45', '2017-03-18', 575000, 3, 1725000, 0),
('BRG0003', 'CUS0011', 'TR.0029-190624', 'No.0029-190624', '2017-04-26 22:32:45', '2017-04-26', 350000, 6, 2100000, 0),
('BRG0013', 'CUS0011', 'TR.0030-190624', 'No.0029-190624', '2017-04-26 22:32:45', '2017-04-26', 325000, 6, 1950000, 0),
('BRG0015', 'CUS0011', 'TR.0031-190624', 'No.0029-190624', '2017-04-26 22:32:45', '2017-04-26', 250000, 3, 750000, 0),
('BRG0007', 'CUS0012', 'TR.0032-190624', 'No.0032-190624', '2017-05-18 22:32:45', '2017-05-18', 250000, 12, 3000000, 0),
('BRG0014', 'CUS0012', 'TR.0033-190624', 'No.0032-190624', '2017-05-18 22:32:45', '2017-05-18', 360000, 6, 2160000, 0),
('BRG0007', 'CUS0007', 'TR.0034-190624', 'No.0034-190624', '2017-06-19 22:32:45', '2017-06-19', 250000, 6, 1500000, 0),
('BRG0005', 'CUS0007', 'TR.0035-190624', 'No.0034-190624', '2017-06-19 22:32:45', '2017-06-19', 475000, 3, 1425000, 0),
('BRG0007', 'CUS0003', 'TR.0036-190624', 'No.0036-190624', '2017-07-20 22:32:45', '2017-07-20', 250000, 6, 1500000, 0),
('BRG0011', 'CUS0003', 'TR.0037-190624', 'No.0036-190624', '2017-07-20 22:32:45', '2017-07-20', 295000, 6, 1770000, 0),
('BRG0001', 'CUS0002', 'TR.0038-190624', 'No.0038-190624', '2017-08-25 22:32:45', '2017-08-25', 350000, 6, 2100000, 0),
('BRG0005', 'CUS0002', 'TR.0039-190624', 'No.0038-190624', '2017-08-25 22:32:45', '2017-08-25', 475000, 6, 2850000, 0),
('BRG0006', 'CUS0009', 'TR.0040-190624', 'No.0040-190624', '2017-09-22 22:32:45', '2017-09-22', 450000, 12, 5400000, 0),
('BRG0016', 'CUS0009', 'TR.0041-190624', 'No.0040-190624', '2017-09-22 22:32:45', '2017-09-22', 25000, 6, 150000, 0),
('BRG0010', 'CUS0011', 'TR.0042-190624', 'No.0042-190624', '2017-10-12 22:32:45', '2017-10-12', 325000, 12, 3900000, 0),
('BRG0011', 'CUS0011', 'TR.0043-190624', 'No.0042-190624', '2017-10-12 22:32:45', '2017-10-12', 295000, 6, 1770000, 0),
('BRG0007', 'CUS0013', 'TR.0044-190624', 'No.0044-190624', '2017-11-17 22:32:45', '2017-11-17', 250000, 12, 3000000, 0),
('BRG0009', 'CUS0006', 'TR.0045-190624', 'No.0045-190624', '2017-12-25 22:32:45', '2017-12-25', 290000, 6, 1740000, 0),
('BRG0010', 'CUS0006', 'TR.0046-190624', 'No.0045-190624', '2017-12-25 22:32:45', '2017-12-25', 325000, 6, 1950000, 0),
('BRG0015', 'CUS0006', 'TR.0047-190624', 'No.0045-190624', '2017-12-25 22:32:45', '2017-12-25', 250000, 6, 1500000, 0),
('BRG0001', 'CUS0001', 'TR.0048-190624', 'No.0048-190624', '2018-01-25 22:32:45', '2018-01-25', 350000, 12, 4200000, 0),
('BRG0005', 'CUS0002', 'TR.0049-190624', 'No.0049-190624', '2018-02-19 22:32:45', '2018-02-19', 475000, 6, 2850000, 0),
('BRG0010', 'CUS0002', 'TR.0050-190624', 'No.0049-190624', '2018-02-19 22:32:45', '2018-02-19', 325000, 6, 1950000, 0),
('BRG0009', 'CUS0003', 'TR.0051-190624', 'No.0051-190624', '2018-03-18 22:32:45', '2018-03-18', 290000, 6, 1740000, 0),
('BRG0012', 'CUS0003', 'TR.0052-190624', 'No.0051-190624', '2018-03-18 22:32:45', '2018-03-18', 575000, 2, 1150000, 0),
('BRG0016', 'CUS0004', 'TR.0053-190624', 'No.0053-190624', '2018-04-20 22:32:45', '2018-04-20', 25000, 12, 300000, 0),
('BRG0011', 'CUS0004', 'TR.0054-190624', 'No.0053-190624', '2018-04-20 22:32:45', '2018-04-20', 295000, 6, 1770000, 0),
('BRG0013', 'CUS0006', 'TR.0055-190624', 'No.0055-190624', '2018-05-24 22:32:45', '2018-05-24', 325000, 6, 1950000, 0),
('BRG0016', 'CUS0006', 'TR.0056-190624', 'No.0055-190624', '2018-05-24 22:32:45', '2018-05-24', 25000, 3, 75000, 0),
('BRG0005', 'CUS0010', 'TR.0057-190624', 'No.0057-190624', '2018-06-28 22:32:45', '2018-06-28', 475000, 6, 2850000, 0),
('BRG0004', 'CUS0012', 'TR.0058-190624', 'No.0058-190624', '2018-07-18 22:32:45', '2018-07-18', 350000, 6, 2100000, 0),
('BRG0009', 'CUS0012', 'TR.0059-190624', 'No.0058-190624', '2018-07-18 22:32:45', '2018-07-18', 290000, 6, 1740000, 0),
('BRG0009', 'CUS0008', 'TR.0060-190624', 'No.0060-190624', '2018-08-17 22:32:45', '2018-08-17', 290000, 6, 1740000, 0),
('BRG0011', 'CUS0008', 'TR.0061-190624', 'No.0060-190624', '2018-08-17 22:32:45', '2018-08-17', 295000, 6, 1770000, 0),
('BRG0012', 'CUS0008', 'TR.0062-190624', 'No.0060-190624', '2018-08-17 22:32:45', '2018-08-17', 575000, 2, 1150000, 0),
('BRG0003', 'CUS0005', 'TR.0063-190624', 'No.0063-190624', '2018-09-18 22:32:45', '2018-09-18', 350000, 6, 2100000, 0),
('BRG0011', 'CUS0005', 'TR.0064-190624', 'No.0063-190624', '2018-09-18 22:32:45', '2018-09-18', 295000, 3, 885000, 0),
('BRG0007', 'CUS0014', 'TR.0065-190624', 'No.0065-190624', '2018-10-18 22:32:45', '2018-10-18', 250000, 12, 3000000, 0),
('BRG0006', 'CUS0009', 'TR.0066-190624', 'No.0066-190624', '2018-11-19 22:32:45', '2018-11-19', 450000, 3, 1350000, 0),
('BRG0012', 'CUS0009', 'TR.0067-190624', 'No.0066-190624', '2018-11-19 22:32:45', '2018-11-19', 575000, 1, 575000, 0),
('BRG0005', 'CUS0011', 'TR.0068-190624', 'No.0068-190624', '2018-12-28 22:32:45', '2018-12-28', 475000, 6, 2850000, 0),
('BRG0013', 'CUS0012', 'TR.0069-190624', 'No.0069-190624', '2019-01-18 22:32:45', '2019-01-18', 325000, 12, 3900000, 0),
('BRG0001', 'CUS0010', 'TR.0070-190624', 'No.0070-190624', '2019-02-21 22:32:45', '2019-02-21', 350000, 6, 2100000, 0),
('BRG0011', 'CUS0007', 'TR.0071-190624', 'No.0071-190624', '2019-03-16 22:32:45', '2019-03-16', 295000, 12, 3540000, 0),
('BRG0004', 'CUS0015', 'TR.0072-190624', 'No.0072-190624', '2019-04-17 22:32:45', '2019-04-17', 350000, 6, 2100000, 0),
('BRG0005', 'CUS0009', 'TR.0073-190624', 'No.0073-190624', '2019-05-24 22:32:45', '2019-05-24', 475000, 6, 2850000, 0),
('BRG0008', 'CUS0009', 'TR.0074-190624', 'No.0073-190624', '2019-05-24 22:32:45', '2019-05-24', 350000, 6, 2100000, 0),
('BRG0005', 'CUS0013', 'TR.0075-190624', 'No.0075-190624', '2019-06-14 22:32:45', '2019-06-14', 475000, 12, 5700000, 0),
('BRG0006', 'CUS0009', 'TR.0076-190624', 'No.0076-190624', '2019-07-26 22:32:45', '2019-07-26', 450000, 6, 2700000, 0),
('BRG0008', 'CUS0012', 'TR.0077-190624', 'No.0077-190624', '2019-08-05 22:32:45', '2019-08-05', 350000, 6, 2100000, 0),
('BRG0007', 'CUS0012', 'TR.0078-190624', 'No.0077-190624', '2019-08-05 22:32:45', '2019-08-05', 250000, 6, 1500000, 0),
('BRG0001', 'CUS0001', 'TR.0079-190624', 'No.0079-190624', '2019-09-19 22:32:45', '2019-09-19', 350000, 6, 2100000, 0),
('BRG0007', 'CUS0004', 'TR.0080-190624', 'No.0080-190624', '2019-10-23 22:32:45', '2019-10-23', 250000, 6, 1500000, 0),
('BRG0012', 'CUS0004', 'TR.0081-190624', 'No.0080-190624', '2019-10-23 22:32:45', '2019-10-23', 575000, 6, 3450000, 0),
('BRG0011', 'CUS0013', 'TR.0082-190624', 'No.0082-190624', '2019-11-03 22:32:45', '2019-11-03', 295000, 6, 1770000, 0),
('BRG0016', 'CUS0013', 'TR.0083-190624', 'No.0082-190624', '2019-11-03 22:32:45', '2019-11-03', 25000, 6, 150000, 0),
('BRG0006', 'CUS0003', 'TR.0084-190624', 'No.0084-190624', '2019-12-31 22:32:45', '2019-12-31', 450000, 6, 2700000, 0),
('BRG0005', 'CUS0003', 'TR.0085-190624', 'No.0084-190624', '2019-12-31 22:32:45', '2019-12-31', 475000, 3, 1425000, 0),
('BRG0008', 'CUS0001', 'TR.0086-190624', 'No.0086-190624', '2019-06-24 23:00:39', '2019-06-24', 350000, 12, 4200000, 0);

--
-- Triggers `transaksi`
--
DELIMITER $$
CREATE TRIGGER `Stok_Barang_Berkurang_Otomatis` AFTER INSERT ON `transaksi` FOR EACH ROW BEGIN
UPDATE barang SET STOK_BARANG = STOK_BARANG - new.QTY
WHERE ID_BARANG = new.ID_BARANG;
END
$$
DELIMITER ;
DELIMITER $$
CREATE TRIGGER `Stok_Barang_Bertambah_Otomatis` AFTER DELETE ON `transaksi` FOR EACH ROW BEGIN
UPDATE barang SET STOK_BARANG = STOK_BARANG + old.QTY
WHERE ID_BARANG = old.ID_BARANG;
END
$$
DELIMITER ;

--
-- Indexes for dumped tables
--

--
-- Indexes for table `barang`
--
ALTER TABLE `barang`
  ADD PRIMARY KEY (`ID_BARANG`);

--
-- Indexes for table `barang_detail`
--
ALTER TABLE `barang_detail`
  ADD KEY `USERNAME` (`USERNAME`),
  ADD KEY `ID_BARANG` (`ID_BARANG`);

--
-- Indexes for table `barang_keluar`
--
ALTER TABLE `barang_keluar`
  ADD PRIMARY KEY (`ID_BARANG_KELUAR`),
  ADD KEY `ID_PELANGGAN` (`ID_PELANGGAN`);

--
-- Indexes for table `barang_keluar_detail`
--
ALTER TABLE `barang_keluar_detail`
  ADD PRIMARY KEY (`ID_BRG_KLR_DETAIL`),
  ADD KEY `ID_BARANG` (`ID_BARANG`,`ID_TRANSAKSI`),
  ADD KEY `ID_TRANSAKSI` (`ID_TRANSAKSI`);

--
-- Indexes for table `barang_masuk`
--
ALTER TABLE `barang_masuk`
  ADD PRIMARY KEY (`ID_BARANG_MASUK`),
  ADD KEY `ID_SUPLLIER` (`ID_SUPPLIER`);

--
-- Indexes for table `barang_masuk_detail`
--
ALTER TABLE `barang_masuk_detail`
  ADD PRIMARY KEY (`ID_BRG_MSK_DETAIL`),
  ADD KEY `FK_BARANG_MASUK_DETAIL` (`ID_BARANG`),
  ADD KEY `ID_DETAIL` (`ID_DETAIL`);

--
-- Indexes for table `pelanggan`
--
ALTER TABLE `pelanggan`
  ADD PRIMARY KEY (`ID_PELANGGAN`);

--
-- Indexes for table `pembelian`
--
ALTER TABLE `pembelian`
  ADD PRIMARY KEY (`ID_PEMBELIAN`),
  ADD KEY `FK_MENGIRIM` (`ID_SUPPLIER`);

--
-- Indexes for table `pembelian_detail`
--
ALTER TABLE `pembelian_detail`
  ADD PRIMARY KEY (`ID_DETAIL`),
  ADD KEY `FK_PEMBELIAN_DETAIL` (`ID_BARANG`),
  ADD KEY `FK_PEMBELIAN_DETAIL2` (`ID_SUPPLIER`);

--
-- Indexes for table `pengguna`
--
ALTER TABLE `pengguna`
  ADD PRIMARY KEY (`USERNAME`);

--
-- Indexes for table `penjualan`
--
ALTER TABLE `penjualan`
  ADD PRIMARY KEY (`ID_PENJUALAN`),
  ADD KEY `FK_MEMESAN` (`ID_PELANGGAN`);

--
-- Indexes for table `retur_pembelian`
--
ALTER TABLE `retur_pembelian`
  ADD PRIMARY KEY (`ID_RETUR_PEMBELIAN`),
  ADD KEY `FK_DIRETUR_` (`ID_SUPPLIER`),
  ADD KEY `FK_MERETUR_` (`ID_PEMBELIAN`),
  ADD KEY `FK_TERDAPAT__` (`ID_BARANG`);

--
-- Indexes for table `retur_penjualan`
--
ALTER TABLE `retur_penjualan`
  ADD PRIMARY KEY (`ID_RETUR_PENJUALAN`),
  ADD KEY `FK_DIRETUR` (`ID_PENJUALAN`),
  ADD KEY `FK_MERETUR` (`ID_PELANGGAN`),
  ADD KEY `FK_TERDAPAT` (`ID_BARANG`);

--
-- Indexes for table `stok_opname`
--
ALTER TABLE `stok_opname`
  ADD PRIMARY KEY (`ID_STOK_OPNAME`),
  ADD KEY `FK_TERDAPAT_` (`ID_BARANG`);

--
-- Indexes for table `supplier`
--
ALTER TABLE `supplier`
  ADD PRIMARY KEY (`ID_SUPPLIER`);

--
-- Indexes for table `transaksi`
--
ALTER TABLE `transaksi`
  ADD PRIMARY KEY (`ID_TRANSAKSI`),
  ADD KEY `FK_TRANSAKSI` (`ID_BARANG`),
  ADD KEY `FK_TRANSAKSI2` (`ID_PELANGGAN`);

--
-- Constraints for dumped tables
--

--
-- Constraints for table `barang_detail`
--
ALTER TABLE `barang_detail`
  ADD CONSTRAINT `barang_detail_ibfk_1` FOREIGN KEY (`USERNAME`) REFERENCES `pengguna` (`USERNAME`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `barang_detail_ibfk_2` FOREIGN KEY (`ID_BARANG`) REFERENCES `barang` (`ID_BARANG`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `barang_keluar`
--
ALTER TABLE `barang_keluar`
  ADD CONSTRAINT `barang_keluar_ibfk_1` FOREIGN KEY (`ID_PELANGGAN`) REFERENCES `pelanggan` (`ID_PELANGGAN`);

--
-- Constraints for table `barang_keluar_detail`
--
ALTER TABLE `barang_keluar_detail`
  ADD CONSTRAINT `barang_keluar_detail_ibfk_1` FOREIGN KEY (`ID_TRANSAKSI`) REFERENCES `transaksi` (`ID_TRANSAKSI`),
  ADD CONSTRAINT `barang_keluar_detail_ibfk_2` FOREIGN KEY (`ID_BARANG`) REFERENCES `barang` (`ID_BARANG`);

--
-- Constraints for table `barang_masuk`
--
ALTER TABLE `barang_masuk`
  ADD CONSTRAINT `barang_masuk_ibfk_1` FOREIGN KEY (`ID_SUPPLIER`) REFERENCES `supplier` (`ID_SUPPLIER`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `barang_masuk_detail`
--
ALTER TABLE `barang_masuk_detail`
  ADD CONSTRAINT `FK_BARANG_MASUK_DETAIL` FOREIGN KEY (`ID_BARANG`) REFERENCES `barang` (`ID_BARANG`),
  ADD CONSTRAINT `barang_masuk_detail_ibfk_1` FOREIGN KEY (`ID_DETAIL`) REFERENCES `pembelian_detail` (`ID_DETAIL`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `pembelian`
--
ALTER TABLE `pembelian`
  ADD CONSTRAINT `FK_MENGIRIM` FOREIGN KEY (`ID_SUPPLIER`) REFERENCES `supplier` (`ID_SUPPLIER`);

--
-- Constraints for table `pembelian_detail`
--
ALTER TABLE `pembelian_detail`
  ADD CONSTRAINT `FK_PEMBELIAN_DETAIL` FOREIGN KEY (`ID_BARANG`) REFERENCES `barang` (`ID_BARANG`),
  ADD CONSTRAINT `FK_PEMBELIAN_DETAIL2` FOREIGN KEY (`ID_SUPPLIER`) REFERENCES `supplier` (`ID_SUPPLIER`);

--
-- Constraints for table `penjualan`
--
ALTER TABLE `penjualan`
  ADD CONSTRAINT `FK_MEMESAN` FOREIGN KEY (`ID_PELANGGAN`) REFERENCES `pelanggan` (`ID_PELANGGAN`);

--
-- Constraints for table `retur_penjualan`
--
ALTER TABLE `retur_penjualan`
  ADD CONSTRAINT `FK_DIRETUR` FOREIGN KEY (`ID_PENJUALAN`) REFERENCES `penjualan` (`ID_PENJUALAN`),
  ADD CONSTRAINT `FK_MERETUR` FOREIGN KEY (`ID_PELANGGAN`) REFERENCES `pelanggan` (`ID_PELANGGAN`),
  ADD CONSTRAINT `FK_TERDAPAT` FOREIGN KEY (`ID_BARANG`) REFERENCES `barang` (`ID_BARANG`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
