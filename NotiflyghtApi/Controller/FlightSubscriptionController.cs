using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using NotiflyghtApi.Entity;

namespace NotiflyghtApi.Controller;

[ApiController]
[Route("api/[controller]")]
public class FlightSubscriptionController : ControllerBase
{

    [HttpPost]
    public async Task<IActionResult> Post([FromBody] Flight flight)
    {
        return Ok();
    }

    [HttpPatch]
    public async Task<IActionResult> Patch([FromBody] Flight flight)
    {
        return Ok();
    }
}