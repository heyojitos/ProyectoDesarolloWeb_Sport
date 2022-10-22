using ProyectoDW.App_Code.Controller.ControllerPaginasWeb;
using ProyectoDW.App_Code.Dao;
using ProyectoDW.App_Code.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Microsoft.AspNet.Identity;
using System.Data;
using DXWebApplication.App_Code.Utilidades;

namespace ProyectoDW.WebForms.Pedido
{
    public partial class WebPedido : System.Web.UI.Page
    {
        ClsControllerPedido controllerPedido = new ClsControllerPedido();
        ClsDetallePedido DetallePedido = new ClsDetallePedido();
        ClsPedido Pedido = new ClsPedido();
        ClsErrorHandler log = new ClsErrorHandler();
        ClsDaoClient objCliente = new ClsDaoClient();
        ClsAspNetUsers aspCliente = new ClsAspNetUsers();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                Session["idCliente"] = User.Identity.GetUserId();
                LlenarDatosCliente();
            }
        }

        private void LlenarDatosCliente()
        {
            try
            {
                String idClienteLogeado = User.Identity.GetUserId();
                objCliente.getUsuarioID(idClienteLogeado);
                if (objCliente.DsReturn.Tables["idCliente"].Rows.Count > 0)
                {
                    int codigoCliente = int.Parse(objCliente.DsReturn.Tables["idCliente"].Rows[0]["Codigo"].ToString());
                    if (objCliente.getClienteXid(codigoCliente))
                    {
                        if (controllerPedido.getPedidosCliente(codigoCliente))
                        {
                            gridPedidos.DataSource = controllerPedido.DsReturn.Tables["PedidoCliente"];
                            gridPedidos.DataBind();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                log.LogError(ex.ToString(), ex.StackTrace);
            }

        }
    }
}