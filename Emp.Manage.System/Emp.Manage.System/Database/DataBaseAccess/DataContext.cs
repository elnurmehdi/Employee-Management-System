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

    public class TableAutoIncrementEmployeeCode
    {
        static Random randomCode = new Random();

        private static string _employeeCode;
        public static string RandomEmpCode
        {
            get
            {
                _employeeCode = "E" + randomCode.Next(10000, 100000);
                return _employeeCode;

            }

        }
    }



}

