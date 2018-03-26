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
            private void timerUndo_Tick(object sender, EventArgs e)
        {
            count--;
            btnSubmitscore.Text = $"Undo({count})";
            if (count == 0)
            {
                timerUndo.Enabled = false;

                Functions Businesslayer = new Functions();
                Businesslayer.Addmatch(DateTime.Now,(int)scoreBlack.Value, (int)scoreWhite.Value, cbbAttackerblack.Text, cbbDefenderblack.Text, cbbAttackerwhite.Text, cbbDefenderwhite.Text);

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

        private void cbbAddRemove_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnAddplayer_Click(this, new EventArgs());
            }
        }
    }


}
/*
 * You can not submit more then 1 time each minute
 * Undo submit
 *  
 * ?
 */ 
