using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoDW.App_Code.Models
{
    public class ClsDetallePedido
    {
        private int idDetallePedido;
        private int idPedido;
        private int idProducto;
        private int cantidad;
        private float subtotal;

        public int IdDetallePedido
        {
            get
            {
                return idDetallePedido;
            }

            set
            {
                idDetallePedido = value;
            }
        }

        public int IdPedido
        {
            get
            {
                return idPedido;
            }

            set
            {
                idPedido = value;
            }
        }

        public int IdProducto
        {
            get
            {
                return idProducto;
            }

            set
            {
                idProducto = value;
            }
        }

        public int Cantidad
        {
            get
            {
                return cantidad;
            }

            set
            {
                cantidad = value;
            }
        }

        public float Subtotal
        {
            get
            {
                return subtotal;
            }

            set
            {
                subtotal = value;
            }
        }
    }
}