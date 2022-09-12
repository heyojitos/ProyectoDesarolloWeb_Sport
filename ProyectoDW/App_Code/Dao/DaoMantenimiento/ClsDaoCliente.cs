using DXWebApplication.App_Code.Dal;

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
        ClsConexion objSql = new ClsConexion();
        ClsErrorHandler log = new ClsErrorHandler();
        String strSql = string.Empty;

        public bool ExecuteSql(string strSql)
        {
            try
            {
                return objSql.ejecutarNonQuery(strSql);
            }
            catch (Exception ex)
            {
                log.LogError(ex.ToString(), ex.StackTrace);
                return false;
            }
        }

        public bool getClienteAll() {

            try
            {
                strSql = "SELECT ID_USUARIO, NOMBRE, APELLIDO, EMAIL, PASSWORD FROM TB_USUARIO";
                DsReturn = objSql.EjectuaSQL(strSql, "Usuario");
            }
            catch (Exception ex)
            {
                log.LogError(ex.ToString(), ex.StackTrace);
                //throw;
            }
            return true;
        }

        public bool InsertCliente(ClsUsuario usuario)
        {
            strSql = "";
            return ExecuteSql(strSql);
        }

        public bool UpdateCliente(ClsUsuario usuario)
        {
            strSql = "";
            return ExecuteSql(strSql);
        }

        public bool DeleteCliente(ClsUsuario usuario)
        {
            strSql = "";
            return ExecuteSql(strSql);
        }
    }
}