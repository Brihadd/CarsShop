using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public  class DatabaseContext:DbContext
    {
        
    public DbSet<Client> Clients { get; set; }
    public DbSet<Employee> Employees { get; set; }
    public DbSet<Car> Cars { get; set; }
     public DbSet<History> Historys { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Data Source=T530\\SQLEXPRESS;Initial Catalog=CarsShop;Trusted_Connection=True");
    }
    
    }
}
