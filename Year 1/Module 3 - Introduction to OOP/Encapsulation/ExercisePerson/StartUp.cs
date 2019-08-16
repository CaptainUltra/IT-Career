using System;

namespace ExercisePerson
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Team team = new Team(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
               var cmdArgs = Console.ReadLine().Split();
               var name = cmdArgs[0];
               var surname = cmdArgs[1];
               var age = int.Parse(cmdArgs[2]);
               var salary = decimal.Parse(cmdArgs[3]);
               Person player = new Person(name, surname, age, salary);
               team.AddPlayer(player);
            }
            System.Console.WriteLine("First team have {0} players", team.FirstTeam.Count);
            System.Console.WriteLine("Reserve team have {0} players", team.SecondTeam.Count);
        }
    }
}
