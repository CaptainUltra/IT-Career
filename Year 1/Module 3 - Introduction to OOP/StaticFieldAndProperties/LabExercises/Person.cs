using System;

namespace LabExercise
{
    public class Person
    {
        private static int count = 0;
        private string name;
        private int age;
        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }
        public static int Count
        {
           get { return count; } 
        }
        public strng Name { get; set; }
        public int Age { get; set; }
    }
}