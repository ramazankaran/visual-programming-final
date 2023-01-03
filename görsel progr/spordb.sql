-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Anamakine: 127.0.0.1
-- Üretim Zamanı: 02 Oca 2023, 21:42:36
-- Sunucu sürümü: 10.4.27-MariaDB
-- PHP Sürümü: 8.1.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Veritabanı: `spordb`
--

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `login`
--

CREATE TABLE `login` (
  `id` int(11) NOT NULL,
  `kadi` varchar(255) NOT NULL,
  `sifre` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_turkish_ci;

--
-- Tablo döküm verisi `login`
--

INSERT INTO `login` (`id`, `kadi`, `sifre`) VALUES
(3, 'Admin', '1234'),
(4, 'Admin', '1234');

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `odemetbl`
--

CREATE TABLE `odemetbl` (
  `Oid` int(50) NOT NULL,
  `OAy` varchar(50) NOT NULL,
  `OUye` varchar(50) NOT NULL,
  `OMiktar` int(50) NOT NULL,
  `AdSoyad` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_turkish_ci;

--
-- Tablo döküm verisi `odemetbl`
--

INSERT INTO `odemetbl` (`Oid`, `OAy`, `OUye`, `OMiktar`, `AdSoyad`) VALUES
(1, '', '', 50, 'mert'),
(2, '', '', 100, 'Murat'),
(3, '', '', 100, 'murat hoca'),
(4, '', '', 75000, 'kartal'),
(5, '', '', 250, 'Çöl Kaplumbağası');

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `uyetbl`
--

CREATE TABLE `uyetbl` (
  `UId` int(11) NOT NULL,
  `UAdSoyad` varchar(50) NOT NULL,
  `UTelefon` varchar(50) NOT NULL,
  `UCinsiyet` varchar(6) NOT NULL,
  `UYas` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_turkish_ci;

--
-- Tablo döküm verisi `uyetbl`
--

INSERT INTO `uyetbl` (`UId`, `UAdSoyad`, `UTelefon`, `UCinsiyet`, `UYas`) VALUES
(3, 'muzekker', '05678', 'Kadın', 6),
(4, 'ram2', '25', 'Erkek	', 22),
(5, 'erdem al', '25', 'Erkek	', 22),
(6, 'murat korkmaz', '2', 'Erkek	', 150),
(7, 'burak tüzün', '2', 'Kadın', 2),
(8, 'Cem Yılmaz ', '123123', 'Erkek	', 22),
(9, 'sevim vasfiye', '1', 'Kadın', 50),
(10, 'adasd', '22', 'Erkek	', 22),
(11, 'asd', '123', 'Erkek	', 123),
(12, 'asdasd', '123', 'Erkek	', 123),
(13, 'asdas', '222', 'Kadın', 222),
(14, 'Çöl Kaplumbağası', '222', 'Erkek	', 160);

--
-- Dökümü yapılmış tablolar için indeksler
--

--
-- Tablo için indeksler `login`
--
ALTER TABLE `login`
  ADD PRIMARY KEY (`id`);

--
-- Tablo için indeksler `odemetbl`
--
ALTER TABLE `odemetbl`
  ADD PRIMARY KEY (`Oid`);

--
-- Tablo için indeksler `uyetbl`
--
ALTER TABLE `uyetbl`
  ADD PRIMARY KEY (`UId`);

--
-- Dökümü yapılmış tablolar için AUTO_INCREMENT değeri
--

--
-- Tablo için AUTO_INCREMENT değeri `login`
--
ALTER TABLE `login`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- Tablo için AUTO_INCREMENT değeri `odemetbl`
--
ALTER TABLE `odemetbl`
  MODIFY `Oid` int(50) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- Tablo için AUTO_INCREMENT değeri `uyetbl`
--
ALTER TABLE `uyetbl`
  MODIFY `UId` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=15;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
