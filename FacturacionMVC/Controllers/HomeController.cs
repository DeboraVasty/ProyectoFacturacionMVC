using FacturacionMVC.DB;
using FacturacionMVC.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Claims; 
using System.Threading.Tasks;

namespace FacturacionMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly AplicationDbContext _context;

        public HomeController(AplicationDbContext context)
        {
            _context = context;
        }
        [Authorize]
        public IActionResult Index()
        {
            return View();
        }

       
      


        [HttpGet("Login")]
        public IActionResult Login()
        {

            return View();
        }
        [HttpPost("Login")]
        public async Task<IActionResult> validate(string usuario, string password)
        {
            var val = from a in _context.TablaUsuarios where usuario == a.NUsuario && password == a.Contraseña select a.Nombre;
            if (val.Any()!)
            {
                var claims = new List<Claim>(); // creamos un listado de peticion
                claims.Add(new Claim("username", val.First())); // guardamos el nombre de quien se logea
                claims.Add(new Claim(ClaimTypes.NameIdentifier, val.First())); //guardamos el tipo de peticion 
                var claimIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme); // asignamos esa peticicon a un esquema de cookies
                var claimprincipal = new ClaimsPrincipal(claimIdentity); // la volvemos peticion principal


                await HttpContext.SignInAsync(claimprincipal); // cremos la cookie de autentificacion

                return RedirectToAction("Index", "Home"); // redireccion a un pagina 
            }
            else
            {
                return BadRequest(); // si el usuario no es valido envia un badrequest como respuesta
            }


        }

        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync(); //elimina la cookie creada 
            return RedirectToAction("Index", "Home"); // regresa a una pagina especifica 
        }

        [Authorize]
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

