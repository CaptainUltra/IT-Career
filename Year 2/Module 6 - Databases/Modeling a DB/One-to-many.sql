CREATE DATABASE IF NOT EXISTS `one-to-many`;
use `one-to-many`;

CREATE TABLE IF NOT EXISTS `manufacturers`
(
	`manufacturer_id` INT NOT NULL AUTO_INCREMENT,
    `name` VARCHAR(50) NOT NULL,
    `established_on` DATE,
    CONSTRAINT `pk_manufacturers` PRIMARY KEY (`manufacturer_id`)
);

CREATE TABLE IF NOT EXISTS `models` (
    `model_id` INT NOT NULL AUTO_INCREMENT,
    `name` VARCHAR(50) NOT NULL,
    `manufacturer_id` INT UNIQUE,
    CONSTRAINT `pk_models` PRIMARY KEY (`model_id`),
    CONSTRAINT `fk_models_manufacurers` FOREIGN KEY (`manufacturer_id`)
        REFERENCES `manufacturers` (`manufacturer_id`)
);