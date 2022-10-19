package com.example.pruebaconsumowsjava;

import androidx.appcompat.app.AppCompatActivity;

import android.os.AsyncTask;
import android.os.Bundle;
import android.util.Log;
import android.view.View;
import android.widget.Button;
import android.widget.TableLayout;
import android.widget.TextView;
import android.widget.Toast;

import org.ksoap2.SoapEnvelope;
import org.ksoap2.SoapFault;
import org.ksoap2.serialization.SoapObject;
import org.ksoap2.serialization.SoapPrimitive;
import org.ksoap2.serialization.SoapSerializationEnvelope;
import org.ksoap2.transport.HttpResponseException;
import org.ksoap2.transport.HttpTransportSE;
import org.xmlpull.v1.XmlPullParserException;

import org.xmlpull.v1.XmlPullParserException;

import java.io.IOException;
import java.net.Proxy;
import java.util.List;
import java.util.Vector;

public class MainActivity extends AppCompatActivity {

    private Button btnConsumir;

    String resultado="";
    String valor, msj;
    SoapObject result;


    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

       // txtResultado =  findViewById(R.id.txtResultado);
        btnConsumir = findViewById(R.id.btnConsumir);


        btnConsumir.setOnClickListener(new View.OnClickListener(){
            @Override
            public void onClick(View view){
                segundoPlano tarea = new segundoPlano();
                tarea.execute();
            }
        });
    }

    private class segundoPlano extends AsyncTask<String,Void,String> {
        String METHOD_NAME = "getTransaccionesParaCierre";
        String NAMESPACE = "http://servicio.org/";
        String SOAP_ACTION =NAMESPACE+METHOD_NAME;
        String URL = "http://192.168.0.5:23398/ServiciosWebProyecto/ObtenerTransaccionesCierre?WSDL";


        @Override
        protected String doInBackground(String... params) {

            SoapObject request = new SoapObject(NAMESPACE,METHOD_NAME);
            SoapSerializationEnvelope envelope = new SoapSerializationEnvelope(SoapEnvelope.VER11);
            envelope.dotNet = false;
            envelope.setOutputSoapObject(request);
            HttpTransportSE transporte = new HttpTransportSE(URL);

            Log.d("transporte", request.toString());


            try {
                transporte.call(SOAP_ACTION, envelope);
                //SoapPrimitive response = (SoapPrimitive) envelope.getResponse();

                SoapObject response = (SoapObject) envelope.bodyIn;
                result = (SoapObject) response;



                for (int i = 0; i< result.getPropertyCount(); i++)
                {
                    SoapObject transaccion = (SoapObject) response.getProperty(i);
                    String nombre = transaccion.getProperty("nombre").toString();
                    String idTransaccion = transaccion.getProperty("idTransaccion").toString();
                    Log.d("nombre", nombre);
                    Log.d("idTransaccion", idTransaccion);

                }

                Log.d("result", result.toString());
                return "Ok";
            }catch(Exception ex){
                Log.e("ex", ex.getMessage());
                return null;
            }
        }

        @Override
        protected void onPreExecute(){
        }

        @Override
        protected void onPostExecute(String s) {
            if(s=="OK"){
               // txtResultado.setText(s);
            }
        }

    }

}


