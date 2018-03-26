namespace Voetbaltafel_competitie
{
    partial class Mainform
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mainform));
            this.cbbAttackerblack = new System.Windows.Forms.ComboBox();
            this.playersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._BusinessLayer_VoetbaltabelContextDataSet2 = new Voetbaltafel_competitie._BusinessLayer_VoetbaltabelContextDataSet2();
            this.cbbDefenderblack = new System.Windows.Forms.ComboBox();
            this.cbbAttackerwhite = new System.Windows.Forms.ComboBox();
            this.cbbDefenderwhite = new System.Windows.Forms.ComboBox();
            this.lblAttackerwhite = new System.Windows.Forms.Label();
            this.lblDefenderwhite = new System.Windows.Forms.Label();
            this.lblAttackerblack = new System.Windows.Forms.Label();
            this.lblDefenderblack = new System.Windows.Forms.Label();
            this.btnAddplayer = new System.Windows.Forms.Button();
            this.btnSubmitscore = new System.Windows.Forms.Button();
            this.lblScore = new System.Windows.Forms.Label();
            this.scoreWhite = new System.Windows.Forms.NumericUpDown();
            this.scoreBlack = new System.Windows.Forms.NumericUpDown();
            this.lblPlayername = new System.Windows.Forms.Label();
            this.timerUndo = new System.Windows.Forms.Timer(this.components);
            this.cbbAddRemove = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.playersTableAdapter = new Voetbaltafel_competitie._BusinessLayer_VoetbaltabelContextDataSet2TableAdapters.PlayersTableAdapter();
            this.btnRemoveplayer = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.playersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._BusinessLayer_VoetbaltabelContextDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scoreWhite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scoreBlack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cbbAttackerblack
            // 
            this.cbbAttackerblack.FormattingEnabled = true;
            this.cbbAttackerblack.Location = new System.Drawing.Point(525, 166);
            this.cbbAttackerblack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbbAttackerblack.Name = "cbbAttackerblack";
            this.cbbAttackerblack.Size = new System.Drawing.Size(121, 24);
            this.cbbAttackerblack.Sorted = true;
            this.cbbAttackerblack.TabIndex = 0;
            // 
            // playersBindingSource
            // 
            this.playersBindingSource.DataMember = "Players";
            this.playersBindingSource.DataSource = this._BusinessLayer_VoetbaltabelContextDataSet2;
            // 
            // _BusinessLayer_VoetbaltabelContextDataSet2
            // 
            this._BusinessLayer_VoetbaltabelContextDataSet2.DataSetName = "_BusinessLayer_VoetbaltabelContextDataSet2";
            this._BusinessLayer_VoetbaltabelContextDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cbbDefenderblack
            // 
            this.cbbDefenderblack.DisplayMember = "\"Name\"";
            this.cbbDefenderblack.FormattingEnabled = true;
            this.cbbDefenderblack.Location = new System.Drawing.Point(525, 422);
            this.cbbDefenderblack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbbDefenderblack.Name = "cbbDefenderblack";
            this.cbbDefenderblack.Size = new System.Drawing.Size(121, 24);
            this.cbbDefenderblack.Sorted = true;
            this.cbbDefenderblack.TabIndex = 1;
            this.cbbDefenderblack.ValueMember = "\"Name\"";
            // 
            // cbbAttackerwhite
            // 
            this.cbbAttackerwhite.DisplayMember = "\"Name\"";
            this.cbbAttackerwhite.FormattingEnabled = true;
            this.cbbAttackerwhite.Location = new System.Drawing.Point(23, 422);
            this.cbbAttackerwhite.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbbAttackerwhite.Name = "cbbAttackerwhite";
            this.cbbAttackerwhite.Size = new System.Drawing.Size(121, 24);
            this.cbbAttackerwhite.Sorted = true;
            this.cbbAttackerwhite.TabIndex = 2;
            this.cbbAttackerwhite.ValueMember = "\"Name\"";
            // 
            // cbbDefenderwhite
            // 
            this.cbbDefenderwhite.DisplayMember = "\"Name\"";
            this.cbbDefenderwhite.FormattingEnabled = true;
            this.cbbDefenderwhite.Location = new System.Drawing.Point(23, 166);
            this.cbbDefenderwhite.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbbDefenderwhite.Name = "cbbDefenderwhite";
            this.cbbDefenderwhite.Size = new System.Drawing.Size(121, 24);
            this.cbbDefenderwhite.Sorted = true;
            this.cbbDefenderwhite.TabIndex = 3;
            this.cbbDefenderwhite.ValueMember = "\"Name\"";
            // 
            // lblAttackerwhite
            // 
            this.lblAttackerwhite.AutoSize = true;
            this.lblAttackerwhite.Location = new System.Drawing.Point(33, 402);
            this.lblAttackerwhite.Name = "lblAttackerwhite";
            this.lblAttackerwhite.Size = new System.Drawing.Size(100, 17);
            this.lblAttackerwhite.TabIndex = 4;
            this.lblAttackerwhite.Text = "Attacker White";
            // 
            // lblDefenderwhite
            // 
            this.lblDefenderwhite.AutoSize = true;
            this.lblDefenderwhite.Location = new System.Drawing.Point(29, 146);
            this.lblDefenderwhite.Name = "lblDefenderwhite";
            this.lblDefenderwhite.Size = new System.Drawing.Size(107, 17);
            this.lblDefenderwhite.TabIndex = 5;
            this.lblDefenderwhite.Text = "Defender White";
            // 
            // lblAttackerblack
            // 
            this.lblAttackerblack.AutoSize = true;
            this.lblAttackerblack.Location = new System.Drawing.Point(537, 146);
            this.lblAttackerblack.Name = "lblAttackerblack";
            this.lblAttackerblack.Size = new System.Drawing.Size(98, 17);
            this.lblAttackerblack.TabIndex = 6;
            this.lblAttackerblack.Text = "Attacker Black";
            // 
            // lblDefenderblack
            // 
            this.lblDefenderblack.AutoSize = true;
            this.lblDefenderblack.Location = new System.Drawing.Point(533, 402);
            this.lblDefenderblack.Name = "lblDefenderblack";
            this.lblDefenderblack.Size = new System.Drawing.Size(105, 17);
            this.lblDefenderblack.TabIndex = 7;
            this.lblDefenderblack.Text = "Defender Black";
            // 
            // btnAddplayer
            // 
            this.btnAddplayer.Location = new System.Drawing.Point(437, 678);
            this.btnAddplayer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddplayer.Name = "btnAddplayer";
            this.btnAddplayer.Size = new System.Drawing.Size(149, 30);
            this.btnAddplayer.TabIndex = 10;
            this.btnAddplayer.Text = "Add Player";
            this.btnAddplayer.UseVisualStyleBackColor = true;
            this.btnAddplayer.Click += new System.EventHandler(this.btnAddplayer_Click);
            // 
            // btnSubmitscore
            // 
            this.btnSubmitscore.Location = new System.Drawing.Point(244, 587);
            this.btnSubmitscore.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSubmitscore.Name = "btnSubmitscore";
            this.btnSubmitscore.Size = new System.Drawing.Size(184, 30);
            this.btnSubmitscore.TabIndex = 12;
            this.btnSubmitscore.Text = "Submit";
            this.btnSubmitscore.UseVisualStyleBackColor = true;
            this.btnSubmitscore.Click += new System.EventHandler(this.btnSubmitscore_Click);
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Location = new System.Drawing.Point(331, 12);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(13, 17);
            this.lblScore.TabIndex = 13;
            this.lblScore.Text = "-";
            // 
            // scoreWhite
            // 
            this.scoreWhite.BackColor = System.Drawing.SystemColors.Window;
            this.scoreWhite.Location = new System.Drawing.Point(201, 10);
            this.scoreWhite.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.scoreWhite.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.scoreWhite.Name = "scoreWhite";
            this.scoreWhite.Size = new System.Drawing.Size(77, 22);
            this.scoreWhite.TabIndex = 15;
            this.scoreWhite.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // scoreBlack
            // 
            this.scoreBlack.BackColor = System.Drawing.SystemColors.Window;
            this.scoreBlack.Location = new System.Drawing.Point(404, 10);
            this.scoreBlack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.scoreBlack.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.scoreBlack.Name = "scoreBlack";
            this.scoreBlack.Size = new System.Drawing.Size(77, 22);
            this.scoreBlack.TabIndex = 16;
            this.scoreBlack.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // lblPlayername
            // 
            this.lblPlayername.AutoSize = true;
            this.lblPlayername.Location = new System.Drawing.Point(340, 645);
            this.lblPlayername.Name = "lblPlayername";
            this.lblPlayername.Size = new System.Drawing.Size(91, 17);
            this.lblPlayername.TabIndex = 19;
            this.lblPlayername.Text = "Player name:";
            // 
            // timerUndo
            // 
            this.timerUndo.Interval = 1000;
            this.timerUndo.Tick += new System.EventHandler(this.timerUndo_Tick);
            // 
            // cbbAddRemove
            // 
            this.cbbAddRemove.FormattingEnabled = true;
            this.cbbAddRemove.Location = new System.Drawing.Point(437, 642);
            this.cbbAddRemove.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbbAddRemove.Name = "cbbAddRemove";
            this.cbbAddRemove.Size = new System.Drawing.Size(149, 24);
            this.cbbAddRemove.Sorted = true;
            this.cbbAddRemove.TabIndex = 21;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(149, 38);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(371, 530);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // playersTableAdapter
            // 
            this.playersTableAdapter.ClearBeforeFill = true;
            // 
            // btnRemoveplayer
            // 
            this.btnRemoveplayer.Location = new System.Drawing.Point(279, 678);
            this.btnRemoveplayer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRemoveplayer.Name = "btnRemoveplayer";
            this.btnRemoveplayer.Size = new System.Drawing.Size(149, 30);
            this.btnRemoveplayer.TabIndex = 23;
            this.btnRemoveplayer.Text = "Remove Player";
            this.btnRemoveplayer.UseVisualStyleBackColor = true;
            this.btnRemoveplayer.Click += new System.EventHandler(this.btnRemoveplayer_Click);
            // 
            // Mainform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 737);
            this.Controls.Add(this.btnRemoveplayer);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cbbAddRemove);
            this.Controls.Add(this.lblPlayername);
            this.Controls.Add(this.scoreBlack);
            this.Controls.Add(this.scoreWhite);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.btnSubmitscore);
            this.Controls.Add(this.btnAddplayer);
            this.Controls.Add(this.lblDefenderblack);
            this.Controls.Add(this.lblAttackerblack);
            this.Controls.Add(this.lblDefenderwhite);
            this.Controls.Add(this.lblAttackerwhite);
            this.Controls.Add(this.cbbDefenderwhite);
            this.Controls.Add(this.cbbAttackerwhite);
            this.Controls.Add(this.cbbDefenderblack);
            this.Controls.Add(this.cbbAttackerblack);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Mainform";
            this.Text = "Soccer";
            ((System.ComponentModel.ISupportInitialize)(this.playersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._BusinessLayer_VoetbaltabelContextDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scoreWhite)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scoreBlack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbbAttackerblack;
        private System.Windows.Forms.ComboBox cbbDefenderblack;
        private System.Windows.Forms.ComboBox cbbAttackerwhite;
        private System.Windows.Forms.ComboBox cbbDefenderwhite;
        private System.Windows.Forms.Label lblAttackerwhite;
        private System.Windows.Forms.Label lblDefenderwhite;
        private System.Windows.Forms.Label lblAttackerblack;
        private System.Windows.Forms.Label lblDefenderblack;
        private System.Windows.Forms.Button btnAddplayer;
        private System.Windows.Forms.Button btnSubmitscore;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.NumericUpDown scoreWhite;
        private System.Windows.Forms.NumericUpDown scoreBlack;
        private System.Windows.Forms.Label lblPlayername;
        private System.Windows.Forms.Timer timerUndo;
        private System.Windows.Forms.ComboBox cbbAddRemove;
        private System.Windows.Forms.PictureBox pictureBox1;
        private _BusinessLayer_VoetbaltabelContextDataSet2 _BusinessLayer_VoetbaltabelContextDataSet2;
        private System.Windows.Forms.BindingSource playersBindingSource;
        private _BusinessLayer_VoetbaltabelContextDataSet2TableAdapters.PlayersTableAdapter playersTableAdapter;
        private System.Windows.Forms.Button btnRemoveplayer;
    }
}

