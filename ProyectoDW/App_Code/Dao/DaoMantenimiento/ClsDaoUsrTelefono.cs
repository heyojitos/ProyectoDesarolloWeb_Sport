using DXWebApplication.App_Code.Dal;
using DXWebApplication.App_Code.Utilidades;
using ProyectoDW.App_Code.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoDW.App_Code.Dao.DaoMantenimiento
{
    public class ClsDaoUsrTelefono : ClsDataLayer
    {
        ClsConexion objSql = new ClsConexion();
        ClsErrorHandler log = new ClsErrorHandler();
        string strSql = string.Empty;

        public bool GetTelefonoAll()
        {
            try
            {
                strSql = "";
                DsReturn = objSql.EjectuaSQL(strSql, "Telefono");
            }
            catch (Exception ex)
            {
                log.LogError(ex.ToString(), ex.StackTrace);
                return false;
            }
            return true;
        }

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

        public bool InsertTelefono(ClsUsrTelefono telefono)
        {
            strSql = "";
            return ExecuteSql(strSql);
        }

        public bool UpdateTelefono(ClsUsrTelefono telefono)
        {
            strSql = "";
            return ExecuteSql(strSql);
        }

        public bool DeleteTelefono(ClsUsrTelefono telefono)
        {
            strSql = "";
            return ExecuteSql(strSql);
        }
    }
}