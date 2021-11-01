using LojaSapatoKhalai.Data;
using LojaSapatoKhalai.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace LojaSapatoKhalai.Controllers
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