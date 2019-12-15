CREATE SCHEMA IF NOT EXISTS `plant_service`;
USE `plant_service`;

CREATE TABLE IF NOT EXISTS `cities`
(
 `id`INT AUTO_INCREMENT,
 `name` VARCHAR(30) NOT NULL,
 `country_name` VARCHAR(80) NOT NULL,
 CONSTRAINT pk_cities PRIMARY KEY (`id`)
);

CREATE TABLE IF NOT EXISTS `users`
(
 `id`INT AUTO_INCREMENT,
 `username` VARCHAR(50) NOT NULL UNIQUE,
 `password` VARCHAR(255) NOT NULL,
 `first_name` VARCHAR(50) NOT NULL,
 `last_name` VARCHAR(50),
 `age` INT NOT NULL,
 `money` DECIMAL(15,2) NOT NULL,
 `city_id` INT NOT NULL,
 `register_date` DATE NOT NULL
 CHECK (`age` >= 18),
 CONSTRAINT pk_users PRIMARY KEY (`id`),
 CONSTRAINT fk_users_cities_id FOREIGN KEY (`city_id`) REFERENCES cities(`id`)
);

CREATE TABLE IF NOT EXISTS `orders`
(
 `id`INT AUTO_INCREMENT,
 `user_id` INT NOT NULL,
 `order_date` DATE NOT NULL,
 `is_completed` BOOLEAN DEFAULT FALSE,
 CONSTRAINT pk_orders PRIMARY KEY (`id`),
 CONSTRAINT fk_orders_users_id FOREIGN KEY (`user_id`) REFERENCES users(`id`)
);

CREATE TABLE IF NOT EXISTS `plants`
(
 `id`INT AUTO_INCREMENT,
 `name` VARCHAR(50) NOT NULL,
 `price` DECIMAL(15,2) NOT NULL,
 `color` VARCHAR(50),
 `quantity` INT DEFAULT 0,
 CONSTRAINT pk_plants PRIMARY KEY (`id`)
);

CREATE TABLE IF NOT EXISTS `info_plants`
(
 `id`INT AUTO_INCREMENT,
 `plant_id` INT NOT NULL,
 `family` VARCHAR(50) NOT NULL,
 `genus` VARCHAR(40) NOT NULL,
 `purpose` VARCHAR(60),
 CONSTRAINT pk_info_plants PRIMARY KEY (`id`),
 CONSTRAINT fk_info_plants_plants_id FOREIGN KEY (`plant_id`) REFERENCES plants(`id`)
);

CREATE TABLE IF NOT EXISTS `plants_orders`
(
 `plant_id`INT NOT NULL,
 `order_id` INT NOT NULL,
 CONSTRAINT fk_plants_orders_plants_id FOREIGN KEY (`plant_id`) REFERENCES plants(`id`),
 CONSTRAINT fk_plants_orders_orders_id FOREIGN KEY (`order_id`) REFERENCES orders(`id`),
 CONSTRAINT pk_plants_orders PRIMARY KEY (`plant_id`, `order_id`)
);

/*Problem 1.*/
SELECT p.`id`, p.`name`, p.`price`
FROM `plants` AS p
WHERE p.`quantity` >= 10 AND p.`price` >= 15
ORDER BY p.`price` DESC, p.`name` ASC
LIMIT 30;

/*Problem 2.*/
USE `plant_service`;
SELECT u.`id`, u.`username`, u.`first_name`, u.`age`, CONCAT(DAY(u.`register_date`),'-', MONTH(u.`register_date`)) AS 'register_day_month'
FROM `users` AS u
WHERE u.`age` < 60 AND u.`last_name` IS NULL
ORDER BY u.`age` ASC, u.`username` ASC;

/*Problem 3.*/
USE `plant_service`;
SELECT p.`id`, p.`name`, pi.`family`, pi.`genus`
FROM `plants` AS p
JOIN `info_plants` AS pi
ON pi.`plant_id` = p.`id`
WHERE p.`quantity` > 0 AND pi.`family` = 'Poaceae'
ORDER BY pi.`genus`, p.`name`;

/*Problem 4.*/
USE `plant_service`;
SELECT CONCAT(u.`first_name`, ' ', u.`last_name`) AS 'full_name', u.`username`, c.`name` AS 'city', YEAR(u.`register_date`) AS 'register_year'
FROM `users` AS u
JOIN `cities` AS c
ON c.`id` = u.`city_id`
WHERE u.`id` NOT IN (SELECT o.`user_id` FROM `orders` AS o) AND CONCAT(u.`first_name`, ' ', u.`last_name`) IS NOT NULL
ORDER BY `register_year` ASC, `full_name` ASC;

/*Problem 5.*/
SELECT u.`id`, u.`first_name` AS 'full_name', u.`age`, COUNT(*) AS 'received_orders'
FROM `orders` AS o
JOIN `users` AS u
ON u.`id` = o.`user_id`
WHERE o.`is_completed` = TRUE
GROUP BY u.`id`
ORDER BY `received_orders` DESC, u.`first_name`
LIMIT 10;

/*Problem 6.*/ 
SELECT c.`country_name`, SUM(p.`price`) AS 'total_sum', COUNT(*) AS 'count_orders'
FROM `orders` AS o
JOIN `plants_orders` AS po
ON po.`order_id` = o.`id`
JOIN `plants` AS p
ON p.`id` = po.`plant_id`
JOIN `users` AS u
ON u.`id` = o.`user_id`
JOIN `cities` AS c
ON c.`id` = u.`city_id`
GROUP BY c.`country_name`
ORDER BY `total_sum` DESC, `count_orders`;


/*Problem 7.*/
SELECT u.`id`, u.`first_name`, COUNT(*) AS 'orders'
FROM `users` AS u
JOIN `orders` AS o
ON u.`id`  = o.`user_id`
WHERE u.`id` IN (SELECT u.`id`
	FROM `orders` AS o
	JOIN `users` AS u
	ON u.`id` = o.`user_id`
	JOIN`plants_orders` AS po
	ON po.`order_id` = o.`id`
	JOIN `plants` AS p
	ON p.`id` = po.`plant_id`
	JOIN `info_plants` AS pi
	ON pi.`plant_id`  = p.`id`
	WHERE pi.`genus` = 'Begonia'
	ORDER BY po.`order_id`)
GROUP BY u.`id`
ORDER BY `orders` DESC, u.`first_name` ASC;


