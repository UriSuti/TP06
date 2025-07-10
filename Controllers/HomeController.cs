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

    public IActionResult Reiniciar()
    {
        HttpContext.Session.Remove("id");
        return RedirectToAction(Index);
    }

    [HttpPost]
    public IActionResult Login(string email, string contraseña)
    {
        int idd = BD.Login(email, contraseña);
        HttpContext.Session.SetString("id", idd.ToString());
        ViewBag.Id = idd;
        return View("Index2");
    }

    public IActionResult Index2()
    {
        int id = int.Parse(HttpContext.Session.GetString("id"));
        ViewBag.Id = id;
        return View();
    }

    public IActionResult SelectIntegrante()
    {
        int id = int.Parse(HttpContext.Session.GetString("id"));
        ViewBag.Id = id;
        return View("infoDatosPersonales");
    }

    public IActionResult MostrarDatosFamiliares()
    {
        int id = int.Parse(HttpContext.Session.GetString("id"));
        ViewBag.Id = id;
        return View("infoDatosFamiliares");
    }

    public IActionResult MostrarDatosIntereses()
    {
        int id = int.Parse(HttpContext.Session.GetString("id"));
        ViewBag.Id = id;
        return View("infoDatosIntereses");
    }
}