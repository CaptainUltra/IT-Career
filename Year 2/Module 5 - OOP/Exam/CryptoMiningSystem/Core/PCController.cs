namespace CryptoMiningSystem.Core
{
    using CryptoMiningSystem.Entities;
    using CryptoMiningSystem.Entities.Components.Processors;
    using CryptoMiningSystem.Entities.Components.VideoCards;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class PCController
    {
        private Dictionary<string, User> users;
        private decimal totalProfits;
        public PCController()
        {
            this.Users = new Dictionary<string, User>();
            this.totalProfits = 0;
        }
        public string RegisterUser(List<string> args)
        {
            string name = args[0];
            decimal money = decimal.Parse(args[1]);
            if (this.Users.ContainsKey(name))
            {
                return $"Username: {name} already exists!";
            }
            this.users.Add(name, new User(name, money));
            return $"Successfully registered user - {name}!";
        }
        public string CreateComputer(List<string> args)
        {
            string userName = args[0];
            string processorType = args[1];
            string processorModel = args[2];
            int processorGeneration = int.Parse(args[3]);
            decimal processorPrice = decimal.Parse(args[4]);
            string videoCardType = args[5];
            string videoCardModel = args[6];
            int videoCardGerenation = int.Parse(args[7]);
            int videoCardRam = int.Parse(args[8]);
            decimal videoCardPrice = decimal.Parse(args[9]);
            int ram = int.Parse(args[10]);

            //Validate input
            if (!this.Users.ContainsKey(userName))
            {
                return $"Username: {userName} does not exist!";
            }
            if (processorType != "Low" && processorType != "High")
            {
                return "Invalid type processor!";
            }
            if (videoCardType != "Game" && videoCardType != "Mine")
            {
                return "Invalid type video card!";
            }
            var processor = this.CreateProcessor(processorType, processorModel, processorGeneration, processorPrice);
            var gpu = this.CreateVideoCartd(videoCardType, videoCardModel, videoCardGerenation, videoCardRam, videoCardPrice);
            Computer computer = new Computer(processor, gpu, ram);
            var neededMoney = processorPrice + videoCardPrice;
            if (this.users[userName].Money >=neededMoney)
            {
                this.users[userName].Computer = computer;
                this.users[userName].Money -= neededMoney;
                return $"Successfully created computer for user: {userName}!";
            }
            else return $"User: {userName} - insufficient funds!";
        }

        public string Mine()
        {
            decimal sum = 0;
            foreach (var user in this.users)
            {
                if (user.Value.Computer != null)
                {
                    if (user.Value.Computer.Processor.LifeWorkingHours > 0
                        && user.Value.Computer.VideoCard.LifeWorkingHours > 0)
                    {
                        decimal money = user.Value.Computer.MinedAmountPerHour * 24;
                        user.Value.Computer.Processor.LifeWorkingHours -= 1;
                        user.Value.Computer.VideoCard.LifeWorkingHours -= 1;
                        user.Value.Money += money;
                        sum += money;
                    }
                }
            }
            this.totalProfits += sum;
            return $"Daily profits: {sum}!";
        }
        public string UserInfo(List<string> args)
        {
            string name = args[0];
            string result = "";
            if (this.users.ContainsKey(name))
            {
                result = $"Name: {name} - Stars: {this.users[name].Stars}" + Environment.NewLine + $"Balance: {this.users[name].Money}";
                if (this.users[name].Computer != null)
                {
                    result += Environment.NewLine + $"PC Ram: {this.users[name].Computer.Ram}"
                            + Environment.NewLine + $" - {this.users[name].Computer.Processor.GetType().Name} - {this.users[name].Computer.Processor.Model} - {this.users[name].Computer.Processor.Generation}"
                            + Environment.NewLine + $" - {this.users[name].Computer.VideoCard.GetType().Name} - {this.users[name].Computer.VideoCard.Model} - {this.users[name].Computer.VideoCard.Generation}"
                            + Environment.NewLine + $"   *Video card Ram: {this.users[name].Computer.VideoCard.Ram}";
                }
            }
            else result = $"Username: {name} does not exist!";
            return result;
        }
        public string Shutdown()
        {
            var sortedUsers = this.users.OrderByDescending(x => x.Value.Stars).ThenBy(x => x.Key);
            StringBuilder result = new StringBuilder();
            foreach (var user in sortedUsers)
            {
                List<string> name = new List<string>();
                name.Add(user.Key);
                result.AppendLine(this.UserInfo(name));
            }
            result.Append($"System total profits: {this.totalProfits}!!!");
            return result.ToString();
        }
        private VideoCard CreateVideoCartd(string videoCardType, string videoCardModel, int videoCardGerenation, int videoCardRam, decimal videoCardPrice)
        {
            VideoCard videoCard = null;
            if (videoCardType == "Mine") videoCard = new MineVideoCard(videoCardModel, videoCardGerenation, videoCardRam, videoCardPrice);
            else videoCard = new GameVideoCard(videoCardModel, videoCardGerenation, videoCardRam, videoCardPrice);
            return videoCard;
        }

        private Processor CreateProcessor(string processorType, string processorModel, int processorGeneration, decimal processorPrice)
        {
            Processor processor = null;
            if (processorType == "Low") processor = new LowPerformanceProcessor(processorModel, processorGeneration, processorPrice);
            else processor = new HighPerformanceProcessor(processorModel, processorGeneration, processorPrice);
            return processor;
        }

        public Dictionary<string, User> Users { get => users; private set => users = value; }
    }
}

