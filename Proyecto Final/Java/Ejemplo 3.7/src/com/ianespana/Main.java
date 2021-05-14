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
        System.out.println("¿Cuantos kilos de uva estas vendiendo?");
        Float kilos = parseFloat(reader.readLine());

        System.out.println("¿Qué tipo de uva son?\n\t1. Tipo A\n\t2. Tipo B");
        byte type = parseByte(reader.readLine());

        System.out.println("¿De qué tamaño son?\n\t1. Tamaño 1\n\t2. Tamaño 2");
        byte size = parseByte(reader.readLine());

        System.out.println("¿A qué precio las quieres vender?");
        Float price = parseFloat(reader.readLine());

        switch (type)
        {
            case 1:
                if (size == 1)
                {
                    price += 0.20f;
                }
                else
                {
                    price += 0.30f;
                }
                break;
            case 2:
                if (size == 1)
                {
                    price -= 0.30f;
                }
                else
                {
                    price -= 0.50f;
                }
                break;
            default:
                System.out.println("Tipo inválido");
                return;
        }

        System.out.println("El costo total es: " + kilos*price);
    }
}