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
        Grupo.inicializarGrupo();
        Dictionary<int, Integrante> integrantes = Grupo.integrantes;
        ViewBag.Integrantes = integrantes;
        return View();
    }

    public IActionResult SelectIntegrante(int dni)
    {
        DatoPersonal datosPersonales = Grupo.integrantes[dni].datosPersonales;
        ViewBag.DatosPersonales = datosPersonales;
        ViewBag.Dni = dni;
        return View("infoDatosPersonales");
    }

    public IActionResult MostrarDatosFamiliares(int dni)
    {
        List<DatoFamiliar> datosFamiliares = Grupo.integrantes[dni].datosFamiliares;
        ViewBag.DatosFamiliares = datosFamiliares;
        return View("infoDatosFamiliares");
    }

    public IActionResult MostrarDatosIntereses(int dni)
    {
        DatosInteres datosInteres = Grupo.integrantes[dni].datosIntereses;
        ViewBag.DatosInteres = datosInteres;
        return View("infoDatosIntereses");
    }
}