using DXWebApplication.App_Code.Dal;
using DXWebApplication.App_Code.Utilidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoDW.App_Code.Dao.DaoPaginasWeb
{
    public class ClsDaoMujer : ClsDataLayer
    {
        ClsConexion objSql = new ClsConexion();
        ClsErrorHandler log = new ClsErrorHandler();
        string strSql = string.Empty;

        public bool getProducto_Mujer()
        {
            try
            {
                strSql = "SELECT        TB_PRODUCTO.ID_PRODUCTO, TB_PRODUCTO.PRODUCTO, TB_CATEGORIA.DESCRIPCION, TB_PRODUCTO.PRECIO, TB_PRODUCTO.IMAGEN  " +
                    "FROM TB_CATEGORIA INNER JOIN " +
                    "TB_PRODUCTO ON TB_CATEGORIA.ID_CATEGORIA = TB_PRODUCTO.ID_CATEGORIA " +
                    "WHERE TB_CATEGORIA.DESCRIPCION LIKE '%MUJER%'";
                DsReturn = objSql.EjectuaSQL(strSql, "Mujer");
            }
            catch (Exception ex)
            {
                log.LogError(ex.ToString(), ex.StackTrace);
                return false;
            }
            return true;
        }

        public bool getProducto_Mujer_Calzado()
        {
            try
            {
                strSql = "SELECT        TB_PRODUCTO.ID_PRODUCTO, TB_PRODUCTO.PRODUCTO, TB_CATEGORIA.DESCRIPCION, TB_PRODUCTO.PRECIO, TB_PRODUCTO.IMAGEN " +
                    "FROM TB_CATEGORIA INNER JOIN " +
                    "TB_PRODUCTO ON TB_CATEGORIA.ID_CATEGORIA = TB_PRODUCTO.ID_CATEGORIA " +
                    "WHERE TB_CATEGORIA.DESCRIPCION = 'CALZADO MUJER'";
                DsReturn = objSql.EjectuaSQL(strSql, "MujerCalzado");
            }
            catch (Exception ex)
            {
                log.LogError(ex.ToString(), ex.StackTrace);
                return false;
            }
            return true;
        }

        public bool getProducto_Mujer_Ropa()
        {
            try
            {
                strSql = "SELECT        TB_PRODUCTO.ID_PRODUCTO, TB_PRODUCTO.PRODUCTO, TB_CATEGORIA.DESCRIPCION, TB_PRODUCTO.PRECIO, TB_PRODUCTO.IMAGEN " +
                    "FROM TB_CATEGORIA INNER JOIN " +
                    "TB_PRODUCTO ON TB_CATEGORIA.ID_CATEGORIA = TB_PRODUCTO.ID_CATEGORIA " +
                    "WHERE TB_CATEGORIA.DESCRIPCION = 'ROPA MUJER'";
                DsReturn = objSql.EjectuaSQL(strSql, "MujerRopa");
            }
            catch (Exception ex)
            {
                log.LogError(ex.ToString(), ex.StackTrace);
                return false;
            }
            return true;
        }

        public bool getProducto_Mujer_Accesorio()
        {
            try
            {
                strSql = "SELECT        TB_PRODUCTO.ID_PRODUCTO, TB_PRODUCTO.PRODUCTO, TB_CATEGORIA.DESCRIPCION, TB_PRODUCTO.PRECIO, TB_PRODUCTO.IMAGEN " +
                    "FROM TB_CATEGORIA INNER JOIN " +
                    "TB_PRODUCTO ON TB_CATEGORIA.ID_CATEGORIA = TB_PRODUCTO.ID_CATEGORIA " +
                    "WHERE TB_CATEGORIA.DESCRIPCION = 'ACCESORIOS MUJER'";
                DsReturn = objSql.EjectuaSQL(strSql, "MujerAccesorio");
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