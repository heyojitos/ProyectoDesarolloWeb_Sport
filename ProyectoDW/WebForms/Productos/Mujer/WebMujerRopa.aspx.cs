using ProyectoDW.App_Code.Controller.ControllerPaginasWeb;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProyectoDW.WebForms.Productos.Mujer
{
    public partial class WebMujerRopa : System.Web.UI.Page
    {
        ClsControllerMujer controllerMujer = new ClsControllerMujer();
        protected void Page_Load(object sender, EventArgs e)
        {
            cargarProductos();
        }

        private void cargarProductos()
        {
            if (controllerMujer.getAllProductoMujerRopa())
            {
                contenidoProductos.DataSource = controllerMujer.DsReturn.Tables["MujerRopa"];
                contenidoProductos.DataBind();
            }
        }
    }
}