CREATE DATABASE `lib` /*!40100 DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci */;
use lib;
CREATE TABLE `books` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `Name` text CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  `Author` text CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  `ISBN` varchar(20) NOT NULL,
  `Genre` text CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  `Left` int(11) NOT NULL,
  `Copies` int(11) NOT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB AUTO_INCREMENT=101 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
CREATE TABLE `users` (
  `Name` text NOT NULL,
  `Username` varchar(45) NOT NULL,
  `Pass` varchar(128) NOT NULL,
  `Salt` varchar(11) NOT NULL,
  `AccType` varchar(7) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  `Rollno` varchar(20) DEFAULT NULL,
  `NoOfBooks` int(2) DEFAULT '0',
  `Due` int(11) unsigned DEFAULT '0',
  `Confirmed` varchar(3) CHARACTER SET utf8 COLLATE utf8_general_ci DEFAULT 'No',
  `Book1` varchar(50) NOT NULL DEFAULT ' ',
  `Book2` varchar(50) NOT NULL DEFAULT ' ',
  `Book3` varchar(50) NOT NULL DEFAULT ' ',
  `Book4` varchar(50) NOT NULL DEFAULT ' ',
  `Book5` varchar(50) NOT NULL DEFAULT ' ',
  `Book6` varchar(50) NOT NULL DEFAULT ' ',
  `Book7` varchar(50) NOT NULL DEFAULT ' ',
  `Book8` varchar(50) NOT NULL DEFAULT ' ',
  `Book9` varchar(50) NOT NULL DEFAULT ' ',
  `Book10` varchar(50) NOT NULL DEFAULT ' ',
  PRIMARY KEY (`Username`),
  UNIQUE KEY `Username_UNIQUE` (`Username`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
