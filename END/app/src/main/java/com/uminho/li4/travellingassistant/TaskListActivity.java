package com.uminho.li4.travellingassistant;

import android.app.ListActivity;
import android.content.Intent;
import android.graphics.Color;
import android.net.Uri;
import android.provider.MediaStore;
import android.os.Bundle;
import android.util.TypedValue;
import android.view.MenuItem;
import android.view.View;
import android.widget.TextView;
import android.widget.Toast;


public class TaskListActivity extends ListActivity {

    public Task tasks[];

    static final int REQUEST_IMAGE_CAPTURE = 1; boolean imageTaken;
    static final int RECORD_REQUEST = 0; boolean voiceTaken;

    private Uri audioFileUri;



    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
       // setContentView(R.layout.activity_task_list);

        tasks = new Task[30];
        for(int i = 0 ; i < 30;i++)
            tasks[i] = new Task(i,"placeName"+i);


        TextView header = (TextView) getLayoutInflater().inflate(R.layout.list_header,null);
        getListView().addHeaderView(header);

        // our adapter instance
        TasksListAdapter adapter = new TasksListAdapter(this, R.layout.list_view_item, tasks);

        //  set the adapter and item click listener
        setListAdapter(adapter);




        OnItemClickListenerListViewItem clickListener = new OnItemClickListenerListViewItem();
        clickListener.setListAdapter(adapter,tasks);
        getListView().setOnItemClickListener(clickListener);

    }


    @Override
    protected void onActivityResult(int requestCode, int resultCode, Intent data) {
        if (requestCode == REQUEST_IMAGE_CAPTURE && resultCode == RESULT_OK) {
            // saves picture
            // tutorial: http://developer.android.com/training/camera/photobasics.html
            Toast.makeText(TaskListActivity.this, "SAVED: IMAGE", Toast.LENGTH_LONG).show();

        }else if(requestCode == RECORD_REQUEST && resultCode == RESULT_OK){
            // save voice: http://developer.android.com/reference/android/provider/MediaStore.Audio.Media.html#RECORD_SOUND_ACTION
            // http://www.java2s.com/Code/Android/Core-Class/UsingIntenttorecordaudio.htm
            Toast.makeText(TaskListActivity.this, "SAVED: AUDIO", Toast.LENGTH_LONG).show();

            audioFileUri = data.getData();
        } else if(requestCode == TextInputActivity.SAVE_TEXT && resultCode > 0){
            String text = data.getStringExtra("textValue");
            Toast.makeText(TaskListActivity.this, "SAVED: " +text, Toast.LENGTH_LONG).show();

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

    public void editText(){

        Intent intent = new Intent(TaskListActivity.this, com.uminho.li4.travellingassistant.TextInputActivity.class);
        startActivityForResult(intent, TextInputActivity.SAVE_TEXT);

    }

}
