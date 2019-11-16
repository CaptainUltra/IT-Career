/* Problem 1. Create new DB */
CREATE SCHEMA IF NOT EXISTS `minions`;

/* Problem 2. Create tables*/
USE `minions`;
CREATE TABLE IF NOT EXISTS `minions` 
(
  `id` INT NOT NULL AUTO_INCREMENT,
  `name` VARCHAR(50) NOT NULL,
  `age` INT(3) NULL,
  CONSTRAINT `pk_minions` PRIMARY KEY (`id`)
);
CREATE TABLE IF NOT EXISTS `towns`
(
 `id`INT NOT NULL AUTO_INCREMENT,
 `name` VARCHAR(50) NOT NULL,
 CONSTRAINT pk_towns PRIMARY KEY (`id`)
);

/* Problem 3. Alter minions table */
USE `minions`;
ALTER TABLE `minions`
ADD COLUMN `town_id` INT NOT NULL;
USE `minions`;
ALTER TABLE `minions`
ADD CONSTRAINT fk_minions_towns FOREIGN KEY (`town_id`) REFERENCES towns(`id`);

/* Problem 4. Insert recors in both tables */
USE `minions`;
INSERT INTO `towns`(`name`) VALUE ("Sofia");
INSERT INTO `towns`(`name`) VALUE ("Plovdiv");
INSERT INTO `towns`(`name`) VALUE ("Varna");

INSERT INTO `minions` (`name`, `age`, `town_id`) VALUES ('Kevin', 22, 1);
INSERT INTO `minions` (`name`, `age`, `town_id`) VALUES ('Bob', 15, 3);
INSERT INTO `minions` (`name`, `age`, `town_id`) VALUES ('Steward', NULL, 2);

/* Problem 5. Truncate table minions*/
USE `minions`;
TRUNCATE TABLE `minions`;

/* Problem 6. Drop all tables */
DROP TABLE `minions`;
DROP TABLE `towns`;

/* Problem 7. Create table people and insert 5 records */
CREATE TABLE IF NOT EXISTS `people`
(
`id` INT NOT NULL AUTO_INCREMENT,
`name` VARCHAR(200) NOT NULL,
`picture` BLOB,
`height` DOUBLE(10, 2),
`weight` DOUBLE(10, 2),
`gender` CHAR(1),
`birthdate` DATETIME NOT NULL,
`biography` VARCHAR(10000),
CONSTRAINT `pk_people` PRIMARY KEY (`id`)
);
INSERT INTO `people` (`name`, `picture`, `height`, `weight`, `gender`, `birthdate`, `biography`) VALUES ('Kevin', NULL, 1.82, 82.24, 'm', '2001-02-01', 'Some biography here');
INSERT INTO `people` (`name`, `picture`, `height`, `weight`, `gender`, `birthdate`, `biography`) VALUES ('Marie Poppinz', NULL, 1.60, 40.55, 'f', '2001-03-01', 'Some biography here');
INSERT INTO `people` (`name`, `picture`, `height`, `weight`, `gender`, `birthdate`, `biography`) VALUES ('Steward', NULL, 1.84, 95.00, 'm', '2001-04-01', 'Some biography here');
INSERT INTO `people` (`name`, `picture`, `height`, `weight`, `gender`, `birthdate`, `biography`) VALUES ('Bob Bob', NULL, 1.86, 101.99, 'm', '2001-11-06', 'Some biography here');
INSERT INTO `people` (`name`, `picture`, `height`, `weight`, `gender`, `birthdate`, `biography`) VALUES ('An Ann Annie', NULL, 1.72, 60.22, 'f', '2001-12-01', 'Some biography here');

