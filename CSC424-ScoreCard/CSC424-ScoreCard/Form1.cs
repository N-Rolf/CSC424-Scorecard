using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSC424_ScoreCard
{
    public partial class Form1 : Form
    {
        Dictionary<string, PlayerStats> playerStats = new Dictionary<string, PlayerStats>();
        public Form1()
        {
            InitializeComponent();
            InitializePlayerStats();
        }
        private string selectedPlayerName;

        private void InitializePlayerStats()
        {
            for (int i = 1; i <= 15; i++)
            {
                string playerName = "Player " + i;
                playerStats.Add(playerName, new PlayerStats());
            }
        }

        private void UpdateGameStatTable()
        {
            // Clear existing rows
            GameStatTable.Rows.Clear();

            // Add rows for each player
            foreach (var playerStat in playerStats)
            {
                GameStatTable.Rows.Add(playerStat.Key,
                                      playerStat.Value.Points,
                                      playerStat.Value.Assists,
                                      playerStat.Value.Rebound,
                                      playerStat.Value.Steals,
                                      playerStat.Value.Blocks,
                                      playerStat.Value.Turnovers);
            }
        }
        //TODO Table NO longer subject to change.

        #region Shot made buttons

        #region 2pt make/miss Buttons

        //The label for homescore is lblHomeScore
        private void _2ptMade_Click(object sender, EventArgs e)
        {
            lblHomeScore.Text = (int.Parse(lblHomeScore.Text) + 2).ToString();
            playerStats[selectedPlayerName].Points += 2;
            UpdateGameStatTable();

        }

        private void _2ptMissed_Click(object sender, EventArgs e)
        {

        }
        #endregion

        #region 3pt make/miss buttons 
        private void _3ptMade_Click(object sender, EventArgs e)
        {
            lblHomeScore.Text = (int.Parse(lblHomeScore.Text) + 3).ToString();
            playerStats[selectedPlayerName].Points += 3;
            UpdateGameStatTable();
        }

        private void _3ptMissed_Click(object sender, EventArgs e)
        {

        }
        #endregion

        #region Freethrow make/miss

        private void _FreeThrwMade_Click(object sender, EventArgs e)
        {
            lblHomeScore.Text = (int.Parse(lblHomeScore.Text) + 1).ToString();
            playerStats[selectedPlayerName].Points += 1;
            UpdateGameStatTable();
        }

        private void _FreeThrwMissed_Click(object sender, EventArgs e)
        {

        }

        #endregion

        #endregion//end make/miss group

        #region REB, BLK, AST, STL, TO Buttons
        private void _Rebound_Click(object sender, EventArgs e)
        {
            playerStats[selectedPlayerName].Rebound += 1;
            UpdateGameStatTable();
        }

        private void _Block_Click(object sender, EventArgs e)
        {
            playerStats[selectedPlayerName].Blocks += 1;
            UpdateGameStatTable();
        }

        private void _Assist_Click(object sender, EventArgs e)
        {
            playerStats[selectedPlayerName].Assists += 1;
            UpdateGameStatTable();
        }

        private void _Steal_Click(object sender, EventArgs e)
        {
            playerStats[selectedPlayerName].Steals += 1;
            UpdateGameStatTable();
        }

        private void _TurnOver_Click(object sender, EventArgs e)
        {
            playerStats[selectedPlayerName].Turnovers += 1;
            UpdateGameStatTable();
        }
        #endregion


        #region player list

        #region players 1-7
        
        private void _player1_Click(object sender, EventArgs e)
        {
            //Rows can be updated with (Game/SeasonStatTable).RowCount = number; 
            //So rows can be added as you add players.
            Button clickedButton = (Button)sender;
            selectedPlayerName = "Player 1";

            UpdateGameStatTable();
        }

        private void _player2_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            selectedPlayerName = "Player 2";

            UpdateGameStatTable();
        }

        private void _player3_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            selectedPlayerName = "Player 3";

            UpdateGameStatTable();
        }

        private void _player4_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            selectedPlayerName = "Player 4";

            UpdateGameStatTable();
        }

        private void _player5_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            selectedPlayerName = "Player 5";

            UpdateGameStatTable();
        }

        private void _player6_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            selectedPlayerName = "Player 6";

            UpdateGameStatTable();

        }

        private void _player7_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            selectedPlayerName = "Player 7";

            UpdateGameStatTable();

        }
        #endregion
    

        #region players 8-15
        private void _player8_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            selectedPlayerName = "Player 8";

            UpdateGameStatTable();
        }

        private void _player9_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            selectedPlayerName = "Player 9";

            UpdateGameStatTable();
        }

        private void _player10_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            selectedPlayerName = "Player 10";

            UpdateGameStatTable();
        }

        private void _player11_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            selectedPlayerName = "Player 11";

            UpdateGameStatTable();
        }

        private void _player12_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            selectedPlayerName = "Player 12";

            UpdateGameStatTable();
        }

        private void _player13_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            selectedPlayerName = "Player 13";

            UpdateGameStatTable();
        }

        private void _player14_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            selectedPlayerName = "Player 14";

            UpdateGameStatTable();
        }

        private void _player15_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            selectedPlayerName = "Player 15";

            UpdateGameStatTable();
        }

        #endregion

        #endregion//end playerlist 

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        #region Opponent Score
        private void _oppnt2ptMade_Click(object sender, EventArgs e)
        {
            //the label for away score is lblAwayScore
            lblAwayScore.Text = (int.Parse(lblAwayScore.Text) + 2).ToString();
        }

        private void _oppnt3ptMade_Click(object sender, EventArgs e)
        {
            lblAwayScore.Text = (int.Parse(lblAwayScore.Text) + 3).ToString();
        }

        private void _oppntFreethrwMade_Click(object sender, EventArgs e)
        {
            lblAwayScore.Text = (int.Parse(lblAwayScore.Text) + 1).ToString();
        }
        #endregion

        public class PlayerStats
        {
            public int Rebound { get; set; }
            public int Assists { get; set; }
            public int Turnovers { get; set; }
            public int Steals { get; set; }
            public int Points { get; set; }
            public int Blocks { get; set; }
        }
    }
}
