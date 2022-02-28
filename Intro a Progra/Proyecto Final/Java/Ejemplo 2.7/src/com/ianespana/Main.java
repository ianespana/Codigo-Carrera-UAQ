package com.ianespana;
import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;

import static java.lang.Float.parseFloat;

public class Main {
    public static void main(String[] args) throws IOException {
        BufferedReader reader = new BufferedReader(new InputStreamReader(System.in));
        System.out.println("Dame el precio por galon:");
        Float ppg = parseFloat(reader.readLine());

        System.out.println("Dame el nmero de litros:");
        Float liters = parseFloat(reader.readLine());

        System.out.println("El costo total es: " + ppg*(liters/3.785));
    }
}