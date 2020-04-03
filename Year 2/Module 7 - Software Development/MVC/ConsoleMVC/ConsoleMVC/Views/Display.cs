using System;

namespace ConsoleMVC.Views
{
    public class Display
    {
        public double Percent { get; set; }
        public double Amount { get; set; }
        public double Total { get; set; }
        public double TipAmount { get; set; }
        public Display()
        {
            this.Percent = 0;
            this.Amount = 0;
            this.Total = 0;
            this.TipAmount = 0;
            this.GetValues();
        }

        private void GetValues()
        {
            System.Console.WriteLine("Enter amount of the meal: ");
            this.Amount = double.Parse(System.Console.ReadLine());
            System.Console.WriteLine("Enter the percent you want to tip: ");
            this.Percent = double.Parse(System.Console.ReadLine());
        }
        public void ShowTipAndTotal()
        {
            System.Console.WriteLine("Your tip is: {0:C}", this.TipAmount);
            System.Console.WriteLine("The total will be: {0:C}", this.Total);
        }
    }
}