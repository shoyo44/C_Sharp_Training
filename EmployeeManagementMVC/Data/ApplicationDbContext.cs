using EmployeeManagementMVC.Models;
using Microsoft.EntityFrameworkCore;

namespace EmployeeManagementMVC.Data;

public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : DbContext(options)
{
    public DbSet<Employee> Employees => Set<Employee>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Employee>().Property(employee => employee.Salary).HasPrecision(18, 2);
    }
}