USE `soft_uni`;

/*Problem 1. Employees and their managers*/
(SELECT `first_name`, `last_name`, "(no manager)" as 'manager_name'
FROM `employees` e where `manager_id` IS NULL)
  UNION
(SELECT `first_name`, `last_name`, 
        (SELECT CONCAT(`first_name`, " ", `last_name`) FROM `employees`
		  WHERE `employee_id` = e.`manager_id`)
FROM `employees` e WHERE `manager_id` IS NOT NULL) 
ORDER BY manager_name;

/*Problem 2. 3 highest paid managers and 3 highest paid employees */
(SELECT `first_name`, `last_name`, `job_title`, "manager" as 'position', `salary`
FROM `employees`
WHERE `employee_id` IN
	(SELECT DISTINCT `manager_id` FROM `employees`)
ORDER BY `salary` DESC LIMIT 3
)
UNION
(SELECT `first_name`, `last_name`, `job_title`, "employee" as 'position', `salary`
FROM `employees`
WHERE `employee_id` NOT IN
	(SELECT DISTINCT `manager_id` FROM `employees` WHERE `manager_id` IS NOT NULL)
ORDER BY `salary` DESC LIMIT 3
)
ORDER BY `salary` DESC, `first_name`, `last_name`;