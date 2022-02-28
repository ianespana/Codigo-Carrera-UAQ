package com.ianespana;
import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;

import static java.lang.Float.parseFloat;

public class Main {
    public static void main(String[] args) throws IOException {
        BufferedReader reader = new BufferedReader(new InputStreamReader(System.in));
        System.out.println("Dame el ancho de la alberca:");
        Float width = parseFloat(reader.readLine());

        System.out.println("Dame la altura de la alberca:");
        Float height = parseFloat(reader.readLine());

        System.out.println("Dame la profundidad de la alberca:");
        Float depth = parseFloat(reader.readLine());

        System.out.println("Dame el precio del agua por metro cubico:");
        Float ppm2 = parseFloat(reader.readLine());

        System.out.println("El precio por llenar la alberca es: " + (width*height*depth*ppm2));
    }
}