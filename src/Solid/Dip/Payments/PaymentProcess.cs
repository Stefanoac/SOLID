using Dip.Factory;
using Dip.Model;
using System;

namespace Dip.Payments
{
    class PaymentProcess
    {
        public void Pay(string id)
        {
            // sql - Busca o produto
            // A classe do SQL SERVER é de baixo nivel da classe de payments
            // Classe de alto nivel (payments) ta dependendo de uma classe de baixo nivel (sql server)
            // Se quisermos mudar de banco futuramente vai exigir muito esforço, o código está engessado
            // A classe não está usando abstração

            //var product = new SQLServerProduct();
            //var productData = product.GetProductById(id);

            var product = DbProductFactory.Create();
            var productData = product.GetProductById(id);

            Console.WriteLine(productData);
        }
    }
}
