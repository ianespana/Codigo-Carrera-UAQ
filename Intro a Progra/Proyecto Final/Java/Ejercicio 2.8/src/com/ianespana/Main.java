package com.ianespana;
import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;

import static java.lang.Float.parseFloat;

public class Main {
    public static void main(String[] args) throws IOException {
        BufferedReader reader = new BufferedReader(new InputStreamReader(System.in));
        System.out.println("Dame la velocidad en km/h:");
        Float speed = parseFloat(reader.readLine());

        System.out.println("Dame la cantidad de kilometros:");
        Float kilometers = parseFloat(reader.readLine());

        System.out.println("El tiempo para llegar es de: " + speed/kilometers + " horas");
    }
}