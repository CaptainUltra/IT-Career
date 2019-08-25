namespace Exam
{
    public class Car
    {
        private string carNumber;
        private Car next;

        public Car(string carNumber)
        {
            this.carNumber = carNumber;
        }
        public string CarNumber
        {
            get {return this.carNumber;}
        }
        public Car Next
        {
            get{return this.next;}
            set{this.next = value;}
        }
        public override string ToString()
        {
            return $"Car: {this.CarNumber}";
        }
    }
}