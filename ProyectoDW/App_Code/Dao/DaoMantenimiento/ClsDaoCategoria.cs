using DXWebApplication.App_Code.Dal;
using DXWebApplication.App_Code.Utilidades;
using ProyectoDW.App_Code.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoDW.App_Code.Dao.DaoMantenimiento
{
    public class ClsDaoCategoria : ClsDataLayer
    {
        ClsConexion objSql = new ClsConexion();
        ClsErrorHandler log = new ClsErrorHandler();
        String strSql = string.Empty;

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

        public bool getCategoriaAll()
        {
            try
            {
                strSql = "SELECT * FROM TB_CATEGORIA";
                DsReturn = objSql.EjectuaSQL(strSql, "Categoria");
            }
            catch (Exception ex)
            {
                log.LogError(ex.ToString(), ex.StackTrace);
                //throw;
            }
            return true;
        }

        public bool getCategoria(ClsCategoria categoria)
        {
            try
            {
                strSql = "SELECT ID_CATEGORIA, DESCRIPCION FROM TB_CATEGORIA WHERE ID_CATEGORIA = " + categoria.IdCategoria;
                DsReturn = objSql.EjectuaSQL(strSql, "CategoriaId");
            }
            catch (Exception ex)
            {
                log.LogError(ex.ToString(), ex.StackTrace);
                //throw;
            }
            return true;
        }

        public bool InsertCategoria(ClsCategoria categoria)
        {
            strSql = "INSERT INTO TB_CATEGORIA (ID_CATEGORIA, DESCRIPCION) "+
                "VALUES((SELECT ISNULL(MAX(ID_CATEGORIA),0) + 1 FROM TB_CATEGORIA),'" +
                ""+ categoria.Descripcion +"')";
            return ExecuteSql(strSql);
        }

        public bool UpdateCategoria(ClsCategoria categoria)
        {
            strSql = "UPDATE TB_CATEGORIA SET "+
                "DESCRIPCION = '" + categoria.Descripcion + 
                "' WHERE ID_CATEGORIA = " + categoria.IdCategoria;
            return ExecuteSql(strSql);
        }

        public bool DeleteCategoria(ClsCategoria categoria)
        {
            strSql = "DELETE FROM TB_CATEGORIA WHERE ID_CATEGORIA = " + categoria.IdCategoria;
            return ExecuteSql(strSql);
        }
    }
}