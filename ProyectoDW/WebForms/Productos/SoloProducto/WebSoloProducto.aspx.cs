using ProyectoDW.App_Code.Controller.ControllerPaginasWeb;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProyectoDW.WebForms.Productos.SoloProducto
{
    public partial class WebSoloProducto : System.Web.UI.Page
    {
        ClsControllerSolo controllerSolo = new ClsControllerSolo();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                if (Request.QueryString["idProducto"] == null) return;
                String id = Request.QueryString["idProducto"].ToString();
                Session["InfoProducto"]= null;
                cargarProducto(id);
            }
            else
            {
                setProducto();
            }
        }

        private void cargarProducto(String id)
        {
            if (controllerSolo.getProducto(id))
            {
                dtlistSolo.DataSource = controllerSolo.DsReturn.Tables["MostrarProducto"];
                dtlistSolo.DataBind();
                Session["InfoProducto"] = controllerSolo.DsReturn;
            }
        }

        private void setProducto()
        {
            dtlistSolo.DataSource = ((DataSet)Session["InfoProducto"]);
            dtlistSolo.DataBind();
        }
    }
}