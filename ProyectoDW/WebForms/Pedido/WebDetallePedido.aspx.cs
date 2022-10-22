using ProyectoDW.App_Code.Controller.ControllerPaginasWeb;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProyectoDW.WebForms.Pedido
{
    public partial class WebDetallePedido : System.Web.UI.Page
    {
        ClsControllerPedido controllerPedido = new ClsControllerPedido();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                if (Request.QueryString["codPed"] == null) return;
                String id = Request.QueryString["codPed"].ToString();
                Session["InfoDetalle"] = null;
                int id_pedido = int.Parse(id);
                LlenarDatosPedido(id_pedido);
            }
            else
            {
                SetDatosPedido();
            }
        }

        private void SetDatosPedido()
        {
            gridDetallePedidos.DataSource = ((DataSet)Session["InfoDetalle"]);
            gridDetallePedidos.DataBind();
        }

        private void LlenarDatosPedido(int id_pedido)
        {
            if (controllerPedido.getDetallePedidoCliente(id_pedido))
            {
                gridDetallePedidos.DataSource = controllerPedido.DsReturn.Tables["DetallePedidoCliente"];
                gridDetallePedidos.DataBind();
                Session["InfoDetalle"] = controllerPedido.DsReturn;
            }
        }
    }
}