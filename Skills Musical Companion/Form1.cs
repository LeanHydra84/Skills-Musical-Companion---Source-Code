﻿using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;
using MsgBox;
using System.Runtime.InteropServices;


namespace Skills_Musical_Companion
{
    public partial class Form1 : Form
    {
        //TODO:
        /*
         * 
         * Maybe output shot speeds to be parsed by the game and passed to the shot functions?
         * 
         */
        
        WindowsMediaPlayer Player;
        Timer timer;
        bool hasStarted;
        List<float> fileTiming;
        List<string> fileList;
        bool muted = false;
        Font font;
        readonly int controlNumber;
        string duration = "0:00";

        //File output
        float bpm;
        float conversion_constant;
        int upCounter;

        public Form1()
        {
            InitializeComponent();
            timer = new Timer();
            timer.Interval = 1;
            timer.Tick += new EventHandler(TimeRun);
            Reset();
            fileList = new List<string>();
            fileTiming = new List<float>();
            KeyPreview = true;
            this.KeyPress += new KeyPressEventHandler(Form1_KeyPress);
            EnableDisableButtons(false);
            reset_button.Enabled = false;
            muteButton.BackgroundImageLayout = ImageLayout.Stretch;
            Player = new WindowsMediaPlayer();
            Player.settings.volume = 100;
            font = new Font("Unispace", 6f);
            progress_bar.MouseDown += new MouseEventHandler(progBar_Clicked);
            progress_bar.MouseUp += new MouseEventHandler(progBar_release);
            controlNumber = Controls.Count - 1;
        }

        private void Reset()
        {
            upCounter = 0;
            buildFile.Enabled = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            pause.Enabled = false;
            pause.Text = "Play";
        }

        void TimeRun(Object sender, EventArgs e)
        {
            //Changes the slider to the right place
            progress_bar.Value = ((int)(Player.controls.currentPosition * 100) < progress_bar.Maximum) ? Convert.ToInt16(Player.controls.currentPosition * 100) : progress_bar.Maximum;
            changeDurationLabel();
        }

        void changeDurationLabel()
        {
            TimeSpan t = TimeSpan.FromSeconds((int)Player.controls.currentPosition);
            string currentPos = $"{t.Minutes}:{t.Seconds.ToString().PadLeft(2, '0')}";
            durationLabel.Text = $"{currentPos}/{duration}";

        }

        void EnableDisableButtons(bool h)
        {
            standard_attack.Enabled =
            shotgun_fire.Enabled =
            ringFire_attack.Enabled =
            ricochet_attack.Enabled =
            shrapnel_attack.Enabled =
            pickup_standard_attack.Enabled = h;
        }

        void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            string symbol = "";
            if (standard_attack.Enabled)
            {
                switch (e.KeyChar)
                {
                    case 'q':
                        symbol = "=";
                        break;
                    case 'w':
                        symbol = "+";
                        break;
                    case 'e':
                        symbol = "/";
                        break;
                    case 'a':
                        symbol = "$";
                        break;
                    case 's':
                        symbol = "!";
                        break;
                    case 'd':
                        symbol = "@";
                        break;
                }
            }

            if (symbol != "")
            {
                AddToFile(symbol);
                e.Handled = true;
            }

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            int oldState = (int)Player.playState;
            if ((int)Player.playState == 3)
            {
                Player.controls.pause();
            }
            else if ((int)Player.playState != 10)
            {
                Player.controls.play();
            }
            else
            {
                Player.controls.play();
            }

        }

        void InitializeFile(string path)
        {
            Player.PlayStateChange += Player_PlayStateChange;
            Player.URL = path;
            Player.controls.stop();
        }

        void UploadFile()
        {
            OpenFileDialog file = new OpenFileDialog();
            file.Filter = "Audio Files(*.MP3; *.WAV)|*.MP3;*.WAV";
            file.Multiselect = false;
            if (file.ShowDialog() == DialogResult.OK)
            {
                reset_button.Enabled = true;
                hasStarted = false;
                pause.Enabled = true;
                InitializeFile(file.FileName);
                Reset();
                reset_button.Enabled = true;
                GetBpm();
                nameLabel.Text = "File: " + file.SafeFileName;
            }
        }

        //Shows input box that asks for the BPM of the song
        void GetBpm()
        {
            fileList.Clear();
            fileTiming.Clear();
            bpm = 0;
            while (bpm == 0)
            {
                string a = "";
                Input.InputBox("BPM", "What's the BPM of the song:", ref a);
                if (float.TryParse(a, out float x))
                {
                    bpm = x;
                    conversion_constant = bpm / 60;
                    //fileList.Add(bpm.ToString());
                }
                else
                {
                    MessageBox.Show("Invalid BPM", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            bpm_label.Text = "BPM: " + bpm;
            //fileList.Add(bpm.ToString());

        }

        Point GetHeadPoint()
        {
            float G = (float)progress_bar.Value / (float)progress_bar.Maximum;
            float xpos = G * (progress_bar.ClientRectangle.Width - 2);
            xpos += 22;
            return new Point((int)xpos, 130);
        }

        //Adds entries to the lists
        void AddToFile(string input)
        {
            if (Player.playState != WMPPlayState.wmppsPlaying)
                EnableDisableButtons(false);
            fileTiming.Add((float)Player.controls.currentPosition);
            fileList.Add(input);

            Color color = Color.Transparent;
            switch(input)
            {
                case "=":
                    color = Color.Gray;
                    break;
                case "+":
                    color = Color.Purple;
                    break;
                case "$":
                    color = Color.Yellow;
                    break;
                case "!":
                    color = Color.Green;
                    break;
                case "/":
                    color = Color.Red;
                    break;
                case "@":
                    color = Color.HotPink;
                    break;
            } //Switch for the colors
            
            Point p = GetHeadPoint();
            upCounter++;
            Controls.Add(new Label { Location = p, AutoSize = true, Text = input, Name = "numberLabel"+upCounter, BackColor = color, Font = font});
            Controls["numberLabel" + upCounter].BringToFront();
        }

        private void OpenFile_Click(object sender, EventArgs e) { UploadFile(); }

        private void Player_PlayStateChange(int NewState)
        {
            if (NewState == 8)
            {
                timer.Stop();
                //hasStarted = false;
                buildFile.Enabled = true;
            }

            if (NewState == 3)
            {
                pause.Text = "Pause";
                EnableDisableButtons(true);
                if (!hasStarted)
                {
                    TimeSpan t = TimeSpan.FromSeconds((int)Player.currentMedia.duration);
                    duration = $"{t.Minutes}:{t.Seconds.ToString().PadLeft(2, '0')}";
                    durationLabel.Text = $"0:00/{duration}";
                    progress_bar.Maximum = (int)(Player.currentMedia.duration * 100);
                    timer.Start();
                    hasStarted = true;
                }
            }

            else
                pause.Text = "Play";
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            Player.settings.volume = volumeBar.Value * 10;
        }

        private void progBar_Clicked(object sender, MouseEventArgs e)
        {
            if (Player.URL != null)
            {
                timer.Stop();
            }
        }
        
        private void progBar_release(object sender, MouseEventArgs e)
        {
            if (Player.URL != null)
            {
                Player.controls.currentPosition = progress_bar.Value / 100;
                timer.Start();
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Volume: " + Player.settings.volume.ToString() + "%", "Volume");
        }


        //Attacks
        private void button1_Click(object sender, EventArgs e) { AddToFile("="); }

        private void button1_Click_2(object sender, EventArgs e) { AddToFile("+"); }

        private void ricochet_attack_Click(object sender, EventArgs e) { AddToFile("!"); }

        private void pickup_standard_attack_Click(object sender, EventArgs e) { AddToFile("@"); }

        private void ringFire_attack_Click(object sender, EventArgs e) { AddToFile("/"); }

        private void shrapnel_attack_Click(object sender, EventArgs e) { AddToFile("$"); }

        //File Output
        private void buildFile_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "Text File (*.txt)|*.txt";
            save.Title = "Save your file output";
            save.ShowDialog();
            if (save.FileName != "")
            {
                float[] timeArray = fileTiming.ToArray();
                string[] inputSort = fileList.ToArray();
                string[] timeFinal = new string[timeArray.Length];
                Array.Sort(timeArray, inputSort);
                for (int i = 0; i < timeArray.Length; i++)
                {
                    float x = timeArray[i];
                    if(i!=0)
                    {
                        x -= timeArray[i - 1];
                    }
                    x *= conversion_constant;
                    timeFinal[i] = x.ToString();
                }

                List<string> finalList = new List<string>();
                finalList.Add(bpm.ToString());
                for (int i = 0; i < timeArray.Length; i++)
                {
                    finalList.Add(timeFinal[i]);
                    finalList.Add(inputSort[i]);
                }
                finalList.Add((Player.currentMedia.duration - timeArray[timeArray.Length - 1]).ToString());
                File.WriteAllLines(save.FileName, finalList.ToArray());

            }
        }

        //Reset Button
        private void reset_button_Click(object sender, EventArgs e)
        {
            Reset();
            progress_bar.Value = 0;
            fileList.Clear();
            fileTiming.Clear();
            hasStarted = false;
            timer.Stop();
            buildFile.Enabled = false;
            int counter = Controls.Count - controlNumber;
            for (int i = 1; i < counter; i++)
            {
                Controls.RemoveByKey("numberLabel"+i);
            }

            if (Player.URL != null)
            {
                pause.Enabled = true;
                Player.controls.stop();
            }
        }

        //Mute Button
        private void muteButton_Click(object sender, EventArgs e)
        {
            muted = !muted;
            if (muted)
            {
                volumeBar.Enabled = false;
                Player.settings.volume = 0;
                muteButton.BackgroundImage = Properties.Resources.mute;
            }
            else
            {
                volumeBar.Enabled = true;
                Player.settings.volume = volumeBar.Value * 10;
                muteButton.BackgroundImage = Properties.Resources.Vol;
            }
        }

        //Change the BPM
        private void bpm_label_Click(object sender, EventArgs e)
        {
            GetBpm();
        }

        private void playback_speed_Scroll(object sender, EventArgs e)
        {
            float rate = playback_speed.Value / 10f;
            Player.settings.rate = rate;
            rate_label.Text = rate.ToString();
        }

        private void rate_label_Click(object sender, EventArgs e)
        {
            Player.settings.rate = 1;
            rate_label.Text = "1";
            playback_speed.Value = 10;
        }

        private void rate_label2_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Changes the rate of music playback.\nNot reccomended to change during playback.\nCurrent playback speed is {Player.settings.rate}");
        }
    }
}

namespace MsgBox
{

    class MyTrackBar : TrackBar
    {

        public Rectangle Slider
        {
            get
            {
                RECT rc = new RECT();
                SendMessageRect(this.Handle, TBM_GETTHUMBRECT, IntPtr.Zero, ref rc);
                return new Rectangle(rc.left, rc.top, rc.right - rc.left, rc.bottom - rc.top);
            }
        }
        public Rectangle Channel
        {
            get
            {
                RECT rc = new RECT();
                SendMessageRect(this.Handle, TBM_GETCHANNELRECT, IntPtr.Zero, ref rc);
                return new Rectangle(rc.left, rc.top, rc.right - rc.left, rc.bottom - rc.top);
            }
        }
        private const int TBM_GETCHANNELRECT = 0x400 + 26;
        private const int TBM_GETTHUMBRECT = 0x400 + 25;
        private struct RECT { public int left, top, right, bottom; }
        [DllImport("user32.dll", EntryPoint = "SendMessageW")]
        private static extern IntPtr SendMessageRect(IntPtr hWnd, int msg, IntPtr wp, ref RECT lp);
    }


    static class Input
    {

        public static DialogResult InputBox(string title, string promptText, ref string value)
        {
            Form form = new Form();
            Label label = new Label();
            TextBox textBox = new TextBox();
            Button buttonOk = new Button();
            Button buttonCancel = new Button();

            form.Text = title;
            label.Text = promptText;
            textBox.Text = value;

            buttonOk.Text = "OK";
            buttonCancel.Text = "Cancel";
            buttonOk.DialogResult = DialogResult.OK;
            buttonCancel.DialogResult = DialogResult.Cancel;

            label.SetBounds(9, 20, 372, 13);
            textBox.SetBounds(12, 36, 372, 20);
            buttonOk.SetBounds(228, 72, 75, 23);
            buttonCancel.SetBounds(309, 72, 75, 23);

            label.AutoSize = true;
            textBox.Anchor = textBox.Anchor | AnchorStyles.Right;
            buttonOk.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;

            form.ClientSize = new Size(396, 107);
            form.Controls.AddRange(new Control[] { label, textBox, buttonOk, buttonCancel });
            form.ClientSize = new Size(Math.Max(300, label.Right + 10), form.ClientSize.Height);
            form.FormBorderStyle = FormBorderStyle.FixedDialog;
            form.StartPosition = FormStartPosition.CenterScreen;
            form.MinimizeBox = false;
            form.MaximizeBox = false;
            form.AcceptButton = buttonOk;
            form.CancelButton = buttonCancel;

            DialogResult dialogResult = form.ShowDialog();
            value = textBox.Text;
            return dialogResult;
        }
    }
}