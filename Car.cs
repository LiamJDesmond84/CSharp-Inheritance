using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSharp_Inheritance
{
    
    public class Car: Vehicle, IRideable
    {
        public string Make;
        public string Model;

        //* we can use DistanceTraveled to be a wrapper for "Odometer"
        public double DistanceTraveled
        {
            get { return Odometer; }
            set { Odometer = value; }
        }
        public void Ride(double distance)
        {
            //* here we can choose implement this method however we wish
            //* as long as we meet the requirements of the method
            Console.WriteLine("... driving ...");
            DistanceTraveled += distance;
        }

        public Car(string color, int odem, string make, string model) : base(color, odem){
            Make = make;
            Model = model;
        }

        public override void GetInfo()
        {

        base.GetInfo();
        // Console.WriteLine($"Num Passengers: {NumPassengers}");
        // Console.WriteLine($"Color: {Color}");
        // Console.WriteLine($"Miles: {Odometer}");
        Console.WriteLine($"Make: {Make}");
        Console.WriteLine($"Model: {Model}");
        }
    }
}