package com.ianespana;

import java.util.ArrayList;
import java.util.Scanner;

public class Main {
    private static ArrayList<Team> teams = new ArrayList<>();
    public static void main(String[] args) {
        for (int i = 1; i <= 4; i++) {
            teams.add(new Team(i));
        }

        ArrayList<Day> days = new ArrayList<>();
        int lowTempCount = 0;
        int dayId = 1;

        Scanner sc = new Scanner(System.in);
        while (lowTempCount < 3){
            System.out.println("Dame la temperatura del día " + dayId);
            float temp = sc.nextFloat();
            Day day = new Day(dayId, temp);
            days.add(day);

            if (temp <= 0) {
                lowTempCount++;
                System.out.println("Muy frio para jugar");
            } else {
                lowTempCount = 0;
            }

            dayId++;
        }
        System.out.println("*** RESULTADOS ***\n");
        Season season = new Season(days, teams);
        System.out.print(season);
        sc.close();
    }
}
