using Dapper.Contrib.Extensions;
using Microsoft.Data.SqlClient;
using SalesOrder;

namespace Repositories
{
    public class Repository<T> where T : class {
        
        private readonly SqlConnection _connection;
        public Repository(SqlConnection connection)
            => _connection = connection;

        public IEnumerable<T> GetAll()
            => _connection.GetAll<T>();

        public T GetById(int id) 
            => _connection.Get<T>(id);
    }
}