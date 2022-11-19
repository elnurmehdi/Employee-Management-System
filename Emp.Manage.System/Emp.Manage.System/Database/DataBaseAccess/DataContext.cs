using Emp.Manage.System.Database.Models;
using Microsoft.EntityFrameworkCore;

namespace Emp.Manage.System.Database.DataBaseAccess
{
    public class DataContext : DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-DOJ9MHV;Database=Employees;Trusted_Connection=True;TrustServerCertificate=True;");
        }

        public DbSet<Employee> Employees { get; set; }




    }
}
