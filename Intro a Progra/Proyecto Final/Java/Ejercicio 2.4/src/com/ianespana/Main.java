package com.ianespana;
import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;

import static java.lang.Float.parseFloat;


public class Main {
    public static void main(String[] args) throws IOException {
        BufferedReader reader = new BufferedReader(new InputStreamReader(System.in));
        System.out.println("Dame el precio por hora:");
        Float price = parseFloat(reader.readLine());

        System.out.println("Dame el numero de horas:");
        Float hours = parseFloat(reader.readLine());
        hours = (float) Math.ceil(hours);

        System.out.println("El costo final es: " + (price*hours));
    }
}