-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Waktu pembuatan: 29 Des 2024 pada 05.58
-- Versi server: 10.4.32-MariaDB
-- Versi PHP: 8.2.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `db_toko_sepatu`
--

-- --------------------------------------------------------

--
-- Struktur dari tabel `barang`
--

CREATE TABLE `barang` (
  `kode_barang` varchar(10) NOT NULL,
  `nama_barang` varchar(50) NOT NULL,
  `kategori` varchar(25) NOT NULL,
  `kode_merk` varchar(15) NOT NULL,
  `harga_beli` int(10) UNSIGNED DEFAULT NULL,
  `harga_jual` int(11) UNSIGNED DEFAULT NULL,
  `kode_warna` varchar(10) NOT NULL,
  `kode_size` varchar(10) NOT NULL,
  `stok` int(11) DEFAULT NULL,
  `kode_satuan` varchar(25) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=latin1_swedish_ci;

--
-- Dumping data untuk tabel `barang`
--

INSERT INTO `barang` (`kode_barang`, `nama_barang`, `kategori`, `kode_merk`, `harga_beli`, `harga_jual`, `kode_warna`, `kode_size`, `stok`, `kode_satuan`) VALUES
('SPT-001', 'Nike Air Force 1', 'KTG-001', 'MRK-002', 1200000, 1500000, 'WRN-001', 'SZE-044', 129, 'STN-002'),
('SPT-002', 'Converse High', 'KTG-001', 'MRK-004', 700000, 1000000, 'WRN-001', 'SZE-044', 79, 'STN-002'),
('SPT-003', 'Adidas Samba', 'KTG-001', 'MRK-001', 1500000, 1600000, 'WRN-001', 'SZE-044', 110, 'STN-002'),
('SPT-004', 'New Balance 325', 'KTG-001', 'MRK-005', 2000000, 2200000, 'WRN-002', 'SZE-040', 109, 'STN-002'),
('SPT-005', 'Nike Air Jordan Low', 'KTG-001', 'MRK-002', 1500000, 1700000, 'WRN-001', 'SZE-044', 109, 'STN-002');

-- --------------------------------------------------------

--
-- Struktur dari tabel `detail_trans_beli`
--

CREATE TABLE `detail_trans_beli` (
  `kode_trans_beli` varchar(15) NOT NULL,
  `kode_barang` varchar(15) NOT NULL,
  `nama_barang` varchar(25) DEFAULT NULL,
  `harga_beli` float UNSIGNED DEFAULT 0,
  `jumlah` float UNSIGNED DEFAULT 0,
  `sub_total` float UNSIGNED DEFAULT 0,
  `warna` varchar(15) DEFAULT NULL,
  `size` varchar(15) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=latin1_swedish_ci;

--
-- Dumping data untuk tabel `detail_trans_beli`
--

INSERT INTO `detail_trans_beli` (`kode_trans_beli`, `kode_barang`, `nama_barang`, `harga_beli`, `jumlah`, `sub_total`, `warna`, `size`) VALUES
('2024-11-28-015', 'SPT-001', 'Nike Air Force 1', 900000, 10, 9000000, 'WRN-001', 'SZE-044'),
('2024-12-02-016', 'SPT-001', 'Nike Air Force 1', 1200000, 10, 12000000, 'WRN-001', 'SZE-044'),
('2024-12-03-018', 'SPT-002', 'Converse High', 700000, 10, 7000000, 'WRN-001', 'SZE-044'),
('2024-12-03-019', 'SPT-002', 'Converse High', 700000, 10, 7000000, 'WRN-001', 'SZE-044'),
('2024-12-07-020', 'SPT-002', 'Converse High', 700000, 9, 6300000, 'WRN-001', 'SZE-044'),
('2024-12-11-020', 'SPT-002', 'Converse High', 700000, 1, 700000, 'WRN-001', 'SZE-044'),
('2024-12-11-021', 'SPT-003', 'Adidas Samba', 1500000, 2, 3000000, 'WRN-001', 'SZE-044'),
('2024-12-11-022', 'SPT-003', 'Adidas Samba', 1500000, 10, 15000000, 'WRN-001', 'SZE-044'),
('2024-12-11-022', 'SPT-001', 'Nike Air Force 1', 1200000, 20, 24000000, 'WRN-001', 'SZE-044'),
('2024-12-11-022', 'SPT-004', 'New Balance 325', 2000000, 10, 20000000, 'WRN-002', 'SZE-040'),
('2024-12-12-023', 'SPT-005', 'Nike Air Jordan Low', 1500000, 10, 15000000, 'WRN-001', 'SZE-044');

-- --------------------------------------------------------

--
-- Struktur dari tabel `detail_trans_jual`
--

CREATE TABLE `detail_trans_jual` (
  `kode_trans_jual` varchar(15) NOT NULL,
  `kode_barang` varchar(15) NOT NULL,
  `nama_barang` varchar(25) DEFAULT NULL,
  `harga_jual` float UNSIGNED DEFAULT 0,
  `jumlah` float UNSIGNED DEFAULT 0,
  `sub_total` float UNSIGNED DEFAULT 0,
  `warna` varchar(15) DEFAULT NULL,
  `size` varchar(15) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=latin1_swedish_ci;

--
-- Dumping data untuk tabel `detail_trans_jual`
--

INSERT INTO `detail_trans_jual` (`kode_trans_jual`, `kode_barang`, `nama_barang`, `harga_jual`, `jumlah`, `sub_total`, `warna`, `size`) VALUES
('2024-11-28-018', 'SPT-001', 'Nike Air Force 1', 1200000, 1, 1200000, 'WRN-001', 'SZE-044'),
('2024-12-02-019', 'SPT-001', 'Nike Air Force 1', 1500000, 1, 1500000, 'WRN-001', 'SZE-044'),
('2024-12-11-020', 'SPT-003', 'Adidas Samba', 1600000, 1, 1600000, 'WRN-001', 'SZE-044'),
('2024-12-11-021', 'SPT-002', 'Converse High', 1000000, 1, 1000000, 'WRN-001', 'SZE-044'),
('2024-12-11-022', 'SPT-003', 'Adidas Samba', 1600000, 1, 1600000, 'WRN-001', 'SZE-044'),
('2024-12-12-023', 'SPT-005', 'Nike Air Jordan Low', 1700000, 1, 1700000, 'WRN-001', 'SZE-044'),
('2024-12-12-023', 'SPT-004', 'New Balance 325', 2200000, 1, 2200000, 'WRN-002', 'SZE-040');

-- --------------------------------------------------------

--
-- Struktur dari tabel `karyawan`
--

CREATE TABLE `karyawan` (
  `nik` varchar(15) NOT NULL,
  `nama` varchar(25) NOT NULL,
  `jenis_kelamin` varchar(15) NOT NULL,
  `tempat_lahir` varchar(20) NOT NULL,
  `tanggal_lahir` date DEFAULT NULL,
  `alamat` varchar(50) NOT NULL,
  `no_telepon` varchar(15) DEFAULT NULL,
  `tanggal_update` timestamp NULL DEFAULT current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=latin1_swedish_ci;

--
-- Dumping data untuk tabel `karyawan`
--

INSERT INTO `karyawan` (`nik`, `nama`, `jenis_kelamin`, `tempat_lahir`, `tanggal_lahir`, `alamat`, `no_telepon`, `tanggal_update`) VALUES
('NIK-001', 'Ramadhan Abdillah', 'Laki-laki', 'Lumajang', '2004-11-13', 'Jogotrunan', '081230487740', '2024-11-25 08:54:48'),
('NIK-002', 'Tiara', 'Perempuan', 'Sidoarjo', '2005-02-10', 'Buduran', '081992992828', '2024-11-25 08:04:32'),
('NIK-003', 'Rama', 'Laki-laki', 'Jember', '2024-12-12', 'btb', '08120891212', '2024-12-12 00:31:34'),
('NIK-004', 'There', 'Perempuan', 'Surabaya', '2005-02-10', 'Ketintang', '081293131209', '2024-12-29 04:54:18');

-- --------------------------------------------------------

--
-- Struktur dari tabel `kategori`
--

CREATE TABLE `kategori` (
  `kode_kategori` varchar(15) NOT NULL,
  `nama_kategori` varchar(25) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=latin1_swedish_ci;

--
-- Dumping data untuk tabel `kategori`
--

INSERT INTO `kategori` (`kode_kategori`, `nama_kategori`) VALUES
('KTG-001', 'Sneakers'),
('KTG-002', 'Boots'),
('KTG-003', 'Cone'),
('KTG-004', 'Curved'),
('KTG-005', 'Flat Shoes'),
('KTG-006', 'High Heels'),
('KTG-007', 'Sepatu Kasual.'),
('KTG-008', 'Sepatu Olahraga'),
('KTG-009', 'Slip In & Loafers'),
('KTG-010', 'Aksesoris Sepatu'),
('KTG-011', 'Spool'),
('KTG-012', 'Stiletto'),
('KTG-013', 'Sandal');

-- --------------------------------------------------------

--
-- Struktur dari tabel `merk`
--

CREATE TABLE `merk` (
  `kode_merk` varchar(15) NOT NULL,
  `nama_merk` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=latin1_swedish_ci;

--
-- Dumping data untuk tabel `merk`
--

INSERT INTO `merk` (`kode_merk`, `nama_merk`) VALUES
('MRK-001', 'ADIDAS'),
('MRK-002', 'NIKE'),
('MRK-003', 'PUMA'),
('MRK-004', 'CONVERSE'),
('MRK-005', 'NEW BALANCE'),
('MRK-006', 'MACBETH'),
('MRK-007', 'AIRWALK'),
('MRK-008', 'DIADORA'),
('MRK-009', 'GLOBE'),
('MRK-010', 'DR. MARTENS'),
('MRK-011', 'FILA'),
('MRK-012', 'DC'),
('MRK-013', 'REEBOOK'),
('MRK-014', 'Yankees');

-- --------------------------------------------------------

--
-- Struktur dari tabel `satuan`
--

CREATE TABLE `satuan` (
  `kode_satuan` varchar(25) NOT NULL,
  `keterangan` varchar(15) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=latin1_swedish_ci;

--
-- Dumping data untuk tabel `satuan`
--

INSERT INTO `satuan` (`kode_satuan`, `keterangan`) VALUES
('STN-001', 'PCS'),
('STN-002', 'PASANG'),
('STN-003', 'LUSIN');

-- --------------------------------------------------------

--
-- Struktur dari tabel `size`
--

CREATE TABLE `size` (
  `kode_size` varchar(10) NOT NULL,
  `nama_size` varchar(15) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=latin1_swedish_ci;

--
-- Dumping data untuk tabel `size`
--

INSERT INTO `size` (`kode_size`, `nama_size`) VALUES
('SZE-037', '37'),
('SZE-038', '38'),
('SZE-039', '39'),
('SZE-040', '40'),
('SZE-041', '41'),
('SZE-042', '42'),
('SZE-043', '43'),
('SZE-044', '44'),
('SZE-045', '45'),
('SZE-046', '46');

-- --------------------------------------------------------

--
-- Struktur dari tabel `supplier`
--

CREATE TABLE `supplier` (
  `kode_supplier` varchar(15) NOT NULL,
  `nama_supplier` varchar(25) DEFAULT NULL,
  `alamat` varchar(25) DEFAULT NULL,
  `telepon` varchar(15) DEFAULT NULL,
  `email` varchar(20) DEFAULT NULL,
  `website` varchar(15) DEFAULT NULL,
  `tanggal_update` timestamp NULL DEFAULT current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=latin1_swedish_ci;

--
-- Dumping data untuk tabel `supplier`
--

INSERT INTO `supplier` (`kode_supplier`, `nama_supplier`, `alamat`, `telepon`, `email`, `website`, `tanggal_update`) VALUES
('SPL-001', 'ShoesShop.ID', 'Panjer', '88888888', 'im@shoeshop.id', 'shoeshop.id', '2024-11-28 18:40:35'),
('SPL-002', 'Shopee', 'Jakarta', '99999999', 'market@Shopee.id', 'Shopee.id', '2024-11-28 18:41:32'),
('SPL-003', 'Lazada', 'Bangkok', '77777777', 'sales@lazada.co.id', 'lazada.co.id', '2024-11-29 03:28:59'),
('SPL-004', 'Tokopedia', 'Jl. MH Tamrin, Jakarta', '11112222', 'reseller@toped.id', 'tokopedia.com', '2024-11-29 15:41:47'),
('SPL-005', 'BukaLapak', 'Denpasar', '232357679', 'shoes@bukalapak.id', 'bukalapak.com', '2024-11-29 15:42:33'),
('SPL-006', 'Uncharted', 'Jakarta', '5555555', 'uncharted@gmail.co', 'uncharted.com', '2024-11-26 03:31:11');

-- --------------------------------------------------------

--
-- Struktur dari tabel `trans_beli`
--

CREATE TABLE `trans_beli` (
  `kode_trans_beli` varchar(15) NOT NULL,
  `kode_supplier` varchar(15) DEFAULT NULL,
  `username` varchar(20) NOT NULL,
  `total` float UNSIGNED NOT NULL DEFAULT 0,
  `tanggal_trans_beli` varchar(10) DEFAULT NULL,
  `tanggal_update` timestamp NULL DEFAULT current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=latin1_swedish_ci;

--
-- Dumping data untuk tabel `trans_beli`
--

INSERT INTO `trans_beli` (`kode_trans_beli`, `kode_supplier`, `username`, `total`, `tanggal_trans_beli`, `tanggal_update`) VALUES
('2024-11-28-015', 'SPL-003', 'abdi', 9000000, '2024-11-28', '2024-11-27 18:01:19'),
('2024-12-02-016', 'SPL-002', 'abdi', 12000000, '2024-12-02', '2024-12-02 01:15:51'),
('2024-12-03-019', 'SPL-003', 'abdi', 7000000, '2024-12-03', '2024-12-03 04:29:04'),
('2024-12-11-020', 'SPL-002', 'abdi', 700000, '2024-12-11', '2024-12-11 03:13:03'),
('2024-12-11-021', 'SPL-005', 'abdi', 3000000, '2024-12-11', '2024-12-11 03:40:22'),
('2024-12-11-022', 'SPL-004', 'abdi', 59000000, '2024-12-11', '2024-12-11 03:58:57'),
('2024-12-12-023', 'SPL-006', 'abdi', 15000000, '2024-12-12', '2024-12-12 01:08:31');

-- --------------------------------------------------------

--
-- Struktur dari tabel `trans_jual`
--

CREATE TABLE `trans_jual` (
  `kode_trans_jual` varchar(15) NOT NULL,
  `pembeli` varchar(25) DEFAULT NULL,
  `username` varchar(20) DEFAULT NULL,
  `total_belanja` float UNSIGNED NOT NULL,
  `diskon` float UNSIGNED NOT NULL,
  `total_akhir` float DEFAULT NULL,
  `bayar` float DEFAULT NULL,
  `kembalian` float DEFAULT NULL,
  `tanggal_trans_jual` varchar(15) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=latin1_swedish_ci;

--
-- Dumping data untuk tabel `trans_jual`
--

INSERT INTO `trans_jual` (`kode_trans_jual`, `pembeli`, `username`, `total_belanja`, `diskon`, `total_akhir`, `bayar`, `kembalian`, `tanggal_trans_jual`) VALUES
('2024-11-28-017', 'bobi', 'abdi', 120000, 0, 120000, 120000, 0, '2024-11-28'),
('2024-11-28-018', 'budi', 'abdi', 1200000, 200000, 1000000, 1000000, 0, '2024-11-28'),
('2024-12-02-019', 'Andi', 'abdi', 1500000, 0, 1500000, 1500000, 0, '2024-12-02'),
('2024-12-11-020', 'juned', 'abdi', 1600000, 0, 1600000, 1700000, 100000, '2024-12-11'),
('2024-12-11-021', 'juned', 'abdi', 1000000, 0, 1000000, 1000000, 0, '2024-12-11'),
('2024-12-11-022', 'budiono', 'abdi', 1600000, 0, 1600000, 1700000, 100000, '2024-12-11'),
('2024-12-12-023', 'Doni', 'abdi', 3900000, 0, 3900000, 4000000, 100000, '2024-12-12');

-- --------------------------------------------------------

--
-- Struktur dari tabel `user`
--

CREATE TABLE `user` (
  `username` varchar(20) NOT NULL,
  `password` varchar(20) NOT NULL,
  `nik` varchar(11) NOT NULL,
  `tanggal_update` timestamp NULL DEFAULT current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=latin1_swedish_ci;

--
-- Dumping data untuk tabel `user`
--

INSERT INTO `user` (`username`, `password`, `nik`, `tanggal_update`) VALUES
('abdi', 'abdi', 'NIK-002', '2017-07-12 04:24:41'),
('rama', 'rama', 'NIK-003', '2024-12-12 00:32:02'),
('there', 'there', 'NIK-004', '2024-12-29 04:56:16'),
('tiara', 'tiara', 'NIK-001', '2017-07-05 08:58:13');

-- --------------------------------------------------------

--
-- Struktur dari tabel `warna`
--

CREATE TABLE `warna` (
  `kode_warna` varchar(10) NOT NULL,
  `nama_warna` varchar(30) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=latin1_swedish_ci;

--
-- Dumping data untuk tabel `warna`
--

INSERT INTO `warna` (`kode_warna`, `nama_warna`) VALUES
('WRN-001', 'White'),
('WRN-002', 'Grey'),
('WRN-003', 'Light Grey'),
('WRN-004', 'Black'),
('WRN-005', 'Cream'),
('WRN-006', 'Dark Brown'),
('WRN-007', 'Blue'),
('WRN-008', 'Dark Green'),
('WRN-009', 'Light Green'),
('WRN-010', 'Yellow'),
('WRN-011', 'Pink'),
('WRN-012', 'Dark Grey'),
('WRN-013', 'Grey/White'),
('WRN-014', 'Navy-White'),
('WRN-015', 'Grey-Sail'),
('WRN-016', 'Green-White'),
('WRN-017', 'Dark Grey-White-Wolf Grey-Anth'),
('WRN-018', 'Black/White'),
('WRN-019', 'Midnight Navy / White'),
('WRN-020', 'Blue/Black');

--
-- Indexes for dumped tables
--

--
-- Indeks untuk tabel `barang`
--
ALTER TABLE `barang`
  ADD PRIMARY KEY (`kode_barang`,`nama_barang`),
  ADD KEY `barang_ibfk_1` (`kode_satuan`),
  ADD KEY `barang_ibfk_2` (`kategori`),
  ADD KEY `size` (`kode_size`),
  ADD KEY `merk_fk` (`kode_merk`),
  ADD KEY `warna_fk` (`kode_warna`);

--
-- Indeks untuk tabel `detail_trans_beli`
--
ALTER TABLE `detail_trans_beli`
  ADD KEY `detail_trans_beli_ibfk_2` (`kode_barang`),
  ADD KEY `detail_trans_beli_ibfk_1` (`kode_trans_beli`);

--
-- Indeks untuk tabel `detail_trans_jual`
--
ALTER TABLE `detail_trans_jual`
  ADD KEY `detail_trans_jual_ibfk_1` (`kode_barang`),
  ADD KEY `detail_trans_jual_ibfk_2` (`kode_trans_jual`),
  ADD KEY `idx_kode_trans_jual` (`kode_trans_jual`);

--
-- Indeks untuk tabel `karyawan`
--
ALTER TABLE `karyawan`
  ADD PRIMARY KEY (`nik`);

--
-- Indeks untuk tabel `kategori`
--
ALTER TABLE `kategori`
  ADD PRIMARY KEY (`kode_kategori`);

--
-- Indeks untuk tabel `merk`
--
ALTER TABLE `merk`
  ADD PRIMARY KEY (`kode_merk`);

--
-- Indeks untuk tabel `satuan`
--
ALTER TABLE `satuan`
  ADD PRIMARY KEY (`kode_satuan`);

--
-- Indeks untuk tabel `size`
--
ALTER TABLE `size`
  ADD PRIMARY KEY (`kode_size`);

--
-- Indeks untuk tabel `supplier`
--
ALTER TABLE `supplier`
  ADD PRIMARY KEY (`kode_supplier`);

--
-- Indeks untuk tabel `trans_beli`
--
ALTER TABLE `trans_beli`
  ADD PRIMARY KEY (`kode_trans_beli`),
  ADD KEY `trans_beli_ibfk_1` (`username`),
  ADD KEY `trans_beli_ibfk_2` (`kode_supplier`);

--
-- Indeks untuk tabel `trans_jual`
--
ALTER TABLE `trans_jual`
  ADD PRIMARY KEY (`kode_trans_jual`),
  ADD KEY `trans_jual_ibfk_1` (`username`);

--
-- Indeks untuk tabel `user`
--
ALTER TABLE `user`
  ADD PRIMARY KEY (`username`),
  ADD UNIQUE KEY `kunci_unik_user` (`username`,`nik`),
  ADD KEY `user_ibfk_1` (`nik`);

--
-- Indeks untuk tabel `warna`
--
ALTER TABLE `warna`
  ADD PRIMARY KEY (`kode_warna`);

--
-- Ketidakleluasaan untuk tabel pelimpahan (Dumped Tables)
--

--
-- Ketidakleluasaan untuk tabel `barang`
--
ALTER TABLE `barang`
  ADD CONSTRAINT `barang_ibfk_1` FOREIGN KEY (`kode_satuan`) REFERENCES `satuan` (`kode_satuan`),
  ADD CONSTRAINT `barang_ibfk_2` FOREIGN KEY (`kode_size`) REFERENCES `size` (`kode_size`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `kategor_fk` FOREIGN KEY (`kategori`) REFERENCES `kategori` (`kode_kategori`) ON UPDATE CASCADE,
  ADD CONSTRAINT `merk_fk` FOREIGN KEY (`kode_merk`) REFERENCES `merk` (`kode_merk`) ON UPDATE CASCADE,
  ADD CONSTRAINT `warna_fk` FOREIGN KEY (`kode_warna`) REFERENCES `warna` (`kode_warna`);

--
-- Ketidakleluasaan untuk tabel `detail_trans_beli`
--
ALTER TABLE `detail_trans_beli`
  ADD CONSTRAINT `detail_trans_beli_ibfk_1` FOREIGN KEY (`kode_barang`) REFERENCES `barang` (`kode_barang`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Ketidakleluasaan untuk tabel `detail_trans_jual`
--
ALTER TABLE `detail_trans_jual`
  ADD CONSTRAINT `detail_trans_jual_ibfk_1` FOREIGN KEY (`kode_barang`) REFERENCES `barang` (`kode_barang`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Ketidakleluasaan untuk tabel `trans_beli`
--
ALTER TABLE `trans_beli`
  ADD CONSTRAINT `trans_beli_ibfk_1` FOREIGN KEY (`username`) REFERENCES `user` (`username`) ON UPDATE CASCADE,
  ADD CONSTRAINT `trans_beli_ibfk_2` FOREIGN KEY (`kode_supplier`) REFERENCES `supplier` (`kode_supplier`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `trans_beli_ibfk_3` FOREIGN KEY (`kode_trans_beli`) REFERENCES `detail_trans_beli` (`kode_trans_beli`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Ketidakleluasaan untuk tabel `trans_jual`
--
ALTER TABLE `trans_jual`
  ADD CONSTRAINT `trans_jual_ibfk_1` FOREIGN KEY (`username`) REFERENCES `user` (`username`) ON UPDATE CASCADE;

--
-- Ketidakleluasaan untuk tabel `user`
--
ALTER TABLE `user`
  ADD CONSTRAINT `fk_user_nik` FOREIGN KEY (`nik`) REFERENCES `karyawan` (`nik`) ON DELETE CASCADE,
  ADD CONSTRAINT `user_ibfk_1` FOREIGN KEY (`nik`) REFERENCES `karyawan` (`nik`) ON UPDATE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
