using DXWebApplication.App_Code.Utilidades;
using ProyectoDW.App_Code.Dao.DaoPaginasWeb;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoDW.App_Code.Controller.ControllerPaginasWeb
{
    public class ClsControllerPedido : ClsController
    {
        ClsErrorHandler log = new ClsErrorHandler();
        ClsDaoPedido daoPedido = new ClsDaoPedido();

        public bool getPedidosCliente(int id_client)
        {
            try
            {
                if (daoPedido.getPedidoCliente(id_client))
                {
                    DsReturn = daoPedido.DsReturn;
                    return true;
                }
            }
            catch (Exception ex)
            {
                log.LogError(ex.ToString(), ex.StackTrace);
                //throw;
            }
            return false;
        }

        public bool getDetallePedidoCliente(int id_pedido)
        {
            try
            {
                if (daoPedido.getDetallePedidoCliente(id_pedido))
                {
                    DsReturn = daoPedido.DsReturn;
                    return true;
                }
            }
            catch (Exception ex)
            {
                log.LogError(ex.ToString(), ex.StackTrace);
                //throw;
            }
            return false;
        }
    }
}