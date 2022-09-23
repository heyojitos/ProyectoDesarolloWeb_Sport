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
    public partial class WebClientes : System.Web.UI.Page
    {
        ClsErrorHandler log = new ClsErrorHandler();
        ClsControllerUsuario objUsuario = new ClsControllerUsuario();
        ClsUsuario usuario = new ClsUsuario();
        DataSet dsUsuario = new DataSet();

        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (!IsPostBack)
                {
                    CargarGrid();
                }
                else
                {
                    SetGrid();
                }
            }
            catch (Exception ex)
            {
                log.LogError(ex.ToString(), ex.StackTrace);
                //throw;
            }
        }

        public void CargarGrid()
        {
            if (objUsuario.GetClienteAll())
            {
                dxGridUsuario.DataSource = objUsuario.DsReturn.Tables["Usuario"];
                dxGridUsuario.DataBind();
                Session["Usuario"] = objUsuario.DsReturn;
            }
        }

        public void SetGrid()
        {
            dxGridUsuario.DataSource = ((DataSet)Session["Usuario"]);
            dxGridUsuario.DataBind();
        }

        protected void dxGridUsuario_RowInserting(object sender, DevExpress.Web.Data.ASPxDataInsertingEventArgs e)
        {
            try
            {
                usuario.Nombre = e.NewValues["NOMBRE"].ToString();
                usuario.Apellido = e.NewValues["APELLIDO"].ToString();
                usuario.Email = e.NewValues["EMAIL"].ToString();
                usuario.Password = e.NewValues["PASSWORD"].ToString();
                if (objUsuario.InsertCliente(usuario))
                {
                    CargarGrid();
                }
                e.Cancel = true;
                dxGridUsuario.CancelEdit();
            }
            catch (Exception ex)
            {
                log.LogError(ex.ToString(), ex.StackTrace);
                //throw;
            }

        }

        protected void dxGridUsuario_RowUpdating(object sender, DevExpress.Web.Data.ASPxDataUpdatingEventArgs e)
        {
            try
            {
                usuario.IdUsuario = int.Parse(e.NewValues["ID_USUARIO"].ToString());
                usuario.Nombre = e.NewValues["NOMBRE"].ToString();
                usuario.Apellido = e.NewValues["APELLIDO"].ToString();
                usuario.Email = e.NewValues["EMAIL"].ToString();
                usuario.Password = e.NewValues["PASSWORD"].ToString();
                if (objUsuario.UpdateCliente(usuario))
                {
                    CargarGrid();
                }
                e.Cancel = true;
                dxGridUsuario.CancelEdit();
            }
            catch (Exception ex)
            {
                log.LogError(ex.ToString(), ex.StackTrace);
                //throw;
            }
        }

        protected void dxGridUsuario_RowDeleting(object sender, DevExpress.Web.Data.ASPxDataDeletingEventArgs e)
        {
            try
            {
                usuario.IdUsuario = int.Parse(e.Values["ID_USUARIO"].ToString());
                if (objUsuario.DeleteCliente(usuario))
                {
                    CargarGrid();
                }
                e.Cancel = true;
                dxGridUsuario.CancelEdit();
            }
            catch (Exception ex)
            {
                log.LogError(ex.ToString(), ex.StackTrace);
                //throw;
            }
        }
    }
}