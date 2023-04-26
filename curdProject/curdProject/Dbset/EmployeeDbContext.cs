using curdProject.Model;
using Microsoft.EntityFrameworkCore;
namespace curdProject.Dbset
{
    public class EmployeeDbContext:DbContext
    {
        public EmployeeDbContext(DbContextOptions<EmployeeDbContext>options) : base(options)
        {

        }
        public DbSet<Employee> employees { get; set; }
    }
}
