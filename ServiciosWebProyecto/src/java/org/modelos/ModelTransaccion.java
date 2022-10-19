/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package org.modelos;

/**
 *
 * @author Alejandra Morataya
 */
public class ModelTransaccion {

    private int idTransaccion;
    private String ultimosDitigosTarjeta;
    private String nombre;
    private String autorizacion;
    private int estadoTransaccion;
   private double monto;
    private String estadoTransaccions;

    public ModelTransaccion() {
    }

    public ModelTransaccion(int idTransaccion, String ultimosDitigosTarjeta, String nombre, String autorizacion, int estadoTransaccion, double monto) {
        this.idTransaccion = idTransaccion;
        this.ultimosDitigosTarjeta = ultimosDitigosTarjeta;
        this.nombre = nombre;
        this.autorizacion = autorizacion;
        this.estadoTransaccion = estadoTransaccion;
        this.monto = monto; 
    }

    public int getIdTransaccion() {
        return idTransaccion;
    }

    public void setIdTransaccion(int idTransaccion) {
        this.idTransaccion = idTransaccion;
    }

    public String getUltimosDitigosTarjeta() {
        return ultimosDitigosTarjeta;
    }

    public void setUltimosDitigosTarjeta(String ultimosDitigosTarjeta) {
        this.ultimosDitigosTarjeta = ultimosDitigosTarjeta;
    }

    public String getNombre() {
        return nombre;
    }

    public void setNombre(String nombre) {
        this.nombre = nombre;
    }

    public String getAutorizacion() {
        return autorizacion;
    }

    public void setAutorizacion(String autorizacion) {
        this.autorizacion = autorizacion;
    }
    
     public int getEstadoTransaccion() {
        return estadoTransaccion;
    }

    public void setEstadoTransaccion(int estadoTransaccion) {
        this.estadoTransaccion = estadoTransaccion;
    }

    public String getEstadoTransaccions() {
        return estadoTransaccions;
    }

    public void setEstadoTransaccions(String estadoTransaccions) {
        this.estadoTransaccions = estadoTransaccions;
    }
    
     public double getMonto() {
        return monto;
    }

    public void setMonto(double monto) {
        this.monto = monto;
    }

}
