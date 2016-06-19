package com.uminho.li4.travellingassistant;
import android.app.Activity;
import android.content.Context;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.AdapterView;
import android.widget.ArrayAdapter;
import android.widget.TextView;
import android.widget.Toast;

import android.widget.AdapterView.OnItemClickListener;
public class OnItemClickListenerListViewItem implements OnItemClickListener {
    TasksListAdapter listAdapter;
    Task tasks[];
    int lastSelected = -1;
    public void setListAdapter(TasksListAdapter listAdapter, Task tasks[]){
        this.listAdapter = listAdapter; this.tasks = tasks;
    }

    @Override
    public void onItemClick(AdapterView<?> parent, View view, int position, long id) {
        Context context = view.getContext();
/*
        TextView textViewItem = ((TextView) view.findViewById(R.id.textViewItem));

        // get the clicked item name
        String listItemText = textViewItem.getText().toString();
        // get the clicked item ID
        String listItemId = textViewItem.getTag().toString();
        */
      /*
        TextView textViewItem = ((TextView) view.findViewById(R.id.textViewItem));
        String listItemText = textViewItem.getText().toString();
        String listItemId = textViewItem.getTag().toString();


        Task t = (Task)parent.getItemAtPosition(Integer.parseInt(listItemId));
    */
        Task t = tasks[(int)id];
        if( !t.selected ) {
            t.selected = true;
            if(lastSelected > -1 && lastSelected!= (int)id )
                tasks[lastSelected].selected = false;

            lastSelected = (int)id;
            listAdapter.notifyDataSetChanged();

        }
        /*
        Toast.makeText(context, "Item: " + listItemText + ", Item ID: " + listItemId, Toast.LENGTH_SHORT).show();
        ((MainActivity) context).alertDialogStores.cancel();
        */
    }

}