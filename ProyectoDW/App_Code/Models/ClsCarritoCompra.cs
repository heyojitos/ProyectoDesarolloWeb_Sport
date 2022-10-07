using DXWebApplication.App_Code.Utilidades;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Linq;
using System.Web;

namespace ProyectoDW.App_Code.Models
{
    
    public class ClsCarritoCompra
    {
        ClsErrorHandler log = new ClsErrorHandler();
        public List<ClsCarroItem> carroItems = new List<ClsCarroItem>();

        

        public int IndexRegistro()
        {
            int retornar = 0;
            if (carroItems.Count() == 0)
            {
                retornar = 1;
            }
            else
            {
                retornar = carroItems.Last().ID_regitro + 1;
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


        public bool InsertRegistro(ClsCarroItem item)
        {
            bool bandera = false;
            try
            {
                carroItems.Add(item);
                bandera = true;
            }
            catch (Exception ex)
            {
                log.LogError(ex.ToString(), ex.StackTrace);
                bandera = false;
            }
            return bandera;
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

        public DataTable TablaCarro()
        {
            DataTable dt = new DataTable();
            DataColumn correlativo = dt.Columns.Add("ID_DETALLE_REGISTRO", typeof(int));
            dt.Columns.Add("ID_PRODUCTO", typeof(int));
            dt.Columns.Add("PRODUCTO", typeof(string));
            dt.Columns.Add("IMAGEN", typeof(string));
            dt.Columns.Add("PRECIO", typeof(decimal));
            dt.Columns.Add("CANTIDAD", typeof(int));
            dt.Columns.Add("SUBTOTAL", typeof(decimal));

            //dt.Columns.Add("ELIMINAR", typeof(Button));
            //dt.PrimaryKey = new DataColumn[] { correlativo };
            //correlativo.ReadOnly = true;

            return dt;
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