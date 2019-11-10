namespace HeroFight.Core
{
    using System;
    using System.Linq;

    public class Engine
    {
        private readonly ArenaController arenaController;
        public Engine()
        {
            this.arenaController = new ArenaController();
        }
        public void Run()
		{
			while (true)
			{
				var command = Console.ReadLine();
				if (command == "CloseArena")
				{
					break;
				}

				try
				{
					var commandResult = this.ProcessCommand(command);
					Console.WriteLine(commandResult);
				}
				catch (InvalidOperationException e)
				{
					Console.WriteLine("Error: " + e.Message);
				}
			}

			var closeArena = this.arenaController.CloseArena();
			Console.WriteLine(closeArena);
		}

		private string ProcessCommand(string command)
		{
			var commandArgs = command.Split(':');
			var commandName = commandArgs[0];
			var args = commandArgs.Skip(1).ToList();

			var output = string.Empty;
			switch (commandName)
			{
				case "CreateHero":
                {
                    output = this.arenaController.CreateHero(args);
                    break;
                }
                case "CreateWeapon":
                {
                    output = this.arenaController.CreateWeapon(args);
                    break;
                }
                case "Fight":
                {
                    output = this.arenaController.Fight(args);
                    break;
                }
                case "HeroInfo":
                {
                    output = this.arenaController.HeroInfo(args);
                    break;
                }
			}

			return output;
		}
    }
}