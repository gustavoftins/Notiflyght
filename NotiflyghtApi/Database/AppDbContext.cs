using Microsoft.EntityFrameworkCore;
using NotiflyghtApi.Entity;

namespace NotiflyghtApi.Database;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {

    }
    
    public DbSet<FlightSubscription> FlightSubscriptions { get; set; }
}