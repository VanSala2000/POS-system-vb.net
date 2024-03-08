/*
SQLyog Community v13.2.1 (64 bit)
MySQL - 8.0.35 : Database - db_inventory
*********************************************************************
*/

/*!40101 SET NAMES utf8 */;

/*!40101 SET SQL_MODE=''*/;

/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;
CREATE DATABASE /*!32312 IF NOT EXISTS*/`db_inventory` /*!40100 DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci */ /*!80016 DEFAULT ENCRYPTION='N' */;

USE `db_inventory`;

/*Table structure for table `admin_credentials` */

DROP TABLE IF EXISTS `admin_credentials`;

CREATE TABLE `admin_credentials` (
  `username` varchar(150) DEFAULT NULL,
  `password` varchar(150) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

/*Data for the table `admin_credentials` */

insert  into `admin_credentials`(`username`,`password`) values 
('admin','admin12345'),
('van','van12345');

/*Table structure for table `tblbrand` */

DROP TABLE IF EXISTS `tblbrand`;

CREATE TABLE `tblbrand` (
  `id` int NOT NULL AUTO_INCREMENT,
  `brand` varchar(250) DEFAULT NULL,
  `created_at` datetime DEFAULT NULL,
  KEY `id` (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=33 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

/*Data for the table `tblbrand` */

insert  into `tblbrand`(`id`,`brand`,`created_at`) values 
(28,'Nike','2023-12-20 15:09:58'),
(29,'Adidas','2023-12-20 15:10:05'),
(30,'Under Armour','2023-12-20 15:10:16'),
(31,'Botchoy','2023-12-20 15:11:37'),
(32,'Converse','2023-12-20 17:41:50');

/*Table structure for table `tblcolorways` */

DROP TABLE IF EXISTS `tblcolorways`;

CREATE TABLE `tblcolorways` (
  `id` int NOT NULL AUTO_INCREMENT,
  `colorways` varchar(250) DEFAULT NULL,
  `created_at` datetime DEFAULT NULL,
  KEY `id` (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=31 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

/*Data for the table `tblcolorways` */

insert  into `tblcolorways`(`id`,`colorways`,`created_at`) values 
(25,'Yellow ','2023-12-20 13:43:30'),
(26,'Dirty White','2023-12-20 13:43:38'),
(27,'Rose Gold','2023-12-20 15:11:02'),
(28,'Oreo','2023-12-20 15:11:53'),
(30,'Black and white','2023-12-20 17:42:17');

/*Table structure for table `tblmodel` */

DROP TABLE IF EXISTS `tblmodel`;

CREATE TABLE `tblmodel` (
  `id` int NOT NULL AUTO_INCREMENT,
  `model` varchar(250) DEFAULT NULL,
  `created_at` datetime DEFAULT NULL,
  KEY `id` (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=41 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

/*Data for the table `tblmodel` */

insert  into `tblmodel`(`id`,`model`,`created_at`) values 
(35,'Ja morant','2023-12-20 15:10:26'),
(36,'Precision 6','2023-12-20 15:10:32'),
(37,'LeBron 8','2023-12-20 15:10:52'),
(38,'Clifford','2023-12-20 15:11:46'),
(39,'KD 15','2023-12-20 15:12:03'),
(40,'High Cut','2023-12-20 17:42:10');

/*Table structure for table `tblproducts` */

DROP TABLE IF EXISTS `tblproducts`;

CREATE TABLE `tblproducts` (
  `prod_id` int NOT NULL AUTO_INCREMENT,
  `prod_brand` varchar(150) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci DEFAULT NULL,
  `prod_model` varchar(150) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci DEFAULT NULL,
  `prod_size` int DEFAULT NULL,
  `prod_colorways` varchar(150) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci DEFAULT NULL,
  `prod_description` varchar(150) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci DEFAULT NULL,
  `prod_qty` int DEFAULT NULL,
  `prod_price` int DEFAULT NULL,
  `prod_date` datetime DEFAULT NULL ON UPDATE CURRENT_TIMESTAMP,
  KEY `id` (`prod_id`)
) ENGINE=InnoDB AUTO_INCREMENT=154 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

/*Data for the table `tblproducts` */

insert  into `tblproducts`(`prod_id`,`prod_brand`,`prod_model`,`prod_size`,`prod_colorways`,`prod_description`,`prod_qty`,`prod_price`,`prod_date`) values 
(147,'Adidas','Ja morant',42,'Dirty White','UA',12,1800,'2023-12-20 17:59:42'),
(150,'Botchoy','Clifford',45,'Oreo','Quality shoes',2,3500,'2023-12-20 17:50:09'),
(152,'Nike','Ja morant',45,'Dirty White','Cool shoes',10,2500,'2023-12-20 17:36:37');

/*Table structure for table `tblproductscancel` */

DROP TABLE IF EXISTS `tblproductscancel`;

CREATE TABLE `tblproductscancel` (
  `id` int NOT NULL AUTO_INCREMENT,
  `prod_id` int DEFAULT NULL,
  `prod_brand` varchar(150) DEFAULT NULL,
  `prod_model` varchar(150) DEFAULT NULL,
  `prod_size` int DEFAULT NULL,
  `prod_colorways` varchar(150) DEFAULT NULL,
  `prod_description` varchar(150) DEFAULT NULL,
  `prod_qty` int DEFAULT NULL,
  `prod_price` int DEFAULT NULL,
  `prod_date` datetime DEFAULT NULL,
  KEY `id` (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=12 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

/*Data for the table `tblproductscancel` */

insert  into `tblproductscancel`(`id`,`prod_id`,`prod_brand`,`prod_model`,`prod_size`,`prod_colorways`,`prod_description`,`prod_qty`,`prod_price`,`prod_date`) values 
(10,146,'Nike','Precision 6',43,'Mint Green','OEM',1,1500,'2023-12-20 14:32:53'),
(11,150,'Botchoy','Clifford',45,'Oreo','Quality shoes',2,10500,'2023-12-20 17:51:03');

/*Table structure for table `tblsales` */

DROP TABLE IF EXISTS `tblsales`;

CREATE TABLE `tblsales` (
  `id` int NOT NULL AUTO_INCREMENT,
  `trans_id` varchar(150) DEFAULT NULL,
  `prod_brand` varchar(150) DEFAULT NULL,
  `prod_model` varchar(150) DEFAULT NULL,
  `prod_size` varchar(150) DEFAULT NULL,
  `prod_colorways` varchar(150) DEFAULT NULL,
  `prod_description` varchar(150) DEFAULT NULL,
  `prod_qty` varchar(150) DEFAULT NULL,
  `prod_price` varchar(150) DEFAULT NULL,
  `prod_date` datetime(6) DEFAULT NULL,
  `total_price` decimal(10,0) DEFAULT NULL,
  KEY `id` (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=165 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

/*Data for the table `tblsales` */

insert  into `tblsales`(`id`,`trans_id`,`prod_brand`,`prod_model`,`prod_size`,`prod_colorways`,`prod_description`,`prod_qty`,`prod_price`,`prod_date`,`total_price`) values 
(155,NULL,'Nike','Precision 6','43','Mint Green',NULL,'1','1500.00','2023-12-20 13:20:09.000000',3366),
(156,NULL,'Nike','Ja morant','42','Chimney',NULL,'1','1800.00','2023-12-20 13:35:55.000000',3366),
(157,NULL,'Nike','Precision 6','43','Mint Green',NULL,'1','1500.00','2023-12-20 13:37:06.000000',1530),
(158,NULL,'Converse','Converse Chuck 70','9','Dirty White',NULL,'1','3000.00','2023-12-20 13:51:04.000000',7140),
(159,NULL,'Nike','Precision 6','43','Mint Green',NULL,'1','1500.00','2023-12-20 14:32:15.000000',1530),
(160,NULL,'Nike','Ja morant','42','Chimney',NULL,'1','1800.00','2023-12-20 14:47:32.000000',8976),
(161,NULL,'Nike','Ja morant','42','Chimney',NULL,'1','1800.00','2023-12-20 15:26:58.000000',8602),
(162,NULL,'Nike','Ja morant','42','Chimney',NULL,'1','1800.00','2023-12-20 15:32:15.000000',8602),
(163,NULL,'Botchoy','Clifford','45','Oreo',NULL,'1','3500.00','2023-12-20 17:12:03.000000',3570),
(164,NULL,'Botchoy','Clifford','45','Oreo',NULL,'1','10500.00','2023-12-20 17:53:41.000000',18054);

/*Table structure for table `user_credentials` */

DROP TABLE IF EXISTS `user_credentials`;

CREATE TABLE `user_credentials` (
  `id` int NOT NULL AUTO_INCREMENT,
  `username` varchar(150) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci DEFAULT NULL,
  `password` varchar(150) DEFAULT NULL,
  `fname` varchar(150) DEFAULT NULL,
  `lname` varchar(150) DEFAULT NULL,
  `gender` varchar(150) DEFAULT NULL,
  `address` varchar(150) DEFAULT NULL,
  `contact_no` varchar(150) DEFAULT NULL,
  `created_at` datetime DEFAULT NULL,
  KEY `id` (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=16 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

/*Data for the table `user_credentials` */

insert  into `user_credentials`(`id`,`username`,`password`,`fname`,`lname`,`gender`,`address`,`contact_no`,`created_at`) values 
(15,'botchoy','botchoy','Leonard','Botchoy','Male','Prk. Pindasan','09876754632','2023-12-20 17:48:05');

/* Procedure structure for procedure `procAdminChangePassword` */

/*!50003 DROP PROCEDURE IF EXISTS  `procAdminChangePassword` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `procAdminChangePassword`(IN p_username VARCHAR(255),
							IN p_current_password VARCHAR(255),
							IN p_new_password VARCHAR(255),
							OUT p_result INTEGER)
BEGIN
		DECLARE user_count INT;
		SELECT COUNT(*) INTO user_count FROM admin_credentials
		WHERE username = p_username AND password = p_current_password;
		IF user_count > 0 THEN
			UPDATE admin_credentials
			SET password = p_new_password
			WHERE username = p_username;
			SET p_result = 1;
		ELSE
			SET p_result = 0; 
		END IF;
	END */$$
DELIMITER ;

/* Procedure structure for procedure `procAdminValidation` */

/*!50003 DROP PROCEDURE IF EXISTS  `procAdminValidation` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `procAdminValidation`(IN p_username VARCHAR(255), IN p_password VARCHAR(255), OUT p_valid INT)
BEGIN
		DECLARE countResult INT;
    
		SELECT COUNT(*) INTO countResult
		FROM admin_credentials
		WHERE username = p_username AND PASSWORD = p_password;
    
		-- Set the result
		SET p_valid = countResult;
	END */$$
DELIMITER ;

/* Procedure structure for procedure `procBrands` */

/*!50003 DROP PROCEDURE IF EXISTS  `procBrands` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `procBrands`()
BEGIN
		Select brand from tblbrand;
	END */$$
DELIMITER ;

/* Procedure structure for procedure `procCancelProducts` */

/*!50003 DROP PROCEDURE IF EXISTS  `procCancelProducts` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `procCancelProducts`(
    IN p_prod_id INTEGER,
    IN p_prod_brand VARCHAR(150),
    IN p_prod_model VARCHAR(150),
    IN p_prod_size INTEGER,
    IN p_prod_colorways VARCHAR(150),
    IN p_prod_description VARCHAR(150),
    IN p_prod_qty INTEGER,
    IN p_prod_price INTEGER,
    IN p_prod_date DATETIME
)
BEGIN
    DECLARE existing_qty INT;
    SELECT prod_qty INTO existing_qty FROM tblproductscancel WHERE prod_id = p_prod_id LIMIT 1;
    IF existing_qty IS NOT NULL THEN
        UPDATE tblproductscancel
        SET prod_qty = existing_qty + 1,
            prod_price = p_prod_price,
            prod_date = p_prod_date
        WHERE prod_id = p_prod_id;
    ELSE
        INSERT INTO tblproductscancel (
            prod_id, 
            prod_brand, 
            prod_model, 
            prod_size, 
            prod_colorways, 
            prod_description, 
            prod_qty, 
            prod_price, 
            prod_date
        )
        VALUES (
            p_prod_id, 
            p_prod_brand, 
            p_prod_model, 
            p_prod_size, 
            p_prod_colorways, 
            p_prod_description, 
            1, 
            p_prod_price, 
            p_prod_date
        );
    END IF;
        
END */$$
DELIMITER ;

/* Procedure structure for procedure `procCashierName` */

/*!50003 DROP PROCEDURE IF EXISTS  `procCashierName` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `procCashierName`(p_lname varchar(255))
BEGIN
		SELECT lname from user_credentials where lname = p_lname; 
	END */$$
DELIMITER ;

/* Procedure structure for procedure `procCreateAccount` */

/*!50003 DROP PROCEDURE IF EXISTS  `procCreateAccount` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `procCreateAccount`(p_username VARCHAR(150),
								p_password VARCHAR(150),
								p_fname VARCHAR(150),
								p_lname VARCHAR(150),
								p_gender VARCHAR(150),
								p_address VARCHAR(150),
								p_contact_no VARCHAR(150),
								p_created_at DATETIME)
BEGIN
	IF NOT EXISTS (SELECT 1 FROM user_credentials WHERE username = p_username) THEN
	
        INSERT INTO user_credentials(username, PASSWORD, fname, lname, gender, address, contact_no, created_at) 
        VALUES(p_username, p_password, p_fname, p_lname, p_gender, p_address, p_contact_no, p_created_at);
        
        SELECT 'Account created successfully' AS result;
    ELSE
    
        SELECT 'Duplicate username. Account creation failed.' AS result;
        
    END IF;
	END */$$
DELIMITER ;

/* Procedure structure for procedure `procCriticalItems` */

/*!50003 DROP PROCEDURE IF EXISTS  `procCriticalItems` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `procCriticalItems`()
BEGIN
		SELect prod_id,
		prod_brand,
		prod_model,
		prod_size,
		prod_colorways,
		prod_description,
		prod_qty,
		prod_price,
		prod_date FROM tblproducts where prod_qty < 5; 
	END */$$
DELIMITER ;

/* Procedure structure for procedure `procDailySales` */

/*!50003 DROP PROCEDURE IF EXISTS  `procDailySales` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `procDailySales`()
BEGIN
		SELECT prod_date, SUM(prod_price) AS total_price FROM tblsales GROUP BY prod_date;
	END */$$
DELIMITER ;

/* Procedure structure for procedure `procDateFilterSalesHistory` */

/*!50003 DROP PROCEDURE IF EXISTS  `procDateFilterSalesHistory` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `procDateFilterSalesHistory`(IN start_date DATE,
									 IN end_date DATE)
BEGIN
		SELECT
		prod_brand AS Brand,
		prod_model As Model,
		prod_size As Size,
		prod_colorways AS Colorways,
		prod_qty AS Quantity,
		prod_price as Price,
		prod_date as Date
		FROM tblsales WHERE prod_date >= start_date AND prod_date < DATE_ADD(end_date, INTERVAL 1 DAY);
	END */$$
DELIMITER ;

/* Procedure structure for procedure `procDatePicker` */

/*!50003 DROP PROCEDURE IF EXISTS  `procDatePicker` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `procDatePicker`(
    IN start_date DATE,
    IN end_date DATE
)
BEGIN
		SELECT
		prod_brand AS Brand,
		prod_model AS Model,
		prod_size AS Size,
		prod_colorways AS Colorways,
		prod_qty AS Quantity,
		prod_price AS Price,
		prod_date AS DATE
		FROM tblproductscancel WHERE prod_date >= start_date AND prod_date < DATE_ADD(end_date, INTERVAL 1 DAY);
END */$$
DELIMITER ;

/* Procedure structure for procedure `procDeleteAccount` */

/*!50003 DROP PROCEDURE IF EXISTS  `procDeleteAccount` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `procDeleteAccount`(p_id INTEGER)
BEGIN
		DELETE FROM user_credentials WHERE id=p_id;
	END */$$
DELIMITER ;

/* Procedure structure for procedure `procDeleteBrandById` */

/*!50003 DROP PROCEDURE IF EXISTS  `procDeleteBrandById` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `procDeleteBrandById`(p_id INTEGER)
BEGIN
		DELETE FROM tblbrand WHERE id=p_id;
	END */$$
DELIMITER ;

/* Procedure structure for procedure `procDeleteColorwaysById` */

/*!50003 DROP PROCEDURE IF EXISTS  `procDeleteColorwaysById` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `procDeleteColorwaysById`(p_id INTEGER)
BEGIN
		DELETE FROM tblcolorways WHERE id=p_id;
	END */$$
DELIMITER ;

/* Procedure structure for procedure `procDeleteModeById` */

/*!50003 DROP PROCEDURE IF EXISTS  `procDeleteModeById` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `procDeleteModeById`(p_id INTEGER)
BEGIN
		DELETE FROM tblmodel WHERE id=p_id;
	END */$$
DELIMITER ;

/* Procedure structure for procedure `procDeleteProductById` */

/*!50003 DROP PROCEDURE IF EXISTS  `procDeleteProductById` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `procDeleteProductById`(p_id INTEGER)
BEGIN
		DELETE FROM tblproducts WHERE prod_id=p_id;
	END */$$
DELIMITER ;

/* Procedure structure for procedure `procDisplayAllDailySales` */

/*!50003 DROP PROCEDURE IF EXISTS  `procDisplayAllDailySales` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `procDisplayAllDailySales`(IN start_date DATE,
    IN end_date DATE)
BEGIN
		SELECT
		prod_brand AS Brand,
		prod_model AS Model,
		prod_size AS Size,
		prod_colorways AS Colorways,
		prod_qty AS Quantity,
		prod_price AS Price,
		prod_date AS DATE
		FROM tblsales WHERE prod_date >= start_date AND prod_date < DATE_ADD(end_date, INTERVAL 1 DAY);
	END */$$
DELIMITER ;

/* Procedure structure for procedure `procDisplayAllProducts` */

/*!50003 DROP PROCEDURE IF EXISTS  `procDisplayAllProducts` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `procDisplayAllProducts`()
BEGIN
	SELECT 
		prod_id,
		prod_brand,
		prod_model,
		prod_size,
		prod_colorways,
		prod_description,
		prod_qty,
		prod_price,
		prod_date
		FROM tblproducts;
	END */$$
DELIMITER ;

/* Procedure structure for procedure `procDisplayBrand` */

/*!50003 DROP PROCEDURE IF EXISTS  `procDisplayBrand` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `procDisplayBrand`()
BEGIN
		SELECT DISTINCT id, brand, created_at FROM tblbrand;
	END */$$
DELIMITER ;

/* Procedure structure for procedure `procDisplayBrandComboBox` */

/*!50003 DROP PROCEDURE IF EXISTS  `procDisplayBrandComboBox` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `procDisplayBrandComboBox`()
BEGIN
		Select DISTINCT brand from tblbrand;
	END */$$
DELIMITER ;

/* Procedure structure for procedure `procDisplayCancelProducts` */

/*!50003 DROP PROCEDURE IF EXISTS  `procDisplayCancelProducts` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `procDisplayCancelProducts`()
BEGIN
		Select 
		prod_id,
		prod_brand,
		prod_model,
		prod_size,
		prod_colorways,
		prod_description,
		prod_qty,
		prod_price,
		DATE_FORMAT(prod_date, '%Y-%m-%d') AS formatted_date
		from tblproductscancel;
	END */$$
DELIMITER ;

/* Procedure structure for procedure `procDisplayCashierAccounts` */

/*!50003 DROP PROCEDURE IF EXISTS  `procDisplayCashierAccounts` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `procDisplayCashierAccounts`()
BEGIN
		Select id,
		fname,
		lname,
		gender,
		address,
		contact_no,
		username,
		PASSWORD,
		created_at from user_credentials;
	END */$$
DELIMITER ;

/* Procedure structure for procedure `procDisplayColorways` */

/*!50003 DROP PROCEDURE IF EXISTS  `procDisplayColorways` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `procDisplayColorways`()
BEGIN
		SELECT DISTINCT id, colorways, created_at FROM tblcolorways;
	END */$$
DELIMITER ;

/* Procedure structure for procedure `procDisplayColorwaysComboBox` */

/*!50003 DROP PROCEDURE IF EXISTS  `procDisplayColorwaysComboBox` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `procDisplayColorwaysComboBox`()
BEGIN
		Select DISTINCT colorways from tblcolorways;
	END */$$
DELIMITER ;

/* Procedure structure for procedure `procDisplayCriticalItems` */

/*!50003 DROP PROCEDURE IF EXISTS  `procDisplayCriticalItems` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `procDisplayCriticalItems`()
BEGIN
		SELECT prod_qty FROM tblproducts
				WHERE prod_qty < 5;
	END */$$
DELIMITER ;

/* Procedure structure for procedure `procDisplayModel` */

/*!50003 DROP PROCEDURE IF EXISTS  `procDisplayModel` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `procDisplayModel`()
BEGIN
		SELECT DISTINCT id, model, created_at FROM tblmodel;
	END */$$
DELIMITER ;

/* Procedure structure for procedure `procDisplayModelComboBox` */

/*!50003 DROP PROCEDURE IF EXISTS  `procDisplayModelComboBox` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `procDisplayModelComboBox`()
BEGIN
		Select DISTINCT model from tblmodel;
	END */$$
DELIMITER ;

/* Procedure structure for procedure `procDisplayTotalQuantity` */

/*!50003 DROP PROCEDURE IF EXISTS  `procDisplayTotalQuantity` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `procDisplayTotalQuantity`()
BEGIN
		SELECT prod_qty FROM tblproducts;
	END */$$
DELIMITER ;

/* Procedure structure for procedure `procInsertBrand` */

/*!50003 DROP PROCEDURE IF EXISTS  `procInsertBrand` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `procInsertBrand`(p_brand varchar(250),p_created_at DATETIME)
BEGIN
		IF NOT EXISTS (SELECT 1 FROM tblbrand WHERE brand = p_brand) THEN
		Insert into tblbrand(brand, created_at) values (p_brand, p_created_at);
		 
		SELECT 'Account created successfully' AS result;
		ELSE
    
		SELECT 'Duplicate brand. Account creation failed.' AS result;
		END IF;
	END */$$
DELIMITER ;

/* Procedure structure for procedure `procInsertColorways` */

/*!50003 DROP PROCEDURE IF EXISTS  `procInsertColorways` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `procInsertColorways`(p_colorways VARCHAR(250), p_created_at DATETIME)
BEGIN
		IF NOT EXISTS (SELECT 1 FROM tblcolorways WHERE colorways = p_colorways) THEN
		INSERT INTO tblcolorways(colorways, created_at) VALUES (p_colorways, p_created_at);
		 
		SELECT 'Colorways created successfully' AS result;
		ELSE
    
		SELECT 'Duplicate colorways. Account creation failed.' AS result;
		END IF;
	END */$$
DELIMITER ;

/* Procedure structure for procedure `procInsertModel` */

/*!50003 DROP PROCEDURE IF EXISTS  `procInsertModel` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `procInsertModel`(p_model VARCHAR(250),p_created_at DATETIME)
BEGIN
		IF NOT EXISTS (SELECT 1 FROM tblmodel WHERE model = p_model) THEN
		INSERT INTO tblmodel(model, created_at) VALUES (p_model, p_created_at);
		 
		SELECT 'Account created successfully' AS result;
		ELSE
    
		SELECT 'Duplicate model. Account creation failed.' AS result;
		END IF;
	END */$$
DELIMITER ;

/* Procedure structure for procedure `procInsertProductPayment` */

/*!50003 DROP PROCEDURE IF EXISTS  `procInsertProductPayment` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `procInsertProductPayment`(
    p_prod_brand VARCHAR(255),
    p_prod_model VARCHAR(255),
    p_prod_size VARCHAR(255),
    p_prod_colorways VARCHAR(255),
    p_prod_quantity INT,
    p_prod_price DECIMAL(18, 2),
    p_total_amount DECIMAL(18, 2),
    p_prod_date datetime
)
BEGIN
    INSERT INTO tblsales (
        prod_brand,
        prod_model,
        prod_size,
        prod_colorways,
        prod_qty,
        prod_price,
        total_price,
        prod_date
    )
    VALUES (
        p_prod_brand,
        p_prod_model,
        p_prod_size,
        p_prod_colorways,
        p_prod_quantity,
        p_prod_price,
        p_total_amount,
        p_prod_date
    );
END */$$
DELIMITER ;

/* Procedure structure for procedure `procInsertProducts` */

/*!50003 DROP PROCEDURE IF EXISTS  `procInsertProducts` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `procInsertProducts`(
                                         p_prod_brand VARCHAR(150),
                                         p_prod_model VARCHAR(150),
                                         p_prod_size INTEGER,
                                         p_prod_colorways VARCHAR(150),
                                         p_prod_description VARCHAR(150),
                                         p_prod_qty INteger,
                                         p_prod_price Integer,
                                         p_prod_date DATETIME)
BEGIN
		INSERT INTO tblproducts(prod_brand,
                                  prod_model,
                                  prod_size,
                                  prod_colorways,
                                  prod_description,
                                  prod_qty,
                                  prod_price,
                                  prod_date)
                                  
                        VALUES(p_prod_brand,
                               p_prod_model,
                               p_prod_size,
                               p_prod_colorways,
                               p_prod_description,
                               p_prod_qty,
                               p_prod_price,
                               p_prod_date);
	END */$$
DELIMITER ;

/* Procedure structure for procedure `procRandomNumberWithDate` */

/*!50003 DROP PROCEDURE IF EXISTS  `procRandomNumberWithDate` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `procRandomNumberWithDate`()
BEGIN
    DECLARE current_datetime_value DATETIME;
    DECLARE random_number_value VARCHAR(10);
    SET current_datetime_value = NOW();
    SET random_number_value = LPAD(FLOOR(RAND() * POWER(10, 10)), 10, '0');
        
    SELECT current_datetime_value AS generated_current_date, random_number_value AS transaction_code;
END */$$
DELIMITER ;

/* Procedure structure for procedure `procSearchProductbyFilterWithAutoComplete` */

/*!50003 DROP PROCEDURE IF EXISTS  `procSearchProductbyFilterWithAutoComplete` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `procSearchProductbyFilterWithAutoComplete`(p_search VARCHAR(50), p_filter VARCHAR(9))
BEGIN
		IF p_filter="ID" THEN
               SELECT prod_id,
                    prod_brand,
                    prod_model,
                    prod_size,
                    prod_colorways,
                    prod_description,
                    prod_qty,
                    prod_price
                FROM tblproducts
                WHERE prod_id LIKE CONCAT(p_search,'%');
		ELSEIF p_filter="Brand" THEN
               SELECT prod_id,
                    prod_brand,
                    prod_model,
                    prod_size,
                    prod_colorways,
                    prod_description,
                    prod_qty,
                    prod_price
                FROM tblproducts
                WHERE prod_brand LIKE CONCAT(p_search,'%');                              
             ELSEIF p_filter="Model" THEN
               SELECT prod_id,
                    prod_brand,
                    prod_model,
                    prod_size,
                    prod_colorways,
                    prod_description,
                    prod_qty,
                    prod_price
                FROM tblproducts
                WHERE prod_model LIKE CONCAT(p_search,'%');
              ELSEIF p_filter="Size" THEN
                SELECT prod_id,
                    prod_brand,
                    prod_model,
                    prod_size,
                    prod_colorways,
                    prod_description,
                    prod_qty,
                    prod_price
                FROM tblproducts
                WHERE prod_size LIKE CONCAT(p_search,'%');
              ELSEIF p_filter="Colorways" THEN
                SELECT prod_id,
                    prod_brand,
                    prod_model,
                    prod_size,
                    prod_colorways,
                    prod_description,
                    prod_qty,
                    prod_price
                FROM tblproducts
                WHERE prod_colorways LIKE CONCAT(p_search,'%');  
              ELSEIF p_filter="Price" THEN
                SELECT prod_id,
                    prod_brand,
                    prod_model,
                    prod_size,
                    prod_colorways,
                    prod_description,
                    prod_qty,
                    prod_price
                FROM tblproducts
                WHERE prod_price LIKE CONCAT(p_search,'%');
                ELSEIF p_filter="Quantity" THEN
                SELECT prod_id,
                    prod_brand,
                    prod_model,
                    prod_size,
                    prod_colorways,
                    prod_description,
                    prod_qty,
                    prod_price
                FROM tblproducts
                WHERE prod_qty LIKE CONCAT(p_search,'%');                             
            END IF;
	END */$$
DELIMITER ;

/* Procedure structure for procedure `procSelectId` */

/*!50003 DROP PROCEDURE IF EXISTS  `procSelectId` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `procSelectId`(p_id INTEGER)
BEGIN
		 SELECT 
			prod_id,
			prod_brand,
			prod_model,
			prod_size,
			prod_colorways,
			prod_description,
			1 AS prod_qty, -- Set quantity to 1
			prod_price
			FROM tblproducts
			WHERE prod_id = p_id;
	END */$$
DELIMITER ;

/* Procedure structure for procedure `procUpdateBrandByID` */

/*!50003 DROP PROCEDURE IF EXISTS  `procUpdateBrandByID` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `procUpdateBrandByID`(p_id integer, p_brand VARCHAR(250),p_created_at DATETIME)
BEGIN
		UPDATE tblbrand SET brand = p_brand,
					created_at = p_created_at
					WHERE id = p_id;
	END */$$
DELIMITER ;

/* Procedure structure for procedure `procUpdateCashierAccountById` */

/*!50003 DROP PROCEDURE IF EXISTS  `procUpdateCashierAccountById` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `procUpdateCashierAccountById`(p_id INTEGER,
                                                     p_fname varchar (150),
                                                     p_lname VARCHAR(150),
                                                     p_gender VARCHAR(150),
                                                     p_address varchar(150),
						     p_contact_no VARCHAR(150),
						     p_username VARCHAR(150),
						     p_password VARCHAR(150),
						     p_created_at DATETIME)
BEGIN
	UPDATE user_credentials SET fname = p_fname,
					lname = p_lname,
					gender = p_gender,
					address = p_address,
					contact_no = p_contact_no,
					username = p_username,
					PASSWORD = p_password,
					created_at = p_created_at
					WHERE id = p_id;
	END */$$
DELIMITER ;

/* Procedure structure for procedure `procUpdateColorwaysById` */

/*!50003 DROP PROCEDURE IF EXISTS  `procUpdateColorwaysById` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `procUpdateColorwaysById`(p_id INTEGER, p_colorways VARCHAR(250),p_created_at DATETIME)
BEGIN
		UPDATE tblcolorways SET colorways = p_colorways,
					created_at = p_created_at
					WHERE id = p_id;
	END */$$
DELIMITER ;

/* Procedure structure for procedure `procUpdateModelById` */

/*!50003 DROP PROCEDURE IF EXISTS  `procUpdateModelById` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `procUpdateModelById`(p_id INTEGER, p_model VARCHAR(250),p_created_at DATETIME)
BEGIN
		UPDATE tblmodel SET model = p_model,
					created_at = p_created_at
					WHERE id = p_id;
	END */$$
DELIMITER ;

/* Procedure structure for procedure `procUpdateProductById` */

/*!50003 DROP PROCEDURE IF EXISTS  `procUpdateProductById` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `procUpdateProductById`(p_id integer,
						     p_prod_brand VARCHAR(150),
						     p_prod_model VARCHAR(150),
                                                     p_prod_size INTEGER,
                                                     p_prod_colorways VARCHAR(150),
                                                     p_prod_description VARCHAR(150),
                                                     p_prod_qty INTEGER,
						     p_prod_price INTEGER,
						     p_prod_date DATETIME)
BEGIN
		UPDATE tblproducts SET prod_brand = p_prod_brand,
					prod_model = p_prod_model,
					prod_size = p_prod_size,
					prod_colorways = p_prod_colorways,
					prod_description = p_prod_description,
					prod_qty = p_prod_qty,
					prod_price = p_prod_price,
					prod_date = p_prod_date
					WHERE prod_id = p_id;
	END */$$
DELIMITER ;

/* Procedure structure for procedure `procUpdateQuantityByEnter` */

/*!50003 DROP PROCEDURE IF EXISTS  `procUpdateQuantityByEnter` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `procUpdateQuantityByEnter`(p_id integer)
BEGIN
		UPDATE tblproducts SET prod_qty = prod_qty - 1 WHERE prod_id=p_id;
		
		 IF (SELECT prod_qty FROM tblproducts WHERE prod_id = p_id) <= 0 THEn
		DELETE FROM tblproducts WHERE prod_id = p_id;
		END IF;
	END */$$
DELIMITER ;

/* Procedure structure for procedure `procUpdateQuantityById` */

/*!50003 DROP PROCEDURE IF EXISTS  `procUpdateQuantityById` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `procUpdateQuantityById`(p_id Integer, p_qty integer)
BEGIN
		UPDATE tblproducts set prod_qty = prod_qty - p_qty where prod_id=p_id;
		
		IF (SELECT prod_qty FROM tblproducts WHERE prod_id = p_id) <= 0 THEN
		DELETE FROM tblproducts WHERE prod_id = p_id;
		END IF;
	END */$$
DELIMITER ;

/* Procedure structure for procedure `procUserValidation` */

/*!50003 DROP PROCEDURE IF EXISTS  `procUserValidation` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `procUserValidation`(IN p_username VARCHAR(255), IN p_password VARCHAR(255), OUT p_valid INT)
BEGIN
		DECLARE countResult INT;
    
		SELECT COUNT(*) INTO countResult
		FROM user_credentials
		WHERE username = p_username AND password = p_password;
    
		-- Set the result
		SET p_valid = countResult;
	END */$$
DELIMITER ;

/* Procedure structure for procedure `procYearlySales` */

/*!50003 DROP PROCEDURE IF EXISTS  `procYearlySales` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `procYearlySales`()
BEGIN
		SELECT YEAR(prod_date) AS sales_year, SUM(prod_price) AS total_yearly_sales FROM tblsales GROUP BY sales_year;
	END */$$
DELIMITER ;

/* Procedure structure for procedure `procYearySales` */

/*!50003 DROP PROCEDURE IF EXISTS  `procYearySales` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `procYearySales`()
BEGIN
		SELECT YEAR(prod_date), SUM(prod_price) FROM tblproducts
					GROUP BY YEAR(prod_date);
	END */$$
DELIMITER ;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;
