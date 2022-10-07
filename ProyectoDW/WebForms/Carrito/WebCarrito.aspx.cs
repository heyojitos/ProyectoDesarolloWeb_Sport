using ProyectoDW.App_Code.Controller.ControllerMantenimiento;
using ProyectoDW.App_Code.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProyectoDW.WebForms.Carrito
{
    public partial class WebCarrito : System.Web.UI.Page
    {
        ClsProducto clsProducto = new ClsProducto();
        ClsControllerProducto clsControllerProducto = new ClsControllerProducto();
        ClsCarritoCompra compra;
        
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["miCarro"] == null)
            {
                Session["miCarro"] = new ClsCarritoCompra();
            }
            compra = (ClsCarritoCompra)Session["miCarro"];
            if (!Page.IsPostBack)
            {
                FillData();
            }            
        }

        public void FillData()
        {
            DataTable dt = compra.TablaCarro();
            DataRow fila;
            foreach (var c in compra.carroItems)
            {
                fila = dt.NewRow();
                fila[0] = c.ID_regitro;
                fila[1] = c.Codigo_producto;
                fila[2] = c.Descripcion_producto;
                fila[3] = c.Imagen;
                fila[4] = c.Precio;
                fila[5] = c.Cantidad;
                fila[6] = c.Subtotal;
                dt.Rows.Add(fila);
            }

            gridCarrito.DataSource = dt;
            gridCarrito.DataBind();

            idTotal.Text = "Q." + compra.TotalCarro().ToString();
        }      

        public void eliminarID_DETALLE_Click(object sender, ImageClickEventArgs e)
        {

        }
    }
}