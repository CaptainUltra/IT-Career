using System;
using System.Text;

namespace Exam
{
    public class Parking
    {
        private Car head;
        private Car tail;
        private int count;
        public int Count
        {
            get { return this.count; }
        }
        public Parking()
        {

        }
        public void AddCar(string carNumber)
        {
            this.count++;
            if (this.head == null)
            {
                this.head = this.tail = new Car(carNumber);
            }
            else
            {
                var newCar = new Car(carNumber);
                this.tail.Next = newCar;
                this.tail = newCar;
            }
        }
        public void AddFancyCar(string carNumber)
        {
            this.count++;
            if (this.head == null)
            {
                this.head = this.tail = new Car(carNumber);
            }
            else
            {
                var newCar = new Car(carNumber);
                newCar.Next = this.head;
                this.head = newCar;
            }
        }
        public Car CheckCarIsPresent(string carNumber)
        {
            var currentCar = this.head;
            while (currentCar != null)
            {
                if (currentCar.CarNumber == carNumber)
                {
                    return currentCar;
                }
                currentCar = currentCar.Next;
            }
            return null;
        }
        public bool ReleaseCar(string carNumber)
        {
            if (this.head.CarNumber == carNumber)
            {
                if(this.head.Next != null)
                {
                    this.head = this.head.Next;
                }
                this.count--;
                return true;
            }
            Car currentCar = this.head;
            Car prevCar = null;
            while(currentCar != null)
            {
                if(currentCar.CarNumber == carNumber)
                {
                    this.count--;
                    if(prevCar != null)
                    {
                        if(this.tail == currentCar)
                        {
                            this.tail = prevCar;
                        }
                        prevCar.Next = currentCar.Next;
                        return true;
                    }
                }
                prevCar = currentCar;
                currentCar = currentCar.Next;
            }
            return false;

        }
        public bool ReleaseCar(int index)
        {
            /*var currentIndex = 0;
            Car current = head;
            Car previous = null;
            while (current != null)
            {
                if (currentIndex == index)
                {
                    if (previous != null)
                    {
                        previous.Next = current.Next;
                    }
                    else
                    {
                        this.head = current.Next;
                    }
                    if (current.Next == null)
                    {
                        this.tail = previous;
                    }
                    count--;
                    return true;
                }
                current = current.Next;
                previous = current;
                currentIndex++;
            }
            return false;*/
            if (index >= 0 && index < this.Count)
            {
                if (index == 0)
                {
                    this.head = this.head.Next;
                    this.count--;
                    return true;
                }
                Car currentCar = this.head.Next;
                Car prevCar = this.head;
                for (int i = 1; i <= index; i++)
                {
                   
                    if (currentCar != null)
                    {
                        if (this.tail == currentCar)
                        {
                            this.tail = prevCar;
                            prevCar.Next = null;
                            this.count--;
                            return true;
                        } 
                        this.count--;
                        prevCar.Next = currentCar.Next;
                        return true;
                    }

                    prevCar = currentCar;
                    currentCar = currentCar.Next;
                }
            }
            return false;
        }
        public StringBuilder ParkingInformation()
        {
            var result = new StringBuilder();
            if (this.Count == 0)
            {
                result.Append("<Parking is empty!>");
            }
            else
            {
                var currentCar = this.head;
                while (currentCar != null)
                {
                    result.Append(currentCar);
                    result.Append("\n");
                    currentCar = currentCar.Next;
                }
            }
            return result;
        }
    }
}