using ElZarape.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
namespace ElZarape.Controllers
{
    public class CategoriaController : Controller
    {
        private static List<Categoria> categorias = new();

        public IActionResult Index() {
            return View(categorias);
        }

        [HttpPost]

        public IActionResult Agregar(Categoria categoria) {
            categoria.idCategoria = categorias.Count + 1;
            categorias.Add(categoria);
            return RedirectToAction("Index");
        }

    }
}
