using System.Data;
using System.Diagnostics;

namespace PPmedTruls
{
    public class Employee
    {
        //For alle folk som jobber i butikken.
        public int Id { get; set; }
        public string Name { get; set; }

        public string JobPosition { get; set; }

        public int Age;

        public Employee(string name, string jobPosition, int age, int id)
        {
            Id = id;
            Name = name;
            JobPosition = jobPosition;
            Age = age;
        }
        public Employee()
        {
        }

        public void ShowDetails()
        {
            Console.WriteLine($"{Id}  | Name: {Name}  | Job Position: {JobPosition}  | Age: {Age}");
            
        }
    }
}