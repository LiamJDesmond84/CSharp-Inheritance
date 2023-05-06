using System;

namespace CSharp_Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehicle vehicle = new Vehicle(4,"Green");

            Car car = new Car("Yellow", "Hyundai", "Elantra");
        }
    }
}
