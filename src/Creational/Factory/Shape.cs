using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    public interface Shape
    {
        //Interfaces can have constants
        public const double PI = 3.14; 
        //Recall that interfaces must have abstract methods
        public void sayName();
    }

    public class Square : Shape
    {
        public void sayName()
        {
            Console.WriteLine("I am a Square!");
        }
    }
    public class Rectangle : Shape
    {
        public void sayName()
        {
            Console.WriteLine("I am a Rectangle!");
        }
    }
    public class Triangle : Shape
    {
        public void sayName()
        {
            Console.WriteLine("I am a Triangle!");
        }
    }
}
