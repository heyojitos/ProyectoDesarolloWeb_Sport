using DXWebApplication.App_Code.Dal;
using DXWebApplication.App_Code.Utilidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoDW.App_Code.Dao.DaoPaginasWeb
{
    public class ClsDaoDeporte : ClsDataLayer
    {
        ClsConexion objSql = new ClsConexion();
        ClsErrorHandler log = new ClsErrorHandler();
        string strSql = string.Empty;

        public bool getProducto_Deporte()
        {
            try
            {
                strSql = "SELECT        TB_PRODUCTO.ID_PRODUCTO, TB_PRODUCTO.PRODUCTO, TB_CATEGORIA.DESCRIPCION, TB_PRODUCTO.PRECIO, TB_PRODUCTO.IMAGEN " +
                    "FROM TB_CATEGORIA INNER JOIN " +
                    "TB_PRODUCTO ON TB_CATEGORIA.ID_CATEGORIA = TB_PRODUCTO.ID_CATEGORIA " +
                    "WHERE TB_CATEGORIA.DESCRIPCION LIKE '%DEPORTE%' ";
                DsReturn = objSql.EjectuaSQL(strSql, "Deporte");
            }
            catch (Exception ex)
            {
                log.LogError(ex.ToString(), ex.StackTrace);
                return false;
            }
            return true;
        }

        public bool getProducto_Deporte_Running()
        {
            try
            {
                strSql = "SELECT        TB_PRODUCTO.ID_PRODUCTO, TB_PRODUCTO.PRODUCTO, TB_CATEGORIA.DESCRIPCION, TB_PRODUCTO.PRECIO, TB_PRODUCTO.IMAGEN " +
                    "FROM TB_CATEGORIA INNER JOIN " +
                    "TB_PRODUCTO ON TB_CATEGORIA.ID_CATEGORIA = TB_PRODUCTO.ID_CATEGORIA " +
                    "WHERE TB_CATEGORIA.DESCRIPCION = 'DEPORTE RUNNING'";
                DsReturn = objSql.EjectuaSQL(strSql, "DeporteRunning");
            }
            catch (Exception ex)
            {
                log.LogError(ex.ToString(), ex.StackTrace);
                return false;
            }
            return true;
        }

        public bool getProducto_Deporte_Training()
        {
            try
            {
                strSql = "SELECT        TB_PRODUCTO.ID_PRODUCTO, TB_PRODUCTO.PRODUCTO, TB_CATEGORIA.DESCRIPCION, TB_PRODUCTO.PRECIO, TB_PRODUCTO.IMAGEN FROM TB_CATEGORIA INNER JOIN " +
                    "TB_PRODUCTO ON TB_CATEGORIA.ID_CATEGORIA = TB_PRODUCTO.ID_CATEGORIA " +
                    "WHERE TB_CATEGORIA.DESCRIPCION = 'DEPORTE TRAINING'";
                DsReturn = objSql.EjectuaSQL(strSql, "DeporteTraining");
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