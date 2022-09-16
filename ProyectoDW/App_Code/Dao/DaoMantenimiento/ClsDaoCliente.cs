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

        public bool getCliente(ClsUsuario usuario)
        {
            try
            {
                strSql = "SELECT ID_USUARIO, NOMBRE, APELLIDO, EMAIL, PASSWORD FROM TB_USUARIO  WHERE EMAIL = '" + usuario.Email + "';";
            DsReturn = objSql.EjectuaSQL(strSql, "TB_USUARIO");
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
            strSql = "INSERT INTO TB_USUARIO (ID_USUARIO,NOMBRE,APELLIDO,EMAIL,PASSWORD) "+
                "VALUES((SELECT ISNULL(MAX(ID_USUARIO),0) + 1 FROM TB_USUARIO),'"
                + usuario.Nombre+"','"+usuario.Apellido+"','"+usuario.Email+"','"+usuario.Password+"')";
            return ExecuteSql(strSql);
        }

        public bool UpdateCliente(ClsUsuario usuario)
        {
            strSql = "UPDATE TB_USUARIO SET"+
                " NOMBRE = '" + usuario.Nombre + "',"+
                " APELLIDO = '" + usuario.Apellido + "',"+
                " EMAIL = '" + usuario.Email + "',"+
                " PASSWORD = '" + usuario.Password + "' "+
                "WHERE ID_USUARIO = " + usuario.IdUsuario;
            return ExecuteSql(strSql);
        }

        public bool DeleteCliente(ClsUsuario usuario)
        {
            strSql = "DELETE FROM TB_USUARIO WHERE ID_USUARIO = " + usuario.IdUsuario;
            return ExecuteSql(strSql);
        }
    }
}