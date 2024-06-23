using Microsoft.EntityFrameworkCore;
using TicketSalesNet.Domain.Models;

namespace TicketSalesNet.Infrastructure.Data;

public class TicketSalesNetContext : DbContext
{

    DbSet<User> Users { get; set; }
    DbSet<Event> Events { get; set; }
    DbSet<Ticket> Tickets { get; set; }

    public TicketSalesNetContext() { }
    public TicketSalesNetContext(DbContextOptions<TicketSalesNetContext> options) : base(options) { }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        var connectionString = "Server=localhost;Port=5432;Database=DB_ticketsales;User Id=dev;Password=password01;";
        if (!optionsBuilder.IsConfigured)
        {
            optionsBuilder.UseNpgsql(connectionString);
        }

        base.OnConfiguring(optionsBuilder);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<User>()
            .HasMany(e => e.Events)
            .WithOne(e => e.Company)
            .HasForeignKey(e => e.CompanyId);

        modelBuilder.Entity<User>()
            .HasMany(e => e.Tickets)
            .WithOne(e => e.User)
            .HasForeignKey(e => e.IdUser);

        modelBuilder.Entity<Ticket>()
            .HasOne(e => e.Event)
            .WithMany()
            .HasForeignKey(e => e.IdEvent)
            .IsRequired(false);
    }
}