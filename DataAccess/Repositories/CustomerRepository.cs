using Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataAccess.Repositories
{
    public class CustomerRepository : GenericRepositoryAsync<Customer>, ICustomerRepository
    {
        private readonly Context _context;

        public CustomerRepository(Context context) :base (context)
        {
            _context = context;
        }

        public async Task<ICollection<Direction>> ListDirections(int id)
        {
            return await _context.Set<Direction>()
                .Where(p => p.CustomerId == id)
                .ToListAsync();
        }
    }
}
