using System;
using System.Collections.Generic;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace DeleteVillain
{
    class Program
    {
        static void Main(string[] args)
        {
            int villainIdInput = int.Parse(Console.ReadLine());

            //MySQL Connection
            string connectionString = "Server=localhost;database=minions;user=root;password=root";
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            using (connection)
            {
                //Find villain id
                string findVillainIdSQL = @"SELECT v.`id`
                                FROM `villains` AS v
                                WHERE v.`id` = @id";
                int? villainId;
                using (MySqlCommand command = new MySqlCommand(findVillainIdSQL, connection))
                {
                    command.Parameters.AddWithValue("@id", villainIdInput);
                    villainId = (int?)command.ExecuteScalar();
                }

                if (villainId == null)
                {
                    System.Console.WriteLine("No such villain was found.");
                    return;
                }
                int minionsCount;
                string villainName;

                using (var command = new MySqlCommand("SELECT COUNT(*) FROM `minions_villains` WHERE `villain_id` = @id", connection))
                {
                    command.Parameters.AddWithValue("@id", villainId);
                    minionsCount = int.Parse(command.ExecuteScalar().ToString());
                }

                using (var command = new MySqlCommand("DELETE FROM `minions_villains` WHERE `villain_id` = @id", connection))
                {
                    command.Parameters.AddWithValue("@id", villainId);
                    command.ExecuteNonQuery();
                }

                using (var command = new MySqlCommand("SELECT `name` FROM `villains` WHERE `id` = @id", connection))
                {
                    command.Parameters.AddWithValue("@id", villainId);
                    villainName = (string)command.ExecuteScalar();
                }

                using (var command = new MySqlCommand("DELETE FROM `villains` WHERE `id` = @id", connection))
                {
                    command.Parameters.AddWithValue("@id", villainId);
                    command.ExecuteNonQuery();
                }

                Console.WriteLine($"{villainName} was deleted.");
                Console.WriteLine($"{minionsCount} minions were released.");
            }
        }
    }
}

