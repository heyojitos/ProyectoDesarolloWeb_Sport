using ProyectoDW.App_Code.Controller.ControllerPaginasWeb;
using ProyectoDW.App_Code.Dao.DaoPaginasWeb;
using ProyectoDW.App_Code.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProyectoDW.WebForms.Productos.Deporte
{
    public partial class WebDeportes : System.Web.UI.Page
    {
        
        ClsProducto producto = new ClsProducto();
        ClsControllerDeporte controllerProducto = new ClsControllerDeporte();

        protected void Page_Load(object sender, EventArgs e)
        {
            cargarProductos();
        }

        private void cargarProductos()
        {
            if (controllerProducto.getAllProductoDeportes())
            {
                contenidoProductos.DataSource = controllerProducto.DsReturn.Tables["Deporte"];
                contenidoProductos.DataBind();
            }
        }
    }
}