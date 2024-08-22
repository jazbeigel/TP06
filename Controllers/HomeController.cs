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

    [HttpPost]
    public IActionResult Index()
    {
        return View("Index");
    }

    public IActionResult Deportes()
    {
<<<<<<< HEAD
        List<Deporte> deportes = BD.ListarDeporte();
        ViewBag.Deportes = deportes;
        return View();
=======
        ViewBag.ListaDeportes = BD.ListarDeportes();
        return View("Deportes");
>>>>>>> a165bd25250c09c6376ca0f0c6218fb6ddcb724e
    }

    public IActionResult Paises()
<<<<<<< HEAD
    { 
        List<Pais> paises = BD.ListarPaises();
        ViewBag.Paises = paises;
        return View();
=======
    {
        ViewBag.ListaPaises = BD.ListarPaises();
        return View("Paises");
>>>>>>> a165bd25250c09c6376ca0f0c6218fb6ddcb724e
    }

    public IActionResult VerDetalleDeporte(int idDeporte)
    {
<<<<<<< HEAD
        Deporte deporte = BD.VerInfoDeporte(idDeporte);
        List<Deportista> deportistas = BD.ListarDeportistas1(idDeporte);
        ViewBag.Deporte = deporte;
        ViewBag.Deporistas = deportistas;
        return View(DetalleDeporte);
=======
        ViewBag.Deporte = BD.VerInfoDeporte(idDeporte);
        ViewBag.Deportistas = BD.ListarDeportistas(idDeporte);
        return View("DetalleDeporte");
>>>>>>> a165bd25250c09c6376ca0f0c6218fb6ddcb724e
    }

    public IActionResult VerDetallePais(int idPais)
    {
<<<<<<< HEAD
        Pais pais = BD.VerInfoDeporte(idPais);
        List<Deportista> deportistas = BD.ListarDeportistas1(idPais);
        ViewBag.Pais = pais;
        ViewBag.Deporistas = deportistas;
        return View(DetallePais);
    }
      public IActionResult VerDetalleDeportista(int idDeportista)
    {
        List<Deportista> deportistas = BD.ListarDeportistas1(idDeportista);
        ViewBag.Deporistas = deportistas;
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
=======
        ViewBag.Pais = BD.VerInfoPais(idPais);
        ViewBag.Deportistas = BD.ListarDeportistas1(idPais);
        return View("DetallePais");
    }
>>>>>>> a165bd25250c09c6376ca0f0c6218fb6ddcb724e

    public IActionResult VerDetalleDeportista(int idDeportista)
    {
        ViewBag.Deportista = BD.VerInfoDeportista(idDeportista);
        return View("DetalleDeportista");
    }

    public IActionResult AgregarDeportista()
    {
        ViewBag.ListaPaises = BD.ListarPaises();
        ViewBag.ListaDeportes = BD.ListarDeportes();
        return View("
