using CadeteriaWeb.Models;
using Microsoft.AspNetCore.Mvc;

namespace CadeteriaWeb.Controllers
{
    public class CadeteriaController : Controller
    {
        private readonly ILogger<CadeteriaController> _logger;
        private static Cadeteria cadeteria = new Cadeteria("Cadetería Web", "3813005947");

        public CadeteriaController(ILogger<CadeteriaController> logger)
        {
            _logger = logger;

        }
        public IActionResult Index()
        {

            return View(cadeteria.Cadetes);
        }
        [HttpPost]
        public IActionResult Index(Cadete cadete)
        {
            cadeteria.AltaCadete(cadete);
            return View(cadeteria.Cadetes);
        }
        public IActionResult DarAltaCadete()
        {
            return View();
        }
        public IActionResult DarBajaCadete(int id)
        {
            var cadeteADarDeBaja = cadeteria.Cadetes.Find(x => x.Id == id);
            return View(cadeteADarDeBaja);
        }
        public RedirectResult ConfirmarBaja(int id)
        {
            cadeteria.BajaCadete(id);
            return Redirect("Index");
        }
    }
}
