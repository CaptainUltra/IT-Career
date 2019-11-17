CREATE DATABASE IF NOT EXISTS `self-relation`;
use `self-relation`;

CREATE TABLE IF NOT EXISTS `teachers` (
    `teacher_id` INT NOT NULL AUTO_INCREMENT,
    `name` VARCHAR(50) NOT NULL,
    `manager_id` INT,
    CONSTRAINT `pk_teachers` PRIMARY KEY (`teacher_id`),
    CONSTRAINT `fk_teachers_managers` FOREIGN KEY (`manager_id`)
        REFERENCES `teachers` (`teacher_id`)
);

ALTER TABLE `teachers`
AUTO_INCREMENT = 101;

INSERT INTO `teachers` (name, manager_id)
	VALUES  ('John', NULL),
			('Maya', NULL),
            ('Silvia', NULL),
            ('Ted', NULL),
            ('Mark', NULL),
            ('Greta', NULL);
            
UPDATE `teachers`
SET `manager_id` = 106
WHERE `teacher_id` IN (102, 103);

UPDATE `teachers`
SET `manager_id` = 105
WHERE `teacher_id` IN (104);

UPDATE `teachers`
SET `manager_id` = 101
WHERE `teacher_id` IN (105, 106);

SELECT * FROM `teachers`;
/* ... - --- -.-- .- -. */