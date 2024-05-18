using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MiPrimeraprueba.Models;

namespace MiPrimeraprueba.Controllers;

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

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }

    public IActionResult StudentList()
    {
        StudentModel alumno = new StudentModel();
        alumno.Nombre = "Oscar Toledo";
        alumno.Carrera = "Ingenieria en Tecnologias de la informacion";
        return View(alumno);
    }

    public IActionResult Profesores()
    {
        return View();
    }

    public IActionResult Carreras()
    {
        return View();
    }

      public IActionResult TeacherList()
    {
        return View();
    }

      public IActionResult DegreeList()
    {
        return View();
    }



}
