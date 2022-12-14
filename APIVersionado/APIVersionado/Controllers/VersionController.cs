using APIVersionado.DTOs;
using APIVersionado.Services;
using Microsoft.AspNetCore.Mvc;

namespace APIVersionado.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VersionController : ControllerBase
    {
        private readonly AppVersionManager configuration;

        public VersionController(AppVersionManager configuration)
        {
            this.configuration = configuration;
        }

        [HttpGet(Name = "GetVersion")]
        public IActionResult GetVersion()
        {
            return Ok(new AppVersionDTO(this.configuration.GetVersion()));
        }
    }
}
