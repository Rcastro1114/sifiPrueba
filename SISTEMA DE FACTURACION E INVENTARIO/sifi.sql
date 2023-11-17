CREATE DATABASE  IF NOT EXISTS `sifi` /*!40100 DEFAULT CHARACTER SET latin1 */;
USE `sifi`;
-- MySQL dump 10.13  Distrib 8.0.32, for Win64 (x86_64)
--
-- Host: localhost    Database: sifi
-- ------------------------------------------------------
-- Server version	5.7.41-log

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!50503 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `clasificaciones`
--

DROP TABLE IF EXISTS `clasificaciones`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `clasificaciones` (
  `idClasificaciones` int(11) NOT NULL AUTO_INCREMENT,
  `clasificacion` varchar(20) NOT NULL,
  PRIMARY KEY (`idClasificaciones`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `clasificaciones`
--

LOCK TABLES `clasificaciones` WRITE;
/*!40000 ALTER TABLE `clasificaciones` DISABLE KEYS */;
/*!40000 ALTER TABLE `clasificaciones` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `clientes`
--

DROP TABLE IF EXISTS `clientes`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `clientes` (
  `idClientes` int(11) NOT NULL AUTO_INCREMENT,
  `Nombres` varchar(30) NOT NULL,
  `Apellidos` varchar(30) NOT NULL,
  `Telefono` varchar(10) NOT NULL,
  `Correo` varchar(30) DEFAULT NULL,
  `idDirecciones` int(11) NOT NULL,
  PRIMARY KEY (`idClientes`),
  KEY `fk_idDirecciones_idx` (`idDirecciones`),
  CONSTRAINT `fk_idDirecciones` FOREIGN KEY (`idDirecciones`) REFERENCES `direcciones` (`idDirecciones`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `clientes`
--

LOCK TABLES `clientes` WRITE;
/*!40000 ALTER TABLE `clientes` DISABLE KEYS */;
INSERT INTO `clientes` VALUES (1,'Pedro','Hernández','444','ph@gmail.com',1);
/*!40000 ALTER TABLE `clientes` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `compras`
--

DROP TABLE IF EXISTS `compras`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `compras` (
  `idCompras` int(11) NOT NULL AUTO_INCREMENT,
  `Fecha` datetime NOT NULL,
  `idProveedores` int(11) NOT NULL,
  `idEmpleados` int(11) NOT NULL,
  `Total` decimal(10,2) NOT NULL,
  PRIMARY KEY (`idCompras`),
  KEY `fk_idEmpleados_idx` (`idEmpleados`),
  KEY `fk_idProveedores_idx` (`idProveedores`),
  CONSTRAINT `fk_idEmpleados` FOREIGN KEY (`idEmpleados`) REFERENCES `empleados` (`idEmpleados`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_idProveedores` FOREIGN KEY (`idProveedores`) REFERENCES `proveedores` (`idProveedores`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `compras`
--

LOCK TABLES `compras` WRITE;
/*!40000 ALTER TABLE `compras` DISABLE KEYS */;
INSERT INTO `compras` VALUES (1,'2023-06-08 02:29:20',1,1,75.50),(2,'2023-06-08 02:32:56',1,1,100.50),(3,'2023-06-08 02:55:26',1,1,160.00),(4,'2023-06-08 02:56:05',1,1,160.00),(5,'2023-06-08 03:04:58',1,1,10.00),(6,'2023-06-08 03:15:12',1,1,16.00);
/*!40000 ALTER TABLE `compras` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `departamentos`
--

DROP TABLE IF EXISTS `departamentos`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `departamentos` (
  `idDepartamentos` int(11) NOT NULL AUTO_INCREMENT,
  `Departamentos` varchar(30) NOT NULL,
  PRIMARY KEY (`idDepartamentos`)
) ENGINE=InnoDB AUTO_INCREMENT=15 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `departamentos`
--

LOCK TABLES `departamentos` WRITE;
/*!40000 ALTER TABLE `departamentos` DISABLE KEYS */;
INSERT INTO `departamentos` VALUES (1,'Sonsonate'),(2,'Ahuachapán'),(3,'Cabañas'),(4,'Chalatenango'),(5,'Cuscatlán'),(6,'La Libertad'),(7,'La paz'),(8,'La Unión'),(9,'Morazán'),(10,'San Miguel'),(11,'San Salvador'),(12,'San Vicente'),(13,'Santa Ana'),(14,'Usulután');
/*!40000 ALTER TABLE `departamentos` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `detallecompras`
--

DROP TABLE IF EXISTS `detallecompras`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `detallecompras` (
  `idDetalleCompras` int(11) NOT NULL AUTO_INCREMENT,
  `idProductos` int(11) NOT NULL,
  `Cantidad` int(11) NOT NULL,
  `idCompras` int(11) NOT NULL,
  `PrecioCompra` decimal(5,2) NOT NULL,
  PRIMARY KEY (`idDetalleCompras`),
  KEY `fk_idProductos_idx` (`idProductos`),
  KEY `fk_idCompras_idx` (`idCompras`),
  CONSTRAINT `fk_idCompras` FOREIGN KEY (`idCompras`) REFERENCES `compras` (`idCompras`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_idProductos` FOREIGN KEY (`idProductos`) REFERENCES `productos` (`idProductos`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `detallecompras`
--

LOCK TABLES `detallecompras` WRITE;
/*!40000 ALTER TABLE `detallecompras` DISABLE KEYS */;
INSERT INTO `detallecompras` VALUES (1,3,500,1,5.50),(2,4,43,2,6.50),(3,5,43,5,4.50),(4,5,24,5,3.60),(5,6,80,6,4.50),(6,8,92,6,7.90);
/*!40000 ALTER TABLE `detallecompras` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `detalleventas`
--

DROP TABLE IF EXISTS `detalleventas`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `detalleventas` (
  `idDetalleVentas` int(11) NOT NULL AUTO_INCREMENT,
  `idVentas` int(11) NOT NULL,
  `idProductos` int(11) NOT NULL,
  `Cantidad` int(11) NOT NULL,
  `PrecioVenta` decimal(5,2) NOT NULL,
  `SubTotal` decimal(10,2) NOT NULL,
  PRIMARY KEY (`idDetalleVentas`),
  KEY `fk_idProductos_idx` (`idVentas`),
  KEY `fkidProductos_idx` (`idProductos`),
  CONSTRAINT `fkidProductos` FOREIGN KEY (`idProductos`) REFERENCES `productos` (`idProductos`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fkidVentas` FOREIGN KEY (`idVentas`) REFERENCES `ventas` (`idVentas`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=34 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `detalleventas`
--

LOCK TABLES `detalleventas` WRITE;
/*!40000 ALTER TABLE `detalleventas` DISABLE KEYS */;
INSERT INTO `detalleventas` VALUES (8,54,1,8,9.50,76.00),(9,55,1,9,9.50,85.50),(10,56,1,2,9.50,19.00),(11,56,1,2,9.50,19.00),(12,58,1,2,9.50,19.00),(13,58,1,2,9.50,19.00),(14,59,1,2,9.50,19.00),(15,60,1,2,9.50,19.00),(16,61,2,3,5.25,15.75),(17,65,1,2,9.50,19.00),(18,69,1,3,9.50,28.50),(19,70,1,2,9.50,19.00),(20,71,1,3,9.50,28.50),(21,72,1,4,9.50,38.00),(22,73,1,2,9.50,19.00),(23,74,1,5,9.50,47.50),(24,73,1,7,8.90,89.00),(25,75,1,2,9.50,19.00),(26,76,1,4,9.50,38.00),(27,76,1,4,9.50,38.00),(28,77,3,54,8.60,464.40),(29,78,1,23,9.50,218.50),(30,79,1,3,9.50,28.50),(31,80,1,8,9.50,76.00),(32,80,2,9,5.25,47.25),(33,80,5,6,0.80,4.80);
/*!40000 ALTER TABLE `detalleventas` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `direcciones`
--

DROP TABLE IF EXISTS `direcciones`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `direcciones` (
  `idDirecciones` int(11) NOT NULL AUTO_INCREMENT,
  `Residencia` varchar(90) NOT NULL,
  `Canton` varchar(90) DEFAULT NULL,
  `Cacerio` varchar(90) DEFAULT NULL,
  `idMunicipios` int(11) NOT NULL,
  PRIMARY KEY (`idDirecciones`),
  KEY `direcciones_ibfk_1` (`idMunicipios`),
  CONSTRAINT `direcciones_ibfk_1` FOREIGN KEY (`idMunicipios`) REFERENCES `municipios` (`idMunicipios`)
) ENGINE=InnoDB AUTO_INCREMENT=11 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `direcciones`
--

LOCK TABLES `direcciones` WRITE;
/*!40000 ALTER TABLE `direcciones` DISABLE KEYS */;
INSERT INTO `direcciones` VALUES (1,'Col. Santa Eugenia de los Altos',NULL,NULL,1),(2,'Col. Belén',NULL,NULL,3),(3,'Col. 14 de Diciembre',NULL,NULL,2),(4,'Col. Sensunapan','','',2),(5,'Col. San Genaro','','',2),(6,'Col. El Balsamar','','',2),(7,'Col. Santa Marta','','',1),(8,'Col. Sedan','','',1),(9,'Col. San Antonio','','',2),(10,'Col. 5 de diciembre','','',1);
/*!40000 ALTER TABLE `direcciones` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `empleados`
--

DROP TABLE IF EXISTS `empleados`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `empleados` (
  `idEmpleados` int(11) NOT NULL AUTO_INCREMENT,
  `Nombres` varchar(30) NOT NULL,
  `Apellidos` varchar(30) NOT NULL,
  `DUI` varchar(10) NOT NULL,
  `Telefono` varchar(10) NOT NULL,
  `Correo` varchar(30) DEFAULT NULL,
  `idDirecciones` int(11) NOT NULL,
  PRIMARY KEY (`idEmpleados`),
  KEY `fk_idDirecciones_idx` (`idDirecciones`),
  CONSTRAINT `fk2_idDirecciones` FOREIGN KEY (`idDirecciones`) REFERENCES `direcciones` (`idDirecciones`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `empleados`
--

LOCK TABLES `empleados` WRITE;
/*!40000 ALTER TABLE `empleados` DISABLE KEYS */;
INSERT INTO `empleados` VALUES (1,'RAFAEL ANTONIO','CASTRO PINEDA','06029116-6','7664-5547','rcastropineda@gmail.com',1),(2,'CARMEN MARISOL','ALAS CÁCERES','06031998-1','8765-5423','cmarisol21@gmail.com',2),(4,'Andreas','Cristensen','321234','4444','ancr@gmail.com',8),(5,'Andres','Jaco','32435','22222','Aj@gmail.com',9),(6,'pedro','Castro','2121','31231','pc@gmail.com',10);
/*!40000 ALTER TABLE `empleados` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `formasdepagos`
--

DROP TABLE IF EXISTS `formasdepagos`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `formasdepagos` (
  `idFormasdePagos` int(11) NOT NULL AUTO_INCREMENT,
  `FormadePago` varchar(35) NOT NULL,
  PRIMARY KEY (`idFormasdePagos`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `formasdepagos`
--

LOCK TABLES `formasdepagos` WRITE;
/*!40000 ALTER TABLE `formasdepagos` DISABLE KEYS */;
INSERT INTO `formasdepagos` VALUES (1,'Tarjeta de Crédito o Débito'),(2,'Efectivo');
/*!40000 ALTER TABLE `formasdepagos` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `movimientos`
--

DROP TABLE IF EXISTS `movimientos`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `movimientos` (
  `idMovimientos` int(11) NOT NULL AUTO_INCREMENT,
  `idProductos` int(11) NOT NULL,
  `Cantidad` int(11) NOT NULL,
  `Fecha` date NOT NULL,
  `TipodeMovimiento` enum('Entrada','Salida') NOT NULL,
  `Saldo` int(11) NOT NULL,
  PRIMARY KEY (`idMovimientos`),
  KEY `movimientos_ibfk_1` (`idProductos`),
  CONSTRAINT `movimientos_ibfk_1` FOREIGN KEY (`idProductos`) REFERENCES `productos` (`idProductos`)
) ENGINE=InnoDB AUTO_INCREMENT=43 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `movimientos`
--

LOCK TABLES `movimientos` WRITE;
/*!40000 ALTER TABLE `movimientos` DISABLE KEYS */;
INSERT INTO `movimientos` VALUES (1,1,300,'2023-05-31','Entrada',300),(2,2,75,'2023-06-04','Entrada',75),(3,1,4,'2023-06-04','Salida',296),(4,1,4,'2023-06-04','Salida',292),(5,1,5,'2023-06-04','Salida',287),(6,1,5,'2023-06-04','Salida',282),(7,1,3,'2023-06-04','Salida',279),(8,1,3,'2023-06-04','Salida',276),(9,1,4,'2023-06-05','Salida',272),(10,1,4,'2023-06-05','Salida',268),(11,1,8,'2023-06-06','Salida',260),(12,1,9,'2023-06-07','Salida',251),(13,1,2,'2023-06-07','Salida',249),(14,1,2,'2023-06-07','Salida',247),(15,1,2,'2023-06-07','Salida',245),(16,1,2,'2023-06-07','Salida',243),(17,1,2,'2023-06-07','Salida',241),(18,1,2,'2023-06-07','Salida',239),(19,2,3,'2023-06-07','Salida',72),(20,1,2,'2023-06-07','Salida',237),(21,1,3,'2023-06-07','Salida',234),(22,1,2,'2023-06-07','Salida',232),(23,1,3,'2023-06-07','Salida',229),(24,1,4,'2023-06-07','Salida',225),(25,1,2,'2023-06-07','Salida',223),(26,1,5,'2023-06-07','Salida',218),(27,1,7,'2023-06-07','Salida',211),(28,1,2,'2023-06-07','Salida',209),(29,1,4,'2023-06-07','Salida',205),(30,1,4,'2023-06-07','Salida',201),(31,3,500,'2023-06-08','Entrada',-500),(32,4,43,'2023-06-08','Entrada',43),(33,5,43,'2023-06-08','Entrada',43),(34,5,24,'2023-06-08','Entrada',67),(35,6,80,'2023-06-08','Entrada',80),(36,8,92,'2023-06-08','Entrada',92),(37,3,54,'2023-06-08','Salida',446),(38,1,23,'2023-06-08','Salida',178),(39,1,3,'2023-06-08','Salida',175),(40,1,8,'2023-06-08','Salida',167),(41,2,9,'2023-06-08','Salida',63),(42,5,6,'2023-06-08','Salida',61);
/*!40000 ALTER TABLE `movimientos` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `municipios`
--

DROP TABLE IF EXISTS `municipios`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `municipios` (
  `idMunicipios` int(11) NOT NULL AUTO_INCREMENT,
  `municipios` varchar(40) NOT NULL,
  `idDepartamentos` int(11) NOT NULL,
  PRIMARY KEY (`idMunicipios`),
  KEY `fk_idDepartamentos_idx` (`idDepartamentos`),
  CONSTRAINT `fk_idDepartamentos` FOREIGN KEY (`idDepartamentos`) REFERENCES `departamentos` (`idDepartamentos`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=263 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `municipios`
--

LOCK TABLES `municipios` WRITE;
/*!40000 ALTER TABLE `municipios` DISABLE KEYS */;
INSERT INTO `municipios` VALUES (1,'Sonzacate',1),(2,'Sonsonate',1),(3,'Acajutla',1),(4,'Armenia',1),(5,'Caluco',1),(6,'Cuisnahuat',1),(7,'Izalco',1),(8,'Juayúa',1),(9,'Nahuizalco',1),(10,'Nahulingo',1),(11,'Salcoatitán',1),(12,'San Antonio del Monte',1),(13,'San Julián',1),(14,'Santa Catarina Masahuat',1),(15,'Santa Isabel Ishuatán',1),(16,'Santo Domingo de Guzmán',1),(17,'Ahuachapán',2),(18,'Apaneca',2),(19,'Atiquizaya',2),(20,'Concepción de Ataco',2),(21,'El Refugio',2),(22,'Guaymango',2),(23,'Jujutla',2),(24,'San Francisco Menéndez',2),(25,'San Lorenzo',2),(26,'San Pedro Puxtla',2),(27,'Tacuba',2),(28,'Turín',2),(29,'Sensuntepeque',3),(30,'Cinquera',3),(31,'Dolores',3),(32,'Guacotecti',3),(33,'Ilobasco',3),(34,'Jutiapa',3),(35,'San Isidro',3),(36,'Tejutepeque',3),(37,'Victoria',3),(38,'Chalatenango',4),(39,'Agua Caliente',4),(40,'Arcatao',4),(41,'Azacualpa',4),(42,'Cancasque',4),(43,'Citalá',4),(44,'Comalapa',4),(45,'Cocepción Quezaltepeque',4),(46,'Dulce Nombre de María',4),(47,'El Carrizal',4),(48,'El Paraíso',4),(49,'La Laguna',4),(50,'La Palma',4),(51,'La Reina',4),(52,'Las Flores',4),(53,'Las Vueltas',4),(54,'Nombre de Jesús',4),(55,'Nueva Concepción',4),(56,'Nueva Trinidad',4),(57,'Ojos de Agua',4),(58,'Potonico',4),(59,'San Antonio de la Cruz',4),(60,'San Antonio Los Ranchos',4),(61,'San Fernando',4),(62,'San Francisco Lempa',4),(63,'San Francisco Morazán',4),(64,'San Ignacio',4),(65,'San Isidro Labrador',4),(66,'San Luis del Carmen',4),(67,'San Miguel de Mercedes',4),(68,'San Rafael',4),(69,'Santa Rita',4),(70,'Tejutla',4),(71,'Cojutepeque',5),(72,'Candelaria',5),(73,'El Carmen',5),(74,'El Rosario',5),(75,'Monte San Juan',5),(76,'Oratorio de Concepción',5),(77,'San Bartolomé Perulapía',5),(78,'San Cristóbal',5),(79,'San José Guayabal',5),(80,'San Pedro Perulapán',5),(81,'San Rafael Cedros',5),(82,'San Ramón',5),(83,'Santa Cruz Analquito',5),(84,'Santa Cruz Michapa',5),(85,'Suchitoto',5),(86,'Tenancingo',5),(87,'Santa Tecla',6),(88,'Antiguo Cuscatlán',6),(89,'Chitiupán',6),(90,'Ciudad Arce',6),(91,'Colón',6),(92,'Comasagua',6),(93,'Huizúcar',6),(94,'Jayaque',6),(95,'Jicalapa',6),(96,'La Libertad',6),(97,'Nuevo Cuscatlán',6),(98,'Quezaltepeque',6),(99,'San Juan Opico',6),(100,'Sacacoyo',6),(101,'San José Villanueva',6),(102,'San Matías',6),(103,'San Pablo Tacachico',6),(104,'Talnique',6),(105,'Tamanique',6),(106,'Teotepeque',6),(107,'Tepecoyo',6),(108,'Zaragoza',6),(109,'Zacatecoluca',7),(110,'Cuyultitán',7),(111,'El Rosario',7),(112,'Jerusalén',7),(113,'Mercedes la Ceiba',7),(114,'Olocuilta',7),(115,'Paraíso de Osorio',7),(116,'San Antonio Masahuat',7),(117,'San Emigdio',7),(118,'San Francisco Chinameca',7),(119,'San Pedro Masahuat',7),(120,'San Juan Nonualco',7),(121,'San Juan Talpa',7),(122,'San Juan Tepezontes',7),(123,'San Luis La Herradura',7),(124,'San Luis Talpa',7),(125,'San Miguel Tepezontes',7),(126,'San Pedro Nonualco',7),(127,'San Rafael Obrajuelo',7),(128,'Santa María Ostuma',7),(129,'Santiago Nonualco',7),(130,'Tapalhuaca',7),(131,'La Unión',8),(132,'Anamorós',8),(133,'Bolívar',8),(134,'Concepción de Oriente',8),(135,'Conchagua',8),(136,'El Carmen',8),(137,'El Sauce',8),(138,'Intipucá',8),(139,'Lislique',8),(140,'Meanguera del Golfo',8),(141,'Nueva Esparta',8),(142,'Pasaquina',8),(143,'Polorós',8),(144,'San Alejo',8),(145,'San José',8),(146,'Santa Rosa de Lima',8),(147,'Yayantique',8),(148,'Yucuaiquín',8),(149,'San Francisco Gotera',9),(150,'Arambala',9),(151,'Cacaopera',9),(152,'Chilanga',9),(153,'Corinto',9),(154,'Delicias de Concepción',9),(155,'El Divisadero',9),(156,'El Rosario',9),(157,'Gualococti',9),(158,'Guatajiagua',9),(159,'Joateca',9),(160,'Jocoaitique',9),(161,'Jocoro',9),(162,'Lolotiquillo',9),(163,'Meanguera',9),(164,'Osicala',9),(165,'Perquín',9),(166,'San Carlos',9),(167,'San Fernando',9),(168,'San Isidro',9),(169,'San Simón',9),(170,'Sensembra',9),(171,'Sociedad',9),(172,'Torola',9),(173,'Yamabal',9),(174,'Yoloaiquín',9),(175,'San Miguel',10),(176,'Carolina',10),(177,'Chapeltique',10),(178,'Chinameca',10),(179,'Chirilagua',10),(180,'Ciudad Barrios',10),(181,'Comacarán',10),(182,'El Trásito',10),(183,'Lolotique',10),(184,'Moncagua',10),(185,'Nueva Guadalupe',10),(186,'Nuevo Edén de San Juan',10),(187,'Quelepa',10),(188,'San Antonio',10),(189,'San Gerardo',10),(190,'San Jorge',10),(191,'San Luis de la Reina',10),(192,'San Rafael Oriente',10),(193,'Sesori',10),(194,'Uluazapa',10),(195,'San Salvador',11),(196,'Aguilares',11),(197,'Apopa',11),(198,'Ayutuxtepeque',11),(199,'Ciudad Delgado',11),(200,'Cuscatancingo',11),(201,'El Paisnal',11),(202,'Guazapa',11),(203,'Ilopango',11),(204,'Mejicanos',11),(205,'Nejapa',11),(206,'Panchimalco',11),(207,'Rosario de Mora',11),(208,'San Marcos',11),(209,'San Martín',11),(210,'Santiago Texacuangos',11),(211,'Santo Tomás',11),(212,'Soyapango',11),(213,'Tonacatepeque',11),(214,'San Vicente',12),(215,'Apastepeque',12),(216,'Guadalupe',12),(217,'San Cayetano Istepeque',12),(218,'San Esteban Catarina',12),(219,'San Ildefonso',12),(220,'San Lorenzo',12),(221,'San Sebastián',12),(222,'Santa Clara',12),(223,'Santo Domingo',12),(224,'Tecoluca',12),(225,'Tepetitán',12),(226,'Verapaz',12),(227,'Santa Ana',13),(228,'Candelaria de la Frontera',13),(229,'Chalchuapa',13),(230,'Coatepeque',13),(231,'El Congo',13),(232,'El Porvenir',13),(233,'Masahuat',13),(234,'Metapán',13),(235,'San Antonio Pajonal',13),(236,'San Sebastián Salitrillo',13),(237,'Santa Rosa Guachipilín',13),(238,'Santiago de la Frontera',13),(239,'Texistepeque',13),(240,'Usulután',14),(241,'Alegría',14),(242,'Berlin',14),(243,'California',14),(244,'Concepción Batres',14),(245,'El Triunfo',14),(246,'Ereguayquín',14),(247,'Estanzuelas',14),(248,'Jiquilisco',14),(249,'Jucuapa',14),(250,'Juacuarán',14),(251,'Mercedes Umaña',14),(252,'Nueva Granada',14),(253,'Ozatlán',14),(254,'Puerto El Triunfo',14),(255,'San Agustín',14),(256,'San Buenaventura',14),(257,'San Dionisio',14),(258,'San Francisco Javier',14),(259,'Santa Elena',14),(260,'Santa María',14),(261,'Santiago de María',14),(262,'Tecapán',14);
/*!40000 ALTER TABLE `municipios` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `opciones`
--

DROP TABLE IF EXISTS `opciones`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `opciones` (
  `idOpciones` int(11) NOT NULL AUTO_INCREMENT,
  `Opciones` varchar(30) NOT NULL,
  `idClasificaciones` int(11) NOT NULL,
  PRIMARY KEY (`idOpciones`),
  KEY `opciones_ibfk_1` (`idClasificaciones`),
  CONSTRAINT `opciones_ibfk_1` FOREIGN KEY (`idClasificaciones`) REFERENCES `clasificaciones` (`idClasificaciones`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `opciones`
--

LOCK TABLES `opciones` WRITE;
/*!40000 ALTER TABLE `opciones` DISABLE KEYS */;
/*!40000 ALTER TABLE `opciones` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `permisos`
--

DROP TABLE IF EXISTS `permisos`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `permisos` (
  `idPermisos` int(11) NOT NULL AUTO_INCREMENT,
  `idRoles` int(11) NOT NULL,
  `idOpciones` int(11) NOT NULL,
  PRIMARY KEY (`idPermisos`),
  KEY `permisos_ibfk_1` (`idRoles`),
  KEY `permisos_ibfk_2` (`idOpciones`),
  CONSTRAINT `permisos_ibfk_1` FOREIGN KEY (`idRoles`) REFERENCES `roles` (`idRoles`),
  CONSTRAINT `permisos_ibfk_2` FOREIGN KEY (`idOpciones`) REFERENCES `opciones` (`idOpciones`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `permisos`
--

LOCK TABLES `permisos` WRITE;
/*!40000 ALTER TABLE `permisos` DISABLE KEYS */;
/*!40000 ALTER TABLE `permisos` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `productos`
--

DROP TABLE IF EXISTS `productos`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `productos` (
  `idProductos` int(11) NOT NULL AUTO_INCREMENT,
  `Productos` varchar(60) NOT NULL,
  `PrecioUnitario` decimal(4,2) NOT NULL,
  `Marca` varchar(25) NOT NULL,
  `Stock` int(11) NOT NULL,
  PRIMARY KEY (`idProductos`)
) ENGINE=InnoDB AUTO_INCREMENT=105 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `productos`
--

LOCK TABLES `productos` WRITE;
/*!40000 ALTER TABLE `productos` DISABLE KEYS */;
INSERT INTO `productos` VALUES (1,'Bolsa de cemento Cessa',9.50,'Holcim',167),(2,'Cinta metrica',5.25,'Truper',63),(3,'Bolsa de cemento Cuscatlan',8.60,'Holcim',446),(4,'Pegamento PVC',2.50,'Durman',43),(5,'Brocha',0.80,'Truper',61),(6,'Brocha',0.90,'Truper',80),(7,'Brocha',1.00,'Truper',0),(8,'Bolsa de PowerMix',8.00,'Reflex',92),(9,'Tubo PVC 1/2\"',3.50,'Amanco',0),(10,'Galon Pintura',9.00,'Megacolor',0),(11,'Spray',2.00,'ABRO',0),(12,'Llave P/piso',3.00,'Foset',0),(13,'Llave P/piso',3.00,'Foset',0),(14,'Libra clavo 1\"',0.50,'Fiero',0),(15,'Libra clavo 2\"',0.50,'Fiero',0),(16,'Libra clavo 3\"',0.50,'Fiero',0),(17,'Libra clavo 4\"',0.50,'Fiero',0),(18,'QQ Hierro 1/4\"',35.00,'Corinca',0),(19,'QQ Hierro 3/8\"',35.00,'Corinca',0),(20,'Tornillo',0.15,'Truper',0),(21,'Tornillos 6-32 x 1/2\"',0.15,'Ciser',0),(22,'Tornillos 8-32 x 3/4\"',0.30,'Ciser',0),(23,'Tornillos 10-32 x 1\"',0.50,'Ciser',0),(24,'Tornillos 6-32 x 3/4\"',0.30,'Romasa',0),(25,'Tornillos 8-32 x 1\"',0.35,'Romasa',0),(26,'Tornillos 10-32 x 1 1/4\"',0.85,'Romasa',0),(27,'Tornillos 6 x 1\"',0.25,'Martek.',0),(28,'Tornillos 8 x 1 1/4\"',0.50,'Martek.',0),(29,'Tornillos 10 x 2\"',0.65,'Martek.',0),(30,'Tornillos 3/16\" x 1 1/4\"',0.40,'Tornikasa',0),(31,'Tornillos 1/4\" x 2 1/4\"',0.65,'Tornikasa',0),(32,'Tornillos 3/8\" x 3\"',0.75,'Tornikasa',0),(33,'Codo PVC 90 grados 1/2\"',0.30,'Amanco',0),(34,'Codo PVC 90 grados 3/4\"',0.45,'Amanco',0),(35,'Codo PVC 90 grados 1\"',0.90,'Amanco',0),(36,'Codo PVC 90 grados 1 1/4\"',1.30,'Amanco',0),(37,'Codo PVC 90 grados 1 1/2\"',1.90,'Amanco',0),(38,'Codo PVC 90 grados 2\"',2.50,'Amanco',0),(39,'Codo PVC 90 grados 3\"',2.75,'Amanco',0),(40,'Codo PVC 90 grados 4\"',3.80,'Amanco',0),(41,'Codo PVC 90 grados 6\"',4.25,'Amanco',0),(42,'Codo PVC 45 grados 1/2\"',0.35,'Amanco',0),(43,'Codo PVC 45 grados 3/4\"',0.50,'Amanco',0),(44,'Codo PVC 45 grados 1\"',1.00,'Amanco',0),(45,'Codo PVC 45 grados 1 1/4\"',1.30,'Amanco',0),(46,'Codo PVC 45 grados 1 1/2\"',1.90,'Amanco',0),(47,'Codo PVC 45 grados 2\"',2.70,'Amanco',0),(48,'Codo PVC 45 grados 3\"',2.80,'Amanco',0),(49,'Codo PVC 45 grados 4\"',3.90,'Amanco',0),(50,'Codo PVC 45 grados 6\"',4.50,'Amanco',0),(51,'Codo PVC 90 c/r grados 1/2\"',0.35,'Amanco',0),(52,'Codo PVC 90 c/r grados 3/4\"',0.55,'Amanco',0),(53,'Codo PVC 90 c/r grados 1\"',0.95,'Amanco',0),(54,'Codo PVC 90 c/r grados 1 1/4\"',1.50,'Amanco',0),(55,'Codo PVC 90 c/r grados 1 1/2\"',2.00,'Amanco',0),(56,'Codo PVC 90 c/r grados 2\"',2.60,'Amanco',0),(57,'Codo PVC 90 c/r grados 3\"',2.80,'Amanco',0),(58,'Codo PVC 90 c/r grados 4\"',3.90,'Amanco',0),(59,'Codo PVC 90 c/r grados 6\"',4.50,'Amanco',0),(60,'Codo PVC 45 c/r grados 1/2\"',0.35,'Amanco',0),(61,'Codo PVC 45 c/r grados 3/4\"',0.55,'Amanco',0),(62,'Codo PVC 45 c/r grados 1\"',1.50,'Amanco',0),(63,'Codo PVC 45 c/r grados 1 1/4\"',1.60,'Amanco',0),(64,'Codo PVC 45 c/r grados 1 1/2\"',1.95,'Amanco',0),(65,'Codo PVC 45 c/r grados 2\"',2.80,'Amanco',0),(66,'Codo PVC 45 c/r grados 3\"',3.30,'Amanco',0),(67,'Codo PVC 45 c/r grados 4\"',4.00,'Amanco',0),(68,'Codo PVC 45 c/r grados 6\"',5.00,'Amanco',0),(69,'Unión PVC de 1/2\"',0.35,'Amanco',0),(70,'Unión PVC de 3/4\"',0.50,'Amanco',0),(71,'Unión PVC de 1\"',1.00,'Amanco',0),(72,'Unión PVC de 1 1/4\"',1.30,'Amanco',0),(73,'Unión PVC de 1 1/2\"',1.90,'Amanco',0),(74,'Unión PVC de  2\"',2.70,'Amanco',0),(75,'Unión PVC de  3\"',2.80,'Amanco',0),(76,'Unión PVC de  4\"',3.90,'Amanco',0),(77,'Unión PVC de 6\"',4.50,'Amanco',0),(78,'Unión PVC c/r de 1/2\"',0.45,'Amanco',0),(79,'Unión PVC c/r de 3/4\"',0.55,'Amanco',0),(80,'Unión PVC c/r de 1\"',1.25,'Amanco',0),(81,'Unión PVC c/r de 1 1/4\"',1.40,'Amanco',0),(82,'Unión PVC c/r de 1 1/2\"',2.00,'Amanco',0),(83,'Unión PVC c/r de  2\"',2.80,'Amanco',0),(84,'Unión PVC c/r de  3\"',3.00,'Amanco',0),(85,'Unión PVC c/r de  4\"',4.00,'Amanco',0),(86,'Unión PVC c/r de 6\"',4.80,'Amanco',0),(87,'Adaptador PVC  1/2\"',0.35,'Amanco',0),(88,'Adaptador PVC  3/4\"',0.50,'Amanco',0),(89,'Adaptador PVC  1\"',1.00,'Amanco',0),(90,'Adaptador PVC e 1 1/4\"',1.30,'Amanco',0),(91,'Adaptador PVC 1 1/2\"',1.90,'Amanco',0),(92,'Adaptador PVC  2\"',2.70,'Amanco',0),(93,'Adaptador PVC   3\"',2.80,'Amanco',0),(94,'Adaptador PVC  4\"',3.90,'Amanco',0),(95,'Adaptador PVC  6\"',4.50,'Amanco',0),(96,'Tapón PVC 1/2\"',0.35,'Amanco',0),(97,'Tapón PVC 3/4\"',0.50,'Amanco',0),(98,'Tapón PVC 1\"',1.00,'Amanco',0),(99,'Tapón PVCe 1 1/4\"',1.30,'Amanco',0),(100,'Tapón PVC 1 1/2\"',1.90,'Amanco',0),(101,'Tapón PVC 2\"',2.70,'Amanco',0),(102,'Tapón PVC   3\"',2.80,'Amanco',0),(103,'Tapón PVC 4\"',3.90,'Amanco',0),(104,'Tapón PVC  6\"',4.50,'Amanco',0);
/*!40000 ALTER TABLE `productos` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `proveedores`
--

DROP TABLE IF EXISTS `proveedores`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `proveedores` (
  `idProveedores` int(11) NOT NULL AUTO_INCREMENT,
  `Proveedor` varchar(80) NOT NULL,
  `Telefono` varchar(10) NOT NULL,
  `Correo` varchar(25) NOT NULL,
  `idDirecciones` int(11) NOT NULL,
  PRIMARY KEY (`idProveedores`),
  KEY `proveedores_ibfk_1` (`idDirecciones`),
  CONSTRAINT `proveedores_ibfk_1` FOREIGN KEY (`idDirecciones`) REFERENCES `direcciones` (`idDirecciones`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `proveedores`
--

LOCK TABLES `proveedores` WRITE;
/*!40000 ALTER TABLE `proveedores` DISABLE KEYS */;
INSERT INTO `proveedores` VALUES (1,'La Palma','2222','lp@gmail.com',1);
/*!40000 ALTER TABLE `proveedores` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `roles`
--

DROP TABLE IF EXISTS `roles`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `roles` (
  `idRoles` int(11) NOT NULL AUTO_INCREMENT,
  `Roles` varchar(25) NOT NULL,
  PRIMARY KEY (`idRoles`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `roles`
--

LOCK TABLES `roles` WRITE;
/*!40000 ALTER TABLE `roles` DISABLE KEYS */;
INSERT INTO `roles` VALUES (1,'Administrador'),(2,'Vendedor'),(3,'Bodeguero');
/*!40000 ALTER TABLE `roles` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `usuarios`
--

DROP TABLE IF EXISTS `usuarios`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `usuarios` (
  `idUsuarios` int(11) NOT NULL AUTO_INCREMENT,
  `Usuario` varchar(12) NOT NULL,
  `Clave` varchar(200) NOT NULL,
  `idRoles` int(11) NOT NULL,
  `idEmpleados` int(11) NOT NULL,
  PRIMARY KEY (`idUsuarios`),
  KEY `usuarios_ibfk_1` (`idEmpleados`),
  KEY `usuarios_ibfk_2` (`idRoles`),
  CONSTRAINT `usuarios_ibfk_1` FOREIGN KEY (`idEmpleados`) REFERENCES `empleados` (`idEmpleados`),
  CONSTRAINT `usuarios_ibfk_2` FOREIGN KEY (`idRoles`) REFERENCES `roles` (`idRoles`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `usuarios`
--

LOCK TABLES `usuarios` WRITE;
/*!40000 ALTER TABLE `usuarios` DISABLE KEYS */;
INSERT INTO `usuarios` VALUES (1,'RCASTRO','62feb4e4213e8b4aec4954f13a264b56449781ab',1,1),(2,'CMARISOL','33360d0f2e7adcb39b688ce770d48f3d0115db6d',2,2);
/*!40000 ALTER TABLE `usuarios` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `ventas`
--

DROP TABLE IF EXISTS `ventas`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `ventas` (
  `idVentas` int(11) NOT NULL AUTO_INCREMENT,
  `idClientes` int(11) DEFAULT NULL,
  `idEmpleados` int(11) NOT NULL,
  `idFormasdePago` int(11) NOT NULL,
  `Fecha` datetime NOT NULL,
  `Total` decimal(10,2) NOT NULL,
  PRIMARY KEY (`idVentas`),
  KEY `ventas_ibfk_2` (`idEmpleados`),
  KEY `ventas_ibfk_3` (`idFormasdePago`),
  KEY `ventas_ibfk_1` (`idClientes`),
  CONSTRAINT `ventas_ibfk_1` FOREIGN KEY (`idClientes`) REFERENCES `clientes` (`idClientes`),
  CONSTRAINT `ventas_ibfk_2` FOREIGN KEY (`idEmpleados`) REFERENCES `empleados` (`idEmpleados`),
  CONSTRAINT `ventas_ibfk_3` FOREIGN KEY (`idFormasdePago`) REFERENCES `formasdepagos` (`idFormasdePagos`)
) ENGINE=InnoDB AUTO_INCREMENT=81 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `ventas`
--

LOCK TABLES `ventas` WRITE;
/*!40000 ALTER TABLE `ventas` DISABLE KEYS */;
INSERT INTO `ventas` VALUES (54,1,1,1,'2023-06-06 00:00:00',1.00),(55,1,1,2,'2023-06-07 00:43:26',216.75),(56,1,1,1,'2023-06-07 11:48:26',29.50),(57,1,2,1,'2023-06-07 11:54:27',123.50),(58,1,1,1,'2023-06-07 11:56:04',29.50),(59,1,1,1,'2023-06-07 14:16:28',34.75),(60,1,1,1,'2023-06-07 14:36:59',34.75),(61,1,1,1,'2023-06-07 15:02:31',34.75),(62,1,1,1,'2023-06-07 15:44:29',39.00),(63,1,1,1,'2023-06-07 15:46:14',98.00),(64,1,1,1,'2023-06-07 15:46:18',98.00),(65,1,1,1,'2023-06-07 15:47:49',34.75),(66,1,1,1,'2023-06-07 15:56:46',92.75),(67,1,1,1,'2023-06-07 15:59:46',92.75),(68,1,1,1,'2023-06-07 16:04:00',139.75),(69,1,1,1,'2023-06-07 16:05:33',39.00),(70,1,1,1,'2023-06-07 16:07:23',34.75),(71,1,1,1,'2023-06-07 16:20:21',49.50),(72,1,1,1,'2023-06-07 21:47:24',64.25),(73,1,1,1,'2023-06-07 22:09:07',40.00),(74,1,1,1,'2023-06-07 22:15:00',168.75),(75,1,1,1,'2023-06-07 22:30:51',53.75),(76,1,1,1,'2023-06-07 22:36:39',64.25),(77,1,1,1,'2023-06-08 03:18:03',1423.15),(78,1,1,1,'2023-06-08 03:18:53',444.25),(79,1,1,1,'2023-06-08 03:20:25',42.60),(80,1,1,1,'2023-06-08 03:22:27',128.05);
/*!40000 ALTER TABLE `ventas` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2023-06-08 11:55:42
