using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Siganberg.SirilogElasticSearch.SampleApp.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public Task<AcceptedResult> Index()
        {
            _logger.LogInformation("Test Logging....");
            return Task.FromResult(new AcceptedResult());
        }
    }
}