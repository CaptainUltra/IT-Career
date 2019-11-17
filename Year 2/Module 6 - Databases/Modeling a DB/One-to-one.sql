CREATE DATABASE IF NOT EXISTS `one-to-one`;
use `one-to-one`;

CREATE TABLE IF NOT EXISTS `passports`
(
	`passport_id` INT NOT NULL AUTO_INCREMENT,
    `passport_number` VARCHAR(10),
    CONSTRAINT `pk_passport` PRIMARY KEY (`passport_id`)
);

CREATE TABLE IF NOT EXISTS `persons` (
    `person_id` INT NOT NULL AUTO_INCREMENT,
    `first_name` VARCHAR(50) NOT NULL,
    `last_name` VARCHAR(50) NOT NULL,
    `salary` DOUBLE(10 , 2 ),
    `passport_id` INT UNIQUE,
    CONSTRAINT `pk_persons` PRIMARY KEY (`person_id`),
    CONSTRAINT `fk_persons_passports` FOREIGN KEY (`passport_id`)
        REFERENCES `passports` (`passport_id`)
);
