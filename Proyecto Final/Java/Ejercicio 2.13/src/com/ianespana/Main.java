package com.ianespana;
import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;

import static java.lang.Float.parseFloat;

public class Main {
    public static void main(String[] args) throws IOException {
        BufferedReader reader = new BufferedReader(new InputStreamReader(System.in));
        System.out.println("Dame el sueldo semanal:");
        Float salary = parseFloat(reader.readLine());

        System.out.println("El ahorro por año es: " + (salary*0.15*48));
    }
}