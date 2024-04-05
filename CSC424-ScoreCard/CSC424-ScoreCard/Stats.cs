using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSC424_ScoreCard
{
    internal class Stats
    {
        private const string FileName = "user_history.txt";

        public static void SaveUserScore(string playerName, int points, int steals, int blocks, int assists, int rebound, int turnover)
        {
            Dictionary<string, List<HistoryEntry>> userHistory = LoadUserScores();

            if (!userHistory.ContainsKey(playerName))
            {
                userHistory[playerName] = new List<HistoryEntry>();
            }

            userHistory[playerName].Add(new HistoryEntry { Points = points, Steals = steals, Blocks = blocks, Assists = assists, Rebound = rebound, Turnover = turnover });

            SaveToFile(userHistory);
        }

        public static Dictionary<string, List<HistoryEntry>> LoadUserScores()
        {
            Dictionary<string, List<HistoryEntry>> userHistory = new Dictionary<string, List<HistoryEntry>>();

            if (File.Exists(FileName))
            {
                using (StreamReader reader = new StreamReader(FileName))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] parts = line.Split(',');
                        if (parts.Length >= 7) 
                        {
                            string playerName = parts[0];
                            int points = int.Parse(parts[1]);
                            int steals = int.Parse(parts[2]);
                            int blocks = int.Parse(parts[3]);
                            int assists = int.Parse(parts[4]);
                            int rebound = int.Parse(parts[5]);
                            int turnover = int.Parse(parts[6]);

                            if (!userHistory.ContainsKey(playerName))
                            {
                                userHistory[playerName] = new List<HistoryEntry>();
                            }

                            userHistory[playerName].Add(new HistoryEntry { Points = points, Steals = steals, Blocks = blocks, Assists = assists, Rebound = rebound, Turnover = turnover });
                        }
                    }
                }
            }

            return userHistory;
        }

        private static void SaveToFile(Dictionary<string, List<HistoryEntry>> userHistory)
        {
            using (StreamWriter writer = new StreamWriter(FileName))
            {
                foreach (var entry in userHistory)
                {
                    foreach (var historyEntry in entry.Value)
                    {
                        writer.WriteLine($"{entry.Key}, {historyEntry.Points}, {historyEntry.Steals}, {historyEntry.Blocks}, {historyEntry.Assists}, {historyEntry.Rebound}, {historyEntry.Turnover}");
                    }
                }
            }
        }
    }

    public class HistoryEntry
    {
        public int Points { get; set; }
        public int Steals { get; set; }
        public int Blocks { get; set; }
        public int Assists { get; set; }
        public int Rebound { get; set; }
        public int Turnover { get; set; }
    }
}
