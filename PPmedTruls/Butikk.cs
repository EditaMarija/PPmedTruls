
namespace PPmedTruls
{
    public class Butikk
    {

        //Dette er for produkter med navn og evnt nr
        public string Name;
        public string Type;
        public static List<Employee> Employees;
        public static List<Produkt> Produkter;

        public Butikk(string name, string type)
        {
            Name = name;
            Type = type;
            Produkter = new List<Produkt>();
            Employees = new List<Employee>();
        }

        public Butikk()
        {

        }

        public void RunStore()
        {
            //Dette skal kjøre alle funksjonene i butikk.

            ShowProducts();

            //ShowEmployees();
            
        }

        
        private void ShowProducts()
        {
            //Produkt MYprodukt = new Produkt(1, 5, "Tshirt", "Nike Tshirt", 100);
            //Produkt andreProdukt = new Produkt(2, 7, "Ball", "Basketball", 500);
            //Butikk.Produkter.Add(MYprodukt);
            //Butikk.Produkter.Add(andreProdukt);

             foreach (var item in Produkter)
             {
                item.ShowProductDetails();
             }
            Console.WriteLine();
        }

        public void AddProducts(Produkt product)
        {
            Produkter.Add(product);
        }

        //private void ShowEmployees()
        //{

        //    foreach (var item in Employees)
        //    {
        //        //Console.WriteLine($"Emplyee: {item.Name}");
        //        item.ShowEmployeeDetails();
        //    }
        //}


    }
}
