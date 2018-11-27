-- MySQL dump 10.13  Distrib 5.7.17, for Win64 (x86_64)
--
-- Host: localhost    Database: wuyemgrsys
-- ------------------------------------------------------
-- Server version	5.5.60-log

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
-- Table structure for table `业主信息`
--

DROP TABLE IF EXISTS `业主信息`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `业主信息` (
  `业主编号` varchar(30) NOT NULL,
  `业主姓名` varchar(50) DEFAULT NULL,
  `楼栋名称` varchar(50) DEFAULT NULL,
  `单元名称` varchar(50) DEFAULT NULL,
  `房号名称` varchar(50) DEFAULT NULL,
  `物业费用` float DEFAULT NULL,
  `预存金额` float DEFAULT NULL,
  `联系电话` varchar(50) DEFAULT NULL,
  `入住日期` date NOT NULL,
  `当前状态` varchar(50) DEFAULT NULL,
  `补充说明` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`业主编号`),
  KEY `FK_业主信息_楼栋信息_idx` (`楼栋名称`),
  CONSTRAINT `FK_业主信息_楼栋信息` FOREIGN KEY (`楼栋名称`) REFERENCES `楼栋信息` (`楼栋名称`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=gbk;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `业主信息`
--

LOCK TABLES `业主信息` WRITE;
/*!40000 ALTER TABLE `业主信息` DISABLE KEYS */;
INSERT INTO `业主信息` VALUES ('未来星1-1-101','陈氏区','未来星1号楼','1单元','101',20,0,'13689563569','2018-11-27','已入住','暂无'),('未来星2-1-101','魏都林','未来星2号楼','1','101',18,0,'13656238956','2018-11-27','已入住','暂无'),('紫藤苑1-1-101','张三丰','紫藤苑1号楼','1单元','101',10,0.5,'13698563698','2018-11-19','已入住','暂无'),('紫藤苑1-1-102','李四光','紫藤苑1号楼','1单元','102',16,0.59,'136985636985','2018-11-26','已入住',''),('紫藤苑1-1-103','林肯郡','紫藤苑1号楼','1单元','103',10,0.46,'13656896325','2018-11-12','已入住','无');
/*!40000 ALTER TABLE `业主信息` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `业主维修`
--

DROP TABLE IF EXISTS `业主维修`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `业主维修` (
  `维修编号` varchar(30) NOT NULL,
  `楼栋名称` varchar(30) DEFAULT NULL,
  `业主编号` varchar(30) DEFAULT NULL,
  `业主姓名` varchar(30) DEFAULT NULL,
  `报修日期` date NOT NULL,
  `接待人员` varchar(30) DEFAULT NULL,
  `故障现象` varchar(200) DEFAULT NULL,
  `处理意见` varchar(200) DEFAULT NULL,
  `修理日期` date NOT NULL,
  `修理人员` varchar(30) DEFAULT NULL,
  `修理费用` float DEFAULT NULL,
  `材料费用` float DEFAULT NULL,
  `费用合计` float DEFAULT NULL,
  `修理结果` varchar(200) DEFAULT NULL,
  `补充说明` varchar(200) DEFAULT NULL,
  PRIMARY KEY (`维修编号`),
  KEY `FK_业主维修_业主信息_idx` (`业主编号`),
  CONSTRAINT `FK_业主维修_业主信息` FOREIGN KEY (`业主编号`) REFERENCES `业主信息` (`业主编号`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=gbk;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `业主维修`
--

LOCK TABLES `业主维修` WRITE;
/*!40000 ALTER TABLE `业主维修` DISABLE KEYS */;
INSERT INTO `业主维修` VALUES ('YW181126153211','紫藤苑1号楼','紫藤苑1-1-101','张三丰','2018-11-19','地方官','往往情人','圈外人误扰','2018-11-19','往往',12,5,17,'伤感的歌','颂德歌功');
/*!40000 ALTER TABLE `业主维修` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `公共维修`
--

DROP TABLE IF EXISTS `公共维修`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `公共维修` (
  `维修编号` varchar(30) NOT NULL,
  `财产编号` varchar(30) DEFAULT NULL,
  `财产名称` varchar(30) DEFAULT NULL,
  `报修日期` date NOT NULL,
  `报修人员` varchar(30) DEFAULT NULL,
  `故障现象` varchar(200) DEFAULT NULL,
  `受理人员` varchar(30) DEFAULT NULL,
  `处理意见` varchar(200) DEFAULT NULL,
  `修理日期` date NOT NULL,
  `修理人员` varchar(30) DEFAULT NULL,
  `修理费用` float DEFAULT NULL,
  `材料费用` float DEFAULT NULL,
  `费用合计` float DEFAULT NULL,
  `修理结果` varchar(200) DEFAULT NULL,
  `补充说明` varchar(200) DEFAULT NULL,
  PRIMARY KEY (`维修编号`),
  KEY `FK_公共维修_公共财产_idx` (`财产编号`),
  CONSTRAINT `FK_公共维修_公共财产` FOREIGN KEY (`财产编号`) REFERENCES `公共财产` (`财产编号`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=gbk;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `公共维修`
--

LOCK TABLES `公共维修` WRITE;
/*!40000 ALTER TABLE `公共维修` DISABLE KEYS */;
/*!40000 ALTER TABLE `公共维修` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `公共财产`
--

DROP TABLE IF EXISTS `公共财产`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `公共财产` (
  `财产编号` varchar(30) NOT NULL,
  `财产名称` varchar(30) DEFAULT NULL,
  `规格型号` varchar(30) DEFAULT NULL,
  `所属类别` varchar(30) DEFAULT NULL,
  `财产原值` float DEFAULT NULL,
  `启用日期` date NOT NULL,
  `存放位置` varchar(100) DEFAULT NULL,
  `当前状态` varchar(30) DEFAULT NULL,
  `保管人员` varchar(30) DEFAULT NULL,
  `补充说明` varchar(100) DEFAULT NULL,
  PRIMARY KEY (`财产编号`)
) ENGINE=InnoDB DEFAULT CHARSET=gbk;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `公共财产`
--

LOCK TABLES `公共财产` WRITE;
/*!40000 ALTER TABLE `公共财产` DISABLE KEYS */;
/*!40000 ALTER TABLE `公共财产` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `小区信息`
--

DROP TABLE IF EXISTS `小区信息`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `小区信息` (
  `小区名称` varchar(50) NOT NULL,
  `总负责人` varchar(50) DEFAULT NULL,
  `小区地址` varchar(50) DEFAULT NULL,
  `邮政编码` varchar(10) DEFAULT NULL,
  `服务电话` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`小区名称`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `小区信息`
--

LOCK TABLES `小区信息` WRITE;
/*!40000 ALTER TABLE `小区信息` DISABLE KEYS */;
INSERT INTO `小区信息` VALUES ('开元社区','李四','红旗渠大道1号','311121','13656895623'),('未来之城','李四','未来大道1号','311121','13658964569');
/*!40000 ALTER TABLE `小区信息` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `操作用户`
--

DROP TABLE IF EXISTS `操作用户`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `操作用户` (
  `用户名称` varchar(30) NOT NULL,
  `用户密码` varchar(100) DEFAULT NULL,
  `用户姓名` varchar(50) DEFAULT NULL,
  `所在部门` varchar(50) DEFAULT NULL,
  `联系电话` varchar(30) DEFAULT NULL,
  `职责说明` varchar(45) DEFAULT NULL,
  `基本管理之业主登记管理` int(11) DEFAULT NULL,
  `基本管理之业主迁出管理` int(11) DEFAULT NULL,
  `基本管理之楼栋信息管理` int(11) DEFAULT NULL,
  `基本管理之公共财产管理` int(11) DEFAULT NULL,
  `物业管理之服务投诉管理` int(11) DEFAULT NULL,
  `物业管理之业主维修管理` int(11) DEFAULT NULL,
  `物业管理之公共维修管理` int(11) DEFAULT NULL,
  `物业管理之车位使用管理` int(11) DEFAULT NULL,
  `物业管理之突发事件管理` int(11) DEFAULT NULL,
  `费用管理之水电气费登记` int(11) DEFAULT NULL,
  `费用管理之水电气费查询` int(11) DEFAULT NULL,
  `费用管理之水电气费交纳` int(11) DEFAULT NULL,
  `费用管理之物管费用登记` int(11) DEFAULT NULL,
  `费用管理之物管费用查询` int(11) DEFAULT NULL,
  `费用管理之物管费用交纳` int(11) DEFAULT NULL,
  `费用管理之其他费用交纳` int(11) DEFAULT NULL,
  `报表管理之业主统计报表` int(11) DEFAULT NULL,
  `报表管理之投诉统计报表` int(11) DEFAULT NULL,
  `报表管理之业主维修报表` int(11) DEFAULT NULL,
  `报表管理之公共维修报表` int(11) DEFAULT NULL,
  `报表管理之收入统计报表` int(11) DEFAULT NULL,
  `系统管理之分配用户权限` int(11) DEFAULT NULL,
  `系统管理之小区信息设置` int(11) DEFAULT NULL,
  PRIMARY KEY (`用户名称`)
) ENGINE=InnoDB DEFAULT CHARSET=gbk;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `操作用户`
--

LOCK TABLES `操作用户` WRITE;
/*!40000 ALTER TABLE `操作用户` DISABLE KEYS */;
INSERT INTO `操作用户` VALUES ('管理员','AQAAAB+LCAAAAAAABAAzBAC379yDAQAAAA==','经理','物业服务中心','13688996989','经理',1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1);
/*!40000 ALTER TABLE `操作用户` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `服务投诉`
--

DROP TABLE IF EXISTS `服务投诉`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `服务投诉` (
  `投诉编号` varchar(30) NOT NULL,
  `楼栋名称` varchar(30) DEFAULT NULL,
  `业主编号` varchar(30) DEFAULT NULL,
  `业主姓名` varchar(30) DEFAULT NULL,
  `投诉日期` date NOT NULL,
  `接待人员` varchar(30) DEFAULT NULL,
  `投诉主题` varchar(30) DEFAULT NULL,
  `投诉内容` varchar(200) DEFAULT NULL,
  `处理日期` date NOT NULL,
  `处理人员` varchar(30) DEFAULT NULL,
  `处理意见` varchar(200) DEFAULT NULL,
  `处理结果` varchar(200) DEFAULT NULL,
  `业主反馈` varchar(200) DEFAULT NULL,
  `补充说明` varchar(200) DEFAULT NULL,
  PRIMARY KEY (`投诉编号`),
  KEY `FK_服务投诉_业主信息_idx` (`业主编号`),
  CONSTRAINT `FK_服务投诉_业主信息` FOREIGN KEY (`业主编号`) REFERENCES `业主信息` (`业主编号`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=gbk;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `服务投诉`
--

LOCK TABLES `服务投诉` WRITE;
/*!40000 ALTER TABLE `服务投诉` DISABLE KEYS */;
/*!40000 ALTER TABLE `服务投诉` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `楼栋信息`
--

DROP TABLE IF EXISTS `楼栋信息`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `楼栋信息` (
  `楼栋名称` varchar(30) NOT NULL,
  `小区名称` varchar(50) CHARACTER SET utf8 NOT NULL,
  `单元信息` varchar(50) DEFAULT NULL,
  `楼层信息` varchar(50) DEFAULT NULL,
  `总户数` int(11) DEFAULT NULL,
  `入住户数` int(11) DEFAULT NULL,
  `空置户数` int(11) DEFAULT NULL,
  `补充说明` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`楼栋名称`),
  KEY `FK_楼栋信息_小区信息` (`小区名称`),
  CONSTRAINT `FK_楼栋信息_小区信息` FOREIGN KEY (`小区名称`) REFERENCES `小区信息` (`小区名称`)
) ENGINE=InnoDB DEFAULT CHARSET=gbk;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `楼栋信息`
--

LOCK TABLES `楼栋信息` WRITE;
/*!40000 ALTER TABLE `楼栋信息` DISABLE KEYS */;
INSERT INTO `楼栋信息` VALUES ('未来星1号楼','未来之城','3','12',120,120,0,'暂无'),('未来星2号楼','未来之城','3','9',60,58,2,'暂无'),('紫藤苑1号楼','开元社区','4个单元','6层',68,68,0,'暂无');
/*!40000 ALTER TABLE `楼栋信息` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `水电气费`
--

DROP TABLE IF EXISTS `水电气费`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `水电气费` (
  `自动编号` int(11) NOT NULL AUTO_INCREMENT,
  `楼栋名称` varchar(30) DEFAULT NULL,
  `业主编号` varchar(30) DEFAULT NULL,
  `业主姓名` varchar(30) DEFAULT NULL,
  `计费年份` int(11) DEFAULT NULL,
  `计费月份` int(11) DEFAULT NULL,
  `费用类型` varchar(30) DEFAULT NULL,
  `表编号` varchar(30) DEFAULT NULL,
  `上月数` float DEFAULT NULL,
  `本月数` float DEFAULT NULL,
  `表用量` float DEFAULT NULL,
  `计费单价` float DEFAULT NULL,
  `应交金额` float DEFAULT NULL,
  `登记标志` varchar(10) DEFAULT NULL,
  `费用状态` varchar(10) DEFAULT NULL,
  `收据编号` varchar(50) DEFAULT NULL,
  `补充说明` varchar(100) DEFAULT NULL,
  PRIMARY KEY (`自动编号`),
  KEY `FK_水电气费_业主信息_idx` (`业主编号`),
  CONSTRAINT `FK_水电气费_业主信息` FOREIGN KEY (`业主编号`) REFERENCES `业主信息` (`业主编号`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=15 DEFAULT CHARSET=gbk;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `水电气费`
--

LOCK TABLES `水电气费` WRITE;
/*!40000 ALTER TABLE `水电气费` DISABLE KEYS */;
INSERT INTO `水电气费` VALUES (1,'紫藤苑1号楼','紫藤苑1-1-101','张三丰',2009,1,'物业费用','紫1-1-101-1',12,65,53,0.61,32.33,'完成登记','已交费','WYF20181127140508','含公共照明:1.855 电力损耗:0.371'),(2,'紫藤苑1号楼','紫藤苑1-1-101','张三丰',2009,1,'物业费用','紫1-1-101-2',2,40,38,0.61,23.18,'完成登记','已交费','WYF20181127140508','含公共照明:1.330 电力损耗:0.266'),(3,'紫藤苑1号楼','紫藤苑1-1-101','张三丰',2009,1,'物业费用','紫1-1-101-3',0,35,35,0.61,21.35,'完成登记','已交费','WYF20181127140508','含公共照明:1.225 电力损耗:0.245'),(4,'紫藤苑1号楼','紫藤苑1-1-102','李四光',2009,1,'物业费用','紫1-1-102-1',3,60,57,0.61,34.77,'完成登记','未交费',NULL,'含公共照明:1.995 电力损耗:0.399'),(5,'紫藤苑1号楼','紫藤苑1-1-103','林肯郡',2009,1,'物业费用','紫1-1-103-1',4,32,28,0.61,17.08,'完成登记','未交费',NULL,'含公共照明:0.980 电力损耗:0.196'),(8,'紫藤苑1号楼','紫藤苑1-1-101','张三丰',2009,2,'物业费用','紫1-1-101-1',65,70,5,0.61,3.05,'完成登记','已交费','WYF20181127140938','含公共照明:0.175 电力损耗:0.035'),(9,'紫藤苑1号楼','紫藤苑1-1-101','张三丰',2009,2,'物业费用','紫1-1-101-2',40,80,40,0.61,24.4,'完成登记','已交费','WYF20181127140938','含公共照明:1.400 电力损耗:0.280'),(10,'紫藤苑1号楼','紫藤苑1-1-101','张三丰',2009,2,'物业费用','紫1-1-101-3',35,90,55,0.61,33.55,'完成登记','已交费','WYF20181127140938','含公共照明:1.925 电力损耗:0.385'),(11,'紫藤苑1号楼','紫藤苑1-1-102','李四光',2009,2,'物业费用','紫1-1-102-1',60,75,15,0.61,9.15,'完成登记','未交费',NULL,'含公共照明:0.525 电力损耗:0.105'),(12,'紫藤苑1号楼','紫藤苑1-1-103','林肯郡',2009,2,'物业费用','紫1-1-103-1',32,45,13,0.61,7.93,'完成登记','未交费',NULL,'含公共照明:0.455 电力损耗:0.091');
/*!40000 ALTER TABLE `水电气费` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `物管费用`
--

DROP TABLE IF EXISTS `物管费用`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `物管费用` (
  `自动编号` int(11) NOT NULL AUTO_INCREMENT,
  `楼栋名称` varchar(30) DEFAULT NULL,
  `业主编号` varchar(30) DEFAULT NULL,
  `业主姓名` varchar(30) DEFAULT NULL,
  `计费年份` int(11) DEFAULT NULL,
  `计费月份` int(11) DEFAULT NULL,
  `建筑面积` float DEFAULT NULL,
  `套内面积` float DEFAULT NULL,
  `计费单价` float DEFAULT NULL,
  `应交金额` float DEFAULT NULL,
  `登记标志` varchar(10) DEFAULT NULL,
  `费用状态` varchar(10) DEFAULT NULL,
  `收据编号` varchar(50) DEFAULT NULL,
  `补充说明` varchar(100) DEFAULT NULL,
  PRIMARY KEY (`自动编号`)
) ENGINE=InnoDB DEFAULT CHARSET=gbk;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `物管费用`
--

LOCK TABLES `物管费用` WRITE;
/*!40000 ALTER TABLE `物管费用` DISABLE KEYS */;
/*!40000 ALTER TABLE `物管费用` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `电表信息`
--

DROP TABLE IF EXISTS `电表信息`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `电表信息` (
  `电表编号` varchar(50) NOT NULL,
  `业主编号` varchar(30) NOT NULL,
  PRIMARY KEY (`电表编号`),
  KEY `FK_电表信息_业主信息_idx` (`业主编号`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `电表信息`
--

LOCK TABLES `电表信息` WRITE;
/*!40000 ALTER TABLE `电表信息` DISABLE KEYS */;
INSERT INTO `电表信息` VALUES ('未来1-1-101-1','未来星1-1-101'),('未来星2-101-1','未来星2-1-101'),('紫1-1-101-1','紫藤苑1-1-101'),('紫1-1-101-2','紫藤苑1-1-101'),('紫1-1-101-3','紫藤苑1-1-101'),('紫1-1-102-1','紫藤苑1-1-102'),('紫1-1-103-1','紫藤苑1-1-103');
/*!40000 ALTER TABLE `电表信息` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `突发事件`
--

DROP TABLE IF EXISTS `突发事件`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `突发事件` (
  `事件编号` varchar(30) NOT NULL,
  `发生日期` date NOT NULL,
  `处理人员` varchar(30) DEFAULT NULL,
  `事件主题` varchar(50) DEFAULT NULL,
  `事件内容` varchar(200) DEFAULT NULL,
  `处理结果` varchar(200) DEFAULT NULL,
  `补充说明` varchar(200) DEFAULT NULL,
  PRIMARY KEY (`事件编号`)
) ENGINE=InnoDB DEFAULT CHARSET=gbk;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `突发事件`
--

LOCK TABLES `突发事件` WRITE;
/*!40000 ALTER TABLE `突发事件` DISABLE KEYS */;
/*!40000 ALTER TABLE `突发事件` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `费用价格`
--

DROP TABLE IF EXISTS `费用价格`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `费用价格` (
  `费用类型` varchar(45) NOT NULL,
  `费用价格` double DEFAULT NULL,
  PRIMARY KEY (`费用类型`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `费用价格`
--

LOCK TABLES `费用价格` WRITE;
/*!40000 ALTER TABLE `费用价格` DISABLE KEYS */;
INSERT INTO `费用价格` VALUES ('公共照明价格',0.035),('标准电费价格',0.568),('电力损耗价格',0.007);
/*!40000 ALTER TABLE `费用价格` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `费用收据`
--

DROP TABLE IF EXISTS `费用收据`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `费用收据` (
  `收据编号` varchar(50) NOT NULL,
  `收款日期` date NOT NULL,
  `交款人员` varchar(30) DEFAULT NULL,
  `应收金额` float DEFAULT NULL,
  `实收金额` float DEFAULT NULL,
  `收款形式` varchar(30) DEFAULT NULL,
  `收款人员` varchar(30) DEFAULT NULL,
  `收款事由` varchar(50) DEFAULT NULL,
  `补充说明` varchar(150) DEFAULT NULL,
  PRIMARY KEY (`收据编号`)
) ENGINE=InnoDB DEFAULT CHARSET=gbk;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `费用收据`
--

LOCK TABLES `费用收据` WRITE;
/*!40000 ALTER TABLE `费用收据` DISABLE KEYS */;
INSERT INTO `费用收据` VALUES ('QTF20181127161428','2018-11-27','ghj',20,20,'现金','经理','交维修费','暂无'),('WYF20181127140508','2018-11-27','张三丰',86.5,87,'现金','经理','交物业费','上期预存已经抵扣0.36元'),('WYF20181127140938','2018-11-27','张三丰',70.5,71,'现金','经理','交物业费','上期预存已经抵扣0.5元');
/*!40000 ALTER TABLE `费用收据` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `车位使用`
--

DROP TABLE IF EXISTS `车位使用`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `车位使用` (
  `自动编号` int(11) NOT NULL AUTO_INCREMENT,
  `车位编号` varchar(30) DEFAULT NULL,
  `车位面积` float DEFAULT NULL,
  `楼栋名称` varchar(30) DEFAULT NULL,
  `业主编号` varchar(30) DEFAULT NULL,
  `业主姓名` varchar(200) DEFAULT NULL,
  `启用日期` date NOT NULL,
  `停用日期` date NOT NULL,
  `费用金额` float DEFAULT NULL,
  `管理人员` varchar(30) DEFAULT NULL,
  `补充说明` varchar(200) DEFAULT NULL,
  PRIMARY KEY (`自动编号`),
  KEY `FK_车位使用_业主信息_idx` (`业主编号`),
  CONSTRAINT `FK_车位使用_业主信息` FOREIGN KEY (`业主编号`) REFERENCES `业主信息` (`业主编号`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=gbk;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `车位使用`
--

LOCK TABLES `车位使用` WRITE;
/*!40000 ALTER TABLE `车位使用` DISABLE KEYS */;
/*!40000 ALTER TABLE `车位使用` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `迁出信息`
--

DROP TABLE IF EXISTS `迁出信息`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `迁出信息` (
  `业主编号` varchar(30) NOT NULL,
  `业主姓名` varchar(50) DEFAULT NULL,
  `迁出日期` date NOT NULL,
  `迁出原因` varchar(50) DEFAULT NULL,
  `补充说明` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`业主编号`),
  CONSTRAINT `FK_迁出信息_业主信息` FOREIGN KEY (`业主编号`) REFERENCES `业主信息` (`业主编号`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=gbk;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `迁出信息`
--

LOCK TABLES `迁出信息` WRITE;
/*!40000 ALTER TABLE `迁出信息` DISABLE KEYS */;
/*!40000 ALTER TABLE `迁出信息` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2018-11-27 16:59:51
