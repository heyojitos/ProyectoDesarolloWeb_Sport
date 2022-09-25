using DXWebApplication.App_Code.Dal;
using DXWebApplication.App_Code.Utilidades;
using ProyectoDW.App_Code.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoDW.App_Code.Dao.DaoMantenimiento
{
    public class ClsDaoAnuncio : ClsDataLayer
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

        public bool getAnunciosAll()
        {
            try
            {
                strSql = "SELECT * FROM TB_ANUNCIO";
                DsReturn = objSql.EjectuaSQL(strSql, "Anuncio");
            }
            catch (Exception ex)
            {
                log.LogError(ex.ToString(), ex.StackTrace);
                //throw;
            }
            return false;
        }

        public bool getAnuncioId(ClsAnuncio anuncio)
        {
            try
            {
                strSql = "SELECT ID_ANUNCIO, IMAGEN, FECHA_INI, FECHA_FINAL FROM TB_ANUNCIO WHERE ID_ANUNCIO = "+ anuncio.IdAnuncio;
                DsReturn = objSql.EjectuaSQL(strSql, "AnuncioId");
            }
            catch (Exception ex)
            {
                log.LogError(ex.ToString(), ex.StackTrace);
                throw;
            }
            return true;
        }

        public bool InsertAnuncio(ClsAnuncio anuncio)
        {
            strSql = "INSERT INTO TB_ANUNCIO(ID_ANUNCIO,IMAGEN,FECHA_INI,FECHA_FINAL) "+
                "VALUES((SELECT ISNULL(MAX(ID_ANUNCIO),0)+ 1 FROM TB_ANUNCIO),'" + anuncio.Imagen + 
                "','" + anuncio.FechaInicial + "','" + anuncio.FechaFinal + "')";
            return ExecuteSql(strSql);
        }

        public bool UpdateAnuncio(ClsAnuncio anuncio)
        {
            strSql = "UPDATE TB_ANUNCIO SET "+
                "IMAGEN = '" + anuncio.Imagen + 
                "', FECHA_INI = '" + anuncio.FechaInicial + 
                "', FECHA_FINAL = '" + anuncio.FechaFinal + 
                "' WHERE ID_ANUNCIO = "+ anuncio.IdAnuncio;
            return ExecuteSql(strSql);
        }

        public bool DeleteAnuncio(ClsAnuncio anuncio)
        {
            strSql = "DELETE FROM TB_ANUNCIO WHERE ID_ANUNCIO = "+ anuncio.IdAnuncio;
            return ExecuteSql(strSql);
        }

    }
}