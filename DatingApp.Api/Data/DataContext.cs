using DatingApp.Api.models;
using Microsoft.EntityFrameworkCore;

namespace DatingApp.Api.Data
{
    public class DataContext : DbContext 
    {
        // public DataContext() { }
        public DataContext(DbContextOptions<DataContext> options) : base (options) { }

        // protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        // {
        //     optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Initial Catalog=DBName;Integrated Security=True");
        // }

        public DbSet<Value> Values { get; set; }
    }
}