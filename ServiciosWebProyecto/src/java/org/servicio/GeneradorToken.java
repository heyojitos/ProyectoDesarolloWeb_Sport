/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/WebServices/WebService.java to edit this template
 */
package org.servicio;

import java.security.SecureRandom;
import javax.jws.WebService;
import javax.jws.WebMethod;
import javax.jws.WebParam;

/**
 *
 * @author Alejandra Morataya
 */
@WebService(serviceName = "GeneradorToken")
public class GeneradorToken {

    @WebMethod(operationName = "getToken")
    public String getToken(
            @WebParam(name = "nombre") String nombre,
            @WebParam(name = "numeroTarjeta") String numeroTarjeta,
            @WebParam(name = "mes") int mes,
            @WebParam(name = "anio") int anio,
            @WebParam(name = "cvv") String cvv) {

        if (validarNumeroTarjeta(numeroTarjeta) && validarAnioyMes(mes, anio) && validarCvv(cvv)) {
            return generateRandomString(32);
        }
        
        return null; 
    }

    private boolean validarNumeroTarjeta(String numeroTarjeta) {
        if (numeroTarjeta.length() == 16) {
            return true;
        }
        return false;
    }

    private boolean validarAnioyMes(int mes, int anio) {
        if (anio < 2022) {
            return false;
        } else if (anio == 2022 && mes <= 10) {
            return false;
        }
        return true;
    }

    private boolean validarCvv(String cvv) {
        if (cvv.length() == 3) {
            return true;
        }
        return false;
    }

    public static String generateRandomString(int length) {
        String CHAR_LOWER = "abcdefghijklmnopqrstuvwxyz";
        String CHAR_UPPER = CHAR_LOWER.toUpperCase();
        String NUMBER = "0123456789";

        String DATA_FOR_RANDOM_STRING = CHAR_LOWER + CHAR_UPPER + NUMBER;
        SecureRandom random = new SecureRandom();

        if (length < 1) {
            throw new IllegalArgumentException();
        }

        StringBuilder sb = new StringBuilder(length);

        for (int i = 0; i < length; i++) {
            // 0-62 (exclusivo), retorno aleatorio 0-61
            int rndCharAt = random.nextInt(DATA_FOR_RANDOM_STRING.length());
            char rndChar = DATA_FOR_RANDOM_STRING.charAt(rndCharAt);

            sb.append(rndChar);
        }

        return sb.toString();
    }
}
