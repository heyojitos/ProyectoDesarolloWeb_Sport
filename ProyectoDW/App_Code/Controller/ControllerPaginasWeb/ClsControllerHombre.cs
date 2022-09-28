using DXWebApplication.App_Code.Utilidades;
using ProyectoDW.App_Code.Dao.DaoPaginasWeb;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoDW.App_Code.Controller.ControllerPaginasWeb
{
    public class ClsControllerHombre : ClsController
    {
        ClsErrorHandler log = new ClsErrorHandler();
        ClsDaoHombre daoHombre = new ClsDaoHombre();

        public bool getAllProductoHombre()
        {
            try
            {
                if (daoHombre.getProducto_Hombre())
                {
                    DsReturn = daoHombre.DsReturn;
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

        public bool getAllProductoHombreCalzado()
        {
            try
            {
                if (daoHombre.getProducto_Hombre_Calzado())
                {
                    DsReturn = daoHombre.DsReturn;
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

        public bool getAllProductoHombreRopa()
        {
            try
            {
                if (daoHombre.getProducto_Hombre_Ropa())
                {
                    DsReturn = daoHombre.DsReturn;
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

        public bool getAllProductoHombreAccesorio()
        {
            try
            {
                if (daoHombre.getProducto_Hombre_Accesorio())
                {
                    DsReturn = daoHombre.DsReturn;
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