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

    public IActionResult Login(string email, string contraseña)
    {
        int idd = BD.Login(email, contraseña);
        HttpContext.Session.SetString("id", idd.ToString());
        ViewBag.Id = idd;
        return View("Index");
    }

    public IActionResult SelectIntegrante(int dni)
    {
        int id = int.Parse(HttpContext.Session.GetString("id"));
        ViewBag.Id = id;
        return View("infoDatosPersonales");
    }

    public IActionResult MostrarDatosFamiliares(int dni)
    {
        int id = int.Parse(HttpContext.Session.GetString("id"));
        ViewBag.Id = id;
        return View("infoDatosFamiliares");
    }

    public IActionResult MostrarDatosIntereses(int dni)
    {
        int id = int.Parse(HttpContext.Session.GetString("id"));
        ViewBag.Id = id;
        return View("infoDatosIntereses");
    }
}