using ElZarape.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
namespace ElZarape.Controllers
{
    public class UsuarioController : Controller
    {
        private static List<Usuario> usuarios = new();

        public IActionResult Index() {
            return View(usuarios);
        }

        [HttpPost]

        public IActionResult Agregar(Usuario usuario) {
            usuario.idUsuario = usuarios.Count + 1;
            usuarios.Add(usuario);
            return RedirectToAction("Index");
        }

    }
}
