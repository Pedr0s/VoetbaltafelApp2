namespace Voetbaltafel_competitie
{
    partial class formRanking
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mostGamesWonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mostGamesPlayedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mostGamesLostToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mostGamesWonToolStripMenuItem,
            this.mostGamesPlayedToolStripMenuItem,
            this.mostGamesLostToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1382, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mostGamesWonToolStripMenuItem
            // 
            this.mostGamesWonToolStripMenuItem.Name = "mostGamesWonToolStripMenuItem";
            this.mostGamesWonToolStripMenuItem.Size = new System.Drawing.Size(125, 24);
            this.mostGamesWonToolStripMenuItem.Text = "Highest ranking";
            this.mostGamesWonToolStripMenuItem.Click += new System.EventHandler(this.mostGamesWonToolStripMenuItem_Click);
            // 
            // mostGamesPlayedToolStripMenuItem
            // 
            this.mostGamesPlayedToolStripMenuItem.Name = "mostGamesPlayedToolStripMenuItem";
            this.mostGamesPlayedToolStripMenuItem.Size = new System.Drawing.Size(151, 24);
            this.mostGamesPlayedToolStripMenuItem.Text = "Most games played";
            // 
            // mostGamesLostToolStripMenuItem
            // 
            this.mostGamesLostToolStripMenuItem.Name = "mostGamesLostToolStripMenuItem";
            this.mostGamesLostToolStripMenuItem.Size = new System.Drawing.Size(130, 24);
            this.mostGamesLostToolStripMenuItem.Text = "Most games lost";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(593, 177);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // formRanking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1382, 782);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "formRanking";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mostGamesWonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mostGamesPlayedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mostGamesLostToolStripMenuItem;
        private System.Windows.Forms.Label label1;
    }
}