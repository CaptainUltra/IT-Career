using System;
using System.Collections.Generic;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace CapitalizeTownNames
{
    class Program
    {
        static void Main(string[] args)
        {
            string countryName = Console.ReadLine();

            //MySQL Connection
            string connectionString = "Server=localhost;database=minions;user=root;password=root";
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            using (connection)
            {
                //Find country id
                string findCountryIdSQL = @"SELECT c.`id`
                                FROM `countries` AS c
                                WHERE c.`name` = @name";
                int? countryId;
                var towns = new Dictionary<int, string>();
                using (MySqlCommand command = new MySqlCommand(findCountryIdSQL, connection))
                {
                    command.Parameters.AddWithValue("@name", countryName);
                    countryId = (int?)command.ExecuteScalar();
                }

                if (countryId != null)
                {
                    string getTownsSQL = @"SELECT t.`id`, t.`name`
                                FROM `towns` AS t
                                WHERE t.`country_code` = @id";
                    using (MySqlCommand command = new MySqlCommand(getTownsSQL, connection))
                    {
                        command.Parameters.AddWithValue("@id", countryId);
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            if (!reader.HasRows)
                            {
                                System.Console.WriteLine("No town names were affected.");
                                return;
                            }
                            else
                            {
                                while (reader.Read())
                                {
                                    int townId = (int)reader[0];
                                    string townName = (string)reader[1];
                                    var newTownName = townName.ToUpper();
                                    towns.Add(townId, newTownName);
                                }
                            }
                        }
                    }
                }
                else
                {
                    System.Console.WriteLine("No town names were affected.");
                    return;
                }

                //Update records and print
                string setTownNameSQL = @"UPDATE `towns`
                                            SET `name` = @name
                                            WHERE `id` = @id;";
                foreach (var town in towns)
                {
                    var updateNameCommand = new MySqlCommand(setTownNameSQL, connection);
                    updateNameCommand.Parameters.AddWithValue("@name", town.Value);
                    updateNameCommand.Parameters.AddWithValue("@id", town.Key);
                    updateNameCommand.ExecuteNonQuery();
                }
                System.Console.WriteLine($"{towns.Count} town names were affected.");
                System.Console.WriteLine("[" + String.Join(", ", towns.Values) + "]");
            }
        }
    }
}

