using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data;

public class DataContext : DbContext
{
    public DataContext(DbContextOptions<DataContext> options) : base(options)
    {


    }
    public DbSet<Region> Regions { get; set; }
    public DbSet<Country> Countries { get; set; }
    public DbSet<Deparment> Deparments { get; set; }
    public DbSet<Job> Jobs { get; set; }
    public DbSet<Employee> Employees { get; set; }
    public DbSet<JobHistory> JobHistories { get; set; }
    public DbSet<JobGrades> JobGrades { get; set; }
    public DbSet<Location> Locations { get; set; } 
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<JobHistory>().HasKey(x => new { x.EmployeeId, x.JobId });
        base.OnModelCreating(modelBuilder);
    }
}

