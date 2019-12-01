USE `gringotts`;

/*Problem 1. Minimal deoposit */
SELECT w.`deposit_group`,w.`magic_wand_creator`, MIN(w.`deposit_charge`) AS 'min_deposit_charge'
FROM `wizzard_deposits` AS w
GROUP BY w.`deposit_group`, w.`magic_wand_creator`
ORDER BY w.`magic_wand_creator`, w.`deposit_group`;

/*Problem 2. Age groups */
SELECT CASE
		WHEN w.`age` BETWEEN 0 AND 10 THEN '[0-10]'
		WHEN w.`age` BETWEEN 11 AND 20 THEN '[11-20]'
		WHEN w.`age` BETWEEN 21 AND 30 THEN '[21-30]'
		WHEN w.`age` BETWEEN 31 AND 40 THEN '[31-40]'
		WHEN w.`age` BETWEEN 41 AND 50 THEN '[41-50]'
		WHEN w.`age` BETWEEN 51 AND 60 THEN '[51-60]'
		WHEN w.`age` >= 61 THEN '[61+]'
		END AS 'SizeGroup'
	,COUNT(*) as 'wizzard_count'
FROM `wizzard_deposits` AS w
GROUP BY `SizeGroup`
ORDER By `SizeGroup`;

/*Problem 3. First letter*/
SELECT SUBSTRING(w.`first_name`, 1,1) AS 'first_letter'
FROM `wizzard_deposits` AS w
WHERE `deposit_group` = 'Troll Chest'
GROUP BY first_letter
ORDER BY first_letter;

/*Problem 4. Average interest*/
SELECT w.`deposit_group`, w.`is_deposit_expired`, AVG(w.`deposit_interest`)
FROM `wizzard_deposits` AS w
WHERE DATE(w.`deposit_start_date`) > '01-01-1985'
GROUP BY w.`deposit_group`, w.`is_deposit_expired`
ORDER BY w.`deposit_group` DESC, `is_deposit_expired` ASC;
