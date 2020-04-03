using System;
using System.Linq;
using System.Collections.Generic;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace MinionsNameAndAge
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] selectedIds = Console.ReadLine().Split().Select(int.Parse).ToArray();

            //MySQL Connection
            string connectionString = "Server=localhost;database=minions;user=root;password=root";
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            //Lists to store the data before updating
            List<int> minionIds = new List<int>();
            List<string> minionaNames = new List<string>();
            List<int> minionAges = new List<int>();

            using (connection)
            {
                MySqlCommand command = new MySqlCommand($"SELECT * FROM `minions` WHERE `id` IN ({String.Join(", ", selectedIds)})", connection);
                MySqlDataReader reader = command.ExecuteReader();

                using (reader)
                {
                    if (!reader.HasRows)
                    {
                        return;
                    }

                    while (reader.Read())
                    {
                        minionIds.Add((int)reader[0]);
                        minionaNames.Add((string)reader[1]);
                        minionAges.Add((int)reader[2]);
                    }
                }

                for (int i = 0; i < minionIds.Count; i++)
                {
                    int minionId = minionIds[i];
                    string minionName = String.Join(" ", minionaNames[i].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList().Select(n => n = char.ToUpper(n.First()) + n.Substring(1).ToLower()).ToArray());
                    int minionAge = minionAges[i] + 1;

                    command = new MySqlCommand("UPDATE `minions` SET `name` = @name, `age` = @age WHERE `id` = @id", connection);
                    command.Parameters.AddWithValue("@name", minionName);
                    command.Parameters.AddWithValue("@age", minionAge);
                    command.Parameters.AddWithValue("@id", minionId);

                    command.ExecuteNonQuery();
                }

                //Retrieve info about all minions
                command = new MySqlCommand($"SELECT * FROM `minions`", connection);
                reader = command.ExecuteReader();

                using (reader)
                {
                    if (!reader.HasRows)
                    {
                        return;
                    }

                    while (reader.Read())
                    {
                        Console.WriteLine($"{(int)reader[0]} {(string)reader[1]} {(int)reader[2]}");
                    }
                }
            }
        }
    }
}
