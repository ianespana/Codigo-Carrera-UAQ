package com.ianespana;
import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;

import static java.lang.Float.parseFloat;

public class Main {
    public static void main(String[] args) throws IOException {
        BufferedReader reader = new BufferedReader(new InputStreamReader(System.in));
        System.out.println("Dame el precio del articulo:");
        Float price = parseFloat(reader.readLine());

        System.out.println("El costo con descuento es de: " + (price*0.8));
        System.out.println("El costo total es de: " + (price*0.92));
    }
}