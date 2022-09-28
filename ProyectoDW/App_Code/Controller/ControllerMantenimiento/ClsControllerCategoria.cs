using DXWebApplication.App_Code.Utilidades;
using ProyectoDW.App_Code.Dao.DaoMantenimiento;
using ProyectoDW.App_Code.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoDW.App_Code.Controller.ControllerMantenimiento
{
    public class ClsControllerCategoria : ClsController
    {
        ClsErrorHandler log = new ClsErrorHandler();
        ClsDaoCategoria objCategoria = new ClsDaoCategoria();

        public bool GetCategoriaAll()
        {
            try
            {
                if (objCategoria.getCategoriaAll())
                {
                    DsReturn = objCategoria.DsReturn;
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

        public bool GetIdCategoria(ClsCategoria categoria)
        {
            try
            {
                if (objCategoria.getCategoria(categoria))
                {
                    DsReturn = objCategoria.DsReturn;
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

        public bool InsertCategoria(ClsCategoria categoria)
        {
            try
            {
                if (objCategoria.InsertCategoria(categoria))
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

        public bool UpdateCategoria(ClsCategoria categoria)
        {
            try
            {
                if (objCategoria.UpdateCategoria(categoria))
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

        public bool DeleteCategoria(ClsCategoria categoria)
        {
            try
            {
                if (objCategoria.DeleteCategoria(categoria))
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