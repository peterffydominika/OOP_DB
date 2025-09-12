-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Gép: 127.0.0.1
-- Létrehozás ideje: 2025. Sze 12. 10:59
-- Kiszolgáló verziója: 10.4.32-MariaDB
-- PHP verzió: 8.2.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Adatbázis: `library`
--
CREATE DATABASE IF NOT EXISTS `library` DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_hungarian_ci;
USE `library`;

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `books`
--

CREATE TABLE `books` (
  `id` int(255) NOT NULL,
  `title` varchar(255) NOT NULL,
  `author` varchar(255) NOT NULL,
  `releaseDate` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_hungarian_ci;

--
-- A tábla adatainak kiíratása `books`
--

INSERT INTO `books` (`id`, `title`, `author`, `releaseDate`) VALUES
(1, 'Happy End', 'Amii Hallstone', '2025-07-23'),
(2, 'Late Night Shopping', 'Dina Abrehart', '2025-06-17'),
(3, 'Shaolin Temple 3: Martial Arts of Shaolin (Nan bei Shao Lin) (Martial Arts of Shaolin)', 'Sterne Dayment', '2024-12-14'),
(4, 'Tiny Toon Adventures: How I Spent My Vacation', 'Wren Howley', '2025-08-09'),
(5, 'Ten Inch Hero', 'Augustin Pinshon', '2025-04-30'),
(6, 'Hans Christian Andersen', 'Rasia Catcheside', '2025-07-04'),
(7, 'Hotel Hell Vacation', 'Kendall Tawn', '2024-10-17'),
(8, 'Particle Fever', 'Elisabetta Duthie', '2025-08-19'),
(9, 'Without a Paddle: Nature\'s Calling', 'Jamal Filpi', '2025-05-25'),
(10, 'Pink Ribbons, Inc.', 'Amity Moreno', '2025-09-04'),
(11, 'Last Year at Marienbad (L\'Année dernière à Marienbad)', 'Rozele Coneron', '2024-10-06'),
(12, 'Nora\'s Will (Cinco días sin Nora)', 'Raimondo Mattocks', '2025-08-20'),
(13, 'The Pacific', 'Oralee Cleave', '2024-10-12'),
(14, 'Little Prince, The', 'Constancia Chupin', '2025-01-12'),
(15, 'Family Tree', 'Bourke Docherty', '2024-12-01'),
(16, 'Long Day Closes, The', 'Matthaeus Foat', '2025-07-09'),
(17, 'Wordplay', 'Jaye Wix', '2024-12-24'),
(18, 'Love Guru, The', 'Ulric Beacham', '2025-06-21'),
(19, 'Annapolis', 'Dena O\'Lagene', '2024-12-19'),
(20, 'O-Bi, O-Ba - The End of Civilization (O-bi, O-ba - Koniec cywilizacji)', 'Armando Jenicek', '2024-12-30'),
(21, 'Place Vendôme', 'Benoite Neild', '2024-10-03'),
(22, 'Lucky Them', 'Olivette Faraker', '2024-10-08'),
(23, 'My Best Fiend (Mein liebster Feind)', 'Tallulah Franchi', '2025-09-05'),
(24, 'Cat in the Hat, The', 'Cherrita Jessel', '2025-08-20'),
(25, 'In the Line of Fire', 'Lynn Shimwall', '2025-03-07'),
(26, 'Old Men in New Cars (Gamle mænd i nye biler)', 'Uta Janz', '2024-12-05'),
(27, 'Out of the Fog', 'Nickolas Petrozzi', '2024-09-15'),
(28, 'Strange Days', 'Hynda Matis', '2025-01-18'),
(29, 'Gidget', 'Llywellyn Pointin', '2025-08-11'),
(30, 'Scusa ma ti chiamo amore', 'Matthew Acres', '2025-04-06'),
(31, 'Bridge on the River Kwai, The', 'Ddene Nolte', '2025-01-05'),
(32, 'Garden of the Finzi-Continis, The (Giardino dei Finzi-Contini, Il)', 'Ermengarde Freen', '2025-01-07'),
(33, 'Three to Tango', 'Felicio Pharaoh', '2025-06-01'),
(34, 'Something in the Air (Apres Mai)', 'Lory Lamke', '2024-09-28'),
(35, 'Larry Crowne', 'Agnese Baudouin', '2024-10-31'),
(36, 'Sita Sings the Blues', 'Camel Casino', '2025-01-16'),
(37, 'Mr. Morgan\'s Last Love', 'Zsazsa McLanaghan', '2025-01-20'),
(38, 'Assault on Precinct 13', 'Shay Masey', '2025-03-24'),
(39, 'Rhythm of a Crime (Ritam zlocina)', 'Tony Bale', '2025-03-04'),
(40, 'Snakehead Terror', 'Julian Anderer', '2025-04-15'),
(41, '2 Days in New York', 'Jammal Muddiman', '2025-08-27'),
(42, 'Basketball Diaries, The', 'Arch Ellcock', '2025-04-17'),
(43, 'Left Behind: World at War', 'Flossi Kimbly', '2024-11-05'),
(44, 'Fame', 'Meridith Meneely', '2025-02-10'),
(45, 'Dead Set', 'Hy Humby', '2025-06-20'),
(46, 'Rudolph the Red-Nosed Reindeer', 'Sammy Jursch', '2025-04-26'),
(47, 'Dog Tags', 'Dietrich Lonie', '2024-12-29'),
(48, 'You\'re Not You', 'Lanny Gavrielly', '2025-01-05'),
(49, 'Gorillas in the Mist', 'Jonah Jeannesson', '2025-05-16'),
(50, 'Sylvia', 'Leicester Forder', '2024-11-01'),
(51, 'Tesla: Master of Lightning', 'Astrix Grinval', '2024-09-16'),
(52, 'Reckless', 'Marcel Dearle-Palser', '2025-01-08'),
(53, 'Cockfighter', 'Marlow Scaife', '2024-10-28'),
(54, 'International House', 'Robenia Yetton', '2025-01-02'),
(55, 'Passion of Joan of Arc, The (Passion de Jeanne d\'Arc, La)', 'Onida O\'Brallaghan', '2025-05-06'),
(56, '4 Months, 3 Weeks and 2 Days (4 luni, 3 saptamâni si 2 zile)', 'Ariel Satcher', '2025-07-03'),
(57, 'London Paris New York', 'Andie Mattingley', '2025-07-13'),
(58, 'Flashdance', 'Lek McGairl', '2025-01-21'),
(59, 'Modern Romance', 'Marlow Savary', '2025-03-16'),
(60, 'Heartbreaker (L\'Arnacoeur)', 'Angy Brackpool', '2024-10-25'),
(61, 'Cottage Country', 'Martie Oosthout de Vree', '2024-11-24'),
(62, 'Ice-Cold in Alex', 'Ellette Waterman', '2025-01-11'),
(63, 'Bulletproof Monk', 'Cordelie Liepina', '2024-10-20'),
(64, 'Daddy Nostalgia (Daddy Nostalgie)', 'Peterus Gilardengo', '2024-11-21'),
(65, 'Images of the World and the Inscription of War (Bilder der Welt und Inschrift des Krieges)', 'Audie Jacobs', '2024-12-16'),
(66, 'The Hungover Games', 'Abigale Godlee', '2025-03-30'),
(67, 'My Family', 'Daven Crapper', '2024-09-26'),
(68, 'Diary of a Wimpy Kid: Dog Days', 'Curt Norsister', '2024-11-08'),
(69, 'Snow Creature, The', 'Waylen Shucksmith', '2025-04-09'),
(70, 'For the Moment', 'Amii Chadbourn', '2024-10-31'),
(71, 'Camp X-Ray', 'Haze Macenzy', '2025-08-20'),
(72, 'Aftermath', 'Gerrard McDirmid', '2025-03-22'),
(73, 'Sierra, La', 'Margie Cliss', '2024-10-09'),
(74, 'Ned Kelly', 'Ivonne Hanway', '2025-06-07'),
(75, 'Night Train To Lisbon', 'Franni Melson', '2025-05-29'),
(76, 'Doctor, The', 'Haleigh McCaughey', '2025-03-10'),
(77, 'Staying Alive', 'Reggy Perot', '2024-11-30'),
(78, 'Alias the Doctor', 'Lemar Stickford', '2024-10-19'),
(79, 'Winning', 'Aguie Finby', '2025-07-21'),
(80, 'Shut Up and Play the Hits', 'Fanchon Loveland', '2025-05-09'),
(81, 'Careful', 'Owen Kirsopp', '2024-12-31'),
(82, 'Genocide', 'Camilla Nuschke', '2025-07-18'),
(83, 'Bride from Hades, The (Botan-dôrô) (Peony Lantern) (Tale of Peonies and Lanterns, A)', 'Thaddus Lonergan', '2025-01-12'),
(84, 'Human Nature', 'Cyrille Ainscough', '2025-01-12'),
(85, 'Monte Walsh', 'Farlie Hartman', '2024-10-01'),
(86, 'Prelude to War (Why We Fight, 1)', 'Jacinda Banstead', '2024-09-24'),
(87, 'Camera Obscura', 'Richard Bottomley', '2024-12-27'),
(88, 'Great War, The (Grande guerra, La)', 'Christabella Empringham', '2025-02-21'),
(89, 'Bickford Shmeckler\'s Cool Ideas', 'Carlita Carrabot', '2025-04-19'),
(90, 'Burton and Taylor', 'Charlene Storror', '2025-01-04'),
(91, 'Hands Off the Loot (Touchez pas au grisbi)', 'Ethel Francois', '2024-12-02'),
(92, 'Dead or Alive: Final', 'Quintana Sutch', '2025-01-07'),
(93, 'Hollywood Homicide', 'Baron Goodale', '2024-10-11'),
(94, 'Flamenco (de Carlos Saura)', 'Malva Beyne', '2025-01-05'),
(95, 'Deadly Spawn, The', 'Corty Pahl', '2025-07-13'),
(96, 'Dirty Dingus Magee', 'Boyd Gair', '2025-04-24'),
(97, 'Rose Seller, The (La vendedora de rosas)', 'Rosalie Pearmine', '2025-02-01'),
(98, 'Alien Contamination', 'Briant Littleover', '2024-10-26'),
(99, 'The Gamers', 'Mervin Freckingham', '2025-06-12'),
(100, 'Way Home, The (Jibeuro)', 'Debera Gouny', '2025-04-27');

--
-- Indexek a kiírt táblákhoz
--

--
-- A tábla indexei `books`
--
ALTER TABLE `books`
  ADD PRIMARY KEY (`id`);

--
-- A kiírt táblák AUTO_INCREMENT értéke
--

--
-- AUTO_INCREMENT a táblához `books`
--
ALTER TABLE `books`
  MODIFY `id` int(255) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=101;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
