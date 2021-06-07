namespace Dip.Model
{
    class MongoDBProduct : DBProduct
    {
        //CONSULTA NO BANCO DE DADOS
        public string GetProductById(string id)
        {
            return $"MongoDB: exibindo dados do produto {id}";
        }
    }
}
