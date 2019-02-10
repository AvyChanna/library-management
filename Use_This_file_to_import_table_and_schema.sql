CREATE DATABASE `lib` /*!40100 DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci */;
use `lib`;
CREATE TABLE `books` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `Name` text NOT NULL,
  `Author` text NOT NULL,
  `ISBN` varchar(20) NOT NULL,
  `Genre` text NOT NULL,
  `Left` int(11) NOT NULL,
  `Copies` int(11) NOT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB AUTO_INCREMENT=28 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
CREATE TABLE `users` (
  `Name` text NOT NULL,
  `Username` varchar(45) NOT NULL,
  `Pass` varchar(128) NOT NULL,
  `Salt` varchar(11) NOT NULL,
  `AccType` varchar(7) NOT NULL,
  `IssuedBooks` text,
  `NoOfBooks` int(2) DEFAULT '0',
  `Due` int(11) unsigned DEFAULT '0',
  `Confirmed` varchar(3) DEFAULT 'No',
  PRIMARY KEY (`Username`),
  UNIQUE KEY `Username_UNIQUE` (`Username`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
