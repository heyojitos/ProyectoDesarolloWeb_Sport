using DXWebApplication.App_Code.Utilidades;
using ProyectoDW.App_Code.Dao.DaoPaginasWeb;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoDW.App_Code.Controller.ControllerPaginasWeb
{
    public class ClsControllerMujer : ClsController
    {
        ClsErrorHandler log = new ClsErrorHandler();
        ClsDaoMujer daoMujer = new ClsDaoMujer();

        public bool getAllProductoMujer()
        {
            try
            {
                if (daoMujer.getProducto_Mujer())
                {
                    DsReturn = daoMujer.DsReturn;
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

        public bool getAllProductoMujerCalzado()
        {
            try
            {
                if (daoMujer.getProducto_Mujer_Calzado())
                {
                    DsReturn = daoMujer.DsReturn;
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

        public bool getAllProductoMujerRopa()
        {
            try
            {
                if (daoMujer.getProducto_Mujer_Ropa())
                {
                    DsReturn = daoMujer.DsReturn;
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

        public bool getAllProductoMujerAccesorio()
        {
            try
            {
                if (daoMujer.getProducto_Mujer_Accesorio())
                {
                    DsReturn = daoMujer.DsReturn;
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