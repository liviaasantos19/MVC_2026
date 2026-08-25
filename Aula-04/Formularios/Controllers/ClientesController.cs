using Microsoft.AspNetCore.Mvc;

namespace MVC_2026;

public class ClientesController : Controller
{
    public IActionResult Cadastrar()
    {
        return View();
    }
}
