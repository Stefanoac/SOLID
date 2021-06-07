using System;
using System.Collections.Generic;
using System.Text;

namespace Lsp.Payments
{
    class NubankRewards : IPaymentInstrument
    {
        public void CollectPayment()
        {
            Console.WriteLine("Pagamento realizado com sucesso");
            Console.WriteLine("Pontuação creditada");
        }

        public void Validate()
        {
            Console.WriteLine("Limite ok, rewards ok");
        }
    }
}
