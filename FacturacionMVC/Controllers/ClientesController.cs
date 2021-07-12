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
    public class ClientesController : Controller
    {
        private readonly AplicationDbContext _context;

        public ClientesController(AplicationDbContext context)
        {
            _context = context;
        }
        [Authorize]
        public IActionResult Index()
        {
            IEnumerable<Cliente> listaClientes = _context.TablaCliente;
            return View(listaClientes);
        }


        public IActionResult Crear()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Crear(Cliente cliente)
        {
            if (ModelState.IsValid)
            {
                _context.TablaCliente.Add(cliente);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }

        public IActionResult Editar(int? id)
        {
            //validar si el id tiene valores 
            var cliente = _context.TablaCliente.Find(id);
            if (id.HasValue == false)
            {
                return NotFound();

            }
            else
            {

                return View(cliente);
            }
        }

        [HttpPost]
        public async Task<IActionResult> Editar(Cliente cliente)
        {
            if (ModelState.IsValid)
            {
                _context.Update(cliente);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View();
        }

        public IActionResult Eliminar(int? id)
        {
            //buscar
            var cliente = _context.TablaCliente.Find(id);
            //verificar que contenga datos
            if (id.HasValue == false)
            {
                return NotFound();
            }
            else
            {
                return View(cliente);

            }

        }


        public async Task<IActionResult> ConfirmacionEliminar(int id)
        {
            try
            {
                var cliente = _context.TablaCliente.Find(id);
                _context.TablaCliente.Remove(cliente);
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
