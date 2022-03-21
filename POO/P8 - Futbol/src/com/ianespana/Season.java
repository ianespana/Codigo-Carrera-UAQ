package com.ianespana;

import java.util.ArrayList;

public class Season {
    private final ArrayList<Day> days;
    private final ArrayList<Team> teams;
    private final ArrayList<Match> matches = new ArrayList<>();

    private int generateRandom(int min, int max) {
        int range = (max - min) + 1;
        return (int)(Math.random() * range) + min;
    }

    private Match simulateMatch(int matchId, Day day){
        Team awayTeam = teams.get(generateRandom(0, teams.size() - 1));
        Team homeTeam;

        do {
            homeTeam = teams.get(generateRandom(0, teams.size() - 1));
        } while (homeTeam == awayTeam);

        return new Match(matchId, day, awayTeam, homeTeam);
    }

    public Season(ArrayList<Day> days, ArrayList<Team> teams){
        int matchId = 1;
        this.days = days;
        this.teams = teams;

        for (Day day : days) {
            if (day.getTemperature() > 0) {
                matches.add(simulateMatch(matchId, day));
                matches.add(simulateMatch(matchId + 1, day));

                matchId += 2;
            }
        }
    }

    public ArrayList<Day> getDays(){
        return days;
    }

    public ArrayList<Match> getMatches(){
        return matches;
    }

    public float getHottestTemp(){
        float hottestTemp = - Float.MAX_VALUE;
        for (Day day : days) {
            float temperature = day.getTemperature();
            if (temperature > hottestTemp){
                hottestTemp = temperature;
            }
        }

        return hottestTemp;
    }

    public float getAverageTemp(){
        float averageTemp = 0;
        for (Day day : days) {
            averageTemp += day.getTemperature();
        }

        averageTemp /= days.size();

        return averageTemp;
    }

    @Override
    public String toString(){
        String seasonString = "";

        for (Team team : teams) {
            seasonString += team + "\n";
        }

        for (Match match : matches) {
            seasonString += match + "\n";
        }

        seasonString += "Hottest Temp: " + getHottestTemp() + "\n";
        seasonString += "Average Temp: " + getAverageTemp() + "\n";

        return seasonString;
    }
}
