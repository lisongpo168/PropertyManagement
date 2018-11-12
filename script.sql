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
  `电子信箱` varchar(50) DEFAULT NULL,
  `小区网站` varchar(50) DEFAULT NULL,
  `首页图像` varchar(50) DEFAULT NULL,
  `背景图像` varchar(50) DEFAULT NULL,
  `标志图标` varchar(50) DEFAULT NULL,
  `系统名称` varchar(50) DEFAULT NULL,
  `优先级` int(11) DEFAULT NULL,
  PRIMARY KEY (`小区名称`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `小区信息`
--

LOCK TABLES `小区信息` WRITE;
/*!40000 ALTER TABLE `小区信息` DISABLE KEYS */;
INSERT INTO `小区信息` VALUES ('未来一号','张三','未来大道88号','111111','0571-88888888','futurewuye@163.com','www.baidu.com','bk.jpg','bk.jpg','app.ico','智慧管家物业管理系统',1);
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
  `用户密码` varchar(50) DEFAULT NULL,
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
INSERT INTO `操作用户` VALUES ('管理员','1','经理','物业服务中心','13688996989','经理',1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1),('王小花','1','王小花','财务部','13525698956','会计',0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0);
/*!40000 ALTER TABLE `操作用户` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `楼栋信息`
--

DROP TABLE IF EXISTS `楼栋信息`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `楼栋信息` (
  `楼栋名称` varchar(30) NOT NULL,
  `所处位置` varchar(50) DEFAULT NULL,
  `单元信息` varchar(50) DEFAULT NULL,
  `楼层信息` varchar(50) DEFAULT NULL,
  `总人口数` int(11) DEFAULT NULL,
  `总户数` int(11) DEFAULT NULL,
  `入住户数` int(11) DEFAULT NULL,
  `空置户数` int(11) DEFAULT NULL,
  `住宅户数` int(11) DEFAULT NULL,
  `商用户数` int(11) DEFAULT NULL,
  `管理楼长` varchar(50) DEFAULT NULL,
  `联系电话` varchar(50) DEFAULT NULL,
  `补充说明` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`楼栋名称`)
) ENGINE=InnoDB DEFAULT CHARSET=gbk;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `楼栋信息`
--

LOCK TABLES `楼栋信息` WRITE;
/*!40000 ALTER TABLE `楼栋信息` DISABLE KEYS */;
INSERT INTO `楼栋信息` VALUES ('123123','232','123123','12312',2122,22,22,200,22,22,'2324','234','暂无'),('未来星一幢','西南','4个单元','18层',100,100,60,40,100,0,'层高','13656894568','哈哈');
/*!40000 ALTER TABLE `楼栋信息` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2018-11-12 18:06:45
