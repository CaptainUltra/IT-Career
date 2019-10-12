namespace StorageMaster
{
    using System;
    using System.Collections.Generic;
    using global::StorageMaster.Models.Products;
    using global::StorageMaster.Models.Storages;

    public class StorageMaster
    {
        private List<Product> products;
        private Dictionary<string, Storage> storages;
        public StorageMaster()
        {
            this.products = new List<Product>();
            this.storages = new Dictionary<string, Storage>();
        }
        public string AddProduct(string type, double price)
        {
            Product product = CreateProduct(type, price);
            this.products.Add(product);
            string result = $"Added {type} to pool";
            return result;

        }
        public string RegisterStorage(string type, string name)
        {
            Storage storage = CreateStorage(type, name);
            this.storages.Add(name, storage);
            string result = $"Registered {name}";
            return result;
        }
        public string SelectVehicle(string storageName, int garageSlot)
        {
            throw new NotImplementedException();
        }
        public string LoadVehicle(IEnumerable<string> productNames)
        {
            throw new NotImplementedException();
        }
        public string SendVehicleTo(string sourceName, int sourceGarageSlot, string destinationName)
        {
            throw new NotImplementedException();
        }
        public string UnloadVehicle(string storageName, int garageSlot)
        {
            throw new NotImplementedException();
        }
        public string GetStorageStatus(string storageName)
        {
            throw new NotImplementedException();
        }
        public string GetSummary()
        {
            throw new NotImplementedException();
        }
        private Product CreateProduct(string type, double price)
        {
            Product product = null;
            switch (type)
            {
                case "Gpu":
                    {
                        product = new Gpu(price);
                        break;
                    }
                case "Ram":
                    {
                        product = new Ram(price);
                        break;
                    }
                case "HardDrive":
                    {
                        product = new HardDrive(price);
                        break;
                    }
                case "SolidStateDrive":
                    {
                        product = new SolidSateDrive(price);
                        break;
                    }
                default:
                    {
                        throw new InvalidOperationException("Invalid product type!");
                    }
            }
            return product;
        }
        private Storage CreateStorage(string type, string name)
        {
            Storage storage = null;
            switch (type)
            {
                case "AutomatedWarehouse":
                    {
                        storage = new AutomatedWarehouse(name);
                        break;
                    }
                case "DistributionCenter":
                    {
                        storage = new DistributionCenter(name);
                        break;
                    }
                case "Warehouse":
                    {
                        storage = new Warehouse(name);
                        break;
                    }
                default:
                    {
                        throw new InvalidOperationException("Invalid storage type!");
                    }
            }
            return storage;
        }
    }
}