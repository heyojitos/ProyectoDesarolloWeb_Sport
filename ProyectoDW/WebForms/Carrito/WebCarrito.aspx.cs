using DXWebApplication.App_Code.Utilidades;
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
        ClsErrorHandler log = new ClsErrorHandler();
        ServiceBanguat.TipoCambioSoapClient wsbanguat = new ServiceBanguat.TipoCambioSoapClient();

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
            var res = wsbanguat.TipoCambioDia();
            idCambioDolar.Text = "Q. " + res.CambioDolar.First().referencia.ToString();
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

            Session["DatosCarro"] = dt;

            idTotal.Text = "Q." + compra.TotalCarro().ToString();
            idTotalUSD.Text = "$. ";
        }      

        protected void gridCarrito_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            try
            {
                int CodigoRegistro = int.Parse(e.Values["ID_DETALLE_REGISTRO"].ToString());
                compra.DeleteRegistro(CodigoRegistro);
                FillData();
                e.Cancel = true;
            }
            catch (Exception ex)
            {
                log.LogError(ex.ToString(), ex.StackTrace);
            }
        }

        protected void txtCantidad_TextChanged(object sender, EventArgs e)
        {
            GridViewRow row = ((TextBox)sender).NamingContainer as GridViewRow;
            TextBox txtCanti = (TextBox)row.FindControl("txtCantidad");

            int codReg = int.Parse(row.Cells[1].Text);
            int can = int.Parse(txtCanti.Text);

            compra.UpdateRegistro(codReg, can);
            FillData();
        }
    }
}