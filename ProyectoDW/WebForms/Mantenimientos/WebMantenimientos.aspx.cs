using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProyectoDW.WebForms.Mantenimientos
{
    public partial class WebMantenimientos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnRedirectCategoria_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/WebForms/Mantenimientos/WebCategoria.aspx");
        }

        protected void btnRedirectCliente_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/WebForms/Mantenimientos/WebClientes.aspx");
        }

        protected void btnRedirectProducto_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/WebForms/Mantenimientos/WebProducto.aspx");
        }

    }
}