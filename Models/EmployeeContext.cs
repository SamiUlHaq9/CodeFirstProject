using Microsoft.EntityFrameworkCore;

namespace CodeFirst.Models
{
    public class EmployeeContext : DbContext
    {
        public EmployeeContext(DbContextOptions<EmployeeContext> options) : base()
        {

        }
        public DbSet<Employee> Employees { get; set;}
    }
}
