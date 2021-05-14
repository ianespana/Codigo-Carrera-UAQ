package com.ianespana;
import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;

import static java.lang.Float.parseFloat;

public class Main {
    public static void main(String[] args) throws IOException {
        BufferedReader reader = new BufferedReader(new InputStreamReader(System.in));
        System.out.println("Dame el precio por metro cuadrado:");
        Float price = parseFloat(reader.readLine());

        System.out.println("Dame el numero de metros cuadrados:");
        Float area = parseFloat(reader.readLine());
        area = (float) Math.ceil(area);

        System.out.println("El costo final es: " + (price*area));
    }
}