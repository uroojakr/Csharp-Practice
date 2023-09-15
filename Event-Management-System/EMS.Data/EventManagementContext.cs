using Event_Management_System.Models;
using Microsoft.EntityFrameworkCore;

public class EventManagementContext : DbContext
{
    readonly string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=master;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";

    public DbSet<Events> Events { get; set; }
    public DbSet<Review> Reviews { get; set; }
    public DbSet<Ticket> Tickets { get; set; }
    public DbSet<User> Users { get; set; }
    public DbSet<Vendor> Vendors { get; set; }
    public DbSet<VendorEvent> VendorEvents { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(connectionString, b => b.MigrationsAssembly("EMSWebApi1"));
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // configure the many-to-many relationship between Vendor and Event through VendorEvent
        modelBuilder.Entity<VendorEvent>()
            .HasKey(ve => new { ve.VendorId, ve.EventId });

        modelBuilder.Entity<VendorEvent>()
            .HasOne(ve => ve.Vendor)
            .WithMany(v => v.VendorEvents)
            .HasForeignKey(ve => ve.VendorId);

        modelBuilder.Entity<VendorEvent>()
            .HasOne(ve => ve.Event)
            .WithMany(e => e.VendorEvents)
            .HasForeignKey(ve => ve.EventId);

        // configure the one-to-many relationship between User and Events (Organizer)
        modelBuilder.Entity<User>()
            .HasMany(u => u.OrganizedEvents)
            .WithOne(e => e.Organizer)
            .HasForeignKey(e => e.OrganizerId)
            .OnDelete(DeleteBehavior.Restrict); // prevent cascade delete

        // configure the one-to-many relationship between Event and Ticket
        modelBuilder.Entity<Ticket>()
            .HasOne(t => t.Event)
            .WithMany(e => e.Tickets)
            .HasForeignKey(t => t.EventId);

        // configure the one-to-many relationship between Event and Review
        modelBuilder.Entity<Review>()
            .HasOne(r => r.Event)
            .WithMany(e => e.Reviews)
            .HasForeignKey(r => r.EventId);

        base.OnModelCreating(modelBuilder);
    }

}
