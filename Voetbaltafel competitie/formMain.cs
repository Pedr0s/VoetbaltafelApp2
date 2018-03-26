using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLayer;


namespace Voetbaltafel_competitie
{
    public partial class Mainform : Form
    {

        public Mainform()
        {
            InitializeComponent();
            Updatecomboboxes();
        }
        public void btnAddplayer_Click(object sender, EventArgs e)
        {
            Functions Businesslayer = new Functions();
            Businesslayer.Addplayer(cbbAddRemove.Text);
            Updatecomboboxes();
        }

        int count;
        private void btnSubmitscore_Click(object sender, EventArgs e)
        {

            btnSubmitscore.Text = "Submit";
            count = 10;
            timerUndo.Enabled = !timerUndo.Enabled;
            //visual
            scoreBlack.Enabled = !scoreBlack.Enabled;
            scoreWhite.Enabled = !scoreWhite.Enabled;
            cbbAttackerblack.Enabled = !cbbAttackerblack.Enabled;
            cbbAttackerwhite.Enabled = !cbbAttackerwhite.Enabled;
            cbbDefenderblack.Enabled = !cbbDefenderblack.Enabled;
            cbbDefenderwhite.Enabled = !cbbDefenderwhite.Enabled; 

        }
            private void timerUndo_Tick(object sender, EventArgs e)
        {
            count--;
            btnSubmitscore.Text = $"Undo({count})";
            if (count == 0)
            {
                timerUndo.Enabled = false;
                Functions Businesslayer = new Functions();
                Businesslayer.Addmatch((int)scoreBlack.Value, (int)scoreWhite.Value, cbbAttackerblack.Text, cbbDefenderblack.Text, cbbAttackerwhite.Text, cbbDefenderwhite.Text);

            }
        }
        void Updatecomboboxes()
        {
            Functions Businesslayer = new Functions();
            var playerlist = Businesslayer.PlayersTolist();

            ComboBox[] comboboxs = new ComboBox[] { cbbAddRemove, cbbAttackerblack, cbbAttackerwhite, cbbDefenderblack, cbbDefenderwhite};
            foreach (ComboBox c in comboboxs)
            {
                c.DataSource = playerlist;
                c.BindingContext = new BindingContext();
                c.DisplayMember = "Name";
                c.SelectedIndex = -1;
            }
        }

        private void btnRemoveplayer_Click(object sender, EventArgs e)
        {
            Functions Businesslayer = new Functions();
            Businesslayer.Removeplayer(cbbAddRemove.Text);
            Updatecomboboxes();
        }
    }
    public class Player
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Ranking { get; set; }
        //public int Gamesplayed { get; set; }
        //public int Gameswon { get; set; }
        //public int Gameslost { get; set; }

    }
    

}
/*
 * You can not submit more then 1 time each minute
 * Undo submit
 *  
 * ?
 */ 
