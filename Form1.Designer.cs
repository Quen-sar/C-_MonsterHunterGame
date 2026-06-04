namespace C__MonsterHunter_V2
{
    partial class Interface
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            UserName = new TextBox();
            lblNamePrompt = new Label();
            listLog = new ListBox();
            listScore = new ListBox();
            lblScoreBoard = new Label();
            groupBox1 = new GroupBox();
            lblAttackList = new Label();
            pictureBoxHero = new PictureBox();
            btnSpear = new Button();
            btnArrow = new Button();
            btnSword = new Button();
            lblMonsterHealth = new Label();
            lblMHP = new Label();
            lblMonsterName = new Label();
            lblMonster = new Label();
            lblHHP = new Label();
            lblHeroHealth = new Label();
            lblHeroName = new Label();
            lblHero = new Label();
            pictureBoxMonster = new PictureBox();
            btnStart = new Button();
            btnQuit = new Button();
            lblStatusReport = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxHero).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxMonster).BeginInit();
            SuspendLayout();
            // 
            // UserName
            // 
            UserName.BorderStyle = BorderStyle.FixedSingle;
            UserName.Location = new Point(92, 6);
            UserName.Name = "UserName";
            UserName.Size = new Size(208, 23);
            UserName.TabIndex = 0;
            // 
            // lblNamePrompt
            // 
            lblNamePrompt.AutoSize = true;
            lblNamePrompt.Location = new Point(12, 9);
            lblNamePrompt.Name = "lblNamePrompt";
            lblNamePrompt.Size = new Size(74, 15);
            lblNamePrompt.TabIndex = 1;
            lblNamePrompt.Text = "Hero Name :";
            // 
            // listLog
            // 
            listLog.FormattingEnabled = true;
            listLog.Location = new Point(12, 340);
            listLog.Name = "listLog";
            listLog.Size = new Size(776, 94);
            listLog.TabIndex = 2;
            // 
            // listScore
            // 
            listScore.FormattingEnabled = true;
            listScore.Location = new Point(607, 67);
            listScore.Name = "listScore";
            listScore.Size = new Size(181, 259);
            listScore.TabIndex = 3;
            // 
            // lblScoreBoard
            // 
            lblScoreBoard.AutoSize = true;
            lblScoreBoard.Location = new Point(609, 43);
            lblScoreBoard.Name = "lblScoreBoard";
            lblScoreBoard.Size = new Size(70, 15);
            lblScoreBoard.TabIndex = 4;
            lblScoreBoard.Text = "Top Scores :";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lblAttackList);
            groupBox1.Controls.Add(pictureBoxHero);
            groupBox1.Controls.Add(btnSpear);
            groupBox1.Controls.Add(btnArrow);
            groupBox1.Controls.Add(btnSword);
            groupBox1.Controls.Add(lblMonsterHealth);
            groupBox1.Controls.Add(lblMHP);
            groupBox1.Controls.Add(lblMonsterName);
            groupBox1.Controls.Add(lblMonster);
            groupBox1.Controls.Add(lblHHP);
            groupBox1.Controls.Add(lblHeroHealth);
            groupBox1.Controls.Add(lblHeroName);
            groupBox1.Controls.Add(lblHero);
            groupBox1.Controls.Add(pictureBoxMonster);
            groupBox1.Location = new Point(26, 65);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(556, 262);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Combatants";
            // 
            // lblAttackList
            // 
            lblAttackList.AutoSize = true;
            lblAttackList.Location = new Point(21, 189);
            lblAttackList.Name = "lblAttackList";
            lblAttackList.Size = new Size(80, 15);
            lblAttackList.TabIndex = 13;
            lblAttackList.Text = "Attack Types :";
            // 
            // pictureBoxHero
            // 
            pictureBoxHero.BackgroundImage = Properties.Resources.MonsterHunterBackgroundCut;
            pictureBoxHero.BorderStyle = BorderStyle.FixedSingle;
            pictureBoxHero.Image = Properties.Resources.MonsterHunterHero1;
            pictureBoxHero.InitialImage = null;
            pictureBoxHero.Location = new Point(133, 22);
            pictureBoxHero.Name = "pictureBoxHero";
            pictureBoxHero.Size = new Size(141, 170);
            pictureBoxHero.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxHero.TabIndex = 12;
            pictureBoxHero.TabStop = false;
            // 
            // btnSpear
            // 
            btnSpear.BackgroundImage = Properties.Resources.MonsterHunterBackgroundCut;
            btnSpear.Location = new Point(335, 216);
            btnSpear.Name = "btnSpear";
            btnSpear.Size = new Size(129, 40);
            btnSpear.TabIndex = 11;
            btnSpear.Text = "Spear (mult of 5)";
            btnSpear.UseVisualStyleBackColor = true;
            // 
            // btnArrow
            // 
            btnArrow.BackgroundImage = Properties.Resources.MonsterHunterBackgroundCut;
            btnArrow.Location = new Point(174, 216);
            btnArrow.Name = "btnArrow";
            btnArrow.Size = new Size(129, 40);
            btnArrow.TabIndex = 10;
            btnArrow.Text = "Arrow (prime)";
            btnArrow.UseVisualStyleBackColor = true;
            // 
            // btnSword
            // 
            btnSword.BackColor = SystemColors.Control;
            btnSword.BackgroundImage = Properties.Resources.MonsterHunterBackgroundCut;
            btnSword.Location = new Point(17, 216);
            btnSword.Name = "btnSword";
            btnSword.Size = new Size(129, 40);
            btnSword.TabIndex = 9;
            btnSword.Text = "Sword Slash";
            btnSword.UseVisualStyleBackColor = false;
            // 
            // lblMonsterHealth
            // 
            lblMonsterHealth.AutoSize = true;
            lblMonsterHealth.Location = new Point(291, 111);
            lblMonsterHealth.Name = "lblMonsterHealth";
            lblMonsterHealth.Size = new Size(13, 15);
            lblMonsterHealth.TabIndex = 8;
            lblMonsterHealth.Text = "0";
            // 
            // lblMHP
            // 
            lblMHP.AutoSize = true;
            lblMHP.Location = new Point(291, 85);
            lblMHP.Name = "lblMHP";
            lblMHP.Size = new Size(95, 15);
            lblMHP.TabIndex = 7;
            lblMHP.Text = "Monster Health :";
            // 
            // lblMonsterName
            // 
            lblMonsterName.AutoSize = true;
            lblMonsterName.Location = new Point(291, 61);
            lblMonsterName.Name = "lblMonsterName";
            lblMonsterName.Size = new Size(12, 15);
            lblMonsterName.TabIndex = 6;
            lblMonsterName.Text = "-";
            // 
            // lblMonster
            // 
            lblMonster.AutoSize = true;
            lblMonster.Location = new Point(291, 36);
            lblMonster.Name = "lblMonster";
            lblMonster.Size = new Size(57, 15);
            lblMonster.TabIndex = 5;
            lblMonster.Text = "Monster :";
            // 
            // lblHHP
            // 
            lblHHP.AutoSize = true;
            lblHHP.Location = new Point(18, 85);
            lblHHP.Name = "lblHHP";
            lblHHP.Size = new Size(77, 15);
            lblHHP.TabIndex = 4;
            lblHHP.Text = "Hero Health :";
            // 
            // lblHeroHealth
            // 
            lblHeroHealth.AutoSize = true;
            lblHeroHealth.Location = new Point(18, 111);
            lblHeroHealth.Name = "lblHeroHealth";
            lblHeroHealth.Size = new Size(13, 15);
            lblHeroHealth.TabIndex = 3;
            lblHeroHealth.Text = "0";
            // 
            // lblHeroName
            // 
            lblHeroName.AutoSize = true;
            lblHeroName.Location = new Point(18, 61);
            lblHeroName.Name = "lblHeroName";
            lblHeroName.Size = new Size(12, 15);
            lblHeroName.TabIndex = 2;
            lblHeroName.Text = "-";
            // 
            // lblHero
            // 
            lblHero.AutoSize = true;
            lblHero.Location = new Point(18, 36);
            lblHero.Name = "lblHero";
            lblHero.Size = new Size(39, 15);
            lblHero.TabIndex = 1;
            lblHero.Text = "Hero :";
            // 
            // pictureBoxMonster
            // 
            pictureBoxMonster.BackgroundImage = Properties.Resources.MonsterHunterBackgroundCut;
            pictureBoxMonster.BorderStyle = BorderStyle.FixedSingle;
            pictureBoxMonster.Location = new Point(406, 22);
            pictureBoxMonster.Name = "pictureBoxMonster";
            pictureBoxMonster.Size = new Size(138, 170);
            pictureBoxMonster.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxMonster.TabIndex = 0;
            pictureBoxMonster.TabStop = false;
            // 
            // btnStart
            // 
            btnStart.Location = new Point(317, 6);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(109, 23);
            btnStart.TabIndex = 6;
            btnStart.Text = "Start Battle";
            btnStart.UseVisualStyleBackColor = true;
            // 
            // btnQuit
            // 
            btnQuit.Location = new Point(432, 6);
            btnQuit.Name = "btnQuit";
            btnQuit.Size = new Size(100, 23);
            btnQuit.TabIndex = 7;
            btnQuit.Text = "Quit Game";
            btnQuit.UseVisualStyleBackColor = true;
            // 
            // lblStatusReport
            // 
            lblStatusReport.AutoSize = true;
            lblStatusReport.Location = new Point(26, 43);
            lblStatusReport.Name = "lblStatusReport";
            lblStatusReport.Size = new Size(146, 15);
            lblStatusReport.TabIndex = 8;
            lblStatusReport.Text = "Enter name and press start";
            // 
            // Interface
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.MonsterHunterBackground;
            ClientSize = new Size(800, 450);
            Controls.Add(lblStatusReport);
            Controls.Add(btnQuit);
            Controls.Add(btnStart);
            Controls.Add(groupBox1);
            Controls.Add(lblScoreBoard);
            Controls.Add(listScore);
            Controls.Add(listLog);
            Controls.Add(lblNamePrompt);
            Controls.Add(UserName);
            Name = "Interface";
            Text = "Monster Hunter";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxHero).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxMonster).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox UserName;
        private Label lblNamePrompt;
        private ListBox listLog;
        private ListBox listScore;
        private Label lblScoreBoard;
        private GroupBox groupBox1;
        private PictureBox pictureBoxMonster;
        private Button btnStart;
        private Button btnQuit;
        private Label lblHero;
        private Label lblHHP;
        private Label lblHeroHealth;
        private Label lblHeroName;
        private Label lblMonster;
        private Label lblMonsterHealth;
        private Label lblMHP;
        private Label lblMonsterName;
        private Button btnSword;
        private Button btnArrow;
        private Button btnSpear;
        private Label lblStatusReport;
        private PictureBox pictureBoxHero;
        private Label lblAttackList;
    }
}
