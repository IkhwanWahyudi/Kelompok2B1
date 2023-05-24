-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Waktu pembuatan: 24 Bulan Mei 2023 pada 17.05
-- Versi server: 10.4.28-MariaDB
-- Versi PHP: 8.2.4

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `dbrumahsakitpa2`
--

-- --------------------------------------------------------

--
-- Struktur dari tabel `tbakun`
--

CREATE TABLE `tbakun` (
  `id` int(3) NOT NULL,
  `fullname` text NOT NULL,
  `address` text NOT NULL,
  `date` text NOT NULL,
  `gender` text NOT NULL,
  `username` text NOT NULL,
  `password` text NOT NULL,
  `gambar` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data untuk tabel `tbakun`
--

INSERT INTO `tbakun` (`id`, `fullname`, `address`, `date`, `gender`, `username`, `password`, `gambar`) VALUES
(12, 'harlin', 'isekai', 'Sunday, Jan 12, 2003', 'Female', 'lin', 'lin', 'pasien5.jpg\r\n'),
(13, 'Budiman Santoso', 'Jalan Ery Suparjan', 'Wednesday, July 19, 2000', 'Male', 'budiman', '123', 'doc1.jpg'),
(14, 'asd', 'asd', 'Thursday, May 18, 2023', '', 'asd', 'asd', 'doc2.jpg'),
(15, 'Rizky Hardian', 'Jalan Pramuka', 'Friday, July 23, 1999', 'Male', 'rizky', '123', 'doc1.jpg');

-- --------------------------------------------------------

--
-- Struktur dari tabel `tbdokter`
--

CREATE TABLE `tbdokter` (
  `Nama` varchar(255) NOT NULL,
  `RiwayatPendidikan` varchar(255) NOT NULL,
  `Pengalaman` varchar(255) NOT NULL,
  `Foto` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data untuk tabel `tbdokter`
--

INSERT INTO `tbdokter` (`Nama`, `RiwayatPendidikan`, `Pengalaman`, `Foto`) VALUES
('dr. Hj. Viona Asya Arinda Sp.A', 'Alumnus Universitas Mulawarman', '4 Tahun', 'dokter3.png'),
('drg. Puput Widyastuti, Sp.KG', 'Alumnus Universitas Mulawarman', '3 Tahun', 'dokter7.png'),
('Prof. Dr. dr. H. Aldy Ramadhan Syahputra Sp.N., Sp.B', 'Alumnus Universitas Mulawarman', '5 Tahun', 'dokter1.png'),
('Prof. dr. Ir. H. Moh Ikhwan Wahyudi, Sp.BS., Sp.A., Sp.PD., S.Kom., M.Cs.', 'Alumnus Universitas Mulawarman', '5 Tahun', 'dokter2.png');

-- --------------------------------------------------------

--
-- Struktur dari tabel `tbpasien`
--

CREATE TABLE `tbpasien` (
  `id` int(3) NOT NULL,
  `idAkun` int(3) NOT NULL,
  `idRs` varchar(5) NOT NULL,
  `status` text NOT NULL,
  `catatan` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data untuk tabel `tbpasien`
--

INSERT INTO `tbpasien` (`id`, `idAkun`, `idRs`, `status`, `catatan`) VALUES
(5, 12, 'GM0', 'Diterima', 'tes tes tes'),
(9, 12, 'GM0', 'Ditolak', 'tes tes tes'),
(11, 15, 'PD0', 'Diterima', 'Besok datang di ruangan A');

-- --------------------------------------------------------

--
-- Struktur dari tabel `tbrs`
--

CREATE TABLE `tbrs` (
  `ID` varchar(5) NOT NULL,
  `Poliklinik` text NOT NULL,
  `Tanggal` date NOT NULL,
  `Jam` text NOT NULL,
  `Dokter` text NOT NULL,
  `Status` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data untuk tabel `tbrs`
--

INSERT INTO `tbrs` (`ID`, `Poliklinik`, `Tanggal`, `Jam`, `Dokter`, `Status`) VALUES
('A0', 'Poliklinik Anak', '2023-08-16', '08:00', 'dr. Hj. Viona Asya Arinda Sp.A', 'Available'),
('GM0', 'Poliklinik Gigi dan Mulut', '2023-05-23', '12:00', 'drg. Puput Widyastuti, Sp.KG', 'Available'),
('PD0', 'Poliklinik Penyakit Dalam', '2023-05-23', '08:00', 'Prof. dr. Ir. H. Moh Ikhwan Wahyudi, Sp.BS., Sp.A., Sp.PD., S.Kom., M.Cs.', 'Available');

--
-- Indexes for dumped tables
--

--
-- Indeks untuk tabel `tbakun`
--
ALTER TABLE `tbakun`
  ADD PRIMARY KEY (`id`);

--
-- Indeks untuk tabel `tbdokter`
--
ALTER TABLE `tbdokter`
  ADD PRIMARY KEY (`Nama`);

--
-- Indeks untuk tabel `tbpasien`
--
ALTER TABLE `tbpasien`
  ADD PRIMARY KEY (`id`),
  ADD KEY `fk_idAkun` (`idAkun`),
  ADD KEY `fk_idRs` (`idRs`);

--
-- Indeks untuk tabel `tbrs`
--
ALTER TABLE `tbrs`
  ADD PRIMARY KEY (`ID`);

--
-- AUTO_INCREMENT untuk tabel yang dibuang
--

--
-- AUTO_INCREMENT untuk tabel `tbakun`
--
ALTER TABLE `tbakun`
  MODIFY `id` int(3) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=16;

--
-- AUTO_INCREMENT untuk tabel `tbpasien`
--
ALTER TABLE `tbpasien`
  MODIFY `id` int(3) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=12;

--
-- Ketidakleluasaan untuk tabel pelimpahan (Dumped Tables)
--

--
-- Ketidakleluasaan untuk tabel `tbpasien`
--
ALTER TABLE `tbpasien`
  ADD CONSTRAINT `fk_idAkun` FOREIGN KEY (`idAkun`) REFERENCES `tbakun` (`id`),
  ADD CONSTRAINT `fk_idRs` FOREIGN KEY (`idRs`) REFERENCES `tbrs` (`ID`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
