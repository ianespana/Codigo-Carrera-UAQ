package com.ianespana;
import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;

import static java.lang.Integer.parseInt;

public class Main {
    public static void main(String[] args) throws IOException {
        BufferedReader reader = new BufferedReader(new InputStreamReader(System.in));
        System.out.println("Dame el numero de alumnos:");
        Integer people = parseInt(reader.readLine());

        Integer price;

        if (people >= 30 && people < 50){
            price = 95;
        } else if (people >= 50 && people < 100){
            price = 70;
        } else if(people >= 100){
            price = 65;
        } else {
            System.out.println("El costo total es: " + 4000);
            System.out.println("El costo por alumno es: " + 4000/people);
            return;
        }

        System.out.println("El costo total es: " + people*price);
        System.out.println("El costo por alumno es: " + price);
    }
}