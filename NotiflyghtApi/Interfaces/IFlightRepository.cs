using NotiflyghtApi.Entity;

namespace NotiflyghtApi.Interfaces;

public interface IFlightRepository
{
    Task<Flight> AddAsync(Flight flight);
}