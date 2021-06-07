using System;

namespace Isp.Vehicles
{
    class Motorcycle : IVehicleMotorcycle
    {
        private string color;
        private int year;
        private double engine;

        public Motorcycle(string color, int year, double engine)
        {
            ConfigureMotorcycle(color, year, engine);
        }

        //public void ConfigureCar(string color, int year, double engine, int seats, int doors)
        //{
        //    // ESSE METHODO NÃO TEM NECESSIDADE
        //    // BAIXA COESAO
        //    // FOI CRIADA A INTERFACE IVEHICLE CAR E MOTORCYCLE QUE FAZER HERANÇA PARA IVEHICLE ASSIM NÃO NECESSITANDO TER CLASSES NÃO UTILIZADAS NAS DUAS CLASSES
        //}

        public void ConfigureMotorcycle(string color, int year, double engine)
        {
            this.color = color;
            this.year = year;
            this.engine = engine;

            Console.WriteLine($"Criando uma moto ano {year}, motor {engine}, da cor {color}");
            StartVehicle();
        }

        public void StartVehicle()
        {
            Console.WriteLine("Ligando os motores");
        }
    }
}
