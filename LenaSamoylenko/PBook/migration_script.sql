-- ----------------------------------------------------------------------------
-- MySQL Workbench Migration
-- Migrated Schemata: PB
-- Source Schemata: phonebook
-- Created: Tue Nov 20 22:26:05 2018
-- Workbench Version: 8.0.12
-- ----------------------------------------------------------------------------

SET FOREIGN_KEY_CHECKS = 0;

-- ----------------------------------------------------------------------------
-- Schema PB
-- ----------------------------------------------------------------------------
DROP SCHEMA IF EXISTS `PB` ;
CREATE SCHEMA IF NOT EXISTS `PB` ;

-- ----------------------------------------------------------------------------
-- Table PB.address
-- ----------------------------------------------------------------------------
CREATE TABLE IF NOT EXISTS `PB`.`address` (
  `idName` INT(11) NOT NULL,
  `City` VARCHAR(25) NULL DEFAULT NULL,
  `Street` VARCHAR(25) NULL DEFAULT NULL,
  `homeNumber` DECIMAL(10,0) NULL DEFAULT NULL,
  `Flat` INT(10) NULL DEFAULT NULL,
  `id_adress` INT(11) NOT NULL AUTO_INCREMENT,
  PRIMARY KEY (`id_adress`),
  INDEX `fk_adress_idx` (`idName` ASC) VISIBLE,
  CONSTRAINT `fk_adress`
    FOREIGN KEY (`idName`)
    REFERENCES `PB`.`name` (`idName`)
    ON DELETE CASCADE
    ON UPDATE CASCADE)
ENGINE = InnoDB
AUTO_INCREMENT = 7
DEFAULT CHARACTER SET = utf8mb4
COLLATE = utf8mb4_0900_ai_ci;

-- ----------------------------------------------------------------------------
-- Table PB.email
-- ----------------------------------------------------------------------------
CREATE TABLE IF NOT EXISTS `PB`.`email` (
  `idName` INT(11) NOT NULL,
  `eMail` VARCHAR(45) NULL DEFAULT NULL,
  `id_mail` INT(11) NOT NULL,
  PRIMARY KEY (`id_mail`),
  INDEX `fk_email_idx` (`idName` ASC) VISIBLE,
  CONSTRAINT `fk_email`
    FOREIGN KEY (`idName`)
    REFERENCES `PB`.`name` (`idName`)
    ON DELETE CASCADE
    ON UPDATE CASCADE)
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8mb4
COLLATE = utf8mb4_0900_ai_ci;

-- ----------------------------------------------------------------------------
-- Table PB.name
-- ----------------------------------------------------------------------------
CREATE TABLE IF NOT EXISTS `PB`.`name` (
  `idName` INT(11) NOT NULL AUTO_INCREMENT,
  `FirstName` VARCHAR(45) NULL DEFAULT NULL,
  `SecondName` VARCHAR(45) NULL DEFAULT NULL,
  PRIMARY KEY (`idName`),
  UNIQUE INDEX `key` (`SecondName` ASC, `FirstName` ASC) VISIBLE,
  INDEX `ID` (`idName` ASC) VISIBLE)
ENGINE = InnoDB
AUTO_INCREMENT = 41
DEFAULT CHARACTER SET = utf8mb4
COLLATE = utf8mb4_0900_ai_ci;

-- ----------------------------------------------------------------------------
-- Table PB.phone
-- ----------------------------------------------------------------------------
CREATE TABLE IF NOT EXISTS `PB`.`phone` (
  `idName` INT(11) NOT NULL,
  `Phone` DECIMAL(12,0) NULL DEFAULT NULL,
  `id_phone` INT(11) NOT NULL AUTO_INCREMENT,
  PRIMARY KEY (`id_phone`),
  INDEX `idx_phone_ibName` (`idName` ASC) VISIBLE,
  CONSTRAINT `fk_phone`
    FOREIGN KEY (`idName`)
    REFERENCES `PB`.`name` (`idName`)
    ON DELETE CASCADE
    ON UPDATE CASCADE)
ENGINE = InnoDB
AUTO_INCREMENT = 7
DEFAULT CHARACTER SET = utf8mb4
COLLATE = utf8mb4_0900_ai_ci;

-- ----------------------------------------------------------------------------
-- Table PB.skype
-- ----------------------------------------------------------------------------
CREATE TABLE IF NOT EXISTS `PB`.`skype` (
  `idName` INT(11) NOT NULL,
  `SkypeName` VARCHAR(45) NULL DEFAULT NULL,
  `Password` VARCHAR(45) NULL DEFAULT NULL,
  `id_skype` INT(11) NOT NULL AUTO_INCREMENT,
  PRIMARY KEY (`id_skype`),
  INDEX `fk_skype_idx` (`idName` ASC) VISIBLE,
  CONSTRAINT `fk_skype`
    FOREIGN KEY (`idName`)
    REFERENCES `PB`.`name` (`idName`)
    ON DELETE CASCADE
    ON UPDATE CASCADE)
ENGINE = InnoDB
AUTO_INCREMENT = 7
DEFAULT CHARACTER SET = utf8mb4
COLLATE = utf8mb4_0900_ai_ci;

-- ----------------------------------------------------------------------------
-- View PB.all data
-- ----------------------------------------------------------------------------
USE `PB`;
CREATE  OR REPLACE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `phonebook`.`all data` AS select `phonebook`.`name`.`idName` AS `ID`,`phonebook`.`name`.`FirstName` AS `FirstName`,`phonebook`.`name`.`SecondName` AS `SecondName`,`phonebook`.`email`.`eMail` AS `e-mail`,concat(`phonebook`.`address`.`City`,'; ',`phonebook`.`address`.`Street`,', ',`phonebook`.`address`.`homeNumber`,'/',`phonebook`.`address`.`Flat`) AS `address`,`phonebook`.`skype`.`SkypeName` AS `skype`,`phonebook`.`phone`.`Phone` AS `phone` from ((((`phonebook`.`name` left join `phonebook`.`phone` on((`phonebook`.`name`.`idName` = `phonebook`.`phone`.`idName`))) left join `phonebook`.`email` on((`phonebook`.`name`.`idName` = `phonebook`.`email`.`idName`))) left join `phonebook`.`address` on((`phonebook`.`name`.`idName` = `phonebook`.`address`.`idName`))) left join `phonebook`.`skype` on((`phonebook`.`name`.`idName` = `phonebook`.`skype`.`idName`)));

-- ----------------------------------------------------------------------------
-- Routine PB.insertData
-- ----------------------------------------------------------------------------
DELIMITER $$

DELIMITER $$
USE `PB`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `insertData`(FirstName varchar(45), SecondName varchar(45), eMail varchar(60), skype varchar(45), phone decimal(12, 0))
BEGIN


insert into `name`(`FirstName`,`SecondName`) values (FirstName, SecondName);

set @var=(select `idName` from `phonebook`.`name` where `FirstName`=FirstName && `SecondName`=SecondName) ;
-- select @var;

insert into `email` (`eMail`, `idName`,`id_mail`)
values (eMail, @var, @var); 

insert into `phone` (`phone`, `idName`, `id_phone`)
values (phone, @var, @var); 

insert into `skype` (`skype`, `idName`)
values (skype, @var);

/*insert into`skype` (`SkypeName`) value (skype);


update `phone` 
set `Phone`=phone
where `idName`=ID*/
-- declare @var int(11);



END$$

DELIMITER ;

-- ----------------------------------------------------------------------------
-- Routine PB.selectData
-- ----------------------------------------------------------------------------
DELIMITER $$

DELIMITER $$
USE `PB`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `selectData`()
BEGIN
select *
from `all data`;
END$$

DELIMITER ;

-- ----------------------------------------------------------------------------
-- Routine PB.updateData
-- ----------------------------------------------------------------------------
DELIMITER $$

DELIMITER $$
USE `PB`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `updateData`(FirstName varchar(45), SecondName varchar(45), eMail varchar(60), skype varchar(45), phone decimal(12, 0), ID int(11))
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

END$$

DELIMITER ;
SET FOREIGN_KEY_CHECKS = 1;
