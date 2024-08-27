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
        return View("Index");
    }

    public IActionResult Deportes()
    {
        List<Deporte> deportes = BD.ListarDeporte();
        ViewBag.Deportes = deportes;
        return View();
    }

    public IActionResult Paises()
    { 
        List<Pais> paises = BD.ListarPaises();
        ViewBag.Paises = paises;
        return View();
    
    }

    public IActionResult VerDetalleDeporte(int idDeporte)
    {
        Deporte deporte = BD.VerInfoDeporte(idDeporte);
        List<Deportista> deportistas = BD.ListarDeportistasxDeporte(idDeporte);
        ViewBag.Deporte = deporte;
        ViewBag.Deporistas = deportistas;
        return View("DetalleDeporte");
    }

    public IActionResult VerDetallePais(int idPais)
    {
        Pais pais = BD.VerInfoPais(idPais);
        List<Deportista> deportistas = BD.ListarDeportistasxPais(idPais);
        ViewBag.Pais = pais;
        ViewBag.Deporistas = deportistas;
        return View("VerDetallePais");
    }
      public IActionResult VerDetalleDeportista(int idDeportista)
    {
        Deportista deportistas = BD.VerInfoDeportista(idDeportista);
        ViewBag.Deporistas = deportistas;
        return View("VerDetalleDeportista");
    }
       public IActionResult AgregarDeportista()
    {
        return View("AgregarDeportistas");
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
        return View("Creditos");
    }

    public IActionResult VerDetallesDeportista(int idDeportista)
    {
        ViewBag.Deportista = BD.VerInfoDeportista(idDeportista);
        return View("VerDetalleDeportista");
    }

    public IActionResult AgregarDeportistas()
    {
        ViewBag.ListaPaises = BD.ListarPaises();
        ViewBag.ListaDeportes = BD.ListarDeporte(); 
        return View("VerDetalleDeportista");
    }
}