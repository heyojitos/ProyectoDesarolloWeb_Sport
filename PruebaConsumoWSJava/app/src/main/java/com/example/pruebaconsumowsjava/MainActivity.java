package com.example.pruebaconsumowsjava;

import androidx.appcompat.app.AppCompatActivity;

import android.annotation.SuppressLint;
import android.app.Dialog;
import android.content.Intent;
import android.graphics.Color;
import android.os.AsyncTask;
import android.os.Bundle;
import android.util.Log;
import android.view.Gravity;
import android.view.View;
import android.view.ViewGroup;
import android.view.Window;
import android.widget.ArrayAdapter;
import android.widget.Button;
import android.widget.TableLayout;
import android.widget.TableRow;
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
import java.util.ArrayList;
import java.util.List;
import java.util.Vector;

public class MainActivity extends AppCompatActivity {

    private Button btnConsumir;
    private Button btnCierre;
    private TextView tvMensaje;

    SoapObject result;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        btnConsumir = findViewById(R.id.btnConsumir);
        btnCierre = findViewById(R.id.btnCierre);
        tvMensaje = findViewById(R.id.tvMensaje);


        btnConsumir.setOnClickListener(new View.OnClickListener(){
            @Override
            public void onClick(View view){
                segundoPlano tarea = new segundoPlano();
                tarea.execute();
            }
        });

        btnCierre.setOnClickListener(new View.OnClickListener(){
            @Override
            public void onClick(View view){
                segundoPlanoCierre tarea2 = new segundoPlanoCierre();
                tarea2.execute();
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
            Log.d("s", s);
           if(s.equals("Ok")&&(result.getPropertyCount()>0)){
            //requestWindowFeature(Window.FEATURE_NO_TITLE);
            setContentView(R.layout.activity_main);
            init();
            }else{
               tvMensaje.setText("NO HAY TRANSACCIONES PENDIENTES");

           }

            //setContentView(R.layout.activity_main);

        }

        }

    private class segundoPlanoCierre extends AsyncTask<String,Void,String> {
        String METHOD_NAME = "cierre";
        String NAMESPACE = "http://servicio.org/";
        String SOAP_ACTION =NAMESPACE+METHOD_NAME;
        String URL = "http://192.168.0.5:23398/ServiciosWebProyecto/RealizarCierre?WSDL";

        @SuppressLint("LongLogTag")
        @Override
        protected String doInBackground(String... strings) {
            SoapObject request = new SoapObject(NAMESPACE,METHOD_NAME);
            SoapSerializationEnvelope envelope = new SoapSerializationEnvelope(SoapEnvelope.VER11);
            envelope.dotNet = false;
            envelope.setOutputSoapObject(request);
            HttpTransportSE transporte = new HttpTransportSE(URL);

            Log.d("transporte", request.toString());


            try {
                transporte.call(SOAP_ACTION, envelope);
                SoapPrimitive response = (SoapPrimitive) envelope.getResponse();
                //SoapObject response = (SoapObject) envelope.bodyIn;

                Log.d("Cierre", "actualizado correctamente");
                return "Ok";
            }catch(Exception ex){
                Log.e("ex", ex.getMessage());
                return null;
            }
        }
        @Override
        protected void onPreExecute(){
            tvMensaje.setText("");


           /* TableLayout stk = (TableLayout) findViewById(R.id.table_main);
            int count = stk.getChildCount();
            for (int i = 0; i < count; i++) {
                View child = stk.getChildAt(i);
                if (child instanceof TableRow)
                    ((ViewGroup) child).removeAllViews(); }*/

        }
        @Override
        protected void onPostExecute(String s) {

        }

    }

    public void init() {
        TableLayout stk = (TableLayout) findViewById(R.id.table_main);

        TableRow tbrow0 = new TableRow(this);

        TextView tv0 = new TextView(this);
        tv0.setText("  ID  ");
        tv0.setTextColor(Color.WHITE);
        tbrow0.addView(tv0);

        TextView tv1 = new TextView(this);
        tv1.setText("       NOMBRE       ");
        tv1.setTextColor(Color.WHITE);
        tbrow0.addView(tv1);

        TextView tv2 = new TextView(this);
        tv2.setText("    MONTO    ");
        tv2.setTextColor(Color.WHITE);
        tbrow0.addView(tv2);

        TextView tv3 = new TextView(this);
        tv3.setText("   ESTADO   ");
        tv3.setTextColor(Color.WHITE);
        tbrow0.addView(tv3);

        stk.addView(tbrow0);

      /*  for (int i = 0; i< result.getPropertyCount(); i++)
        {
            SoapObject transaccion = (SoapObject) result.getProperty(i);
            String nombre = transaccion.getProperty("nombre").toString();
            String idTransaccion = transaccion.getProperty("idTransaccion").toString();
            Log.d("nombre", nombre);
            Log.d("idTransaccion", idTransaccion);

        }*/

        for (int i = 0; i< result.getPropertyCount(); i++) {
            TableRow tbrow = new TableRow(this);
            SoapObject transaccion = (SoapObject) result.getProperty(i);

            TextView t1v = new TextView(this);
            String idTransaccion = transaccion.getProperty("idTransaccion").toString();
            t1v.setText(idTransaccion);
            t1v.setTextColor(Color.WHITE);
            t1v.setGravity(Gravity.CENTER);
            tbrow.addView(t1v);

            TextView t2v = new TextView(this);
            String nombre = transaccion.getProperty("nombre").toString();
            t2v.setText(nombre);
            t2v.setTextColor(Color.WHITE);
            t2v.setGravity(Gravity.CENTER);
            tbrow.addView(t2v);

            TextView t3v = new TextView(this);
            String monto = transaccion.getProperty("monto").toString();
            t3v.setText(monto);
            t3v.setTextColor(Color.WHITE);
            t3v.setGravity(Gravity.CENTER);
            tbrow.addView(t3v);

            TextView t4v = new TextView(this);
            String estado = transaccion.getProperty("estadoTransaccions").toString();
            t4v.setText(estado);
            t4v.setTextColor(Color.WHITE);
            t4v.setGravity(Gravity.CENTER);
            tbrow.addView(t4v);
            stk.addView(tbrow);
        }
        

    }



}


