using EmployeeAdminPortal.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace EmployeeAdminPortal.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { 
            
        }

        public DbSet<Employee> Employees { get; set; } 



    }
}
