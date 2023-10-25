using GeneticAlgorithms.Models;
using Microsoft.EntityFrameworkCore;

namespace GeneticAlgorithms;

public class DataContext : DbContext
{
    public DbSet<StudentCourse> StudentCourses { get; set; }
    public DbSet<Student> Students { get; set; }
    public DbSet<Teacher> Teachers { get; set; }
    public DbSet<Course> Courses { get; set; }
    public DbSet<Place> Places { get; set; }
    public DbSet<TimeSlot> TimeSlots { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseNpgsql("Server=localhost;Database=genetic;Username=postgres;Password=postgres;");
        base.OnConfiguring(optionsBuilder);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<StudentCourse>()
            .HasKey(e => new { e.StudentId, e.CourseId });
        
        modelBuilder.Entity<Student>()
            .HasMany(e => e.Courses);

        modelBuilder.Entity<Course>()
            .HasMany(e => e.StudentCourses);

        modelBuilder.Entity<Student>()
            .HasMany(e => e.TimeSlots);

        modelBuilder.Entity<TimeSlot>()
            .HasMany(e => e.Students);
            
        base.OnModelCreating(modelBuilder);
    }
}