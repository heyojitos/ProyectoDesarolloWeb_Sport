using DXWebApplication.App_Code.Dal;
using DXWebApplication.App_Code.Utilidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoDW.App_Code.Dao.DaoPaginasWeb
{
    public class ClsDaoPedido : ClsDataLayer
    {
        ClsConexion objSql = new ClsConexion();
        ClsErrorHandler log = new ClsErrorHandler();
        //ClsCarritoCompra ClsCarrito = new ClsCarritoCompra();

        string strSql = "";

        public bool getPedidoCliente(int id_cliente)
        {
            try
            {
                strSql = "SELECT TB_PEDIDO.ID_PEDIDO, TB_PEDIDO.FECHA_PEDIDO, TB_PEDIDO.NOMBRE_CLIENTE, TB_PEDIDO.NIT, TB_PEDIDO.MONTO, TB_ESTADO.DESCRIPCION as 'ESTADO' " +
                    "FROM TB_PEDIDO INNER JOIN TB_ESTADO ON TB_PEDIDO.ID_ESTADO = TB_ESTADO.ID_ESTADO WHERE TB_PEDIDO.ID_USUARIO = " + id_cliente;
                DsReturn = objSql.EjectuaSQL(strSql, "PedidoCliente");
            }
            catch (Exception ex)
            {
                log.LogError(ex.ToString(), ex.StackTrace);
                return false;
            }
            return true;
        }

        public bool getDetallePedidoCliente(int id_pedido)
        {
            try
            {
                strSql = "SELECT TB_DETALLE_PEDIDO.ID_DETALLE_PEDIDO, TB_PRODUCTO.PRODUCTO, TB_PRODUCTO.IMAGEN, TB_DETALLE_PEDIDO.CANTIDAD, TB_DETALLE_PEDIDO.SUBTOTAL " +
                    "FROM TB_PEDIDO INNER JOIN TB_DETALLE_PEDIDO ON TB_PEDIDO.ID_PEDIDO = TB_DETALLE_PEDIDO.ID_PEDIDO INNER JOIN TB_PRODUCTO ON TB_DETALLE_PEDIDO.ID_PRODUCTO = TB_PRODUCTO.ID_PRODUCTO " +
                    "WHERE TB_PEDIDO.ID_PEDIDO = " + id_pedido;
                DsReturn = objSql.EjectuaSQL(strSql, "DetallePedidoCliente");
            }
            catch (Exception ex)
            {
                log.LogError(ex.ToString(), ex.StackTrace);
                return false;
            }
            return true;
        }

        /*public bool getDetallePedidoClienteTotal(int id_pedido)
        {
            try
            {
                strSql = "" + id_pedido;
                DsReturn = objSql.EjectuaSQL(strSql, "DetallePedidoClienteTotal");
            }
            catch (Exception ex)
            {
                log.LogError(ex.ToString(), ex.StackTrace);
                return false;
            }
            return true;
        }*/
    }
}