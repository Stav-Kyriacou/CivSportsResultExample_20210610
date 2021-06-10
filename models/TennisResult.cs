using System;
using System.Collections.Generic;

namespace CivSportsResultExample_20210610.models
{
    public class TennisResult : SportResult
    {
        public int GamesSet1PlayerA;
        public int GamesSet1PlayerB;
        public int GamesSet2PlayerA;
        public int GamesSet2PlayerB;
        public int GamesSet3PlayerA;
        public int GamesSet3PlayerB;

        Player PlayerA;
        Player PlayerB;

        public TennisResult(string location, DateTime tIme, int gamesSet1PlayerA, int gamesSet1PlayerB, int gamesSet2PlayerA, int gamesSet2PlayerB, int gamesSet3PlayerA,
                            int gamesSet3PlayerB, Player playerA, Player playerB) : base(location, tIme)
        {
            this.GamesSet1PlayerA = gamesSet1PlayerA;
            this.GamesSet1PlayerB = gamesSet1PlayerB;
            this.GamesSet2PlayerA = gamesSet2PlayerA;
            this.GamesSet2PlayerB = gamesSet2PlayerB;
            this.GamesSet3PlayerA = gamesSet3PlayerA;
            this.GamesSet3PlayerB = gamesSet3PlayerB;
            this.PlayerA = playerA;
            this.PlayerB = playerB;
        }

        public string GetWinner()
        {
            int scorePlayerA = 0;
            int scorePlayerB = 0;

            List<int> playerAScores = new List<int>();
            List<int> playerBScores = new List<int>();

            playerAScores.Add(GamesSet1PlayerA);
            playerAScores.Add(GamesSet2PlayerA);
            playerAScores.Add(GamesSet3PlayerA);
            playerBScores.Add(GamesSet1PlayerB);
            playerBScores.Add(GamesSet2PlayerB);
            playerBScores.Add(GamesSet3PlayerB);

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