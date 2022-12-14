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
        int Existe = 0;

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
            strSql = "INSERT INTO TB_CLIENT " +
                     "(ID_CLIENTE, NOMBRE, CORREO, DIRECCION, TELEFONO) " +
                     "VALUES (" + cliente.IdCliente + ", '" + cliente.Nombre + "', '" + cliente.Correo + "', '" + cliente.Direccion + "', '" + cliente.Telefono + "')";
            return ExecuteSql(strSql);
        }

        public bool getUsuarioID(String usuario)
        {

            try
            {
                strSql = "SELECT Email, UserName, Codigo FROM AspNetUsers WHERE id = '" + usuario + "' ";
                DsReturn = objSql.EjectuaSQL(strSql, "idCliente");
            }
            catch (Exception ex)
            {
                log.LogError(ex.ToString(), ex.StackTrace);
                return false;
            }
            return true;
        }

        public bool getCliente(ClsClient usuario)
        {
            try
            {
                strSql = "SELECT ID_CLIENTE, NOMBRE, CORREO FROM TB_CLIENTE  WHERE CORREO = '" + usuario.Correo + "';";
                DsReturn = objSql.EjectuaSQL(strSql, "TB_CLIENTE");
            }
            catch (Exception ex)
            {
                log.LogError(ex.ToString(), ex.StackTrace);
                return false;
            }
            return true;
        }

        public bool getClienteXid(int id)
        {
            try
            {
                strSql = "SELECT ID_CLIENTE FROM TB_CLIENT WHERE ID_CLIENTE = " + id;
                return objSql.ejecutarNonQuery(strSql);
                
            }
            catch (Exception ex)
            {
                log.LogError(ex.ToString(), ex.StackTrace);
                return false;
            }

            //return true;
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
                " CORREO = '" + usuario.Correo + "' " +                
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