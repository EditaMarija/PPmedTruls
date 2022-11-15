
namespace PPmedTruls
{
    public class Butikk
    {

        //Dette er for produkter med navn og evnt nr
        public string Name;
        public string Type;
        public int EmployeesId;
        public List<Employee> Employees;
        public List<Produkt> Produkter;

        public Butikk(string name, string type, List<Produkt> produkter)
        {
            Name = name;
            Type = type;
            Produkter = new List<Produkt>();
            Employees = new List<Employee>();
            initProducts(produkter);
        }

        public Butikk()
        {

        }

        public void initProducts(List<Produkt> produkter)
        {
            foreach (var produkt in produkter)
            {
                AddProducts(produkt);
            }
           
        }

        public void RunStore()
        {
            //Dette skal kjøre alle funksjonene i butikk.
            Console.Clear();
            ShowProducts();
            ShowEmployees();          
        }
     
        private void ShowProducts()
        {

             foreach (var produkt in Produkter)
             {
                 produkt.ShowDetails();
             }
            Console.WriteLine();
        }

        public void AddProducts(Produkt product)
        {
            Produkter.Add(product);
        }

        public void GetEmployeeDetails()
        {
    
            Console.WriteLine("Skriv navn:");
            var ansattNavn = Console.ReadLine();
            Console.WriteLine("Skriv stilling:");
            var posisjon = Console.ReadLine();
            Console.WriteLine("Skriv alder:");
            int alder = int.Parse(Console.ReadLine());
            AddEmployee(ansattNavn, posisjon, alder);

        }
        public void AddEmployee(string employeeName, string position, int age)
        {  
            var employee = new Employee(employeeName, position, age, GenerateId()); 
            Employees.Add(employee);
        }
        public int GenerateId()
        {
            EmployeesId++;
            return EmployeesId;
        }

        private void ShowEmployees()
        {
            foreach (var employee in Employees)
            {
                employee.ShowDetails();
            }
        }


    }
}
