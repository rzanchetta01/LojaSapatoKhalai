using lojaSapato.Data;
using lojaSapato.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;


namespace lojaSapato.Controllers
{
    public class FornecedorController : Controller
    {

        private AppDbContext db;
        public FornecedorController(AppDbContext db)
        {
            this.db = db;
        }
        public IActionResult Listar()
        {
            IEnumerable<Fornecedor> objList = db.Fornecedores;
            return View(objList);
        }

        [HttpPost]
        public IActionResult CadastrarFornecedor(Fornecedor obj)
        {
            db.Fornecedores.Add(obj);
            db.SaveChanges();
            return RedirectToAction("Listar");
        }

        public IActionResult Cadastrar()
        {
            return View();
        }
    }
}