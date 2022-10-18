using DXWebApplication.App_Code.Dal;
using DXWebApplication.App_Code.Utilidades;
using ProyectoDW.App_Code.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoDW.App_Code.Dao.DaoPaginasWeb
{
    public class ClsDaoContacto : ClsDataLayer
    {
        ClsConexion objSql = new ClsConexion();
        ClsErrorHandler log = new ClsErrorHandler();
        string strSql = string.Empty;

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

        public bool InsertContacto(ClsContacto contacto)
        {
            strSql = "INSERT INTO TB_CONTACTO (ID_CONTACTO, NOMBRE, EMAIL, MENSAJE) " +
                "VALUES((SELECT ISNULL(MAX(ID_CONTACTO),0) + 1 FROM TB_CONTACTO),'" +
                "" + contacto.Nombre + "', '" +
                ""+ contacto.Email +"', '" +
                ""+ contacto.Mensaje +"')";
            return ExecuteSql(strSql);
        }

        public bool UpdateContacto(ClsContacto contacto)
        {
            strSql = "";
            return ExecuteSql(strSql);
        }

        public bool DeleteContacto(ClsContacto contacto)
        {
            strSql = "";
            return ExecuteSql(strSql);
        }

    }
}