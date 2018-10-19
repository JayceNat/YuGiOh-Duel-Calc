using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Media;
using System.Drawing;
using System.Threading;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IWshRuntimeLibrary;

namespace DuelCalculator
{
    public partial class DuelCalc : Form
    {
        private string CurrentDirectory = System.IO.Directory.GetCurrentDirectory();
        public string currentDirectory { get => CurrentDirectory; set => CurrentDirectory = value; }
        public DuelCalc()
        {
            InitializeComponent();

            if (!System.IO.File.Exists(currentDirectory + @"\DuelCalc.lnk"))
                CreateShortcut();

            player1Pic.SizeMode = PictureBoxSizeMode.Zoom;
            player2Pic.SizeMode = PictureBoxSizeMode.Zoom;
            if (Settings.Default.Player1Pic == "")
                player1Pic.Image = Image.FromFile(currentDirectory + "\\Images\\pic_banner1.jpg");
            else
                player1Pic.ImageLocation = Settings.Default.Player1Pic;
            if (Settings.Default.Player2Pic == "")
                player2Pic.Image = Image.FromFile(currentDirectory + "\\Images\\pic_banner2.jpg");
            else
                player2Pic.ImageLocation = Settings.Default.Player2Pic;
            player1Pic.Show();
            player2Pic.Show();
            player1Name.Text = Settings.Default.Player1Name.ToString();
            player2Name.Text = Settings.Default.Player2Name.ToString();
            player1Life.Text = Settings.Default.Player1Life.ToString();
            player2Life.Text = Settings.Default.Player2Life.ToString();
            pointsCounter.Text = Settings.Default.PointsCounter.ToString();
            player1Bar.Maximum = Settings.Default.Player1Max;
            player2Bar.Maximum = Settings.Default.Player2Max;
            player1Bar.Value = Settings.Default.Player1Life;
            player2Bar.Value = Settings.Default.Player2Life;
            if (Settings.Default.Player1Life >= 8000)
                player1Bar.Maximum = Settings.Default.Player1Life;
            if (Settings.Default.Player2Life >= 8000)
                player2Bar.Maximum = Settings.Default.Player2Life;
            clearCounter.Select();
        }

        public string Roll_Flip(string act)
        {
            Random result = new Random();
            int val;
            switch (act)
            {
                case "roll":
                    {
                        val = result.Next(1, 7);
                        return val.ToString();
                    }                    
                case "flip":
                    {
                        val = result.Next(0, 2);
                        if (val == 0)
                            return "Heads";
                        if (val == 1)
                            return "Tails";
                        else
                            return "ERROR 404 - Dice/Coin Not Found";
                    }                    
                default:
                    return "ERROR 404 - Dice/Coin Not Found";
            }
        }

        public void Save_Game()
        {
            Settings.Default.Player1Name = player1Name.Text.ToString();
            Settings.Default.Player2Name = player2Name.Text.ToString();
            Settings.Default.Player1Life = int.Parse(player1Life.Text);
            Settings.Default.Player2Life = int.Parse(player2Life.Text);
            Settings.Default.PointsCounter = int.Parse(pointsCounter.Text);
            Settings.Default.Player1Max = player1Bar.Maximum;
            Settings.Default.Player2Max = player2Bar.Maximum;
            Settings.Default.Save();
        }

        public void Play_Sound(string what_to_play)
        {
            string sound_files = currentDirectory + "\\Sounds";
            System.Media.SoundPlayer life_drop = new System.Media.SoundPlayer(@sound_files + "\\Points drop.wav");
            System.Media.SoundPlayer life_zero = new System.Media.SoundPlayer(@sound_files + "\\Points to 0.wav");
            System.Media.SoundPlayer roll = new System.Media.SoundPlayer(sound_files + "\\rolldie.wav");
            System.Media.SoundPlayer flip = new System.Media.SoundPlayer(sound_files + "\\coinflip.wav");
            System.Media.SoundPlayer new_game = new System.Media.SoundPlayer(sound_files + "\\lets duel.wav");
            System.Media.SoundPlayer reset = new System.Media.SoundPlayer(sound_files + "\\reset.wav");

            switch (what_to_play)
            {
                case "zero":
                    life_zero.Play();
                    break;
                case "roll":
                    roll.Play();
                    break;
                case "flip":
                    flip.Play();
                    break;
                case "new":
                    new_game.Play();
                    break;
                case "reset":
                    reset.Play();
                    break;
                default:
                    life_drop.Play();       // "half", "minus", "plus"
                    break;
            }
        }

        public void CreateShortcut()
        {
            WshShell shell = new WshShell();
            string shortcutAddress = currentDirectory + @"\DuelCalc.lnk";
            IWshShortcut shortcut = (IWshShortcut)shell.CreateShortcut(shortcutAddress);
            shortcut.IconLocation = currentDirectory + @"\Images\icon.ico";
            shortcut.Description = "Yu-Gi-Oh! Duel Calculator Shortcut";
            shortcut.Hotkey = "Ctrl+Shift+Y";
            shortcut.TargetPath = currentDirectory + @"\DuelCalculator.exe";
            shortcut.Save();
        }

        public void display_Pic(int box)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp;";
            open.InitialDirectory = currentDirectory + "\\Characters";
            if (open.ShowDialog() == DialogResult.OK)
            {
                switch (box)
                {
                    case 1:
                        player1Pic.SizeMode = PictureBoxSizeMode.Zoom;
                        player1Pic.Image = new Bitmap(open.FileName);
                        Settings.Default.Player1Pic = open.FileName.ToString();
                        Settings.Default.Save();
                        break;
                    case 2:
                        player2Pic.SizeMode = PictureBoxSizeMode.Zoom;
                        player2Pic.Image = new Bitmap(open.FileName);
                        Settings.Default.Player2Pic = open.FileName.ToString();
                        Settings.Default.Save();
                        break;
                    default:
                        break;
                }
            }
        }

        private void player1Pic_Click(object sender, EventArgs e)
        {
            display_Pic(1);
            Save_Game();
        }

        private void player2Pic_Click(object sender, EventArgs e)
        {
            display_Pic(2);
            Save_Game();
        }

        private void player1Name_TextChanged(object sender, EventArgs e)
        {
            Settings.Default.Player1Name = player1Name.Text.ToString();
            Settings.Default.Save();
        }

        private void player2Name_TextChanged(object sender, EventArgs e)
        {
            Settings.Default.Player2Name = player2Name.Text.ToString();
            Settings.Default.Save();
        }        

        public void Life_Effect(int player, string amt)
        {
            Random randint = new Random();
            switch (player)
            {
                case 1:
                    if (amt == "0")
                    {
                        for (int i = 0; i < 424; i += 1)
                        {
                            player1Life.Text = randint.Next(1000, 9999).ToString();
                            player1Life.Refresh();
                        }
                    }
                    else
                    {
                        for (int i = 0; i < 280; i += 1)
                        {
                            player1Life.Text = randint.Next(1000, 9999).ToString();
                            player1Life.Refresh();
                        }
                    }
                    break;
                case 2:
                    if (amt == "0")
                    {
                        for (int i = 0; i < 424; i += 1)
                        {
                            player2Life.Text = randint.Next(1000, 9999).ToString();
                            player2Life.Refresh();
                        }
                    }
                    else
                    {
                        for (int i = 0; i < 280; i += 1)
                        {
                            player2Life.Text = randint.Next(1000, 9999).ToString();
                            player2Life.Refresh();
                        }
                    }
                    break;
                default:
                    break;
            }
        }

        private void life_Adjust(int player, string button)
        {
            if (player == 1) /////////////////////////////////////////////////// Player 1
            {
                string start_health = player1Life.Text.ToString();
                string counter_health = pointsCounter.Text.ToString();
                int.TryParse(counter_health, out int change);
                int.TryParse(start_health, out int player_health);
                int bar_before = player1Bar.Value;
                
                if (button == "minus")
                {
                    if ((player_health - change) <= 0)
                    {
                        Play_Sound("zero");
                        Life_Effect(1, "0");
                        player1Life.Text = "0";
                        player1Life.Refresh();
                        player1Bar.Maximum = 8000;
                        for (int i = 0; i < player1Bar.Value; i += 1)
                        {
                            player1Bar.Value -= 5;
                            player1Bar.Refresh();
                        }
                        player1Bar.Value = 0;
                    }
                    else
                    {
                        Play_Sound(button);
                        Life_Effect(1, "other");
                        int val = player_health - change;
                        player1Life.Text = val.ToString();
                        player1Life.Refresh();
                        for (int i = 0; i < change; i += 3)
                        {
                            player1Bar.Value -= 3;
                            player1Bar.Refresh();
                        }
                        player1Bar.Value = bar_before - change;
                    }
                }
                if (button == "plus")
                {
                    Play_Sound(button);
                    Life_Effect(1, "other");
                    int val = player_health + change;
                    player1Life.Text = val.ToString();
                    if ((bar_before + change) >= 8000)
                        player1Bar.Maximum = bar_before + change;
                    player1Bar.Value = bar_before + change;
                }
                if (button == "half")
                {
                    Play_Sound(button);
                    Life_Effect(1, "other");

                    int val = player_health / 2;
                    player1Life.Text = val.ToString();
                    player1Life.Refresh();
                    for (int i = 0; i < (player1Bar.Value / 2); i += 1)
                    {
                        player1Bar.Value -= 2;
                        player1Bar.Refresh();
                    }
                    player1Bar.Value = bar_before / 2;
                }
                player1Life.Refresh();
                player1Bar.Refresh();
            }

            if (player == 2) /////////////////////////////////////////////////// Player 2
            {
                string start_health = player2Life.Text.ToString();
                string counter_health = pointsCounter.Text.ToString();
                int.TryParse(counter_health, out int change);
                int.TryParse(start_health, out int player_health);
                int bar_before = player2Bar.Value;

                if (button == "minus")
                {
                    if ((player_health - change) <= 0)
                    {
                        Play_Sound("zero");
                        Life_Effect(2, "0");
                        player2Life.Text = "0";
                        player2Life.Refresh();
                        player2Bar.Maximum = 8000;
                        for (int i = 0; i < player2Bar.Value; i += 1)
                        {
                            player2Bar.Value -= 5;
                            player2Bar.Refresh();
                        }
                        player2Bar.Value = 0;
                    }
                    else
                    {
                        Play_Sound(button);
                        Life_Effect(2, "other");
                        int val = player_health - change;
                        player2Life.Text = val.ToString();
                        player2Life.Refresh();
                        for (int i = 0; i < change; i += 3)
                        {
                            player2Bar.Value -= 3;
                            player2Bar.Refresh();
                        }
                        player2Bar.Value = bar_before - change;
                    }
                }
                if (button == "plus")
                {
                    Play_Sound(button);
                    Life_Effect(2, "other");
                    int val = player_health + change;
                    player2Life.Text = val.ToString();
                    if ((bar_before + change) >= 8000)
                        player2Bar.Maximum = bar_before + change;
                    player2Bar.Value = bar_before + change;
                }
                if (button == "half")
                {
                    Play_Sound(button);
                    Life_Effect(2, "other");

                    int val = player_health / 2;
                    player2Life.Text = val.ToString();
                    player2Life.Refresh();
                    for (int i = 0; i < (player2Bar.Value / 2); i += 1)
                    {
                        player2Bar.Value -= 2;
                        player2Bar.Refresh();
                    }
                    player2Bar.Value = bar_before / 2;
                }
                player2Life.Refresh();
                player2Bar.Refresh();
            }
            pointsCounter.Text = "0";
            Save_Game();
        }

        private void player1Half_Click(object sender, EventArgs e)
        {
            life_Adjust(1, "half");
        }

        private void player2Half_Click(object sender, EventArgs e)
        {
            life_Adjust(2, "half");
        }

        private void player1Minus_Click(object sender, EventArgs e)
        {
            if (pointsCounter.Text != "0")
                life_Adjust(1, "minus");
        }

        private void player1Plus_Click(object sender, EventArgs e)
        {
            if (pointsCounter.Text != "0")
                life_Adjust(1, "plus");
        }

        private void player2Minus_Click(object sender, EventArgs e)
        {
            if (pointsCounter.Text != "0")
                life_Adjust(2, "minus");
        }

        private void player2Plus_Click(object sender, EventArgs e)
        {
            if (pointsCounter.Text != "0")
                life_Adjust(2, "plus");
        }

        private void pointsCounter_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(pointsCounter.Text, out int x))
                pointsCounter.Text = x.ToString();
            else
                pointsCounter.Text = "0";
        }

        public void Accum_Points(int clicked_num)
        {
            int points = 0;
            if (int.TryParse(pointsCounter.Text, out int x))
                points = clicked_num + x;
            pointsCounter.Text = points.ToString();
            Settings.Default.PointsCounter = int.Parse(pointsCounter.Text);
            Settings.Default.Save();
        }

        private void fiftyPoint_Click(object sender, EventArgs e)
        {
            Accum_Points(50);
        }

        private void hundredPoint_Click(object sender, EventArgs e)
        {
            Accum_Points(100);
        }

        private void fiveHundredPoint_Click(object sender, EventArgs e)
        {
            Accum_Points(500);
        }

        private void thousandPoint_Click(object sender, EventArgs e)
        {
            Accum_Points(1000);
        }

        private void fiveThousandPoint_Click(object sender, EventArgs e)
        {
            Accum_Points(5000);
        }

        private void clearCounter_Click(object sender, EventArgs e)
        {
            pointsCounter.Text = "0";
        }

        private void newGame_Click(object sender, EventArgs e)
        {
            Play_Sound("new");
            player1Bar.Maximum = 8000;
            player2Bar.Maximum = 8000;
            player1Bar.Minimum = 0;
            player2Bar.Minimum = 0;
            player1Life.Text = "8000";
            player2Life.Text = "8000";
            player1Bar.Value = 8000;
            player2Bar.Value = 8000;
            pointsCounter.Text = "0";
            Save_Game();
        }

        private void diceRoll_Click(object sender, EventArgs e)
        {
            Play_Sound("roll");
            MessageBox.Show("You Rolled:\n\n      " + Roll_Flip("roll").ToString() + "!", "6-Sided Die Roll", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void coinToss_Click(object sender, EventArgs e)
        {
            Play_Sound("flip");
            MessageBox.Show("You Flipped:\n\n   " + Roll_Flip("flip").ToString() + "!", "Coin Flip", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            Play_Sound("reset");
            player1Pic.Image = Image.FromFile(currentDirectory + "\\Images\\pic_banner1.jpg");
            player2Pic.Image = Image.FromFile(currentDirectory + "\\Images\\pic_banner2.jpg");
            player1Name.Text = "Player1";
            player2Name.Text = "Player2";
            player1Life.Text = "8000";
            player2Life.Text = "8000";
            player1Bar.Maximum = 8000;
            player2Bar.Maximum = 8000;
            player1Bar.Value = 8000;
            player2Bar.Value = 8000;
            pointsCounter.Text = "0";
            player1Life.Refresh();
            player2Life.Refresh();

            Settings.Default.Player1Pic = player1Pic.Image.ToString();
            Settings.Default.Player2Pic = player2Pic.Image.ToString();
            Settings.Default.Save();
            Save_Game();
        }

        private void DuelCalc_Load(object sender, EventArgs e)
        {

        }

        private void player1Life_Click(object sender, EventArgs e)
        {

        }

        private void player2Life_Click(object sender, EventArgs e)
        {

        }        
    }    
}
