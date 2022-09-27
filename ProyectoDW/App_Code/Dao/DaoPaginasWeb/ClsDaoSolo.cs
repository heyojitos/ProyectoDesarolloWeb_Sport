using DXWebApplication.App_Code.Dal;
using DXWebApplication.App_Code.Utilidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoDW.App_Code.Dao.DaoPaginasWeb
{
    public class ClsDaoSolo : ClsDataLayer
    {
        ClsConexion objSql = new ClsConexion();
        ClsErrorHandler log = new ClsErrorHandler();
        string strSql = string.Empty;

        public bool getProducto_Id(String id)
        {
            try
            {
                strSql = "SELECT * FROM TB_PRODUCTO WHERE ID_PRODUCTO = " + int.Parse(id);
                DsReturn = objSql.EjectuaSQL(strSql, "MostrarProducto");
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