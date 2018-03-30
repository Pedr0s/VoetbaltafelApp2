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
            ComboBox[] comboboxs = new ComboBox[] { cbbAttackerblack, cbbAttackerwhite, cbbDefenderblack, cbbDefenderwhite };
            bool Doublename = false;
            foreach (ComboBox c in comboboxs)
            {
                int count = 0;
                foreach (ComboBox co in comboboxs)
                {

                    if (c.Text == co.Text)
                    {
                        count++;
                        if (count == 2)
                        {
                            Doublename = true;
                        }

                    }

                }
            }
            if (scoreBlack.Value == scoreWhite.Value)
            {
                MessageBox.Show("There has to be a winner.");
            }
            else if (Doublename)
            {
                MessageBox.Show("A player can not play at multiple possitions");
            }
            else
            {
                btnSubmitscore.Text = "Submit";
                count = 4;
                timerUndo.Enabled = !timerUndo.Enabled;
                //visual
                scoreBlack.Enabled = !scoreBlack.Enabled;
                scoreWhite.Enabled = !scoreWhite.Enabled;
                cbbAttackerblack.Enabled = !cbbAttackerblack.Enabled;
                cbbAttackerwhite.Enabled = !cbbAttackerwhite.Enabled;
                cbbDefenderblack.Enabled = !cbbDefenderblack.Enabled;
                cbbDefenderwhite.Enabled = !cbbDefenderwhite.Enabled;
            }

        }
        private void timerUndo_Tick(object sender, EventArgs e)
        {
            count--;
            btnSubmitscore.Text = $"Undo({count})";
            if (count == 0)
            {
                timerUndo.Enabled = false;

                Functions Businesslayer = new Functions();

                Businesslayer.Addmatch(DateTime.Now, (int)scoreBlack.Value, (int)scoreWhite.Value, cbbAttackerblack.Text, cbbDefenderblack.Text, cbbAttackerwhite.Text, cbbDefenderwhite.Text);
                Businesslayer.Updateplayer((int)scoreBlack.Value, (int)scoreWhite.Value, cbbAttackerblack.Text, cbbDefenderblack.Text, cbbAttackerwhite.Text, cbbDefenderwhite.Text);



                //visual
                btnSubmitscore.Text = "Submit";
                scoreBlack.Enabled = !scoreBlack.Enabled;
                scoreWhite.Enabled = !scoreWhite.Enabled;
                cbbAttackerblack.Enabled = !cbbAttackerblack.Enabled;
                cbbAttackerwhite.Enabled = !cbbAttackerwhite.Enabled;
                cbbDefenderblack.Enabled = !cbbDefenderblack.Enabled;
                cbbDefenderwhite.Enabled = !cbbDefenderwhite.Enabled;
                MessageBox.Show("Match has been added to the database.");
            }
        }
        void Updatecomboboxes()
        {
            Functions Businesslayer = new Functions();
            var playerlist = Businesslayer.PlayersTolist();
            playerlist.Sort();

            ComboBox[] comboboxs = new ComboBox[] { cbbAddRemove, cbbAttackerblack, cbbAttackerwhite, cbbDefenderblack, cbbDefenderwhite };
            foreach (ComboBox c in comboboxs)
            {
                c.DataSource = playerlist;
                c.BindingContext = new BindingContext();
                //c.DisplayMember = "Name";
                c.SelectedIndex = -1;
            }
        }

        private void btnRemoveplayer_Click(object sender, EventArgs e)
        {
            Functions Businesslayer = new Functions();
            Businesslayer.Removeplayer(cbbAddRemove.Text);
            Updatecomboboxes();
        }

        private void cbbAddRemove_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnAddplayer_Click(this, new EventArgs());
            }
        }

        private void btnRanking_Click(object sender, EventArgs e)
        {

            Functions Businesslayer = new Functions();
            Businesslayer.OrderRanks();
        }
    }
}
/*
 
 * 
 *  
 * ?
 */
