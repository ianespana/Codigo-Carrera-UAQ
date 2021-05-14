package com.ianespana;
import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;

import static java.lang.Float.parseFloat;

public class Main {
    public static void main(String[] args) throws IOException {
        BufferedReader reader = new BufferedReader(new InputStreamReader(System.in));
        System.out.println("Dame el precio del traje:");
        Float price = parseFloat(reader.readLine());

        Float disc = price > 2500 ? 0.85f : 0.92f;

        System.out.println("El costo final es " + price*disc);
    }
}