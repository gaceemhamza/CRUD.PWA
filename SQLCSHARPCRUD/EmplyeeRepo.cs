using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLCSHARPCRUD
{
    public class EmplyeeRepo
    {
       DbProviderFactory factory;
        string provider;

        public string connectionString { get; private set; }

        string connectdtring;

        public EmplyeeRepo()
        {
            provider = ConfigurationManager.AppSettings["provider"];
            connectionString = ConfigurationManager.AppSettings["connectionString"];

            factory = DbProviderFactories.GetFactory(provider);

        }
        public List<Employee> GetAll()
        {
            var employes = new List<Employee>()
                using (var connection = factory.CreateConnection())
            {
                connection.ConnectionString = connectionString;
                connection.Open();
                var command = factory.CreateCommand();

            }
        }

    }
}
