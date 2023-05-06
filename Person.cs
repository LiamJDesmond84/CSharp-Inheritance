using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSharp_Inheritance
{
    public class Person
    {
        public string Name;
        List<Vehicle> myVehicles = new List<Vehicle>();

        public void setVehicles(Vehicle v){
            myVehicles.Add(v);
        }

        public void getVehicles(){

            foreach(var x in myVehicles){
                Console.WriteLine("The Dude's stuff:");
                x.GetInfo();
            }
        }

        public IRideable Transport;
        public double Miles;
        public Person(string name, IRideable trans)
        {
            Name = name;
            Transport = trans;
            Miles = 0;
        }
        // Person can make use of the capabilities of their "transport"
        public void GoSomewhere(double miles)
        {
            Transport.Ride(miles);
            Miles += Transport.DistanceTraveled;
        }
        public void GetInfo()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Miles Traveled: {Miles}");
        }
    }
}