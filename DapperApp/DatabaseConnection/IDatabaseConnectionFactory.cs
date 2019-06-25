using System.Data;

namespace DapperApp.DatabaseConnection
{
    public interface IDatabaseConnectionFactory
    {
        IDbConnection GetConnection();
    }
}
