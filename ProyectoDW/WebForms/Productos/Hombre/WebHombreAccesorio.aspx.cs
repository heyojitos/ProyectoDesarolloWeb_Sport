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
    public partial class WebHombreAccesorio : System.Web.UI.Page
    {
        ClsControllerHombre controllerHombre = new ClsControllerHombre();
        ClsControllerProducto clsProducto = new ClsControllerProducto();
        ClsCarritoCompra compra;

        protected void Page_Load(object sender, EventArgs e)
        {
            cargarProductos();
        }

        private void cargarProductos()
        {
            if (controllerHombre.getAllProductoHombreAccesorio())
            {
                contenidoProductos.DataSource = controllerHombre.DsReturn.Tables["HombreAccesorio"];
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
                                string StrQry = "<script language='javascript'>";
                                StrQry += "alert('Se agrego correctamente el producto: " + row["PRODUCTO"] + "');";
                                StrQry += "</script>";
                                ClientScript.RegisterStartupScript(GetType(), "mensaje", StrQry, false);
                            }
                            else
                            {
                                string StrQry = "<script language='javascript'>";
                                StrQry += "alert('Error al agregar al carrito'); ";
                                StrQry += "</script>";
                                ClientScript.RegisterStartupScript(GetType(), "mensaje", StrQry, false);
                            }
                        }
                        else
                        {
                            string StrQry = "<script language='javascript'>";
                            StrQry += "alert('Ya existe este producto en el carrito'); ";
                            StrQry += "</script>";
                            ClientScript.RegisterStartupScript(GetType(), "mensaje", StrQry, false);
                        }
                    }
                    catch (Exception ex)
                    {
                        string StrQry = "<script language='javascript'>";
                        StrQry += "alert('Error al agregar al carrito'); ";
                        StrQry += "</script>";
                        ClientScript.RegisterStartupScript(GetType(), "mensaje", StrQry, false);
                    }
                }
            }
        }
    }
}