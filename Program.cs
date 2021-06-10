using System;
using System.Collections.Generic;
using CivSportsResultExample_20210610.models;

namespace CivSportsResultExample_20210610
{
    class Program
    {
        static void Main(string[] args)
        {
            Player p1 = new Player("Michael", "Jordan");
            Player p2 = new Player("Larry", "Bird");
            Player p3 = new Player("Kobe", "Bryant");
            Player p4 = new Player("LeBron", "James");
            Player p5 = new Player("Steph", "Curry");
            Player p6 = new Player("James", "Harden");

            List<Player> oldDudesList = new List<Player>();
            List<Player> youngDudesList = new List<Player>();
            
            oldDudesList.Add(p1);
            oldDudesList.Add(p2);
            oldDudesList.Add(p3);
            
            youngDudesList.Add(p4);
            youngDudesList.Add(p5);
            youngDudesList.Add(p6);

            Team oldDudes = new Team("Old Dudes", oldDudesList);
            Team youngDudes = new Team("Young Dudes", youngDudesList);

            BasketballResult game1 = 
            new BasketballResult("New York", new DateTime(2015, 1,1), 100, 80, oldDudes, youngDudes);

            BasketballResult game2 = 
            new BasketballResult("Las Vegas", new DateTime(2015, 1,2), 90, 101, oldDudes, youngDudes);

            System.Console.WriteLine($"Winner game1 : {game1.GetWinnerName()}");
            System.Console.WriteLine($"{game1.TeamA.Name} scored {game1.PointsTeamA} | {game1.TeamB.Name} scored {game1.PointsTeamB}" );

            TennisResult tennisGame1 =
            new TennisResult("Somewhere", new DateTime(1111, 1, 1), 3, 4, 5, 4, 6, 5, p1, p2);
            Console.WriteLine(tennisGame1.GetWinner());

            GrandSlamMensResult grandSlam1 = 
            new GrandSlamMensResult("Elsewhere", new DateTime(1111, 1, 1), 3, 4, 5, 6, 7, 6, p1, p2, 1, 1, 2, 3);
            Console.WriteLine(grandSlam1.GetWinner());

            MmaResult mmaGame =
            new MmaResult("Over there", new DateTime(1111, 1, 1), 1, 2, 3, 4, 6, 5, p1, p2, "Death :(");
            Console.WriteLine(mmaGame.GetWinner());
        }
    }
}
