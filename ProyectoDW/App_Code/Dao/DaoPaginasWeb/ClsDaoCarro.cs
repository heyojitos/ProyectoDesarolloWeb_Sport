using DXWebApplication.App_Code.Dal;
using DXWebApplication.App_Code.Utilidades;
using ProyectoDW.App_Code.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace ProyectoDW.App_Code.Dao.DaoPaginasWeb
{
    public class ClsDaoCarro : ClsDataLayer
    {
        ClsConexion objSql = new ClsConexion();
        ClsErrorHandler log = new ClsErrorHandler();
        //ClsCarritoCompra ClsCarrito = new ClsCarritoCompra();
        
        string strSql = "";
        int id_pedido = 0;

        public bool InsertarPedido(ClsClient client, List<ClsCarroItem> lstCarrito, decimal total)
        {
            SqlConnection conexion = objSql.OpenConexion();
            SqlTransaction transaccion;
            transaccion = conexion.BeginTransaction();
            int linea = 1;
            
            try
            {

                strSql = "INSERT INTO [TB_PEDIDO] ([ID_PEDIDO],[ID_USUARIO],[NOMBRE_CLIENTE],[NIT],[FECHA_PEDIDO],[MONTO],[ID_ESTADO]) VALUES (" +
                        "(SELECT ISNULL(MAX(ID_PEDIDO),0) + 1 FROM TB_PEDIDO)," +
                        ""+ client.IdCliente +"," +
                        "'"+ client.Contacto +"'," +
                        "'"+ client.Nit +"'," +
                        "GETDATE()," +
                        " "+ total +"," +
                        "1)";
                objSql.EjectuaSQLT(conexion, transaccion, strSql);

                foreach (ClsCarroItem cls in lstCarrito)
                {
                    strSql = "INSERT INTO [TB_DETALLE_PEDIDO] ([ID_DETALLE_PEDIDO],[ID_PEDIDO],[ID_PRODUCTO],[CANTIDAD],[SUBTOTAL]) VALUES (" +
                        " "+ cls.ID_regitro +"," +
                        "(SELECT MAX(ID_PEDIDO) FROM TB_PEDIDO)," +
                        " "+ cls.Codigo_producto +", " +
                        " "+ cls.Cantidad+", " +
                        " "+ cls.Subtotal +")";
                    objSql.EjectuaSQLT(conexion, transaccion, strSql);

                    strSql = "UPDATE [TB_PRODUCTO] SET [STOCK] = [STOCK] - "+ cls.Cantidad +" WHERE [ID_PRODUCTO] = "+ cls.Codigo_producto +" ";
                    objSql.EjectuaSQLT(conexion, transaccion, strSql);
                }

                transaccion.Commit();

            }
            catch (Exception ex)
            {
                log.LogError(ex.ToString(), ex.StackTrace);
                transaccion.Rollback();
                conexion.Close();
                return false;
            }
            conexion.Close();
            return true;
        }
    }
}