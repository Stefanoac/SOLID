using System;

namespace Lsp.Payments
{
    class CreditCard : NubankCard
    {
        public override void Validate()
        {
            Console.WriteLine("Validando Limite...");
            Console.WriteLine("Limite Ok");
        }
    }
}
