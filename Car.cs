using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSharp_Inheritance
{
    
    public class Car: Vehicle
    {
        public string Make;
        public string Model;

        public Car(string color, int odem, string make, string model) : base(color, odem){
            Make = make;
            Model = model;
        }

        public override void GetInfo()
        {
        Console.WriteLine($"Num Passengers: {NumPassengers}");
        Console.WriteLine($"Color: {Color}");
        Console.WriteLine($"Miles: {Odometer}");
        Console.WriteLine($"Make: {Make}");
        Console.WriteLine($"Model: {Model}");
        }
    }
}