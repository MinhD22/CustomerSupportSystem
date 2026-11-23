
using Microsoft.EntityFrameworkCore;
using SupportAPI.Models;

namespace SupportAPI.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }

    public DbSet<User> Users { get; set; }

    public DbSet<Ticket> Tickets { get; set; }
    
    public DbSet<TicketHistory> TicketHistories { get; set; }
}
