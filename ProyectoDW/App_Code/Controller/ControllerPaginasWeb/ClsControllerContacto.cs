using DXWebApplication.App_Code.Utilidades;
using ProyectoDW.App_Code.Dao.DaoPaginasWeb;
using ProyectoDW.App_Code.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoDW.App_Code.Controller.ControllerPaginasWeb
{
    public class ClsControllerContacto : ClsController
    {
        ClsErrorHandler log = new ClsErrorHandler();
        ClsDaoContacto objContacto = new ClsDaoContacto();

        public bool InsertContacto(ClsContacto contacto)
        {
            try
            {
                if (objContacto.InsertContacto(contacto))
                {
                    return true;
                }
            }
            catch (Exception ex)
            {
                log.LogError(ex.ToString(), ex.StackTrace);
                throw;
            }
            return false;
        }
    }
}