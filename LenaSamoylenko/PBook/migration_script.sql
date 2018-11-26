-- ----------------------------------------------------------------------------
-- MySQL Workbench Migration
-- Migrated Schemata: pb
-- Source Schemata: phonebook
-- Created: Sun Nov 25 22:59:00 2018
-- Workbench Version: 8.0.12
-- ----------------------------------------------------------------------------

SET FOREIGN_KEY_CHECKS = 0;

-- ----------------------------------------------------------------------------
-- Schema pb
-- ----------------------------------------------------------------------------
DROP SCHEMA IF EXISTS `pb` ;
CREATE SCHEMA IF NOT EXISTS `pb` ;

-- ----------------------------------------------------------------------------
-- Table pb.address
-- ----------------------------------------------------------------------------
CREATE TABLE IF NOT EXISTS `pb`.`address` (
  `idName` INT(11) NOT NULL,
  `City` VARCHAR(25) NULL DEFAULT NULL,
  `Street` VARCHAR(25) NULL DEFAULT NULL,
  `homeNumber` DECIMAL(10,0) NULL DEFAULT NULL,
  `Flat` INT(10) NULL DEFAULT NULL,
  `id_adress` INT(11) NOT NULL AUTO_INCREMENT,
  PRIMARY KEY (`id_adress`),
  INDEX `fk_adress_idx` (`idName` ASC, `id_adress` ASC) VISIBLE)
ENGINE = InnoDB
AUTO_INCREMENT = 77
DEFAULT CHARACTER SET = utf8mb4
COLLATE = utf8mb4_0900_ai_ci;

-- ----------------------------------------------------------------------------
-- Table pb.email
-- ----------------------------------------------------------------------------
CREATE TABLE IF NOT EXISTS `pb`.`email` (
  `idName` INT(11) NOT NULL,
  `eMail` VARCHAR(45) NULL DEFAULT NULL,
  `id_mail` INT(11) NOT NULL,
  PRIMARY KEY (`id_mail`),
  INDEX `fk_email_idx` (`idName` ASC) VISIBLE,
  CONSTRAINT `fk_email`
    FOREIGN KEY (`idName`)
    REFERENCES `pb`.`name` (`idName`)
    ON DELETE CASCADE
    ON UPDATE CASCADE)
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8mb4
COLLATE = utf8mb4_0900_ai_ci;

-- ----------------------------------------------------------------------------
-- Table pb.name
-- ----------------------------------------------------------------------------
CREATE TABLE IF NOT EXISTS `pb`.`name` (
  `idName` INT(11) NOT NULL AUTO_INCREMENT,
  `FirstName` VARCHAR(45) NOT NULL,
  `SecondName` VARCHAR(45) NOT NULL,
  PRIMARY KEY (`idName`),
  UNIQUE INDEX `key` (`SecondName` ASC, `FirstName` ASC) VISIBLE,
  UNIQUE INDEX `idName_UNIQUE` (`idName` ASC) VISIBLE,
  INDEX `ID` (`idName` ASC) VISIBLE)
ENGINE = InnoDB
AUTO_INCREMENT = 77
DEFAULT CHARACTER SET = utf8mb4
COLLATE = utf8mb4_0900_ai_ci;

-- ----------------------------------------------------------------------------
-- Table pb.phone
-- ----------------------------------------------------------------------------
CREATE TABLE IF NOT EXISTS `pb`.`phone` (
  `idName` INT(11) NOT NULL,
  `Phone` DECIMAL(12,0) NULL DEFAULT NULL,
  `id_phone` INT(11) NOT NULL AUTO_INCREMENT,
  PRIMARY KEY (`id_phone`),
  INDEX `idx_phone_ibName` (`idName` ASC) VISIBLE,
  CONSTRAINT `fk_phone`
    FOREIGN KEY (`idName`)
    REFERENCES `pb`.`name` (`idName`)
    ON DELETE CASCADE
    ON UPDATE CASCADE)
ENGINE = InnoDB
AUTO_INCREMENT = 77
DEFAULT CHARACTER SET = utf8mb4
COLLATE = utf8mb4_0900_ai_ci;

-- ----------------------------------------------------------------------------
-- Table pb.skype
-- ----------------------------------------------------------------------------
CREATE TABLE IF NOT EXISTS `pb`.`skype` (
  `idName` INT(11) NOT NULL,
  `SkypeName` VARCHAR(45) NULL DEFAULT NULL,
  `Password` VARCHAR(45) NULL DEFAULT NULL,
  `id_skype` INT(11) NOT NULL AUTO_INCREMENT,
  PRIMARY KEY (`id_skype`),
  INDEX `fk_skype_idx` (`idName` ASC) VISIBLE,
  CONSTRAINT `fk_skype`
    FOREIGN KEY (`idName`)
    REFERENCES `pb`.`name` (`idName`)
    ON DELETE CASCADE
    ON UPDATE CASCADE)
ENGINE = InnoDB
AUTO_INCREMENT = 77
DEFAULT CHARACTER SET = utf8mb4
COLLATE = utf8mb4_0900_ai_ci;

-- ----------------------------------------------------------------------------
-- View pb.all data
-- ----------------------------------------------------------------------------
USE `pb`;
CREATE  OR REPLACE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `phonebook`.`all data` AS select `phonebook`.`name`.`idName` AS `ID`,`phonebook`.`name`.`FirstName` AS `FirstName`,`phonebook`.`name`.`SecondName` AS `SecondName`,`phonebook`.`email`.`eMail` AS `e-mail`,concat(`phonebook`.`address`.`City`,'; ',`phonebook`.`address`.`Street`,', ',`phonebook`.`address`.`homeNumber`,'/',`phonebook`.`address`.`Flat`) AS `address`,`phonebook`.`skype`.`SkypeName` AS `skype`,`phonebook`.`phone`.`Phone` AS `phone` from ((((`phonebook`.`name` left join `phonebook`.`phone` on((`phonebook`.`name`.`idName` = `phonebook`.`phone`.`idName`))) left join `phonebook`.`email` on((`phonebook`.`name`.`idName` = `phonebook`.`email`.`idName`))) left join `phonebook`.`address` on((`phonebook`.`name`.`idName` = `phonebook`.`address`.`idName`))) left join `phonebook`.`skype` on((`phonebook`.`name`.`idName` = `phonebook`.`skype`.`idName`)));

-- ----------------------------------------------------------------------------
-- Routine pb.insertData
-- ----------------------------------------------------------------------------
DELIMITER $$

DELIMITER $$
USE `pb`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `insertData`(FirstName varchar(45), SecondName varchar(45), eMail varchar(60), skype varchar(45), phone decimal(12, 0), adress varchar(76))
BEGIN


insert into `name`(`FirstName`,`SecondName`) values (FirstName, SecondName);
set @var :=LAST_INSERT_ID() ;
set @city:= string_split(adress, ','||' '||'.'||'/');
-- select @var;

insert into `email` (`eMail`, `idName`,`id_mail`)
values (eMail, @var, @var); 

insert into `phone` (`phone`, `idName`, `id_phone`)
values (phone, @var, @var); 

insert into `skype` (`SkypeName`, `idName`, `Password`, `id_skype`)
values (skype, @var, '1111', @var);

insert into `address` (`idName`,`City`,`Street`,`homeNumber`,`Flat`,`id_adress`)
values (@var, @city, null, null, null, @var);

END$$

DELIMITER ;

-- ----------------------------------------------------------------------------
-- Routine pb.selectData
-- ----------------------------------------------------------------------------
DELIMITER $$

DELIMITER $$
USE `pb`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `selectData`()
BEGIN
select *
from `all data`;
END$$

DELIMITER ;

-- ----------------------------------------------------------------------------
-- Routine pb.updateData
-- ----------------------------------------------------------------------------
DELIMITER $$

DELIMITER $$
USE `pb`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `updateData`(FirstName varchar(45), SecondName varchar(45), eMail varchar(60), skype varchar(45), phone decimal(12, 0), adress varchar (76), ID int(11))
BEGIN
-- `address`

update `name` 
set `FirstName`=FirstName, `SecondName`=SecondName
where `name`.`idName`=ID;

update `email`
set `eMail`=eMail
where `idName`=ID;

update `skype`
set `SkypeName`= skype
where `idName`=ID;

update `phone` 
set `Phone`=phone
where `idName`=ID;

update `address`
set `City`=adress
where `idName`=ID;

END$$

DELIMITER ;
SET FOREIGN_KEY_CHECKS = 1;
