USE `geography`;

/*Problem 6. Mountains in Bulgaria */
SELECT m.`mountain_range`, 
	(SELECT p.`peak_name` FROM `peaks` AS p
	WHERE p.`mountain_id` = m.`id`
    ORDER BY p.`elevation` DESC LIMIT 1
    ) `peak_name`,
    (SELECT e.`elevation` FROM `peaks` AS e
	WHERE e.`mountain_id` = m.`id`
    ORDER BY e.`elevation` DESC LIMIT 1
    ) `elevation`
FROM `mountains` AS m
WHERE m.`id` IN (SELECT `mountain_id` FROM `mountains_countries` WHERE `country_code` = 'BG')
ORDER BY `elevation` DESC;

/*Problem 7. Unidentified mountains in Bulgaria*/
SELECT m.`mountain_range`
FROM `mountains` AS m
WHERE m.`id` IN (SELECT `mountain_id` FROM `mountains_countries` WHERE `country_code` = 'BG')
AND NOT EXISTS(SELECT p.`peak_name` FROM `peaks` AS p
	WHERE p.`mountain_id` = m.`id`
    ORDER BY p.`elevation` DESC LIMIT 1
    )
AND NOT EXISTS(SELECT e.`elevation` FROM `peaks` AS e
	WHERE e.`mountain_id` = m.`id`
    ORDER BY e.`elevation` DESC LIMIT 1
    )
ORDER BY `mountain_range`;