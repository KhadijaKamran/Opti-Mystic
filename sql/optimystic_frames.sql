-- MySQL dump 10.13  Distrib 5.7.17, for Win64 (x86_64)
--
-- Host: localhost    Database: optimystic
-- ------------------------------------------------------
-- Server version	5.7.20-log

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `frames`
--

DROP TABLE IF EXISTS `frames`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `frames` (
  `fSrNo` int(11) NOT NULL,
  `size` varchar(15) DEFAULT NULL,
  `fType` varchar(15) DEFAULT NULL,
  `color` varchar(20) DEFAULT NULL,
  PRIMARY KEY (`fSrNo`),
  CONSTRAINT `f_keyframes` FOREIGN KEY (`fSrNo`) REFERENCES `products` (`SrNo`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `frames`
--

LOCK TABLES `frames` WRITE;
/*!40000 ALTER TABLE `frames` DISABLE KEYS */;
INSERT INTO `frames` VALUES (1,'full','other','Metal'),(2,'full','silver','Metal'),(3,'full','gun-metal','Metal'),(4,'full','blue','Metal'),(5,'full','brown','Metal'),(6,'rimless','other','Metal'),(7,'rimless','silver','Metal'),(8,'rimless','gun-metal','Metal'),(9,'rimless','blue','Metal'),(10,'rimless','brown','Metal'),(11,'frameless','other','Metal'),(12,'frameless','silver','Metal'),(13,'frameless','gun-metal','Metal'),(14,'frameless','blue','Metal'),(15,'frameless','brown','Metal'),(16,'full','other','Sheet'),(17,'full','silver','Sheet'),(18,'full','gun-metal','Sheet'),(19,'full','blue','Sheet'),(20,'full','brown','Sheet'),(21,'frameless','brown','Sheet'),(22,'rimless','other','Sheet'),(23,'rimless','silver','Sheet'),(24,'rimless','gun-metal','Sheet'),(25,'rimless','blue','Sheet'),(26,'rimless','brown','Sheet'),(27,'frameless','other','Sheet'),(28,'frameless','silver','Sheet'),(29,'frameless','gun-metal','Sheet'),(30,'frameless','blue','Sheet');
/*!40000 ALTER TABLE `frames` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2018-01-08 12:44:08
