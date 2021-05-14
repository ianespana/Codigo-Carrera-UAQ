package com.ianespana;
import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;
import java.util.Calendar;

import static java.lang.Integer.parseInt;

public class Main {
    public static void main(String[] args) throws IOException {
        BufferedReader reader = new BufferedReader(new InputStreamReader(System.in));
        System.out.println("Dame el año de nacimiento:");
        Integer year = parseInt(reader.readLine());

        Integer curYear = Calendar.getInstance().get(Calendar.YEAR);
        System.out.println("La edad es: " + (curYear-year));
    }
}