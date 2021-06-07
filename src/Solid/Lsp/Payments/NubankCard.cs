using System;
using System.Collections.Generic;
using System.Text;

namespace Lsp.Payments
{
    abstract class NubankCard : IPaymentInstrument
    {
        public void CollectPayment()
        {
            Console.WriteLine("Pagamento Realizado");
        }

        public virtual void Validate()
        {
            // Validação Basica do cartão
        }
    }
}
