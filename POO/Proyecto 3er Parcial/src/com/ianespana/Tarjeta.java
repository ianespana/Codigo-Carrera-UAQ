package com.ianespana;

import java.util.ArrayList;
import java.util.Objects;

public class Tarjeta {
    private String id;
    private Usuario usuario;
    private ArrayList<EventoEstacionar> historiaEstacionados;
    private EventoEstacionar eventoActual;

    /**
     * Construye una nuevo tarjeta
     * @param id El ID de esta tarjeta
     * @param usuario El usuario asociado con esta tarjeta
     */
    public Tarjeta(String id, Usuario usuario){
        this.id = id;
        this.usuario = usuario;
        historiaEstacionados = new ArrayList<>();
    }

    /**
     Este método regresa el ID asociado con la tarjeta
     @return El ID de la tarjeta
     */
    public String getId(){
        return id;
    }

    /**
     Este método regresa el usuario asociado con la tarjeta
     @return El usuario asociado con la tarjeta
     */
    public Usuario getUsuario(){
        return usuario;
    }

    /**
     Este método regresa el historial de pagos del estacionamiento asociados con la tarjeta
     @return El historial de pagos
     */
    public ArrayList<EventoEstacionar> getHistoriaEstacionados(){
        return historiaEstacionados;
    }

    /**
     Este método agrega un evento de estacionamiento al historial de la tarjeta
     @param eventoEstacionar El evento a añadir al historial
     */
    public void addHistoriaEstacionados(EventoEstacionar eventoEstacionar){
        historiaEstacionados.add(eventoEstacionar);
    }

    /**
     Este método regresa el evento de estacionamiento actual
     @return El evento de estacionamiento actual
     */
    public EventoEstacionar getEventoActual(){
        return eventoActual;
    }

    /**
     Este método asigna el evento de estacionamiento actual relacionado con la tarjeta
     @param eventoActual El evento a añadir
     */
    public void setEventoActual(EventoEstacionar eventoActual){
        this.eventoActual = eventoActual;
    }

    @Override
    public boolean equals(Object o){
        if(o == this) return true;
        if(!(o instanceof Tarjeta tarjeta)) return false;

        return Objects.equals(this.id, tarjeta.id);
    }

    @Override
    public String toString(){
        String info = "ID: " + id + "\n\t";
        info += usuario;
        return info;
    }
}
