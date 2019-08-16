namespace ChefsKingdom
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Text;
    public class Chef
    {
        private string name;
        private string department;
        private List<Dish> dishes;
        private bool isOnABreak;
        public Chef(string name, string department)
        {
            this.Name = name;
            this.Department = department;
            this.Dishes = new List<Dish>();
            this.IsOnABreak = false;
        }
        public void AddDish(Dish dish)
        {
            this.Dishes.Add(dish);
        }
        public bool RemoveDish(Dish dish)
        {
            if (this.Dishes.Contains(dish))
            {
                this.Dishes.Remove(dish);
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool RemoveAllByFoodGroup(string foodGroup)
        {
            bool flag = false;
            foreach (var dish in this.Dishes.Where(x => x.FoodGroup == foodGroup).ToList())
            {
                this.Dishes.Remove(dish);
                flag = true;
            }
            return flag;
        }
        public int CountExpensiveDishesOfFoodGroup(string foodGroup, double priceLevel)
        {
            int count = 0;
            foreach (var dish in this.dishes.Where(x => x.FoodGroup == foodGroup && x.Price >= priceLevel).ToList())
            {
                count++;
            }
            return count;
        }
        public void StartCooking()
        {
            this.IsOnABreak = false;
        }
        public Dish DeliverDish(string dishName)
        {
            if (this.Dishes.Contains(this.dishes.Where(x => x.Name == dishName).FirstOrDefault()) && this.IsOnABreak == false)
            {
                return this.Dishes.Where(x => x.Name == dishName).FirstOrDefault();
            }
            else return null;

        }
        public void GiveChefABreak()
        {
            this.IsOnABreak = true;
        }
        public bool IsChefAvailable()
        {
            return !this.IsOnABreak;
        }
        public override string ToString()
        {
            /* StringBuilder s = new StringBuilder();
            s.AppendLine($"Chef {this.Name} from department {this.Department} is able to cook the following dishes:");
            foreach (var dish in this.Dishes)
            {
                s.AppendLine(dish.ToString());
            }
            return s.ToString(); */
            return $"Chef {this.Name} from department {this.Department} is able to cook the following dishes:\r\n"+String.Join("\n",this.Dishes);
        }
        public string Name
        {
            get { return this.name; }
            set 
            { 
                if(value.Length > 2)
                {
                this.name = value; 
                }
                else throw new System.ArgumentException("Invalid chef name!");
            }
        }
        public string Department
        {
            get { return this.department; }
            set
            {
                if (value.All(c => char.IsUpper(c)))
                {
                    this.department = value;
                }
                else throw new System.ArgumentException("Department name should be uppercase word!");
            }
        }
        public List<Dish> Dishes
        {
            get { return this.dishes; }
            set { this.dishes = value; }
        }
        public bool IsOnABreak
        {
            get { return this.isOnABreak; }
            set { this.isOnABreak = value; }
        }
    }
}