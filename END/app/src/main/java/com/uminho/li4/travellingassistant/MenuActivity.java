package com.uminho.li4.travellingassistant;

import android.content.Intent;
import android.net.Uri;
import android.provider.MediaStore;
import android.support.v7.app.ActionBarActivity;
import android.os.Bundle;
import android.view.Menu;
import android.view.MenuItem;
import android.view.View;
import android.widget.Button;


public class MenuActivity extends ActionBarActivity {

    static final int REQUEST_IMAGE_CAPTURE = 1; boolean imageTaken;
    static final int RECORD_REQUEST = 0; boolean voiceTaken;

    private Uri audioFileUri;
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_menu);

        Button button_cam = (Button)findViewById(R.id.button_cam);

        button_cam.setOnClickListener(new View.OnClickListener() {
            public void onClick(View v) {
                takePicture();

            }
        });

        Button button_voice = (Button)findViewById(R.id.button_voice);

        button_voice.setOnClickListener(new View.OnClickListener() {
            public void onClick(View v) {
                recordSound();

            }
        });

    }

    public void takePicture(){

        Intent takePictureIntent = new Intent(MediaStore.ACTION_IMAGE_CAPTURE);
        // resolveActivity() returns first activity component that can handle the intent
        if (takePictureIntent.resolveActivity(getPackageManager()) != null) {
            startActivityForResult(takePictureIntent, REQUEST_IMAGE_CAPTURE);
            imageTaken = true;
        }

    }

    public void recordSound(){

        Intent intent = new Intent(MediaStore.Audio.Media.RECORD_SOUND_ACTION);
        startActivityForResult(intent, RECORD_REQUEST);
        voiceTaken = true;
    }

    @Override
    protected void onActivityResult(int requestCode, int resultCode, Intent data) {
        if (requestCode == REQUEST_IMAGE_CAPTURE && resultCode == RESULT_OK) {
            // saves picture
            // tutorial: http://developer.android.com/training/camera/photobasics.html
        }else if(requestCode == RECORD_REQUEST && resultCode == RESULT_OK){
            // save voice: http://developer.android.com/reference/android/provider/MediaStore.Audio.Media.html#RECORD_SOUND_ACTION
            // http://www.java2s.com/Code/Android/Core-Class/UsingIntenttorecordaudio.htm
            audioFileUri = data.getData();
        }
    }

    @Override
    public boolean onCreateOptionsMenu(android.view.Menu menu) {
        // Inflate the menuActivity; this adds items to the action bar if it is present.
        getMenuInflater().inflate(R.menu.menu_menu, menu);
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
