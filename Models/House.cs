namespace gregslist.Models
{
    public class House
    {
        public House(string address, string levels, int bedrooms, int bathrooms, int price)
        {
            Address = address;
            Levels = levels;
            Bedrooms = bedrooms;
            Bathrooms = bathrooms;
            Price = price;
        }

        public string Address { get; set; }
        public string Levels { get; set; }
        public int Bedrooms { get; set; }
        public int Bathrooms { get; set; }
        public int Price { get; set; }
    }
}