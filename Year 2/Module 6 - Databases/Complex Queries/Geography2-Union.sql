USE `geography`;

/*Problem 3. Mountains in Bulgaria */
(SELECT `mountain_range`,  
       (SELECT `peak_name` FROM `peaks` WHERE `mountain_id` = m.`id` ORDER BY `elevation` DESC LIMIT 1) `peak_name`,
       (SELECT `elevation` FROM `peaks` WHERE `mountain_id` = m.`id` ORDER BY `elevation` DESC LIMIT 1) `elevation`
 FROM `mountains` AS m  
 WHERE `id` IN (SELECT `mountain_id` FROM `mountains_countries` WHERE `country_code` = 'BG')
   AND `id` IN (SELECT DISTINCT `mountain_id` FROM `peaks`))
UNION
(SELECT `mountain_range`, "no",  "info"
 FROM `mountains` AS m  
 WHERE `id` IN (SELECT `mountain_id` FROM `mountains_countries` WHERE `country_code` = 'BG')
   AND NOT EXISTS (SELECT 1 FROM `peaks` WHERE `mountain_id` = m.`id`))
ORDER BY `mountain_range`;

/*Problem 4. All geographical landmarks in Bulgaria */
(SELECT `mountain_range` as 'name', "mountain" as 'type',
	(SELECT `elevation` FROM `peaks` WHERE `mountain_id` = m.`id` ORDER BY `elevation` DESC LIMIT 1) 'info'
FROM `mountains` as m
WHERE `id` IN (SELECT `mountain_id` FROM `mountains_countries` WHERE `country_code` = 'BG')
)
UNION
(SELECT p.`peak_name` as 'name', "peak" as 'type', p.`elevation` as 'info'
FROM `peaks` as p
WHERE p.`mountain_id` IN (SELECT `mountain_id` FROM `mountains_countries` WHERE `country_code` = 'BG')
)
UNION
(SELECT r.`river_name` as 'name', "river" as 'type', r.`length` as 'info'
FROM `rivers` as r
WHERE r.`id` IN (SELECT river_id FROM countries_rivers WHERE country_code = 'BG')
)
ORDER BY name;
