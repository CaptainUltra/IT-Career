CREATE SCHEMA IF NOT EXISTS colonial_journey_management_system_db;
USE `colonial_journey_management_system_db`;

CREATE TABLE IF NOT EXISTS `planets`
(
 `id`INT AUTO_INCREMENT,
 `name` VARCHAR(30) NOT NULL,
 CONSTRAINT pk_planets PRIMARY KEY (`id`)
);

CREATE TABLE IF NOT EXISTS `spaceports`
(
 `id`INT AUTO_INCREMENT,
 `name` VARCHAR(50) NOT NULL,
 `planet_id` INT,
 CONSTRAINT pk_spaceports PRIMARY KEY (`id`),
 CONSTRAINT fk_spaceports_planets_id FOREIGN KEY (`planet_id`) REFERENCES planets(`id`)
);
CREATE TABLE IF NOT EXISTS `spaceships`
(
 `id`INT AUTO_INCREMENT,
 `name` VARCHAR(50) NOT NULL,
 `manufacturer` VARCHAR(30) NOT NULL,
 `light_speed_rate` INT DEFAULT 0,
 CONSTRAINT pk_spaceships PRIMARY KEY (`id`)
);

CREATE TABLE IF NOT EXISTS `colonists`
(
 `id`INT AUTO_INCREMENT,
 `first_name` VARCHAR(20) NOT NULL,
 `last_name` VARCHAR(30) NOT NULL,
 `ucn` CHAR(10) UNIQUE NOT NULL,
 `birth_date` DATE NOT NULL,
 CONSTRAINT pk_colonists PRIMARY KEY (`id`)
);

CREATE TABLE IF NOT EXISTS `journeys`
(
 `id`INT AUTO_INCREMENT,
 `journey_start` DATETIME NOT NULL,
 `journey_end` DATETIME NOT NULL,
 `purpose` ENUM ('Medical', 'Technical', 'Educational', 'Military'),
 `destination_spaceport_id` INT,
 `spaceship_id` INT,
 CONSTRAINT pk_journeys PRIMARY KEY (`id`),
 CONSTRAINT fk_journeys_spaceports_id FOREIGN KEY (`destination_spaceport_id`) REFERENCES spaceports(`id`),
 CONSTRAINT fk_journeys_spaceships_id FOREIGN KEY (`spaceship_id`) REFERENCES spaceships(`id`)
);

CREATE TABLE IF NOT EXISTS `travel_cards`
(
 `id`INT AUTO_INCREMENT,
 `card_number` CHAR(10) NOT NULL UNIQUE,
 `job_during_journey` ENUM ('Pilot', 'Engineer', 'Trooper', 'Cleaner', 'Cook'),
 `colonist_id` INT,
 `journey_id` INT,
 CONSTRAINT pk_travel_cards PRIMARY KEY (`id`),
 CONSTRAINT fk_travel_cards_colonists_id FOREIGN KEY (`colonist_id`) REFERENCES colonists(`id`),
 CONSTRAINT fk_travel_cards_journeys_id FOREIGN KEY (`journey_id`) REFERENCES journeys(`id`)
);

/*Task 2. DML*/
/*Problem 1.*/
INSERT INTO `travel_cards` ()





