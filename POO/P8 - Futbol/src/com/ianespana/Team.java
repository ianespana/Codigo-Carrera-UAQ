package com.ianespana;

import java.util.ArrayList;

public class Team {
    private int id;
    private int wins = 0;
    private int losses = 0;
    private int ties = 0;
    private int pointsScored = 0;
    private int pointsAllowed = 0;

    private ArrayList<Match> matchesPlayed = new ArrayList<>();

    public Team(int id){
        this.id = id;
    }

    public void setId(int id){
        this.id = id;
    }

    public int getId(){
        return id;
    }

    public int getWins(){
        return wins;
    }

    public int getLosses(){
        return losses;
    }

    public int getTies(){
        return ties;
    }

    public int getPointsScored(){
        return pointsScored;
    }

    public int getPointsAllowed(){
        return pointsAllowed;
    }

    public void addMatch(Match match){
        Team winner = match.getWinner();
        matchesPlayed.add(match);

        if (match.getAwayTeam() == this){
            pointsScored += match.getAwayTeamScore();
            pointsAllowed += match.getHomeTeamScore();
        } else {
            pointsScored += match.getHomeTeamScore();
            pointsAllowed += match.getAwayTeamScore();
        }

        if (winner == null){
            ties++;
        } else if (winner == this){
            wins++;
        } else {
            losses++;
        }
    }

    public ArrayList<Match> getMatchesPlayed(){
        return matchesPlayed;
    }

    @Override
    public String toString(){
        String teamString = "Team " + id + "\n";
        teamString += "Wins: " + wins + ", Losses: " + losses + ", Ties: " + ties + "\n";
        teamString += "Points Scored: " + pointsScored + ", Points Allowed: " + pointsAllowed + "\n";
        return teamString;
    }
}
