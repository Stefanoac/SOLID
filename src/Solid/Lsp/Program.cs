using Lsp.Payments;
using System;

namespace Lsp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Trocando as instancia continua funcionando

            //var card = new CreditCard();
            //var card = new DebitCard();

            // Essa classe foi diretamente na interface, sem passar no nubank card
            // Nos programamos dirigidos a interface e preparamos nosso código para caso haja alteração ele nao quebre
            var card = new NubankRewards(); 

            //Imagine que esses metodos são chamados em todo sistema, idependente da instacia que eu chamar, o código tem que continuar funcionando
            card.Validate();
            card.CollectPayment();

            Console.ReadLine();
        }
    }
}
