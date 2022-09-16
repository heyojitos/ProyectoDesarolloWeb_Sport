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
            strSql = "INSERT INTO TB_PRODUCTO(ID_PRODUCTO,PRODUCTO,DESCRIPCION,ID_CATEGORIA,PRECIO,IMAGEN,STOCK) "+
                "VALUES((SELECT ISNULL(MAX(ID_PRODUCTO),0)+ 1 FROM TB_PRODUCTO),'" 
                + producto.Producto + "','" 
                + producto.Descripcion + "'," 
                + producto.IdCategoria + "," 
                + producto.Precio + ",'" 
                + producto.Imagen + "'," 
                + producto.Stock + ")";
            return ExecuteSql(strSql);
        }

        public bool UpdateProducto(ClsProducto producto)
        {
            strSql = "UPDATE TB_PRODUCTO SET"+
                " PRODUCTO = '" + producto.Producto + 
                "', DESCRIPCION = '" + producto.Descripcion + 
                "', ID_CATEGORIA = " + producto.IdCategoria + 
                ", PRECIO = " + producto.Precio + 
                ", IMAGEN = '" + producto.Imagen + 
                "', STOCK = " + producto.Stock + 
                " WHERE ID_PRODUCTO = " + producto.IdProducto;
            return ExecuteSql(strSql);
        }

        public bool DeleteProducto(ClsProducto producto)
        {
            strSql = "DELETE FROM TB_PRODUCTO WHERE ID_PRODUCTO = " + producto.IdProducto;
            return ExecuteSql(strSql);
        }
    }
}