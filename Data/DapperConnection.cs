using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;

namespace BASEBALLBIBICOWEB.Data
{
    public class DapperConnection : IConnection
    {
        private readonly string _connectionString;


        public DapperConnection(IConfiguration configuration)
            => _connectionString = configuration.GetConnectionString("DefaultConnection");

        public SqlConnection GetConnection()
        {
            return new SqlConnection(_connectionString);
        }
    }
}
