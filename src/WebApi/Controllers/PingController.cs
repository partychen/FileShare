using Microsoft.AspNetCore.Mvc;
using System;
using System.Reflection;
using System.Threading.Tasks;

namespace WebApi.Controllers
{
    [Route("")]
    [ApiController]
    public class PingController : ControllerBase
    {
        [HttpGet]
        [Route("")]
        [ApiExplorerSettings(IgnoreApi = true)]
        public Task<string> Ping()
        {
            var version = Assembly.GetEntryAssembly()
                                  ?.GetCustomAttribute<AssemblyInformationalVersionAttribute>()
                                  ?.InformationalVersion;
            return Task.FromResult($"File Share Api Version:{version}\nDatetime:{DateTime.UtcNow:o}");
        }
    }
}
