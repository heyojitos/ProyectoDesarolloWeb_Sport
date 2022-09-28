using ProyectoDW.App_Code.Controller.ControllerPaginasWeb;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProyectoDW.WebForms.Productos.Deporte
{
    public partial class WebDeporteRunning : System.Web.UI.Page
    {
        ClsControllerDeporte controllerProducto = new ClsControllerDeporte();
        protected void Page_Load(object sender, EventArgs e)
        {
            cargarProductos();
        }

        private void cargarProductos()
        {
            if (controllerProducto.getAllProductoDeportesRunning())
            {
                contenidoProductos.DataSource = controllerProducto.DsReturn.Tables["DeporteRunning"];
                contenidoProductos.DataBind();
            }
        }
    }
}