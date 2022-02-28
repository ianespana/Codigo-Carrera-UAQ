package com.ianespana;
import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;

import static java.lang.Float.parseFloat;

public class Main {
    public static void main(String[] args) throws IOException {
        BufferedReader reader = new BufferedReader(new InputStreamReader(System.in));
        System.out.println("Dame la calificacion del primer examen:");
        Float examA = parseFloat(reader.readLine());

        System.out.println("Dame la calificacion del segundo examen:");
        Float examB = parseFloat(reader.readLine());

        System.out.println("Dame la calificacion del tercer examen:");
        Float examC = parseFloat(reader.readLine());

        System.out.println("la calificacion final es: " + (examA*0.25+examB*0.25+examC*0.5));
    }
}