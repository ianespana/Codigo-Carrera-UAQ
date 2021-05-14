package com.ianespana;
import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;

import static java.lang.Integer.parseInt;

public class Main {
    public static void main(String[] args) throws IOException {
        BufferedReader reader = new BufferedReader(new InputStreamReader(System.in));
        System.out.println("Dame el numero de personas:");
        Integer people = parseInt(reader.readLine());

        Integer price = 95;

        if (people > 200 && people <= 300){
            price = 85;
        } else if(people > 300){
            price = 75;
        }
        System.out.println("El costo total es: " + people*price);
    }
}