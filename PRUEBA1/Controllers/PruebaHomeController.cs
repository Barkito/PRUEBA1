using Microsoft.AspNetCore.Mvc;

namespace PRUEBA1.Controllers
{
    public class PruebaHomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
