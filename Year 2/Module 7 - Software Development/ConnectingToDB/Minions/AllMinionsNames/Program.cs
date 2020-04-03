using System;
using System.Collections.Generic;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace AllMinionsNames
{
    class Program
    {
        static void Main(string[] args)
        {
            //MySQL Connection
            string connectionString = "Server=localhost;database=minions;user=root;password=root";
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            List<string> minionsList = new List<string>();
            List<string> minionsNames = new List<string>();

            using (connection)
            {
                MySqlCommand command = new MySqlCommand("SELECT `name` FROM `minions`", connection);

                MySqlDataReader reader = command.ExecuteReader();

                using (reader)
                {
                    while (reader.Read())
                    {
                        minionsList.Add((string)reader[0]);
                    }
                }
            }

            while (minionsList.Count > 0)
            {
                minionsNames.Add(minionsList[0]);
                minionsList.RemoveAt(0);

                if (minionsList.Count > 0)
                {
                    minionsNames.Add(minionsList[minionsList.Count - 1]);
                    minionsList.RemoveAt(minionsList.Count - 1);
                }
            }

            foreach (var name in minionsNames)
            {
                System.Console.WriteLine(name);
            }
        }
    }
}
