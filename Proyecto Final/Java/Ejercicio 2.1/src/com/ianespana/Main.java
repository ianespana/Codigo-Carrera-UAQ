package com.ianespana;
import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;

import static java.lang.Integer.parseInt;

public class Main {
    public static void main(String[] args) throws IOException {
        BufferedReader reader = new BufferedReader(new InputStreamReader(System.in));
        System.out.println("Dame el valor de la base:");
        Integer width = parseInt(reader.readLine());

        System.out.println("Dame el valor de la altura:");
        Integer height = parseInt(reader.readLine());

        System.out.println("El area es: " + (width*height)/2);
    }
}
