USE `soft_uni`;

/*Problem 1. Lowest paid employees */
SELECT `first_name`, `last_name`, `salary` 
FROM `employees`
WHERE `salary` = 
  (SELECT `salary` FROM `employees`
   ORDER BY `salary` LIMIT 1)
ORDER BY `department_id`;

/*Problem 2. Employees closest to the lowest paid */
SELECT `first_name`, `last_name`, `salary`
FROM `employees`
WHERE `salary` < 1.1 *
	(SELECT `salary` FROM `employees`
   ORDER BY `salary` LIMIT 1)
ORDER BY `salary`;

/*Problem 3. Find all managers */
SELECT `first_name`, `last_name`, `job_title`
FROM `employees`
WHERE `employee_id` IN (SELECT DISTINCT `manager_id` FROM `employees`)
ORDER BY `first_name`, `last_name`;

/*Problem 4. All employees from San Francisco */
SELECT `employee_id`, `first_name`, `last_name`
FROM `employees`
WHERE `address_id` IN 
	(	SELECT `address_id` 
		FROM `addresses` 
		WHERE `town_id` =
        ( SELECT `town_id` FROM `towns` WHERE `name` = 'San Francisco' LIMIT 1)
	)
ORDER BY `first_name`;
SELECT * FROM `towns`;