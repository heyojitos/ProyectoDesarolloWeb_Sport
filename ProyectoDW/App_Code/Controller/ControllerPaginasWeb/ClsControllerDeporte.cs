using DXWebApplication.App_Code.Utilidades;
using ProyectoDW.App_Code.Dao.DaoPaginasWeb;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoDW.App_Code.Controller.ControllerPaginasWeb
{
    public class ClsControllerDeporte : ClsController
    {
        ClsErrorHandler log = new ClsErrorHandler();
        ClsDaoDeporte daoDeporte = new ClsDaoDeporte();

        public bool getAllProductoDeportes()
        {
            try
            {
                if (daoDeporte.getProducto_Deporte())
                {
                    DsReturn = daoDeporte.DsReturn;
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

        public bool getAllProductoDeportesRunning()
        {
            try
            {
                if (daoDeporte.getProducto_Deporte_Running())
                {
                    DsReturn = daoDeporte.DsReturn;
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

        public bool getAllProductoDeportesTraining()
        {
            try
            {
                if (daoDeporte.getProducto_Deporte_Training())
                {
                    DsReturn = daoDeporte.DsReturn;
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