package com.uminho.li4.travellingassistant;

/**
 * Created by Gustavo on 16/06/2016.
 */
public class Task {
    public int id;
    public String name;
    public String horas = "00:00";
    public boolean selected;

    public Task(int itemId,String n){
        id = itemId;
        name = n;
        selected = false;
    }

    @Override
    public String toString(){
        return "Visita a " + name +" as horas: " + horas;
    }

}
