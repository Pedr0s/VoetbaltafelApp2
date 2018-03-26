using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    class Match
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public int GoalsBlack { get; set; }
        public int GoalsWhite { get; set; }
        public String AttackerBlack { get; set; }
        public String DefenderBlack { get; set; }
        public String AttackerWhite { get; set; }
        public String DefenderWhite { get; set; }
    }
}



