CREATE DATABASE IF NOT EXISTS `university`;
USE `university`;

CREATE TABLE IF NOT EXISTS `majors`
(
`major_id` INT(11)AUTO_INCREMENT NOT NULL,
`name` VARCHAR(50),
CONSTRAINT `pk_majors` PRIMARY KEY (`major_id`)
);
CREATE TABLE IF NOT EXISTS `students`
(
`student_id` INT(11)AUTO_INCREMENT NOT NULL,
`student_number` VARCHAR(1),
`student_name` VARCHAR(50),
`major_id` INT(11),
CONSTRAINT `pk_students` PRIMARY KEY (`student_id`),
CONSTRAINT `fk_students_majors` FOREIGN KEY (`major_id`) REFERENCES `majors`(`major_id`)
);
CREATE TABLE IF NOT EXISTS `payments`
(
`payment_id` INT(11) AUTO_INCREMENT NOT NULL,
`payment_date` DATE,
`payment_ammount` DECIMAL(8,2),
`student_id` INT(11),
CONSTRAINT `pk_payments` PRIMARY KEY (`payment_id`),
CONSTRAINT `fk_payments_students` FOREIGN KEY (`student_id`) REFERENCES `students`(`student_id`)
);
CREATE TABLE IF NOT EXISTS `subjects`
(
`subject_id` INT(11)AUTO_INCREMENT NOT NULL,
`subject_name` VARCHAR(50),
CONSTRAINT `pk_subjects` PRIMARY KEY (`subject_id`)
);
CREATE TABLE IF NOT EXISTS `agenda`
(
`subject_id` INT(11) NOT NULL,
`student_id` INT(11) NOT NULL,
CONSTRAINT `pk_agenda` PRIMARY KEY (`subject_id`,`student_id`),
CONSTRAINT `fk_agenda_subjects` FOREIGN KEY (`subject_id`) REFERENCES `subjects`(`subject_id`),
CONSTRAINT `fk_agenda_students` FOREIGN KEY (`student_id`) REFERENCES `students`(`student_id`)
);

