using System.Collections.Generic;
using DapperApp.Models;

namespace DapperApp.Repositories
{
    public interface IClientRepository
    {
        IEnumerable<ClientDTO> Get(List<int> ids);
    }
}
