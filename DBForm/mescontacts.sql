-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Hôte : 127.0.0.1:3306
-- Généré le : dim. 27 avr. 2025 à 22:12
-- Version du serveur : 5.7.31
-- Version de PHP : 8.1.31

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de données : `mescontacts`
--
CREATE DATABASE IF NOT EXISTS `mescontacts` DEFAULT CHARACTER SET utf8 COLLATE utf8_general_ci;
USE `mescontacts`;

-- --------------------------------------------------------

--
-- Structure de la table `contacts`
--

DROP TABLE IF EXISTS `contacts`;
CREATE TABLE IF NOT EXISTS `contacts` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `nom` varchar(100) NOT NULL,
  `telephone` varchar(100) NOT NULL,
  `email` varchar(100) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=9 DEFAULT CHARSET=utf8;

--
-- Déchargement des données de la table `contacts`
--

INSERT INTO `contacts` (`id`, `nom`, `telephone`, `email`) VALUES
(1, 'ali hassan', '77123456', 'ali@gmail.com'),
(2, 'houmed osman', '77142536', 'houmed@gmail.com'),
(3, 'omar', '123456', 'omar@gmail.com'),
(4, 'yacin', '97949649', 'yacin'),
(5, 'yacin\'ali', '88888888888', 'ali'),
(6, 'aaaaa', 'bbbbb', 'cccc'),
(7, 'lslmjfzjf', 'kklhklhklhl', 'mmljmjm'),
(8, 'ali\'mohamed', 'jojopo', 'jmljmljmljlm');
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
