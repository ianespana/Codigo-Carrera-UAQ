package com.ianespana;
import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;

import static java.lang.Float.parseFloat;

public class Main {
    public static void main(String[] args) throws IOException {
        BufferedReader reader = new BufferedReader(new InputStreamReader(System.in));
        System.out.println("Dame el valor de uno de los catetos:");
        Float sideA = parseFloat(reader.readLine());

        System.out.println("Dame el valor del otro cateto:");
        Float sideB = parseFloat(reader.readLine());

        System.out.println("La hipotenusa es: " + Math.sqrt(Math.pow(sideA, 2)+Math.pow(sideB, 2)));
    }
}