namespace StorageMaster.Core
{
    using System;
    using System.Linq;
    using System.Text;
    public class Engine
    {
        private StorageMaster storageMaster;
        private bool isRunning;
        private StringBuilder outputs;
        public Engine()
        {
            this.storageMaster = new StorageMaster();
            this.outputs = new StringBuilder();
        }
        public void Run()
        {
            this.isRunning = true;
            while (this.isRunning)
            {
                try
                {
                    string line = Console.ReadLine();
                    string result = this.ProcessCommand(line);
                    outputs.AppendLine(result);
                }
                catch (InvalidOperationException e)
                {
                    outputs.AppendLine($"Error: {e.Message}");
                }

            }
            Console.Clear();
            System.Console.WriteLine(outputs.ToString().Trim());
        }

        private string ProcessCommand(string line)
        {
            string[] tokens = line.Split();
            string command = tokens[0];
            string output = "";
            switch (command)
            {
                case "AddProduct":
                    {
                        string productType = tokens[1];
                        double price = double.Parse(tokens[2]);
                        output = this.storageMaster.AddProduct(productType, price);
                        break;
                    }
                case "RegisterStorage":
                    {
                        string storageType = tokens[1];
                        string name = tokens[2];
                        output = this.storageMaster.RegisterStorage(storageType, name);
                        break;
                    }
                case "SelectVehicle":
                    {
                        string storageName = tokens[1];
                        int garageSlot = int.Parse(tokens[2]);
                        output = this.storageMaster.SelectVehicle(storageName, garageSlot);
                        break;
                    }
                case "LoadVehicle":
                    {
                        string[] productNames = tokens.Skip(1).ToArray();
                        output = this.storageMaster.LoadVehicle(productNames);
                        break;
                    }
                case "SendVehicleTo":
                    {
                        string sourceName = tokens[1];
                        int garageSlot = int.Parse(tokens[2]);
                        string destinationName = tokens[3];
                        output = this.storageMaster.SendVehicleTo(sourceName, garageSlot, destinationName);
                        break;
                    }
                case "UnloadVehicle":
                    {
                        string storageName = tokens[1];
                        int garageSlot = int.Parse(tokens[2]);
                        output = this.storageMaster.UnloadVehicle(storageName, garageSlot);
                        break;
                    }
                case "GetStorageStatus":
                    {
                        string storageName = tokens[1];
                        output = this.storageMaster.GetStorageStatus(storageName);
                        break;
                    }
                case "END":
                    {
                        this.isRunning = false;
                        output = this.storageMaster.GetSummary();
                        break;
                    }

            }
            return output;
        }
    }
}