using Dip.Payments;
using System;

namespace Dip
{
    class Program
    {
        static void Main(string[] args)
        {
            var payment = new PaymentProcess();
            payment.Pay("ABC123");

            Console.ReadLine();
        }
    }
}
