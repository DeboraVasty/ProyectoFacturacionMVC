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
    [Authorize]
    public class FacturaProductoController : Controller
    {

        private readonly AplicationDbContext _context;

        public FacturaProductoController(AplicationDbContext context)
        {
            _context = context;
        }

        
        public async Task<IActionResult> Index(int? id)
        {
            var aplicationDbContext = _context.TablaFacturaProducto.Where(p => p.NumeroFactura == id).Include(p => p.CodProducto);
            TempData["NoFactura"] = id;
            return View(await aplicationDbContext.ToListAsync());
        }

        public IActionResult Crear(int? id)
        {
            ViewData["productos"] = new SelectList(_context.TablaProducto.Where(p => p.Activo == 'S').ToList(), "CodigoProducto", "Nombre");
            ViewData["precios"] = new SelectList(_context.TablaProducto, "CodigoProducto", "Precio");
            ViewData["existencia"] = new SelectList(_context.TablaProducto, "CodigoProducto", "Existencia");

            TempData["NoFactura"] = id;

            return View();
        }
        [HttpPost]
        public IActionResult Crear(FacturaProducto facturaProducto)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    Producto p = _context.TablaProducto.Find(facturaProducto.CodigoProducto);
                    facturaProducto.precioUnitario = p.Precio; // Le asigna el precio unitario ya que desde la vista lo trae érroneo

                    _context.TablaFacturaProducto.Add(facturaProducto);
                    _context.SaveChanges();

                    // -----------------------------
                    // -Actualizacion de Existencia-
                    // -----------------------------
                    Producto producto = _context.TablaProducto.Find(facturaProducto.CodigoProducto); // Traigo el producto al objeto
                    producto.Existencia = producto.Existencia - facturaProducto.cantidad; // Resto existencia

                    _context.TablaProducto.Update(producto); // Actualizo todo nuevamente
                    _context.SaveChanges(); // Guardo Cambios

                    // ---------------------------------------
                    // -Actualizacion del Total de la Factura-
                    // ---------------------------------------
                    Factura factura = _context.TablaFactura.Find(facturaProducto.NumeroFactura);
                    factura.TotalFactura = factura.TotalFactura + (facturaProducto.precioUnitario * facturaProducto.cantidad);
                    _context.TablaFactura.Update(factura);
                    _context.SaveChanges();


                    TempData["mensaje"] = "La compra se ha añadido correctamente";
                    return RedirectToAction("Index", new { id = facturaProducto.NumeroFactura });
                }
                catch (Exception)
                {
                    return RedirectToAction("Error el producto ya se a comprado", new { idFactura = facturaProducto.NumeroFactura, codigoProducto = facturaProducto.CodigoProducto });
                }


            }

            return View();
        }

        public IActionResult ErrorCompraRealizadaAnteriormente(int idFactura, int codigoProducto)
        {
            TempData["NoFactura"] = idFactura;
            TempData["CodigoProducto"] = codigoProducto;
            return View();
        }

        public IActionResult Editar(int? id, int? codigo_producto)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            var detalle = _context.TablaFacturaProducto.Find(id, codigo_producto);

            if (detalle == null)
            {
                return NotFound();
            }
            TempData["NoFactura"] = id;
            TempData["CodigoProducto"] = codigo_producto;

            Producto p = _context.TablaProducto.Find(detalle.CodigoProducto);

            ViewData["productos"] = new SelectList(_context.TablaProducto.Where(p => p.CodigoProducto == codigo_producto).ToList(), "CodigoProducto", "Nombre");
            TempData["precioUnitario"] = detalle.precioUnitario;
            TempData["existencia"] = p.Existencia + detalle.cantidad;
            return View(detalle);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Editar(FacturaProducto detalleRecibido)
        {
            if (ModelState.IsValid)
            {
                int? IdFactura = detalleRecibido.NumeroFactura;
                int? IdCodigoProducto = detalleRecibido.CodigoProducto;

                var detalleObtenerCosto = await _context.TablaFacturaProducto.AsNoTracking().FirstOrDefaultAsync(x => x.NumeroFactura == IdFactura && x.CodigoProducto == IdCodigoProducto);

                Factura factura = _context.TablaFactura.Find(detalleRecibido.NumeroFactura);
                factura.TotalFactura = factura.TotalFactura - (detalleObtenerCosto.cantidad * detalleObtenerCosto.precioUnitario); // Descontamos el precio anterior
                factura.TotalFactura = factura.TotalFactura + (detalleRecibido.cantidad * detalleRecibido.precioUnitario); // Sumamos la nueva compra

                Producto producto = _context.TablaProducto.Find(detalleRecibido.CodigoProducto);
                producto.Existencia = producto.Existencia + detalleObtenerCosto.cantidad;
                producto.Existencia = producto.Existencia - detalleRecibido.cantidad;

                _context.TablaFacturaProducto.Update(detalleRecibido);
                _context.SaveChanges();

                _context.TablaFactura.Update(factura);
                _context.SaveChanges();

                _context.TablaProducto.Update(producto);
                _context.SaveChanges();



                TempData["mensaje"] = "La Compra se ha actualizado correctamente";

                return RedirectToAction("Index", new { id = detalleRecibido.NumeroFactura });
            }

            return View();
        }

        public IActionResult Eliminar(int? id, int? codigo_producto)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            var detalle = _context.TablaFacturaProducto.Find(id, codigo_producto);

            if (detalle == null)
            {
                return NotFound();
            }

            TempData["NoFactura"] = id;
            TempData["precioUnitario"] = detalle.precioUnitario;
            ViewData["productos"] = new SelectList(_context.TablaProducto.Where(p => p.CodigoProducto == codigo_producto).ToList(), "Codigoproducto", "Nombre");

            return View(detalle);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult ConfirmarEliminar(FacturaProducto detalle)
        {
            if (detalle == null)
            {
                return NotFound();
            }

            Factura factura = _context.TablaFactura.Find(detalle.NumeroFactura);
            factura.TotalFactura = factura.TotalFactura - (detalle.cantidad * detalle.precioUnitario);
            _context.TablaFactura.Update(factura);
            _context.SaveChanges();

            Producto producto = _context.TablaProducto.Find(detalle.CodigoProducto);
            producto.Existencia = producto.Existencia + detalle.cantidad;
            _context.TablaProducto.Update(producto);
            _context.SaveChanges();

            _context.TablaFacturaProducto.Remove(detalle);
            _context.SaveChanges();

            TempData["mensaje"] = "La Compra se ha eliminado correctamente";

            return RedirectToAction("Index", new { id = detalle.NumeroFactura });

        }



    }
}
