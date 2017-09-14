-- Host: localhost    Database: project
-- ------------------------------------------------------
-- Server version	5.7.15-log

-- Current Database: `project`
--

CREATE DATABASE `project`;

USE `project`;
--
-- Table structure for table `admin_table

DROP TABLE IF EXISTS `admin_table`;
CREATE TABLE `admin_table` (
  `Staff_id` varchar(10) NOT NULL,
  `Programme` varchar(45) DEFAULT NULL,
  `Priviledges` varchar(45) NOT NULL,
  `Password` varchar(45) NOT NULL,
  PRIMARY KEY (`Staff_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

LOCK TABLES `admin_table` WRITE;
INSERT INTO `admin_table` VALUES ('AC/0122A','swed','Lecturer','CSE'),('AC/0123F','sda','Lecturer','SOFTWARE ENGINEERING'),('AC/0123I','tomide','PG Coordinator','COMPUTER SCIENCE'),('AC/0123R','ghbiii','Programme Administrator','INTELLIGENT SYSTEM ENGINEERING'),('AC/0124G ','root','HOD','INTELLIGENT SYSTEM ENGINEERING'),('AC/0124L','akan','Lecturer','COMPUTER ENGINEERING'),('AC/0124N','dfn','Lecturer','INTELLIGENT SYSTEM ENGINEERING'),('AC/0124S','COMPUTER SCIENCE','Programmme Coordinator','anni'),('AC/0935C','IS','Others','bukola');
UNLOCK TABLES;

--
-- Table structure for table `biodata`
--

DROP TABLE IF EXISTS `biodata`;
CREATE TABLE `biodata` (
  `Registration_No` varchar(15) NOT NULL,
  `Last_Name` varchar(45) NOT NULL,
  `Other_Names` varchar(45) NOT NULL,
  `Age` int(11) NOT NULL,
  `Sex` varchar(7) NOT NULL,
  `Address` varchar(80) NOT NULL,
  `State_of_origin` varchar(45) NOT NULL,
  `LGA` varchar(80) NOT NULL,
  `Phone_No` int(11) NOT NULL,
  `Programme` varchar(45) NOT NULL,
  `Next_kin` varchar(45) NOT NULL,
  `Phone_no_of_next_of_kin` int(11) NOT NULL,
  PRIMARY KEY (`Registration_No`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

LOCK TABLES `biodata` WRITE;

UNLOCK TABLES;

--
-- Table structure for table `compulsory_courses`
--

DROP TABLE IF EXISTS `compulsory_courses`;
CREATE TABLE `compulsory_courses` (
  `Course_code` varchar(7) NOT NULL,
  `Course_title` varchar(80) NOT NULL,
  `Course_unit` int(11) NOT NULL,
  `Semester` varchar(15) NOT NULL,
  PRIMARY KEY (`Course_code`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

LOCK TABLES `compulsory_courses` WRITE;
INSERT INTO `compulsory_courses` VALUES ('CIS601','Information Theory & coding',2,'Rain'),('CPE601','Advanced Modelling & Simulation',2,'Rain'),('CSC601','Special Topics in Computing Systems',2,'Harmattan'),('CSE601','Research Methodology in Computer Science & Engineering',3,'Harmattan');
UNLOCK TABLES;

--
-- Table structure for table `computer_engineering_courses`
--

DROP TABLE IF EXISTS `computer_engineering_courses`;
CREATE TABLE `computer_engineering_courses` (
  `Course_code` varchar(7) NOT NULL,
  `Course_title` varchar(85) NOT NULL,
  `Course_unit` int(11) NOT NULL,
  `Semester` varchar(45) NOT NULL,
  PRIMARY KEY (`Course_code`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

LOCK TABLES `computer_engineering_courses` WRITE;
INSERT INTO `computer_engineering_courses` VALUES ('CPE21','Deployment and Applications of Wireless sensor networks',3,'Harmattan/Rain'),('CPE602','Advanced Engineering Systems analysis & design',3,'Harmattan/Rain'),('CPE611','Advanced digital systems design',3,'Harmattan/Rain'),('CPE612','Principles of Embedded computing system',3,'Harmattan/Rain'),('CPE613','Digital Signal processing systems',3,'Harmattan/Rain'),('CPE614','Advanced Computer Architecture',3,'Harmattan/Rain'),('CPE615','Distributed Systems architecture',3,'Harmattan/Rain'),('CPE616','Advanced Digital communication',3,'Harmattan/Rain'),('CPE617','Wireless and mobile systems technologies',3,'Harmattan/Rain'),('CPE618','Computer Syetms and network Security',3,'Harmattan/Rain'),('CPE619','Satellite and Optical communication',3,'Harmattan/Rain'),('CPE620','Wireless Sensor networks',3,'Harmattan/Rain'),('CPE622','cop',3,'Harmattan/Rain');
UNLOCK TABLES;

--
-- Table structure for table `computer_science`
--

DROP TABLE IF EXISTS `computer_science`;
CREATE TABLE `computer_science` (
  `Course_code` varchar(7) NOT NULL,
  `Course_title` varchar(80) NOT NULL,
  `Course_unit` int(11) NOT NULL,
  `Semester` varchar(45) NOT NULL,
  PRIMARY KEY (`Course_code`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

LOCK TABLES `computer_science` WRITE;
INSERT INTO `computer_science` VALUES ('CSC610','Advanced Computer Graphics',3,'Harmattan/Rain'),('CSC611','Advanced Multimedia System',3,'Harmattan/Rain'),('CSC613','Advanced Multi-agent System',3,'Harmattan/Rain'),('CSC615','Advanced Automata Theory',3,'Harmattan/Rain'),('CSC616','Theory of computation and complexity',3,'Harmattan/Rain'),('CSC617','Theory of programming language',3,'Harmattan/Rain'),('CSC618','Discrete Mathematics & Computations',3,'Harmattan/Rain'),('CSC619','Principle of  Operating System Design',3,'Harmattan/Rain'),('CSC620','Advanced compiler design',3,'Harmattan/Rain'),('CSC621','Advanced Data Warehousing',3,'Harmattan/Rain'),('CSC622','Decision Support System',3,'Harmattan/Rain');
UNLOCK TABLES;

--
-- Table structure for table `course_definition`
--

DROP TABLE IF EXISTS `course_definition`;
CREATE TABLE `course_definition` (
  `Course_code` varchar(8) NOT NULL,
  `Course_Lecturers` varchar(55) NOT NULL,
  `Session` varchar(15) NOT NULL,
  `Coordinate` varchar(45) NOT NULL,
  PRIMARY KEY (`Course_code`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

LOCK TABLES `course_definition` WRITE;
INSERT INTO `course_definition` VALUES ('CIS 612','HAS, TOO','2015/2016','HAS');
UNLOCK TABLES;

--
-- Table structure for table `information_system`
--

DROP TABLE IF EXISTS `information_system`;
CREATE TABLE `information_system` (
  `Course_code` varchar(7) NOT NULL,
  `Course_title` varchar(85) NOT NULL,
  `Course_unit` int(11) NOT NULL,
  `Semester` varchar(45) NOT NULL,
  PRIMARY KEY (`Course_code`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

LOCK TABLES `information_system` WRITE;
INSERT INTO `information_system` VALUES ('CIS610','Information System in Organization',3,'Harmattan/Rain'),('CIS611','Information System Modelling',3,'Harmattan/Rain'),('CIS612','Advanced Operation Research',3,'Harmattan/Rain'),('CIS613','Advanced Information Storage & Retrival',3,'Harmattan/Rain'),('CIS614','Software Project management',3,'Harmattan/Rain'),('CIS615','Informatics',3,'Harmattan/Rain'),('CIS616','Fudamental of Electronic Commerce',3,'Harmattan/Rain'),('CIS617','Software Theory of Geo-informatics systems',3,'Harmattan/Rain'),('CIS618','Human computer interaction',3,'Harmattan/Rain'),('CIS619','Content Management Systems',3,'Harmattan/Rain'),('CIS620','Management Support Systems',3,'Harmattan/Rain'),('CIS621','Disturbed Database Systems',3,'Harmattan/Rain'),('CIS622','Information Requirement and databases',3,'Harmattan/Rain');
UNLOCK TABLES;

--
-- Table structure for table `intelligent_systems_engineering`
--

DROP TABLE IF EXISTS `intelligent_systems_engineering`;
CREATE TABLE `intelligent_systems_engineering` (
  `Course_code` varchar(8) NOT NULL,
  `Course_title` varchar(85) NOT NULL,
  `Course_unit` int(11) NOT NULL,
  `Semester` varchar(45) NOT NULL,
  PRIMARY KEY (`Course_code`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `intelligent_systems_engineering`
--

LOCK TABLES `intelligent_systems_engineering` WRITE;
/*!40000 ALTER TABLE `intelligent_systems_engineering` DISABLE KEYS */;
INSERT INTO `intelligent_systems_engineering` VALUES ('CIE610','Information Theories of Intelligent Systems',3,'Harmattan/Rain'),('CIE611','Introduction to Robotics and Motion Planning',3,'Harmattan/Rain'),('CIE612','Human Language Processing & Applications ',3,'Harmattan/Rain'),('CIE613','Applied Bio-Informatics',3,'Harmattan/Rain'),('CIE614','Formal Logic in Intelligence Systems',3,'Harmattan/Rain'),('CIE615','Soft-computing and Applications',3,'Harmattan/Rain'),('CIE616','Theories and Concepts of Computing in African Culture',3,'Harmattan/Rain'),('CIE617','Computational Linguistics',3,'Harmattan/Rain'),('CIE618','Knowledge Engineering ',3,'Harmattan/Rain'),('CIE619','Games Theories and Applications',3,'Harmattan/Rain'),('CIE620','Speech and Language Technologies',3,'Harmattan/Rain');
/*!40000 ALTER TABLE `intelligent_systems_engineering` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `list_of_lecturers`
--

DROP TABLE IF EXISTS `list_of_lecturers`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `list_of_lecturers` (
  `Staff_Id` varchar(45) NOT NULL,
  `Surname` varchar(45) DEFAULT NULL,
  `FirstName` varchar(45) DEFAULT NULL,
  `OtherName` varchar(45) DEFAULT NULL,
  `Short_Form` varchar(45) DEFAULT NULL,
  `Position` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`Staff_Id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `list_of_lecturers`
--

LOCK TABLES `list_of_lecturers` WRITE;
INSERT INTO `list_of_lecturers` VALUES ('AC/0122A','AFOLABI','Babajide','Samuel','BSA','Programme admin'),('AC/0122O','OLAJUBU','Emmanuel','Ajayi','EAO','Lecturer'),('AC/0123A','AJAYI','Anuoluwapo','Olarenwanju','AOA','Lecturer'),('AC/0123B','BELLO','Sururah','Apinke','SAB','Lecturer'),('AC/0123E','ELUDIORA','Safiriyu','Ijiyemi','SIE','Programme admin'),('AC/0123F','ASAHIAH','Franklin','Oladiipo','FOA','Programme admin'),('AC/0123I','AWOYELU','Iyabo','Olukemi','AIO','Programme admin'),('AC/0123O','OLAJUBU','Emmanuel','Ajayi','EAO','Lecturer'),('AC/0123P ','IDOWU','Peter ','Adebayo','PAI','Programme admin'),('AC/0123R','IKONO','Rhoda','Nsikan-Abasi','RHI','Programme adimin'),('AC/0124A','AKINYEMI','Bodunde','Odunola','BOA','Lecturer'),('AC/0124B','AKHIGBE','Bernard','Ijesunor','BIA','Programme admin'),('AC/0124G ','GAMBO','Ishaya','Peni','IPG','Programme admin'),('AC/0124I','IYANDA','Abimbola','Rhoda','ARI','Lecturer'),('AC/0124L','AKANBI','Lukman','Adewale','LAA','Programmme admin'),('AC/0124N','NINAN','Olufemi','Deborah','ODN','Lecturer'),('AC/0124O','OLUFOKUNBI','Karen','Cowan','KCO','Programme admin'),('AC/0124S','SANNI','Mistura','Laide','MLS','Lecturer'),('AC/0125A','AINA','Segun',NULL,'SA','Lecturer'),('AC/0125O','ODUKOYA','Helen','Oluwatoyin','HOO','Lecturer'),('AC/0253A','OLUWARANTI','Adeniran','Ishola','AIO','Lecturer'),('AC/0443A','OLUWATOPE','Ayodeji','Oludola ','AOO','Coordinator'),('AC/0935C','OMODUNBI','Theresa','Olubukola','TOO','Programme admin');
UNLOCK TABLES;

--
-- Table structure for table `programme_table`
--

DROP TABLE IF EXISTS `programme_table`;
CREATE TABLE `programme_table` (
  `Programe_code` varchar(10) NOT NULL,
  `Programme_Name` varchar(45) NOT NULL,
  PRIMARY KEY (`Programe_code`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

LOCK TABLES `programme_table` WRITE;
/*!40000 ALTER TABLE `programme_table` DISABLE KEYS */;
INSERT INTO `programme_table` VALUES ('M.CIE','INTELLIGENT SYSTEM ENGINEERING'),('M.CIS','INFORMATION SYSTEM'),('M.CPE','COMPUTER ENGINEERING'),('M.CSC','COMPUTER SCIENCE'),('M.CSE','SOFTWARE ENGINEERING');
/*!40000 ALTER TABLE `programme_table` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `software_engineering`
--

DROP TABLE IF EXISTS `software_engineering`;
CREATE TABLE `software_engineering` (
  `Course_code` varchar(7) NOT NULL,
  `Course_title` varchar(80) NOT NULL,
  `Course_unit` int(11) NOT NULL,
  `Semester` varchar(45) NOT NULL,
  PRIMARY KEY (`Course_code`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--

LOCK TABLES `software_engineering` WRITE;
INSERT INTO `software_engineering` VALUES ('CSE602','Advanced Software systems analysis and design',3,'Harmattan/Rain'),('CSE610','Software maintainance and reuse',3,'Harmattan/Rain'),('CSE611','Advanced Software Testing',3,'Harmattan/Rain'),('CSE612','Special topicsin web-based Software',3,'Harmattan/Rain'),('CSE613','Advanced Database management concepts',3,'Harmattan/Rain'),('CSE614','Data Mining Technique',3,'Harmattan/Rain'),('CSE615','Software for scientific Data and image visualization',3,'Harmattan/Rain'),('CSE616','Advanced topic in computer security',3,'Harmattan/Rain'),('CSE617','Objectt Oriented software design & implementation',3,'Harmattan/Rain'),('CSE618','Formal method and models in software engineering',3,'Harmattan/Rain'),('CSE619','Software Engineering enviroment',3,'Harmattan/Rain'),('CSE620','Software for Advanced engineering systems',3,'Harmattan/Rain'),('CSE621','Open-source Software Architecture',3,'Harmattan/Rain');
UNLOCK TABLES;

--
-- Table structure for table `student_registration`
--

DROP TABLE IF EXISTS `student_registration`;
CREATE TABLE `student_registration` (
  `Registration_No` varchar(10) NOT NULL,
  `Session` varchar(45) NOT NULL,
  `Semester` int(11) NOT NULL,
  `Courses` varchar(80) NOT NULL,
  PRIMARY KEY (`Semester`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

LOCK TABLES `student_registration` WRITE;
UNLOCK TABLES;

