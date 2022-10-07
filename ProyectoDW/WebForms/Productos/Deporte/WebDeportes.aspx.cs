using ProyectoDW.App_Code.Controller.ControllerMantenimiento;
using ProyectoDW.App_Code.Controller.ControllerPaginasWeb;
using ProyectoDW.App_Code.Dao.DaoPaginasWeb;
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
    public partial class WebDeportes : System.Web.UI.Page
    {

        ClsProducto producto = new ClsProducto();
        ClsControllerDeporte controllerProducto = new ClsControllerDeporte();
        ClsControllerProducto clsProducto = new ClsControllerProducto();
        ClsCarritoCompra compra;

        protected void Page_Load(object sender, EventArgs e)
        {
            cargarProductos();
        }



        private void cargarProductos()
        {
            if (controllerProducto.getAllProductoDeportes())
            {
                contenidoProductos.DataSource = controllerProducto.DsReturn.Tables["Deporte"];
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
                    DataTable dt1 = clsProducto.DsReturn.Tables["BuscarProducto"];
                    //DataTable dt2 = compra.TablaCarro();
                    DataRow row = dt1.Rows[0];
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
                                StrQry += "alert('Se agrego correctamente el producto: " + row["PRODUCTO"] + " al carrito');";
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