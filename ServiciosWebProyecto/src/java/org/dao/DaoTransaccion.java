/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package org.dao;

import java.sql.ResultSet;
import java.util.ArrayList;
import java.util.List;
import java.util.logging.Level;
import java.util.logging.Logger;
import org.config.Conexion;
import org.modelos.ModelTransaccion;

/**
 *
 * @author Alejandra Morataya
 */
public class DaoTransaccion {

    //Se crea un objeto publico del Cliente
    ModelTransaccion transaccion = new ModelTransaccion();
    String strSql = "";
    //Se crea un obejto de tipo conexión para manejar la persistencia hacia la base de datos
    Conexion conexion = new Conexion();
    //Obtiene el resultado de las consultas SQL
    ResultSet rs = null;
    //flag para retornar si la sentencia SQL fue satisfactorio o no
    boolean respuesta = false;

    //Método que obtiene la consulta de la tabla Clliente
    public List<ModelTransaccion> getListaTransacciones() {
        List<ModelTransaccion> lstTransaccion = new ArrayList<ModelTransaccion>();
        try {
            strSql = "SELECT ID_TRANSACCION, "
                    + "ULTIMOS_DIGITOS_TARJETA, "
                    + "NOMBRE, "
                    + "AUTORIZACION, "
                    + "ID_ESTADO_TRANSACCION, "
                    + "MONTO,"
                    + "(SELECT ET.DES_ESTADO_TRANSACCION FROM TB_CAT_ESTADO_TRANSACCION ET WHERE ET.ID_ESTADO_TRANSACCION = TP.ID_ESTADO_TRANSACCION ) "
                    + "ESTADO_TRANSACCION from TB_TRANSACCION_PAGO TP WHERE ID_ESTADO_TRANSACCION = 1;";
            conexion.open();
            rs = conexion.executeQuery(strSql);

            while (rs.next()) {
                ModelTransaccion transaccion = new ModelTransaccion();
                transaccion.setIdTransaccion(Integer.parseInt(rs.getString("ID_TRANSACCION")));
                transaccion.setUltimosDitigosTarjeta(rs.getString("ULTIMOS_DIGITOS_TARJETA"));
                transaccion.setNombre(rs.getString("NOMBRE"));
                transaccion.setAutorizacion(rs.getString("AUTORIZACION"));
                transaccion.setEstadoTransaccion(Integer.parseInt(rs.getString("ID_ESTADO_TRANSACCION")));
                 transaccion.setEstadoTransaccions(rs.getString("ESTADO_TRANSACCION"));
                lstTransaccion.add(transaccion);
            }
            rs.close();
            conexion.close();

        } catch (ClassNotFoundException ex) {
            Logger.getLogger(DaoTransaccion.class.getName()).log(Level.SEVERE, null, ex);
        } catch (Exception ex) {
            Logger.getLogger(DaoTransaccion.class.getName()).log(Level.SEVERE, null, ex);
        }

        return lstTransaccion;
    }

    //Método para hacer la inserción del cliente en la BD
    public boolean insertarCliente(ModelTransaccion transaccion) {
        //Se prepara la sentencia SQL a ejecutar en la BD
        strSql = "INSERT INTO TB_TRANSACCION_PAGO (ULTIMOS_DIGITOS_TARJETA, NOMBRE, AUTORIZACION, MONTO,ID_ESTADO_TRANSACCION) "
                + "VALUES('" + transaccion.getUltimosDitigosTarjeta() + "', "
                + "'" + transaccion.getNombre() + "', "
                + "'" + transaccion.getAutorizacion() + "', "
                +  transaccion.getMonto() + ", "
                + "" + transaccion.getEstadoTransaccion() + ")";

        try {
            //se abre una conexión hacia la BD
            conexion.open();
            //Se ejecuta la instrucción y retorna si la ejecución fue satisfactoria
            respuesta = conexion.executeSql(strSql);
            //Se cierra la conexión hacia la BD
            conexion.close();

        } catch (ClassNotFoundException ex) {
            Logger.getLogger(DaoTransaccion.class.getName()).log(Level.SEVERE, null, ex);
            return false;
        } catch (Exception ex) {
            Logger.getLogger(DaoTransaccion.class.getName()).log(Level.SEVERE, null, ex);
        }
        return respuesta;
    }

}
