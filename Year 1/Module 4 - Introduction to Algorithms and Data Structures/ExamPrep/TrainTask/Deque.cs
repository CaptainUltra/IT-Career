using System;
using System.Collections.Generic;
using System.Linq;

namespace TrainTask
{
    public class Deque<Train>
    {
        private List<Train> trains;
        //private int count;
        //private int capacity;

        public int Count { get => trains.Count;}
        public int Capacity { get => trains.Capacity; }

        public Deque()
        {
            trains = new List<Train>();
        }

        public void AddBack(Train train)
        {
            trains.Add(train);
        }

        public void AddFront(Train train)
        {
            trains.Insert(0, train);
        }

        public Train GetFront()
        {
            return trains.First();
        }

        public Train GetBack()
        {
            return trains.Last();
        }

        public Train RemoveBack()
        {
            var lastTrain = trains.Last();
            trains.RemoveAt(trains.Count-1);
            return lastTrain;
        }

        public Train RemoveFront()
        {
            var firstTrain = trains.First();
            trains.RemoveAt(0);
            return firstTrain;
        }
    }
}