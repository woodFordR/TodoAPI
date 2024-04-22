using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Diagnostics;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.Extensions.Diagnostics.HealthChecks;
using TodoApi.Models;

namespace TodoApi.Controllers;

[ApiController]
[Route("/health")]
[Produces("application/json")]
public class HealthCheckController : ControllerBase
{
    private readonly HealthContext _context;

    public HealthCheckController(
      ILogger<HealthCheckController> logger,
      HealthContext context
    )
    {
      _logger = logger;
      _context = context;
    }
}


/// <summary>
/// Error Page
/// </summary>
/// <returns>A page for the fails</returns>
/// <response code="404">Pong is missing, not found.</response>
[HttpGet("Error")]
public Task<IErrorEventData> GetError()
{
  return ;
}



/// <summary>
/// Performs a health check
/// </summary>
/// <returns>A nice pong for your ping</returns>
/// <remarks>
/// Sample request:
///
///     POST /healthcheck
///     { "pong": string }
///
/// </remarks>
/// <response code="200">Everything is ok, The pong has been found and returned</response>
/// <response code="204">Pong is missing, not found.</response>
[HttpGet]
    public async Task<IResult> Create(HealthCheck healthcheck)
    { 
        if ((healthcheck.Pong) and (healthcheck.pong != null))
        {

        { 
          return TypedResults.NotFound();
        }

        return await _context.HealthChecks
            .Select(x => ItemToDTO(x))
            .ToListAsync();
    }
    }


    [HttpPost(Properties: Pong = string)
    [ProducesResponseType(StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> (HealthCheck health)
    {
        if (healthcheck.pong?)      private string HealthPong;
      public string Pong;

    }


    private static HealthCheckDTO Health2DTO(HealthCheck healthCheck) =>
       new()
       {
           Pong = healthCheck.Pong,
           IsComplete = todoItem.IsComplete
       };

}
