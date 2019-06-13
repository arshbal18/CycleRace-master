namespace RacetrackSimulator
{
    partial class CycleRace
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
            this.gamble = new System.Windows.Forms.GroupBox();
            this.Go_button = new System.Windows.Forms.Button();
            this.SamLB = new System.Windows.Forms.Label();
            this.SarahLB = new System.Windows.Forms.Label();
            this.LucyLB = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Chooseracer = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.betIncre = new System.Windows.Forms.NumericUpDown();
            this.PlaceBet = new System.Windows.Forms.Button();
            this.NameLabel = new System.Windows.Forms.Label();
            this.SamRB = new System.Windows.Forms.RadioButton();
            this.SarahRB = new System.Windows.Forms.RadioButton();
            this.LucyRB = new System.Windows.Forms.RadioButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.PBbicycle4 = new System.Windows.Forms.PictureBox();
            this.PBbicycle3 = new System.Windows.Forms.PictureBox();
            this.PBbicycle2 = new System.Windows.Forms.PictureBox();
            this.PBbicycle1 = new System.Windows.Forms.PictureBox();
            this.racetrack = new System.Windows.Forms.PictureBox();
            this.gamble.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Chooseracer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.betIncre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBbicycle4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBbicycle3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBbicycle2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBbicycle1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.racetrack)).BeginInit();
            this.SuspendLayout();
            // 
            // gamble
            // 
            this.gamble.Controls.Add(this.Go_button);
            this.gamble.Controls.Add(this.SamLB);
            this.gamble.Controls.Add(this.SarahLB);
            this.gamble.Controls.Add(this.LucyLB);
            this.gamble.Controls.Add(this.label3);
            this.gamble.Controls.Add(this.Chooseracer);
            this.gamble.Controls.Add(this.label2);
            this.gamble.Controls.Add(this.betIncre);
            this.gamble.Controls.Add(this.PlaceBet);
            this.gamble.Controls.Add(this.NameLabel);
            this.gamble.Controls.Add(this.SamRB);
            this.gamble.Controls.Add(this.SarahRB);
            this.gamble.Controls.Add(this.LucyRB);
            this.gamble.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gamble.Location = new System.Drawing.Point(11, 478);
            this.gamble.Margin = new System.Windows.Forms.Padding(2);
            this.gamble.Name = "gamble";
            this.gamble.Padding = new System.Windows.Forms.Padding(2);
            this.gamble.Size = new System.Drawing.Size(1082, 260);
            this.gamble.TabIndex = 0;
            this.gamble.TabStop = false;
            this.gamble.Enter += new System.EventHandler(this.gamble_Enter);
            // 
            // Go_button
            // 
            this.Go_button.Font = new System.Drawing.Font("Ink Free", 34F);
            this.Go_button.Location = new System.Drawing.Point(772, 91);
            this.Go_button.Margin = new System.Windows.Forms.Padding(2);
            this.Go_button.Name = "Go_button";
            this.Go_button.Size = new System.Drawing.Size(233, 96);
            this.Go_button.TabIndex = 13;
            this.Go_button.Text = "Go";
            this.Go_button.UseVisualStyleBackColor = true;
            this.Go_button.Click += new System.EventHandler(this.Start_Click);
            // 
            // SamLB
            // 
            this.SamLB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SamLB.Font = new System.Drawing.Font("Ink Free", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SamLB.Location = new System.Drawing.Point(321, 214);
            this.SamLB.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.SamLB.Name = "SamLB";
            this.SamLB.Size = new System.Drawing.Size(332, 33);
            this.SamLB.TabIndex = 12;
            this.SamLB.Text = "SamLabel";
            // 
            // SarahLB
            // 
            this.SarahLB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SarahLB.Font = new System.Drawing.Font("Ink Free", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SarahLB.Location = new System.Drawing.Point(321, 155);
            this.SarahLB.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.SarahLB.Name = "SarahLB";
            this.SarahLB.Size = new System.Drawing.Size(332, 32);
            this.SarahLB.TabIndex = 11;
            this.SarahLB.Text = "SarahLabel";
            this.SarahLB.Click += new System.EventHandler(this.SarahLB_Click);
            // 
            // LucyLB
            // 
            this.LucyLB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LucyLB.Font = new System.Drawing.Font("Ink Free", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LucyLB.Location = new System.Drawing.Point(321, 103);
            this.LucyLB.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LucyLB.Name = "LucyLB";
            this.LucyLB.Size = new System.Drawing.Size(332, 32);
            this.LucyLB.TabIndex = 10;
            this.LucyLB.Text = "Lucy label";
            this.LucyLB.Click += new System.EventHandler(this.LucyLB_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(5, 155);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 17);
            this.label3.TabIndex = 9;
            // 
            // Chooseracer
            // 
            this.Chooseracer.Location = new System.Drawing.Point(473, 47);
            this.Chooseracer.Margin = new System.Windows.Forms.Padding(2);
            this.Chooseracer.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.Chooseracer.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Chooseracer.Name = "Chooseracer";
            this.Chooseracer.Size = new System.Drawing.Size(38, 23);
            this.Chooseracer.TabIndex = 8;
            this.Chooseracer.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Ink Free", 18F);
            this.label2.Location = new System.Drawing.Point(261, 44);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(208, 30);
            this.label2.TabIndex = 7;
            this.label2.Text = "$ on Bicycle number";
            // 
            // betIncre
            // 
            this.betIncre.Location = new System.Drawing.Point(195, 47);
            this.betIncre.Margin = new System.Windows.Forms.Padding(2);
            this.betIncre.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.betIncre.Name = "betIncre";
            this.betIncre.Size = new System.Drawing.Size(47, 23);
            this.betIncre.TabIndex = 6;
            this.betIncre.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // PlaceBet
            // 
            this.PlaceBet.Font = new System.Drawing.Font("Ink Free", 18F);
            this.PlaceBet.Location = new System.Drawing.Point(106, 36);
            this.PlaceBet.Margin = new System.Windows.Forms.Padding(2);
            this.PlaceBet.Name = "PlaceBet";
            this.PlaceBet.Size = new System.Drawing.Size(73, 38);
            this.PlaceBet.TabIndex = 5;
            this.PlaceBet.Text = "Bets";
            this.PlaceBet.UseVisualStyleBackColor = true;
            this.PlaceBet.Click += new System.EventHandler(this.Bet_Click);
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Ink Free", 18F);
            this.NameLabel.Location = new System.Drawing.Point(16, 44);
            this.NameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(75, 30);
            this.NameLabel.TabIndex = 4;
            this.NameLabel.Text = "Player";
            // 
            // SamRB
            // 
            this.SamRB.AutoSize = true;
            this.SamRB.Font = new System.Drawing.Font("Ink Free", 18F);
            this.SamRB.Location = new System.Drawing.Point(15, 210);
            this.SamRB.Margin = new System.Windows.Forms.Padding(2);
            this.SamRB.Name = "SamRB";
            this.SamRB.Size = new System.Drawing.Size(129, 34);
            this.SamRB.TabIndex = 3;
            this.SamRB.TabStop = true;
            this.SamRB.Text = "SamRadio";
            this.SamRB.UseVisualStyleBackColor = true;
            this.SamRB.CheckedChanged += new System.EventHandler(this.MalkeetRadioButton_CheckedChanged);
            // 
            // SarahRB
            // 
            this.SarahRB.AutoSize = true;
            this.SarahRB.Font = new System.Drawing.Font("Ink Free", 18F);
            this.SarahRB.Location = new System.Drawing.Point(15, 155);
            this.SarahRB.Margin = new System.Windows.Forms.Padding(2);
            this.SarahRB.Name = "SarahRB";
            this.SarahRB.Size = new System.Drawing.Size(147, 34);
            this.SarahRB.TabIndex = 2;
            this.SarahRB.TabStop = true;
            this.SarahRB.Text = "SarahRadio";
            this.SarahRB.UseVisualStyleBackColor = true;
            this.SarahRB.CheckedChanged += new System.EventHandler(this.GillRadioButton_CheckedChanged);
            // 
            // LucyRB
            // 
            this.LucyRB.AutoSize = true;
            this.LucyRB.Font = new System.Drawing.Font("Ink Free", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LucyRB.Location = new System.Drawing.Point(15, 103);
            this.LucyRB.Margin = new System.Windows.Forms.Padding(2);
            this.LucyRB.Name = "LucyRB";
            this.LucyRB.Size = new System.Drawing.Size(132, 34);
            this.LucyRB.TabIndex = 1;
            this.LucyRB.TabStop = true;
            this.LucyRB.Text = "LucyRAdio";
            this.LucyRB.UseVisualStyleBackColor = true;
            this.LucyRB.CheckedChanged += new System.EventHandler(this.SimerRadioButton_CheckedChanged);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // PBbicycle4
            // 
            this.PBbicycle4.Image = global::CycleRace.Properties.Resources.bicycle;
            this.PBbicycle4.Location = new System.Drawing.Point(11, 373);
            this.PBbicycle4.Margin = new System.Windows.Forms.Padding(2);
            this.PBbicycle4.Name = "PBbicycle4";
            this.PBbicycle4.Size = new System.Drawing.Size(118, 61);
            this.PBbicycle4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PBbicycle4.TabIndex = 5;
            this.PBbicycle4.TabStop = false;
            // 
            // PBbicycle3
            // 
            this.PBbicycle3.Image = global::CycleRace.Properties.Resources.bicycle;
            this.PBbicycle3.Location = new System.Drawing.Point(11, 283);
            this.PBbicycle3.Margin = new System.Windows.Forms.Padding(2);
            this.PBbicycle3.Name = "PBbicycle3";
            this.PBbicycle3.Size = new System.Drawing.Size(118, 66);
            this.PBbicycle3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PBbicycle3.TabIndex = 4;
            this.PBbicycle3.TabStop = false;
            // 
            // PBbicycle2
            // 
            this.PBbicycle2.Image = global::CycleRace.Properties.Resources.bicycle;
            this.PBbicycle2.Location = new System.Drawing.Point(11, 118);
            this.PBbicycle2.Margin = new System.Windows.Forms.Padding(2);
            this.PBbicycle2.Name = "PBbicycle2";
            this.PBbicycle2.Size = new System.Drawing.Size(118, 62);
            this.PBbicycle2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PBbicycle2.TabIndex = 3;
            this.PBbicycle2.TabStop = false;
            // 
            // PBbicycle1
            // 
            this.PBbicycle1.Image = global::CycleRace.Properties.Resources.bicycle;
            this.PBbicycle1.Location = new System.Drawing.Point(11, 31);
            this.PBbicycle1.Margin = new System.Windows.Forms.Padding(2);
            this.PBbicycle1.Name = "PBbicycle1";
            this.PBbicycle1.Size = new System.Drawing.Size(118, 64);
            this.PBbicycle1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PBbicycle1.TabIndex = 2;
            this.PBbicycle1.TabStop = false;
            // 
            // racetrack
            // 
            this.racetrack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.racetrack.Image = global::CycleRace.Properties.Resources.roades;
            this.racetrack.Location = new System.Drawing.Point(1, 11);
            this.racetrack.Margin = new System.Windows.Forms.Padding(2);
            this.racetrack.Name = "racetrack";
            this.racetrack.Size = new System.Drawing.Size(1106, 443);
            this.racetrack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.racetrack.TabIndex = 1;
            this.racetrack.TabStop = false;
            // 
            // CycleRace
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(1107, 749);
            this.Controls.Add(this.PBbicycle4);
            this.Controls.Add(this.PBbicycle3);
            this.Controls.Add(this.PBbicycle2);
            this.Controls.Add(this.PBbicycle1);
            this.Controls.Add(this.gamble);
            this.Controls.Add(this.racetrack);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CycleRace";
            this.Text = "BicycleRace";
            this.gamble.ResumeLayout(false);
            this.gamble.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Chooseracer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.betIncre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBbicycle4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBbicycle3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBbicycle2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBbicycle1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.racetrack)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gamble;
        private System.Windows.Forms.PictureBox PBbicycle1;
        private System.Windows.Forms.PictureBox PBbicycle2;
        private System.Windows.Forms.PictureBox PBbicycle3;
        private System.Windows.Forms.PictureBox PBbicycle4;
        private System.Windows.Forms.Button Go_button;
        private System.Windows.Forms.Label SamLB;
        private System.Windows.Forms.Label SarahLB;
        private System.Windows.Forms.Label LucyLB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown Chooseracer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown betIncre;
        private System.Windows.Forms.Button PlaceBet;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.RadioButton SamRB;
        private System.Windows.Forms.RadioButton SarahRB;
        private System.Windows.Forms.RadioButton LucyRB;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox racetrack;
    }
}

