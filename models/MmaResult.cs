using System;
using System.Collections.Generic;

namespace CivSportsResultExample_20210610.models
{
    public class MmaResult : SportResult
    {
        public int Rnd1PointsPlayerA { get; set; }
        public int Rnd2PointsPlayerA { get; set; }
        public int Rnd3PointsPlayerA { get; set; }
        public int Rnd1PointsPlayerB { get; set; }
        public int Rnd2PointsPlayerB { get; set; }
        public int Rnd3PointsPlayerB { get; set; }
        public Player PlayerA;
        public Player PlayerB;
        public string VictoryType { get; set; }

        public MmaResult(string location, DateTime date, int rnd1PointsPlayerA, int rnd2PointsPlayerA, int rnd3PointsPlayerA, int rnd1PointsPlayerB, int rnd2PointsPlayerB, int rnd3PointsPlayerB, 
                            Player playerA, Player playerB, string victoryType) : base(location, date)
        {
            this.Rnd1PointsPlayerA = rnd1PointsPlayerA;
            this.Rnd2PointsPlayerA = rnd2PointsPlayerA;
            this.Rnd3PointsPlayerA = rnd3PointsPlayerA;
            this.Rnd1PointsPlayerB = rnd1PointsPlayerB;
            this.Rnd2PointsPlayerB = rnd2PointsPlayerB;
            this.Rnd3PointsPlayerB = rnd3PointsPlayerB;
            this.PlayerA = playerA;
            this.PlayerB = playerB;
            this.VictoryType = victoryType;
        }

        public string GetWinner()
        {
            int scorePlayerA = 0;
            int scorePlayerB = 0;

            List<int> playerAScores = new List<int>();
            List<int> playerBScores = new List<int>();

            playerAScores.Add(Rnd1PointsPlayerA);
            playerAScores.Add(Rnd2PointsPlayerA);
            playerAScores.Add(Rnd3PointsPlayerA);
            playerBScores.Add(Rnd1PointsPlayerB);
            playerBScores.Add(Rnd2PointsPlayerB);
            playerBScores.Add(Rnd3PointsPlayerB);

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