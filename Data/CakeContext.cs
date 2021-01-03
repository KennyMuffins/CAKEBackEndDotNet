using Cake.Models;
using Microsoft.EntityFrameworkCore;

namespace Cake.Data
{
    public class CakeContext : DbContext
    {
        public CakeContext(DbContextOptions<CakeContext> opt) : base(opt)
        {

        }

        public DbSet<User> Users { get; set; }
    }
}