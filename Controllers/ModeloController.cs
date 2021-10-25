using lojaSapato.Data;
using lojaSapato.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace lojaSapato.Controllers
{
    public class ModeloController : Controller
    {
        private AppDbContext db;
        public ModeloController(AppDbContext db)
        {
            this.db = db;
        }
        public IActionResult Listar()
        {
            IEnumerable<Modelo> objList = db.Modelos;
            return View(objList);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CadastrarModelo(Modelo obj)
        {
            db.Modelos.Add(obj);
            db.SaveChanges();
            return RedirectToAction("Listar");
        }

        public IActionResult Cadastrar()
        {
            return View();
        }
    }
}