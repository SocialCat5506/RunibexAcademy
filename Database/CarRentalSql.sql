-- MySQL Script generated by MySQL Workbench
-- Mon Jul 18 17:09:40 2022
-- Model: New Model    Version: 1.0
-- MySQL Workbench Forward Engineering

SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0;
SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0;
SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION';

-- -----------------------------------------------------
-- Schema CarRental
-- -----------------------------------------------------

-- -----------------------------------------------------
-- Schema CarRental
-- -----------------------------------------------------
CREATE SCHEMA IF NOT EXISTS `CarRental` DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci ;
USE `CarRental` ;

-- -----------------------------------------------------
-- Table `CarRental`.`Brands`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `CarRental`.`Brands` (
  `Id` INT NOT NULL AUTO_INCREMENT,
  `Name` VARCHAR(25) CHARACTER SET 'utf8mb4' COLLATE 'utf8mb4_0900_ai_ci' NOT NULL,
  PRIMARY KEY (`Id`))
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8mb4
COLLATE = utf8mb4_0900_ai_ci;


-- -----------------------------------------------------
-- Table `CarRental`.`Colors`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `CarRental`.`Colors` (
  `Id` INT NOT NULL AUTO_INCREMENT,
  `Name` VARCHAR(25) CHARACTER SET 'utf8mb4' COLLATE 'utf8mb4_0900_ai_ci' NOT NULL,
  PRIMARY KEY (`Id`))
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8mb4
COLLATE = utf8mb4_0900_ai_ci;


-- -----------------------------------------------------
-- Table `CarRental`.`FuelTypes`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `CarRental`.`FuelTypes` (
  `Id` INT NOT NULL AUTO_INCREMENT,
  `Name` VARCHAR(25) CHARACTER SET 'utf8mb4' COLLATE 'utf8mb4_0900_ai_ci' NOT NULL,
  PRIMARY KEY (`Id`))
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8mb4
COLLATE = utf8mb4_0900_ai_ci;


-- -----------------------------------------------------
-- Table `CarRental`.`Models`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `CarRental`.`Models` (
  `Id` INT NOT NULL AUTO_INCREMENT,
  `BrandId` INT NOT NULL,
  `Name` VARCHAR(50) CHARACTER SET 'utf8mb4' COLLATE 'utf8mb4_0900_ai_ci' NOT NULL,
  PRIMARY KEY (`Id`, `BrandId`),
  INDEX `IX_Models_BrandId` (`BrandId` ASC),
  CONSTRAINT `FK_Models_Brands_BrandId`
    FOREIGN KEY (`BrandId`)
    REFERENCES `CarRental`.`Brands` (`Id`)
    ON DELETE CASCADE)
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8mb4
COLLATE = utf8mb4_0900_ai_ci;


-- -----------------------------------------------------
-- Table `CarRental`.`Cars`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `CarRental`.`Cars` (
  `Id` INT NOT NULL AUTO_INCREMENT,
  `BrandId` INT NOT NULL,
  `ModelId` INT NOT NULL,
  `ColorId` INT NOT NULL,
  `FuelTypeId` INT NOT NULL,
  `Milage` VARCHAR(15) CHARACTER SET 'utf8mb4' COLLATE 'utf8mb4_0900_ai_ci' NOT NULL,
  `Transmission` TINYINT(1) NOT NULL,
  `DailyPrice` DECIMAL(18,2) NOT NULL,
  `Description` VARCHAR(100) CHARACTER SET 'utf8mb3' NOT NULL,
  `IsDeleted` TINYINT(1) NOT NULL DEFAULT 0,
  PRIMARY KEY (`Id`, `FuelTypeId`, `ModelId`, `BrandId`, `ColorId`),
  INDEX `IX_Cars_BrandId` (`BrandId` ASC),
  INDEX `IX_Cars_ColorId` (`ColorId` ASC),
  INDEX `IX_Cars_FuelTypeId` (`FuelTypeId` ASC),
  INDEX `IX_Cars_ModelId` (`ModelId` ASC),
  CONSTRAINT `FK_Cars_Brands_BrandId`
    FOREIGN KEY (`BrandId`)
    REFERENCES `CarRental`.`Brands` (`Id`)
    ON DELETE CASCADE,
  CONSTRAINT `FK_Cars_Colors_ColorId`
    FOREIGN KEY (`ColorId`)
    REFERENCES `CarRental`.`Colors` (`Id`)
    ON DELETE CASCADE,
  CONSTRAINT `FK_Cars_FuelTypes_FuelTypeId`
    FOREIGN KEY (`FuelTypeId`)
    REFERENCES `CarRental`.`FuelTypes` (`Id`)
    ON DELETE CASCADE,
  CONSTRAINT `FK_Cars_Models_ModelId`
    FOREIGN KEY (`ModelId`)
    REFERENCES `CarRental`.`Models` (`Id`)
    ON DELETE CASCADE)
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8mb4
COLLATE = utf8mb4_0900_ai_ci;


-- -----------------------------------------------------
-- Table `CarRental`.`CarImages`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `CarRental`.`CarImages` (
  `Id` INT NOT NULL AUTO_INCREMENT,
  `CarId` INT NOT NULL,
  `ImagePath` LONGTEXT CHARACTER SET 'utf8mb4' COLLATE 'utf8mb4_0900_ai_ci' NOT NULL,
  `EditDate` DATETIME(6) NOT NULL,
  PRIMARY KEY (`Id`),
  INDEX `IX_CarImages_CarId` (`CarId` ASC),
  CONSTRAINT `FK_CarImages_Cars_CarId`
    FOREIGN KEY (`CarId`)
    REFERENCES `CarRental`.`Cars` (`Id`)
    ON DELETE CASCADE)
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8mb4
COLLATE = utf8mb4_0900_ai_ci;


-- -----------------------------------------------------
-- Table `CarRental`.`ColorModel`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `CarRental`.`ColorModel` (
  `ColorsId` INT NOT NULL,
  `ModelsId` INT NOT NULL,
  PRIMARY KEY (`ColorsId`, `ModelsId`),
  INDEX `IX_ColorModel_ModelsId` (`ModelsId` ASC),
  CONSTRAINT `FK_ColorModel_Colors_ColorsId`
    FOREIGN KEY (`ColorsId`)
    REFERENCES `CarRental`.`Colors` (`Id`)
    ON DELETE CASCADE,
  CONSTRAINT `FK_ColorModel_Models_ModelsId`
    FOREIGN KEY (`ModelsId`)
    REFERENCES `CarRental`.`Models` (`Id`)
    ON DELETE CASCADE)
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8mb4
COLLATE = utf8mb4_0900_ai_ci;


-- -----------------------------------------------------
-- Table `CarRental`.`Countries`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `CarRental`.`Countries` (
  `Id` INT NOT NULL AUTO_INCREMENT,
  `Name` VARCHAR(25) CHARACTER SET 'utf8mb4' COLLATE 'utf8mb4_0900_ai_ci' NOT NULL,
  `CountryCode` VARCHAR(15) CHARACTER SET 'utf8mb4' COLLATE 'utf8mb4_0900_ai_ci' NOT NULL,
  `IsoCode` VARCHAR(15) CHARACTER SET 'utf8mb4' COLLATE 'utf8mb4_0900_ai_ci' NOT NULL,
  PRIMARY KEY (`Id`))
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8mb4
COLLATE = utf8mb4_0900_ai_ci;


-- -----------------------------------------------------
-- Table `CarRental`.`Users`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `CarRental`.`Users` (
  `Id` INT NOT NULL AUTO_INCREMENT,
  `Email` VARCHAR(50) CHARACTER SET 'ascii' COLLATE 'ascii_general_ci' NOT NULL,
  `FirstName` VARCHAR(50) CHARACTER SET 'utf8mb4' COLLATE 'utf8mb4_0900_ai_ci' NOT NULL,
  `LastName` VARCHAR(50) CHARACTER SET 'utf8mb4' COLLATE 'utf8mb4_0900_ai_ci' NOT NULL,
  `ContactNumber` VARCHAR(15) CHARACTER SET 'utf8mb4' COLLATE 'utf8mb4_0900_ai_ci' NOT NULL,
  `CountryId` INT NOT NULL,
  `PasswordSalt` VARBINARY(500) NOT NULL,
  `PasswordHash` VARBINARY(500) NOT NULL,
  `Stasus` TINYINT(1) NOT NULL DEFAULT 1,
  PRIMARY KEY (`Id`, `CountryId`),
  INDEX `IX_Users_CountryId` (`CountryId` ASC),
  CONSTRAINT `FK_Users_Countries_CountryId`
    FOREIGN KEY (`CountryId`)
    REFERENCES `CarRental`.`Countries` (`Id`)
    ON DELETE CASCADE)
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8mb4
COLLATE = utf8mb4_0900_ai_ci;


-- -----------------------------------------------------
-- Table `CarRental`.`CreditCards`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `CarRental`.`CreditCards` (
  `Id` INT NOT NULL AUTO_INCREMENT,
  `CardNumber` VARBINARY(500) NOT NULL,
  `ExpirationDate` VARBINARY(500) NOT NULL,
  `CardHolderName` VARBINARY(500) NOT NULL,
  `UserId` INT NOT NULL,
  PRIMARY KEY (`Id`),
  INDEX `IX_CreditCards_UserId` (`UserId` ASC),
  CONSTRAINT `FK_CreditCards_Users_UserId`
    FOREIGN KEY (`UserId`)
    REFERENCES `CarRental`.`Users` (`Id`)
    ON DELETE CASCADE)
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8mb4
COLLATE = utf8mb4_0900_ai_ci;


-- -----------------------------------------------------
-- Table `CarRental`.`Currencies`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `CarRental`.`Currencies` (
  `Id` INT NOT NULL AUTO_INCREMENT,
  `Name` VARCHAR(25) CHARACTER SET 'utf8mb4' COLLATE 'utf8mb4_0900_ai_ci' NOT NULL,
  `IsoCode` VARCHAR(25) CHARACTER SET 'utf8mb4' COLLATE 'utf8mb4_0900_ai_ci' NOT NULL,
  PRIMARY KEY (`Id`))
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8mb4
COLLATE = utf8mb4_0900_ai_ci;


-- -----------------------------------------------------
-- Table `CarRental`.`FuelTypeModel`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `CarRental`.`FuelTypeModel` (
  `FuelTypesId` INT NOT NULL,
  `ModelsId` INT NOT NULL,
  PRIMARY KEY (`FuelTypesId`, `ModelsId`),
  INDEX `IX_FuelTypeModel_ModelsId` (`ModelsId` ASC),
  CONSTRAINT `FK_FuelTypeModel_FuelTypes_FuelTypesId`
    FOREIGN KEY (`FuelTypesId`)
    REFERENCES `CarRental`.`FuelTypes` (`Id`)
    ON DELETE CASCADE,
  CONSTRAINT `FK_FuelTypeModel_Models_ModelsId`
    FOREIGN KEY (`ModelsId`)
    REFERENCES `CarRental`.`Models` (`Id`)
    ON DELETE CASCADE)
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8mb4
COLLATE = utf8mb4_0900_ai_ci;


-- -----------------------------------------------------
-- Table `CarRental`.`OperationClaims`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `CarRental`.`OperationClaims` (
  `Id` INT NOT NULL AUTO_INCREMENT,
  `Name` VARCHAR(25) CHARACTER SET 'ascii' COLLATE 'ascii_general_ci' NOT NULL,
  PRIMARY KEY (`Id`))
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8mb4
COLLATE = utf8mb4_0900_ai_ci;


-- -----------------------------------------------------
-- Table `CarRental`.`OperationClaimUser`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `CarRental`.`OperationClaimUser` (
  `OperationClaimsId` INT NOT NULL,
  `UsersId` INT NOT NULL,
  PRIMARY KEY (`OperationClaimsId`, `UsersId`),
  INDEX `IX_OperationClaimUser_UsersId` (`UsersId` ASC),
  CONSTRAINT `FK_OperationClaimUser_OperationClaims_OperationClaimsId`
    FOREIGN KEY (`OperationClaimsId`)
    REFERENCES `CarRental`.`OperationClaims` (`Id`)
    ON DELETE CASCADE,
  CONSTRAINT `FK_OperationClaimUser_Users_UsersId`
    FOREIGN KEY (`UsersId`)
    REFERENCES `CarRental`.`Users` (`Id`)
    ON DELETE CASCADE)
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8mb4
COLLATE = utf8mb4_0900_ai_ci;


-- -----------------------------------------------------
-- Table `CarRental`.`Payments`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `CarRental`.`Payments` (
  `Id` INT NOT NULL AUTO_INCREMENT,
  `UserId` INT NOT NULL,
  `CreditCardId` INT NOT NULL,
  `CurrencyId` INT NOT NULL,
  `Amount` DECIMAL(18,2) NOT NULL,
  `PaymentDate` DATETIME(6) NOT NULL,
  PRIMARY KEY (`Id`, `CurrencyId`),
  INDEX `IX_Payments_CreditCardId` (`CreditCardId` ASC),
  INDEX `IX_Payments_CurrencyId` (`CurrencyId` ASC),
  INDEX `IX_Payments_UserId` (`UserId` ASC),
  CONSTRAINT `FK_Payments_CreditCards_CreditCardId`
    FOREIGN KEY (`CreditCardId`)
    REFERENCES `CarRental`.`CreditCards` (`Id`)
    ON DELETE CASCADE,
  CONSTRAINT `FK_Payments_Currencies_CurrencyId`
    FOREIGN KEY (`CurrencyId`)
    REFERENCES `CarRental`.`Currencies` (`Id`)
    ON DELETE CASCADE,
  CONSTRAINT `FK_Payments_Users_UserId`
    FOREIGN KEY (`UserId`)
    REFERENCES `CarRental`.`Users` (`Id`)
    ON DELETE CASCADE)
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8mb4
COLLATE = utf8mb4_0900_ai_ci;


-- -----------------------------------------------------
-- Table `CarRental`.`Suppliers`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `CarRental`.`Suppliers` (
  `Id` INT NOT NULL,
  `CompanyName` VARCHAR(50) CHARACTER SET 'utf8mb4' COLLATE 'utf8mb4_0900_ai_ci' NOT NULL,
  `Address` LONGTEXT CHARACTER SET 'utf8mb4' COLLATE 'utf8mb4_0900_ai_ci' NOT NULL,
  `Postcode` VARCHAR(15) CHARACTER SET 'utf8mb4' COLLATE 'utf8mb4_0900_ai_ci' NOT NULL,
  PRIMARY KEY (`Id`),
  CONSTRAINT `FK_Suppliers_Users_Id`
    FOREIGN KEY (`Id`)
    REFERENCES `CarRental`.`Users` (`Id`)
    ON DELETE CASCADE)
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8mb4
COLLATE = utf8mb4_0900_ai_ci;


-- -----------------------------------------------------
-- Table `CarRental`.`Rentals`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `CarRental`.`Rentals` (
  `Id` INT NOT NULL AUTO_INCREMENT,
  `CarId` INT NOT NULL,
  `UserId` INT NOT NULL,
  `SupplierId` INT NOT NULL,
  `PaymentId` INT NOT NULL,
  `MilageLimit` TINYINT(1) NOT NULL,
  `RentDate` DATETIME(6) NOT NULL,
  `ReturnDate` DATETIME(6) NOT NULL,
  `IsActive` TINYINT(1) NOT NULL,
  PRIMARY KEY (`Id`),
  UNIQUE INDEX `IX_Rentals_PaymentId` (`PaymentId` ASC),
  INDEX `IX_Rentals_CarId` (`CarId` ASC),
  INDEX `IX_Rentals_SupplierId` (`SupplierId` ASC),
  INDEX `IX_Rentals_UserId` (`UserId` ASC),
  CONSTRAINT `FK_Rentals_Cars_CarId`
    FOREIGN KEY (`CarId`)
    REFERENCES `CarRental`.`Cars` (`Id`)
    ON DELETE CASCADE,
  CONSTRAINT `FK_Rentals_Payments_PaymentId`
    FOREIGN KEY (`PaymentId`)
    REFERENCES `CarRental`.`Payments` (`Id`)
    ON DELETE CASCADE,
  CONSTRAINT `FK_Rentals_Suppliers_SupplierId`
    FOREIGN KEY (`SupplierId`)
    REFERENCES `CarRental`.`Suppliers` (`Id`)
    ON DELETE CASCADE,
  CONSTRAINT `FK_Rentals_Users_UserId`
    FOREIGN KEY (`UserId`)
    REFERENCES `CarRental`.`Users` (`Id`)
    ON DELETE CASCADE)
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8mb4
COLLATE = utf8mb4_0900_ai_ci;


SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;