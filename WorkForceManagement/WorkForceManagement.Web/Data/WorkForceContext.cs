using Microsoft.EntityFrameworkCore;
using WorkForceManagement.Web.Models;

namespace WorkForceManagement.Web.Data;


public class WorkForceContext : DbContext
{
    public DbSet<Employee> Employees { get; set; }


    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        //WorkForceDB is the database name in Catalog
        //dotnet tool install dotnet-ef
        //dotnet tool install dotnet-ef - g
        //dotnet ef
        //dotnet ef migrations add InitialCreate
        //dotnet ef database update

        string connectionString = "Data Source=(localdb)\\mssqllocaldb;Initial Catalog=WorkForceDB;Integrated Security=true";
        optionsBuilder.UseSqlServer(connectionString);
    }
}
