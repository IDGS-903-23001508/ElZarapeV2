using ElZarape.Models;using Microsoft.AspNetCore.Mvc;using Microsoft.AspNetCore.Mvc.Rendering;

namespace ElZarape.Controllers

{

    public class CombosController : Controller    {

        private static List<Combos> combos = new();

        //private static List<Alimento> alimentos = new();

        //private static List<Bebida> bebidas = new();


        public IActionResult Index()

        {

            //ViewBag.Alimentos = new SelectList(alimentos, "idAlimento", "nombre");

            //ViewBag.Bebidas = new SelectList(bebidas, "idBebida", "nombre");


            return View(combos);

        }


        [HttpPost]

        public IActionResult Agregar(Combos combo)

        {

            combo.idCombo = combos.Count + 1;


            combos.Add(combo);


            return RedirectToAction("Index");

        }

    }

}