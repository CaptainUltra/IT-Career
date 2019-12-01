USE `soft_uni`;

/*Problem 2. Sales and Finances hires after 1-1-1999*/
SELECT e.`first_name`, e.`last_name`, DATE(e.`hire_date`), d.`name` as 'department_name'
FROM `employees` AS e
JOIN `departments` AS d
ON e.`department_id` = d.`department_id`
WHERE d.`name` IN ('Sales', 'Finance')
AND DATE(e.`hire_date`) > '1-1-1999'
ORDER BY e.`hire_date`;

/*Problem 3. Employees with project*/
SELECT e.`employee_id`, e.`first_name`, p.`name`
FROM `employees` AS e
JOIN `employees_projects` as ep
ON e.`employee_id` = ep.`employee_id`
JOIN `projects` AS p
ON ep.`project_id` = p.`project_id`
WHERE DATE(p.`start_date`) > '13-8-2002' AND p.`end_date` IS NULL
ORDER BY e.`first_name`, p.`name`
LIMIT 5;

/*Problem 4. Employee reume */
SELECT 
    e.`employee_id`,
    CONCAT(e.`first_name`, ' ', e.`last_name`) AS 'employee_name',
    CONCAT(m.`first_name`, ' ', m.`last_name`) AS 'manager_name',
    d.`name` AS 'department_name'
FROM `employees` AS e
INNER JOIN `employees` AS m 
ON m.`employee_id` = e.`manager_id`
JOIN `departments` AS d 
ON e.`department_id` = d.`department_id`
WHERE e.`manager_id` IS NOT NULL
ORDER BY e.`employee_id`
LIMIT 5;

/*Problem 5. Highest peaks in Bulgaria*/
USE `geography`;

SELECT 
    c.`country_code`,
    m.`mountain_range`,
    p.`peak_name`,
    p.`elevation`
FROM `countries` AS c
INNER JOIN `mountains_countries` AS mc 
ON c.`country_code` = mc.`country_code`
INNER JOIN `mountains` AS m 
ON m.`id` = mc.`mountain_id`
INNER JOIN `peaks` AS p 
ON p.`mountain_id` = m.`id`
WHERE c.`country_code` = 'BG'
AND p.`elevation`> 2835
ORDER BY p.`elevation` DESC;

/*Problem 7. Mountain ranges */
SELECT c.`country_code`, c.`country_name`, m.`mountain_range`
FROM `countries` AS c
JOIN `mountains_countries` AS mc
ON mc.`country_code` = c.`country_code`
JOIN `mountains` as m
ON m.`id`= mc.`mountain_id`
WHERE c.`country_code` IN ('BG', 'RU', 'US')
ORDER BY c.`country_code`, m.`mountain_range`;

