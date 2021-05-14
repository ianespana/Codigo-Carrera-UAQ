package com.ianespana;
import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;

import static java.lang.Float.parseFloat;

public class Main {
    public static void main(String[] args) throws IOException {
        BufferedReader reader = new BufferedReader(new InputStreamReader(System.in));
        System.out.println("Dame el primer numero:");
        Float numA = parseFloat(reader.readLine());

        System.out.println("Dame el segundo numero:");
        Float numB = parseFloat(reader.readLine());

        System.out.println("La suma es: " + (numA+numB));
    }
}