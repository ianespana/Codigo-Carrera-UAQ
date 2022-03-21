package com.ianespana;

import java.time.Duration;
import java.time.LocalDateTime;

public class EventoEstacionar {
    private LocalDateTime entrada;
    private LocalDateTime salida;
    private Tarjeta tarjeta;
    private float precioPorHora;

    /**
     Este metodo genera un nuevo evento de estacionamiento (entrada y salida)
     @param entrada La fecha y hora en la que se ingresó al estaciomiento
     @param tarjeta La tarjeta del usuario
     @param precioPorHora El precio por hora del estacionamiento (se toma por segundo para la simulación)
     */
    public EventoEstacionar(LocalDateTime entrada, Tarjeta tarjeta, float precioPorHora){
        this.entrada = entrada;
        this.tarjeta = tarjeta;
        this.precioPorHora = precioPorHora;
    }

    /**
     Este metodo asigna una fecha y hora de salida al evento de estacionamiento
     @param salida La fecha y hora en la que se salió del estaciomiento
     */
    public void setSalida(LocalDateTime salida){
        this.salida = salida;
    }

    /**
     Este metodo regresa la fecha y hora de salida del evento de estacionamiento
     @return La fecha y hora en la que se salió del estaciomiento
     */
    public LocalDateTime getSalida(){
        return salida;
    }

    /**
     Este metodo regresa la fecha y hora de ingreso del evento de estacionamiento
     @return La fecha y hora en la que se ingresó del estaciomiento
     */
    public LocalDateTime getEntrada(){
        return entrada;
    }

    /**
     Este metodo regresa la tarjeta relacionada con el evento de estacionamiento
     @return La tarjeta asociada con el evento
     */
    public Tarjeta getTarjeta(){
        return tarjeta;
    }

    /**
     Este metodo regresa el tiempo transcurrido entre el ingreso y la salida del evento de estacionamiento
     @return El tiempo transcurrido
     */
    public Duration getDuracion(){ // Obtiene el tiempo que estuvo estacionado el coche
        return Duration.between(entrada, salida);
    }

    /**
     Este metodo regresa el precio por hora del estacionamiento
     @return El precio por hora
     */
    public float getPrecioPorHora(){
        return precioPorHora;
    }

    /**
     Este metodo calcula el precio final que deberá pagar el usuario basado en el tiempo que pasó dentro del estacionamiento y el precio por hora
     @return El precio final
     */
    public float calcularPrecioTotal(){
        long horas = this.getDuracion().toSeconds() + 1;
        return horas * precioPorHora;
    }
}
