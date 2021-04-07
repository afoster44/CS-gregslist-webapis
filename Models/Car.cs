using System;
using System.ComponentModel.DataAnnotations;

namespace gregslist.Models
{
    public class Car
    {
        // public Car(string make, string model, int price, int year)
        // {
        //     Make = make;
        //     Model = model;
        //     Price = price;
        //     Year = year;
        // }
        // public Car() { }
        public string Make { get; set; }
        public string Model { get; set; }

        [Range(0, int.MaxValue, ErrorMessage = "No way that number is TOO BIG")]
        public int Price { get; set; } = 0;
        public int Year { get; set; } = 0;
        public int Id { get; set; } = 0;
    }
}