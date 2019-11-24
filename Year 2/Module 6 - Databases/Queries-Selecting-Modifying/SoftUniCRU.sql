USE `soft_uni`;

/*Problem 2. Find all information about all departments*/
SELECT * FROM `departments`;

/*Problem 3. Find all department names */
SELECT name FROM `departments`;

/*Problem 4. Find all salaries of all employees */
SELECT `first_name`, `last_name`, `salary` FROM `employees`;

/*Problem 5. Find full names of all employees */
SELECT `first_name`, `middle_name`, `last_name` FROM `employees`;

/*Problem 6. Find e-mail addresses of all employees */
SELECT CONCAT(`first_name`, '.', `last_name`, '@softuni.bg') AS "Full Email Address"
FROM `employees`;

/*Problem 7. Find all different salaries of all employees */ 
SELECT DISTINCT `salary` FROM `employees` ORDER BY `salary`;

/*Problem 8. Find all info about all Sales Representatives */
SELECT * FROM `employees`
WHERE `job_title` = 'Sales Representative';
/*Problem 9. Find all employees with salary between 20000 and 30000*/
SELECT `first_name`, `last_name`, `job_title`
FROM `employees`
WHERE `salary` BETWEEN 20000 AND 30000;

/*Problem 10. Find full name of emplyees with salaries 25000, 14000, 12500, 236000 */
SELECT concat(`first_name`, ' ', `middle_name`, ' ', `last_name`) AS 'Full name'
FROM `employees`
WHERE `salary` IN (25000, 14000, 12500, 23600);

/*Problem 11. Find all employees without manager */
SELECT `first_name`, `last_name`
FROM `employees`
WHERE `manager_id` IS NULL;

/*Problem 12. Find all employees with salary above 50000 */
SELECT `first_name`, `last_name`, `salary`
FROM `employees`
WHERE `salary` >= 50000
ORDER BY `salary` DESC;

/*Problem 13. Find top 5 most paid*/
SELECT `first_name`, `last_name`
FROM `employees`
ORDER BY `salary` DESC
LIMIT 5;

/*Problem 14. Find all employees that are not in marketing*/
SELECT `first_name`, `last_name`
FROM `employees`
WHERE `department_id` <> 4;

/*Problem 15. Find all the different job titles */
SELECT DISTINCT `job_title` 
FROM `employees`
ORDER BY `job_title`;

/*Problem 16. Find first 10 started projects */
SELECT * FROM `projects`
ORDER BY `start_date` ASC, `name` ASC;

/*Problem 17. Find latest 7 hires*/
SELECT `first_name`, `last_name`, `hire_date`
FROM `employees`
ORDER BY `hire_date` DESC;

/*Problem 18. Raise salaries in some departments */
UPDATE `employees`
SET `salary` = `salary` * 1.12
WHERE `department_id` IN (1, 2, 4, 11);

SELECT `salary` FROM `employees`;