USE `buhtig`;

/*Problem 1.*/
SELECT u.`id`, u.`username`
FROM `users` AS u
ORDER BY u.`id`;

/*Problem 2.*/
SELECT rc.`repository_id`, rc.`contributor_id`
FROM `repositories_contributors` AS rc
WHERE rc.`repository_id` = rc.`contributor_id`
ORDER BY rc.`repository_id`;

/*Problem 3.*/
SELECT i.`id`, concat(u.`username`, ' : ', i.`title`)
FROM `issues` AS i
JOIN `users` AS u
ON i.`assignee_id` = u.`id`
ORDER BY i.`id` DESC;

/*Problem 4.*/
SELECT f.`id`, f.`name`, concat(f.`size`, 'KB') AS 'size'
FROM `files` AS f
WHERE f.`id` NOT IN (SELECT DISTINCT ff.`parent_id` FROM `files` AS ff WHERE ff.`parent_id` IS NOT NULL)
ORDER BY f.`id` ASC;

/*Problem 5.*/
SELECT r.`id`, r.`name`, 
	(SELECT count(*) `id` 
		FROM `issues` AS i WHERE r.`id` = i.`repository_id` ) AS 'Issues'
FROM `repositories` AS r
ORDER BY issues DESC, r.`id` ASC
LIMIT 5;

/*Problem 6.*/
SELECT r.`id`, r.`name`,
	(SELECT count(*) `id` 
		FROM `commits` AS c WHERE r.`id` = c.`repository_id` ) AS 'commits',
	(SELECT count(*) `id` 
		FROM `users` AS u WHERE u.`id` IN 
        (SELECT rc.`contributor_id` FROM `repositories_contributors` AS rc
        WHERE rc.`repository_id` = r.`id` 
        )
        ) AS 'contributors'
FROM `repositories` AS r
ORDER BY contributors DESC, r.`id` LIMIT 1;

/*Problem 7.*/
SELECT r.`id`, r.`name`,
	COUNT(DISTINCT c.`contributor_id`) AS 'users'
FROM `repositories` AS r
LEFT JOIN `commits` AS c
ON r.`id` = c.`repository_id`
GROUP BY r.`id`
ORDER BY `users` DESC, r.`id`;
	

