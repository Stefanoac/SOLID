namespace Dip.Model
{
    class SQLServerProduct : DBProduct
    {
        //CONSULTA NO BANCO DE DADOS
        public string GetProductById(string id)
        {
            return $"SQL SERVER: exibindo dados do produto {id}";
        }
    }
}
