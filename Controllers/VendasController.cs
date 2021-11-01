using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using lojaSapato.Data;
using lojaSapato.Models;
using lojaSapato.Models.ViewModels;

namespace LojaSapatoKhalai.Controllers
{
    public class VendasController : Controller
    {        
        private readonly AppDbContext _context;

        public VendasController(AppDbContext context)
        {
            _context = context;
        }        
        // GET: Vendas
        public async Task<List<HistoricoVendaViewModel>> getHistoricoVendas()
        {
            List<HistoricoVendaViewModel> hvvms = new();
                       
            var venda = await _context.Vendas.ToListAsync();

            foreach (var e in venda)
            {
                var modelo = await _context.Modelos.FirstOrDefaultAsync(m => m.Id == e.idModelo);
                var fornecedore = await _context.Fornecedores.FirstOrDefaultAsync(f => f.Id == modelo.IdFornecedor);
                var categoria = await _context.Categorias.FirstOrDefaultAsync(c => c.Id == modelo.IdCategoria);
                HistoricoVendaViewModel hvvm = new();

                hvvm.NomeModelo = modelo.Nome;
                hvvm.NomeFornecedor = fornecedore.Nome;
                hvvm.PrecoModelo = modelo.Preco;
                hvvm.Quantidade = e.Quantidade;
                hvvm.Categoria = categoria.Nome;
                hvvm.PrecoCompra = modelo.Preco * e.Quantidade;
                hvvm.DataVenda = e.DtVenda;
                hvvm.id = e.Id;
                hvvms.Add(hvvm);
            }

            return hvvms;
        }


        // GET:Historico Vendas
        public async Task<IActionResult> Index()
        {           
            var x = await getHistoricoVendas();
            return View(x.ToList());
        }
     
        // GET: Vendas/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var venda = await _context.Vendas
                .FirstOrDefaultAsync(m => m.Id == id);
            if (venda == null)
            {
                return NotFound();
            }

            return View(venda);
        }

        // GET: Vendas/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Vendas/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,idModelo,idCliente,Quantidade,DtVenda")] Venda venda)
        {
            if (ModelState.IsValid)
            {
                _context.Add(venda);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(venda);
        }

        // GET: Vendas/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var venda = await _context.Vendas.FindAsync(id);
            if (venda == null)
            {
                return NotFound();
            }
            return View(venda);
        }

        // POST: Vendas/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,idModelo,idCliente,Quantidade,DtVenda")] Venda venda)
        {
            if (id != venda.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(venda);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!VendaExists(venda.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(venda);
        }

        // GET: Vendas/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var venda = await _context.Vendas
                .FirstOrDefaultAsync(m => m.Id == id);
            if (venda == null)
            {
                return NotFound();
            }

            return View(venda);
        }

        // POST: Vendas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var venda = await _context.Vendas.FindAsync(id);
            _context.Vendas.Remove(venda);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool VendaExists(int id)
        {
            return _context.Vendas.Any(e => e.Id == id);
        }
    }
}
