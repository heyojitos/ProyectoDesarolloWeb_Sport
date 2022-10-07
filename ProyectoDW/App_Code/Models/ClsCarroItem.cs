using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoDW.App_Code.Models
{
    public class ClsCarroItem
    {
        private int iD_regitro;
        private string codigo_producto;
        private string descripcion_producto;
        private decimal precio;
        private int cantidad;
        private decimal subtotal;
        private string imagen;       

        public string Codigo_producto
        {
            get
            {
                return codigo_producto;
            }

            set
            {
                codigo_producto = value;
            }
        }

        public string Descripcion_producto
        {
            get
            {
                return descripcion_producto;
            }

            set
            {
                descripcion_producto = value;
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

        public decimal Subtotal
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

        public decimal Precio
        {
            get
            {
                return precio;
            }

            set
            {
                precio = value;
            }
        }

        public int ID_regitro
        {
            get
            {
                return iD_regitro;
            }

            set
            {
                iD_regitro = value;
            }
        }

        public string Imagen
        {
            get
            {
                return imagen;
            }

            set
            {
                imagen = value;
            }
        }

        public ClsCarroItem()
        {

        }
        public ClsCarroItem(int id_registro, string codigo_producto, string descripcion_producto, string imagen, decimal precio, int cantidad, decimal subtotal)
        {
            this.ID_regitro = id_registro;
            this.Codigo_producto = codigo_producto;
            this.Descripcion_producto = descripcion_producto;
            this.Imagen = imagen;
            this.Precio = precio;
            this.Cantidad = cantidad;
            this.Subtotal = subtotal;
        }        
    }
}