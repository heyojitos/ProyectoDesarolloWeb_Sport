using DXWebApplication.App_Code.Utilidades;
using ProyectoDW.App_Code.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoDW.App_Code.Dao.DaoMantenimiento
{
    public class ClsDaoCliente : ClsDataLayer
    {
        ClsUsuario objUsuario = new ClsUsuario();
        ClsErrorHandler log = new ClsErrorHandler();
        String strSql = string.Empty;

        public bool getClienteAll() {

            try
            {
                strSql = "SELECT ID_USUARIO, NOMBRE, APELLIDO, EMAIL, PASSWORD FROM TB_USUARIO";

            }
            catch (Exception ex)
            {
                log.LogError(ex.ToString(), ex.StackTrace);
                //throw;
            }
            return true;
        }
    }
}