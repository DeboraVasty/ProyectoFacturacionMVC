using FacturacionMVC.DB;
using FacturacionMVC.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FacturacionMVC.Controllers
{
    public class FacturasController : Controller
    {
        private readonly AplicationDbContext _context;

        public FacturasController(AplicationDbContext context)
        {
            _context = context;
        }

        [Authorize]
        public async Task<IActionResult> Index()
        {
            var aplicationDbContext = _context.TablaFactura.Include(c => c.cliente);

            return View(await aplicationDbContext.ToListAsync());
        }


        public IActionResult Crear()
        {
            ViewData["id"] = new SelectList(_context.TablaCliente, "codigoCliente", "Nombres");
            return View();
        }
        [HttpPost]
        public IActionResult Crear(Factura factura)
        {
            if (ModelState.IsValid)
            {
                _context.TablaFactura.Add(factura);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }


        public IActionResult Editar(int? id)
        {
            //validar si el id tiene valores 
            var factura = _context.TablaFactura.Find(id);
            if (id.HasValue == false)
            {
                return NotFound();

            }
            else
            {
                ViewData["id"] = new SelectList(_context.TablaCliente, "codigoCliente", "Nombres");
              
                return View(factura);
            }
        }

        [HttpPost]
        public async Task<IActionResult> Editar(Factura factura)
        {
            if (ModelState.IsValid)
            {
                _context.Update(factura);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View();
        }

        public IActionResult Eliminar(int? id)
        {
            //buscar
            var factura = _context.TablaFactura.Find(id);
            //verificar que contenga datos
            if (id.HasValue == false)
            {
                return NotFound();
            }
            else
            {
                return View(factura);

            }

        }


        public async Task<IActionResult> ConfirmacionEliminar(int id)
        {
            try
            {
                var factura = _context.TablaFactura.Find(id);
                _context.TablaFactura.Remove(factura);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            catch (Exception e)
            {
                return RedirectToAction("HttpError404", new { error = e });
            }




        }

        public ActionResult HttpError404(Exception error)
        {
            TempData["Error"] = error.Message;
            return View();
        }





    }
}
