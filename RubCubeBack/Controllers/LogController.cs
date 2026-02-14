using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RubCubeBack.Application.DTOs.Log;
using RubCubeBack.Application.Interfaces;
using RubCubeBack.Domain.Repositories;

namespace RubCubeBack.Controllers
{
    [ApiController]
    [Authorize]
    [Route("api/[controller]")]
    public class LogController : ControllerBase
    {
        private readonly ILogService _logService;


        public LogController(ILogService logService)
        {
            _logService = logService;
        }

        [HttpGet("GetLogs")]
        [Authorize]
        public async Task<IActionResult> GetLogs([FromQuery] LogsFilterDTO filter, CancellationToken cancellationToken)
        {
             var logs = await _logService.GetLogs(filter, cancellationToken);
            return Ok(logs);
        }

    }
}
