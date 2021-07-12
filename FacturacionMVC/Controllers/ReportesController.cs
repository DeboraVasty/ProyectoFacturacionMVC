using FacturacionMVC.DB;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FacturacionMVC.Controllers
{
    [Authorize]
    public class ReportesController : Controller
    {
        private readonly AplicationDbContext _context;

        public ReportesController(AplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

       

        public async Task<IActionResult> ReporteFacturasAsync(int? todos, string fechaInicio, string fechaFinal)
        {
            if (todos == 0 && fechaInicio == null && fechaFinal == null)
            {
                var listado = await _context.ReporteFacturas.FromSqlRaw("ReporteFacturas").ToListAsync();

                return View(listado);
            }

            if (todos == null && fechaInicio != null && fechaFinal != null)
            {
                List<SqlParameter> parameters = new List<SqlParameter>
                    {
                       new SqlParameter("@FechaInicio", fechaInicio),
                       new SqlParameter("@FechaFinal", fechaFinal)
                    };

                var listado = await _context.ReporteFacturas.FromSqlRaw("ReporteFechaFacturas @FechaInicio, @FechaFinal", parameters.ToArray()).ToListAsync();

                return View(listado);
            }


            return NotFound();

        }
    }
}
