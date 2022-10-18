using DXWebApplication.App_Code.Utilidades;
using ProyectoDW.App_Code.Dao;
using ProyectoDW.App_Code.Dao.DaoMantenimiento;
using ProyectoDW.App_Code.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoDW.App_Code.Controller
{
    public class ClsControllerClient : ClsController
    {
        ClsErrorHandler log = new ClsErrorHandler();
        ClsDaoClient objCliente = new ClsDaoClient();

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

        public bool GetIdCliente(ClsClient cliente)
        {
            try
            {
                if (objCliente.getUsuarioID(cliente))
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

        public bool InsertCliente(ClsClient cliente)
        {
            try
            {
                if (objCliente.InsertCliente(cliente))
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


        public bool getCliente(ClsClient cliente)
        {
            try
            {
                if (objCliente.getCliente(cliente))
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

        public bool getUsuario(ClsClient cliente)
        {
            try
            {
                if (objCliente.getUsuario(cliente))
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

        public bool UpdateCliente(ClsClient cliente)
        {
            try
            {
                if (objCliente.UpdateCliente(cliente))
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

        public bool DeleteCliente(ClsClient cliente)
        {
            try
            {
                if (objCliente.DeleteCliente(cliente))
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