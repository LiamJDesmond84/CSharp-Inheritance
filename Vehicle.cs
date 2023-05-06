using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSharp_Inheritance
{
    public class Vehicle
    {
    public int NumPassengers;
    public string Color;
    public double Odometer;
    //* Say Vehicle has two overloaded constructors
    //* We will either need to pass up two values (int, string), from Car ...
    public Vehicle(int numPas, string col)
    {   
        NumPassengers = numPas;
        Color = col;
        Odometer = 0;
    }
    //* Or just one string value.  
    public Vehicle(string col)
    {
        NumPassengers = 5;
        Color = col;
        Odometer = 0;
    }
    }
}