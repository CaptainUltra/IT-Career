using System;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace MinionsNames
{
    class Program
    {
        static void Main(string[] args)
        {
            //MySQL Connection
            string connectionString = "Server=localhost;database=minions;user=root;password=root";
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            int id = int.Parse(Console.ReadLine());

            string querySQL = @"SELECT v.`name`, m.`name`, m.`age`
                                FROM `villains` AS v
                                JOIN `minions_villains` AS mv
                                ON mv.`villain_id` = v.`id`
                                JOIN `minions` AS m
                                ON m.`id` = mv.`minion_id`
                                WHERE v.`id` = @id
                                ORDER BY m.`name` ASC;";

            using (connection)
            {
                using (MySqlCommand command = new MySqlCommand(querySQL, connection))
                {
                    command.Parameters.AddWithValue("@id", id);
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        if (!reader.HasRows)
                        {
                            System.Console.WriteLine("No villain with ID {0} exists in the database", id);
                        }
                        else
                        {
                            int count = 1;
                            while (reader.Read())
                            {
                                if (count == 1)
                                {
                                    System.Console.WriteLine($"Villain: {reader[0]}");
                                }
                                System.Console.WriteLine($"{count}. {reader[1]} {reader[2]}");
                                count++;
                            }
                        }
                    }
                }
            }
        }
    }
}
