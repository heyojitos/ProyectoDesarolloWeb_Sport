using DXWebApplication.App_Code.Utilidades;
using ProyectoDW.App_Code.Dao.DaoPaginasWeb;
using ProyectoDW.App_Code.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoDW.App_Code.Controller.ControllerPaginasWeb
{
    public class ClsControllerCarro : ClsController
    {
        ClsErrorHandler log = new ClsErrorHandler();
        ClsDaoCarro clsDaoCarro = new ClsDaoCarro();
    
        public bool InsertarPedido(ClsClient client, List<ClsCarroItem> carroItem, decimal total)
        {
            try
            {
                if (clsDaoCarro.InsertarPedido(client, carroItem, total))
                    return true;
            }
            catch (Exception ex)
            {
                log.LogError(ex.ToString(), ex.StackTrace);
                return false;
            }
            return false;
        }
    }
}