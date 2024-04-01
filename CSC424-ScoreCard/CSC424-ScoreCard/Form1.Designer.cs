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
            this.label5 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.TabPanel = new System.Windows.Forms.TabControl();
            this.TabGameStats = new System.Windows.Forms.TabPage();
            this.GameStatTable = new System.Windows.Forms.DataGridView();
            this.TabSeasonStats = new System.Windows.Forms.TabPage();
            this.SeasonStatTable = new System.Windows.Forms.DataGridView();
            this.seasonPlayerNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.seasonPointsColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.seasonAssistColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.seasonReboundColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.seasonStealColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.seasonBlockColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.seasonTurnoverColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fieldGoalPercentColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gamePlayernameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gamePointsColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gameAssistsColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gameReboundsColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gameStealsColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gameBlocksColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gameTurnoversColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gameFieldGoalPercentColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TabPanel.SuspendLayout();
            this.TabGameStats.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GameStatTable)).BeginInit();
            this.TabSeasonStats.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SeasonStatTable)).BeginInit();
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
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(289, 40);
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
            // TabPanel
            // 
            this.TabPanel.Controls.Add(this.TabGameStats);
            this.TabPanel.Controls.Add(this.TabSeasonStats);
            this.TabPanel.Location = new System.Drawing.Point(740, 12);
            this.TabPanel.Name = "TabPanel";
            this.TabPanel.SelectedIndex = 0;
            this.TabPanel.Size = new System.Drawing.Size(383, 424);
            this.TabPanel.TabIndex = 31;
            // 
            // TabGameStats
            // 
            this.TabGameStats.Controls.Add(this.GameStatTable);
            this.TabGameStats.Location = new System.Drawing.Point(4, 22);
            this.TabGameStats.Name = "TabGameStats";
            this.TabGameStats.Padding = new System.Windows.Forms.Padding(3);
            this.TabGameStats.Size = new System.Drawing.Size(375, 398);
            this.TabGameStats.TabIndex = 0;
            this.TabGameStats.Text = "Game";
            this.TabGameStats.UseVisualStyleBackColor = true;
            // 
            // GameStatTable
            // 
            this.GameStatTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GameStatTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.gamePlayernameColumn,
            this.gamePointsColumn,
            this.gameAssistsColumn,
            this.gameReboundsColumn,
            this.gameStealsColumn,
            this.gameBlocksColumn,
            this.gameTurnoversColumn,
            this.gameFieldGoalPercentColumn});
            this.GameStatTable.Location = new System.Drawing.Point(0, 0);
            this.GameStatTable.Name = "GameStatTable";
            this.GameStatTable.Size = new System.Drawing.Size(375, 395);
            this.GameStatTable.TabIndex = 32;
            // 
            // TabSeasonStats
            // 
            this.TabSeasonStats.Controls.Add(this.SeasonStatTable);
            this.TabSeasonStats.Location = new System.Drawing.Point(4, 22);
            this.TabSeasonStats.Name = "TabSeasonStats";
            this.TabSeasonStats.Padding = new System.Windows.Forms.Padding(3);
            this.TabSeasonStats.Size = new System.Drawing.Size(375, 398);
            this.TabSeasonStats.TabIndex = 1;
            this.TabSeasonStats.Text = "Season";
            this.TabSeasonStats.UseVisualStyleBackColor = true;
            // 
            // SeasonStatTable
            // 
            this.SeasonStatTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SeasonStatTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.seasonPlayerNameColumn,
            this.seasonPointsColumn,
            this.seasonAssistColumn,
            this.seasonReboundColumn,
            this.seasonStealColumn,
            this.seasonBlockColumn,
            this.seasonTurnoverColumn,
            this.fieldGoalPercentColumn});
            this.SeasonStatTable.Location = new System.Drawing.Point(0, 0);
            this.SeasonStatTable.Name = "SeasonStatTable";
            this.SeasonStatTable.Size = new System.Drawing.Size(375, 395);
            this.SeasonStatTable.TabIndex = 33;
            // 
            // seasonPlayerNameColumn
            // 
            this.seasonPlayerNameColumn.HeaderText = "Player Name";
            this.seasonPlayerNameColumn.Name = "seasonPlayerNameColumn";
            this.seasonPlayerNameColumn.Width = 113;
            // 
            // seasonPointsColumn
            // 
            this.seasonPointsColumn.HeaderText = "PTS";
            this.seasonPointsColumn.Name = "seasonPointsColumn";
            this.seasonPointsColumn.Width = 30;
            // 
            // seasonAssistColumn
            // 
            this.seasonAssistColumn.HeaderText = "AST";
            this.seasonAssistColumn.Name = "seasonAssistColumn";
            this.seasonAssistColumn.Width = 30;
            // 
            // seasonReboundColumn
            // 
            this.seasonReboundColumn.HeaderText = "REB";
            this.seasonReboundColumn.Name = "seasonReboundColumn";
            this.seasonReboundColumn.Width = 32;
            // 
            // seasonStealColumn
            // 
            this.seasonStealColumn.HeaderText = "STL";
            this.seasonStealColumn.Name = "seasonStealColumn";
            this.seasonStealColumn.Width = 32;
            // 
            // seasonBlockColumn
            // 
            this.seasonBlockColumn.HeaderText = "BLK";
            this.seasonBlockColumn.Name = "seasonBlockColumn";
            this.seasonBlockColumn.Width = 32;
            // 
            // seasonTurnoverColumn
            // 
            this.seasonTurnoverColumn.HeaderText = "TO";
            this.seasonTurnoverColumn.Name = "seasonTurnoverColumn";
            this.seasonTurnoverColumn.Width = 32;
            // 
            // fieldGoalPercentColumn
            // 
            this.fieldGoalPercentColumn.DataPropertyName = "FieldGoal";
            this.fieldGoalPercentColumn.HeaderText = "FG%";
            this.fieldGoalPercentColumn.Name = "fieldGoalPercentColumn";
            this.fieldGoalPercentColumn.Width = 32;
            // 
            // gamePlayernameColumn
            // 
            this.gamePlayernameColumn.HeaderText = "Player Name";
            this.gamePlayernameColumn.Name = "gamePlayernameColumn";
            this.gamePlayernameColumn.Width = 113;
            // 
            // gamePointsColumn
            // 
            this.gamePointsColumn.HeaderText = "PTS";
            this.gamePointsColumn.Name = "gamePointsColumn";
            this.gamePointsColumn.Width = 30;
            // 
            // gameAssistsColumn
            // 
            this.gameAssistsColumn.HeaderText = "AST";
            this.gameAssistsColumn.Name = "gameAssistsColumn";
            this.gameAssistsColumn.Width = 30;
            // 
            // gameReboundsColumn
            // 
            this.gameReboundsColumn.HeaderText = "REB";
            this.gameReboundsColumn.Name = "gameReboundsColumn";
            this.gameReboundsColumn.Width = 32;
            // 
            // gameStealsColumn
            // 
            this.gameStealsColumn.HeaderText = "STL";
            this.gameStealsColumn.Name = "gameStealsColumn";
            this.gameStealsColumn.Width = 32;
            // 
            // gameBlocksColumn
            // 
            this.gameBlocksColumn.HeaderText = "BLK";
            this.gameBlocksColumn.Name = "gameBlocksColumn";
            this.gameBlocksColumn.Width = 32;
            // 
            // gameTurnoversColumn
            // 
            this.gameTurnoversColumn.HeaderText = "TO";
            this.gameTurnoversColumn.Name = "gameTurnoversColumn";
            this.gameTurnoversColumn.Width = 32;
            // 
            // gameFieldGoalPercentColumn
            // 
            this.gameFieldGoalPercentColumn.HeaderText = "FG%";
            this.gameFieldGoalPercentColumn.Name = "gameFieldGoalPercentColumn";
            this.gameFieldGoalPercentColumn.Width = 32;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1135, 450);
            this.Controls.Add(this.TabPanel);
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
            this.TabPanel.ResumeLayout(false);
            this.TabGameStats.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GameStatTable)).EndInit();
            this.TabSeasonStats.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SeasonStatTable)).EndInit();
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
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TabControl TabPanel;
        private System.Windows.Forms.TabPage TabGameStats;
        private System.Windows.Forms.TabPage TabSeasonStats;
        private System.Windows.Forms.DataGridView GameStatTable;
        private System.Windows.Forms.DataGridView SeasonStatTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn gamePlayernameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gamePointsColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gameAssistsColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gameReboundsColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gameStealsColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gameBlocksColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gameTurnoversColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gameFieldGoalPercentColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn seasonPlayerNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn seasonPointsColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn seasonAssistColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn seasonReboundColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn seasonStealColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn seasonBlockColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn seasonTurnoverColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fieldGoalPercentColumn;
    }
}

