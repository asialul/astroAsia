using astroNerds.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace astroNerds.Controllers
{ 
    public class ChartController : Controller
{
    private readonly ILogger<ChartController> _logger;

    public ChartController(ILogger<ChartController> logger)
    {
        _logger = logger;
    }

        public IActionResult Chart()
        {
            return View();
        }

    }
}
