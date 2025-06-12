using MyShelf.DB.Interfaces;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyShelf.DB.UOW
{
    public class DatabaseConnectionFactory /*: IConnectionFactory, IDisposable*/
    {
        //    private readonly string connectionString = "Data Source = (localdb)\\MSSQLLocalDB;Initial Catalog = StructuredProjectDB";

        //    public static string CnnVal(string name)
        //    {
        //        return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        //    }

        //    public IDbConnection GetConnection
        //    {
        //        get
        //        {
        //            DbProviderFactories.RegisterFactory("System.Data.SqlClient", System.Data.SqlClient.SqlClientFactory.Instance);
        //            var factory = DbProviderFactories.GetFactory("System.Data.SqlClient");
        //            var conn = factory.CreateConnection();
        //            conn.ConnectionString = connectionString;

        //            return conn;
        //        }
        //    }

        //    public void Dispose()
        //    {
        //        using (var conn = GetConnection)
        //        {
        //            conn.Dispose();
        //        }
        //    }
    }
}
