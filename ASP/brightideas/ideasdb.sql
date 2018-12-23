CREATE DATABASE  IF NOT EXISTS `ideasdb` /*!40100 DEFAULT CHARACTER SET utf8 */;
USE `ideasdb`;
-- MySQL dump 10.13  Distrib 8.0.12, for Win64 (x86_64)
--
-- Host: localhost    Database: ideasdb
-- ------------------------------------------------------
-- Server version	8.0.12

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
 SET NAMES utf8 ;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `idea`
--

DROP TABLE IF EXISTS `idea`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `idea` (
  `IdeaId` int(11) NOT NULL AUTO_INCREMENT,
  `content` text,
  `created_at` datetime DEFAULT NULL,
  `updated_at` datetime DEFAULT NULL,
  `UserId` int(11) NOT NULL,
  PRIMARY KEY (`IdeaId`),
  KEY `fk_idea_user_idx` (`UserId`),
  CONSTRAINT `fk_idea_user` FOREIGN KEY (`UserId`) REFERENCES `user` (`userid`)
) ENGINE=InnoDB AUTO_INCREMENT=13 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `idea`
--

LOCK TABLES `idea` WRITE;
/*!40000 ALTER TABLE `idea` DISABLE KEYS */;
INSERT INTO `idea` VALUES (5,'heysdf','2018-11-19 10:22:44','2018-11-19 10:22:44',13),(7,'wow this review is a real review','2018-11-19 10:46:47','2018-11-19 10:46:47',14),(8,'wow this review is a real reviewwow this review is a real review','2018-11-19 10:46:52','2018-11-19 10:46:52',14),(12,'wow this review is a real reviewwow this review is a real reviewwow this review is a real reviewwow this review is a real reviewwow this review is a real review','2018-11-19 11:20:50','2018-11-19 11:20:50',14);
/*!40000 ALTER TABLE `idea` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `like`
--

DROP TABLE IF EXISTS `like`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `like` (
  `LikeId` int(11) NOT NULL AUTO_INCREMENT,
  `IdeaId` int(11) NOT NULL,
  `UserId` int(11) NOT NULL,
  PRIMARY KEY (`LikeId`),
  KEY `fk_Like_idea1_idx` (`IdeaId`),
  KEY `fk_Like_user1_idx` (`UserId`),
  CONSTRAINT `fk_Like_idea1` FOREIGN KEY (`IdeaId`) REFERENCES `idea` (`ideaid`),
  CONSTRAINT `fk_Like_user1` FOREIGN KEY (`UserId`) REFERENCES `user` (`userid`)
) ENGINE=InnoDB AUTO_INCREMENT=14 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `like`
--

LOCK TABLES `like` WRITE;
/*!40000 ALTER TABLE `like` DISABLE KEYS */;
INSERT INTO `like` VALUES (4,5,13),(5,5,14),(7,8,14),(8,7,14),(9,5,11),(13,12,14);
/*!40000 ALTER TABLE `like` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `user`
--

DROP TABLE IF EXISTS `user`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `user` (
  `UserId` int(11) NOT NULL AUTO_INCREMENT,
  `firstname` varchar(45) DEFAULT NULL,
  `lastname` varchar(45) DEFAULT NULL,
  `alias` varchar(45) DEFAULT NULL,
  `password` text,
  `email` varchar(45) DEFAULT NULL,
  `created_at` datetime DEFAULT NULL,
  `updated_at` datetime DEFAULT NULL,
  PRIMARY KEY (`UserId`)
) ENGINE=InnoDB AUTO_INCREMENT=15 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `user`
--

LOCK TABLES `user` WRITE;
/*!40000 ALTER TABLE `user` DISABLE KEYS */;
INSERT INTO `user` VALUES (11,'asdf@asdf.com','asdf@asdf.com','asdf@asdf.com','AQAAAAEAACcQAAAAEFGR8tWLBqthma3raxP+towpdumwdV2PCWud3ulo5wCMTLE2ym+Ys+UhWQQ1Mr3j8A==','asdf@asdf.com','2018-11-19 10:19:18','2018-11-19 10:19:18'),(12,'asdsadf@asdf.com','asdsadf@asdf.com','asdsadf@asdf.com','AQAAAAEAACcQAAAAEN7GPakv9edPf22BGgoEo42HgArUN1GM+UfH2savUDzgVk+EQSXDurXDga1QVI0QbA==','asdsadf@asdf.com','2018-11-19 10:21:53','2018-11-19 10:21:53'),(13,'asdsadf@asdf.com','asdsadf@asdf.com','asdsadf@asdf.com','AQAAAAEAACcQAAAAEGPjKOR0NwvcOYBKq4as7YmoAYPwiIgt4P1bYTY8L9DxNHHcjpAP5s//ZRiPX9Ud7A==','asddsadf@asdf.com','2018-11-19 10:22:01','2018-11-19 10:22:01'),(14,'zach@zach.com','zach@zach.com','ZACHMAN','AQAAAAEAACcQAAAAEF+blJZsgXrrGWzzGziwJoqCDA+Nn3+IL6vcn+LijdiEet9tp+chu0ZsvkRuSXXMlQ==','zach@zach.com','2018-11-19 10:35:20','2018-11-19 10:35:20');
/*!40000 ALTER TABLE `user` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2018-11-19 12:06:38
