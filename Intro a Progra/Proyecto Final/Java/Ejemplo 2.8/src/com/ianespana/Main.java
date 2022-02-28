package com.ianespana;
import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;

import static java.lang.Float.parseFloat;

public class Main {
    public static void main(String[] args) throws IOException {
        BufferedReader reader = new BufferedReader(new InputStreamReader(System.in));
        System.out.println("Dame la coordenada X del primer punto:");
        Float x1 = parseFloat(reader.readLine());

        System.out.println("Dame la coordenada Y del primer punto:");
        Float y1 = parseFloat(reader.readLine());

        System.out.println("Dame la coordenada X del segundo punto:");
        Float x2 = parseFloat(reader.readLine());

        System.out.println("Dame la coordenada Y del segundo punto:");
        Float y2 = parseFloat(reader.readLine());

        System.out.println("La distancia entre puntos es: " + (Math.sqrt(Math.pow(x2-x1, 2) + Math.pow(y2-y1, 2))));
    }
}