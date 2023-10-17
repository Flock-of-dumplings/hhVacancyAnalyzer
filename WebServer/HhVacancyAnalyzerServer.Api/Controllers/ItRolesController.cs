using HhVacancyAnalyzerServer.Provider.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace HhVacancyAnalyzerServer.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ItRolesController : ControllerBase
{
    private readonly ILogger<ItRolesController> _logger;
    private readonly IItRolesHandlerService _itRolesHandlerService;

    public ItRolesController(ILogger<ItRolesController> logger, IItRolesHandlerService itRolesHandlerService)
    {
        _logger = logger;
        _itRolesHandlerService = itRolesHandlerService;
    }

    /// <summary>
    ///     Get IT roles data
    /// </summary>
    /// <returns>
    ///     IT roles data
    /// </returns>
    /// <response code="200">Success</response>
    /// <response code="400">If error occurs</response>
    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult<string>> GetAll()
    {
        try
        {
            var itRoles = _itRolesHandlerService.GetAllItRoles();
            _logger.LogInformation("IT roles data found, returning ok");
            return Ok(itRoles);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error getting IT roles data");
            return BadRequest(ex.Message);
        }
    }
}