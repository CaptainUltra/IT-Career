USE `soft_uni`;

/* Problem 1. Projects of employee with id = 24*/
SELECT e.`employee_id`, e.`first_name`,
	(CASE
		WHEN DATE(p.`start_date`) >= '2005-01-01' THEN 'NULL'
		ELSE p.`name` END) as 'project_name'
FROM `employees` AS e
JOIN `employees_projects` as ep
ON ep.`employee_id` = e.`employee_id`
JOIN `projects` AS p
ON p.`project_id` = ep.`project_id`
WHERE e.`employee_id` = 24
ORDER BY p.`name`;

/*Problem 2. Continents*/
USE `geography`;

SELECT c.`continent_name` AS 'FROM', cc.`continent_name` AS 'TO'
FROM `continents` AS c
CROSS JOIN `continents` AS cc
ORDER BY c.`continent_name`, cc.`continent_name`;

/*Problem 3. Football */
SELECT c1.`capital` AS 'Place', c1.`country_name` AS 'Player 1', ' ' AS 'Host', ' ' AS 'Guest', c2.`country_name` AS 'Player 2'
FROM `countries` AS c1
CROSS JOIN `countries` AS c2
WHERE c1.`continent_code` = 'EU' AND c2.`continent_code` = 'EU'
	AND c1.`country_code` != c2.`country_code`
ORDER BY RAND();

/*Problem 4.*/
SELECT c.`country_name`, p.`elevation`, r.`length`
FROM `countries` AS c
INNER JOIN `countries_rivers` AS cr
ON cr.`country_code` = c.`country_code`
INNER JOIN `rivers` AS r
ON r.`id` = cr.`river_id` 
INNER JOIN `mountains_countries` AS mc
ON mc.`country_code` = c.`country_code`
INNER JOIN `mountains` AS m
ON m.`id` = mc.`mountain_id`
INNER JOIN `peaks` AS p
ON p.`mountain_id` = m.`id`
WHERE 
	(p.`id` = (SELECT pk.`id` 
				FROM `peaks` AS pk 
				WHERE pk.`mountain_id` = m.`id` 
                ORDER BY pk.`elevation` DESC LIMIT 1)
		OR p.`id` IS NULL)
	AND ( r.`id` = (SELECT rr.`id` 
				FROM `rivers` AS rr 
				WHERE rr.`id`IN (SELECT rp.`river_id` FROM `countries_rivers` AS rp WHERE rp.`country_code` = c.`country_code`) 
                ORDER BY rr.`length` DESC LIMIT 1) OR r.`id` IS NULL)
ORDER BY p.`elevation` DESC, r.`length` DESC, c.`country_name`


