using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SysMiniSuper.API.Data;
using SysMiniSuper.API.Models;

namespace SysMiniSuper.API.Controllers
{
    public class Detalle_VentaController : Controller
    {
        private readonly SysMiniSuperAPIContext _context;

        public Detalle_VentaController(SysMiniSuperAPIContext context)
        {
            _context = context;
        }

        // GET: Detalle_Venta
        public async Task<IActionResult> Index()
        {
            var sysMiniSuperAPIContext = _context.Detalle_Venta.Include(d => d.Cliente).Include(d => d.Producto);
            return View(await sysMiniSuperAPIContext.ToListAsync());
        }

        // GET: Detalle_Venta/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var detalle_Venta = await _context.Detalle_Venta
                .Include(d => d.Cliente)
                .Include(d => d.Producto)
                .FirstOrDefaultAsync(m => m.IdDetalle == id);
            if (detalle_Venta == null)
            {
                return NotFound();
            }

            return View(detalle_Venta);
        }

        // GET: Detalle_Venta/Create
        public IActionResult Create()
        {
            ViewData["IdCliente"] = new SelectList(_context.Cliente, "IdCliente", "IdCliente");
            ViewData["IdProducto"] = new SelectList(_context.Set<Producto>(), "IdProducto", "IdProducto");
            return View();
        }

        // POST: Detalle_Venta/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdDetalle,IdCliente,IdProducto,Cantidad,SubTotal")] Detalle_Venta detalle_Venta)
        {
            if (ModelState.IsValid)
            {
                _context.Add(detalle_Venta);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["IdCliente"] = new SelectList(_context.Cliente, "IdCliente", "IdCliente", detalle_Venta.IdCliente);
            ViewData["IdProducto"] = new SelectList(_context.Set<Producto>(), "IdProducto", "IdProducto", detalle_Venta.IdProducto);
            return View(detalle_Venta);
        }

        // GET: Detalle_Venta/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var detalle_Venta = await _context.Detalle_Venta.FindAsync(id);
            if (detalle_Venta == null)
            {
                return NotFound();
            }
            ViewData["IdCliente"] = new SelectList(_context.Cliente, "IdCliente", "IdCliente", detalle_Venta.IdCliente);
            ViewData["IdProducto"] = new SelectList(_context.Set<Producto>(), "IdProducto", "IdProducto", detalle_Venta.IdProducto);
            return View(detalle_Venta);
        }

        // POST: Detalle_Venta/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdDetalle,IdCliente,IdProducto,Cantidad,SubTotal")] Detalle_Venta detalle_Venta)
        {
            if (id != detalle_Venta.IdDetalle)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(detalle_Venta);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!Detalle_VentaExists(detalle_Venta.IdDetalle))
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
            ViewData["IdCliente"] = new SelectList(_context.Cliente, "IdCliente", "IdCliente", detalle_Venta.IdCliente);
            ViewData["IdProducto"] = new SelectList(_context.Set<Producto>(), "IdProducto", "IdProducto", detalle_Venta.IdProducto);
            return View(detalle_Venta);
        }

        // GET: Detalle_Venta/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var detalle_Venta = await _context.Detalle_Venta
                .Include(d => d.Cliente)
                .Include(d => d.Producto)
                .FirstOrDefaultAsync(m => m.IdDetalle == id);
            if (detalle_Venta == null)
            {
                return NotFound();
            }

            return View(detalle_Venta);
        }

        // POST: Detalle_Venta/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var detalle_Venta = await _context.Detalle_Venta.FindAsync(id);
            if (detalle_Venta != null)
            {
                _context.Detalle_Venta.Remove(detalle_Venta);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool Detalle_VentaExists(int id)
        {
            return _context.Detalle_Venta.Any(e => e.IdDetalle == id);
        }
    }
}
