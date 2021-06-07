using Dip.Model;
using System.Configuration;

namespace Dip.Factory
{
    class DbProductFactory
    {
        public static DBProduct Create()
        {
            if (ConfigurationManager.AppSettings["DB"] == "SQLSERVER")
            {
                return new SQLServerProduct();
            }
            else
            {
                return new MongoDBProduct();
            }
        }
    }
}
