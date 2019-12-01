USE `gringotts`;

/*Problem 1. Deposits of Ollivander family*/
SELECT w.`deposit_group`, SUM(w.`deposit_amount`) AS 'total_sum'
FROM `wizzard_deposits` AS w
WHERE w.`magic_wand_creator` = 'Ollivander family'
GROUP BY w.`deposit_group`
ORDER BY w.`deposit_group`;

/*Second solution of problem 1.*/
SELECT w.`deposit_group`, SUM(w.`deposit_amount`) AS 'total_sum'
FROM `wizzard_deposits` AS w
GROUP BY w.`deposit_group`, w.`magic_wand_creator`
HAVING w.`magic_wand_creator` = 'Ollivander family'
ORDER BY w.`deposit_group`;

/*Problem 2. Deposit filter */
SELECT w.`deposit_group`, SUM(w.`deposit_amount`) AS 'total_sum'
FROM `wizzard_deposits` AS w
GROUP BY w.`deposit_group`, w.`magic_wand_creator`
HAVING w.`magic_wand_creator` = 'Ollivander family' AND `total_sum` < 150000
ORDER BY `total_sum` DESC;
