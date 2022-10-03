using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoDW.App_Code.Models
{
    public class ClsCarro
    {
        private int id_regitro;
        private string codigo_producto;
        private string descripcion_producto;
        private int cantidad;
        private decimal subtotal;
        private decimal total;

        public int Id_regitro
        {
            get
            {
                return id_regitro;
            }

            set
            {
                id_regitro = value;
            }
        }

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

        public decimal Total
        {
            get
            {
                return total;
            }

            set
            {
                total = value;
            }
        }
    }
}