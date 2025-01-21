using Microsoft.AspNetCore.Mvc;
using NotiflyghtApi.Dto;
using NotiflyghtApi.Entity;
using NotiflyghtApi.Interfaces;

namespace NotiflyghtApi.Controller;

[ApiController]
[Route("api/[controller]")]
public class FlightSubscriptionController : ControllerBase
{
    private readonly IFlightRepository _flightRepository;

    public FlightSubscriptionController(IFlightRepository flightRepository)
    {
        _flightRepository = flightRepository;
    }

    [HttpPost]
    public async Task<IActionResult> Post([FromBody] FlightDto flight)
    {
        if (flight.FlightDate < DateTimeOffset.UtcNow)
            return BadRequest();

        if (string.IsNullOrEmpty(flight.FlightNumber))
            return BadRequest();

        if (string.IsNullOrEmpty(flight.NotificationEmail))
            return BadRequest();
        
        await _flightRepository.AddAsync(new Flight(flight.FlightNumber, flight.FlightDate, flight.NotificationEmail));
        
        return Ok();
    }

    [HttpPatch]
    public async Task<IActionResult> Patch([FromBody] Flight flight)
    {
        return Ok();
    }
}