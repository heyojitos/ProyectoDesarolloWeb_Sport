using DXWebApplication.App_Code.Utilidades;
using ProyectoDW.App_Code.Dao;
using ProyectoDW.App_Code.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoDW.App_Code.Controller
{
    public class ClsControllerCarrito : ClsController
    {
        ClsErrorHandler log = new ClsErrorHandler();
        ClsDaoCarrito objCarrito = new ClsDaoCarrito();

        public bool GetCarritoAll()
        {
            try
            {
                if (objCarrito.getDetallePedido())
                {
                    DsReturn = objCarrito.DsReturn;
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

        public bool InsertDetallePedido(ClsDetallePedido detalle)
        {
            try
            {
                if (objCarrito.insertDetallePedido(detalle))
                {
                    return true;
                }
            }
            catch (Exception ex)
            {
                log.LogError(ex.ToString(), ex.StackTrace);
                return false;
            }
            return false;
        }

        public bool UpdateDetallePedido(ClsDetallePedido detalle)
        {
            try
            {
                if (objCarrito.updateDetallePedido(detalle))
                {
                    return true;
                }

            }
            catch (Exception ex)
            {
                log.LogError(ex.ToString(), ex.StackTrace);
                return false;
            }
            return false;
        }

        public bool DeleteDetallePedido(ClsDetallePedido detalle)
        {
            try
            {
                if (objCarrito.deleteDetallePedido(detalle))
                {
                    return true;
                }
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