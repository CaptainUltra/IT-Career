using System;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace VillainsNames
{
    class Program
    {
        static void Main(string[] args)
        {
            //MySQL Connection
            string connectionString = "Server=localhost;database=minions;user=root;password=root";
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();
            string querySQL = @"SELECT v.`name`, COUNT(mv.`minion_id`) AS 'Count'
                                FROM `villains` AS v
                                LEFT JOIN `minions_villains` AS mv
                                ON mv.`villain_id` = v.`id`
                                GROUP BY v.`name`
                                HAVING `Count` >= 3
                                ORDER BY `Count` DESC;";

            using (connection)
            {
                using (MySqlCommand command = new MySqlCommand(querySQL, connection))
                {
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while(reader.Read())
                        {
                            Console.WriteLine(reader[0]+ " - " + reader[1]);
                        }
                    }
                }
            }
        }
    }
}
