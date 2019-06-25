using System.Data;
using System.Data.SqlClient;
using Microsoft.Extensions.Options;

namespace DapperApp.DatabaseConnection
{
    public class DatabaseConnectionFactory : IDatabaseConnectionFactory
    {
        private readonly IOptions<ConnectionStringOptions> _connectionStringOptions;

        public DatabaseConnectionFactory(IOptions<ConnectionStringOptions> connectionStringOptions)
        {
            _connectionStringOptions = connectionStringOptions;
        }

        public IDbConnection GetConnection()
        {
            return new SqlConnection(_connectionStringOptions.Value.DefaultConnection);
        }
    }
}
