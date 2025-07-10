using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TP02.Models;

namespace TP02.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult SelectIntegrante(int dni)
    {
        return View("infoDatosPersonales");
    }

    public IActionResult MostrarDatosFamiliares(int dni)
    {
        return View("infoDatosFamiliares");
    }

    public IActionResult MostrarDatosIntereses(int dni)
    {
        return View("infoDatosIntereses");
    }
}