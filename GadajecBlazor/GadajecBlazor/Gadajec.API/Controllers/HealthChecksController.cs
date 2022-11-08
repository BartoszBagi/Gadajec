using Gadajec.API.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;


namespace Gadajec.API.Controllers
{
    [ApiController]
    [Route("api/hc")]
    public class HealthChecksController : ControllerBase
    {
        public HealthChecksController()
        {

        }

        [HttpGet("/hc")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status403Forbidden, Type = typeof(ErrorModel))]
        public async Task<ActionResult<string>> GetAsync()
        {
            return "Healthy";
        }
    }
}
