using DXWebApplication.App_Code.Dal;
using DXWebApplication.App_Code.Utilidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoDW.App_Code.Dao.DaoPaginasWeb
{
    public class ClsDaoHombre : ClsDataLayer
    {
        ClsConexion objSql = new ClsConexion();
        ClsErrorHandler log = new ClsErrorHandler();
        string strSql = string.Empty;

        public bool getProducto_Hombre()
        {
            try
            {
                strSql = "SELECT        TB_PRODUCTO.ID_PRODUCTO, TB_PRODUCTO.PRODUCTO, TB_CATEGORIA.DESCRIPCION, TB_PRODUCTO.PRECIO, TB_PRODUCTO.IMAGEN  " +
                    "FROM TB_CATEGORIA INNER JOIN " +
                    "TB_PRODUCTO ON TB_CATEGORIA.ID_CATEGORIA = TB_PRODUCTO.ID_CATEGORIA " +
                    "WHERE TB_CATEGORIA.DESCRIPCION LIKE '%HOMBRE%'";
                DsReturn = objSql.EjectuaSQL(strSql, "Hombre");
            }
            catch (Exception ex)
            {
                log.LogError(ex.ToString(), ex.StackTrace);
                return false;
            }
            return true;
        }

        public bool getProducto_Hombre_Calzado()
        {
            try
            {
                strSql = "SELECT        TB_PRODUCTO.ID_PRODUCTO, TB_PRODUCTO.PRODUCTO, TB_CATEGORIA.DESCRIPCION, TB_PRODUCTO.PRECIO, TB_PRODUCTO.IMAGEN " +
                    "FROM TB_CATEGORIA INNER JOIN " +
                    "TB_PRODUCTO ON TB_CATEGORIA.ID_CATEGORIA = TB_PRODUCTO.ID_CATEGORIA " +
                    "WHERE TB_CATEGORIA.DESCRIPCION = 'CALZADO HOMBRE'";
                DsReturn = objSql.EjectuaSQL(strSql, "HombreCalzado");
            }
            catch (Exception ex)
            {
                log.LogError(ex.ToString(), ex.StackTrace);
                return false;
            }
            return true;
        }

        public bool getProducto_Hombre_Ropa()
        {
            try
            {
                strSql = "SELECT        TB_PRODUCTO.ID_PRODUCTO, TB_PRODUCTO.PRODUCTO, TB_CATEGORIA.DESCRIPCION, TB_PRODUCTO.PRECIO, TB_PRODUCTO.IMAGEN " +
                    "FROM TB_CATEGORIA INNER JOIN " +
                    "TB_PRODUCTO ON TB_CATEGORIA.ID_CATEGORIA = TB_PRODUCTO.ID_CATEGORIA " +
                    "WHERE TB_CATEGORIA.DESCRIPCION = 'ROPA HOMBRE'";
                DsReturn = objSql.EjectuaSQL(strSql, "HombreRopa");
            }
            catch (Exception ex)
            {
                log.LogError(ex.ToString(), ex.StackTrace);
                return false;
            }
            return true;
        }

        public bool getProducto_Hombre_Accesorio()
        {
            try
            {
                strSql = "SELECT        TB_PRODUCTO.ID_PRODUCTO, TB_PRODUCTO.PRODUCTO, TB_CATEGORIA.DESCRIPCION, TB_PRODUCTO.PRECIO, TB_PRODUCTO.IMAGEN " +
                    "FROM TB_CATEGORIA INNER JOIN " +
                    "TB_PRODUCTO ON TB_CATEGORIA.ID_CATEGORIA = TB_PRODUCTO.ID_CATEGORIA " +
                    "WHERE TB_CATEGORIA.DESCRIPCION = 'ACCESORIOS HOMBRE'";
                DsReturn = objSql.EjectuaSQL(strSql, "HombreAccesorio");
            }
            catch (Exception ex)
            {
                log.LogError(ex.ToString(), ex.StackTrace);
                return false;
            }
            return true;
        }
    }
}