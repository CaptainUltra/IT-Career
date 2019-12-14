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
/*Problem 1. Inserting*/
INSERT INTO `travel_cards` (`card_number`, `job_during_journey`, `colonist_id`, `journey_id`)
SELECT
	(
		CASE
			WHEN c.`birth_date` > '1980-01-01'
				THEN CONCAT(YEAR(c.`birth_date`), DAY(c.`birth_date`), SUBSTRING(`ucn`, 1, 4))
			ELSE CONCAT(YEAR(c.`birth_date`), MONTH(c.`birth_date`), SUBSTRING(`ucn`, 7, 4))
            END
    ) AS `card_number`,
    (
		CASE
			WHEN c.`id` % 2 = 0
				THEN 'Pilot'
			WHEN c.`id` % 3 = 0
				THEN 'Cook'
			ELSE 'Engineer'
            END
    ) AS `job_during_journey`,
    c.`id`,
    SUBSTRING(c.`ucn`, 1,1) AS `journey_id`
FROM `colonists` AS c
WHERE c.`id` BETWEEN 96 AND 100;

/*Problem 2. Updating*/
UPDATE `journeys`
SET `purpose` = 
	(CASE
		WHEN `id` % 2 = 0
			THEN 'Medical'
		WHEN `id` % 3 = 0
			THEN 'Technical'
		WHEN `id` % 5 = 0
			THEN 'Educational'
		WHEN `id` % 7 = 0
			THEN 'Military'
		ELSE purpose
		END);
/*Problem 3. Deleting*/
DELETE FROM `colonists`
WHERE `id` NOT IN (SELECT `colonist_id` FROM `travel_cards`);

/*Task 3. Queries*/
/*Problem 1. Traveling cards*/
SELECT tc.`card_number`, tc.`job_during_journey`
FROM `travel_cards` AS tc
ORDER BY tc.`card_number` ASC;

/*Problem 2. Colonists*/
SELECT c.`id`, concat(c.`first_name`, ' ' , c.`last_name`) AS `full_name`, c.`ucn` 
FROM `colonists` AS c
ORDER BY c.`first_name`, c.`last_name`, c.`id`;

/*Problem 3. Journeys*/
SELECT j.`id`, j.`journey_start`, j.`journey_end`
FROM `journeys` AS j
WHERE j.`purpose` = 'Military'
ORDER BY j.`journey_start` ASC;

/*Problem 4.*/
SELECT c.`id`, concat(c.`first_name`, ' ' , c.`last_name`) AS `full_name`
FROM `colonists` AS c
WHERE c.`id` IN (SELECT tc.`colonist_id` FROM `travel_cards` AS tc WHERE tc.`job_during_journey` = 'Pilot');

/*Problem 5. Fastest spaceship*/
SELECT s.`name` AS 'spaceship_name', p.`name` AS 'spaceport_name'
FROM `spaceships` AS s
JOIN `journeys` AS j
ON j.`spaceship_id` = s.`id`
JOIN `spaceports` AS p
ON p.`id` = j.`destination_spaceport_id`
ORDER BY s.`light_speed_rate` DESC
LIMIT 1;

/*Problem 6.*/
SELECT pl.`name` AS 'planet_name', p.`name` AS 'spaceport_name'
FROM `journeys` AS j
JOIN `spaceports` AS p
ON p.`id` = j.`destination_spaceport_id`
JOIN `planets` AS pl
ON pl.`id` = p.`planet_id`
WHERE j.`purpose` = 'Educational'
ORDER BY `spaceport_name` DESC;

/*Problem 7.*/
/*SELECT pl.`name` AS 'planet_name', 
	(select count(*) FROM `journeys` AS j
    WHERE j.`destination_spaceport_id` 
    IN (SELECT p.`id` FROM `spaceports` AS p WHERE p.`planet_id` = pl.`id`)
    ) AS 'journeys_count'
FROM `planets` AS pl	
ORDER BY `journeys_count` DESC, `planet_name` ASC;*/
SELECT pl.`name` AS 'planet_name',  COUNT(*) AS 'journeys_count'
FROM `journeys` AS j
JOIN `spaceports` AS p
ON p.`id` = j.`destination_spaceport_id`
JOIN `planets` AS pl
ON pl.`id` = p.`planet_id`
GROUP BY pl.`id`
ORDER BY `journeys_count` DESC, `planet_name` ASC;

		




