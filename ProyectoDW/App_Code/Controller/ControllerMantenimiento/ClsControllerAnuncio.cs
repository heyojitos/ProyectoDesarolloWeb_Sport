using DXWebApplication.App_Code.Utilidades;
using ProyectoDW.App_Code.Dao.DaoMantenimiento;
using ProyectoDW.App_Code.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoDW.App_Code.Controller.ControllerMantenimiento
{
    public class ClsControllerAnuncio : ClsController
    {
        ClsErrorHandler log = new ClsErrorHandler();
        ClsDaoAnuncio objAnuncio = new ClsDaoAnuncio();

        public bool getAnuncioAll()
        {
            try
            {
                if (objAnuncio.getAnunciosAll())
                {
                    DsReturn = objAnuncio.DsReturn;
                    return true;
                }
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
                if (objAnuncio.getAnuncioId(anuncio))
                {
                    DsReturn = objAnuncio.DsReturn;
                    return true;
                }
            }
            catch (Exception ex)
            {
                log.LogError(ex.ToString(), ex.StackTrace);
                throw;
            }
            return false;
        }

        public bool InsertAnuncio(ClsAnuncio anuncio)
        {
            try
            {
                if (objAnuncio.InsertAnuncio(anuncio))
                {
                    return true;
                }
            }
            catch (Exception ex)
            {
                log.LogError(ex.ToString(), ex.StackTrace);
                return false;
            }
            return false;
        }

        public bool UpdateAnuncio(ClsAnuncio anuncio)
        {
            try
            {
                if (objAnuncio.UpdateAnuncio(anuncio))
                {
                    return true;
                }
            }
            catch (Exception ex)
            {
                log.LogError(ex.ToString(), ex.StackTrace);
                return false;
            }
            return false;
        }

        public bool DeleteAnuncio(ClsAnuncio anuncio)
        {
            try
            {
                if (objAnuncio.DeleteAnuncio(anuncio))
                {
                    return true;
                }
            }
            catch (Exception ex)
            {
                log.LogError(ex.ToString(), ex.StackTrace);
                return false;
            }
            return false;
        }

    }
}