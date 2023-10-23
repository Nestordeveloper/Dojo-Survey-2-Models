using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using DojoSurvey2Model.Models;

namespace DojoSurvey2Model.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    [HttpGet]
    [Route("")]
    public IActionResult Index()
    {
        return View("Index");
    }
    [HttpPost]
    [Route("results")]
    public IActionResult Submission(DojoSurvey survey)
    {
        // Procesa la encuesta y luego pasa el objeto "survey" a la vista "Results"
        return View("Results", survey);
    }


    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
