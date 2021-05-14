package com.ianespana;
import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;

import static java.lang.Float.parseFloat;

public class Main {
    public static void main(String[] args) throws IOException {
        BufferedReader reader = new BufferedReader(new InputStreamReader(System.in));
        System.out.println("Dame un numero:");
        Float numA = parseFloat(reader.readLine());

        String val = numA < 0 ? "negativo" : "positivo";

        System.out.println("El numero es " + val);
    }
}