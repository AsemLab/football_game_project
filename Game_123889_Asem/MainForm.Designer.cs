using System.Drawing;

namespace Game_123889_Asem
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.BallTimer = new System.Windows.Forms.Timer(this.components);
            this.MenuCommands = new System.Windows.Forms.MenuStrip();
            this.GameMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.PauseCommand = new System.Windows.Forms.ToolStripMenuItem();
            this.NewGameCommand = new System.Windows.Forms.ToolStripMenuItem();
            this.GameRuleCommand = new System.Windows.Forms.ToolStripMenuItem();
            this.ProfileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.CurrentProfilesCommand = new System.Windows.Forms.ToolStripMenuItem();
            this.NewFootballerCommand = new System.Windows.Forms.ToolStripMenuItem();
            this.NewGoalkeeperCommand = new System.Windows.Forms.ToolStripMenuItem();
            this.ReportMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.HistoryCommand = new System.Windows.Forms.ToolStripMenuItem();
            this.StatisticsCommand = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitCommand = new System.Windows.Forms.ToolStripMenuItem();
            this.MovingTimer = new System.Windows.Forms.Timer(this.components);
            this.upperPost = new System.Windows.Forms.Label();
            this.lowerPost = new System.Windows.Forms.Label();
            this.GoalLabel = new System.Windows.Forms.Label();
            this.BackgroundLabel = new System.Windows.Forms.Label();
            this.PowerLabel = new System.Windows.Forms.Label();
            this.DistractorsTimer = new System.Windows.Forms.Timer(this.components);
            this.FootballerLabel = new System.Windows.Forms.PictureBox();
            this.BallLabel = new System.Windows.Forms.Label();
            this.MaskGoal = new System.Windows.Forms.PictureBox();
            this.CpuFootballer = new System.Windows.Forms.PictureBox();
            this.HumanFootballer = new System.Windows.Forms.PictureBox();
            this.CpuKeeper = new System.Windows.Forms.PictureBox();
            this.HumanKeeper = new System.Windows.Forms.PictureBox();
            this.KeeperLabel = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Ball8 = new System.Windows.Forms.PictureBox();
            this.Ball9 = new System.Windows.Forms.PictureBox();
            this.Ball7 = new System.Windows.Forms.PictureBox();
            this.Ball1 = new System.Windows.Forms.PictureBox();
            this.Ball4 = new System.Windows.Forms.PictureBox();
            this.Ball2 = new System.Windows.Forms.PictureBox();
            this.Ball3 = new System.Windows.Forms.PictureBox();
            this.Ball6 = new System.Windows.Forms.PictureBox();
            this.Ball5 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.TimeOutLabel = new System.Windows.Forms.Label();
            this.LevelLabel = new System.Windows.Forms.Label();
            this.RunTimeLabel = new System.Windows.Forms.Label();
            this.KeeperScore = new System.Windows.Forms.Label();
            this.PlayerScore = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.MenuCommands.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FootballerLabel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaskGoal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CpuFootballer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HumanFootballer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CpuKeeper)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HumanKeeper)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.KeeperLabel)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Ball8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ball9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ball7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ball1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ball4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ball2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ball3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ball6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ball5)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // BallTimer
            // 
            this.BallTimer.Interval = 51;
            this.BallTimer.Tick += new System.EventHandler(this.BallTimer_tick);
            // 
            // MenuCommands
            // 
            this.MenuCommands.AutoSize = false;
            this.MenuCommands.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.MenuCommands.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.GameMenu,
            this.ProfileMenu,
            this.ReportMenu,
            this.ExitCommand});
            this.MenuCommands.Location = new System.Drawing.Point(0, 0);
            this.MenuCommands.Name = "MenuCommands";
            this.MenuCommands.Padding = new System.Windows.Forms.Padding(0);
            this.MenuCommands.Size = new System.Drawing.Size(1264, 25);
            this.MenuCommands.TabIndex = 6;
            this.MenuCommands.Text = "menuStrip1";
            // 
            // GameMenu
            // 
            this.GameMenu.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.GameMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.PauseCommand,
            this.NewGameCommand,
            this.GameRuleCommand});
            this.GameMenu.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GameMenu.ImageTransparentColor = System.Drawing.SystemColors.MenuBar;
            this.GameMenu.Name = "GameMenu";
            this.GameMenu.Size = new System.Drawing.Size(54, 25);
            this.GameMenu.Text = "Game";
            // 
            // PauseCommand
            // 
            this.PauseCommand.Name = "PauseCommand";
            this.PauseCommand.Size = new System.Drawing.Size(218, 22);
            this.PauseCommand.Text = "Pause                 Esc";
            this.PauseCommand.Click += new System.EventHandler(this.PauseCommand_Click);
            // 
            // NewGameCommand
            // 
            this.NewGameCommand.Name = "NewGameCommand";
            this.NewGameCommand.Size = new System.Drawing.Size(218, 22);
            this.NewGameCommand.Text = "New game          Ctrl+N";
            this.NewGameCommand.Click += new System.EventHandler(this.NewGameCommand_Click);
            // 
            // GameRuleCommand
            // 
            this.GameRuleCommand.Name = "GameRuleCommand";
            this.GameRuleCommand.Size = new System.Drawing.Size(218, 22);
            this.GameRuleCommand.Text = "Game rules         Ctrl+R";
            this.GameRuleCommand.Click += new System.EventHandler(this.GameRulesCommand_Click);
            // 
            // ProfileMenu
            // 
            this.ProfileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CurrentProfilesCommand,
            this.NewFootballerCommand,
            this.NewGoalkeeperCommand});
            this.ProfileMenu.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProfileMenu.Name = "ProfileMenu";
            this.ProfileMenu.Size = new System.Drawing.Size(57, 25);
            this.ProfileMenu.Text = "Profile";
            // 
            // CurrentProfilesCommand
            // 
            this.CurrentProfilesCommand.Name = "CurrentProfilesCommand";
            this.CurrentProfilesCommand.Size = new System.Drawing.Size(262, 22);
            this.CurrentProfilesCommand.Text = "Current Profiles               Ctrl+P";
            this.CurrentProfilesCommand.Click += new System.EventHandler(this.CurrentProfilesCommand_Click);
            // 
            // NewFootballerCommand
            // 
            this.NewFootballerCommand.Name = "NewFootballerCommand";
            this.NewFootballerCommand.Size = new System.Drawing.Size(262, 22);
            this.NewFootballerCommand.Text = "New footballer player     Ctrl+F";
            this.NewFootballerCommand.Click += new System.EventHandler(this.NewFootballerCommand_Click);
            // 
            // NewGoalkeeperCommand
            // 
            this.NewGoalkeeperCommand.Name = "NewGoalkeeperCommand";
            this.NewGoalkeeperCommand.Size = new System.Drawing.Size(262, 22);
            this.NewGoalkeeperCommand.Text = "New goalkeeper player   Ctrl+G";
            this.NewGoalkeeperCommand.Click += new System.EventHandler(this.NewGoalkeeperCommand_Click);
            // 
            // ReportMenu
            // 
            this.ReportMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.HistoryCommand,
            this.StatisticsCommand});
            this.ReportMenu.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReportMenu.Name = "ReportMenu";
            this.ReportMenu.Size = new System.Drawing.Size(60, 25);
            this.ReportMenu.Text = "Report";
            // 
            // HistoryCommand
            // 
            this.HistoryCommand.Name = "HistoryCommand";
            this.HistoryCommand.Size = new System.Drawing.Size(203, 22);
            this.HistoryCommand.Text = "History            Ctrl+H";
            this.HistoryCommand.Click += new System.EventHandler(this.HistoryCommand_Click);
            // 
            // StatisticsCommand
            // 
            this.StatisticsCommand.Name = "StatisticsCommand";
            this.StatisticsCommand.Size = new System.Drawing.Size(203, 22);
            this.StatisticsCommand.Text = "Statistics         Ctrl+T";
            this.StatisticsCommand.Click += new System.EventHandler(this.StatisticsCommand_Click);
            // 
            // ExitCommand
            // 
            this.ExitCommand.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitCommand.Name = "ExitCommand";
            this.ExitCommand.Size = new System.Drawing.Size(40, 25);
            this.ExitCommand.Text = "Exit";
            this.ExitCommand.Click += new System.EventHandler(this.ExitCommand_Click);
            // 
            // MovingTimer
            // 
            this.MovingTimer.Interval = 15;
            this.MovingTimer.Tick += new System.EventHandler(this.MovingTimer_Tick);
            // 
            // upperPost
            // 
            this.upperPost.BackColor = System.Drawing.Color.White;
            this.upperPost.Location = new System.Drawing.Point(150, 240);
            this.upperPost.Margin = new System.Windows.Forms.Padding(0);
            this.upperPost.Name = "upperPost";
            this.upperPost.Size = new System.Drawing.Size(20, 20);
            this.upperPost.TabIndex = 0;
            this.upperPost.LocationChanged += new System.EventHandler(this.Control_LocationChanged);
            // 
            // lowerPost
            // 
            this.lowerPost.BackColor = System.Drawing.Color.LightYellow;
            this.lowerPost.Location = new System.Drawing.Point(150, 560);
            this.lowerPost.Margin = new System.Windows.Forms.Padding(0);
            this.lowerPost.Name = "lowerPost";
            this.lowerPost.Size = new System.Drawing.Size(20, 20);
            this.lowerPost.TabIndex = 0;
            this.lowerPost.LocationChanged += new System.EventHandler(this.Control_LocationChanged);
            // 
            // GoalLabel
            // 
            this.GoalLabel.BackColor = System.Drawing.Color.IndianRed;
            this.GoalLabel.Location = new System.Drawing.Point(50, 260);
            this.GoalLabel.Margin = new System.Windows.Forms.Padding(0);
            this.GoalLabel.MaximumSize = new System.Drawing.Size(512, 512);
            this.GoalLabel.Name = "GoalLabel";
            this.GoalLabel.Size = new System.Drawing.Size(100, 300);
            this.GoalLabel.TabIndex = 3;
            this.GoalLabel.LocationChanged += new System.EventHandler(this.Control_LocationChanged);
            this.GoalLabel.SizeChanged += new System.EventHandler(this.Control_SizeChanged);
            // 
            // BackgroundLabel
            // 
            this.BackgroundLabel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BackgroundLabel.Location = new System.Drawing.Point(700, 615);
            this.BackgroundLabel.MaximumSize = new System.Drawing.Size(1000, 50);
            this.BackgroundLabel.Name = "BackgroundLabel";
            this.BackgroundLabel.Size = new System.Drawing.Size(250, 25);
            this.BackgroundLabel.TabIndex = 17;
            // 
            // PowerLabel
            // 
            this.PowerLabel.BackColor = System.Drawing.Color.Crimson;
            this.PowerLabel.Location = new System.Drawing.Point(700, 615);
            this.PowerLabel.MaximumSize = new System.Drawing.Size(1000, 50);
            this.PowerLabel.Name = "PowerLabel";
            this.PowerLabel.Size = new System.Drawing.Size(50, 25);
            this.PowerLabel.TabIndex = 18;
            // 
            // DistractorsTimer
            // 
            this.DistractorsTimer.Interval = 25;
            this.DistractorsTimer.Tick += new System.EventHandler(this.DistractorsTimer_Tick);
            // 
            // FootballerLabel
            // 
            this.FootballerLabel.BackColor = System.Drawing.Color.Transparent;
            this.FootballerLabel.Location = new System.Drawing.Point(800, 360);
            this.FootballerLabel.Margin = new System.Windows.Forms.Padding(0);
            this.FootballerLabel.MaximumSize = new System.Drawing.Size(128, 128);
            this.FootballerLabel.Name = "FootballerLabel";
            this.FootballerLabel.Size = new System.Drawing.Size(100, 100);
            this.FootballerLabel.TabIndex = 0;
            this.FootballerLabel.TabStop = false;
            this.FootballerLabel.LocationChanged += new System.EventHandler(this.Control_LocationChanged);
            // 
            // BallLabel
            // 
            this.BallLabel.BackColor = System.Drawing.Color.Transparent;
            this.BallLabel.Image = global::Game_123889_Asem.Properties.Resources.Ball;
            this.BallLabel.Location = new System.Drawing.Point(665, 386);
            this.BallLabel.Margin = new System.Windows.Forms.Padding(0);
            this.BallLabel.Name = "BallLabel";
            this.BallLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BallLabel.Size = new System.Drawing.Size(50, 50);
            this.BallLabel.TabIndex = 0;
            this.BallLabel.EnabledChanged += new System.EventHandler(this.BallLabel_EnabledChanged);
            this.BallLabel.LocationChanged += new System.EventHandler(this.Control_LocationChanged);
            // 
            // MaskGoal
            // 
            this.MaskGoal.BackColor = System.Drawing.Color.Transparent;
            this.MaskGoal.Image = global::Game_123889_Asem.Properties.Resources.Net;
            this.MaskGoal.Location = new System.Drawing.Point(50, 240);
            this.MaskGoal.Name = "MaskGoal";
            this.MaskGoal.Size = new System.Drawing.Size(120, 340);
            this.MaskGoal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.MaskGoal.TabIndex = 29;
            this.MaskGoal.TabStop = false;
            this.MaskGoal.LocationChanged += new System.EventHandler(this.Control_LocationChanged);
            this.MaskGoal.SizeChanged += new System.EventHandler(this.Control_SizeChanged);
            // 
            // CpuFootballer
            // 
            this.CpuFootballer.BackColor = System.Drawing.Color.Transparent;
            this.CpuFootballer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.CpuFootballer.Image = ((System.Drawing.Image)(resources.GetObject("CpuFootballer.Image")));
            this.CpuFootballer.Location = new System.Drawing.Point(870, 39);
            this.CpuFootballer.Name = "CpuFootballer";
            this.CpuFootballer.Size = new System.Drawing.Size(80, 80);
            this.CpuFootballer.TabIndex = 16;
            this.CpuFootballer.TabStop = false;
            this.CpuFootballer.Tag = "";
            this.CpuFootballer.Click += new System.EventHandler(this.CpuFootballer_Click);
            // 
            // HumanFootballer
            // 
            this.HumanFootballer.BackColor = System.Drawing.Color.Transparent;
            this.HumanFootballer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.HumanFootballer.Image = ((System.Drawing.Image)(resources.GetObject("HumanFootballer.Image")));
            this.HumanFootballer.Location = new System.Drawing.Point(765, 40);
            this.HumanFootballer.Name = "HumanFootballer";
            this.HumanFootballer.Size = new System.Drawing.Size(80, 80);
            this.HumanFootballer.TabIndex = 15;
            this.HumanFootballer.TabStop = false;
            this.HumanFootballer.Tag = "";
            this.HumanFootballer.Click += new System.EventHandler(this.HumanFootballer_Click);
            // 
            // CpuKeeper
            // 
            this.CpuKeeper.BackColor = System.Drawing.Color.Transparent;
            this.CpuKeeper.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.CpuKeeper.ErrorImage = null;
            this.CpuKeeper.Image = ((System.Drawing.Image)(resources.GetObject("CpuKeeper.Image")));
            this.CpuKeeper.InitialImage = null;
            this.CpuKeeper.Location = new System.Drawing.Point(155, 40);
            this.CpuKeeper.Name = "CpuKeeper";
            this.CpuKeeper.Size = new System.Drawing.Size(80, 80);
            this.CpuKeeper.TabIndex = 14;
            this.CpuKeeper.TabStop = false;
            this.CpuKeeper.Tag = "";
            this.CpuKeeper.Click += new System.EventHandler(this.CpuKeeper_Click);
            // 
            // HumanKeeper
            // 
            this.HumanKeeper.BackColor = System.Drawing.Color.Transparent;
            this.HumanKeeper.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.HumanKeeper.Image = ((System.Drawing.Image)(resources.GetObject("HumanKeeper.Image")));
            this.HumanKeeper.InitialImage = null;
            this.HumanKeeper.Location = new System.Drawing.Point(50, 40);
            this.HumanKeeper.Name = "HumanKeeper";
            this.HumanKeeper.Size = new System.Drawing.Size(80, 80);
            this.HumanKeeper.TabIndex = 13;
            this.HumanKeeper.TabStop = false;
            this.HumanKeeper.Tag = "";
            this.HumanKeeper.Click += new System.EventHandler(this.HumanKeeper_Click);
            // 
            // KeeperLabel
            // 
            this.KeeperLabel.BackColor = System.Drawing.Color.Transparent;
            this.KeeperLabel.Location = new System.Drawing.Point(170, 360);
            this.KeeperLabel.Margin = new System.Windows.Forms.Padding(0);
            this.KeeperLabel.MaximumSize = new System.Drawing.Size(100, 300);
            this.KeeperLabel.Name = "KeeperLabel";
            this.KeeperLabel.Size = new System.Drawing.Size(100, 100);
            this.KeeperLabel.TabIndex = 1;
            this.KeeperLabel.TabStop = false;
            this.KeeperLabel.LocationChanged += new System.EventHandler(this.Control_LocationChanged);
            this.KeeperLabel.SizeChanged += new System.EventHandler(this.Control_SizeChanged);
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.Tan;
            this.panel1.BackgroundImage = global::Game_123889_Asem.Properties.Resources.Board;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.LevelLabel);
            this.panel1.Controls.Add(this.RunTimeLabel);
            this.panel1.Controls.Add(this.KeeperScore);
            this.panel1.Controls.Add(this.PlayerScore);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(1000, 25);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(264, 664);
            this.panel1.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::Game_123889_Asem.Properties.Resources.Shelf;
            this.panel2.Controls.Add(this.Ball8);
            this.panel2.Controls.Add(this.Ball9);
            this.panel2.Controls.Add(this.Ball7);
            this.panel2.Controls.Add(this.Ball1);
            this.panel2.Controls.Add(this.Ball4);
            this.panel2.Controls.Add(this.Ball2);
            this.panel2.Controls.Add(this.Ball3);
            this.panel2.Controls.Add(this.Ball6);
            this.panel2.Controls.Add(this.Ball5);
            this.panel2.Location = new System.Drawing.Point(0, 485);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(264, 175);
            this.panel2.TabIndex = 30;
            // 
            // Ball8
            // 
            this.Ball8.BackColor = System.Drawing.Color.Transparent;
            this.Ball8.Enabled = false;
            this.Ball8.Image = global::Game_123889_Asem.Properties.Resources.Ball_2;
            this.Ball8.Location = new System.Drawing.Point(137, 13);
            this.Ball8.Name = "Ball8";
            this.Ball8.Size = new System.Drawing.Size(50, 50);
            this.Ball8.TabIndex = 27;
            this.Ball8.TabStop = false;
            this.Ball8.Visible = false;
            // 
            // Ball9
            // 
            this.Ball9.BackColor = System.Drawing.Color.Transparent;
            this.Ball9.Enabled = false;
            this.Ball9.Image = global::Game_123889_Asem.Properties.Resources.Ball_2;
            this.Ball9.Location = new System.Drawing.Point(81, 13);
            this.Ball9.Name = "Ball9";
            this.Ball9.Size = new System.Drawing.Size(50, 50);
            this.Ball9.TabIndex = 26;
            this.Ball9.TabStop = false;
            this.Ball9.Visible = false;
            // 
            // Ball7
            // 
            this.Ball7.BackColor = System.Drawing.Color.Transparent;
            this.Ball7.Enabled = false;
            this.Ball7.Image = global::Game_123889_Asem.Properties.Resources.Ball_2;
            this.Ball7.Location = new System.Drawing.Point(57, 69);
            this.Ball7.Name = "Ball7";
            this.Ball7.Size = new System.Drawing.Size(50, 50);
            this.Ball7.TabIndex = 28;
            this.Ball7.TabStop = false;
            this.Ball7.Visible = false;
            // 
            // Ball1
            // 
            this.Ball1.BackColor = System.Drawing.Color.Transparent;
            this.Ball1.Enabled = false;
            this.Ball1.Image = global::Game_123889_Asem.Properties.Resources.Ball_2;
            this.Ball1.Location = new System.Drawing.Point(25, 125);
            this.Ball1.Name = "Ball1";
            this.Ball1.Size = new System.Drawing.Size(50, 50);
            this.Ball1.TabIndex = 19;
            this.Ball1.TabStop = false;
            // 
            // Ball4
            // 
            this.Ball4.BackColor = System.Drawing.Color.Transparent;
            this.Ball4.Enabled = false;
            this.Ball4.Image = global::Game_123889_Asem.Properties.Resources.Ball_2;
            this.Ball4.Location = new System.Drawing.Point(193, 125);
            this.Ball4.Name = "Ball4";
            this.Ball4.Size = new System.Drawing.Size(50, 50);
            this.Ball4.TabIndex = 21;
            this.Ball4.TabStop = false;
            // 
            // Ball2
            // 
            this.Ball2.BackColor = System.Drawing.Color.Transparent;
            this.Ball2.Enabled = false;
            this.Ball2.Image = global::Game_123889_Asem.Properties.Resources.Ball_2;
            this.Ball2.Location = new System.Drawing.Point(81, 125);
            this.Ball2.Name = "Ball2";
            this.Ball2.Size = new System.Drawing.Size(50, 50);
            this.Ball2.TabIndex = 22;
            this.Ball2.TabStop = false;
            // 
            // Ball3
            // 
            this.Ball3.BackColor = System.Drawing.Color.Transparent;
            this.Ball3.Enabled = false;
            this.Ball3.Image = global::Game_123889_Asem.Properties.Resources.Ball_2;
            this.Ball3.Location = new System.Drawing.Point(137, 125);
            this.Ball3.Name = "Ball3";
            this.Ball3.Size = new System.Drawing.Size(50, 50);
            this.Ball3.TabIndex = 23;
            this.Ball3.TabStop = false;
            // 
            // Ball6
            // 
            this.Ball6.BackColor = System.Drawing.Color.Transparent;
            this.Ball6.Enabled = false;
            this.Ball6.Image = global::Game_123889_Asem.Properties.Resources.Ball_2;
            this.Ball6.Location = new System.Drawing.Point(169, 69);
            this.Ball6.Name = "Ball6";
            this.Ball6.Size = new System.Drawing.Size(50, 50);
            this.Ball6.TabIndex = 25;
            this.Ball6.TabStop = false;
            this.Ball6.Visible = false;
            // 
            // Ball5
            // 
            this.Ball5.BackColor = System.Drawing.Color.Transparent;
            this.Ball5.Enabled = false;
            this.Ball5.Image = global::Game_123889_Asem.Properties.Resources.Ball_2;
            this.Ball5.Location = new System.Drawing.Point(113, 69);
            this.Ball5.Name = "Ball5";
            this.Ball5.Size = new System.Drawing.Size(50, 50);
            this.Ball5.TabIndex = 24;
            this.Ball5.TabStop = false;
            this.Ball5.Visible = false;
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = global::Game_123889_Asem.Properties.Resources.Screen;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Controls.Add(this.TimeOutLabel);
            this.panel3.Location = new System.Drawing.Point(3, 259);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(261, 276);
            this.panel3.TabIndex = 31;
            // 
            // TimeOutLabel
            // 
            this.TimeOutLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TimeOutLabel.BackColor = System.Drawing.Color.Transparent;
            this.TimeOutLabel.Font = new System.Drawing.Font("Tahoma", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeOutLabel.ForeColor = System.Drawing.Color.Red;
            this.TimeOutLabel.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.TimeOutLabel.Location = new System.Drawing.Point(22, 57);
            this.TimeOutLabel.Name = "TimeOutLabel";
            this.TimeOutLabel.Size = new System.Drawing.Size(218, 126);
            this.TimeOutLabel.TabIndex = 8;
            this.TimeOutLabel.Text = "00";
            this.TimeOutLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.TimeOutLabel.TextChanged += new System.EventHandler(this.Label_TextChanged);
            // 
            // LevelLabel
            // 
            this.LevelLabel.BackColor = System.Drawing.Color.Transparent;
            this.LevelLabel.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LevelLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.LevelLabel.Location = new System.Drawing.Point(95, 210);
            this.LevelLabel.Name = "LevelLabel";
            this.LevelLabel.Size = new System.Drawing.Size(90, 30);
            this.LevelLabel.TabIndex = 7;
            this.LevelLabel.Text = "1";
            this.LevelLabel.TextChanged += new System.EventHandler(this.Label_TextChanged);
            // 
            // RunTimeLabel
            // 
            this.RunTimeLabel.BackColor = System.Drawing.Color.Transparent;
            this.RunTimeLabel.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RunTimeLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.RunTimeLabel.Location = new System.Drawing.Point(95, 150);
            this.RunTimeLabel.Name = "RunTimeLabel";
            this.RunTimeLabel.Size = new System.Drawing.Size(90, 30);
            this.RunTimeLabel.TabIndex = 6;
            this.RunTimeLabel.Text = "00:00";
            this.RunTimeLabel.TextChanged += new System.EventHandler(this.Label_TextChanged);
            // 
            // KeeperScore
            // 
            this.KeeperScore.BackColor = System.Drawing.Color.Transparent;
            this.KeeperScore.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KeeperScore.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.KeeperScore.Location = new System.Drawing.Point(165, 90);
            this.KeeperScore.Name = "KeeperScore";
            this.KeeperScore.Size = new System.Drawing.Size(80, 30);
            this.KeeperScore.TabIndex = 5;
            this.KeeperScore.Text = "00";
            this.KeeperScore.TextChanged += new System.EventHandler(this.Label_TextChanged);
            // 
            // PlayerScore
            // 
            this.PlayerScore.BackColor = System.Drawing.Color.Transparent;
            this.PlayerScore.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayerScore.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.PlayerScore.Location = new System.Drawing.Point(165, 30);
            this.PlayerScore.Name = "PlayerScore";
            this.PlayerScore.Size = new System.Drawing.Size(80, 30);
            this.PlayerScore.TabIndex = 4;
            this.PlayerScore.Text = "00";
            this.PlayerScore.TextChanged += new System.EventHandler(this.Label_TextChanged);
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label8.Location = new System.Drawing.Point(15, 210);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 30);
            this.label8.TabIndex = 3;
            this.label8.Text = "Level :";
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label7.Location = new System.Drawing.Point(15, 150);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 30);
            this.label7.TabIndex = 2;
            this.label7.Text = "Time :";
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label6.Location = new System.Drawing.Point(15, 90);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(150, 30);
            this.label6.TabIndex = 1;
            this.label6.Text = "Keeper score :";
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label5.Location = new System.Drawing.Point(15, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(150, 30);
            this.label5.TabIndex = 0;
            this.label5.Text = "Player score :";
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.ForestGreen;
            this.BackgroundImage = global::Game_123889_Asem.Properties.Resources.Pitch;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1264, 687);
            this.Controls.Add(this.FootballerLabel);
            this.Controls.Add(this.BallLabel);
            this.Controls.Add(this.MaskGoal);
            this.Controls.Add(this.PowerLabel);
            this.Controls.Add(this.BackgroundLabel);
            this.Controls.Add(this.upperPost);
            this.Controls.Add(this.lowerPost);
            this.Controls.Add(this.CpuFootballer);
            this.Controls.Add(this.HumanFootballer);
            this.Controls.Add(this.CpuKeeper);
            this.Controls.Add(this.HumanKeeper);
            this.Controls.Add(this.KeeperLabel);
            this.Controls.Add(this.GoalLabel);
            this.Controls.Add(this.MenuCommands);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MainMenuStrip = this.MenuCommands;
            this.MaximumSize = new System.Drawing.Size(1280, 725);
            this.MinimumSize = new System.Drawing.Size(1280, 725);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kids football shootout";
            this.Activated += new System.EventHandler(this.Form1_Activated);
            this.Deactivate += new System.EventHandler(this.Form1_Deactivate);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyDown_Click);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.MenuCommands.ResumeLayout(false);
            this.MenuCommands.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FootballerLabel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaskGoal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CpuFootballer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HumanFootballer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CpuKeeper)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HumanKeeper)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.KeeperLabel)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Ball8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ball9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ball7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ball1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ball4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ball2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ball3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ball6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ball5)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox FootballerLabel;
        private System.Windows.Forms.PictureBox KeeperLabel;
        private System.Windows.Forms.Label GoalLabel;
        private System.Windows.Forms.Timer BallTimer;
        private System.Windows.Forms.MenuStrip MenuCommands;
        private System.Windows.Forms.ToolStripMenuItem GameMenu;
        private System.Windows.Forms.ToolStripMenuItem NewGameCommand;
        private System.Windows.Forms.ToolStripMenuItem ProfileMenu;
        private System.Windows.Forms.ToolStripMenuItem CurrentProfilesCommand;
        private System.Windows.Forms.ToolStripMenuItem NewFootballerCommand;
        private System.Windows.Forms.ToolStripMenuItem NewGoalkeeperCommand;
        private System.Windows.Forms.ToolStripMenuItem ReportMenu;
        private System.Windows.Forms.ToolStripMenuItem ExitCommand;
        private System.Windows.Forms.ToolStripMenuItem HistoryCommand;
        private System.Windows.Forms.ToolStripMenuItem StatisticsCommand;
        private System.Windows.Forms.Label LevelLabel;
        private System.Windows.Forms.Label RunTimeLabel;
        private System.Windows.Forms.Label KeeperScore;
        private System.Windows.Forms.Label PlayerScore;
        private System.Windows.Forms.Timer MovingTimer;
        private System.Windows.Forms.PictureBox HumanKeeper;
        private System.Windows.Forms.PictureBox CpuKeeper;
        private System.Windows.Forms.PictureBox HumanFootballer;
        private System.Windows.Forms.PictureBox CpuFootballer;
        private System.Windows.Forms.Label upperPost;
        private System.Windows.Forms.Label lowerPost;
        private System.Windows.Forms.Label BallLabel;
        private System.Windows.Forms.Label BackgroundLabel;
        private System.Windows.Forms.Label PowerLabel;
        private System.Windows.Forms.Label TimeOutLabel;
        private System.Windows.Forms.PictureBox Ball4;
        private System.Windows.Forms.PictureBox Ball2;
        private System.Windows.Forms.PictureBox Ball3;
        private System.Windows.Forms.PictureBox Ball1;
        private System.Windows.Forms.Timer DistractorsTimer;
        private System.Windows.Forms.PictureBox Ball5;
        private System.Windows.Forms.PictureBox Ball6;
        private System.Windows.Forms.PictureBox Ball9;
        private System.Windows.Forms.PictureBox Ball8;
        private System.Windows.Forms.PictureBox Ball7;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox MaskGoal;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ToolStripMenuItem GameRuleCommand;
        private System.Windows.Forms.ToolStripMenuItem PauseCommand;
    }
}

