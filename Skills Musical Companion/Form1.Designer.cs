﻿namespace Skills_Musical_Companion
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.OpenFile = new System.Windows.Forms.Button();
            this.pause = new System.Windows.Forms.Button();
            this.standard_attack = new System.Windows.Forms.Button();
            this.shotgun_fire = new System.Windows.Forms.Button();
            this.ringFire_attack = new System.Windows.Forms.Button();
            this.pickup_standard_attack = new System.Windows.Forms.Button();
            this.ricochet_attack = new System.Windows.Forms.Button();
            this.shrapnel_attack = new System.Windows.Forms.Button();
            this.progress_bar = new System.Windows.Forms.TrackBar();
            this.volumeBar = new System.Windows.Forms.TrackBar();
            this.volLabel = new System.Windows.Forms.Label();
            this.bpm_label = new System.Windows.Forms.Label();
            this.buildFile = new System.Windows.Forms.Button();
            this.reset_button = new System.Windows.Forms.Button();
            this.muteButton = new System.Windows.Forms.Button();
            this.nameLabel = new System.Windows.Forms.Label();
            this.playback_speed = new System.Windows.Forms.TrackBar();
            this.rate_label = new System.Windows.Forms.Label();
            this.rate_label2 = new System.Windows.Forms.Label();
            this.durationLabel = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mainMenu1 = new System.Windows.Forms.MainMenu(this.components);
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.menuItem5 = new System.Windows.Forms.MenuItem();
            this.menuItem6 = new System.Windows.Forms.MenuItem();
            this.menuItem2 = new System.Windows.Forms.MenuItem();
            this.menuItem7 = new System.Windows.Forms.MenuItem();
            this.menuItem3 = new System.Windows.Forms.MenuItem();
            this.menuItem4 = new System.Windows.Forms.MenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.progress_bar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.volumeBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playback_speed)).BeginInit();
            this.SuspendLayout();
            // 
            // OpenFile
            // 
            this.OpenFile.Location = new System.Drawing.Point(13, 12);
            this.OpenFile.Name = "OpenFile";
            this.OpenFile.Size = new System.Drawing.Size(75, 23);
            this.OpenFile.TabIndex = 1;
            this.OpenFile.Text = "Open File...";
            this.OpenFile.UseVisualStyleBackColor = true;
            this.OpenFile.Click += new System.EventHandler(this.OpenFile_Click);
            // 
            // pause
            // 
            this.pause.Location = new System.Drawing.Point(13, 41);
            this.pause.Name = "pause";
            this.pause.Size = new System.Drawing.Size(75, 23);
            this.pause.TabIndex = 2;
            this.pause.Text = "Pause";
            this.pause.UseVisualStyleBackColor = true;
            this.pause.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // standard_attack
            // 
            this.standard_attack.BackColor = System.Drawing.SystemColors.Control;
            this.standard_attack.Location = new System.Drawing.Point(116, 12);
            this.standard_attack.Name = "standard_attack";
            this.standard_attack.Size = new System.Drawing.Size(90, 42);
            this.standard_attack.TabIndex = 3;
            this.standard_attack.Text = "Standard (Q)";
            this.standard_attack.UseVisualStyleBackColor = false;
            this.standard_attack.Click += new System.EventHandler(this.button1_Click);
            // 
            // shotgun_fire
            // 
            this.shotgun_fire.BackColor = System.Drawing.SystemColors.Control;
            this.shotgun_fire.Location = new System.Drawing.Point(212, 12);
            this.shotgun_fire.Name = "shotgun_fire";
            this.shotgun_fire.Size = new System.Drawing.Size(90, 42);
            this.shotgun_fire.TabIndex = 4;
            this.shotgun_fire.Text = "Shotgun (W)";
            this.shotgun_fire.UseVisualStyleBackColor = false;
            this.shotgun_fire.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // ringFire_attack
            // 
            this.ringFire_attack.BackColor = System.Drawing.SystemColors.Control;
            this.ringFire_attack.Location = new System.Drawing.Point(308, 12);
            this.ringFire_attack.Name = "ringFire_attack";
            this.ringFire_attack.Size = new System.Drawing.Size(90, 42);
            this.ringFire_attack.TabIndex = 5;
            this.ringFire_attack.Text = "Ring Of Fire (E)";
            this.ringFire_attack.UseVisualStyleBackColor = false;
            this.ringFire_attack.Click += new System.EventHandler(this.ringFire_attack_Click);
            // 
            // pickup_standard_attack
            // 
            this.pickup_standard_attack.BackColor = System.Drawing.SystemColors.Control;
            this.pickup_standard_attack.Location = new System.Drawing.Point(596, 12);
            this.pickup_standard_attack.Name = "pickup_standard_attack";
            this.pickup_standard_attack.Size = new System.Drawing.Size(90, 42);
            this.pickup_standard_attack.TabIndex = 8;
            this.pickup_standard_attack.Text = "Pickup (D)";
            this.pickup_standard_attack.UseVisualStyleBackColor = false;
            this.pickup_standard_attack.Click += new System.EventHandler(this.pickup_standard_attack_Click);
            // 
            // ricochet_attack
            // 
            this.ricochet_attack.BackColor = System.Drawing.SystemColors.Control;
            this.ricochet_attack.Location = new System.Drawing.Point(500, 12);
            this.ricochet_attack.Name = "ricochet_attack";
            this.ricochet_attack.Size = new System.Drawing.Size(90, 42);
            this.ricochet_attack.TabIndex = 7;
            this.ricochet_attack.Text = "Ricochet (S)";
            this.ricochet_attack.UseVisualStyleBackColor = false;
            this.ricochet_attack.Click += new System.EventHandler(this.ricochet_attack_Click);
            // 
            // shrapnel_attack
            // 
            this.shrapnel_attack.BackColor = System.Drawing.SystemColors.Control;
            this.shrapnel_attack.Location = new System.Drawing.Point(404, 12);
            this.shrapnel_attack.Name = "shrapnel_attack";
            this.shrapnel_attack.Size = new System.Drawing.Size(90, 42);
            this.shrapnel_attack.TabIndex = 6;
            this.shrapnel_attack.Text = "Shrapnel (A)";
            this.shrapnel_attack.UseVisualStyleBackColor = false;
            this.shrapnel_attack.Click += new System.EventHandler(this.shrapnel_attack_Click);
            // 
            // progress_bar
            // 
            this.progress_bar.Location = new System.Drawing.Point(13, 142);
            this.progress_bar.Name = "progress_bar";
            this.progress_bar.Size = new System.Drawing.Size(688, 45);
            this.progress_bar.TabIndex = 9;
            this.progress_bar.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            // 
            // volumeBar
            // 
            this.volumeBar.Location = new System.Drawing.Point(545, 91);
            this.volumeBar.Name = "volumeBar";
            this.volumeBar.Size = new System.Drawing.Size(104, 45);
            this.volumeBar.TabIndex = 10;
            this.volumeBar.Value = 10;
            this.volumeBar.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // volLabel
            // 
            this.volLabel.AutoSize = true;
            this.volLabel.Location = new System.Drawing.Point(497, 96);
            this.volLabel.Name = "volLabel";
            this.volLabel.Size = new System.Drawing.Size(45, 13);
            this.volLabel.TabIndex = 11;
            this.volLabel.Text = "Volume:";
            this.volLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // bpm_label
            // 
            this.bpm_label.AutoSize = true;
            this.bpm_label.Location = new System.Drawing.Point(14, 111);
            this.bpm_label.Name = "bpm_label";
            this.bpm_label.Size = new System.Drawing.Size(36, 13);
            this.bpm_label.TabIndex = 12;
            this.bpm_label.Text = "BPM: ";
            this.bpm_label.Click += new System.EventHandler(this.bpm_label_Click);
            // 
            // buildFile
            // 
            this.buildFile.Location = new System.Drawing.Point(626, 184);
            this.buildFile.Name = "buildFile";
            this.buildFile.Size = new System.Drawing.Size(75, 23);
            this.buildFile.TabIndex = 13;
            this.buildFile.Text = "Build File";
            this.buildFile.UseVisualStyleBackColor = true;
            this.buildFile.Click += new System.EventHandler(this.buildFile_Click);
            // 
            // reset_button
            // 
            this.reset_button.Location = new System.Drawing.Point(545, 184);
            this.reset_button.Name = "reset_button";
            this.reset_button.Size = new System.Drawing.Size(75, 23);
            this.reset_button.TabIndex = 14;
            this.reset_button.Text = "Reset";
            this.reset_button.UseVisualStyleBackColor = true;
            this.reset_button.Click += new System.EventHandler(this.reset_button_Click);
            // 
            // muteButton
            // 
            this.muteButton.BackgroundImage = global::Skills_Musical_Companion.Properties.Resources.Vol;
            this.muteButton.Location = new System.Drawing.Point(655, 90);
            this.muteButton.Name = "muteButton";
            this.muteButton.Size = new System.Drawing.Size(24, 24);
            this.muteButton.TabIndex = 15;
            this.muteButton.UseVisualStyleBackColor = true;
            this.muteButton.Click += new System.EventHandler(this.muteButton_Click);
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(13, 79);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(26, 13);
            this.nameLabel.TabIndex = 16;
            this.nameLabel.Text = "File:";
            this.nameLabel.Click += new System.EventHandler(this.nameLabel_Click);
            // 
            // playback_speed
            // 
            this.playback_speed.Location = new System.Drawing.Point(324, 91);
            this.playback_speed.Maximum = 20;
            this.playback_speed.Minimum = 1;
            this.playback_speed.Name = "playback_speed";
            this.playback_speed.Size = new System.Drawing.Size(104, 45);
            this.playback_speed.TabIndex = 17;
            this.playback_speed.Value = 10;
            this.playback_speed.Scroll += new System.EventHandler(this.playback_speed_Scroll);
            // 
            // rate_label
            // 
            this.rate_label.AutoSize = true;
            this.rate_label.Location = new System.Drawing.Point(434, 101);
            this.rate_label.Name = "rate_label";
            this.rate_label.Size = new System.Drawing.Size(13, 13);
            this.rate_label.TabIndex = 18;
            this.rate_label.Text = "1";
            this.rate_label.Click += new System.EventHandler(this.rate_label_Click);
            // 
            // rate_label2
            // 
            this.rate_label2.AutoSize = true;
            this.rate_label2.Location = new System.Drawing.Point(267, 96);
            this.rate_label2.Name = "rate_label2";
            this.rate_label2.Size = new System.Drawing.Size(51, 26);
            this.rate_label2.TabIndex = 19;
            this.rate_label2.Text = "Playback\r\nSpeed\r\n";
            this.rate_label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rate_label2.Click += new System.EventHandler(this.rate_label2_Click);
            // 
            // durationLabel
            // 
            this.durationLabel.AutoSize = true;
            this.durationLabel.Location = new System.Drawing.Point(22, 184);
            this.durationLabel.Name = "durationLabel";
            this.durationLabel.Size = new System.Drawing.Size(54, 13);
            this.durationLabel.TabIndex = 20;
            this.durationLabel.Text = "0:00/0:00";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // mainMenu1
            // 
            this.mainMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem1,
            this.menuItem2});
            // 
            // menuItem1
            // 
            this.menuItem1.Index = 0;
            this.menuItem1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem5,
            this.menuItem6});
            this.menuItem1.Text = "File";
            // 
            // menuItem5
            // 
            this.menuItem5.Index = 0;
            this.menuItem5.Text = "Open";
            this.menuItem5.Click += new System.EventHandler(this.menuItem5_Click);
            // 
            // menuItem6
            // 
            this.menuItem6.Index = 1;
            this.menuItem6.Text = "Clear";
            this.menuItem6.Click += new System.EventHandler(this.menuItem6_Click);
            // 
            // menuItem2
            // 
            this.menuItem2.Index = 1;
            this.menuItem2.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem7});
            this.menuItem2.Text = "Options";
            // 
            // menuItem7
            // 
            this.menuItem7.Index = 0;
            this.menuItem7.Text = "Colors";
            this.menuItem7.Click += new System.EventHandler(this.menuItem7_Click);
            // 
            // menuItem3
            // 
            this.menuItem3.Index = -1;
            this.menuItem3.Text = "Open";
            this.menuItem3.Click += new System.EventHandler(this.menuItem3_Click);
            // 
            // menuItem4
            // 
            this.menuItem4.Index = -1;
            this.menuItem4.Text = "Reset";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 215);
            this.Controls.Add(this.durationLabel);
            this.Controls.Add(this.rate_label2);
            this.Controls.Add(this.rate_label);
            this.Controls.Add(this.playback_speed);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.muteButton);
            this.Controls.Add(this.reset_button);
            this.Controls.Add(this.buildFile);
            this.Controls.Add(this.bpm_label);
            this.Controls.Add(this.volLabel);
            this.Controls.Add(this.volumeBar);
            this.Controls.Add(this.progress_bar);
            this.Controls.Add(this.pickup_standard_attack);
            this.Controls.Add(this.ricochet_attack);
            this.Controls.Add(this.shrapnel_attack);
            this.Controls.Add(this.ringFire_attack);
            this.Controls.Add(this.shotgun_fire);
            this.Controls.Add(this.standard_attack);
            this.Controls.Add(this.pause);
            this.Controls.Add(this.OpenFile);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Menu = this.mainMenu1;
            this.Name = "Form1";
            this.Text = "Musical Companion";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.progress_bar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.volumeBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playback_speed)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button OpenFile;
        private System.Windows.Forms.Button pause;
        private System.Windows.Forms.Button standard_attack;
        private System.Windows.Forms.Button shotgun_fire;
        private System.Windows.Forms.Button ringFire_attack;
        private System.Windows.Forms.Button pickup_standard_attack;
        private System.Windows.Forms.Button ricochet_attack;
        private System.Windows.Forms.Button shrapnel_attack;
        public System.Windows.Forms.TrackBar progress_bar;
        private System.Windows.Forms.TrackBar volumeBar;
        private System.Windows.Forms.Label volLabel;
        private System.Windows.Forms.Label bpm_label;
        private System.Windows.Forms.Button buildFile;
        private System.Windows.Forms.Button reset_button;
        private System.Windows.Forms.Button muteButton;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TrackBar playback_speed;
        private System.Windows.Forms.Label rate_label;
        private System.Windows.Forms.Label rate_label2;
        private System.Windows.Forms.Label durationLabel;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.MainMenu mainMenu1;
        private System.Windows.Forms.MenuItem menuItem1;
        private System.Windows.Forms.MenuItem menuItem3;
        private System.Windows.Forms.MenuItem menuItem4;
        private System.Windows.Forms.MenuItem menuItem2;
        private System.Windows.Forms.MenuItem menuItem5;
        private System.Windows.Forms.MenuItem menuItem6;
        private System.Windows.Forms.MenuItem menuItem7;
    }
}

