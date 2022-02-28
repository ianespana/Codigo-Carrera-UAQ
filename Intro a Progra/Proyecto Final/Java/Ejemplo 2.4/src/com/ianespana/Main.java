package com.ianespana;
import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;

import static java.lang.Float.parseFloat;

public class Main {
    public static void main(String[] args) throws IOException {
        BufferedReader reader = new BufferedReader(new InputStreamReader(System.in));
        System.out.println("Dame el radio del circulo:");
        Float radius = parseFloat(reader.readLine());

        System.out.println("El area es: " + (Math.PI * Math.pow(radius, 2)));
    }
}