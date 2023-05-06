using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSharp_Inheritance
{
    public class Person
    {
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
    }
}