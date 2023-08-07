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
-- Table structure for table `glasses`
--

DROP TABLE IF EXISTS `glasses`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `glasses` (
  `gSrNo` int(11) NOT NULL,
  `Quality` varchar(20) DEFAULT NULL,
  `color` varchar(30) DEFAULT NULL,
  `Category` varchar(20) DEFAULT NULL,
  PRIMARY KEY (`gSrNo`),
  CONSTRAINT `f_keyglassesC` FOREIGN KEY (`gSrNo`) REFERENCES `products` (`SrNo`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `glasses`
--

LOCK TABLES `glasses` WRITE;
/*!40000 ALTER TABLE `glasses` DISABLE KEYS */;
INSERT INTO `glasses` VALUES (44,'glass','white transparent','Photo-chromic'),(45,'plastic CR','white transparent','Bifocal Kryptok'),(46,'plastic CR','green','Hard Coated'),(47,'glass','blue','Hard Coated'),(48,'glass','blue','Multi Coated'),(49,'glass','green','Multi Coated'),(50,'plastic CR','blue','Multi Coated'),(51,'plastic CR','green','Multi Coated'),(52,'glass','brown','Photo-Chromic'),(53,'glass','grey','Photo-Chromic'),(54,'plastic CR','brown','Photo-Chromic'),(55,'plastic CR','grey','Photo-Chromic'),(56,'glass','anti-glare','Bifocal Kryptok'),(57,'glass','photo-chromic','Bifocal Kryptok'),(58,'glass','white','Bifocal Kryptok'),(59,'glass','anti-glare','Bifocal Dtype'),(60,'glass','photo-chromic','Bifocal Dtype'),(61,'glass','white','Bifocal Dtype'),(62,'glass','anti-glare','Bifocal Progresive'),(63,'glass','photo-chromic','Bifocal Progresive'),(64,'glass','white','Bifocal Progresive'),(65,'plastic CR','anti-glare','Bifocal Kryptok'),(66,'plastic CR','photo-chromic','Bifocal Kryptok'),(67,'plastic CR','white','Bifocal Kryptok'),(68,'plastic CR','anti-glare','Bifocal Dtype'),(69,'plastic CR','photo-chromic','Bifocal Dtype'),(70,'plastic CR','white','Bifocal Dtype'),(71,'plastic CR','anti-glare','Bifocal Progresive'),(72,'plastic CR','photo-chromic','Bifocal Progresive'),(73,'plastic CR','white','Bifocal Progresive');
/*!40000 ALTER TABLE `glasses` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2018-01-08 12:44:11
