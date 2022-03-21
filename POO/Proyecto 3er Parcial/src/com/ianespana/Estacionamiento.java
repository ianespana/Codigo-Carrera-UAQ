package com.ianespana;

import java.time.LocalDateTime;
import java.util.ArrayList;
import java.util.InputMismatchException;
import java.util.Scanner;

public class Estacionamiento {
    private int capacidad;
    private float precioPorHora;
    private ArrayList<Pluma> plumas;
    private ArrayList<Tarjeta> cochesEstacionados;
    private ArrayList<Tarjeta> tarjetasRegistradas;

    /**
     Este metodo genera un nuevo estacionamiento
     @param precioPorHora El precio por hora del estacionamiento (se toma por segundo para la simulación)
     @param capacidad La capacidad del estacionamiento
     @param plumas Las plumas de entrada y salida que tiene el estacionamiento
     */
    public Estacionamiento(float precioPorHora, int capacidad, ArrayList<Pluma> plumas){
        this.precioPorHora = precioPorHora;
        this.capacidad = capacidad;
        this.plumas = plumas;
        this.cochesEstacionados = new ArrayList<>();
        this.tarjetasRegistradas = new ArrayList<>();
    }

    /**
     Este metodo asigna un nuevo precio al estacionamiento
     @param precioPorHora El precio por hora del estacionamiento (se toma por segundo para la simulación)
     */
    public void setPrecioPorHora(float precioPorHora){
        this.precioPorHora = precioPorHora;
    }

    /**
     Este metodo regresa las tarjetas de los usuarios estacionados
     @return Las tarjetas de los usuarios estacionados
     */
    public ArrayList<Tarjeta> getCochesEstacionados(){
        return cochesEstacionados;
    }

    /**
     Este metodo regresa las tarjetas registradas en el estacionamiento
     @return Las tarjetas registradas en este estacionamiento
     */
    public ArrayList<Tarjeta> getTarjetasRegistradas(){
        return tarjetasRegistradas;
    }

    /**
     Este metodo intenta registrar una entrada al estacionamiento
     @param tarjeta La tarjeta del usuario que está intentando ingresar al estacionamiento
     @param plumaEntrada La pluma por la que el usuario está intentando ingresar
     @return Un mensaje de estado para el usuario
     */
    public String intentarEntrada(Tarjeta tarjeta, Pluma plumaEntrada){
        if (cochesEstacionados.size() >= capacidad) return "Estacionamiento lleno";
        if (cochesEstacionados.contains(tarjeta)) return "Esta tarjeta ya está en uso";
        cochesEstacionados.add(tarjeta);
        EventoEstacionar eventoEstacionar = new EventoEstacionar(LocalDateTime.now(), tarjeta, precioPorHora);
        tarjeta.setEventoActual(eventoEstacionar);
        plumaEntrada.abrirPluma();

        if (cochesEstacionados.size() >= capacidad){
            for (Pluma pluma : plumas) {
                pluma.setSemaforo(false);
            }
        }
        return "Puedes pasar";
    }

    /**
     Este metodo intenta registrar una salida del estacionamiento
     @param tarjeta La tarjeta del usuario que está intentando salir del estacionamiento
     @param plumaSalida La pluma por la que el usuario está intentando salir
     @param sc Scanner de la clase principal que usaremos para pedir entradas al usuario
     @return Un mensaje de estado para el usuario
     */
    public String intentarSalida(Tarjeta tarjeta, Pluma plumaSalida, Scanner sc){
        if (!cochesEstacionados.contains(tarjeta)) return "Esta tarjeta no está en uso";

        EventoEstacionar eventoEstacionar = tarjeta.getEventoActual();
        eventoEstacionar.setSalida(LocalDateTime.now());
        System.out.println("El monto a pagar sería: " + eventoEstacionar.calcularPrecioTotal());
        System.out.println("¿Deseas recibir la factura? [1] Sí\t[0] No");

        boolean respuestaValida = false;
        while (!respuestaValida){
            try{
                int factura = sc.nextInt();
                if (!(factura == 0 || factura == 1)){
                    System.out.println("Respuesta inválida");
                } else if (factura == 1){
                    System.out.println("Enviando factura");
                    respuestaValida = true;
                } else {
                    respuestaValida = true;
                }
            } catch (Exception e) {
                System.out.println("Respuesta inválida");
                sc.reset();
            }
        }

        cochesEstacionados.remove(tarjeta);
        tarjeta.addHistoriaEstacionados(eventoEstacionar);
        plumaSalida.abrirPluma();

        if (cochesEstacionados.size() < capacidad){
            for (Pluma pluma : plumas) {
                pluma.setSemaforo(true);
            }
        }
        return "Puedes pasar";
    }

    /**
     Este metodo intenta registrar una nueva tarjeta con el estacionamiento
     @param nuevaTarjeta La tarjeta que vamos a registrar
     @return Si se pudo registrar la nueva tarjeta o no
     */
    public boolean registrarTarjeta(Tarjeta nuevaTarjeta){
        boolean duplicada = false;
        for (Tarjeta tarjeta : tarjetasRegistradas){
            if (tarjeta == nuevaTarjeta){
                duplicada = true;
                break;
            }
        }

        if (!duplicada){
            tarjetasRegistradas.add(nuevaTarjeta);
            return true;
        }
        return false;
    }

    /**
     Este metodo intenta recuperar una factura del historial de entradas al estacionamiento relacionada con una tarjeta específica
     @param tarjeta La tarjeta de la que vamos a recuperar una factura
     @param sc Scanner de la clase principal que usaremos para pedir entradas al usuario
     */
    public void generarFactura(Tarjeta tarjeta, Scanner sc){
        ArrayList<EventoEstacionar> historiaEstacionados = tarjeta.getHistoriaEstacionados();
        if (historiaEstacionados.size() == 0) {
            System.out.println("El usuario seleccionado no tiene pagos en su historial");
            return;
        }

        System.out.println("Elige el pago del que requieres factura");
        for (EventoEstacionar eventoEstracionar : historiaEstacionados) {
            System.out.println("[" + historiaEstacionados.indexOf(eventoEstracionar) + "] - " + eventoEstracionar.getEntrada());
        }

        boolean respuestaValida = false;
        while (!respuestaValida){
            try{
                EventoEstacionar eventoEstacionar = historiaEstacionados.get(sc.nextInt());
                System.out.println("Pagaste " + eventoEstacionar.calcularPrecioTotal());
                System.out.println("Enviando factura");
                respuestaValida = true;
            } catch (Exception e) {
                System.out.println("Seleccion inválida");
                sc.reset();
            }
        }
    }
}
