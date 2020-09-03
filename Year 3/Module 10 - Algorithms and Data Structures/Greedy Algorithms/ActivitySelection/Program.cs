using System;
using System.Collections.Generic;
using System.Linq;

namespace ActivitySelection
{
    internal class Activity
    {
        public string Name { get; set; } 
        public int  Start { get; set; }
        public int End { get; set; }

        public override string ToString()
        {
            return $"{this.Name}: {this.Start} - {this.End}";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Activity> activities = new List<Activity>();

            //Example data seed
            activities.Add(new Activity() {Name = "a1", Start = 1, End = 3});
            activities.Add(new Activity() {Name = "a2", Start = 0, End = 4});
            activities.Add(new Activity() {Name = "a3", Start = 1, End = 2});
            activities.Add(new Activity() {Name = "a4", Start = 4, End = 6});
            activities.Add(new Activity() {Name = "a5", Start = 2, End = 9});
            activities.Add(new Activity() {Name = "a6", Start = 5, End = 8});
            activities.Add(new Activity() {Name = "a7", Start = 3, End = 5});
            activities.Add(new Activity() {Name = "a8", Start = 4, End = 5});

            activities = activities.OrderBy(a => a.End).ToList();

            var last = activities.First();

            List<string> results = new  List<string>();
            results.Add(last.ToString());

            for (int i = 1; i < activities.Count; i++)
            {
                var currentActivity = activities[i];
                if(currentActivity.Start >= last.End)
                {
                    last = currentActivity;
                    results.Add(currentActivity.ToString());
                }
            }

            Console.WriteLine("Results:");
            foreach (var activity in results)
            {
                System.Console.WriteLine(activity.ToString());
            }
        }
    }
}
