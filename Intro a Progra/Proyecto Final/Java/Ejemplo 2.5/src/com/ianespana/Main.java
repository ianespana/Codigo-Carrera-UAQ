package com.ianespana;
import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;

import static java.lang.Float.parseFloat;

public class Main {
    public static void main(String[] args) throws IOException {
        BufferedReader reader = new BufferedReader(new InputStreamReader(System.in));
        System.out.println("Dame el ancho del terreno:");
        Float width = parseFloat(reader.readLine());

        System.out.println("Dame la altura del terreno (parte larga):");
        Float height = parseFloat(reader.readLine());

        System.out.println("Dame el altura del terreno (parte corta):");
        Float height2 = parseFloat(reader.readLine());

        System.out.println("El area es: " + ((width*(height-height2))/2 + (width*height)));
    }
}