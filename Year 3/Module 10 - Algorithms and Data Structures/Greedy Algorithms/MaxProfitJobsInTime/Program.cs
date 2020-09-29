using System;
using System.Collections.Generic;
using System.Linq;

namespace MaxProfitJobsInTime
{
    class Job
    {
        public string Name { get; private set; }
        public int Deadline { get; private set; }
        public int Profit { get; private set; }
        public Job(string name, int deadline, int profit)
        {
            this.Name = name;
            this.Deadline = deadline;
            this.Profit = profit;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Input
            int n = 5;
            var jobs = new List<Job>()
            {
                new Job("j1", 2, 60),
                new Job("j2", 1, 100),
                new Job("j3", 3, 20),
                new Job("j4", 2, 40),
                new Job("j5", 1, 20)
            };

            int maxProfit = 0;
            int maxDeadlie = jobs.Max(x => x.Deadline);
            int i = 1;

            while(i < n && i <= maxDeadlie)
            {
                var job = jobs.Where(j => j.Deadline >= i).OrderByDescending(j => j.Profit).ThenBy(j => j.Deadline).First();
                jobs.Remove(job);
                Console.Write(job.Name + " ");
                maxProfit += job.Profit;
                i++;
            }
            Console.WriteLine();
            Console.WriteLine("Max profit: " + maxProfit);           
        }
    }
}
