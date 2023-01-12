using Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace DataAccess
{
    public class Context : IdentityDbContext
    {
        public Context()
        {
            
        }

        public Context(DbContextOptions<Context> options)
            :base(options)
        {
            
        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Direction> Directions { get; set; }
    }
}