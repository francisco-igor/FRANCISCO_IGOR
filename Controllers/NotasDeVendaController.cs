#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using FRANCISCO_IGOR.Models;

namespace FRANCISCO_IGOR.Controllers
{
    public class NotasDeVendaController : Controller
    {
        private readonly MyDbContext _context;

        public NotasDeVendaController(MyDbContext context)
        {
            _context = context;
        }

        // GET: NotasDeVenda
        public async Task<IActionResult> Index()
        {
            var myDbContext = _context.NotasDeVenda.Include(n => n.Cliente).Include(n => n.Pagamento).Include(n => n.TipoDePagamento).Include(n => n.Transportadora).Include(n => n.Vendedor);
            return View(await myDbContext.ToListAsync());
        }

        // GET: NotasDeVenda/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var notaDeVenda = await _context.NotasDeVenda
                .Include(n => n.Cliente)
                .Include(n => n.Pagamento)
                .Include(n => n.TipoDePagamento)
                .Include(n => n.Transportadora)
                .Include(n => n.Vendedor)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (notaDeVenda == null)
            {
                return NotFound();
            }

            return View(notaDeVenda);
        }

        // GET: NotasDeVenda/Create
        public IActionResult Create()
        {
            ViewData["ClienteId"] = new SelectList(_context.Clientes, "Id", "Nome");
            ViewData["PagamentoId"] = new SelectList(_context.Pagamentos, "Id", "Id");
            ViewData["TipoDePagamentoId"] = new SelectList(_context.TiposDePagamento, "Id", "Id");
            ViewData["TransportadoraId"] = new SelectList(_context.Transportadoras, "Id", "Nome");
            ViewData["VendedorId"] = new SelectList(_context.Vendedores, "Id", "Nome");
            return View();
        }

        // POST: NotasDeVenda/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Data,Tipo,ClienteId,VendedorId,TransportadoraId,TipoDePagamentoId,PagamentoId")] NotaDeVenda notaDeVenda)
        {
            if (ModelState.IsValid)
            {
                _context.Add(notaDeVenda);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["ClienteId"] = new SelectList(_context.Clientes, "Id", "Nome", notaDeVenda.ClienteId);
            ViewData["PagamentoId"] = new SelectList(_context.Pagamentos, "Id", "Id", notaDeVenda.PagamentoId);
            ViewData["TipoDePagamentoId"] = new SelectList(_context.TiposDePagamento, "Id", "Id", notaDeVenda.TipoDePagamentoId);
            ViewData["TransportadoraId"] = new SelectList(_context.Transportadoras, "Id", "Nome", notaDeVenda.TransportadoraId);
            ViewData["VendedorId"] = new SelectList(_context.Vendedores, "Id", "Nome", notaDeVenda.VendedorId);
            return View(notaDeVenda);
        }

        // GET: NotasDeVenda/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var notaDeVenda = await _context.NotasDeVenda.FindAsync(id);
            if (notaDeVenda == null)
            {
                return NotFound();
            }
            ViewData["ClienteId"] = new SelectList(_context.Clientes, "Id", "Nome", notaDeVenda.ClienteId);
            ViewData["PagamentoId"] = new SelectList(_context.Pagamentos, "Id", "Id", notaDeVenda.PagamentoId);
            ViewData["TipoDePagamentoId"] = new SelectList(_context.TiposDePagamento, "Id", "Id", notaDeVenda.TipoDePagamentoId);
            ViewData["TransportadoraId"] = new SelectList(_context.Transportadoras, "Id", "Nome", notaDeVenda.TransportadoraId);
            ViewData["VendedorId"] = new SelectList(_context.Vendedores, "Id", "Nome", notaDeVenda.VendedorId);
            return View(notaDeVenda);
        }

        // POST: NotasDeVenda/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Data,Tipo,ClienteId,VendedorId,TransportadoraId,TipoDePagamentoId,PagamentoId")] NotaDeVenda notaDeVenda)
        {
            if (id != notaDeVenda.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(notaDeVenda);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!NotaDeVendaExists(notaDeVenda.Id))
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
            ViewData["ClienteId"] = new SelectList(_context.Clientes, "Id", "Nome", notaDeVenda.ClienteId);
            ViewData["PagamentoId"] = new SelectList(_context.Pagamentos, "Id", "Id", notaDeVenda.PagamentoId);
            ViewData["TipoDePagamentoId"] = new SelectList(_context.TiposDePagamento, "Id", "Id", notaDeVenda.TipoDePagamentoId);
            ViewData["TransportadoraId"] = new SelectList(_context.Transportadoras, "Id", "Nome", notaDeVenda.TransportadoraId);
            ViewData["VendedorId"] = new SelectList(_context.Vendedores, "Id", "Nome", notaDeVenda.VendedorId);
            return View(notaDeVenda);
        }

        // GET: NotasDeVenda/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var notaDeVenda = await _context.NotasDeVenda
                .Include(n => n.Cliente)
                .Include(n => n.Pagamento)
                .Include(n => n.TipoDePagamento)
                .Include(n => n.Transportadora)
                .Include(n => n.Vendedor)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (notaDeVenda == null)
            {
                return NotFound();
            }

            return View(notaDeVenda);
        }

        // POST: NotasDeVenda/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var notaDeVenda = await _context.NotasDeVenda.FindAsync(id);
            _context.NotasDeVenda.Remove(notaDeVenda);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool NotaDeVendaExists(int id)
        {
            return _context.NotasDeVenda.Any(e => e.Id == id);
        }

        // GET: NotasDeVendas/Return/5
        public async Task<IActionResult> Return(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var notaDeVenda = await _context.NotasDeVenda.FindAsync(id);

            if (notaDeVenda == null)
            {
                return NotFound();
            }

            notaDeVenda.Tipo = TipoNotaDeVenda.Devolvido;
            _context.Update(notaDeVenda);
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }

        // GET: NotasDeVendas/Cancel/5
        public async Task<IActionResult> Cancel(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var notaDeVenda = await _context.NotasDeVenda.FindAsync(id);

            if (notaDeVenda == null)
            {
                return NotFound();
            }

            notaDeVenda.Tipo = TipoNotaDeVenda.Cancelado;
            _context.Update(notaDeVenda);
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }
    }
}
