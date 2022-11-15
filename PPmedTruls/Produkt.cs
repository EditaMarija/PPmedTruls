namespace PPmedTruls
{
    public class Produkt
    {

        //Produkt info med navn og innhold i produktet
        public int Id;
        public int Count;
        public string Name;
        public string Description;
        public int Price;

        public Produkt(int id,int count, string name, string description, int price)
        {
            Id = id;
            Count = count;
            Name = name;
            Description = description;
            Price = price;
        }

        public void ShowDetails()
        {
            Console.WriteLine($"Id: {Id} | Name: {Name} | Count: {Count} | Descriptions: {Description} | Price: {Price:c2}");
        }


    }
}