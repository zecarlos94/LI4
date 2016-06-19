package com.uminho.li4.travellingassistant;

import android.content.Intent;
import android.support.v7.app.ActionBarActivity;
import android.os.Bundle;
import android.view.Menu;
import android.view.MenuItem;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;


public class TextInputActivity extends ActionBarActivity {

    public static int SAVE_TEXT = 5;

    public EditText editor;
    public String textSaved;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.text_input);

        editor = (EditText) findViewById(R.id.editText);

        Button save_button = (Button) findViewById(R.id.b_done);
        // config listener for login activity
        save_button.setOnClickListener(new View.OnClickListener() {
            public void onClick(View v) {

                textSaved = editor.getText().toString();
                if (textSaved.length() == 0)
                    textSaved = null;
                end();
            }
        });
        

        Button cancel_button = (Button) findViewById(R.id.b_cancel);
        // config listener for login activity
        cancel_button.setOnClickListener(new View.OnClickListener() {
            public void onClick(View v) {

                textSaved = null;
                end();
            }
        });

    }

    public void end(){
        Intent intent = new Intent();
        if(textSaved!= null) {
            intent.putExtra("textValue",textSaved);
            setResult(SAVE_TEXT,intent);
        } else {
            intent.putExtra("textValue","");
            setResult(-1,intent);
        }
        this.finish();
    }

    @Override
    public void onBackPressed(){
        textSaved = null;
        super.onBackPressed();
    }


    @Override
    public boolean onCreateOptionsMenu(Menu menu) {
        // Inflate the menu; this adds items to the action bar if it is present.
        getMenuInflater().inflate(R.menu.menu_text_input, menu);
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
