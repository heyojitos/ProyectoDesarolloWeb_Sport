using ProyectoDW.App_Code.Controller.ControllerPaginasWeb;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProyectoDW.WebForms.Productos.Deporte
{
    public partial class WebDeporteTraining : System.Web.UI.Page
    {
        ClsControllerDeporte controllerProducto = new ClsControllerDeporte();

        protected void Page_Load(object sender, EventArgs e)
        {
            cargarProductos();
        }

        private void cargarProductos()
        {
            if (controllerProducto.getAllProductoDeportesTraining())
            {
                contenidoProductos.DataSource = controllerProducto.DsReturn.Tables["DeporteTraining"];
                contenidoProductos.DataBind();
            }
        }

    }
}