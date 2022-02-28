package com.ianespana;
import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;
import java.time.LocalDateTime;
import java.time.temporal.ChronoUnit;

import static java.lang.Integer.parseInt;

public class Main {
    public static void main(String[] args) throws IOException {
        BufferedReader reader = new BufferedReader(new InputStreamReader(System.in));
        System.out.println("Dame tu año de nacimiento:");
        Integer year = parseInt(reader.readLine());

        System.out.println("Dame tu mes de nacimiento (numerico):");
        Integer month = parseInt(reader.readLine());

        System.out.println("Dame tu dia de nacimiento (numerico):");
        Integer day = parseInt(reader.readLine());

        LocalDateTime birthday = LocalDateTime.of(year, month, day, 0, 0);
        LocalDateTime now = LocalDateTime.now();

        Long secondsAlive = ChronoUnit.SECONDS.between(birthday, now);

        System.out.print("Has vivido ");
        ConvertSecToDay(secondsAlive);
    }

    static void ConvertSecToDay(long n)
    {
        long months = n / 2629746;
        n %= 2629746;

        long weeks = n / 604800;
        n %= 604800;

        long days = n / 86400;
        n %= 86400;

        long hours = n / 3600;

        System.out.println( months + " meses "
                + weeks + " semanas "
                + days + " dias "
                + hours + " horas");
    }
}