using System;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace InitialSetUp
{
    class Program
    {
        static void Main(string[] args)
        {
            //MySQL Connection
            string connectionString = "Server=localhost;database=minions;user=root;password=root";
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            string[] createTablesSql = { 
                //Countries table
                @"CREATE TABLE IF NOT EXISTS `countries`
                (
                `id` INT AUTO_INCREMENT NOT NULL,
                `name` VARCHAR(50),
                CONSTRAINT `pk_countries` PRIMARY KEY(`id`)
                );",
                //Towns table
                @"CREATE TABLE IF NOT EXISTS `towns`
                (
                `id` INT AUTO_INCREMENT NOT NULL,
                `name` VARCHAR(50),
                `country_code` INT,
                CONSTRAINT `pk_towns` PRIMARY KEY(`id`),
                CONSTRAINT `fk_towns_countries` FOREIGN KEY(`country_code`) REFERENCES `countries`(`id`)
                );",
                //Minions table
                @"CREATE TABLE IF NOT EXISTS `minions`
                (
                `id` INT AUTO_INCREMENT NOT NULL,
                `name` VARCHAR(50),
                `age` INT,
                `town_id` INT,
                CONSTRAINT `pk_minions` PRIMARY KEY(`id`),
                CONSTRAINT `fk_minions_towns` FOREIGN KEY(`town_id`) REFERENCES `towns`(`id`)
                );",
                //Evilness factors table
                @"CREATE TABLE IF NOT EXISTS `evilness_factors`
                (
                `id` INT AUTO_INCREMENT NOT NULL,
                `name` VARCHAR(50),
                CONSTRAINT `pk_evilness_factors` PRIMARY KEY(`id`)
                );",
                //Villains table
                @"CREATE TABLE IF NOT EXISTS `villains`
                (
                `id` INT AUTO_INCREMENT NOT NULL,
                `name` VARCHAR(50),
                `evilness_factor_id` INT,
                CONSTRAINT `pk_villains` PRIMARY KEY(`id`),
                CONSTRAINT `fk_villains_evilness_factors` FOREIGN KEY(`evilness_factor_id`) REFERENCES `evilness_factors`(`id`)
                );",
                //Minions villains table
                @"CREATE TABLE IF NOT EXISTS `minions_villains`
                (
                `minion_id` INT,
                `villain_id` INT,
                CONSTRAINT `pk_minions_villains` PRIMARY KEY(`minion_id`, `villain_id`),
                CONSTRAINT `fk_minions_villains_minions` FOREIGN KEY(`minion_id`) REFERENCES `minions`(`id`),
                CONSTRAINT `fk_minions_villains_villains` FOREIGN KEY(`villain_id`) REFERENCES `villains`(`id`)
                );",
            };
            using (connection)
            {
                foreach (var statement in createTablesSql)
                {
                    using (MySqlCommand command = new MySqlCommand(statement, connection))
                    {
                        command.ExecuteNonQuery();
                    }
                }
            }
        }
    }
}
