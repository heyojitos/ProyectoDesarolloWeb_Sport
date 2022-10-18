using DXWebApplication.App_Code.Dal;
using DXWebApplication.App_Code.Utilidades;
using ProyectoDW.App_Code.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoDW.App_Code.Dao
{
    public class ClsDaoClient : ClsDataLayer
    {
        ClsConexion objSql = new ClsConexion();
        ClsErrorHandler log = new ClsErrorHandler();
        String strSql = "";

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

        public bool getClienteAll()
        {
            try
            {
                strSql = "SELECT * FROM TB_CLIENTE";
                DsReturn = objSql.EjectuaSQL(strSql, "Cliente");
            }
            catch (Exception ex)
            {
                log.LogError(ex.ToString(), ex.StackTrace);
                return false;
            }
            return true;

        }

        public bool InsertCliente(ClsClient cliente)
        {
            strSql = "INSERT INTO TB_CLIENTE " +
                     "(ID_CLIENTE, NOMBRE, APELLIDO, CORREO, CLAVE) " +
                     "VALUES " +
                     "((SELECT ISNULL(MAX(ID_CLIENTE),0) + 1 FROM TB_CLIENTE), '" + cliente.Nombre + "', '" + cliente.Apellido + "', " +
                     "'" + cliente.Correo + "', '" + cliente.Clave + "')";
            return ExecuteSql(strSql);
        }

        public bool getUsuarioID(ClsClient usuario)
        {

            try
            {
                strSql = "SELECT ID_CLIENTE FROM TB_CLIENTE WHERE NOMBRE = '" + usuario.Nombre + "'  AND [APELLIDO] = '" + usuario.Apellido + "' AND [CORREO] = '" + usuario.Correo + "' AND [CLAVE] = '" + usuario.Clave + "' ";
                DsReturn = objSql.EjectuaSQL(strSql, "idCliente");
            }
            catch (Exception ex)
            {
                log.LogError(ex.ToString(), ex.StackTrace);
                //throw;
            }
            return true;
        }

        public bool getCliente(ClsClient usuario)
        {
            try
            {
                strSql = "SELECT ID_CLIENTE, NOMBRE, APELLIDO, CORREO, CLAVE FROM TB_CLIENTE  WHERE CORREO = '" + usuario.Correo + "';";
                DsReturn = objSql.EjectuaSQL(strSql, "TB_CLIENTE");
            }
            catch (Exception ex)
            {
                log.LogError(ex.ToString(), ex.StackTrace);
                //throw;
            }
            return true;
        }


        public bool getUsuario(ClsClient usuario)
        {
            try
            {
                strSql = "SELECT CORREO FROM TB_CLIENTE WHERE CORREO = '" + usuario.Correo + "'  ;";
                DsReturn = objSql.EjectuaSQL(strSql, "correoCliente");
            }
            catch (Exception ex)
            {
                log.LogError(ex.ToString(), ex.StackTrace);
                //throw;
            }
            return true;
        }


        public bool UpdateCliente(ClsClient usuario)
        {
            strSql = "UPDATE TB_CLIENTE SET" +
                " NOMBRE = '" + usuario.Nombre + "'," +
                " APELLIDO = '" + usuario.Apellido + "'," +
                " CORREO = '" + usuario.Correo + "'," +
                " CLAVE = '" + usuario.Clave + "' " +
                "WHERE ID_CLIENTE = " + usuario.IdCliente;
            return ExecuteSql(strSql);
        }

        public bool DeleteCliente(ClsClient usuario)
        {
            strSql = "DELETE FROM TB_CLIENTE WHERE ID_CLIENTE = " + usuario.IdCliente;
            return ExecuteSql(strSql);
        }
    }
}