using DXWebApplication.App_Code.Utilidades;
using ProyectoDW.App_Code.Dao;
using ProyectoDW.App_Code.Dao.DaoMantenimiento;
using ProyectoDW.App_Code.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoDW.App_Code.Controller.ControllerMantenimiento
{
    public class ClsControllerUsrDireccion : ClsController
    {
        ClsErrorHandler log = new ClsErrorHandler();
        ClsDaoUsrDireccion objDireccion = new ClsDaoUsrDireccion();

        public bool GetDireccionAll()
        {
            try
            {
                if (objDireccion.getDireccionAll())
                {
                    DsReturn = objDireccion.DsReturn;
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

        public bool InsertDireccion(ClsUsrDireccion direccion)
        {
            try
            {
                if (objDireccion.InsertDireccion(direccion))
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

        public bool UpdateDireccion(ClsUsrDireccion direccion)
        {
            try
            {
                if (objDireccion.UpdateDireccion(direccion))
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

        public bool DeleteDireccion(ClsUsrDireccion direccion)
        {
            try
            {
                if (objDireccion.DeleteDireccion(direccion))
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