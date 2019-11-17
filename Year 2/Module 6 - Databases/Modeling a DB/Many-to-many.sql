CREATE DATABASE IF NOT EXISTS `many-to-many`;
use `many-to-many`;

CREATE TABLE IF NOT EXISTS `students`
(
	`student_id` INT NOT NULL AUTO_INCREMENT,
    `name` VARCHAR(50),
    CONSTRAINT `pk_students` PRIMARY KEY (`student_id`)
);

CREATE TABLE IF NOT EXISTS `exams` (
    `exam_id` INT NOT NULL AUTO_INCREMENT,
    `name` VARCHAR(50) NOT NULL,
    CONSTRAINT `pk_exams` PRIMARY KEY (`exam_id`)
);

CREATE TABLE IF NOT EXISTS `students_exams`
(
`student_id` INT NOT NULL,
`exam_id` INT NOT NULL,
CONSTRAINT `pk_students_exams` PRIMARY KEY (`student_id`, `exam_id`),
CONSTRAINT `fk_students_exams_students` FOREIGN KEY (`student_id`)
        REFERENCES `students` (`student_id`),
CONSTRAINT `fk_students_exams_exams` FOREIGN KEY (`exam_id`)
        REFERENCES `exams` (`exam_id`)
);