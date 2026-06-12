using Microsoft.AspNetCore.Mvc;
using ElZarape.Models;

namespace ElZarape.Controllers
{
    public class SucursalController : Controller
    {
        public static List<Sucursal> sucursales = new();

        public IActionResult Index()
        {
            return View(sucursales);
        }

        [HttpPost]
        public IActionResult Agregar(Sucursal sucursal)
        {
            sucursales.Add(sucursal);

            return RedirectToAction("Index");
        }
    }
}