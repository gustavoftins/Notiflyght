using Microsoft.AspNetCore.Mvc;
using NotiflyghtApi.Dto;
using NotiflyghtApi.Entity;

namespace NotiflyghtApi.Controller;

[ApiController]
[Route("api/[controller]")]
public class FlightSubscriptionController : ControllerBase
{

    [HttpPost]
    public async Task<IActionResult> Post([FromBody] FlightDto flight)
    {
        if (flight.FlightDate < DateTimeOffset.UtcNow)
            return BadRequest();

        if (string.IsNullOrEmpty(flight.FlightNumber))
            return BadRequest();

        if (string.IsNullOrEmpty(flight.NotificationEmail))
            return BadRequest();
        
        return Ok();
    }

    [HttpPatch]
    public async Task<IActionResult> Patch([FromBody] Flight flight)
    {
        return Ok();
    }
}