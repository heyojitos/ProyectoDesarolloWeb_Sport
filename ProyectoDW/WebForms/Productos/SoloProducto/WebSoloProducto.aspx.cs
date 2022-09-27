using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProyectoDW.WebForms.Productos.SoloProducto
{
    public partial class WebSoloProducto : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                if (Request.QueryString["idProducto"] == null) return;
                String id = Request.QueryString["idProducto"].ToString();
                cargarProducto(id);
            }
        }

        private void cargarProducto(String id)
        {

        }
    }
}