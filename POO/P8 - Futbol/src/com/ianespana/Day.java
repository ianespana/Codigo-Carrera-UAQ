package com.ianespana;

public class Day {
    private float temperature;
    // Se podría implementar un dato tipo Date para identificar el día
    private int id;

    public Day(int id, float temperature){
        this.id = id;
        this.temperature = temperature;
    }

    public void setId(int id){
        this.id = id;
    }

    public int getId(){
        return id;
    }

    public void setTemperature(float temperature){
        this.temperature = temperature;
    }

    public float getTemperature(){
        return temperature;
    }
}
