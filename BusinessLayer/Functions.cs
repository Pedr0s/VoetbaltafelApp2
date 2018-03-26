using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            VoetbaltabelContext context = new VoetbaltabelContext();
            if (context.Players.FirstOrDefault(x => x.Name == Name) == null)
            {
            context.Players.Add(new Player {Createdate = DateTime.Now, Name = Name, Ranking = 0 });
            context.SaveChanges();
            }
            else
            {
                MessageBox.Show("This name already exists");
            }

            //var test = context.Players.Find("Hallo");

            //bool Nametaken;


        }
        

        public List<Player> PlayersTolist()
        {
            VoetbaltabelContext context = new VoetbaltabelContext();
            return context.Players.ToList();
        }

        public void Addmatch(DateTime Date, int GoalsBlack, int GoalsWhite, string AttackerBlack, string DefenderBlack, string AttackerWhite, string DefenderWhite)
        {
            VoetbaltabelContext context = new VoetbaltabelContext();
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
            context.SaveChanges();
        }

    }
}
