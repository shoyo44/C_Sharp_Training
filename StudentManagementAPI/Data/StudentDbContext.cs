using Microsoft.EntityFrameworkCore;
using StudentManagementAPI.Models.Entity;

namespace StudentManagementAPI.Data
{
    public class StudentDbContext : DbContext
    {
        public StudentDbContext(DbContextOptions<StudentDbContext> options) : base(options)
        {
        }

        public DbSet<Student> Students { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Student>(entity =>
            {
                entity.ToTable("Students");
                entity.HasKey(e => e.StudentId);
                entity.Property(e => e.StudentId).HasColumnType("uniqueidentifier").ValueGeneratedOnAdd();
                entity.Property(e => e.Name).IsRequired().HasMaxLength(100).HasColumnType("nvarchar(100)");
                entity.Property(e => e.Email).IsRequired().HasMaxLength(100).HasColumnType("nvarchar(100)");
                entity.Property(e => e.Phone).IsRequired().HasMaxLength(15).HasColumnType("nvarchar(15)");
                entity.Property(e => e.Age).IsRequired().HasColumnType("int");
                entity.Property(e => e.Course).IsRequired().HasMaxLength(100).HasColumnType("nvarchar(100)");
                entity.Property(e => e.Address).HasMaxLength(250).HasColumnType("nvarchar(250)").IsRequired(false);
            });
        }
    }
}
