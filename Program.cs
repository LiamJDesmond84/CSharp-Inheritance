using System;
using System.Collections.Generic;

namespace CSharp_Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehicle vehicle = new Vehicle(4,"Green");

            Car car = new Car("Yellow", 69, "Hyundai", "Elantra");

            // vehicle.GetInfo();

            // car.GetInfo();

            // car.Drive(100);

            Person dude = new Person();
            dude.setVehicles(vehicle);
            dude.setVehicles(car);

            dude.getVehicles();

            // foreach(var x in vehicles){

            //     x.GetInfo();
            // }
        }
    }
}
