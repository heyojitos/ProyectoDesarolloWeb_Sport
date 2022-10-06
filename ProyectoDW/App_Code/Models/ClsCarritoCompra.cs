using DXWebApplication.App_Code.Utilidades;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProyectoDW.App_Code.Models
{
    public class ClsCarritoCompra
    {
        ClsErrorHandler log = new ClsErrorHandler();
        private List<ClsCarroItem> carroItems { get; set; }

        public List<ClsCarroItem> GetLista()
        {
            return carroItems = new List<ClsCarroItem>();
        }

        public int IndexRegistro()
        {
            int retornar = 0;
            if (carroItems == null)
            {
                retornar = 1;
            }
            else
            {
                retornar = carroItems.Last().Id_regitro + 1;
            }
            return retornar;
        }

        public bool buscarFilaRepetida(int CodPro)
        {
            bool bandera = true;
            if (carroItems== null)
            {
                bandera = true;
            }
            else
            {
                foreach (ClsCarroItem item in carroItems)
                {
                    if (int.Parse(item.Codigo_producto) == CodPro)
                    {
                        bandera = false;
                    }
                }
            }
            return bandera;
        }


        public void InsertRegistro(ClsCarroItem item)
        {
            try
            {
                carroItems.Add(item);
            }
            catch (Exception ex)
            {
                log.LogError(ex.ToString(), ex.StackTrace);
            }

        }

        public void DeleteRegistro(int filaID)
        {
            carroItems.RemoveAt(filaID);
        }

        public void UpdateRegistro(int filaID, int Cantidad)
        {
            if (Cantidad > 0)
            {
                carroItems[filaID].Cantidad = Cantidad;
            }
            else
            {
                DeleteRegistro(filaID);
            }
        }

        public decimal TotalCarro()
        {
            decimal retornar = 0;
            if (carroItems == null)
            {
                retornar = 0;
            }
            else
            {
                decimal total = 0;
                foreach (ClsCarroItem item in carroItems)
                {
                    total += item.Subtotal;
                }
                retornar = total;
            }
            return retornar;
        }
        /*[Key]
        public int idDetallePedido { get; set; }

        public int idPedido { get; set; }

        public int idProducto { get; set; }

        public int idUsuario { get; set; }

        public virtual ClsProducto producto { get; set; }

        public int cantidad { get; set; }*/

    }
}