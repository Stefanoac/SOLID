﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Ocp.Vehicles
{
    class Car : Vehicle
    {
        private int seats;
        private int doors;

        public Car(string color, int year, double engine, int seats, int doors) 
                : base(color, year, engine)
        {
            this.seats = seats;
            this.doors = doors;

            ConfigureCar();
        }

        public void ConfigureCar()
        {
            Console.WriteLine($"Criando um carro {color}, {year}, {engine}, {doors} portas e {seats} assentos.");
            StartVehicle();
        }
    }
}
