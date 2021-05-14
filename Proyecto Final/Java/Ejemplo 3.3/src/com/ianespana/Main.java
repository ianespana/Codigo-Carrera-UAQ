package com.ianespana;
import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;

import static java.lang.Integer.parseInt;

public class Main {
    public static void main(String[] args) throws IOException {
        BufferedReader reader = new BufferedReader(new InputStreamReader(System.in));
        System.out.println("Dame el numero de lapices:");
        Integer pencils = parseInt(reader.readLine());

        Integer price = pencils >= 1000 ? 85 : 90;

        System.out.println("El costo final es " + pencils*price);
    }
}