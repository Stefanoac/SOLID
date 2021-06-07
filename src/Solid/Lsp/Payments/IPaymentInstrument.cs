using System;
using System.Collections.Generic;
using System.Text;

namespace Lsp.Payments
{
    interface IPaymentInstrument
    {
        void Validate();
        void CollectPayment();
    }
}
