using crudapi.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace crudapi.Data
{
    public class ApplicationDbContext(DbContextOptions options) : DbContext(options)
    {
        public required DbSet<Employee> Employees { get; set; }
    }
}
