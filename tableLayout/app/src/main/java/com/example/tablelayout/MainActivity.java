package com.example.tablelayout;

import androidx.appcompat.app.AppCompatActivity;

import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.TableLayout;

import java.util.List;

public class MainActivity extends AppCompatActivity {
    private boolean flag = false;
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
    }

    public void collapseTable(View view){
        TableLayout table = findViewById(R.id.table);
        Button btnSwitch = findViewById(R.id.switchBtn);

        table.setColumnCollapsed(0, flag);
        table.setColumnCollapsed(2, flag);
        if(flag){
            flag = false;
            btnSwitch.setText("Ver Detalles");
        }else{
            flag = true;
            btnSwitch.setText("Ocultar Detalles");
        }

        List<Cliente> lstCliente;
    }

    public class Cliente{
        private int nombre;
        private String direccion;
    }
}