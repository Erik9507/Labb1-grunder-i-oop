using System;       //Erik Norell sut21

namespace Labb1_grunder_i_oop
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle radiusFive = new Circle(5);
            Circle radiusSix = new Circle(6);
            Console.WriteLine("The area of a circle with the radius of 5 is " + radiusFive.getArea());
            Console.WriteLine("The area of a circle with the radius of 6 is " + radiusSix.getArea());
            Console.WriteLine();

            Console.WriteLine("The volyme of a sphere with the radius of 5 is " + radiusFive.getVolume());
            Console.WriteLine("The volyme of a sphere with the radius of 6 is " + radiusSix.getVolume());
            Console.WriteLine();

            Console.WriteLine("Type in the radius to find out area of a cirle");
            Circle radius = new Circle(int.Parse(Console.ReadLine()));
            Console.WriteLine("The area of your circle is " + radius.getArea());
            Console.WriteLine();

            Console.WriteLine("Type in the radius to find out volume of a sphere");
            Circle volume = new Circle(int.Parse(Console.ReadLine()));
            Console.WriteLine("The volume of your sphere is " + volume.getVolume());
        }
    }
    class Circle    //Klassen för cirkel
    {
        float pi = 3.141f;  //variable för pi
        int radius;         //variabel för radien
        public Circle(int inputRadius)
        {
            radius = inputRadius;
        }
        public float getArea()
        {
            return (radius * radius * pi);  //formeln för att räkna ut arean med hjälp av radien och pi
        }
        public float getVolume()
        {
            return (4 * pi * (radius * radius * radius) / 3);   //formeln för att räkna ut volymen med hjälp av radien och pi
        }

    }
}
