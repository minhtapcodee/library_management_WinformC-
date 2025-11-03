-- MySQL dump 10.13  Distrib 8.0.40, for Win64 (x86_64)
--
-- Host: 127.0.0.1    Database: quanlythuvien
-- ------------------------------------------------------
-- Server version	8.0.40

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
-- Table structure for table `borrow`
--

DROP TABLE IF EXISTS `borrow`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `borrow` (
  `TransactionID` int NOT NULL AUTO_INCREMENT,
  `BookID` int NOT NULL,
  `BookTitle` varchar(255) NOT NULL,
  `Author` varchar(255) DEFAULT NULL,
  `Category` varchar(100) DEFAULT NULL,
  `BorrowerID` int NOT NULL,
  `BorrowerName` varchar(255) NOT NULL,
  `ContactInfo` varchar(255) DEFAULT NULL,
  `StaffID` int DEFAULT NULL,
  `StaffName` varchar(255) DEFAULT NULL,
  `BorrowDate` date NOT NULL,
  `DueDate` date NOT NULL,
  `ReturnDate` date DEFAULT NULL,
  `TransactionStatus` varchar(50) DEFAULT 'Borrowed',
  `PenaltyFee` decimal(10,2) DEFAULT '0.00',
  PRIMARY KEY (`TransactionID`)
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `borrow`
--

LOCK TABLES `borrow` WRITE;
/*!40000 ALTER TABLE `borrow` DISABLE KEYS */;
INSERT INTO `borrow` VALUES (1,1,'The Great Gatsby','F. Scott Fitzgerald','Fiction',101,'Nguyen Van A','0123456789',201,'Tran Thi B','2025-03-01','2025-03-15',NULL,'Borrowed',0.00),(3,2,'To Kill a Mockingbird','Harper Lee','Drama',102,'Le Thi C','0987654321',202,'Pham Van D','2025-03-05','2025-03-20',NULL,'Returned',5.00),(4,654,'jhng','t','gnh',634,'ret','09876',654,'s','2025-04-02','2025-04-10','2025-04-18','Returned',0.00),(5,5,'gfhg','fgh','hg',54,'dh','06567443',35,'bgf','2025-04-01','2025-04-18','2025-04-18','Borrowed',0.00),(6,534,'ytfg','rtth','dfb',234,'minh','098543',454,'nhbg','2025-04-02','2025-04-18','2025-04-26','Borrowed',0.00);
/*!40000 ALTER TABLE `borrow` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `chamcong`
--

DROP TABLE IF EXISTS `chamcong`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `chamcong` (
  `ChamCongID` int NOT NULL AUTO_INCREMENT,
  `UserID` int NOT NULL,
  `NgayChamCong` date NOT NULL,
  `GioVao` time DEFAULT NULL,
  `GioRa` time DEFAULT NULL,
  `HinhAnh` varchar(255) CHARACTER SET utf8mb3 COLLATE utf8mb3_general_ci DEFAULT NULL,
  `GhiChu` varchar(255) CHARACTER SET utf8mb3 COLLATE utf8mb3_general_ci DEFAULT NULL,
  `TrangThai` enum('Chờ xác nhận','Đã xác nhận','Từ chối') NOT NULL DEFAULT 'Chờ xác nhận',
  `NgayXacNhan` date DEFAULT NULL,
  `AdminXacNhanID` int DEFAULT NULL,
  PRIMARY KEY (`ChamCongID`),
  UNIQUE KEY `UserID` (`UserID`,`NgayChamCong`),
  KEY `AdminXacNhanID` (`AdminXacNhanID`),
  CONSTRAINT `chamcong_ibfk_1` FOREIGN KEY (`UserID`) REFERENCES `users` (`ID`),
  CONSTRAINT `chamcong_ibfk_2` FOREIGN KEY (`AdminXacNhanID`) REFERENCES `users` (`ID`)
) ENGINE=InnoDB AUTO_INCREMENT=24 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `chamcong`
--

LOCK TABLES `chamcong` WRITE;
/*!40000 ALTER TABLE `chamcong` DISABLE KEYS */;
INSERT INTO `chamcong` VALUES (1,7,'2025-05-03','08:00:00','17:00:00','/images/chamcong_nhanvien01_20250503.jpg','Chấm công ngày 3/5/2025','Chờ xác nhận',NULL,NULL),(8,13,'2025-05-04','08:30:00','17:30:00','/images/chamcong_nhanvien02_20250504.jpg','Chấm công ngày 4/5/2025','Đã xác nhận','2025-05-05',6),(9,12,'2025-05-05','09:00:00','18:00:00','/images/chamcong_nhanvien03_20250505.jpg','Chấm công ngày 5/5/2025','Chờ xác nhận',NULL,NULL),(10,10,'2025-05-06','08:15:00','16:45:00','/images/chamcong_nhanvien04_20250506.jpg','Chấm công ngày 6/5/2025','Từ chối','2025-05-06',6),(11,7,'2025-07-03','08:15:00','17:00:00','GUI/Image\\3ac05dc0-6476-47d0-bb2f-4c73f9011031.png','hihi','Chờ xác nhận',NULL,NULL),(14,13,'2025-06-04','08:30:00','17:30:00','GUI/Image\\anh-sach-vo-6.jpg','Chấm công ngày 14/5/2025','Đã xác nhận','2025-07-09',NULL),(15,13,'2025-07-04','08:30:00','17:30:00','GUI/Image\\thuvien.png','Chấm công ngày 4/5/2025','Chờ xác nhận','2025-05-05',NULL),(16,13,'2025-08-04','08:30:00','17:30:00','GUI/Image\\xinchao.jpg','Chấm công ngày 14/5/2025','Từ chối','2025-05-07',NULL),(17,7,'2025-05-07','08:30:00','16:10:00','GUI/Image\\Not-Your-Boring-Book-Club-Hero.jpeg','hohoff','Đã xác nhận','2025-05-08',NULL),(18,13,'2025-05-07','08:00:00','19:00:00','GUI/Image\\Screenshot 2025-04-19 110206.jpg','àgg','Chờ xác nhận',NULL,NULL),(19,7,'2025-05-08','09:00:00','13:00:00','GUI/Image\\244282652-300923341507642-2134-4375-4818-1634175456.jpg','sớm','Đã xác nhận',NULL,NULL),(20,7,'2025-05-09','09:00:00','17:00:00','GUI/Image\\car.png','sd','Chờ xác nhận',NULL,NULL),(21,7,'2025-05-28','08:00:00','16:30:00','GUI/Image\\chamcong.jpg','Xin phép về sớm 30 phút ','Chờ xác nhận',NULL,NULL),(22,7,'2025-05-29','08:00:00','09:00:00','GUI/Image\\b39c69b07642c61c9f53.jpg','sgf','Đã xác nhận',NULL,NULL),(23,13,'2025-05-29','08:00:00','09:01:00','GUI/Image\\2024-09-08.png','sdg','Chờ xác nhận',NULL,NULL);
/*!40000 ALTER TABLE `chamcong` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `khosach`
--

DROP TABLE IF EXISTS `khosach`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `khosach` (
  `MaKho` int NOT NULL AUTO_INCREMENT,
  `MaSach` varchar(10) NOT NULL,
  `SoLuongNhap` int NOT NULL,
  `SoLuongDangMuon` int NOT NULL DEFAULT '0',
  `SoLuongConLai` int DEFAULT NULL,
  `MoTa` varchar(255) CHARACTER SET utf8mb3 COLLATE utf8mb3_general_ci DEFAULT NULL,
  `NgayNhap` date NOT NULL,
  `MaNhanVien` int NOT NULL,
  PRIMARY KEY (`MaKho`),
  KEY `MaSach` (`MaSach`),
  KEY `MaNhanVien` (`MaNhanVien`),
  CONSTRAINT `khosach_ibfk_1` FOREIGN KEY (`MaSach`) REFERENCES `sach` (`MaSach`),
  CONSTRAINT `khosach_ibfk_2` FOREIGN KEY (`MaNhanVien`) REFERENCES `users` (`ID`)
) ENGINE=InnoDB AUTO_INCREMENT=36 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `khosach`
--

LOCK TABLES `khosach` WRITE;
/*!40000 ALTER TABLE `khosach` DISABLE KEYS */;
INSERT INTO `khosach` VALUES (12,'S009',8,1,4,'htthht','2025-04-18',10),(14,'S011',5,1,3,'hj','2025-05-09',16),(18,'S098',41,1,39,'hiiiiiiiiiiiiiiiiiii','2025-02-12',22),(19,'S876',8,1,6,'123456','2025-05-27',23),(20,'S879',78,0,78,'ưer','2025-07-17',22),(21,'S009',2,0,2,'ưertyu','2025-06-11',16),(22,'S010',24,0,24,'ui','2025-05-27',10),(23,'S004',50,2,47,'ghh','2025-09-09',16),(24,'S009',34,0,34,'tree','2025-10-24',22),(27,'S876',30,1,28,'trew','2025-12-11',14),(28,'S879',10,0,10,'tre','2025-05-27',7),(29,'S876',23,0,23,'fff','2025-06-06',22),(32,'S153',43,0,43,'nhập thêm sách','2024-06-18',12),(34,'S0300',43,0,43,'sdd','2025-05-29',12);
/*!40000 ALTER TABLE `khosach` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `lichsunhapxuat`
--

DROP TABLE IF EXISTS `lichsunhapxuat`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `lichsunhapxuat` (
  `ID` int NOT NULL AUTO_INCREMENT,
  `MaSach` varchar(10) NOT NULL,
  `TenSach` varchar(100) CHARACTER SET utf8mb3 COLLATE utf8mb3_general_ci NOT NULL,
  `LoaiGiaoDich` varchar(20) NOT NULL,
  `SoLuong` int NOT NULL,
  `NgayGiaoDich` date NOT NULL,
  `MaNhanVien` int NOT NULL,
  `MoTa` text,
  PRIMARY KEY (`ID`),
  KEY `MaSach` (`MaSach`),
  KEY `MaNhanVien` (`MaNhanVien`),
  CONSTRAINT `lichsunhapxuat_ibfk_1` FOREIGN KEY (`MaSach`) REFERENCES `sach` (`MaSach`),
  CONSTRAINT `lichsunhapxuat_ibfk_2` FOREIGN KEY (`MaNhanVien`) REFERENCES `users` (`ID`)
) ENGINE=InnoDB AUTO_INCREMENT=34 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `lichsunhapxuat`
--

LOCK TABLES `lichsunhapxuat` WRITE;
/*!40000 ALTER TABLE `lichsunhapxuat` DISABLE KEYS */;
INSERT INTO `lichsunhapxuat` VALUES (1,'S003','Công nghệ C#','Nhập',10,'2025-01-01',7,'Sách mới nhập '),(3,'S001','Dế Mèn Phiêu Lưu Ký ','Xóa',3,'2025-03-01',7,' sách thiếu '),(4,'S098','Hi Vong','Nhập',40,'2025-02-12',22,'hiiiiiiiiiiiiiiiiiii'),(5,'S876','Một chút hi vọng','Nhập',8,'2025-05-27',23,'123456'),(6,'S879','Co len','Nhập',78,'2025-07-17',22,'ưer'),(7,'S009','Hihihaa','Nhập',2,'2025-06-11',16,'ưertyu'),(8,'S010','www','Nhập',24,'2025-05-27',10,'ui'),(9,'S004','dggfb','Nhập',59,'2025-09-09',16,'ghh'),(10,'S009','Hihihaa','Nhập',34,'2025-10-24',22,'tree'),(11,'S876','Một chút hi vọng','Nhập',89,'2025-11-22',23,'le truong giang'),(12,'S879','Co len','Nhập',14,'2025-12-27',13,'thuuuuu'),(15,'S879','Co len','Nhập',10,'2025-05-27',7,'tre'),(17,'S003','Công nghệ C#','Xuất',16,'2025-05-28',16,'Xóa khỏi kho: hhtt1'),(19,'S014','Những điều thú vị','Nhập',30,'2025-05-28',14,'vvv'),(20,'S014','Những điều thú vị','Nhập',12,'2025-05-30',13,'fd'),(21,'S014','Những điều thú vị','Xuất',13,'2025-05-28',13,'Xóa khỏi kho: fddff'),(22,'S003','Công nghệ C#','Xuất',43,'2025-05-28',22,'Xóa khỏi kho: sd'),(23,'S153','Nhà giả kim','Nhập',43,'2024-06-18',12,'nhập thêm sách'),(24,'S010','www','Nhập',65,'2025-05-31',16,'fg'),(25,'S0300','hh','Nhập',43,'2025-05-29',12,'sdd'),(26,'S010','www','Xuất',10,'2025-05-29',17,'Xóa khỏi kho: ANhMinh khách quen'),(27,'S010','www','Xuất',65,'2025-05-29',16,'Xóa khỏi kho: fg'),(28,'S876','Một chút hi vọng','Xuất',89,'2025-05-29',23,'Xóa khỏi kho: le truong giang'),(32,'S014','Những điều thú vị','Xuất',30,'2025-05-29',14,'Xóa khỏi kho: vvv'),(33,'S001','Dế Mèn Phiêu Lưu Ký','Xuất',6,'2025-05-29',17,'Xóa khỏi kho: htth');
/*!40000 ALTER TABLE `lichsunhapxuat` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `muontra`
--

DROP TABLE IF EXISTS `muontra`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `muontra` (
  `MaMT` int NOT NULL AUTO_INCREMENT,
  `MaSach` varchar(10) NOT NULL,
  `MaNguoiMuon` int NOT NULL,
  `MaNhanVien` int NOT NULL,
  `NgayMuon` date NOT NULL,
  `NgayTraDuKien` date NOT NULL,
  `NgayTraThucTe` date DEFAULT NULL,
  `TienPhat` decimal(10,2) DEFAULT NULL,
  `TrangThai` enum('Đang mượn','Đã trả','Quá hạn (chưa trả)','Quá hạn (đã trả)') NOT NULL DEFAULT 'Đang mượn',
  PRIMARY KEY (`MaMT`),
  KEY `MaSach` (`MaSach`),
  KEY `MaNguoiMuon` (`MaNguoiMuon`),
  KEY `MaNhanVien` (`MaNhanVien`),
  CONSTRAINT `muontra_ibfk_1` FOREIGN KEY (`MaSach`) REFERENCES `sach` (`MaSach`),
  CONSTRAINT `muontra_ibfk_2` FOREIGN KEY (`MaNguoiMuon`) REFERENCES `users` (`ID`),
  CONSTRAINT `muontra_ibfk_3` FOREIGN KEY (`MaNhanVien`) REFERENCES `users` (`ID`)
) ENGINE=InnoDB AUTO_INCREMENT=64 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `muontra`
--

LOCK TABLES `muontra` WRITE;
/*!40000 ALTER TABLE `muontra` DISABLE KEYS */;
INSERT INTO `muontra` VALUES (3,'S001',8,7,'2025-04-01','2025-04-08',NULL,0.00,'Đang mượn'),(5,'S002',14,12,'2025-04-01','2025-04-08','2025-05-07',1.00,'Đã trả'),(22,'S001',8,7,'2025-04-08','2025-04-08','2025-04-08',0.00,'Đã trả'),(27,'S001',8,7,'2025-04-08','2025-04-08','2025-04-17',0.00,'Quá hạn (đã trả)'),(28,'S002',13,7,'2025-04-08','2025-04-08','2025-04-08',0.00,'Đã trả'),(29,'S002',13,10,'2025-04-08','2025-04-08','2025-04-09',2.00,'Quá hạn (chưa trả)'),(30,'S002',13,10,'2025-04-08','2025-04-17','2025-04-08',0.00,'Đã trả'),(31,'S002',13,12,'2025-04-08','2025-04-09',NULL,NULL,'Đang mượn'),(32,'S003',15,16,'2025-04-16','2025-04-18',NULL,NULL,'Đang mượn'),(34,'S003',13,12,'2025-04-17','2025-04-25','2025-04-17',0.00,'Đã trả'),(35,'S001',8,16,'2025-04-07','2025-04-12','2025-04-18',2000.00,'Quá hạn (chưa trả)'),(36,'S001',15,10,'2025-04-01','2025-04-25','2025-04-01',0.00,'Đang mượn'),(39,'S001',15,17,'2025-04-08','2025-04-18',NULL,NULL,'Đang mượn'),(42,'S009',15,17,'2025-04-09','2025-04-18','2025-05-27',0.00,'Quá hạn (chưa trả)'),(43,'S003',13,12,'2025-04-01','2025-04-10',NULL,NULL,'Đang mượn'),(45,'S010',20,12,'2025-05-06','2025-05-09','2025-05-25',2000.00,'Quá hạn (đã trả)'),(46,'S011',20,7,'2025-05-09','2025-05-09',NULL,NULL,'Đang mượn'),(48,'S010',20,13,'2025-05-25','2025-05-24',NULL,NULL,'Đang mượn'),(50,'S003',20,12,'2025-05-27','2025-05-30',NULL,NULL,'Đang mượn'),(51,'S876',20,21,'2025-05-28','2025-05-30',NULL,NULL,'Đang mượn'),(53,'S003',20,13,'2025-05-28','2025-05-28',NULL,NULL,'Đang mượn'),(54,'S004',15,12,'2025-05-28','2025-05-28',NULL,NULL,'Đang mượn'),(57,'S003',20,16,'2025-05-28','2025-05-28',NULL,NULL,'Đang mượn'),(59,'S014',8,7,'2025-05-28','2025-05-28',NULL,NULL,'Đang mượn'),(60,'S014',15,21,'2025-05-28','2025-05-20',NULL,NULL,'Đang mượn'),(61,'S004',8,7,'2025-05-29','2025-05-30',NULL,NULL,'Đang mượn'),(62,'S098',8,7,'2025-05-29','2025-05-30',NULL,NULL,'Đang mượn');
/*!40000 ALTER TABLE `muontra` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `sach`
--

DROP TABLE IF EXISTS `sach`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `sach` (
  `MaSach` varchar(10) NOT NULL,
  `TenSach` varchar(200) CHARACTER SET utf8mb3 COLLATE utf8mb3_general_ci NOT NULL,
  `TacGia` varchar(100) CHARACTER SET utf8mb3 COLLATE utf8mb3_general_ci DEFAULT NULL,
  `NamXB` int DEFAULT NULL,
  `NhaXB` varchar(100) CHARACTER SET utf8mb3 COLLATE utf8mb3_general_ci DEFAULT NULL,
  `TinhTrang` varchar(20) DEFAULT NULL,
  `Gia` decimal(10,2) DEFAULT NULL,
  `MoTa` text,
  `HinhAnh` varchar(255) CHARACTER SET utf8mb3 COLLATE utf8mb3_general_ci DEFAULT NULL,
  PRIMARY KEY (`MaSach`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `sach`
--

LOCK TABLES `sach` WRITE;
/*!40000 ALTER TABLE `sach` DISABLE KEYS */;
INSERT INTO `sach` VALUES ('S001','Dế Mèn Phiêu Lưu Ký','Tô Hoài',1941,'NXB Kim Đồng','Còn',50000.00,'Cuốn sách thiếu nhi nổi tiếng.\r\nVị Trí Sách : Kệ B3, tầng 1','C:\\Users\\DELL\\Visual .NET folder\\QUANLYTHUVIENC3\\QUANLYTHUVIENC3\\GUI\\img\\dacnhantam.jpg'),('S002','Vũ Trụ Trong Một Hạt Cát','Stephen Hawking',1988,'NXB Trẻ','Còn',120000.00,'Sách khoa học phổ thông.\r\nVị trí sách : Kệ B2, tầng 1','C:\\Users\\DELL\\Visual .NET folder\\QUANLYTHUVIENC3\\QUANLYTHUVIENC3\\GUI\\img\\cautrucdulieu.jpg'),('S003','Công nghệ C#','Anh Minh',1941,'NXB Hunre','Còn',70000.00,'Cuốn sách công nghệ .\r\nVị trí sách : Kệ A1, tầng 1','C:\\Users\\DELL\\Visual .NET folder\\QUANLYTHUVIENC3\\QUANLYTHUVIENC3\\GUI\\img\\kythuat.jpg'),('S004','Lập trình và cuộc sống','Huynh Duc',2024,'Hoa Sĩ','Còn',65998.00,'Vị trí sách : Kệ C2, tầng 1','C:\\Users\\DELL\\Visual .NET folder\\QUANLYTHUVIENC3\\QUANLYTHUVIENC3\\GUI\\img\\laptrinh.jpg'),('S009','Lập Trình Cơ Sở','Anh Minh',2004,'So Do','Còn',2000.00,'Vị trí sách: kệ D1, tầng 2','C:\\Users\\DELL\\Visual .NET folder\\QUANLYTHUVIENC3\\QUANLYTHUVIENC3\\GUI\\img\\ngonnguc.jpg'),('S010','www','gr',2007,'ds','Còn',2004.00,'Vị trí sách :Kệ B4 , tầng 2','C:\\Users\\DELL\\Visual .NET folder\\QUANLYTHUVIENC3\\QUANLYTHUVIENC3\\GUI\\img\\taichinh.jpg'),('S011','Pháp Lý và Tài Chính','Hà Nhương',2004,'Anh Sang','Còn',2000.00,'Vị trí kệ : Kệ A1 , tầng 1','C:\\Users\\DELL\\Visual .NET folder\\QUANLYTHUVIENC3\\QUANLYTHUVIENC3\\GUI\\img\\taichinh.jpg'),('S014','Những điều thú vị','Le Thuy Dung',1936,'Kim Đồng','Còn',200000.00,'Vị trí kệ sách : Kệ C2 , tầng 1','C:\\Users\\DELL\\OneDrive\\Tài liệu\\Hình ảnh\\icon\\trang-tri-bia-sach-45.jpg'),('S0300','hh','hhh',2015,'jjj','Còn',2000000.00,'jjjj','C:\\Users\\DELL\\Downloads\\car.png'),('S032','Hoho','hoho',2022,'joj','Hết',200.00,'hoho','C:\\Users\\DELL\\OneDrive\\Tài liệu\\Hình ảnh\\icon\\Not-Your-Boring-Book-Club-Hero.jpeg'),('S098','Hi Vong','AnhMinh',2004,'Nhom12','Còn',2100.00,'Hi Vong se duoc','C:\\Users\\DELL\\OneDrive\\Tài liệu\\Hình ảnh\\icon\\nhanvien.png'),('S153','Nhà giả kim','Nguyen Nhuong',2012,'To Huu','Còn',12000.00,'Vị trí kệ sách : D2 , tầng 1','C:\\Users\\DELL\\OneDrive\\Tài liệu\\Hình ảnh\\icon\\nhagiakim.jpg'),('S876','Một chút hi vọng','AnhMinh',2004,'Nhóm 12','Còn',11.00,'Vị Trí sách : B3 - tầng 2','C:\\Users\\DELL\\OneDrive\\Tài liệu\\Hình ảnh\\icon\\caidat.jpg'),('S879','Co len','Tran Linh',2006,'Nhom12','Còn',111.00,'Co Len','C:\\Users\\DELL\\OneDrive\\Tài liệu\\Hình ảnh\\icon\\caidat1.jpg');
/*!40000 ALTER TABLE `sach` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `sach_theloai`
--

DROP TABLE IF EXISTS `sach_theloai`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `sach_theloai` (
  `MaSach` varchar(10) NOT NULL,
  `MaTL` varchar(10) NOT NULL,
  PRIMARY KEY (`MaSach`,`MaTL`),
  KEY `MaTL` (`MaTL`),
  CONSTRAINT `sach_theloai_ibfk_1` FOREIGN KEY (`MaSach`) REFERENCES `sach` (`MaSach`),
  CONSTRAINT `sach_theloai_ibfk_2` FOREIGN KEY (`MaTL`) REFERENCES `theloaisach` (`MaTL`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `sach_theloai`
--

LOCK TABLES `sach_theloai` WRITE;
/*!40000 ALTER TABLE `sach_theloai` DISABLE KEYS */;
INSERT INTO `sach_theloai` VALUES ('S001','TL007'),('S014','TL007'),('S0300','TL007'),('S010','TL010'),('S153','TL021'),('S002','TL1124'),('S003','TL123'),('S098','TL321'),('S009','TL4'),('S876','TL4'),('S004','TL6'),('S011','TL6'),('S032','TL6'),('S879','TL6');
/*!40000 ALTER TABLE `sach_theloai` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `theloaisach`
--

DROP TABLE IF EXISTS `theloaisach`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `theloaisach` (
  `MaTL` varchar(10) NOT NULL,
  `TenTheLoai` varchar(50) CHARACTER SET utf8mb3 COLLATE utf8mb3_general_ci NOT NULL,
  PRIMARY KEY (`MaTL`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `theloaisach`
--

LOCK TABLES `theloaisach` WRITE;
/*!40000 ALTER TABLE `theloaisach` DISABLE KEYS */;
INSERT INTO `theloaisach` VALUES ('TL007','Toán Học'),('TL010','Sinh học'),('TL021','Công nghệ thông tin'),('TL1124','AO LANG 1'),('TL123','Văn học'),('TL132','Tiếng Anh '),('TL321','Kế toán'),('TL4','Tin  hoc'),('TL6','sinh hoc');
/*!40000 ALTER TABLE `theloaisach` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `users`
--

DROP TABLE IF EXISTS `users`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `users` (
  `ID` int NOT NULL AUTO_INCREMENT,
  `Username` varchar(50) NOT NULL,
  `Password` varchar(255) NOT NULL,
  `Role` enum('ADMIN','Nhân viên','Độc giả') NOT NULL DEFAULT 'Độc giả',
  `HoTen` varchar(100) CHARACTER SET utf8mb3 COLLATE utf8mb3_general_ci NOT NULL,
  `GioiTinh` enum('Nam','Nữ') NOT NULL,
  `NgaySinh` date DEFAULT NULL,
  `DiaChi` varchar(255) CHARACTER SET utf8mb3 COLLATE utf8mb3_general_ci DEFAULT NULL,
  `SDT` varchar(15) DEFAULT NULL,
  `Email` varchar(100) CHARACTER SET utf8mb3 COLLATE utf8mb3_general_ci DEFAULT NULL,
  PRIMARY KEY (`ID`),
  UNIQUE KEY `Username` (`Username`)
) ENGINE=InnoDB AUTO_INCREMENT=38 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `users`
--

LOCK TABLES `users` WRITE;
/*!40000 ALTER TABLE `users` DISABLE KEYS */;
INSERT INTO `users` VALUES (6,'admin','12345','ADMIN','Nguyen Van A','Nam','1985-06-10','123 Đường ABC, Hà Nội','0123456789','admin@example.com'),(7,'nhanvien01','12345','Nhân viên','Tran Thi B','Nữ','1990-02-25','456 Đường XYZ, Hà Nội2','0987654321','nhanvien001@example.com'),(8,'docgia022','12345','Độc giả','Le Van C','Nam','2000-10-15','789 Đường PQR, Hà Nội','0912345679','docgia01@example.com'),(10,'22111061323','12345','Nhân viên','minh123','Nam','2004-04-15','hà nội','099564675','h@gmail.com'),(12,'hihiiii1','hi','Nhân viên','hihihhhh','Nữ','2025-04-01','jkn','0389802934','fdf@gmail.com'),(13,'docgia03','12345','Nhân viên','Le Van D','Nữ','2000-10-15','789 Đường PQR, Hà Nội','0912345678','docgia03@example.com'),(14,'docgia04','123455','Nhân viên','Le Van D','Nữ','2000-10-15','789 Đường PQR, Hà Nội','0912345678','docgia03@example.com'),(15,'docgia05','12345','Độc giả','Haha','Nam','2000-10-25','789 Đường PQR, Hà Nội2','0345456473','docgia05@example.com'),(16,'ANH1','12345','Nhân viên','thuylinh11','Nam','2020-04-15','jgihgid','065447567','thuylinh@gmail.com'),(17,'Nhom12','12345','Nhân viên','Nhom12','Nam','2025-04-17','now','054364353','h@gmail.com'),(20,'thuylinh','123','Độc giả','thuy linh','Nữ','2025-05-20','phu dien','0984613341','nguyen004lih@gmail.com'),(21,'nguyen thi maii','12345','Nhân viên','nguyen thi maii','Nữ','2025-05-05','hhuhuhu','035435465','ggg@gmail.com'),(22,'thu thuy','12345','Nhân viên','thu thuy','Nữ','2025-05-01','gffbb','0547568562','gghh@gmail.com'),(23,'qae','12345','Nhân viên','qae','Nam','2025-04-08','ui','09876543','po@gmail.com'),(24,'221111061136','1','Nhân viên','1','Nữ','2025-05-28','r','98','h@gmail.com'),(30,'ghff','12345','Nhân viên','fdf','Nam','2025-05-21','','0876876537','sd@gmail.com'),(31,'jhn','12345','Nhân viên','gbf','Nam','2025-05-22','sd','0987654321','f@gmail.com'),(32,'linhlinhcute','12345','Độc giả','linhlih','Nữ','2025-05-28','hanoicity','0357315133','Tranthilinh@gmail.com'),(33,'nhuongnhuong','12345','Độc giả','nguyennhuong','Nữ','2025-05-01','hanoi','0355729980','nhuong04@gmail.com'),(34,'linh','12345','Độc giả','nguyen thi thuy linh','Nữ','2025-05-01','bAC NINH','0357315134','linh@gmail.com'),(35,'hanhuong','12345','Độc giả','hathanhnhuong','Nam','2025-04-30','phutho','0357315144','Nhuong@gmail.com'),(36,'anhminh','12345','Độc giả','huynhvietanhminh','Nam','2025-05-01','ha tinh','0357315155','minh@gmail.com'),(37,'thuylinh04','12345','Nhân viên','Nguyen Thi Thuy Linh','Nữ','2025-05-05','2 ngach 62 ngo 26','0984613341','nguyen004linh@gmail.com');
/*!40000 ALTER TABLE `users` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2025-11-03 18:15:43
