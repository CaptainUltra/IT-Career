using System;
using System.Linq;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace AddMinion
{
    class Program
    {
        static void Main(string[] args)
        {
            //Read parameters from console
            var minionArguments = Console.ReadLine().Split(' ').ToArray();
            string minionName = minionArguments[1];
            int minionAge = int.Parse(minionArguments[2]);
            string minionTown = minionArguments[3];
            var villainArguments = Console.ReadLine().Split(' ').ToArray();
            string villainName = villainArguments[1];

            //MySQL Connection
            string connectionString = "Server=localhost;database=minions;user=root;password=root";
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            using (connection)
            {
                //Find town id
                string findTownIdSQL = @"SELECT t.`id`
                                FROM `towns` AS t
                                WHERE t.`name` = @name";
                int townId;
                using (MySqlCommand command = new MySqlCommand(findTownIdSQL, connection))
                {
                    command.Parameters.AddWithValue("@name", minionTown);
                    int? result = (int?)command.ExecuteScalar();
                    //If town doesn't exist insert a new one
                    if (result == null)
                    {
                        string insertNewTownSQL = @"INSERT INTO `towns` (`name`, `country_code`)
                                                        VALUES 
                                                        (@name, 1);";
                        using (MySqlCommand insertCommand = new MySqlCommand(insertNewTownSQL, connection))
                        {
                            insertCommand.Parameters.AddWithValue("@name", minionTown);
                            insertCommand.ExecuteNonQuery();

                            //Retrieve id of the newly created town
                            using (MySqlCommand retrieveIdCommand = new MySqlCommand(findTownIdSQL, connection))
                            {
                                retrieveIdCommand.Parameters.AddWithValue("@name", minionTown);
                                int newId = (int)retrieveIdCommand.ExecuteScalar();
                                townId = newId;
                            }
                        }
                        System.Console.WriteLine($"Town {minionTown} was added to the database.");
                    }
                    else
                    {
                        townId = (int)result;
                    }
                }

                //Find villain id
                string findVillainIdSql = @"SELECT v.`id`
                                FROM `villains` AS v
                                WHERE v.`name` = @name";
                int villainId;
                using (MySqlCommand command = new MySqlCommand(findVillainIdSql, connection))
                {
                    command.Parameters.AddWithValue("@name", villainName);
                    int? result = (int?)command.ExecuteScalar();
                    //If villain doesn't exist insert a new one
                    if (result == null)
                    {
                        string insertNewVillainSQL = @"INSERT INTO `villains` (`name`, `evilness_factor_id`)
                                                        VALUES 
                                                        (@name, 1);"; //Default evillness factor
                        using (MySqlCommand insertCommand = new MySqlCommand(insertNewVillainSQL, connection))
                        {
                            insertCommand.Parameters.AddWithValue("@name", villainName);
                            insertCommand.ExecuteNonQuery();

                            //Retrieve id of the newly created villain
                            using (MySqlCommand retrieveIdCommand = new MySqlCommand(findVillainIdSql, connection))
                            {
                                retrieveIdCommand.Parameters.AddWithValue("@name", villainName);
                                int newId = (int)retrieveIdCommand.ExecuteScalar();
                                villainId = newId;
                            }
                        }
                        System.Console.WriteLine($"Villain {villainName} was added to the database.");
                    }
                    else
                    {
                        villainId = (int)result;
                    }
                }

                //Create new minion
                string addMinonSQL = @"INSERT INTO `minions` (`name`, `age`, `town_id`)
                                    VALUES
                                    (@name, @age, @townId);";
                int minionId;
                using (MySqlCommand command = new MySqlCommand(addMinonSQL, connection))
                {
                    command.Parameters.AddWithValue("@name", minionName);
                    command.Parameters.AddWithValue("@age", minionAge);
                    command.Parameters.AddWithValue("@townId", townId);
                    command.ExecuteNonQuery();
                    
                    //Retrieve id of the newly created minion
                    string findMinionIdSQL = @"SELECT m.`id`
                                FROM `minions` AS m
                                WHERE m.`name` = @name";
                    using (MySqlCommand retrieveIdCommand = new MySqlCommand(findMinionIdSQL, connection))
                    {
                        retrieveIdCommand.Parameters.AddWithValue("@name", minionName);
                        int newId = (int)retrieveIdCommand.ExecuteScalar();
                        minionId = newId;
                    }
                }

                //Add minion to villain
                string addMinonToVillainSQL = @"INSERT INTO `minions_villains` (`minion_id`, `villain_id`)
                                    VALUES
                                    (@minionId, @villainId);";
                using (MySqlCommand command = new MySqlCommand(addMinonToVillainSQL, connection))
                {
                    command.Parameters.AddWithValue("@minionId", minionId);
                    command.Parameters.AddWithValue("@villainId", villainId);
                    command.ExecuteNonQuery();
                }
                System.Console.WriteLine($"Successfully added {minionName} to be minion of {villainName}.");
            }
        }
    }
}
