using Microsoft.AspNetCore.Mvc;

namespace ImageStore.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class HomeController : ControllerBase
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public int Index()
        {
            return 15;
        }
    }
}
