using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TP06.Models;

namespace TP06.Controllers;

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

      public IActionResult Deportes()
    {
        ViewBag.List<Deporte>;
        return View(Deportes);
    }
    public IActionResult Paises()
    {
        ViewBag.List<Pais>;
        return View(Paises);
    }
    public IActionResult VerDetalleDeporte(int idDeporte)
    {
        ViewBag.Deporte = BD.VerInfoDeporte(idDeporte);
        ViewBag.Deporistas = BD.ListarDeportistas(idDeporte);
        return View(DetalleDeporte);
    }
    public IActionResult VerDetallePais(int idPais)
    {
        ViewBag.Pais = BD.VerInfoPais(idPais);
        ViewBag.Deporistas = BD.ListarDeportistas1(idPais);
        return View(DetallePais);
    }
      public IActionResult VerDetalleDeportista(int idDeportista)
    {
        ViewBag.Deportistas = BD.VerInfoDeportista;
        return View(DetalleDeportista);
    }
       public IActionResult AgregarDeportista()
    {
        return View(AgregarDeportistas);
    }
    [HttpPost]
    public IActionResult GuardarDeportista(Deportista dep)
    {
        return View(Index);
    }
    public IActionResult EliminarDeportista(int idCandidato)
    {
        return View(Index);
    }
     public IActionResult Creditos()
    {
        return View(Creditos);
    }
}


