using Isp.Vehicles;
using System;

namespace Isp
{
    class Program
    {
        static void Main(string[] args)
        {
            var car = new Car("Azul", 2022, 4.0, 2, 2);
            var moto = new Motorcycle("Branca", 2022, 600);

            Console.ReadLine();
        }
    }
}
