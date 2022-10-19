/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/WebServices/WebService.java to edit this template
 */
package org.servicio;

import javax.jws.WebService;
import javax.jws.WebMethod;
import javax.jws.WebParam;
import org.dao.DaoTransaccion;
import org.modelos.ModelTransaccion;

/**
 *
 * @author Alejandra Morataya
 */
@WebService(serviceName = "InsertarTransaccion")
public class InsertarTransaccion {

    @WebMethod(operationName = "ingresarTransaccion")
    public ModelTransaccion ingresarTransaccion(
            @WebParam(name = "idTransaccion") int idTransaccion,
            @WebParam(name = "ultimosDitigosTarjeta") String ultimosDitigosTarjeta,
            @WebParam(name = "nombre") String nombre,
            @WebParam(name = "autorizacion") String autorizacion,
            @WebParam(name = "monto") double monto,
            @WebParam(name = "estadoTransaccion") int estadoTransaccion) {

        if (ultimosDitigosTarjeta.length() > 4) {
            ultimosDitigosTarjeta = ultimosDitigosTarjeta.substring(Math.max(0, ultimosDitigosTarjeta.length() - 4));
        } 

        DaoTransaccion daoTransaccion = new DaoTransaccion();
        ModelTransaccion transaccion = new ModelTransaccion(idTransaccion, ultimosDitigosTarjeta, nombre, autorizacion, estadoTransaccion, monto);
        daoTransaccion.insertarCliente(transaccion);

        return transaccion;
    }

}
