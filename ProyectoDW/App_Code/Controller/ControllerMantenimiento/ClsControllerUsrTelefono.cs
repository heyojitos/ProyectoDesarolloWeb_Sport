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
    public class ClsControllerUsrTelefono : ClsController
    {
        ClsErrorHandler log = new ClsErrorHandler();
        ClsDaoUsrTelefono objTelefono = new ClsDaoUsrTelefono();

        public bool GetTelefonoAll()
        {
            try
            {
                if (objTelefono.GetTelefonoAll())
                {
                    DsReturn = objTelefono.DsReturn;
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

        public bool InsertTelefono(ClsUsrTelefono telefono)
        {
            try
            {
                if (objTelefono.InsertTelefono(telefono))
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

        public bool UpdateTelefono(ClsUsrTelefono telefono)
        {
            try
            {
                if (objTelefono.UpdateTelefono(telefono))
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

        public bool DeleteTelefono(ClsUsrTelefono telefono)
        {
            try
            {
                if (objTelefono.DeleteTelefono(telefono))
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