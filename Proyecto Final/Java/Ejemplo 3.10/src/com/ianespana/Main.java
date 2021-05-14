package com.ianespana;
import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;

import static java.lang.Byte.parseByte;
import static java.lang.Float.parseFloat;
import static java.lang.Integer.parseInt;

public class Main {
    public static void main(String[] args) throws IOException {
        BufferedReader reader = new BufferedReader(new InputStreamReader(System.in));

        Float price = 0f;
        System.out.println("Dame el numero de personas:");
        Float people = parseFloat(reader.readLine());

        people = people < 20 ? 20 : people;

        System.out.println("Indica el tipo de autobs:\n\t1. Tipo A\n\t2. Tipo B\n\t3. Tipo C");
        byte bus = parseByte(reader.readLine());

        switch (bus){
            case 1:
                price = 2f;
                break;
            case 2:
                price = 2.5f;
                break;
            case 3:
                price = 3f;
                break;
            default:
                System.out.println("Autobus invalido");
                return;
        }

        System.out.println("El costo total es: " + people*price);
    }
}