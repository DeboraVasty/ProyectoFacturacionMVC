using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FacturacionMVC.Models
{
    public class ReporteFacturas
    {
        [Display(Name = "Fecha")]
        public DateTime Dia { get; set; }

        [Display(Name = "Cantidad de Facturas")]
        public int cantidadFacturas { get; set; }

        [Key, Column(Order = 1)]
        [Display(Name = "Monto Facturado")]
        public decimal montoFacturado { get; set; }

        [Display(Name = " Productos Vendidos")]
        public int cantidadProductos { get; set; }
    }
}
