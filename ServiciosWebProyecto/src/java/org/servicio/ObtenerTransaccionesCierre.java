/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/WebServices/WebService.java to edit this template
 */
package org.servicio;

import java.util.List;
import javax.jws.WebService;
import javax.jws.WebMethod;
import javax.jws.WebParam;
import org.dao.DaoTransaccion;
import org.modelos.ModelTransaccion;

/**
 *
 * @author Alejandra Morataya
 */
@WebService(serviceName = "ObtenerTransaccionesCierre")
public class ObtenerTransaccionesCierre {

    @WebMethod(operationName = "getTransaccionesParaCierre")
    public List<ModelTransaccion> getTransaccionesParaCierre() {
        DaoTransaccion daoTransaccion = new DaoTransaccion();
        List<ModelTransaccion> listaTransaccion = daoTransaccion.getListaTransacciones();
        return listaTransaccion;
    }
    
}
