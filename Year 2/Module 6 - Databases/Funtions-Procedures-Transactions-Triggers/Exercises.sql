USE `soft_uni`;

/*Problem 1.*/
DELIMITER $$
CREATE PROCEDURE usp_get_employees_salary_above_35000 ()
BEGIN
	SELECT e.`first_name`, e.`last_name`
    FROM `employees` AS e
    WHERE e.`salary` > 35000
    ORDER BY e.`first_name`, e.`last_name`;
END $$

/*Problem 2.*/
DELIMITER $$
CREATE PROCEDURE usp_get_employees_salary_above (salary_value DECIMAL)
BEGIN
	SELECT e.`first_name`, e.`last_name`
    FROM `employees` AS e
    WHERE e.`salary` >= salary_value
    ORDER BY e.`first_name`, e.`last_name`;
END $$

/*Problem 3.*/
DELIMITER $$
CREATE PROCEDURE usp_get_towns_starting_with (check_string VARCHAR(12))
BEGIN
	SELECT t.`name`
    FROM `towns` AS t
    WHERE t.`name` LIKE concat(check_string,'%')
    ORDER BY t.`name`;
END $$

/*Problem 4.*/
CREATE PROCEDURE usp_get_employees_from_town (town VARCHAR(12))
BEGIN
	SELECT e.`first_name`, e.`last_name`
    FROM `employees` AS e
    WHERE e.`address_id` = 
    (SELECT a.`address_id` FROM `addresses` AS a 
		WHERE a.`town_id` = 
		(SELECT t.`town_id` FROM `towns` AS t WHERE t.`name` = town ) LIMIT 1)
    ORDER BY e.`first_name`, e.`last_name`;
END $$

/*Problem 5.*/
CREATE FUNCTION udf_get_salary_level(salary DECIMAL(19,4))
RETURNS VARCHAR(10)
BEGIN
	DECLARE salary_level VARCHAR(10);
	IF (salary < 30000) THEN
		SET salary_level := 'Low';
	ELSEIF(salary <= 50000) THEN
		SET salary_level := 'Average';
	ELSE
		SET salary_level := 'High';
	END IF;
	RETURN salary_level;
END;

