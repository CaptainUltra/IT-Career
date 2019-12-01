USE `geography`;

/*Problem 1. Countries with rivers*/
SELECT c.`country_name`, r.`river_name`
FROM `continents` AS co
LEFT JOIN `countries` AS c
ON c.`continent_code` = co.`continent_code`
LEFT JOIN `countries_rivers` AS cr
ON cr.`country_code` = c.`country_code`
LEFT JOIN `rivers` AS r
ON r.`id` = cr.`river_id`
WHERE co.`continent_code` = 'AF'
ORDER BY c.`country_name` LIMIT 5;

/*Problem 2. Countries w/o mountains*/
SELECT c.`country_name`
FROM `countries` AS c
LEFT JOIN `mountains_countries` AS mc
ON c.`country_code` = mc.`country_code`
WHERE mc.`mountain_id` IS NULL;


/*Problem 3. Mountains in Bulgaria */
SELECT
    m.`mountain_range`,
    p.`peak_name`,
    p.`elevation`
FROM `peaks` AS p
RIGHT OUTER JOIN `mountains` AS m
ON m.`id` = p.`mountain_id`
RIGHT OUTER JOIN `mountains_countries` AS mc
ON mc.`mountain_id` = m.`id`
WHERE mc.`country_code` = 'BG'
	AND (p.`id` = ( SELECT `id` FROM `peaks` AS pk WHERE pk.`mountain_id` = m.`id` ORDER BY pk.`elevation` DESC LIMIT 1) OR p.`id` IS NULL)
ORDER BY p.`elevation` DESC;

