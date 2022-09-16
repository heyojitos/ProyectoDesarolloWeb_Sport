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
    public class ClsControllerUsuario : ClsController
    {
        ClsErrorHandler log = new ClsErrorHandler();
        ClsDaoCliente objCliente = new ClsDaoCliente();

        public bool GetClienteAll()
        {
            try
            {
                if (objCliente.getClienteAll())
                {
                    DsReturn = objCliente.DsReturn;
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

        public bool GetIdUsuario(ClsUsuario usuario)
        {
            try
            {
                if (objCliente.getUsuarioID(usuario))
                {
                    DsReturn = objCliente.DsReturn;
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

        public bool InsertCliente(ClsUsuario usuario)
        {
            try
            {
                if (objCliente.InsertCliente(usuario))
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


        public bool getCliente(ClsUsuario usuario)
        {
            try
            {
                if (objCliente.getCliente(usuario))
                {
                    DsReturn = objCliente.DsReturn;
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

        public bool UpdateCliente(ClsUsuario usuario)
        {
            try
            {
                if (objCliente.UpdateCliente(usuario))
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

        public bool DeleteCliente(ClsUsuario usuario)
        {
            try
            {
                if (objCliente.DeleteCliente(usuario))
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