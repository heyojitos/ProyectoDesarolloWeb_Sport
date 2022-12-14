using DXWebApplication.App_Code.Dal;
using DXWebApplication.App_Code.Utilidades;
using ProyectoDW.App_Code.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoDW.App_Code.Dao.DaoMantenimiento
{
    public class ClsDaoUsrDireccion : ClsDataLayer
    {
        ClsConexion objSql = new ClsConexion();
        ClsErrorHandler log = new ClsErrorHandler();
        string strSql = string.Empty;

        public bool getDireccionAll()
        {
            try
            {
                strSql = "SELECT * FROM TB_USR_DIRECCION";
                DsReturn = objSql.EjectuaSQL(strSql, "Direccion");
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

        public bool InsertDireccion(ClsUsrDireccion direccion)
        {
            strSql = "INSERT INTO TB_USR_DIRECCION(ID_DIRECCION,ID_USUARIO,DESCRIPCION) "+
                "VALUES((SELECT ISNULL(MAX(ID_DIRECCION),0)+ 1 FROM TB_USR_DIRECCION)," 
                + direccion.IdUsuario + ",'" + direccion.Descripcion + "')";
            return ExecuteSql(strSql);
        }

        public bool UpdateDireccion(ClsUsrDireccion direccion)
        {
            strSql = "UPDATE TB_USR_DIRECCION SET "+
                "ID_USUARIO = " + direccion.IdUsuario + 
                ", DESCRIPCION = '" + direccion.Descripcion + 
                "' WHERE ID_DIRECCION = " + direccion.IdDireccion;
            return ExecuteSql(strSql);
        }

        public bool DeleteDireccion(ClsUsrDireccion direccion)
        {
            strSql = "DELETE FROM TB_USR_DIRECCION WHERE ID_DIRECCION = " + direccion.IdDireccion;
            return ExecuteSql(strSql);
        }
    }
}