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
  `身份证号码` varchar(50) DEFAULT NULL,
  `楼栋名称` varchar(50) DEFAULT NULL,
  `单元名称` varchar(50) DEFAULT NULL,
  `房号名称` varchar(50) DEFAULT NULL,
  `房屋性质` varchar(50) DEFAULT NULL,
  `房屋类型` varchar(50) DEFAULT NULL,
  `建筑面积` float DEFAULT NULL,
  `套内面积` float DEFAULT NULL,
  `常住人员` varchar(50) DEFAULT NULL,
  `联系电话` varchar(50) DEFAULT NULL,
  `入住日期` date DEFAULT NULL,
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
INSERT INTO `业主信息` VALUES ('1-502','赵六','7894561236*985','致敬园1号楼','4单元','502','住宅','地方官',96,52,'规划局','1234569385','2018-02-06','已入住','暂无'),('2-203','杰奎琳','1234569887455','未来星一幢','二单元','203','住宅','高层',100,96,'符桂花','13696856938','2015-06-16','已入住','暂无'),('3-102','李三哥','33012589098625894658','未来星一幢','一单元','403','住宅','住宅',100,89,'李三哥','13669894563','2016-03-26','已入住','暂无'),('6-606','牛红刚','234532535345345345','致敬园1号楼','1单元','606','住宅','高层',253,100,'宇航局','23452345423423','2018-11-05','已入住','暂无');
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
  `报修日期` date DEFAULT NULL,
  `接待人员` varchar(30) DEFAULT NULL,
  `故障现象` varchar(200) DEFAULT NULL,
  `处理意见` varchar(200) DEFAULT NULL,
  `修理日期` date DEFAULT NULL,
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
INSERT INTO `业主维修` VALUES ('WX201801256','未来星一幢','2-203','杰奎琳','2018-11-06','衢州行','门禁视频不亮','上门维修','2018-11-13','士大夫',50,0,50,'修好','暂无'),('YW181114170753','致敬园1号楼','1-502','赵六','2018-11-14','地方官','对手是法国','凤生凤士大夫','2018-11-14','地方官',5,9,14,'顶顶','方法');
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
  `报修日期` date DEFAULT NULL,
  `报修人员` varchar(30) DEFAULT NULL,
  `故障现象` varchar(200) DEFAULT NULL,
  `受理人员` varchar(30) DEFAULT NULL,
  `处理意见` varchar(200) DEFAULT NULL,
  `修理日期` date DEFAULT NULL,
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
INSERT INTO `公共维修` VALUES ('GW181114170855','1002','安全锤','2018-11-14','大热天','地方随风','方法','首发式地方','2018-11-14','方法',9,10,19,'符桂花','烦烦烦'),('GWX20180632','1002','安全锤','2018-11-14','热风格','安全锤把手坏','安全锤把手坏','更换','2018-11-14','地方官',0,200,200,'修好','无');
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
  `启用日期` date DEFAULT NULL,
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
INSERT INTO `公共财产` VALUES ('1001','围栏','DFG-89','公共设施',500,'2018-11-12','南门','在使用','伍德','暂无'),('1002','安全锤','DFG-86','公共设施',100,'2018-11-12','消防通道','在使用','伍德','暂无');
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
  `投诉日期` date DEFAULT NULL,
  `接待人员` varchar(30) DEFAULT NULL,
  `投诉主题` varchar(30) DEFAULT NULL,
  `投诉内容` varchar(200) DEFAULT NULL,
  `处理日期` date DEFAULT NULL,
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
INSERT INTO `服务投诉` VALUES ('TS181114170400','致敬园1号楼','1-502','赵六','2018-11-14','地方官','首发式地方','石帆胜丰首发式','2018-11-14','随风倒','首发式地方','首发式地方','首发式地方','首发式地方'),('TS201800263','致敬园1号楼','1-502','赵六','2018-11-14','地方官','史蒂芬森地方','污染物饿饿特容易热议','2018-11-14','户籍科','党规党法韩复榘国开行快女才能','大股东感到风格','一般般','施工方大锅饭'),('YZTS181114170129','未来星一幢','2-203','杰奎琳','2018-11-14','地方官','地方时地方','阿什福撒旦公共','2018-11-14','顶顶顶','萨芬萨佛斯','阿方索地方','阿方地方','阿方地方');
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
INSERT INTO `楼栋信息` VALUES ('未来星一幢','西南','4个单元','18层',100,100,60,40,100,0,'层高','13656894568','哈哈'),('致敬园1号楼','232','123123','6层',2122,22,22,0,22,22,'自动','234','暂无');
/*!40000 ALTER TABLE `楼栋信息` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `突发事件`
--

DROP TABLE IF EXISTS `突发事件`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `突发事件` (
  `事件编号` varchar(30) NOT NULL,
  `发生日期` date DEFAULT NULL,
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
INSERT INTO `突发事件` VALUES ('TF181114171317','2018-11-14','说到底','阿斯顿速度','阿斯顿','阿斯打扫','阿斯顿速度'),('TF181114171342','2018-11-14','地方官','颂德歌功公共','滴滴答答得到','顶顶顶顶顶','古古怪怪');
/*!40000 ALTER TABLE `突发事件` ENABLE KEYS */;
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
  `启用日期` date DEFAULT NULL,
  `停用日期` date DEFAULT NULL,
  `费用金额` float DEFAULT NULL,
  `管理人员` varchar(30) DEFAULT NULL,
  `补充说明` varchar(200) DEFAULT NULL,
  PRIMARY KEY (`自动编号`),
  KEY `FK_车位使用_业主信息_idx` (`业主编号`),
  CONSTRAINT `FK_车位使用_业主信息` FOREIGN KEY (`业主编号`) REFERENCES `业主信息` (`业主编号`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=gbk;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `车位使用`
--

LOCK TABLES `车位使用` WRITE;
/*!40000 ALTER TABLE `车位使用` DISABLE KEYS */;
INSERT INTO `车位使用` VALUES (1,'A01',4,'未来星一幢','2-203','杰奎琳','2017-06-13','2018-12-31',300,'地方官','暂无');
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
  `迁出日期` date DEFAULT NULL,
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

-- Dump completed on 2018-11-14 17:14:47
