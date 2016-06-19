package com.uminho.li4.travellingassistant;

import android.content.Intent;
import android.os.Bundle;
import android.support.v7.app.ActionBarActivity;
import android.view.Menu;
import android.view.MenuItem;
import android.view.View;
import android.widget.Button;
import android.widget.TextView;

import java.text.SimpleDateFormat;
import java.util.Calendar;
import java.util.Date;

/**
 * Created by Gustavo on 19/06/2016.
 */
public class UserMenuActivity extends ActionBarActivity {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_user_menu);


        TextView dateView = (TextView) findViewById(R.id.DataValue);
        TextView countryView = (TextView) findViewById(R.id.PaisValue);

        Calendar c = Calendar.getInstance();

        SimpleDateFormat sdf = new SimpleDateFormat("dd/M/yyyy");
        String date = sdf.format(c.getTime());
        dateView.setText( date );
        countryView.setText("Holanda");

        Button list_button = (Button) findViewById(R.id.button_list);

        list_button.setOnClickListener(new View.OnClickListener() {
            public void onClick(View v) {

                Intent intent = new Intent(UserMenuActivity.this, com.uminho.li4.travellingassistant.TaskListActivity.class);
                UserMenuActivity.this.startActivity(intent);

            }
        });

        Button map_button = (Button) findViewById(R.id.button_map);

        map_button.setOnClickListener(new View.OnClickListener() {
            public void onClick(View v) {

                Intent intent = new Intent(UserMenuActivity.this, com.uminho.li4.travellingassistant.UserMapActivity.class);
                UserMenuActivity.this.startActivity(intent);

            }
        });

        Button upload_button = (Button) findViewById(R.id.button_end);
        upload_button.setOnClickListener(new View.OnClickListener() {
            public void onClick(View v) {

            }
        });




    }



    @Override
    public boolean onCreateOptionsMenu(Menu menu) {
        // Inflate the menu; this adds items to the action bar if it is present.
        getMenuInflater().inflate(R.menu.menu_main, menu);
        return true;
    }

    @Override
    public boolean onOptionsItemSelected(MenuItem item) {
        // Handle action bar item clicks here. The action bar will
        // automatically handle clicks on the Home/Up button, so long
        // as you specify a parent activity in AndroidManifest.xml.
        int id = item.getItemId();

        //noinspection SimplifiableIfStatement
        if (id == R.id.action_settings) {
            return true;
        }

        return super.onOptionsItemSelected(item);
    }
}