using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSharp_Inheritance
{
    public abstract class Vehicle
    {
    protected int NumPassengers;
    protected string Color;
    protected double Odometer;
    //* Say Vehicle has two overloaded constructors
    //* We will either need to pass up two values (int, string), from Car ...
    public Vehicle(int numPas, string col)
    {   
        NumPassengers = numPas;
        Color = col;
        Odometer = 0;
    }
    //* Or just one string value.  
    public Vehicle(string col, int odem)
    {
        NumPassengers = 5;
        Color = col;
        Odometer = odem;
    }

    public virtual void GetInfo()
    {
        Console.WriteLine($"Num Passengers: {NumPassengers}");
        Console.WriteLine($"Color: {Color}");
        Console.WriteLine($"Miles: {Odometer}");
    }

    public void Drive(double distance)
    {

        Odometer += distance;
        Console.WriteLine("My odometer is now at: " + Odometer + " miles");
    }

    //# Abstract Method
    // "abstract" methods only take a method "signature", just like interfaces
    // they also must be either "public" or "protected", as they need to be
    // accessible to their child classes
    public abstract void MakeNoise();


    
    }
}