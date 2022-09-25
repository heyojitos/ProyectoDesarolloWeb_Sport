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

namespace ProyectoDW.WebForms.Mantenimientos
{
    public partial class WebCategoria : System.Web.UI.Page
    {
        ClsErrorHandler log = new ClsErrorHandler();
        ClsControllerCategoria objCategoria = new ClsControllerCategoria();
        ClsCategoria categoria = new ClsCategoria();
        DataSet dsCategoria = new DataSet();

        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (!IsPostBack)
                {
                    cargarGrid();
                }
                else
                {
                    setGrid();
                }
            }
            catch (Exception ex)
            {
                log.LogError(ex.ToString(), ex.StackTrace);
                //throw;
            }
        }

        private void cargarGrid()
        {
            if (objCategoria.GetCategoriaAll())
            {
                dxGridCategoria.DataSource = objCategoria.DsReturn.Tables["Categoria"];
                dxGridCategoria.DataBind();
                Session["Categoria"] = objCategoria.DsReturn;
            }
        }

        private void setGrid()
        {
            dxGridCategoria.DataSource = ((DataSet)Session["Categoria"]);
            dxGridCategoria.DataBind();
        }

        protected void dxGridCategoria_RowInserting(object sender, DevExpress.Web.Data.ASPxDataInsertingEventArgs e)
        {
            try
            {
                categoria.Descripcion = e.NewValues["DESCRIPCION"].ToString();
                if (objCategoria.InsertCategoria(categoria))
                {
                    cargarGrid();
                }
                e.Cancel = true;
                dxGridCategoria.CancelEdit();
            }
            catch (Exception ex)
            {
                log.LogError(ex.ToString(), ex.StackTrace);
                //throw;
            }
        }

        protected void dxGridCategoria_RowUpdating(object sender, DevExpress.Web.Data.ASPxDataUpdatingEventArgs e)
        {
            try
            {
                categoria.IdCategoria = int.Parse(e.NewValues["ID_CATEGORIA"].ToString());
                categoria.Descripcion = e.NewValues["DESCRIPCION"].ToString();
                if (objCategoria.UpdateCategoria(categoria))
                {
                    cargarGrid();
                }
                e.Cancel = true;
                dxGridCategoria.CancelEdit();
            }
            catch (Exception ex)
            {
                log.LogError(ex.ToString(), ex.StackTrace);
                //throw;
            }
        }

        protected void dxGridCategoria_RowDeleting(object sender, DevExpress.Web.Data.ASPxDataDeletingEventArgs e)
        {
            try
            {
                categoria.IdCategoria = int.Parse(e.Values["ID_CATEGORIA"].ToString());
                if (objCategoria.DeleteCategoria(categoria))
                {
                    cargarGrid();
                }
                e.Cancel = true;
                dxGridCategoria.CancelEdit();
            }
            catch (Exception ex)
            {
                log.LogError(ex.ToString(), ex.StackTrace);
                //throw;
            }

        }
    }
}