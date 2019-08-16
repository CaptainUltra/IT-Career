using System;

namespace FieldsAndProperties_ex3
{
    class Employee
    {
        private string name;
        private double salary;
        private string position;
        private string department;
        private string email;
        private int age;

        public Employee(string name, double salary, string position, string department)
        {
            this.Name = name;
            this.Salary = salary;
            this.Position = position;
            this.Department = department;
            this.Email = "n/a";
            this.Age = -1;
        }

        public string Name { get; set; }
        public double Salary{ get; set;}
        public string Position{ get; set;}
        public string Department{ get; set;}
        public string Email{ get; set;}
        public int Age{ get; set;}
    }
}