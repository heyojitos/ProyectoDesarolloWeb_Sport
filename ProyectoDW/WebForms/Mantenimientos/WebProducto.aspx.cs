using DXWebApplication.App_Code.Utilidades;
using ProyectoDW.App_Code.Controller.ControllerMantenimiento;
using ProyectoDW.App_Code.Models;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace ProyectoDW.WebForms.Mantenimientos
{
    public partial class WebProducto : System.Web.UI.Page
    {
        ClsErrorHandler log = new ClsErrorHandler();
        ClsControllerProducto objProducto = new ClsControllerProducto();
        ClsProducto producto = new ClsProducto();
        DataSet dsProducto = new DataSet();

        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (!IsPostBack)
                {
                    CargarProductos();
                }
                else
                {
                    SetGridProducto();
                }
            }
            catch (Exception ex)
            {
                log.LogError(ex.ToString(), ex.StackTrace);
                //throw;
            }
        }

        private void CargarProductos()
        {
            if (objProducto.GetProductoAll())
            {
                dxGridProducto.DataSource = objProducto.DsReturn.Tables["Producto"];
                dxGridProducto.DataBind();
                Session["Producto"] = objProducto.DsReturn;
            }
        }

        private void SetGridProducto()
        {
            dxGridProducto.DataSource = ((DataSet)Session["Producto"]);
            dxGridProducto.DataBind();
        }

        protected void dxGridProducto_RowInserting(object sender, DevExpress.Web.Data.ASPxDataInsertingEventArgs e)
        {
            try
            {
                producto.Producto = e.NewValues["PRODUCTO"].ToString();
                producto.Descripcion = e.NewValues["DESCRIPCION"].ToString();
                producto.IdCategoria = int.Parse(e.NewValues["ID_CATEGORIA"].ToString());
                producto.Precio = long.Parse(e.NewValues["PRECIO"].ToString());
                producto.Imagen = e.NewValues["IMAGEN"].ToString();
                producto.Stock = int.Parse(e.NewValues["STOCK"].ToString());
                if (objProducto.InsertProducto(producto))
                {
                    CargarProductos();
                }
                e.Cancel = true;
                dxGridProducto.CancelEdit();
            }
            catch (Exception ex) {
                log.LogError(ex.ToString(), ex.StackTrace);
            }
        }

        protected void dxGridProducto_RowUpdating(object sender, DevExpress.Web.Data.ASPxDataUpdatingEventArgs e)
        {
            try
            {
                producto.IdProducto = int.Parse(e.NewValues["ID_PRODUCTO"].ToString());
                producto.Producto = e.NewValues["PRODUCTO"].ToString();
                producto.Descripcion = e.NewValues["DESCRIPCION"].ToString();
                producto.IdCategoria = int.Parse(e.NewValues["ID_CATEGORIA"].ToString());
                producto.Precio = long.Parse(e.NewValues["PRECIO"].ToString());
                producto.Imagen = e.NewValues["IMAGEN"].ToString();
                producto.Stock = int.Parse(e.NewValues["STOCK"].ToString());
                if (objProducto.UpdateProducto(producto))
                {
                    CargarProductos();
                }
                e.Cancel = true;
                dxGridProducto.CancelEdit();
            }
            catch (Exception ex)
            {
                log.LogError(ex.ToString(), ex.StackTrace);
                //throw;
            }
        }

        protected void dxGridProducto_RowDeleting(object sender, DevExpress.Web.Data.ASPxDataDeletingEventArgs e)
        {
            try
            {
                producto.IdProducto = int.Parse(e.Values["ID_PRODUCTO"].ToString());
                
                if (objProducto.DeleteProducto(producto))
                {
                    CargarProductos();
                }
                e.Cancel = true;
                dxGridProducto.CancelEdit();
            }
            catch (Exception ex)
            {
                log.LogError(ex.ToString(), ex.StackTrace);
                //throw;
            }
        }
    }
}