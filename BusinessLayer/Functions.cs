using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;


namespace BusinessLayer
{
    public class Functions
    {

        public void Removeplayer(string Name)
        {
            VoetbaltabelContext context = new VoetbaltabelContext();
            bool Removed = false;
            foreach (Player player in context.Players)
            {
                if (player.Name.Equals(Name))
                {
                    context.Players.Remove(player);
                    Removed = true;
                    break;

                }
            }
            if (Removed)
            {
                context.SaveChanges();
            }
            else
            {
                MessageBox.Show("There is no such name available to delete");
            }


        }
        public void Addplayer(string Name)
        {
            using (VoetbaltabelContext context = new VoetbaltabelContext())
            {
                if (context.Players.FirstOrDefault(x => x.Name == Name) == null)
                {
                    context.Players.Add(new Player { Createdate = DateTime.Now, Name = Name, Ranking = 0 });
                    context.SaveChanges();
                }
                else
                {
                    MessageBox.Show("This name already exists");
                }
            }
        }



        public List<string> PlayersTolist()
        {
         VoetbaltabelContext context = new VoetbaltabelContext();
         return context.Players.Select(x => x.Name).ToList();
        }


        public void Addmatch(DateTime Date, int GoalsBlack, int GoalsWhite, string AttackerBlack, string DefenderBlack, string AttackerWhite, string DefenderWhite)
        {
            string[] Players = new string[] { AttackerBlack, DefenderBlack, AttackerWhite, DefenderWhite };

            bool isUnique = Players.Distinct().Count() == Players.Count();

            if (GoalsBlack == GoalsWhite)
            {
                MessageBox.Show("There has to be a winner.");
            }
            else if (isUnique == false)
            {
                MessageBox.Show("A player can not play at multiple possitions");
            }
            else
            {
                using (VoetbaltabelContext context = new VoetbaltabelContext())
                {
                    context.Matches.Add(new Match
                    {
                        Date = Date,
                        GoalsBlack = GoalsBlack,
                        GoalsWhite = GoalsWhite,
                        AttackerBlack = AttackerBlack,
                        DefenderBlack = DefenderBlack,
                        AttackerWhite = AttackerWhite,
                        DefenderWhite = DefenderWhite
                    });

                    Updateplayer(GoalsBlack,GoalsWhite,AttackerBlack,DefenderBlack,AttackerWhite,DefenderWhite);

                    context.SaveChanges();
                }
            }
        }

        public void Updateplayer(int GoalsBlack, int GoalsWhite, string AttackerBlack, string DefenderBlack, string AttackerWhite, string DefenderWhite)
        {
            using (VoetbaltabelContext context = new VoetbaltabelContext())
            {
                foreach (Player p in context.Players)
                {
                    if (p.Name == AttackerBlack || p.Name == DefenderBlack)
                    {
                        if (GoalsBlack > GoalsWhite)
                        {
                            p.Gameswon++;
                            p.Ranking = p.Ranking + (GoalsBlack - GoalsWhite);
                        }
                        else
                        {
                            p.Gameslost++;
                            p.Ranking = p.Ranking + (GoalsBlack - GoalsWhite);
                        }
                    }

                    else if (p.Name == AttackerWhite || p.Name == DefenderWhite)
                    {
                        if (GoalsWhite > GoalsBlack)
                        {
                            p.Gameswon++;
                            p.Ranking = p.Ranking + (GoalsWhite - GoalsBlack);
                        }

                        else
                        {
                            p.Gameslost++;
                            p.Ranking = p.Ranking + (GoalsWhite - GoalsBlack);
                        }
                    }


                    p.Gamesplayed = p.Gameslost + p.Gameswon;

                    // makes sure ranking does not exceed over 100 or below 0
                    if (p.Ranking >= 100) { p.Ranking = 100; }
                    else if (p.Ranking <= 0) { p.Ranking = 0; }

                }
                context.SaveChanges();
            }
        }
        public void OrderRanks()
        {
            using (VoetbaltabelContext context = new VoetbaltabelContext())
            {
                var ranking = from player in context.Players orderby player.Ranking descending select player;
                var ArrayRanking = ranking.ToList();
            
            foreach (Player p in ranking)
                {
                    MessageBox.Show(p.Name);
                }
            }   
        }

    }
}
