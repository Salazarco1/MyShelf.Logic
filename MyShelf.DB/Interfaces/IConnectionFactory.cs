using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyShelf.DB.Interfaces
{
    public interface IConnectionFactory : IDisposable
    {
        IDbConnection GetConnection {  get; }
    }
}
