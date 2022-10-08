using ProyectoDW.App_Code.Controller.ControllerMantenimiento;
using ProyectoDW.App_Code.Controller.ControllerPaginasWeb;
using ProyectoDW.App_Code.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProyectoDW.WebForms.Productos.Deporte
{
    public partial class WebDeporteRunning : System.Web.UI.Page
    {
        ClsControllerDeporte controllerProducto = new ClsControllerDeporte();
        ClsControllerProducto clsProducto = new ClsControllerProducto();
        ClsCarritoCompra compra;
        protected void Page_Load(object sender, EventArgs e)
        {
            cargarProductos();
        }

        private void cargarProductos()
        {
            if (controllerProducto.getAllProductoDeportesRunning())
            {
                contenidoProductos.DataSource = controllerProducto.DsReturn.Tables["DeporteRunning"];
                contenidoProductos.DataBind();
            }
        }

        protected void contenidoProductos_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            if (e.CommandName == "Agregar")
            {
                int idPro = int.Parse(e.CommandArgument.ToString());
                if (Session["miCarro"] == null)
                {
                    compra = new ClsCarritoCompra();
                    Session["miCarro"] = compra;
                }
                if (clsProducto.Buscar_Producto(idPro.ToString()))
                {
                    compra = (ClsCarritoCompra)Session["miCarro"];
                    DataTable dt = clsProducto.DsReturn.Tables["BuscarProducto"];
                    DataRow row = dt.Rows[0];
                    int idRegistro = compra.IndexRegistro();
                    int pro = int.Parse(row["ID_PRODUCTO"].ToString());
                    try
                    {
                        if (compra.buscarFilaRepetida(pro))
                        {
                            if (compra.InsertRegistro(new ClsCarroItem(idRegistro, row["ID_PRODUCTO"].ToString(), row["PRODUCTO"].ToString(), row["IMAGEN"].ToString(),
                                decimal.Parse(row["PRECIO"].ToString()), 1, decimal.Parse(row["PRECIO"].ToString()))))
                            {
                                string mensaje_alerta = "swal('Se agrego correctamente el producto: " + row["PRODUCTO"] + "','success')";
                                ClientScript.RegisterClientScriptBlock(this.GetType(), "alerta", mensaje_alerta, true);
                            }
                            else
                            {
                                string mensaje_alerta = "swal('Error al agregar al carrito','warning')";
                                ClientScript.RegisterClientScriptBlock(this.GetType(), "alerta", mensaje_alerta, true);
                            }
                        }
                        else
                        {
                            string mensaje_alerta = "swal('Ya existe este producto en el carrito','info')";
                            ClientScript.RegisterClientScriptBlock(this.GetType(), "alerta", mensaje_alerta, true);
                        }
                    }
                    catch (Exception ex)
                    {
                        string mensaje_alerta = "swal('Ya existe este producto en el carrito','info')";
                        ClientScript.RegisterClientScriptBlock(this.GetType(), "alerta", mensaje_alerta, true);
                    }
                }
            }
        }
    }
}