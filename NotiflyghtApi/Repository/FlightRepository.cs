using NotiflyghtApi.Database;
using NotiflyghtApi.Entity;
using NotiflyghtApi.Interfaces;

namespace NotiflyghtApi.Repository;

public class FlightRepository : IFlightRepository
{
    private readonly AppDbContext _context;

    public FlightRepository(AppDbContext context)
    {
        _context = context;
    }

    public async Task<Flight> AddAsync(Flight flight)
    {
        _context.Flight.Add(flight);

        await _context.SaveChangesAsync();
        
        return flight;
    }
}