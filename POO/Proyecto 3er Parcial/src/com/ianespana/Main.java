package com.ianespana;

import java.util.ArrayList;
import java.util.Random;
import java.util.Scanner;

public class Main {
    /**
     Este metodo genera una cadena de caracteres alfabéticos
     @param length El tamaño de la cadena
     @return La caderna generada
     */
    public static String randomAlphaString(int length){
        int leftLimit = 97; // letter 'a'
        int rightLimit = 122; // letter 'z'
        Random random = new Random();

        return random.ints(leftLimit, rightLimit + 1)
                .limit(length)
                .collect(StringBuilder::new, StringBuilder::appendCodePoint, StringBuilder::append)
                .toString();
    }

    /**
     Este metodo genera una cadena de caracteres alfanuméricos
     @param length el tamaño de la cadena
     @return la caderna generada
     */
    public static String randomAlphaNumString(int length){
        int leftLimit = 48; // number '0'
        int rightLimit = 122; // letter 'z'
        Random random = new Random();

        return random.ints(leftLimit, rightLimit + 1)
                .filter(i -> (i <= 57 || i >= 65) && (i <= 90 || i >= 97))
                .limit(length)
                .collect(StringBuilder::new, StringBuilder::appendCodePoint, StringBuilder::append)
                .toString();
    }

    /**
     Este metodo genera una cadena de caracteres que se encuentran entre el código asciiInicial y asciiFinal
     @param length El tamaño de la cadena
     @param leftLimit El limite inicial (código ASCII) a partir del cuál generar caracteres
     @param rightLimit El limite final (código ASCII) hasta el cuál generar caracteres
     @return La caderna generada
     */
    public static String randomAlphaNumString(int length, int leftLimit, int rightLimit){
        Random random = new Random();

        return random.ints(leftLimit, rightLimit + 1)
                .filter(i -> (i <= 57 || i >= 65) && (i <= 90 || i >= 97))
                .limit(length)
                .collect(StringBuilder::new, StringBuilder::appendCodePoint, StringBuilder::append)
                .toString();
    }

    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        ArrayList<Pluma> plumas = new ArrayList<>();
        ArrayList<Tarjeta> tarjetas = new ArrayList<>();

        Pluma plumaEntrada = new Pluma(true);
        Pluma plumaSalida = new Pluma(false);
        plumas.add(plumaEntrada);
        plumas.add(plumaSalida);

        Estacionamiento estacionamiento = new Estacionamiento(5.0f, 5, plumas);

        for (int i = 0; i < 20; i++) {
            Usuario usuario = new Usuario(randomAlphaString(10), randomAlphaString(30), randomAlphaNumString(10, 48, 57), randomAlphaNumString(13));
            Tarjeta tarjeta = new Tarjeta(Integer.toString(i), usuario);
            tarjetas.add(tarjeta);
            estacionamiento.registrarTarjeta(tarjeta);
        }

        boolean ejecutar = true;
        while(ejecutar){
            System.out.println("Menu de opciones:\n\t[1] Registrar entrada\n\t[2] Registrar salida\n\t[3] Obtener factura anterior\n\t[4] Cambiar precio por hora (se toma por segundo para la simulación)\n\t[5] Listar tarjetas registradas\n\t[6] Listar tarjetas estacionadas\n\t[7] Detener programa");
            switch (sc.nextInt()) {
                case 1 -> {
                    System.out.println("Ingresa el ID del usuario [0-" + (tarjetas.size() - 1) + "]");
                    try{
                        System.out.println(estacionamiento.intentarEntrada(tarjetas.get(sc.nextInt()), plumaEntrada));
                    } catch (Exception e){
                        System.out.println("Selección inválida");
                    }
                }
                case 2 -> {
                    System.out.println("Ingresa el ID del usuario [0-" + (tarjetas.size() - 1) + "]");
                    try{
                        System.out.println(estacionamiento.intentarSalida(tarjetas.get(sc.nextInt()), plumaSalida, sc));
                    } catch (Exception e){
                        System.out.println("Selección inválida");
                    }
                }
                case 3 -> {
                    System.out.println("Ingresa el ID del usuario [0-" + (tarjetas.size() - 1) + "]");
                    try{
                        estacionamiento.generarFactura(tarjetas.get(sc.nextInt()), sc);
                    } catch (Exception e){
                        System.out.println("Selección inválida");
                    }
                }
                case 4 -> {
                    System.out.println("Ingresa el nuevo precio por hora (se toma por segundo para la simulación)");
                    try{
                        estacionamiento.setPrecioPorHora(sc.nextFloat());
                    } catch (Exception e){
                        System.out.println("Monto inválido");
                    }
                }
                case 5 -> {
                    for (Tarjeta tarjeta : estacionamiento.getTarjetasRegistradas()) {
                        System.out.println(tarjeta);
                    }
                }
                case 6 -> {
                    for (Tarjeta tarjeta : estacionamiento.getCochesEstacionados()) {
                        System.out.println(tarjeta);
                    }
                }
                case 7 -> ejecutar = false;
                default -> System.out.println("Opción inválida");
            }
        }

        sc.close();
    }
}
