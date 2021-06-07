using Ocp.Vehicles;
using System;

namespace Ocp
{
    class Program
    {
        static void Main(string[] args)
        {
            TypeVehicle type = TypeVehicle.CAR;

            if (type == TypeVehicle.CAR)
            {
                var car = new Car("Azul", 2022, 2.0, 5, 4);
            }
            else
            {
                var moto = new Motorcycle("Branco", 2022, 250);
            }

            Console.ReadLine();
        }
    }
}
