namespace DuelCalculator
{
    partial class DuelCalc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DuelCalc));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.resetButton = new System.Windows.Forms.Button();
            this.player2Pic = new System.Windows.Forms.PictureBox();
            this.player2Half = new System.Windows.Forms.Button();
            this.player1Half = new System.Windows.Forms.Button();
            this.newGame = new System.Windows.Forms.Button();
            this.diceRoll = new System.Windows.Forms.Button();
            this.fiveThousandPoint = new System.Windows.Forms.Button();
            this.thousandPoint = new System.Windows.Forms.Button();
            this.fiveHundredPoint = new System.Windows.Forms.Button();
            this.hundredPoint = new System.Windows.Forms.Button();
            this.pointsCounter = new System.Windows.Forms.TextBox();
            this.player2Plus = new System.Windows.Forms.Button();
            this.player2Minus = new System.Windows.Forms.Button();
            this.player1Plus = new System.Windows.Forms.Button();
            this.player2Name = new System.Windows.Forms.TextBox();
            this.player1Name = new System.Windows.Forms.TextBox();
            this.player2Bar = new System.Windows.Forms.ProgressBar();
            this.player1Pic = new System.Windows.Forms.PictureBox();
            this.player1Bar = new System.Windows.Forms.ProgressBar();
            this.player1Minus = new System.Windows.Forms.Button();
            this.fiftyPoint = new System.Windows.Forms.Button();
            this.coinToss = new System.Windows.Forms.Button();
            this.player2Life = new System.Windows.Forms.Button();
            this.player1Life = new System.Windows.Forms.Button();
            this.clearCounter = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.player2Pic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player1Pic)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            resources.ApplyResources(this.tableLayoutPanel1, "tableLayoutPanel1");
            this.tableLayoutPanel1.Controls.Add(this.resetButton, 3, 16);
            this.tableLayoutPanel1.Controls.Add(this.player2Pic, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.player2Half, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.player1Half, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.newGame, 1, 16);
            this.tableLayoutPanel1.Controls.Add(this.diceRoll, 2, 14);
            this.tableLayoutPanel1.Controls.Add(this.fiveThousandPoint, 1, 12);
            this.tableLayoutPanel1.Controls.Add(this.thousandPoint, 1, 11);
            this.tableLayoutPanel1.Controls.Add(this.fiveHundredPoint, 1, 10);
            this.tableLayoutPanel1.Controls.Add(this.hundredPoint, 1, 9);
            this.tableLayoutPanel1.Controls.Add(this.pointsCounter, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.player2Plus, 4, 5);
            this.tableLayoutPanel1.Controls.Add(this.player2Minus, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.player1Plus, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.player2Name, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.player1Name, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.player2Bar, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.player1Pic, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.player1Bar, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.player1Minus, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.fiftyPoint, 1, 8);
            this.tableLayoutPanel1.Controls.Add(this.coinToss, 0, 14);
            this.tableLayoutPanel1.Controls.Add(this.player2Life, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.player1Life, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.clearCounter, 0, 7);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            // 
            // resetButton
            // 
            this.resetButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            resources.ApplyResources(this.resetButton, "resetButton");
            this.resetButton.ForeColor = System.Drawing.Color.Crimson;
            this.resetButton.Name = "resetButton";
            this.resetButton.UseVisualStyleBackColor = false;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // player2Pic
            // 
            this.player2Pic.BackColor = System.Drawing.Color.Black;
            resources.ApplyResources(this.player2Pic, "player2Pic");
            this.tableLayoutPanel1.SetColumnSpan(this.player2Pic, 2);
            this.player2Pic.Name = "player2Pic";
            this.player2Pic.TabStop = false;
            this.player2Pic.Click += new System.EventHandler(this.player2Pic_Click);
            // 
            // player2Half
            // 
            this.player2Half.BackColor = System.Drawing.Color.DarkSlateGray;
            resources.ApplyResources(this.player2Half, "player2Half");
            this.player2Half.ForeColor = System.Drawing.Color.LightGray;
            this.player2Half.Name = "player2Half";
            this.player2Half.UseVisualStyleBackColor = false;
            this.player2Half.Click += new System.EventHandler(this.player2Half_Click);
            // 
            // player1Half
            // 
            this.player1Half.BackColor = System.Drawing.Color.DarkSlateGray;
            resources.ApplyResources(this.player1Half, "player1Half");
            this.player1Half.ForeColor = System.Drawing.Color.LightGray;
            this.player1Half.Name = "player1Half";
            this.player1Half.UseVisualStyleBackColor = false;
            this.player1Half.Click += new System.EventHandler(this.player1Half_Click);
            // 
            // newGame
            // 
            this.newGame.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            resources.ApplyResources(this.newGame, "newGame");
            this.tableLayoutPanel1.SetColumnSpan(this.newGame, 2);
            this.newGame.ForeColor = System.Drawing.Color.Ivory;
            this.newGame.Name = "newGame";
            this.newGame.UseVisualStyleBackColor = true;
            this.newGame.Click += new System.EventHandler(this.newGame_Click);
            // 
            // diceRoll
            // 
            this.diceRoll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            resources.ApplyResources(this.diceRoll, "diceRoll");
            this.tableLayoutPanel1.SetColumnSpan(this.diceRoll, 2);
            this.diceRoll.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.diceRoll.Name = "diceRoll";
            this.diceRoll.UseVisualStyleBackColor = false;
            this.diceRoll.Click += new System.EventHandler(this.diceRoll_Click);
            // 
            // fiveThousandPoint
            // 
            this.fiveThousandPoint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            resources.ApplyResources(this.fiveThousandPoint, "fiveThousandPoint");
            this.tableLayoutPanel1.SetColumnSpan(this.fiveThousandPoint, 2);
            this.fiveThousandPoint.ForeColor = System.Drawing.Color.Bisque;
            this.fiveThousandPoint.Name = "fiveThousandPoint";
            this.fiveThousandPoint.UseVisualStyleBackColor = false;
            this.fiveThousandPoint.Click += new System.EventHandler(this.fiveThousandPoint_Click);
            // 
            // thousandPoint
            // 
            this.thousandPoint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            resources.ApplyResources(this.thousandPoint, "thousandPoint");
            this.tableLayoutPanel1.SetColumnSpan(this.thousandPoint, 2);
            this.thousandPoint.ForeColor = System.Drawing.Color.Bisque;
            this.thousandPoint.Name = "thousandPoint";
            this.thousandPoint.UseVisualStyleBackColor = false;
            this.thousandPoint.Click += new System.EventHandler(this.thousandPoint_Click);
            // 
            // fiveHundredPoint
            // 
            this.fiveHundredPoint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            resources.ApplyResources(this.fiveHundredPoint, "fiveHundredPoint");
            this.tableLayoutPanel1.SetColumnSpan(this.fiveHundredPoint, 2);
            this.fiveHundredPoint.ForeColor = System.Drawing.Color.Bisque;
            this.fiveHundredPoint.Name = "fiveHundredPoint";
            this.fiveHundredPoint.UseVisualStyleBackColor = false;
            this.fiveHundredPoint.Click += new System.EventHandler(this.fiveHundredPoint_Click);
            // 
            // hundredPoint
            // 
            this.hundredPoint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            resources.ApplyResources(this.hundredPoint, "hundredPoint");
            this.tableLayoutPanel1.SetColumnSpan(this.hundredPoint, 2);
            this.hundredPoint.ForeColor = System.Drawing.Color.Bisque;
            this.hundredPoint.Name = "hundredPoint";
            this.hundredPoint.UseVisualStyleBackColor = false;
            this.hundredPoint.Click += new System.EventHandler(this.hundredPoint_Click);
            // 
            // pointsCounter
            // 
            this.pointsCounter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.tableLayoutPanel1.SetColumnSpan(this.pointsCounter, 4);
            resources.ApplyResources(this.pointsCounter, "pointsCounter");
            this.pointsCounter.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.pointsCounter.Name = "pointsCounter";
            this.pointsCounter.ReadOnly = true;
            this.pointsCounter.TextChanged += new System.EventHandler(this.pointsCounter_TextChanged);
            // 
            // player2Plus
            // 
            this.player2Plus.BackColor = System.Drawing.Color.YellowGreen;
            resources.ApplyResources(this.player2Plus, "player2Plus");
            this.player2Plus.ForeColor = System.Drawing.Color.Goldenrod;
            this.player2Plus.Name = "player2Plus";
            this.player2Plus.UseVisualStyleBackColor = false;
            this.player2Plus.Click += new System.EventHandler(this.player2Plus_Click);
            // 
            // player2Minus
            // 
            this.player2Minus.BackColor = System.Drawing.Color.Crimson;
            resources.ApplyResources(this.player2Minus, "player2Minus");
            this.player2Minus.ForeColor = System.Drawing.Color.Goldenrod;
            this.player2Minus.Name = "player2Minus";
            this.player2Minus.UseVisualStyleBackColor = false;
            this.player2Minus.Click += new System.EventHandler(this.player2Minus_Click);
            // 
            // player1Plus
            // 
            this.player1Plus.BackColor = System.Drawing.Color.YellowGreen;
            resources.ApplyResources(this.player1Plus, "player1Plus");
            this.player1Plus.ForeColor = System.Drawing.Color.Goldenrod;
            this.player1Plus.Name = "player1Plus";
            this.player1Plus.UseVisualStyleBackColor = false;
            this.player1Plus.Click += new System.EventHandler(this.player1Plus_Click);
            // 
            // player2Name
            // 
            this.player2Name.BackColor = System.Drawing.Color.Black;
            this.player2Name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tableLayoutPanel1.SetColumnSpan(this.player2Name, 2);
            resources.ApplyResources(this.player2Name, "player2Name");
            this.player2Name.ForeColor = System.Drawing.Color.DarkRed;
            this.player2Name.Name = "player2Name";
            this.player2Name.TextChanged += new System.EventHandler(this.player2Name_TextChanged);
            // 
            // player1Name
            // 
            this.player1Name.BackColor = System.Drawing.Color.Black;
            this.player1Name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tableLayoutPanel1.SetColumnSpan(this.player1Name, 2);
            resources.ApplyResources(this.player1Name, "player1Name");
            this.player1Name.ForeColor = System.Drawing.Color.DarkRed;
            this.player1Name.Name = "player1Name";
            this.player1Name.TextChanged += new System.EventHandler(this.player1Name_TextChanged);
            // 
            // player2Bar
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.player2Bar, 2);
            resources.ApplyResources(this.player2Bar, "player2Bar");
            this.player2Bar.ForeColor = System.Drawing.Color.DarkViolet;
            this.player2Bar.Maximum = 8000;
            this.player2Bar.Name = "player2Bar";
            this.player2Bar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.player2Bar.Value = 8000;
            // 
            // player1Pic
            // 
            this.player1Pic.BackColor = System.Drawing.Color.Black;
            resources.ApplyResources(this.player1Pic, "player1Pic");
            this.tableLayoutPanel1.SetColumnSpan(this.player1Pic, 2);
            this.player1Pic.Name = "player1Pic";
            this.player1Pic.TabStop = false;
            this.player1Pic.Click += new System.EventHandler(this.player1Pic_Click);
            // 
            // player1Bar
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.player1Bar, 2);
            resources.ApplyResources(this.player1Bar, "player1Bar");
            this.player1Bar.ForeColor = System.Drawing.Color.DarkViolet;
            this.player1Bar.Maximum = 8000;
            this.player1Bar.Name = "player1Bar";
            this.player1Bar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.player1Bar.Value = 8000;
            // 
            // player1Minus
            // 
            this.player1Minus.BackColor = System.Drawing.Color.Crimson;
            resources.ApplyResources(this.player1Minus, "player1Minus");
            this.player1Minus.ForeColor = System.Drawing.Color.Goldenrod;
            this.player1Minus.Name = "player1Minus";
            this.player1Minus.UseVisualStyleBackColor = false;
            this.player1Minus.Click += new System.EventHandler(this.player1Minus_Click);
            // 
            // fiftyPoint
            // 
            this.fiftyPoint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            resources.ApplyResources(this.fiftyPoint, "fiftyPoint");
            this.tableLayoutPanel1.SetColumnSpan(this.fiftyPoint, 2);
            this.fiftyPoint.ForeColor = System.Drawing.Color.Bisque;
            this.fiftyPoint.Name = "fiftyPoint";
            this.fiftyPoint.UseVisualStyleBackColor = false;
            this.fiftyPoint.Click += new System.EventHandler(this.fiftyPoint_Click);
            // 
            // coinToss
            // 
            this.coinToss.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            resources.ApplyResources(this.coinToss, "coinToss");
            this.tableLayoutPanel1.SetColumnSpan(this.coinToss, 2);
            this.coinToss.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.coinToss.Name = "coinToss";
            this.coinToss.UseVisualStyleBackColor = false;
            this.coinToss.Click += new System.EventHandler(this.coinToss_Click);
            // 
            // player2Life
            // 
            resources.ApplyResources(this.player2Life, "player2Life");
            this.tableLayoutPanel1.SetColumnSpan(this.player2Life, 2);
            this.player2Life.FlatAppearance.BorderColor = System.Drawing.Color.Indigo;
            this.player2Life.FlatAppearance.BorderSize = 0;
            this.player2Life.ForeColor = System.Drawing.Color.Goldenrod;
            this.player2Life.Name = "player2Life";
            this.player2Life.UseVisualStyleBackColor = true;
            this.player2Life.Click += new System.EventHandler(this.player2Life_Click);
            // 
            // player1Life
            // 
            resources.ApplyResources(this.player1Life, "player1Life");
            this.tableLayoutPanel1.SetColumnSpan(this.player1Life, 2);
            this.player1Life.FlatAppearance.BorderColor = System.Drawing.Color.Indigo;
            this.player1Life.FlatAppearance.BorderSize = 0;
            this.player1Life.ForeColor = System.Drawing.Color.Goldenrod;
            this.player1Life.Name = "player1Life";
            this.player1Life.UseVisualStyleBackColor = true;
            this.player1Life.Click += new System.EventHandler(this.player1Life_Click);
            // 
            // clearCounter
            // 
            resources.ApplyResources(this.clearCounter, "clearCounter");
            this.tableLayoutPanel1.SetColumnSpan(this.clearCounter, 4);
            this.clearCounter.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.clearCounter.FlatAppearance.BorderSize = 0;
            this.clearCounter.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.clearCounter.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.clearCounter.ForeColor = System.Drawing.Color.Goldenrod;
            this.clearCounter.Name = "clearCounter";
            this.clearCounter.UseVisualStyleBackColor = true;
            this.clearCounter.Click += new System.EventHandler(this.clearCounter_Click);
            // 
            // DuelCalc
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Controls.Add(this.tableLayoutPanel1);
            this.MaximizeBox = false;
            this.Name = "DuelCalc";
            this.Load += new System.EventHandler(this.DuelCalc_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.player2Pic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player1Pic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox player1Pic;
        private System.Windows.Forms.ProgressBar player2Bar;
        private System.Windows.Forms.ProgressBar player1Bar;
        private System.Windows.Forms.TextBox player2Name;
        private System.Windows.Forms.TextBox player1Name;
        private System.Windows.Forms.Button player1Plus;
        private System.Windows.Forms.Button player1Minus;
        private System.Windows.Forms.TextBox pointsCounter;
        private System.Windows.Forms.Button player2Plus;
        private System.Windows.Forms.Button player2Minus;
        private System.Windows.Forms.Button newGame;
        private System.Windows.Forms.Button diceRoll;
        private System.Windows.Forms.Button fiveThousandPoint;
        private System.Windows.Forms.Button thousandPoint;
        private System.Windows.Forms.Button fiveHundredPoint;
        private System.Windows.Forms.Button hundredPoint;
        private System.Windows.Forms.Button fiftyPoint;
        private System.Windows.Forms.Button coinToss;
        private System.Windows.Forms.Button player2Half;
        private System.Windows.Forms.Button player1Half;
        private System.Windows.Forms.Button player2Life;
        private System.Windows.Forms.Button player1Life;
        private System.Windows.Forms.Button clearCounter;
        private System.Windows.Forms.PictureBox player2Pic;
        private System.Windows.Forms.Button resetButton;
    }
}

