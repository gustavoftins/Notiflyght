using Microsoft.EntityFrameworkCore;
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
        var existingFlight = await _context.Flight.Include(f => f.NotificationEmails).FirstOrDefaultAsync(x => x.FlightNumber == flight.FlightNumber && x.FlightDate == flight.FlightDate);

        if (existingFlight != null)
        {
            var emails = existingFlight.NotificationEmails.Concat(flight.NotificationEmails);
            existingFlight.NotificationEmails = emails.ToList();
            _context.Update(existingFlight);

            await _context.SaveChangesAsync();
            return flight;
        }
        
        _context.Flight.Add(flight);

        await _context.SaveChangesAsync();
        
        return flight;
    }
}