use `soft_uni`;

/*Problem 1. Addess of employees*/
SELECT e.`employee_id`, e.`job_title`, e.`address_id`, a.`address_text`
FROM `employees` AS e
JOIN `addresses` AS a
ON e.`address_id` = a.`address_id`
ORDER BY e.`address_id`
LIMIT 5;

/*Problem 2. Employees from sales */
SELECT e.`employee_id`, e.`first_name`, e.`last_name`, d.`name` AS 'department_name'
FROM `employees` AS e
JOIN `departments` as d
ON e.`department_id` = d.`department_id`
WHERE d.`name` = 'Sales'
ORDER BY e.`employee_id` DESC;

/*Problem 3. Executive depatments */
SELECT e.`employee_id`, e.`first_name`, e.`salary`, d.`name` AS 'department_name'
FROM `employees` AS e
JOIN `departments` as d
ON e.`department_id` = d.`department_id`
WHERE e.`salary` > 15000
ORDER BY d.`department_id` DESC 
LIMIT 5;

/*Problem 4. Employees without a project */
SELECT e.`employee_id`, e.`first_name`
FROM `employees` AS e
LEFT JOIN `employees_projects` as ep
ON e.`employee_id` = ep.`employee_id` 
WHERE ep.`project_id` IS NULL
ORDER BY e.`employee_id` DESC
LIMIT 3;

/*Problem 5. Employees' managers */
SELECT e.`employee_id`, e.`first_name`, m.`employee_id` as 'manager_id', m.`first_name` as 'manager_name'
FROM `employees` AS e
INNER JOIN `employees` AS m ON m.`employee_id` = e.`manager_id`
WHERE e.`manager_id` IN (3,7)
ORDER BY e.`first_name`;

/*Problem 6. Min salary */
SELECT min_salary.`salary`, d.`name`
FROM
(
	SELECT e.`salary` AS salary, e.`department_id` FROM `employees` AS e
	ORDER BY e.`salary` LIMIT 1
) AS min_salary
JOIN `departments`AS d
ON d.`department_id` = min_salary.`department_id`

