using System.Collections.Generic;
using System.Threading.Tasks;
using Entities;

namespace DataAccess.Repositories
{
    public interface ICustomerRepository : IGenericRepositoryAsync<Customer>
    {
        Task<ICollection<Direction>> ListDirections(int id);
    }
}