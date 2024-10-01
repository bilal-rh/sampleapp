using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using System.Configuration;
namespace sampleapp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {

        private readonly ILogger<ValuesController> _logger;
        private readonly IOptionsMonitor<ValuesConfiguration> _valuesMonitoredConfiguration;
        private readonly ValuesConfiguration _valuesConfiguration;

        public ValuesController(ILogger<ValuesController> logger, IOptionsMonitor<ValuesConfiguration> valuesMonitoredConfiguration, ValuesConfiguration valuesConfiguration)
        {
            _logger = logger;
            _valuesMonitoredConfiguration = valuesMonitoredConfiguration;
            _valuesConfiguration = valuesConfiguration;
        }
        
    }
}
