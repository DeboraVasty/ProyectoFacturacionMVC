using FacturacionMVC.DB;
using FacturacionMVC.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FacturacionMVC.Controllers
{
    public class ProductosController : Controller
    {
        private readonly AplicationDbContext _context;

        public ProductosController(AplicationDbContext context)
        {
            _context = context;
        }
        [Authorize]
        public IActionResult Index()
        {
            IEnumerable<Producto> listaProductos = _context.TablaProducto;
            return View(listaProductos);
        }
        [Authorize]
        public IActionResult Crear()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Crear(Producto producto)
        {
            if (ModelState.IsValid)
            {
                _context.TablaProducto.Add(producto);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }

        [Authorize]
        public IActionResult Editar(int? id)
        {
            //validar si el id tiene valores 
            var producto = _context.TablaProducto.Find(id);
            if (id.HasValue == false)
            {
                return NotFound();

            }
            else
            {

                return View(producto);
            }
        }

        [HttpPost]
        public async Task<IActionResult> Editar(Producto producto)
        {
            if (ModelState.IsValid)
            {
                _context.Update(producto);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View();
        }

        [Authorize]
        public IActionResult Eliminar(int? id)
        {
            //buscar
            var producto = _context.TablaProducto.Find(id);
            //verificar que contenga datos
            if (id.HasValue == false)
            {
                return NotFound();
            }
            else
            {
                return View(producto);

            }

        }


        public async Task<IActionResult> ConfirmacionEliminar(int id)
        {
            try
            {
                var producto = _context.TablaProducto.Find(id);
                _context.TablaProducto.Remove(producto);
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
