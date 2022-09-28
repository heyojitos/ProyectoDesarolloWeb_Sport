using DXWebApplication.App_Code.Utilidades;
using ProyectoDW.App_Code.Dao.DaoPaginasWeb;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoDW.App_Code.Controller.ControllerPaginasWeb
{
    public class ClsControllerSolo : ClsController
    {
        ClsErrorHandler log = new ClsErrorHandler();
        ClsDaoSolo daoSolo = new ClsDaoSolo();

        public bool getProducto(String id)
        {
            try
            {
                if (daoSolo.getProducto_Id(id))
                {
                    DsReturn = daoSolo.DsReturn;
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