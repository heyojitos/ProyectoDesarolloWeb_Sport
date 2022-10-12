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

namespace ProyectoDW.WebForms.Productos.Hombre
{
    public partial class WebHombreCalzados : System.Web.UI.Page
    {
        ClsControllerHombre controllerHombre = new ClsControllerHombre();
        ClsControllerProducto clsProducto = new ClsControllerProducto();
        ClsCarritoCompra compra;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["miCarro"] == null)
                {
                    compra = new ClsCarritoCompra();
                    Session["miCarro"] = compra;
                }
                else
                {
                    compra = (ClsCarritoCompra)Session["miCarro"];
                }
                lblIdTotal.Text = "Q." + compra.TotalCarro().ToString();
                lblIdCantidad.Text = " (" + compra.Contador_registros().ToString() + " agregados)";
            }
            cargarProductos();
        }

        private void cargarProductos()
        {
            if (controllerHombre.getAllProductoHombreCalzado())
            {
                contenidoProductos.DataSource = controllerHombre.DsReturn.Tables["HombreCalzado"];
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
                                lblIdTotal.Text = "Q." + compra.TotalCarro().ToString();
                                lblIdCantidad.Text = " (" + compra.Contador_registros().ToString() + " agregados)";
                                string mensaje_alerta = "Se agrego correctamente el producto: " + row["PRODUCTO"] + "";
                                ClientScript.RegisterStartupScript(GetType(), "alerta", "Agregado('" + mensaje_alerta + "')", true);
                            }
                            else
                            {
                                lblIdTotal.Text = "Q." + compra.TotalCarro().ToString();
                                lblIdCantidad.Text = " (" + compra.Contador_registros().ToString() + " agregados)";
                                string mensaje_alerta = "Error al agregar al carrito";
                                ClientScript.RegisterStartupScript(GetType(), "alerta", "Error('" + mensaje_alerta + "')", true);
                            }
                        }
                        else
                        {
                            lblIdTotal.Text = "Q." + compra.TotalCarro().ToString();
                            lblIdCantidad.Text = " (" + compra.Contador_registros().ToString() + " agregados)";
                            string mensaje_alerta = "Ya existe este producto en el carrito";
                            ClientScript.RegisterStartupScript(GetType(), "alerta", "Repite('" + mensaje_alerta + "')", true);
                        }
                    }
                    catch (Exception ex)
                    {
                        lblIdTotal.Text = "Q." + compra.TotalCarro().ToString();
                        lblIdCantidad.Text = " (" + compra.Contador_registros().ToString() + " agregados)";
                        string mensaje_alerta = "No se pudo agregar el producto al carrito";
                        ClientScript.RegisterStartupScript(GetType(), "alerta", "ErrorCatch('" + mensaje_alerta + "')", true);
                    }
                }
            }
        }
    }
}