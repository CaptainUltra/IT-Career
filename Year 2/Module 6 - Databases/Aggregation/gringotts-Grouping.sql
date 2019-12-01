USE `gringotts`;

/*Problem 1. Longest wand by deposit groups*/
SELECT w.`deposit_group`, MAX(w.`magic_wand_size`) AS 'longest_magic_wand'
FROM `wizzard_deposits` AS w
GROUP BY w.`deposit_group`
ORDER BY longest_magic_wand, w.`deposit_group`;

/*Problem 2. Deposit group with smallest average wand size*/
SELECT w.`deposit_group` 
FROM `wizzard_deposits` AS w
GROUP BY w.`deposit_group` 
ORDER BY AVG(w.`magic_wand_size`)
LIMIT 1;

/*Problem 3. Sum of deposits per group */
SELECT w.`deposit_group`, SUM(w.`deposit_amount`) AS 'total_sum'
FROM `wizzard_deposits` AS w
GROUP BY w.`deposit_group`
ORDER BY total_sum;