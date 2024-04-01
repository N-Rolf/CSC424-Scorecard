namespace CSC424_ScoreCard
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
            this._2ptMade = new System.Windows.Forms.Button();
            this._2ptMissed = new System.Windows.Forms.Button();
            this._3ptMissed = new System.Windows.Forms.Button();
            this._3ptMade = new System.Windows.Forms.Button();
            this._FreeThrwMissed = new System.Windows.Forms.Button();
            this._FreeThrwMade = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this._Rebound = new System.Windows.Forms.Button();
            this._Block = new System.Windows.Forms.Button();
            this._Assist = new System.Windows.Forms.Button();
            this._Steal = new System.Windows.Forms.Button();
            this._TurnOver = new System.Windows.Forms.Button();
            this._player1 = new System.Windows.Forms.Button();
            this._player2 = new System.Windows.Forms.Button();
            this._player3 = new System.Windows.Forms.Button();
            this._player4 = new System.Windows.Forms.Button();
            this._player5 = new System.Windows.Forms.Button();
            this._player10 = new System.Windows.Forms.Button();
            this._player9 = new System.Windows.Forms.Button();
            this._player8 = new System.Windows.Forms.Button();
            this._player7 = new System.Windows.Forms.Button();
            this._player6 = new System.Windows.Forms.Button();
            this._player15 = new System.Windows.Forms.Button();
            this._player14 = new System.Windows.Forms.Button();
            this._player13 = new System.Windows.Forms.Button();
            this._player12 = new System.Windows.Forms.Button();
            this._player11 = new System.Windows.Forms.Button();
            this.CurrentGameStatPnl = new System.Windows.Forms.TableLayoutPanel();
            this._PlayerNameDispaly = new System.Windows.Forms.Label();
            this._StealsDisplay = new System.Windows.Forms.Label();
            this._PointsDisplay = new System.Windows.Forms.Label();
            this._AssistDisplay = new System.Windows.Forms.Label();
            this._ReboundsDisplay = new System.Windows.Forms.Label();
            this._BlocksDisplay = new System.Windows.Forms.Label();
            this._TurnOversDisplay = new System.Windows.Forms.Label();
            this._FieldGoalPercent = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.GameStats = new System.Windows.Forms.TabPage();
            this.SeasonStats = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.CurrentGameStatPnl.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.GameStats.SuspendLayout();
            this.SeasonStats.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // _2ptMade
            // 
            this._2ptMade.BackColor = System.Drawing.Color.ForestGreen;
            this._2ptMade.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._2ptMade.Location = new System.Drawing.Point(9, 172);
            this._2ptMade.Name = "_2ptMade";
            this._2ptMade.Size = new System.Drawing.Size(113, 39);
            this._2ptMade.TabIndex = 0;
            this._2ptMade.Text = "Made";
            this._2ptMade.UseVisualStyleBackColor = false;
            this._2ptMade.Click += new System.EventHandler(this._2ptMade_Click);
            // 
            // _2ptMissed
            // 
            this._2ptMissed.BackColor = System.Drawing.Color.Firebrick;
            this._2ptMissed.Location = new System.Drawing.Point(128, 172);
            this._2ptMissed.Name = "_2ptMissed";
            this._2ptMissed.Size = new System.Drawing.Size(113, 39);
            this._2ptMissed.TabIndex = 1;
            this._2ptMissed.Text = "Missed";
            this._2ptMissed.UseVisualStyleBackColor = false;
            this._2ptMissed.Click += new System.EventHandler(this._2ptMissed_Click);
            // 
            // _3ptMissed
            // 
            this._3ptMissed.BackColor = System.Drawing.Color.Firebrick;
            this._3ptMissed.Location = new System.Drawing.Point(378, 172);
            this._3ptMissed.Name = "_3ptMissed";
            this._3ptMissed.Size = new System.Drawing.Size(113, 39);
            this._3ptMissed.TabIndex = 3;
            this._3ptMissed.Text = "Missed";
            this._3ptMissed.UseVisualStyleBackColor = false;
            this._3ptMissed.Click += new System.EventHandler(this._3ptMissed_Click);
            // 
            // _3ptMade
            // 
            this._3ptMade.BackColor = System.Drawing.Color.ForestGreen;
            this._3ptMade.Location = new System.Drawing.Point(259, 172);
            this._3ptMade.Name = "_3ptMade";
            this._3ptMade.Size = new System.Drawing.Size(113, 39);
            this._3ptMade.TabIndex = 2;
            this._3ptMade.Text = "Made";
            this._3ptMade.UseVisualStyleBackColor = false;
            this._3ptMade.Click += new System.EventHandler(this._3ptMade_Click);
            // 
            // _FreeThrwMissed
            // 
            this._FreeThrwMissed.BackColor = System.Drawing.Color.Firebrick;
            this._FreeThrwMissed.Location = new System.Drawing.Point(625, 172);
            this._FreeThrwMissed.Name = "_FreeThrwMissed";
            this._FreeThrwMissed.Size = new System.Drawing.Size(113, 39);
            this._FreeThrwMissed.TabIndex = 5;
            this._FreeThrwMissed.Text = "Missed";
            this._FreeThrwMissed.UseVisualStyleBackColor = false;
            this._FreeThrwMissed.Click += new System.EventHandler(this._FreeThrwMissed_Click);
            // 
            // _FreeThrwMade
            // 
            this._FreeThrwMade.BackColor = System.Drawing.Color.ForestGreen;
            this._FreeThrwMade.Location = new System.Drawing.Point(506, 172);
            this._FreeThrwMade.Name = "_FreeThrwMade";
            this._FreeThrwMade.Size = new System.Drawing.Size(113, 39);
            this._FreeThrwMade.TabIndex = 4;
            this._FreeThrwMade.Text = "Made";
            this._FreeThrwMade.UseVisualStyleBackColor = false;
            this._FreeThrwMade.Click += new System.EventHandler(this._FreeThrwMade_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(106, 139);
            this.label1.MinimumSize = new System.Drawing.Size(40, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 30);
            this.label1.TabIndex = 6;
            this.label1.Text = "2pt";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(354, 139);
            this.label2.MinimumSize = new System.Drawing.Size(40, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 30);
            this.label2.TabIndex = 7;
            this.label2.Text = "3pt";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(583, 139);
            this.label3.MinimumSize = new System.Drawing.Size(40, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 30);
            this.label3.TabIndex = 8;
            this.label3.Text = "Free Throws";
            // 
            // _Rebound
            // 
            this._Rebound.Location = new System.Drawing.Point(9, 217);
            this._Rebound.Name = "_Rebound";
            this._Rebound.Size = new System.Drawing.Size(232, 56);
            this._Rebound.TabIndex = 9;
            this._Rebound.Text = "Rebound";
            this._Rebound.UseVisualStyleBackColor = true;
            this._Rebound.Click += new System.EventHandler(this._Rebound_Click);
            // 
            // _Block
            // 
            this._Block.Location = new System.Drawing.Point(263, 217);
            this._Block.Name = "_Block";
            this._Block.Size = new System.Drawing.Size(109, 56);
            this._Block.TabIndex = 10;
            this._Block.Text = "Block";
            this._Block.UseVisualStyleBackColor = true;
            this._Block.Click += new System.EventHandler(this._Block_Click);
            // 
            // _Assist
            // 
            this._Assist.Location = new System.Drawing.Point(378, 217);
            this._Assist.Name = "_Assist";
            this._Assist.Size = new System.Drawing.Size(109, 56);
            this._Assist.TabIndex = 11;
            this._Assist.Text = "Assist";
            this._Assist.UseVisualStyleBackColor = true;
            this._Assist.Click += new System.EventHandler(this._Assist_Click);
            // 
            // _Steal
            // 
            this._Steal.Location = new System.Drawing.Point(506, 217);
            this._Steal.Name = "_Steal";
            this._Steal.Size = new System.Drawing.Size(109, 56);
            this._Steal.TabIndex = 12;
            this._Steal.Text = "Steal";
            this._Steal.UseVisualStyleBackColor = true;
            this._Steal.Click += new System.EventHandler(this._Steal_Click);
            // 
            // _TurnOver
            // 
            this._TurnOver.Location = new System.Drawing.Point(625, 217);
            this._TurnOver.Name = "_TurnOver";
            this._TurnOver.Size = new System.Drawing.Size(109, 56);
            this._TurnOver.TabIndex = 13;
            this._TurnOver.Text = "Turn Over";
            this._TurnOver.UseVisualStyleBackColor = true;
            this._TurnOver.Click += new System.EventHandler(this._TurnOver_Click);
            // 
            // _player1
            // 
            this._player1.Location = new System.Drawing.Point(10, 280);
            this._player1.Name = "_player1";
            this._player1.Size = new System.Drawing.Size(139, 48);
            this._player1.TabIndex = 14;
            this._player1.Text = "player1";
            this._player1.UseVisualStyleBackColor = true;
            this._player1.Click += new System.EventHandler(this._player1_Click);
            // 
            // _player2
            // 
            this._player2.Location = new System.Drawing.Point(151, 280);
            this._player2.Name = "_player2";
            this._player2.Size = new System.Drawing.Size(139, 48);
            this._player2.TabIndex = 15;
            this._player2.Text = "player2";
            this._player2.UseVisualStyleBackColor = true;
            this._player2.Click += new System.EventHandler(this._player2_Click);
            // 
            // _player3
            // 
            this._player3.Location = new System.Drawing.Point(292, 280);
            this._player3.Name = "_player3";
            this._player3.Size = new System.Drawing.Size(139, 48);
            this._player3.TabIndex = 16;
            this._player3.Text = "player3";
            this._player3.UseVisualStyleBackColor = true;
            this._player3.Click += new System.EventHandler(this._player3_Click);
            // 
            // _player4
            // 
            this._player4.Location = new System.Drawing.Point(433, 280);
            this._player4.Name = "_player4";
            this._player4.Size = new System.Drawing.Size(139, 48);
            this._player4.TabIndex = 17;
            this._player4.Text = "player4";
            this._player4.UseVisualStyleBackColor = true;
            this._player4.Click += new System.EventHandler(this._player4_Click);
            // 
            // _player5
            // 
            this._player5.Location = new System.Drawing.Point(574, 280);
            this._player5.Name = "_player5";
            this._player5.Size = new System.Drawing.Size(139, 48);
            this._player5.TabIndex = 18;
            this._player5.Text = "player5";
            this._player5.UseVisualStyleBackColor = true;
            this._player5.Click += new System.EventHandler(this._player5_Click);
            // 
            // _player10
            // 
            this._player10.Location = new System.Drawing.Point(574, 334);
            this._player10.Name = "_player10";
            this._player10.Size = new System.Drawing.Size(139, 48);
            this._player10.TabIndex = 23;
            this._player10.Text = "player10";
            this._player10.UseVisualStyleBackColor = true;
            this._player10.Click += new System.EventHandler(this._player10_Click);
            // 
            // _player9
            // 
            this._player9.Location = new System.Drawing.Point(433, 334);
            this._player9.Name = "_player9";
            this._player9.Size = new System.Drawing.Size(139, 48);
            this._player9.TabIndex = 22;
            this._player9.Text = "player9";
            this._player9.UseVisualStyleBackColor = true;
            this._player9.Click += new System.EventHandler(this._player9_Click);
            // 
            // _player8
            // 
            this._player8.Location = new System.Drawing.Point(292, 334);
            this._player8.Name = "_player8";
            this._player8.Size = new System.Drawing.Size(139, 48);
            this._player8.TabIndex = 21;
            this._player8.Text = "player8";
            this._player8.UseVisualStyleBackColor = true;
            this._player8.Click += new System.EventHandler(this._player8_Click);
            // 
            // _player7
            // 
            this._player7.Location = new System.Drawing.Point(151, 334);
            this._player7.Name = "_player7";
            this._player7.Size = new System.Drawing.Size(139, 48);
            this._player7.TabIndex = 20;
            this._player7.Text = "player7";
            this._player7.UseVisualStyleBackColor = true;
            this._player7.Click += new System.EventHandler(this._player7_Click);
            // 
            // _player6
            // 
            this._player6.Location = new System.Drawing.Point(10, 334);
            this._player6.Name = "_player6";
            this._player6.Size = new System.Drawing.Size(139, 48);
            this._player6.TabIndex = 19;
            this._player6.Text = "player6";
            this._player6.UseVisualStyleBackColor = true;
            this._player6.Click += new System.EventHandler(this._player6_Click);
            // 
            // _player15
            // 
            this._player15.Location = new System.Drawing.Point(574, 388);
            this._player15.Name = "_player15";
            this._player15.Size = new System.Drawing.Size(139, 48);
            this._player15.TabIndex = 28;
            this._player15.Text = "player15";
            this._player15.UseVisualStyleBackColor = true;
            this._player15.Click += new System.EventHandler(this._player15_Click);
            // 
            // _player14
            // 
            this._player14.Location = new System.Drawing.Point(433, 388);
            this._player14.Name = "_player14";
            this._player14.Size = new System.Drawing.Size(139, 48);
            this._player14.TabIndex = 27;
            this._player14.Text = "player14";
            this._player14.UseVisualStyleBackColor = true;
            this._player14.Click += new System.EventHandler(this._player14_Click);
            // 
            // _player13
            // 
            this._player13.Location = new System.Drawing.Point(292, 388);
            this._player13.Name = "_player13";
            this._player13.Size = new System.Drawing.Size(139, 48);
            this._player13.TabIndex = 26;
            this._player13.Text = "player13";
            this._player13.UseVisualStyleBackColor = true;
            this._player13.Click += new System.EventHandler(this._player13_Click);
            // 
            // _player12
            // 
            this._player12.Location = new System.Drawing.Point(151, 388);
            this._player12.Name = "_player12";
            this._player12.Size = new System.Drawing.Size(139, 48);
            this._player12.TabIndex = 25;
            this._player12.Text = "player12";
            this._player12.UseVisualStyleBackColor = true;
            this._player12.Click += new System.EventHandler(this._player12_Click);
            // 
            // _player11
            // 
            this._player11.Location = new System.Drawing.Point(10, 388);
            this._player11.Name = "_player11";
            this._player11.Size = new System.Drawing.Size(139, 48);
            this._player11.TabIndex = 24;
            this._player11.Text = "player11";
            this._player11.UseVisualStyleBackColor = true;
            this._player11.Click += new System.EventHandler(this._player11_Click);
            // 
            // CurrentGameStatPnl
            // 
            this.CurrentGameStatPnl.AutoScroll = true;
            this.CurrentGameStatPnl.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.CurrentGameStatPnl.ColumnCount = 8;
            this.CurrentGameStatPnl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.98469F));
            this.CurrentGameStatPnl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.8541F));
            this.CurrentGameStatPnl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.94225F));
            this.CurrentGameStatPnl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.55015F));
            this.CurrentGameStatPnl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.473684F));
            this.CurrentGameStatPnl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.473684F));
            this.CurrentGameStatPnl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.815427F));
            this.CurrentGameStatPnl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.22314F));
            this.CurrentGameStatPnl.Controls.Add(this._PlayerNameDispaly, 0, 0);
            this.CurrentGameStatPnl.Controls.Add(this._StealsDisplay, 5, 0);
            this.CurrentGameStatPnl.Controls.Add(this._PointsDisplay, 1, 0);
            this.CurrentGameStatPnl.Controls.Add(this._AssistDisplay, 2, 0);
            this.CurrentGameStatPnl.Controls.Add(this._ReboundsDisplay, 3, 0);
            this.CurrentGameStatPnl.Controls.Add(this._BlocksDisplay, 4, 0);
            this.CurrentGameStatPnl.Controls.Add(this._TurnOversDisplay, 6, 0);
            this.CurrentGameStatPnl.Controls.Add(this._FieldGoalPercent, 7, 0);
            this.CurrentGameStatPnl.Location = new System.Drawing.Point(6, 6);
            this.CurrentGameStatPnl.Name = "CurrentGameStatPnl";
            this.CurrentGameStatPnl.RowCount = 15;
            this.CurrentGameStatPnl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.764706F));
            this.CurrentGameStatPnl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.411765F));
            this.CurrentGameStatPnl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.599936F));
            this.CurrentGameStatPnl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.674675F));
            this.CurrentGameStatPnl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.674675F));
            this.CurrentGameStatPnl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.674675F));
            this.CurrentGameStatPnl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.674675F));
            this.CurrentGameStatPnl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.674675F));
            this.CurrentGameStatPnl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.674675F));
            this.CurrentGameStatPnl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.674675F));
            this.CurrentGameStatPnl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.674675F));
            this.CurrentGameStatPnl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.674675F));
            this.CurrentGameStatPnl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.674675F));
            this.CurrentGameStatPnl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.674675F));
            this.CurrentGameStatPnl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.674675F));
            this.CurrentGameStatPnl.Size = new System.Drawing.Size(363, 425);
            this.CurrentGameStatPnl.TabIndex = 29;
            // 
            // _PlayerNameDispaly
            // 
            this._PlayerNameDispaly.AutoSize = true;
            this._PlayerNameDispaly.Location = new System.Drawing.Point(3, 0);
            this._PlayerNameDispaly.Name = "_PlayerNameDispaly";
            this._PlayerNameDispaly.Size = new System.Drawing.Size(64, 13);
            this._PlayerNameDispaly.TabIndex = 0;
            this._PlayerNameDispaly.Text = "PlayerName";
            // 
            // _StealsDisplay
            // 
            this._StealsDisplay.AutoSize = true;
            this._StealsDisplay.Location = new System.Drawing.Point(253, 0);
            this._StealsDisplay.Name = "_StealsDisplay";
            this._StealsDisplay.Size = new System.Drawing.Size(27, 13);
            this._StealsDisplay.TabIndex = 1;
            this._StealsDisplay.Text = "STL";
            // 
            // _PointsDisplay
            // 
            this._PointsDisplay.AutoSize = true;
            this._PointsDisplay.Location = new System.Drawing.Point(101, 0);
            this._PointsDisplay.Name = "_PointsDisplay";
            this._PointsDisplay.Size = new System.Drawing.Size(28, 13);
            this._PointsDisplay.TabIndex = 2;
            this._PointsDisplay.Text = "PTS";
            // 
            // _AssistDisplay
            // 
            this._AssistDisplay.AutoSize = true;
            this._AssistDisplay.Location = new System.Drawing.Point(142, 0);
            this._AssistDisplay.Name = "_AssistDisplay";
            this._AssistDisplay.Size = new System.Drawing.Size(28, 13);
            this._AssistDisplay.TabIndex = 3;
            this._AssistDisplay.Text = "AST";
            // 
            // _ReboundsDisplay
            // 
            this._ReboundsDisplay.AutoSize = true;
            this._ReboundsDisplay.Location = new System.Drawing.Point(180, 0);
            this._ReboundsDisplay.Name = "_ReboundsDisplay";
            this._ReboundsDisplay.Size = new System.Drawing.Size(29, 13);
            this._ReboundsDisplay.TabIndex = 4;
            this._ReboundsDisplay.Text = "REB";
            // 
            // _BlocksDisplay
            // 
            this._BlocksDisplay.AutoSize = true;
            this._BlocksDisplay.Location = new System.Drawing.Point(220, 0);
            this._BlocksDisplay.Name = "_BlocksDisplay";
            this._BlocksDisplay.Size = new System.Drawing.Size(27, 13);
            this._BlocksDisplay.TabIndex = 5;
            this._BlocksDisplay.Text = "BLK";
            // 
            // _TurnOversDisplay
            // 
            this._TurnOversDisplay.AutoSize = true;
            this._TurnOversDisplay.Location = new System.Drawing.Point(286, 0);
            this._TurnOversDisplay.Name = "_TurnOversDisplay";
            this._TurnOversDisplay.Size = new System.Drawing.Size(22, 13);
            this._TurnOversDisplay.TabIndex = 6;
            this._TurnOversDisplay.Text = "TO";
            // 
            // _FieldGoalPercent
            // 
            this._FieldGoalPercent.AutoSize = true;
            this._FieldGoalPercent.Location = new System.Drawing.Point(316, 0);
            this._FieldGoalPercent.Name = "_FieldGoalPercent";
            this._FieldGoalPercent.Size = new System.Drawing.Size(29, 13);
            this._FieldGoalPercent.TabIndex = 7;
            this._FieldGoalPercent.Text = "FG%";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(513, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 30;
            this.label5.Text = "label5";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.GameStats);
            this.tabControl1.Controls.Add(this.SeasonStats);
            this.tabControl1.Location = new System.Drawing.Point(740, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(383, 424);
            this.tabControl1.TabIndex = 31;
            // 
            // GameStats
            // 
            this.GameStats.Controls.Add(this.CurrentGameStatPnl);
            this.GameStats.Location = new System.Drawing.Point(4, 22);
            this.GameStats.Name = "GameStats";
            this.GameStats.Padding = new System.Windows.Forms.Padding(3);
            this.GameStats.Size = new System.Drawing.Size(375, 398);
            this.GameStats.TabIndex = 0;
            this.GameStats.Text = "Game";
            this.GameStats.UseVisualStyleBackColor = true;
            // 
            // SeasonStats
            // 
            this.SeasonStats.Controls.Add(this.tableLayoutPanel1);
            this.SeasonStats.Location = new System.Drawing.Point(4, 22);
            this.SeasonStats.Name = "SeasonStats";
            this.SeasonStats.Padding = new System.Windows.Forms.Padding(3);
            this.SeasonStats.Size = new System.Drawing.Size(375, 398);
            this.SeasonStats.TabIndex = 1;
            this.SeasonStats.Text = "Season";
            this.SeasonStats.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoScroll = true;
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tableLayoutPanel1.ColumnCount = 8;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.98469F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.8541F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.94225F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.55015F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.473684F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.473684F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.815427F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.22314F));
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label6, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.label7, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label8, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label9, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.label10, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.label11, 6, 0);
            this.tableLayoutPanel1.Controls.Add(this.label12, 7, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 6);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 15;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.764706F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.411765F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.599936F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.674675F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.674675F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.674675F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.674675F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.674675F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.674675F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.674675F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.674675F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.674675F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.674675F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.674675F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.674675F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(363, 425);
            this.tableLayoutPanel1.TabIndex = 32;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "PlayerName";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(253, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "STL";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(101, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(28, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "PTS";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(142, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(28, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "AST";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(180, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 13);
            this.label9.TabIndex = 4;
            this.label9.Text = "REB";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(220, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(27, 13);
            this.label10.TabIndex = 5;
            this.label10.Text = "BLK";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(286, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(22, 13);
            this.label11.TabIndex = 6;
            this.label11.Text = "TO";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(316, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(29, 13);
            this.label12.TabIndex = 7;
            this.label12.Text = "FG%";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1135, 450);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this._player15);
            this.Controls.Add(this._player14);
            this.Controls.Add(this._player13);
            this.Controls.Add(this._player12);
            this.Controls.Add(this._player11);
            this.Controls.Add(this._player10);
            this.Controls.Add(this._player9);
            this.Controls.Add(this._player8);
            this.Controls.Add(this._player7);
            this.Controls.Add(this._player6);
            this.Controls.Add(this._player5);
            this.Controls.Add(this._player4);
            this.Controls.Add(this._player3);
            this.Controls.Add(this._player2);
            this.Controls.Add(this._player1);
            this.Controls.Add(this._TurnOver);
            this.Controls.Add(this._Steal);
            this.Controls.Add(this._Assist);
            this.Controls.Add(this._Block);
            this.Controls.Add(this._Rebound);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this._FreeThrwMissed);
            this.Controls.Add(this._FreeThrwMade);
            this.Controls.Add(this._3ptMissed);
            this.Controls.Add(this._3ptMade);
            this.Controls.Add(this._2ptMissed);
            this.Controls.Add(this._2ptMade);
            this.Name = "Form1";
            this.Text = "Form1";
            this.CurrentGameStatPnl.ResumeLayout(false);
            this.CurrentGameStatPnl.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.GameStats.ResumeLayout(false);
            this.SeasonStats.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button _2ptMade;
        private System.Windows.Forms.Button _2ptMissed;
        private System.Windows.Forms.Button _3ptMissed;
        private System.Windows.Forms.Button _3ptMade;
        private System.Windows.Forms.Button _FreeThrwMissed;
        private System.Windows.Forms.Button _FreeThrwMade;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button _Rebound;
        private System.Windows.Forms.Button _Block;
        private System.Windows.Forms.Button _Assist;
        private System.Windows.Forms.Button _Steal;
        private System.Windows.Forms.Button _TurnOver;
        private System.Windows.Forms.Button _player1;
        private System.Windows.Forms.Button _player2;
        private System.Windows.Forms.Button _player3;
        private System.Windows.Forms.Button _player4;
        private System.Windows.Forms.Button _player5;
        private System.Windows.Forms.Button _player10;
        private System.Windows.Forms.Button _player9;
        private System.Windows.Forms.Button _player8;
        private System.Windows.Forms.Button _player7;
        private System.Windows.Forms.Button _player6;
        private System.Windows.Forms.Button _player15;
        private System.Windows.Forms.Button _player14;
        private System.Windows.Forms.Button _player13;
        private System.Windows.Forms.Button _player12;
        private System.Windows.Forms.Button _player11;
        private System.Windows.Forms.TableLayoutPanel CurrentGameStatPnl;
        private System.Windows.Forms.Label _PlayerNameDispaly;
        private System.Windows.Forms.Label _StealsDisplay;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label _PointsDisplay;
        private System.Windows.Forms.Label _AssistDisplay;
        private System.Windows.Forms.Label _ReboundsDisplay;
        private System.Windows.Forms.Label _BlocksDisplay;
        private System.Windows.Forms.Label _TurnOversDisplay;
        private System.Windows.Forms.Label _FieldGoalPercent;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage GameStats;
        private System.Windows.Forms.TabPage SeasonStats;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
    }
}

