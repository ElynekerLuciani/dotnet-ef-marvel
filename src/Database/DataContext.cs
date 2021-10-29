using dotnet_ef_marvel.src.Entities;
using Microsoft.EntityFrameworkCore;

namespace dotnet_ef_marvel.src.Database
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
            var connection = "Server=.\\SQLEXPRESS2017; Initial Catalog=dbAPI;MultipleActiveResult=true;User Id=admin;Password=Freire2096#";
        }

        public DbSet<Hero> heroes { get; set; }
        public DbSet<Group> groups { get; set; }
    }
}