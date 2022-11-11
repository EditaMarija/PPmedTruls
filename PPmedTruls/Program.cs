namespace PPmedTruls
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to our SuperStore!\n");

            var MyStore = new Butikk("XXL", "sport");

            Produkt produkt = new Produkt(1, 5, "Tshirt", "Nike Tshirt", 100);
            Produkt andreProdukt = new Produkt(2, 7, "Ball", "Basketball", 500);
            MyStore.AddProducts(produkt);
            MyStore.AddProducts(andreProdukt);


            var runEmp = new Employee();
            runEmp.RunEmployees();

            MyStore.RunStore();


            ////show the produkt and store the names in the list in the class butikk.
            //Produkt MYprodukt = new Produkt(1, 5, "Tshirt", "Nike Tshirt", 100);
            //Produkt andreProdukt = new Produkt(2, 7, "Ball", "Basketball", 500);

            ////Add new stores
            //Butikk MyStore = new Butikk("Our Super Store", "XXL");

            ////add products to product list:
            //Butikk.Produkter.Add(MYprodukt);
            //Butikk.Produkter.Add(andreProdukt);

            ////Let's start shopping
            //Console.WriteLine("List of products:");
            //MyStore.ShowProducts();
            //Console.WriteLine("Please choose a product:");
            //var response = Console.ReadLine();



        }
    }
}