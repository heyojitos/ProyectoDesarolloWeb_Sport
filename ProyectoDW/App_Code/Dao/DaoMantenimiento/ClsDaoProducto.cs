using DXWebApplication.App_Code.Dal;
using DXWebApplication.App_Code.Utilidades;
using ProyectoDW.App_Code.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoDW.App_Code.Dao.DaoMantenimiento
{
    public class ClsDaoProducto : ClsDataLayer
    {
        ClsConexion objSql = new ClsConexion();
        ClsErrorHandler log = new ClsErrorHandler();
        string strSql = string.Empty;

        public bool getProductoAll()
        {
            try
            {
                strSql = "SELECT * FROM TB_PRODUCTO";
                DsReturn = objSql.EjectuaSQL(strSql, "Producto");
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

        public bool InsertProducto(ClsProducto producto)
        {
            strSql = "";
            return ExecuteSql(strSql);
        }

        public bool UpdateProducto(ClsProducto producto)
        {
            strSql = "";
            return ExecuteSql(strSql);
        }

        public bool DeleteProducto(ClsProducto producto)
        {
            strSql = "";
            return ExecuteSql(strSql);
        }
    }
}