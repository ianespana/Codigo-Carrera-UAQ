package com.ianespana;
import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;

import static java.lang.Float.parseFloat;

public class Main {
    public static void main(String[] args) throws IOException {
        BufferedReader reader = new BufferedReader(new InputStreamReader(System.in));
        System.out.println("Dame el numero de dias:");
        Float days = parseFloat(reader.readLine());

        System.out.println("Dame el costo diario del hotel:");
        Float hppd = parseFloat(reader.readLine());

        System.out.println("Dame el costo diario de las comidas:");
        Float fppd = parseFloat(reader.readLine());

        System.out.println("El costo por el hotel es: " + (days*hppd));
        System.out.println("El costo por las comidas es: " + (days*fppd));
        System.out.println("El costo por otros gastos es: " + (days*100));
        System.out.println("El costo final es: " + ((days*hppd)+(days*fppd)+(days*100)));
    }
}