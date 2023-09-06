using Microsoft.AspNetCore.Mvc;

namespace SenaiAlimentos.Controllers;

public class NivelController : Controller
{  
    public IActionResult Index()
    {
        ViewData["titulo"] ="Cadastro de Niveis";
        return View();
    }
}