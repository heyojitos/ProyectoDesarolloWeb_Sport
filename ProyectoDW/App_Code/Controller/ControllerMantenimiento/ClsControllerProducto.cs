using DXWebApplication.App_Code.Utilidades;
using ProyectoDW.App_Code.Dao;
using ProyectoDW.App_Code.Dao.DaoMantenimiento;
using ProyectoDW.App_Code.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoDW.App_Code.Controller.ControllerMantenimiento
{
    public class ClsControllerProducto : ClsController
    {
        ClsErrorHandler log = new ClsErrorHandler();
        ClsDaoProducto objProducto = new ClsDaoProducto();

        public bool GetProductoAll()
        {
            try
            {
                if (objProducto.getProductoAll())
                {
                    DsReturn = objProducto.DsReturn;
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

        public bool InsertProducto(ClsProducto producto)
        {
            try
            {
                if (objProducto.InsertProducto(producto))
                {
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

        public bool UpdateProducto(ClsProducto producto)
        {
            try
            {
                if (objProducto.UpdateProducto(producto))
                {
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

        public bool DeleteProducto(ClsProducto producto)
        {
            try
            {
                if (objProducto.DeleteProducto(producto))
                {
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
        public bool Buscar_Producto(String buscarID)
        {
            try
            {
                if (objProducto.getProducto_by_ID(buscarID))
                {
                    DsReturn = objProducto.DsReturn;
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
    }
}