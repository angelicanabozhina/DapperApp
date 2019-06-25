using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DapperApp.DatabaseConnection;
using DapperApp.Models;
using Dapper;

namespace DapperApp.Repositories
{
    public class ClientRepository : IClientRepository
    {
        private readonly IDatabaseConnectionFactory _databaseConnectionFactory;

        public ClientRepository(IDatabaseConnectionFactory databaseConnectionFactory)
        {
            _databaseConnectionFactory = databaseConnectionFactory;
        }

        public IEnumerable<ClientDTO> Get(List<int> ids)
        {
            const string query = @"";

            var queryParameters = new
            {
            };

            using (var connection = _databaseConnectionFactory.GetConnection())
            {
                IEnumerable<ClientDTO> clients;
                
                try
                {
                    connection.Open();
                    clients = connection.Query<ClientDTO>(query, queryParameters);
                }
                finally
                {
                    connection.Close();
                }              

                return clients;
            }
        }
    }
}
