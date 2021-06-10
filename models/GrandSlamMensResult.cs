using System;
using System.Collections.Generic;

namespace CivSportsResultExample_20210610.models
{
    public class GrandSlamMensResult : TennisResult
    {
        public int GamesSet4PlayerA { get; set; }
        public int GamesSet4PlayerB { get; set; }
        public int GamesSet5PlayerA { get; set; }
        public int GamesSet5PlayerB { get; set; }

        public GrandSlamMensResult(string location, DateTime tIme, int gamesSet1PlayerA, int gamesSet1PlayerB, int gamesSet2PlayerA, int gamesSet2PlayerB, int gamesSet3PlayerA,
                                    int gamesSet3PlayerB, Player playerA, Player playerB, int gamesSet4PlayerA, int gamesSet4PlayerB, int gamesSet5PlayerA, int gamesSet5PlayerB)
                                    : base(location, tIme, gamesSet1PlayerA, gamesSet1PlayerB, gamesSet2PlayerA, gamesSet2PlayerB, gamesSet3PlayerA, gamesSet3PlayerB, playerA, playerB)
        {
            this.GamesSet4PlayerA = gamesSet4PlayerA;
            this.GamesSet4PlayerB = gamesSet4PlayerB;
            this.GamesSet5PlayerA = gamesSet5PlayerA;
            this.GamesSet5PlayerB = gamesSet5PlayerB;
        }

        public override string GetWinner()
        {
            int scorePlayerA = 0;
            int scorePlayerB = 0;

            List<int> playerAScores = new List<int>();
            List<int> playerBScores = new List<int>();

            playerAScores.Add(GamesSet1PlayerA);
            playerAScores.Add(GamesSet2PlayerA);
            playerAScores.Add(GamesSet3PlayerA);
            playerAScores.Add(GamesSet4PlayerA);
            playerAScores.Add(GamesSet5PlayerA);
            playerBScores.Add(GamesSet1PlayerB);
            playerBScores.Add(GamesSet2PlayerB);
            playerBScores.Add(GamesSet3PlayerB);
            playerBScores.Add(GamesSet4PlayerB);
            playerBScores.Add(GamesSet5PlayerB);

            for (int i = 0; i < playerAScores.Count; i++)
            {
                if (playerAScores[i] > playerBScores[i])
                {
                    scorePlayerA++;
                }
                else
                {
                    scorePlayerB++;
                }
            }

            if (scorePlayerA > scorePlayerB)
            {
                return $"{PlayerA.FName} {PlayerA.SName}";
            }
            else
            {
                return $"{PlayerB.FName} {PlayerB.SName}";

            }
        }
    }
}