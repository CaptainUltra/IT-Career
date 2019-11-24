USE `soft_uni`;

/*Problem 1. Highest salaries by job titles*/
SELECT e.`job_title`, e.`salary`
FROM `employees` AS e
WHERE `salary` = 
	(SELECT `salary` FROM `employees` AS es
    WHERE es.`job_title` = e.`job_title`
	ORDER BY `salary` DESC LIMIT 1)
ORDER BY e.`salary` DESC, e.`job_title` ASC;

/*Problem 2. Lowest salaries by departments */
SELECT DISTINCT e.`first_name`, e.`last_name`, e.`salary`,
	(SELECT d.`name` 
    FROM `departments` AS d 
	WHERE d.`department_id` = e.`department_id`) as `department`
FROM `employees` AS e
WHERE `salary` = 
	(SELECT `salary` FROM `employees` AS es
    WHERE es.`department_id` = e.`department_id`
	ORDER BY `salary` LIMIT 1)
ORDER BY e.`salary`, e.`first_name`, e.`salary`;

/*Problem 3. Managers with same middle name name as with their under*/
SELECT m.`first_name`, m.`last_name`
FROM `employees` AS m
WHERE m.`employee_id` IN 
	( SELECT DISTINCT `manager_id` FROM `employees`)
    AND EXISTS (SELECT `middle_name` FROM `employees` AS e
		WHERE e.`middle_name` = m.`middle_name`
		AND e.`manager_id` = m.`employee_id`
        LIMIT 1)
ORDER BY `first_name`;
    
/*Problem 4. Managers with their under havign higher salary*/
SELECT m.`first_name`, m.`last_name`
FROM `employees` AS m
WHERE m.`employee_id` IN 
	( SELECT DISTINCT `manager_id` FROM `employees`)
    AND EXISTS (SELECT `first_name` FROM `employees` AS e
		WHERE e.`salary` > m.`salary`
		AND e.`manager_id` = m.`employee_id`
        LIMIT 1);
        
/*Problem 5. Managers wiht only 5 under */
SELECT m.`first_name`, m.`last_name`
FROM `employees` AS m
WHERE m.`employee_id` IN 
	( SELECT DISTINCT `manager_id` FROM `employees`)
    AND EXISTS (SELECT 5 `first_name` FROM `employees` AS e
		WHERE e.`manager_id` = m.`employee_id`
        LIMIT 1);
        



