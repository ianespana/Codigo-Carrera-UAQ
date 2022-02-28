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
        System.out.println("Dame el numero de minutos:");
        Float minutes = parseFloat(reader.readLine());

        Float price = CalcPricePerMinute(minutes);

        System.out.println("Indica el día:\n\t1. Día habil\n\t2. Sabado\n\t3. Domingo");
        byte day = parseByte(reader.readLine());
        switch (day){
            case 1:
                System.out.println("Indica el turno:\n\t1. Matutino\n\t2. Vespertino");
                byte time = parseByte(reader.readLine());
                switch (time) {
                    case 1:
                        price *= 1.15f;
                        break;
                    case 2:
                        price *= 1.1f;
                        break;
                    default:
                        System.out.println("Turno invalido");
                        return;
                }
                break;
            case 2:
                break;
            case 3:
                price *= 1.03f;
                break;
            default:
                System.out.println("Dia invalido");
                return;
        }

        System.out.println("El costo total es: " + price);
    }

    static float CalcPricePerMinute(float n)
    {
        float total = 0;

        if (n - 5 <= 0){
            total += n;
            return total;
        }
        total += 5;
        n -= 5;

        if (n - 3 <= 0){
            total += n*0.8;
            return total;
        }
        total += 3*0.8;
        n -= 3;

        if (n - 2 <= 0){
            total += n*0.7;
            return total;
        }
        total += 2*0.7;
        n -= 2;

        total += n*0.5;

        return total;
    }
}