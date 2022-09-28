using ProyectoDW.App_Code.Controller.ControllerPaginasWeb;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProyectoDW.WebForms.Productos.Hombre
{
    public partial class WebHombre : System.Web.UI.Page
    {
        ClsControllerHombre controllerHombre = new ClsControllerHombre();

        protected void Page_Load(object sender, EventArgs e)
        {
            cargarProductos();
        }

        private void cargarProductos()
        {
            if (controllerHombre.getAllProductoHombre())
            {
                contenidoProductos.DataSource = controllerHombre.DsReturn.Tables["Hombre"];
                contenidoProductos.DataBind();
            }
        }
    }
}