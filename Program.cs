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
            Horse wilbur = new Horse("Wilbur", 120);

            // vehicle.GetInfo();

            // car.GetInfo();

            // car.Drive(100);

            Person dude = new Person("Dude", car);
            Person walter = new Person("Walter", wilbur);
            dude.setVehicles(vehicle);
            dude.setVehicles(car);

            // dude.getVehicles();

            // foreach(var x in vehicles){

            //     x.GetInfo();
            // }


        IRideable[] variousRideables = new IRideable[]
            {
                new Car("Yellow", 76, "Dodge", "Dart"),
                new Car("Green", 22, "Ford", "Fiesta"),
                new Horse("Silver Queen", 100),
                new Horse("Samammish", 75),
            };
            // let them all ride!
            foreach(var rideable in variousRideables)
            {
                // each "rideable" object will be able to invoke the common "Ride()" method
                // however the implementation of "Ride()" will be unique to how each class has chosen to build it
                rideable.Ride(50);
            }




        }

    }
}
