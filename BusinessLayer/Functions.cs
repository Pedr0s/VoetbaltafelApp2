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
            var context = new VoetbaltabelContext();
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
            var context = new VoetbaltabelContext();
            int Numberofplayers = context.Players.Count();
            //var test = context.Players.Find("Hallo");

            //bool Nametaken;
            
            context.Players.Add(new Player {Name = Name, Ranking = 0 });
            //Createdate = DateTime.Now
            context.SaveChanges();
        }
        

        public List<Player> PlayersTolist()
        {
            var context = new VoetbaltabelContext();
            return context.Players.ToList();
        }

        public void Addmatch(int GoalsBlack, int GoalsWhite, string AttackerBlack, string DefenderBlack, string AttackerWhite, string DefenderWhite)
        {
            VoetbaltabelContext context = new VoetbaltabelContext();
            context.Matches.Add(new Match
            {
                Id = context.Matches.Count() + 1,
                GoalsBlack = GoalsBlack,
                GoalsWhite = GoalsWhite,
                AttackerBlack = AttackerBlack,
                DefenderBlack = DefenderBlack,
                AttackerWhite = AttackerWhite,
                DefenderWhite = DefenderWhite
            });
        }

    }
}
