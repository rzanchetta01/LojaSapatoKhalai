using lojaSapato.Data;
using lojaSapato.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace lojaSapato.Controllers
{
    public class VendasController : Controller
    {
        private AppDbContext db;
        public VendasController(AppDbContext db)
        {
            this.db = db;
        }
        public IActionResult Listar()
        {
            IEnumerable<Venda> objList = db.Vendas;
            return View(objList);
        }
        public IActionResult FazerVenda()
        {
            return View();
        }

        public IActionResult CadastrarVendas(Venda obj)
        {
            db.Vendas.Add(obj);
            db.SaveChanges();
            return RedirectToAction("Listar");
        }
    }
}