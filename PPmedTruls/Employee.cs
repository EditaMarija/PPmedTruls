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

        public Employee(int id, string name, string jobPosition, int age)
        {
            Id = id;
            Name = name;
            JobPosition = jobPosition;
            Age = age;
        }
        public Employee()
        {

        }

        public void RunEmployees()
        {     
                     
            MakeNewEmployees(); 
        }

        private void MakeNewEmployees()
        {
            Employee Marija = new Employee(1, "Marija", "Sales", 33);
            Employee Truls = new Employee(2, "Truls", "Service", 26);
            ////List the new employees and store them in the list.
            Butikk.Employees.Add(Marija);
            Butikk.Employees.Add(Truls);
            ShowEmployeeDetails(Marija);
            ShowEmployeeDetails(Truls);

        }

        public void ShowEmployeeDetails(Employee employee)
        {
            Console.WriteLine($"Name: {employee.Name} Job Position: {employee.JobPosition} Age: {employee.Age}");
            
        }
    }
}