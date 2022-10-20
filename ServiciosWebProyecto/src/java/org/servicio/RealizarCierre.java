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
@WebService(serviceName = "RealizarCierre")
public class RealizarCierre {

    @WebMethod(operationName = "cierre")
    public double cierre() {
        DaoTransaccion daoTransaccion = new DaoTransaccion();
        double totalCierre=0;
        List<ModelTransaccion> listaTransaccion = daoTransaccion.getListaTransacciones();
        for(ModelTransaccion transaccion :listaTransaccion ){
            totalCierre= totalCierre + transaccion.getMonto();
        }
        daoTransaccion.actualizarTransacciones();
        
        return totalCierre;
    }
}
