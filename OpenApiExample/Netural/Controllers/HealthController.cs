namespace AspVersioning.Examples.Netural.Controllers;

using Asp.Versioning;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System;

/// <summary>
/// Netural API controller hidden from OpenApi UI.
/// </summary>
[ApiVersionNeutral]
[ApiExplorerSettings(IgnoreApi = true)]
[Route("api/[controller]")]
public class HealthController : ControllerBase
{
    /// <summary>
    /// Retrieves all orders.
    /// </summary>
    /// <returns>All available orders.</returns>
    /// <response code="200">Orders successfully retrieved.</response>
    [HttpGet]
    [Produces("application/json")]
    [ProducesResponseType(typeof(string), 200)]
    public IActionResult Get()
    {
        return Ok("I am up and running");
    }
}
