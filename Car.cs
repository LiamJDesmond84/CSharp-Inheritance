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

        public Car(string color, string make, string model) : base(color){
            Make = make;
            Model = model;
        }
    }
}