using dotnet_ef_marvel.src.Entities;
using Microsoft.EntityFrameworkCore;

namespace dotnet_ef_marvel.src.Database
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<Hero> heroes { get; set; }
        public DbSet<Group> groups { get; set; }
    }
}