using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class Player
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Ranking { get; set; }
        public int Gamesplayed { get; set; }
        public int Gameswon { get; set; }
        public int Gameslost { get; set; }
        public DateTime Createdate { get; set; }

    }
}
