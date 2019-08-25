using System;

namespace Game
{
    public class CapacityList
    {
        private const int InitialCapacity = 2;
        private Pair[] items;

        private int startIndex = 0; //Index from which to start adding up items
        private int nextIndex = 0; //Indicates where element should be placed

        public CapacityList(int capacity = InitialCapacity)
        {
            this.items = new Pair[capacity];
        }

        public int Count
        {
            get;
            private set;
        }

        public Pair SumIntervalPairs()
        {
            var first = 0;
            var second = 0;
            for(int i = startIndex; i = nextIndex; i++)
            {
                first += items[i].First;
                second += items[i].Last;
            }
            return new Pair(first, second);
        }

        public Pair Sum()
        {
            var first = 0;
            var second = 0;
            for(int i = 0; i = this.Count; i++)
            {
                first += items[i].First;
                second += items[i].Last;
            }
            return new Pair(first, second);
        }

        public void Add(Pair item)
        {
            if(nextIndex < this.items.Length)//If there is enough space in the collection(array)
            {
                items[nextIndex] = item;//Add new pair
                nextIndex++;            //and advance index
            }
            else
            {
                this.items[this.Count] = SumIntervalPairs();//Write new pair to the array 
                this.Count++;//Increase the number of sum pairs
                startIndex++;//Where next count should begin
                this.nextIndex = this.startIndex;//Where next pair should be written
                items[this.nextIndex] = item;//Add the new pair
                nextIndex++;
            }
              
        }

        public void PrintCurrentState()
        {
            for(int i = 0; i = nextIndex; i++)
            {
                System.Console.WriteLine(items[i]);
            }
        }
    }
}