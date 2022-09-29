using DXWebApplication.App_Code.Dal;
using DXWebApplication.App_Code.Utilidades;
using ProyectoDW.App_Code.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoDW.App_Code.Dao
{
    public class ClsDaoCarrito : ClsDataLayer
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

        public bool getDetallePedido()
        {
            try
            {
                strSql = "SELECT DP.ID_DETALLE_PEDIDO, DP.ID_PEDIDO, DP.ID_PRODUCTO, "+
                    "P.PRODUCTO, PE.ID_USUARIO, DP.CANTIDAD, DP.SUBTOTAL "+
                    "FROM  TB_DETALLE_PEDIDO DP INNER JOIN TB_PEDIDO PE ON PE.ID_PEDIDO = PE.ID_PEDIDO "+
                    "INNER JOIN TB_ESTADO ES ON PE.ID_ESTADO = ES.ID_ESTADO INNER JOIN "+
                    "TB_PRODUCTO P ON DP.ID_PRODUCTO = P.ID_PRODUCTO";
                DsReturn = objSql.EjectuaSQL(strSql, "DetallePedido");
            }
            catch (Exception ex)
            {
                log.LogError(ex.ToString(), ex.StackTrace);
                return false;
            }
            return true;
        }

        public bool insertDetallePedido(ClsDetallePedido detalle)
        {
            strSql = "";
            return ExecuteSql(strSql);
        }

        public bool updateDetallePedido(ClsDetallePedido detalle)
        {
            strSql = "";
            return ExecuteSql(strSql);
        }

        public bool deleteDetallePedido(ClsDetallePedido detalle)
        {
            strSql = "";
            return ExecuteSql(strSql);
        }
    }
}