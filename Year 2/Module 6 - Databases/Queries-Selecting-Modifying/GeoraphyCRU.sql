USE `geography`;

/*Problem 19. Get all peaks */
SELECT `peak_name` FROM `peaks`
ORDER BY `peak_name`;

/*Problem 20. Find 30 countries with most population in Europe */
SELECT `country_name`, `population`
FROM `countries`
WHERE `continent_code` = 'EU'
ORDER BY `population` DESC, `country_name` ASC
LIMIT 30;

/*Problem 21. Euro/not euro countries*/
SELECT `country_name`, `country_code`,
  (CASE WHEN `currency_code`='EUR' THEN 'Euro' ELSE 'Not Euro' END) AS 'Currency'
FROM `countries`
ORDER BY `country_name`;