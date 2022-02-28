package com.ianespana;
import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;

import static java.lang.Float.parseFloat;

public class Main {
    public static void main(String[] args) throws IOException {
        BufferedReader reader = new BufferedReader(new InputStreamReader(System.in));
        System.out.println("Dame la cantidad de pesos mexicanos a convertir:");
        Float pesos = parseFloat(reader.readLine());

        System.out.println("La cantidad en dolares es: " + pesos*0.05);
    }
}