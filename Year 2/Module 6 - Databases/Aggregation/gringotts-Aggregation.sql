USE `gringotts`;

/*Problem 1. Count of wizzard deposits */
SELECT count(*) `id` FROM `wizzard_deposits`;

/*Problem 2. Longest magic wand */
SELECT max(w.`magic_wand_size`) AS 'longest_magic_wand'
FROM `wizzard_deposits` AS w;