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
    public class UsuariosController : Controller
    {
        private readonly AplicationDbContext _context;

        public UsuariosController(AplicationDbContext context)
        {
            _context = context;
        }
        [Authorize]
        public IActionResult Index()
        {
            IEnumerable<Usuario> listaUsuarios= _context.TablaUsuarios;
            return View(listaUsuarios);
        }

        public IActionResult Crear()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Crear(Usuario usuario)
        {
            if (ModelState.IsValid)
            {
                _context.TablaUsuarios.Add(usuario);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }

        public IActionResult Editar(int? id)
        {
            //validar si el id tiene valores 
            var usuario = _context.TablaUsuarios.Find(id);
            if (id.HasValue==false)
            {
                return NotFound();

            }
            else
            {
              
                return View(usuario);
            }
        }

        [HttpPost]
        public async Task<IActionResult> Editar(Usuario usuario)
        {
            if (ModelState.IsValid)
            {
                _context.Update(usuario);
                await  _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View();
        }





    }
}
