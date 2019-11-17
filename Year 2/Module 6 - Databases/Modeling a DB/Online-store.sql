CREATe DATABASE `online_store`;

USE `online_store`;

CREATE TABLE IF NOT EXISTS `cities`
(
`city_id` INT(11) PRIMARY KEY AUTO_INCREMENT,
`name` VARCHAR(50)
);
CREATE TABLE IF NOT EXISTS `customers`
(
`customer_id` INT(11) PRIMARY KEY AUTO_INCREMENT,
`name` VARCHAR(50),
`birthday` DATE,
`city_id` INT(11),
CONSTRAINT `fk_customers_cities` FOREIGN KEY (`city_id`) REFERENCES `cities`(`city_id`)
);
CREATE TABLE IF NOT EXISTS `orders`
(
`order_id` INT(11) PRIMARY KEY AUTO_INCREMENT,
`customer_id` INT(11),
CONSTRAINT `fk_orders_customers` FOREIGN KEY (`customer_id`) REFERENCES `customers`(`customer_id`)
);
CREATE TABLE IF NOT EXISTS `item_types`
(
`item_type_id` INT(11) PRIMARY KEY AUTO_INCREMENT,
`name` VARCHAR(50)
);
CREATE TABLE IF NOT EXISTS `items`
(
`item_id` INT(11) PRIMARY KEY AUTO_INCREMENT,
`name` VARCHAR(50),
`item_type_id` INT(11),
CONSTRAINT `fk_items_types` FOREIGN KEY (`item_type_id`) REFERENCES `item_types`(`item_type_id`)
);
CREATE TABLE IF NOT EXISTS `order_items`
(
`order_id` INT(11),
`item_id` INT(11),
CONSTRAINT `pk_order_items` PRIMARY KEY (`order_id`, `item_id`),
CONSTRAINT `fk_order_items_orders` FOREIGN KEY (`order_id`) REFERENCES `orders`(`order_id`),
CONSTRAINT `fk_order_items_items` FOREIGN KEY (`item_id`) REFERENCES `items`(`item_id`)
);
