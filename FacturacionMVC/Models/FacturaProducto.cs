using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FacturacionMVC.Models
{
    public class FacturaProducto
    {

        [Display(Name = "Cantidad")]
        public int cantidad { get; set; }
        [Display(Name = "Precio Unitario")]
        public decimal precioUnitario { get; set; }

         [Key, Column(Order =1)]
        [Display(Name = "Factura")]
        public int? NumeroFactura { get; set; }
        [ForeignKey("NumeroFactura")]
        public virtual Factura NumeroFact { get; set; }



        [Key, Column(Order = 2)]
        [Display(Name = "Producto")]
        public int? CodigoProducto { get; set; }
        [ForeignKey("CodigoProducto")]
        public virtual Producto CodProducto { get; set; }

    }
}
