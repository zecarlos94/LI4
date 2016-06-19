package com.uminho.li4.travellingassistant;
import android.app.Activity;
import android.content.Context;
import android.graphics.Color;
import android.util.TypedValue;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.ArrayAdapter;
import android.widget.Button;
import android.widget.TextView;


public class TasksListAdapter extends ArrayAdapter<Task>{
    Context mContext;
    int layoutResourceId;
    Task data[] = null;
/*
    static class ViewHolder {
        public TextView taskInfo;
        public LinearLayout taskOptions;
    }
*/
    public TasksListAdapter(TaskListActivity mContext, int layoutResourceId, Task[] data) {
        super(mContext, layoutResourceId, data);
        this.layoutResourceId = layoutResourceId;
        this.mContext = mContext;
        this.data = data;
    }

    @Override
    public View getView(int position, View convertView, ViewGroup parent) {

        if(convertView==null){
            // inflate the layout
            LayoutInflater inflater = ((Activity) mContext).getLayoutInflater();
            convertView = inflater.inflate(layoutResourceId, parent, false);
        }
        // object item based on the position
        Task Task = data[position];

        // get the TextView and then set the text (item name) and tag (item ID) values
        if(Task.selected){
            ViewGroup viewGroupItem = (ViewGroup) convertView.findViewById(R.id.selected_layout);

            if(viewGroupItem.getChildCount() == 4) {
                return convertView;
            }

            Button textEntry = new Button(mContext);
            Button voiceEntry = new Button(mContext);
            Button photoEntry = new Button(mContext);

            textEntry.setText("Entrada de texto");
            voiceEntry.setText("Captar voz");
            photoEntry.setText("Captar fotografia");

            textEntry.setTextColor(Color.parseColor("#ffffffff"));
            voiceEntry.setTextColor(Color.parseColor("#ffffffff"));
            photoEntry.setTextColor(Color.parseColor("#ffffffff"));

            textEntry.setBackgroundColor(Color.parseColor("#eb000000"));
            voiceEntry.setBackgroundColor(Color.parseColor("#eb000000"));
            photoEntry.setBackgroundColor(Color.parseColor("#eb000000"));

            textEntry.setTextSize(TypedValue.COMPLEX_UNIT_SP,18);
            voiceEntry.setTextSize(TypedValue.COMPLEX_UNIT_SP, 18);
            photoEntry.setTextSize(TypedValue.COMPLEX_UNIT_SP, 18);





            textEntry.setOnClickListener(new View.OnClickListener() {
                public void onClick(View v) {
                    ((TaskListActivity) mContext).editText();

                }
            });


            photoEntry.setOnClickListener(new View.OnClickListener() {
            public void onClick(View v) {
                ((TaskListActivity) mContext).takePicture();

            }
        });

        voiceEntry.setOnClickListener(new View.OnClickListener() {
            public void onClick(View v) {
                ((TaskListActivity) mContext).recordSound();
            }
        });

            TextView textViewItem = (TextView)viewGroupItem.getChildAt(0);
            textViewItem.setText(Task.toString());
            textViewItem.setTag(Task.id);
        viewGroupItem.addView(textEntry);
        viewGroupItem.addView(voiceEntry);
        viewGroupItem.addView(photoEntry);
        viewGroupItem.setVisibility(View.VISIBLE);

        }else {
            ViewGroup viewGroupItem = (ViewGroup) convertView.findViewById(R.id.selected_layout);

            if(viewGroupItem.getChildCount() == 4){
                TextView t = (TextView) viewGroupItem.getChildAt(0);
                viewGroupItem.removeAllViews();
                viewGroupItem.addView(t);
            }

             TextView textViewItem = (TextView) convertView.findViewById(R.id.textViewItem);
             textViewItem.setText(Task.toString());
             textViewItem.setTag(Task.id);
            }
        return convertView;
    }



}
