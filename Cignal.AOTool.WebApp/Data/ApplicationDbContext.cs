using Cignal.AOTool.WebApp.Data.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Cignal.AOTool.WebApp.Data;

public class ApplicationDbContext : IdentityDbContext<AppUser> 
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {

    }

    public DbSet<City> Cities { get; set; }
    public DbSet<Barangay> Barangays { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        builder.Entity<Barangay>()
            .HasOne(x => x.City)
            .WithMany(x => x.Barangays)
            .OnDelete(DeleteBehavior.Cascade);
    } 
}
