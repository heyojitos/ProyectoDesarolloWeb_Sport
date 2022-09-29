using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProyectoDW.App_Code.Models
{
    public class ClsCarritoCompra
    {
        [Key]
        public int idDetallePedido { get; set; }

        public int idPedido { get; set; }

        public int idProducto { get; set; }

        public int idUsuario { get; set; }

        public virtual ClsProducto producto { get; set; }

        public int cantidad { get; set; }

    }
}