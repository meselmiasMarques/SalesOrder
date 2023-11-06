using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.VisualBasic;
using models;
using Repositories;
using SalesOrder;

namespace controllers
{
    [ApiController]
    [Route("/v1/users")]
    public class UserController{
    private const string CONNECTION_STRING = @"Server=localhost,1433;
            Database=dbOrderSales;User ID=sa;Password=Mm@rques0701!;TrustServerCertificate=True";

        [HttpGet]
        public IEnumerable<User> GetAll()
        {
            using (var connection  = new SqlConnection(CONNECTION_STRING))
            {
                var repository = new Repository<User>(connection);
                var users = repository.GetAll();
                return users;
            }
        }

    }
}