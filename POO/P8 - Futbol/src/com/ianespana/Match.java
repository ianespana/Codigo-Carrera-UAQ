package com.ianespana;

public class Match {
    private int id;
    private Team awayTeam;
    private Team homeTeam;
    private int awayTeamScore = 0;
    private int homeTeamScore = 0;
    private Day day;
    private Team winner;

    private int generateMatchScore(int min, int max) {
        int range = (max - min) + 1;
        return (int)(Math.random() * range) + min;
    }

    public Match(int id, Day day, Team awayTeam, Team homeTeam){
        this.id = id;
        this.day = day;
        this.awayTeam = awayTeam;
        this.homeTeam = homeTeam;

        float temperature = day.getTemperature();

        awayTeamScore = generateMatchScore(0, (int) Math.ceil(temperature / 10) * 4);
        homeTeamScore = generateMatchScore(0, (int) Math.ceil(temperature / 10) * 4);

        if (awayTeamScore > homeTeamScore){
            winner = awayTeam;
        } else if (homeTeamScore > awayTeamScore){
            winner = homeTeam;
        } else {
            winner = null;
        }

        awayTeam.addMatch(this);
        homeTeam.addMatch(this);
    }

    public void setId(int id){
        this.id = id;
    }

    public int getId(){
        return id;
    }

    public int getAwayTeamScore(){
        return awayTeamScore;
    }

    public int getHomeTeamScore(){
        return homeTeamScore;
    }

    public Team getAwayTeam(){
        return awayTeam;
    }

    public Team getHomeTeam(){
        return homeTeam;
    }

    public Day getDay(){
        return day;
    }

    public Team getWinner(){
        return winner;
    }

    @Override
    public String toString(){
        String matchString = "Game #" + id + "\n";
        matchString += "Temperature: " + day.getTemperature() + "\n";
        matchString += "Away Team: Team " + awayTeam.getId() + ", " + awayTeamScore + "\n";
        matchString += "Home Team: Team " + homeTeam.getId() + ", " + homeTeamScore + "\n";
        return matchString;
    }
}
