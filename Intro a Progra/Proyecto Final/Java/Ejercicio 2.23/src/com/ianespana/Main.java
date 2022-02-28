package com.ianespana;
import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;

import static java.lang.Float.parseFloat;
import static java.lang.Integer.parseInt;

public class Main {
    public static void main(String[] args) throws IOException {
        BufferedReader reader = new BufferedReader(new InputStreamReader(System.in));
        System.out.println("Dame el precio por noche:");
        Float price = parseFloat(reader.readLine());

        System.out.println("Dame el numero de noches:");
        Integer nights = parseInt(reader.readLine());

        System.out.println("El costo final es: " + (price*nights));
    }
}