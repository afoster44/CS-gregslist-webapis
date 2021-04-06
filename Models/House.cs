using System;
using System.ComponentModel.DataAnnotations;

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

        [Required]
        public string Address { get; set; }
        [Required]
        public string Levels { get; set; }
        [Required]
        public int Bedrooms { get; set; }
        [Required]
        public int Bathrooms { get; set; }
        [Required]
        public int Price { get; set; }
        [Required]
        public string Id { get; private set; } = Guid.NewGuid().ToString();
    }
}